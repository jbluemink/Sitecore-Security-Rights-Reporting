using System;
using System.Collections.Generic;

namespace Security.Rights.Reporting.Shell
{
    public partial class Download : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserInfo.CheckAccessRight())
            {
                string warning = string.Empty;
                string info = string.Empty;
                List<List<string>> usertabel = null;
                try
                {
                    usertabel = UserInfo.UserTabel(2000, out warning, out info);
                }
                catch (Exception ex)
                {
                    dowload.Text += warning + ex.ToString();
                    return;
                }
                if (!string.IsNullOrEmpty(warning))
                {
                    dowload.Text += warning + "\n";
                }
                if (usertabel == null || usertabel.Count <= 0)
                {
                    return;
                }
                foreach (var tabelrow in usertabel)
                {
                    var rowcount = 0;
                    if (tabelrow == null || tabelrow.Count <= 0)
                    {
                        continue;
                    }
                    foreach (var tabelfield in tabelrow)
                    {
                        if (rowcount != 0)
                        {
                            dowload.Text += ",";
                        }
                        if (string.IsNullOrEmpty(tabelfield))
                        {
                            dowload.Text += "";
                        }
                        else
                        {
                            dowload.Text += string.Format("\"{0}\"",
                                tabelfield.Replace("&nbsp;", "")
                                    .Replace("\"", "\"\"")
                                     .Replace("?EVERYONE?", "")
                                    .Replace("<nobr>", "")
                                    .Replace("</nobr>", ""));
                        }
                        rowcount++;
                    }
                    dowload.Text += "\n";
                }
            }
            Response.Clear();
            Response.ContentType = "application/CSV";
            Response.AddHeader("Cache-Control", "must-revalidate");
            Response.AddHeader("Pragma", "must-revalidate");
            Response.AddHeader("Content-type", "application/vnd.ms-excel");
            Response.AddHeader("Content-disposition", "attachment; filename=sitecore-users.csv");
        }
    }
}