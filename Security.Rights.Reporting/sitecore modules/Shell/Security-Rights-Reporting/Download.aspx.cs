using Security.Rights.Reporting.sitecore_modules.Shell.Security_Rights_Reporting.RightsData;
using Sitecore.Security.AccessControl;
using Sitecore.Security.Accounts;
using Sitecore.Syndication;
using System;
using System.Collections.Generic;

namespace Security.Rights.Reporting.Shell
{
    public partial class Download : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var export = Request.QueryString.Get("rolesexport");
            if (export == "1")
            {
                DownloadRolesExport();
            }
            else
            {
                Downloadrights();
            }
        }

        private void DownloadRolesExport()
        {
            var allright = CurrentRights.GetAllRightsMaster();
            var rols = Request.Form.Get("rol");
            if (rols != null)
            {
                foreach (var rol in rols.Split(','))
                {
                    var account = Sitecore.Security.Accounts.Role.FromName(rol);
                    if (account == null) break;
                    dowload.Text += "role," + account.Name + ",";
                    int count = 0;
                    foreach (var subrol in RolesInRolesManager.GetRolesInRole(account,false))
                    {
                        if (count != 0)
                        {
                            dowload.Text += "|";
                        }
                        dowload.Text += subrol.Name;
                        count++;
                    }
                    dowload.Text += "\n";
                }
                foreach (var rol in rols.Split(','))
                {
                    var account = Sitecore.Security.Accounts.Role.FromName(rol);
                    if (account == null) break;
                    foreach (var itemWithRights in allright)
                    {
                        var accessRules = itemWithRights.Security.GetAccessRules();
                        if (accessRules != null)
                        {
                            foreach (var rule in accessRules)
                            {
                                if (rule.Account == account)
                                {
                                    AccessRuleCollection ruleCollection = new AccessRuleCollection();
                                    ruleCollection.Add(rule);
                                    dowload.Text += itemWithRights.Paths.FullPath + "," + ruleCollection.ToString() + "\n";
                                }
                            }
                        }
                    }
                }
            }
            Response.Clear();
            Response.ContentType = "application/CSV";
            Response.AddHeader("Cache-Control", "must-revalidate");
            Response.AddHeader("Pragma", "must-revalidate");
            Response.AddHeader("Content-type", "application/x-download");
            Response.AddHeader("Content-disposition", "attachment; filename=sitecore-roles-export.csv");

        }

        public void Downloadrights()
        {
            if (UserInfo.CheckAccessRight())
            {
                string warning = string.Empty;
                string info = string.Empty;
                List<List<string>> usertabel = null;
                try
                {
                    usertabel = sitecore_modules.Shell.Security_Rights_Reporting.UserRightsClassicScreen.UserTabel(2000, out warning, out info);
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