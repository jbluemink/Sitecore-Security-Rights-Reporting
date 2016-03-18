using System;
using System.Collections.Generic;
using System.Linq;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Security.Accounts;
using Sitecore.Security.Domains;
using Sitecore.SecurityModel;

namespace Security.Rights.Reporting.Shell
{
    public partial class UserInfo : System.Web.UI.Page
    {
        #region page load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CheckAccessRight())
            {
                var account = Request.QueryString.Get("account");
                var mode = Request.QueryString.Get("mode");
                if (!string.IsNullOrEmpty(mode))
                {
                    ApplicationSetup(mode);
                }
                else if (string.IsNullOrEmpty(account))
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
                    userrights.Text += string.Format("With this tool you view all the Access right set on Sitecore items, and see which are custom or default Sitecore, and get a warning as default Sitecore rights are lacking.<br/>Legenda:<br/>Black Right is custom<br /><span style=\"color:#880000;\">Red Right</span> is missing<br /><span style=\"color:#FFA500;\">Orange Right</span> account not found, Note: $currentuser is a valid token for a __Standard Values item or a Branche template<br /><span style=\"color:#008800;\">Green Right</span> is expected in Your Sitecore version: {0}<br>", Sitecore.Configuration.About.Version);
                    GetAccountRight(account, showdefaultrights);
                }
            }
            else
            {
                userlist.Text += "access denied";
            }
        }
