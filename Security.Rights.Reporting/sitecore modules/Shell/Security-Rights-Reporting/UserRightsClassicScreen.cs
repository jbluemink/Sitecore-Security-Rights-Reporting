using Security.Rights.Reporting.Shell;
using Sitecore.Security.Accounts;
using Sitecore.Security.Domains;
using Sitecore.SecurityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Security.Rights.Reporting.sitecore_modules.Shell.Security_Rights_Reporting
{
    public static class UserRightsClassicScreen
    {

        #region User / domain screen
        public static List<List<string>> UserTabel(int maxusers, out string warning, out string info)
        {
            warning = string.Empty;
            info = string.Empty;

            var profileFinder = new UserProfileFinder();
            List<List<string>> usertabel = new List<List<string>>();
            IEnumerable<User> users;
            var totaluser = Sitecore.Security.Accounts.UserManager.GetUserCount();
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

                var webuser = Sitecore.Security.Accounts.User.FromName("extranet\\Anonymous", false);
                if (webuser != null)
                {
                    var x = new List<User>();
                    x.Add(webuser);
                    users = users.Concat(x);
                }
            }
            else
            {
                users = Sitecore.Security.Accounts.UserManager.GetUsers();
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
                    row0.Add(rol.Name + "?EVERYONE?");
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

        public static void GetUserTabel(Literal userlist)
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
                        var rolfield = tabelfield.Replace("?EVERYONE?", "");
                        var defaultRol = defaultRols.SingleOrDefault(x => x.Rol == rolfield);
                        if (defaultRol != null)
                        {
                            defaultRol.Hit = true;
                            style = " style=\"color:#008800;\"";
                        }
                        string comment;
                        DefaultRols.RolComment.TryGetValue(rolfield, out comment);
                        userlist.Text += string.Format("<th class=\"rotate\"><div><span><a href=\"?account={0}&t=d\"{1} title=\"{2}\">{0}</a>{3}</span></div></th>", rolfield, style, comment, note);
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
                    userlist.Text += warningRol.Rol + " ";
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

            userlist.Text += "<p><a href=\"?account=all\">Show all Right</a><br><a href=\"/sitecore modules/Shell/Security-Rights-Reporting/Download.aspx\">Download</a><br/><a href=\"?\">Simple Account list</a><br>";
            userlist.Text += "<a href=\"?rolesexport=step1\">Export Roles and Right</a><br><a href=\"?rolesexport=import1\">Import Roles and Right</a></p>";
            userlist.Text += "<p><strong>Legenda:</strong><br>X Role is assigned to user<br>* isAdmin<br>*e Everyone role (can only assign to a item, All users are assigned to the Everyone role)<br><span style=\"color:#008800;\">Green Role / User</span> is expected in Your Sitecore version:" + Sitecore.Configuration.About.Version + "</p>";
        }
        #endregion
    }
}