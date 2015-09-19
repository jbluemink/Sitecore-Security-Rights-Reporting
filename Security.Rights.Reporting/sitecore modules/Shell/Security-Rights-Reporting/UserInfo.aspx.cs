using System;
using System.Collections.Generic;
using System.Linq;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace Security.Rights.Reporting.Shell
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CheckAccessRight())
            {
                var account = Request.QueryString.Get("account");
                //account = "sitecore\\ed1";
                if (string.IsNullOrEmpty(account))
                {
                    GetUserTabel();
                }
                else
                {
                    userrights.Text = string.Format("<h2><a href=\"{0}\">Back</a></h2>", Request.Path);
                    GetAccountRight(account);
                }
            }
            else
            {
                userlist.Text += "access denied";
            }

        }

        private void GetAccountRight(string account)
        {
            Database db = Sitecore.Configuration.Factory.GetDatabase("core");
            DisplayAccountRight(db, account);
            db = Sitecore.Configuration.Factory.GetDatabase("master");
            DisplayAccountRight(db, account);

        }

        private void DisplayAccountRight(Database db, string account)
        {
            userrights.Text += string.Format("<h2>Item Rights set on account {0} on {1} Database</h2>", System.Web.HttpUtility.HtmlEncode(account), db.Name);
            const string query = "fast://sitecore//*[@__Security != '' ]";

            var itemList = new List<Item>(db.SelectItems(query));
            var count = 0;

            userrights.Text += "<table>";
            foreach (var item in itemList)
            {
                var accessRules = item.Security.GetAccessRules();
                if (accessRules != null)
                {
                    foreach (var rule in accessRules)
                    {
                        if (rule.Account.Name == account)
                        {
                            userrights.Text += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>\n", item.Paths.FullPath, rule.AccessRight.Comment, rule.SecurityPermission);
                            count++;
                        }
                        else if (account == "all")
                        {
                            userrights.Text += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td></tr>\n", item.Paths.FullPath, rule.Account.Name, rule.AccessRight.Comment, rule.SecurityPermission);
                            count++;
                        }
                    }
                }
            }
            if (count == 0)
            {
                userrights.Text += "<tr><td>No rights found in this Database for the user</td></tr>";
            }
            userrights.Text += "</table>";
        }

        public static bool CheckAccessRight()
        {
            if (Sitecore.Context.User.IsInRole("sitecore\\Sitecore Client Users"))
            {
                return true;
            }
            if (Sitecore.Context.User.IsAdministrator)
            {
                return true;
            }
            return false;

        }


        public static List<List<string>> UserTabel()
        {
            List<List<string>> usertabel = new List<List<string>>();
            var users = Sitecore.Security.Accounts.UserManager.GetUsers();
            if (users == null || users.Any() == false)
            {
                List<string> errorrow = new List<string> { "Error No Users" };
                usertabel.Add(errorrow);
                return usertabel;
            }
            var allrols = Sitecore.Security.Accounts.RolesInRolesManager.GetAllRoles();
            if (allrols == null || allrols.Any() == false)
            {
                List<string> errorrow = new List<string> { "Error No Rols" };
                usertabel.Add(errorrow);
                return usertabel;
            }

            List<string> row0 = new List<string>();
            row0.Add("User");
            row0.Add("Username");
            row0.Add("Domain");
            row0.Add("Admin");

            foreach (var rol in allrols)
            {
                row0.Add(rol.Name);
            }
            usertabel.Add(row0);

            foreach (var user in users)
            {
                List<string> row = new List<string>();
                row.Add(user.Name);
                row.Add(user.LocalName);
                if (user.Domain != null)
                {
                    row.Add(user.Domain.Name);
                }
                else
                {
                    row.Add("&nbsp;");
                }
                row.Add(user.IsAdministrator ? "*" : "&nbsp;");
                if (user.Roles != null)
                {
                    foreach (var rol in allrols)
                    {
                        if (rol != null && user.IsInRole(rol))
                        {
                            row.Add("X");
                        }
                        else
                        {
                            row.Add("&nbsp;");
                        }
                    }
                }
                usertabel.Add(row);
            }
            return usertabel;
        }

        void GetUserTabel()
        {
            var usertabel = UserTabel();
            userlist.Text = "<Table class=\"table table-header-rotated\">";
            var linecount = 0;
            foreach (var tabelrow in usertabel)
            {
                userlist.Text += "<tr>";
                var rowcount = 0;
                foreach (var tabelfield in tabelrow)
                {
                    if (linecount == 0 && rowcount >= 4)
                    {
                        userlist.Text += "<th class=\"rotate\"><div><span><a href=\"?account=" + tabelfield + "\">" + tabelfield + "</a></span></div></th>";
                    }
                    else if (linecount == 0)
                    {
                        userlist.Text += "<th class=\"norotate\" valign=\"bottom\"><div><span>" + tabelfield + "</span></div></th>";
                    }
                    else if (rowcount == 0)
                    {
                        userlist.Text += "<td><a href=\"?account=" + tabelfield + "\">" + tabelfield + "</a></td>";
                    }
                    else
                    {
                        userlist.Text += "<td>" + tabelfield + "</td>";
                    }
                    rowcount++;
                }
                userlist.Text += "</tr>";
                linecount++;
            }
            userlist.Text += "</Table><br><a href=\"?account=all\">Show all Right</a><br><a href=\"/sitecore modules/Shell/Security-Rights-Reporting/Download.aspx\">Download</a>";

        }

    }
}