#endregion

        #region setup

        private void ApplicationSetup(string mode)
        {
            if (CheckSetupRights())
            {
                if (mode == "uninstall")
                {
                    userlist.Text +=
                        "<h1>Uninstall the Security Rights Reporting Module</h1><p>Are you sure you want to delete the Security Rights Reporting Module? <a href=\"?mode=unistallyes\">Yes remove</a> - <a href=\"?\">No cancel</a>";
                }
                else if (mode == "unistallyes")
                {
                    DeleteFileFromWebroot("~\\App_Config\\Include\\Security.Rights.Reporting.Module.config");
                    DeleteFileFromWebroot("~\\bin\\Security.Rights.Reporting.dll");
                    DeleteFileFromWebroot("~\\sitecore modules\\Shell\\Security-Rights-Reporting\\Download.aspx");
                    DeleteFileFromWebroot("~\\sitecore modules\\Shell\\Security-Rights-Reporting\\UserInfo.aspx");
                    DeleteDirectoryFromWebroot("~\\sitecore modules\\Shell\\Security-Rights-Reporting");
                    DeleteSitecoreCoreItem("/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Security Tools/Userinfo");
                    DeleteSitecoreCoreItem( "/sitecore/content/Documents and settings/All users/Start menu/Right/Security Tools/Security Reporting");
                    DeleteSitecoreCoreItem("/sitecore/content/Applications/Security Reporting");


                    userlist.Text +=
                        "<p>The Security Rights Reporting Module is removed, Thank you for using <a href=\"javascript:window.close()\">Close</a>";
                }
            }
            else
            {
                userlist.Text += "access denied, you need Development or Admin rights";
            }
        }

        private void DeleteFileFromWebroot(string file)
        {
            
            userlist.Text += "<br>Delete File "+file;
            try
            {
                var path = Server.MapPath(file);
                System.IO.File.Delete(path);
            }
            catch (Exception e)
            {
                userlist.Text += "<br><strong>Error</strong> delete dir " + file;
                userlist.Text += string.Format("<p>{0}</p>",e);
            }
        }

        private void DeleteDirectoryFromWebroot(string dir)
        {

            userlist.Text += "<br>Delete Directory " + dir;
            try
            {
                var path = Server.MapPath(dir);
                System.IO.Directory.Delete(path);
            }
            catch (Exception e)
            {
                userlist.Text += "<br><strong>Error</strong> delete Directory " + dir;
                userlist.Text += string.Format("<p>{0}</p>", e);
            }
        }

        private void DeleteSitecoreCoreItem(string itempath)
        {

            userlist.Text += "<br>Delete Sitecore Item " + itempath;
            try
            {
                var db = Sitecore.Configuration.Factory.GetDatabase("core");
                var item = db.GetItem(itempath);
                if (item != null && !item.Empty)
                {
                    item.Delete();
                }
                else
                {
                    userlist.Text += "<br><strong>Warning</strong> Sitecore Item not found " + itempath;
                }
            }
            catch (Exception e)
            {
                userlist.Text += "<br><strong>Error</strong> delete Sitecore Item " + itempath;
                userlist.Text += string.Format("<p>{0}</p>", e);
            }
        }
        #endregion

        private void GetAccountRight(string account, bool showdefaultrights)
        {
            Database db = Sitecore.Configuration.Factory.GetDatabase("core");
            DisplayAccountRight(db, account, showdefaultrights);
            db = Sitecore.Configuration.Factory.GetDatabase("master");
            DisplayAccountRight(db, account, showdefaultrights);
        }

        #region Account rights screen
        private void DisplayAccountRight(Database db, string account, bool showdefaultrights)
        {
            if (account == "all")
            {
                userrights.Text += string.Format("<h2 id=\"{0}\">Item Rights set on all users and roles on {0} Database</h2>", db.Name);
            }
            else
            {
                userrights.Text += string.Format("<h2 id=\"{1}\">Item Rights set on account {0} on {1} Database</h2>", System.Web.HttpUtility.HtmlEncode(account), db.Name);
            }
            //We use a query instead of index search because, security field data is not in query, will be slower by large resultset.
            //const string query = "fast://sitecore//*[@__Security != '' ]";

            //var itemList = new List<Item>(db.SelectItems(query));
            var root = db.GetItem("/sitecore");
            var itemList = root.Axes.GetDescendants().ToList();
            itemList.Insert(0, root);

            var count = 0;

            var checkAccount = new CheckAccount();

            string outmessage;
            var defaultRights = RightsData.RightsData.GetDefaultRights(db.Name, account, out outmessage);
            if (!string.IsNullOrEmpty(outmessage))
            {
                userrights.Text += "<p>" + outmessage + "</p>";
            }
            userrights.Text += "<table id=\"table-accountrights\">";
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
                            var accountExsist = true;
                            if (rule.Account.AccountType == AccountType.Role)
                            {
                                accountExsist = checkAccount.IsRolExsisting(rule.Account.Name);
                            }
                            else
                            {
                                accountExsist = checkAccount.IsUserExsisting(rule.Account.Name);
                            }
                            if (!accountExsist)
                            {
                                message += ", Account unknown";
                                style = " style=\"color:#FFA500;\" class=\"orange\"";
                            }

                            if (rule.Account.Name == account)
                            {
                                userrights.Text += string.Format("<tr{3}><td>{0}</td><td>{1}</td><td>{6}</td><td>{2}{4}</td><td>{5}</td></tr>\n", item.Paths.FullPath, rule.AccessRight.Comment, rule.SecurityPermission, style, message, rule.PropagationType, rule.AccessRight.Name);
                                count++;
                            }
                            else if (account == "all")
                            {
                                userrights.Text += string.Format("<tr{4}><td>{0}</td><td>{8} : {1}</td><td>{7}</td><td>{2}{5}</td><td>{3}</td><td>{6}</td></tr>\n", item.Paths.FullPath, rule.Account.Name, rule.AccessRight.Comment, rule.SecurityPermission, style, message, rule.PropagationType, rule.AccessRight.Name, rule.Account.AccountType.ToString());
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
        #endregion

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

        //for uninstalling
        public static bool CheckSetupRights()
        {
            if (Sitecore.Context.User.IsInRole("sitecore\\Developer"))
            {
                return true;
            }
            if (Sitecore.Context.User.IsAdministrator)
            {
                return true;
            }
            return false;
        }


        #region User / domain screen
        public static List<List<string>> UserTabel(int maxusers, out string warning, out string info)
        {
            warning = string.Empty;
            info = string.Empty;

            var profileFinder = new UserProfileFinder();
            List<List<string>> usertabel = new List<List<string>>();
            IEnumerable<User> users;
            var totaluser = Sitecore.Security.Accounts.UserManager.Provider.GetUserCount();
            info = string.Format("Total real Membership users is {0} (sitecore\\Anonymous does not count)", totaluser);
            if (totaluser > maxusers)
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
                    var totalsitecoreusers = sitecoreDomain.GetUserCount();
                    info += " Total Users in Sitecore Domain is " + totalsitecoreusers;
                    users = sitecoreDomain.GetUsers().Take(maxusers);
                    if (users.Count() < totalsitecoreusers)
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

            //Add the sitecore Anonymous
            var sDomain = Domain.GetDomain("sitecore");
            if (sDomain != null)
            {
                var sAnony = sDomain.GetAnonymousUser();
                if (sAnony != null)
                {
                    var xan = new List<User>();
                    xan.Add(sAnony);
                    users = users.Concat(xan);
                }
            }

            var allnormalroles = Sitecore.Security.Accounts.RolesInRolesManager.GetAllRoles();
            if (allnormalroles == null || allnormalroles.Any() == false)
            {
                warning += "Error No Roles";
                List<string> errorrow = new List<string> { "Error No Roles. " };
                usertabel.Add(errorrow);
                return usertabel;
            }
            var allrols = allnormalroles.ToList();

            foreach (var d in DomainManager.GetDomains())
            {
                var every = d.GetEveryoneRole();
                if (every != null)
                {
                    allrols.Add(every);
                }
            }
            var roleEveryone = Sitecore.Security.Accounts.Role.FromName("Everyone");
            if (roleEveryone != null)
            {
                allrols.Add(roleEveryone);
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
                if (rol.IsEveryone)
                {
                    row0.Add(rol.Name+"?EVERYONE?");
                }
                else
                {
                    row0.Add(rol.Name);
                }
                
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
                        else if (rol != null && rol.IsEveryone && (rol.Domain == user.Domain || rol.Domain == null))
                        {
                            row.Add("*e");
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
            string info;
            var usertabel = UserTabel(200, out warning, out info);
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
                        var note = "";
                        if (tabelfield.EndsWith("?EVERYONE?"))
                        {
                            note = " *e";
                        }
                        var rolfield = tabelfield.Replace("?EVERYONE?","");
                        var defaultRol = defaultRols.SingleOrDefault(x => x.Rol == rolfield);
                        if (defaultRol != null)
                        {
                            defaultRol.Hit = true;
                            style = " style=\"color:#008800;\"";
                        }
                        string comment;
                        DefaultRols.RolComment.TryGetValue(rolfield, out comment);
                        userlist.Text += string.Format("<th class=\"rotate\"><div><span><a href=\"?account={0}&t=d\"{1} title=\"{2}\">{0}</a>{3}</span></div></th>", rolfield, style, comment,note);
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
                        string comment;
                        if (!DefaultUsers.UserComment.TryGetValue(tabelfield, out comment))
                        {
                            if (tabelrow.Count > 1)
                            {
                                comment = tabelrow[1];
                            }
                        }
                        userlist.Text += string.Format("<td nowrap><a href=\"?account={0}&t=u\"{1} title=\"{2}\">{0}</a></td>", tabelfield, style, comment);
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
            userlist.Text += "<tr><td><a href=\"?account=$currentuser&t=u\" title=\"replace token for Standard value\">$currentuser</a></td><td style=\"text-align: left\" colspan=\"25\" align=\"left\">Not a real user but a Sitecore replace token, can be used for item rights on __Standard Values or Branches, but no roles</td></tr>";
            userlist.Text += "</Table><p>With this tool you can view a all users and roles. It can be used to do audits. You can see which users and roles are custom or default Sitecore, and get reported as default Sitecore users or roles missing.<br>" + info + "</p>";
            if (!string.IsNullOrEmpty(warning))
            {
                userlist.Text += "<br><span style=\"color:#880000;\">WARNING: " + warning;
            }
            var warningRols = defaultRols.Where(x => x.Hit == false).ToList();
            if (warningRols.Any())
            {
                userlist.Text += "<br><span style=\"color:#880000;\">WARNING:</span> Expected roles not found: ";
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
            userlist.Text += "<p><a href=\"?account=all\">Show all Right</a><br><a href=\"/sitecore modules/Shell/Security-Rights-Reporting/Download.aspx\">Download</a></p><p><strong>Legenda:</strong><br>X Role is assigned to user<br>* isAdmin<br>*r Everyone role (can only assign to a item, All users are assigned to the Everyone role)<br><span style=\"color:#008800;\">Green Role / User</span> is expected in Your Sitecore version:" + Sitecore.Configuration.About.Version+"</p>";
        }
#endregion
    }
}