using System;
using System.Collections.Generic;
using System.Linq;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Security.Accounts;
using Sitecore.Security.Domains;

namespace Security.Rights.Reporting.Shell
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CheckAccessRight())
            {
                var account = Request.QueryString.Get("account");
                if (string.IsNullOrEmpty(account))
                {
                    GetUserTabel();
                }
                else
                {
                    string defaultrights = "Hide default Sitecore rights";
                    string url = string.Format("account={0}&defaultright=off",account);
                    bool showdefaultrights = true;
                    if (Request.QueryString.Get("defaultright") == "off")
                    {
                        defaultrights = "Show default Sitecore rights";
                        url = string.Format("account={0}", account);
                        showdefaultrights = false;
                    }
                    userrights.Text = string.Format("<h2><a href=\"{0}\">Back</a> | <a href=\"#master\">Master</a> | <a href=\"?{1}\">{2}</a></h2>", Request.Path, url, defaultrights);
                    userrights.Text += string.Format("With this tool you view all the Access right set on Sitecore items, and see which are custom or default Sitecore, and get a warning as default Sitecore rights are lacking.<br/>Legenda: <span style=\"color:#008800;\">Green Right</span> is expected in Your Sitecore version: {0}<br>", Sitecore.Configuration.About.Version);
                    GetAccountRight(account, showdefaultrights);
                }
            }
            else
            {
                userlist.Text += "access denied";
            }
        }

        private void GetAccountRight(string account, bool showdefaultrights)
        {
            Database db = Sitecore.Configuration.Factory.GetDatabase("core");
            DisplayAccountRight(db, account, showdefaultrights);
            db = Sitecore.Configuration.Factory.GetDatabase("master");
            DisplayAccountRight(db, account, showdefaultrights);
        }

        private void DisplayAccountRight(Database db, string account, bool showdefaultrights)
        {
            if (account == "all")
            {
                userrights.Text += string.Format("<h2 id=\"{0}\">Item Rights set on all users and rols on {0} Database</h2>", db.Name);
            }
            else
            {
                userrights.Text += string.Format("<h2 id=\"{1}\">Item Rights set on account {0} on {1} Database</h2>", System.Web.HttpUtility.HtmlEncode(account), db.Name);
            }
            //We use a query instead of index search because, security field data is not in query, will be slower by large resultset.
            const string query = "fast://sitecore//*[@__Security != '' ]";

            var itemList = new List<Item>(db.SelectItems(query));
            var count = 0;

            string outmessage;
            var defaultRights = RightsData.RightsData.GetDefaultRights(db.Name, account, out outmessage);
            if (!string.IsNullOrEmpty(outmessage))
            {
                userrights.Text += "<p>" + outmessage + "</p>";
            }
            userrights.Text += "<table>";
            foreach (var item in itemList)
            {
                var accessRules = item.Security.GetAccessRules();
                if (accessRules != null)
                {
                    if (account == "devexport")
                    {
                        userrights.Text += string.Format(",new[] {{\"{0}\",@\"{1}\"}}\n<br>", item.Paths.FullPath, item.Fields["__Security"].Value);
                    }
                    else
                    {
                        foreach (var rule in accessRules)
                        {
                            var defaultRight = defaultRights.FirstOrDefault(x => x.Path == item.Paths.FullPath && x.Account == rule.Account.Name && x.Right == rule.SecurityPermission.ToString() && x.Name == rule.AccessRight.Name && x.PropagationType == rule.PropagationType.ToString());
                            var style = "";
                            var message = "";
                            if (defaultRight != null)
                            {
                                defaultRight.Hit = true;
                                style = " style=\"color:#008800;\" class=\"green\"";
                                message = string.Format(", ({0})", defaultRight.Message);
                                if (!showdefaultrights)
                                {
                                    continue;
                                }
                            }
                            if (rule.Account.Name == account)
                            {
                                userrights.Text += string.Format("<tr{3}><td>{0}</td><td>{1}</td><td>{6}</td><td>{2}{4}</td><td>{5}</tr>\n", item.Paths.FullPath, rule.AccessRight.Comment, rule.SecurityPermission, style, message, rule.PropagationType, rule.AccessRight.Name);
                                count++;
                            }
                            else if (account == "all")
                            {
                                userrights.Text += string.Format("<tr{4}><td>{0}</td><td>{1}</td><td>{7}</td><td>{2}{5}</td><td>{3}</td><td>{6}</tr>\n", item.Paths.FullPath, rule.Account.Name, rule.AccessRight.Comment, rule.SecurityPermission, style, message, rule.PropagationType, rule.AccessRight.Name);
                                count++;
                            }
                            else if (account == "alldevexport")
                            {
                                userrights.Text += string.Format(",new[] {{\"{0}\",\"{1}\",\"{2}\",\"{3}\"}}\n<br>", item.Paths.FullPath, rule.Account.Name.Replace("\\", "\\\\"), rule.SecurityPermission, rule.PropagationType);
                                count++;
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                if (showdefaultrights)
                {
                    userrights.Text += "<tr><td>No rights found in this Database for the user or role.</td></tr>";
                }
                else
                {
                    userrights.Text += "<tr><td>No custom rights found in this Database.</td></tr>";
                }
            }
            userrights.Text += "</table>";

            var warningRights = defaultRights.Where(x => x.Hit == false).ToList();
            if (warningRights.Any())
            {
                userrights.Text += "<br><span style=\"color:#880000;\">WARNING:</span> Expected rights not found:<br><table style=\"color:#880000;\">";
                foreach (var warningRight in warningRights)
                {
                    userrights.Text += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td></tr>\n", warningRight.Path, warningRight.Account, warningRight.Name,warningRight.Message, warningRight.Right, warningRight.PropagationType);
                }
                userrights.Text += "</table>";
            }
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

        public static List<List<string>> UserTabel(int maxusers, out string warning)
        {
            warning = string.Empty;
            var profileFinder = new UserProfileFinder();
            List<List<string>> usertabel = new List<List<string>>();
            IEnumerable<User> users;
            if (Sitecore.Security.Accounts.UserManager.Provider.GetUserCount() > maxusers)
            {
                warning += "To many users the user are filtered, show only the sitecore domain and the default sitecore users. ";
                var sitecoreDomain = Domain.GetDomain("sitecore");
                if (sitecoreDomain == null)
                {
                    users = new List<User>();
                    warning += "The sitecore domain is missing. ";
                }
                else
                {
                    users = sitecoreDomain.GetUsers().Take(maxusers);
                    if (users.Count() >= maxusers)
                    {
                        warning += "To many users in the Sitecore domain for this Tool, Take the first one and skip the rest, try the download link this has a higher limiet. ";
                    }
                }
                var defaultDomain = Domain.GetDomain("default");
                if (defaultDomain == null)
                {
                    warning += "The default domain is missing. ";
                }
                else
                {
                    var defaultUser = defaultDomain.GetUsers().Take(maxusers);
                    if (defaultUser == null || defaultUser.Count() == 0)
                    {
                        warning += "No users found in the default domain, expect Anonymous. ";
                    }
                    else
                    {
                        if (defaultUser.Count() >= maxusers)
                        {
                            warning +=
                                "To many users in the default domain for this Tool, Take the first one and skip the rest, try the download link this has a higher limiet. ";
                        }
                        users = users.Concat(defaultUser);
                    }
                }

                var webuser = Sitecore.Security.Accounts.User.FromName("extranet\\Anonymous",false);
                if (webuser != null)
                {
                    var x = new List<User>();
                    x.Add(webuser);
                    users = users.Concat(x);
                }   
            }
            else
            {
                users = Sitecore.Security.Accounts.UserManager.Provider.GetUsers();
            }
            if (users == null || users.Any() == false)
            {
                warning = "Error No Users";
                List<string> errorrow = new List<string> { "Error No Users. " };
                usertabel.Add(errorrow);
                return usertabel;
            }
            var allrols = Sitecore.Security.Accounts.RolesInRolesManager.GetAllRoles();
            if (allrols == null || allrols.Any() == false)
            {
                warning += "Error No Rols";
                List<string> errorrow = new List<string> { "Error No Rols. " };
                usertabel.Add(errorrow);
                return usertabel;
            }

            List<string> row0 = new List<string>();
            row0.Add("User");
            row0.Add("Comment");
            row0.Add("Locked");
            row0.Add("Username");
            row0.Add("Domain");
            row0.Add("Profile");
            row0.Add("Create date");
            row0.Add("Last login");
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
                var profileType = string.Empty;
                if (user.Profile != null)
                {
                    row.Add(user.Profile.Comment);
                    row.Add(user.Profile.State);
                    profileType = profileFinder.GetProfile(user.Profile.ProfileItemId);
                }
                else
                {
                    row.Add("&nbsp;");
                    row.Add("&nbsp;");
                }
                row.Add(user.LocalName);
                if (user.Domain != null)
                {
                    row.Add(user.Domain.Name);
                }
                else
                {
                    row.Add("&nbsp;");
                }
                var membershipUser = System.Web.Security.Membership.GetUser(user.Name, false);
                var createdate = string.Empty;
                var lastlogin = string.Empty;
                if (membershipUser != null)
                {
                    createdate = "<nobr>" + membershipUser.CreationDate.ToString("yyyy MMMM dd") + "</nobr>";
                    lastlogin = "<nobr>" + membershipUser.LastLoginDate.ToString("yyyy MMMM dd") + "</nobr>";
                }
                row.Add(profileType);
                row.Add(createdate);
                row.Add(lastlogin);
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
            var defaultRols = DefaultRols.GetDefaultRols();
            var defaultUsers = DefaultUsers.GetDefaultUsers();
            string warning;
            var usertabel = UserTabel(200, out warning);
            userlist.Text = "<Table class=\"table table-header-rotated\">";
            var linecount = 0;
            foreach (var tabelrow in usertabel)
            {
                userlist.Text += "<tr>";
                var rowcount = 0;
                foreach (var tabelfield in tabelrow)
                {
                    if (rowcount == 1)
                    {
                        //do nothings, skip comment, use this as optional title in the User column
                    }
                    else if (linecount == 0 && rowcount >= 9)
                    {
                        var style = "";
                        var defaultRol = defaultRols.SingleOrDefault(x => x.Rol == tabelfield);
                        if (defaultRol != null)
                        {
                            defaultRol.Hit = true;
                            style = " style=\"color:#008800;\"";
                        }
                        var comment = string.Empty;
                        DefaultRols.RolComment.TryGetValue(tabelfield, out comment);
                        userlist.Text += string.Format("<th class=\"rotate\"><div><span><a href=\"?account={0}\"{1} title=\"{2}\">{0}</a></span></div></th>", tabelfield, style, comment);
                    }
                    else if (linecount == 0)
                    {
                        userlist.Text += "<th class=\"norotate\" valign=\"bottom\"><div><span>" + tabelfield + "</span></div></th>";
                    }
                    else if (rowcount == 0)
                    {
                        var style = "";
                        var defaultUser = defaultUsers.SingleOrDefault(x => x.User == tabelfield);
                        if (defaultUser != null)
                        {
                            defaultUser.Hit = true;
                            style = " style=\"color:#008800;\"";
                        }
                        var comment = string.Empty;
                        if (!DefaultUsers.UserComment.TryGetValue(tabelfield, out comment))
                        {
                            if (tabelrow.Count > 1)
                            {
                                comment = tabelrow[1];
                            }
                        }
                        userlist.Text += string.Format("<td nowrap><a href=\"?account={0}\"{1} title=\"{2}\">{0}</a></td>", tabelfield, style, comment);
                    }
                    else if (rowcount >= 9)
                    {
                        userlist.Text += "<td nowrap class=\"xfield\">" + tabelfield + "</td>";
                    }                       
                    else
                    {
                        userlist.Text += "<td nowrap>" + tabelfield + "</td>";
                    }
                    rowcount++;
                }
                userlist.Text += "</tr>";
                linecount++;
            }
            userlist.Text += "</Table><p>With this tool you can view a all users and roles. It can be used to do audits. You can see which users and rols are custom or default Sitecore, and get reported as default Sitecore users or roles missing.</p>";
            if (!string.IsNullOrEmpty(warning))
            {
                userlist.Text += "<br><span style=\"color:#880000;\">WARNING: " + warning;
            }
            var warningRols = defaultRols.Where(x => x.Hit == false).ToList();
            if (warningRols.Any())
            {
                userlist.Text += "<br><span style=\"color:#880000;\">WARNING:</span> Expected rols not found: ";
                foreach (var warningRol in warningRols)
                {
                    userlist.Text += warningRol.Rol+" ";
                }
            }
            var warningUsers = defaultUsers.Where(x => x.Hit == false).ToList();
            if (warningUsers.Any())
            {
                userlist.Text += "<br><span style=\"color:#880000;\">WARNING:</span> Expected user not found: ";
                foreach (var warningUser in warningUsers)
                {
                    userlist.Text += warningUser.User + " ";
                }
            }
            userlist.Text += "<br><a href=\"?account=all\">Show all Right</a><br><a href=\"/sitecore modules/Shell/Security-Rights-Reporting/Download.aspx\">Download</a><br>Legenda: <span style=\"color:#008800;\">Green Rol / User</span> is expected in Your Sitecore version:" + Sitecore.Configuration.About.Version;
        }

    }
}