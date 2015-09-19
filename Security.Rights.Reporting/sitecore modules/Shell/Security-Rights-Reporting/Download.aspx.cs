using System;

namespace Security.Rights.Reporting.Shell
{
    public partial class Download : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserInfo.CheckAccessRight())
            {
                var usertabel = UserInfo.UserTabel();
                foreach (var tabelrow in usertabel)
                {
                    var rowcount = 0;
                    foreach (var tabelfield in tabelrow)
                    {
                        if (rowcount != 0)
                        {
                            dowload.Text += ",";
                        }
                        dowload.Text += string.Format("\"{0}\"", tabelfield.Replace("&nbsp;","").Replace("\"", "\"\""));
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