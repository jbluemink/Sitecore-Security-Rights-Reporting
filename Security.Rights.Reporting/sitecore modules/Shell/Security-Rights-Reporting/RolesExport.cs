using Security.Rights.Reporting.sitecore_modules.Shell.Security_Rights_Reporting.RightsData;
using Sitecore.Data.Items;
using Sitecore.Security.AccessControl;
using Sitecore.SecurityModel;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Razor.Editor;
using System.Web.UI.WebControls;
using Sitecore.Security.Accounts;
using System.Web.Security;

namespace Security.Rights.Reporting.sitecore_modules.Shell.Security_Rights_Reporting
{
    public static class RolesExport
    {
        public static void ExportWizard(HttpRequest request, Literal rolesexport, string step)
        {
            rolesexport.Text += string.Format("<p><a href=\"?\">Back</a> | <a href=\"?classic=1\">Back to Classic</a></p>");

            if (step == "step1")
            {
                Step1(rolesexport);
            }
            if (step == "step2")
            {
                Step2(request, rolesexport);
            }
            if (step == "import1")
            {
                Import1(rolesexport);
            }
            if (step == "import2")
            {
                Import2(request, rolesexport);
            }
         }

        private static void Step1(Literal rolesexport)
        {
            rolesexport.Text += "<h1>Export Roles with the Rights set on Items </h1>";
            rolesexport.Text += "<p>With this export roles tool you can export one or more roles including all item rights that are set. This tool can help to move your rights through the DTAP-street. At the import rules are created if they not exist already. Items are matched by the item path, not the id. Only the security field is modified, and only the rights for the selected roles, rights are only added, rights not in the export will not modify or delete. Note only items in the master database. Note, if you only want to export the rules without rights, you can use a normal Sitecore Package.<p>";
            rolesexport.Text += "<strong>Select Roles</strong><br/><form method=\"post\" action=\"?rolesexport=step2\">";
            var allnormalroles = Sitecore.Security.Accounts.RolesInRolesManager.GetAllRoles();
            if (allnormalroles == null || allnormalroles.Any() == false)
            {
                rolesexport.Text += "Error No Roles</form>";

                return;
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
            foreach (var rol in allrols)
            {
                //note: trust the role name, it should not contain wierd, breaking characters.
                rolesexport.Text += "<input type=\"checkbox\" id=\""
                    + rol.Name + "\" name=\"rol\" value=\"" + HttpUtility.HtmlAttributeEncode(rol.Name) + "\" >" + rol.Name + "<br/>";
            }
            rolesexport.Text += "<input type=\"submit\" name=\"Submit\" value=\"Preview\"></form>";
        }

        private static void Step2(HttpRequest request, Literal rolesexport)
        {
            rolesexport.Text += "Export preview<br><br>";
            var allright = CurrentRights.GetAllRightsMaster();
            var rols = request.Form.Get("rol");
            if (rols != null)
            {
                foreach (var rol in rols.Split(','))
                {
                    rolesexport.Text += "<strong>" + rol + "</strong>  :<br> ";
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
                                    rolesexport.Text += itemWithRights.Paths.FullPath + " " + RightsHelper.RightToHtml(rule) + " " + rule.AccessRight.Name + " " + rule.SecurityPermission.ToString() + "<br>";
                                }
                            }
                        }
                    }
                    rolesexport.Text += "<br>\n";
                }
                rolesexport.Text += "<form method=\"post\" action=\"/sitecore modules/Shell/Security-Rights-Reporting/Download.aspx?rolesexport=1\" enctype=\"multipart/form-data\"><input type=\"hidden\" id=\"rol\" name=\"rol\" value=\"" + "" + HttpUtility.HtmlAttributeEncode(rols) + "\"><input type=\"submit\" value=\"Download\" name=\"submit\" ></form>";
            }
        }

        private static void Import1(Literal rolesexport)
        {
            rolesexport.Text += "<p>With this import roles tool you can import the roles including all item rights that are set. This tool can help to move your rights through the DTAP-street. At the import rules are created if they not exist already. Items are matched by the item path, not the id. Only the security field is modified, and only the rights for the selected roles, rights are only added, rights not in the export will not modify or delete. Note, if you only want to export the rules without rights, you can use a normal Sitecore Package.<p>";

            if (CheckOnManagingRights())
            {
                rolesexport.Text += "<b>Select an export file</b> generated with the Security Rights Reporting Export Roles with the Rights tool";
                rolesexport.Text += "<form method=\"post\" action=\"?rolesexport=import2\" enctype=\"multipart/form-data\"><input type=\"file\" name=\"fileToUpload\" id=\"fileToUpload\" ><input type=\"submit\" value=\"Upload\" name=\"submit\" ></form>";
            } else
            {
                rolesexport.Text += "You need Sitecore Client Securing right for Importing Riols and Users, the follow rol should work:  Developer, Admin, Client Account Managing or Client Securing right";
            }
        }
        private static void Import2(HttpRequest request, Literal rolesexport)
        {
            if (!CheckOnManagingRights())
            {
                rolesexport.Text += "You need Sitecore Client Securing right for Importing Riols and Users, the follow rol should work:  Developer, Admin, Client Account Managing or Client Securing right";
                return;
            }

            var file = request.Files.Get("fileToUpload");           
            if (file == null || file.ContentLength == 0) {
                rolesexport.Text += "Select an import csv file.<br/>";
                Import1(rolesexport);
                return;
            }
            rolesexport.Text += "Import size=" + file.ContentLength +" characters<br/>";
            var db = Sitecore.Configuration.Factory.GetDatabase("master");
            var updatecount = 0;
            var newcount = 0;
            List<string> rolsPostponedProcess = new List<string>();
            using (StreamReader reader = new StreamReader(file.InputStream))
            {
                string line;
                int count = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    count++;
                    var splitted = line.Split(',');
                    if (splitted.Length == 3 && splitted[0] == "role")
                    {
                        if(!Sitecore.Security.Accounts.Role.Exists(splitted[1])) {
                            try
                            {
                                Roles.CreateRole(splitted[1]);
                                rolesexport.Text += "<br>rol created" + HttpUtility.HtmlEncode(splitted[1]);
                                if (!string.IsNullOrEmpty(splitted[0]))
                                {
                                    rolsPostponedProcess.Add(line);
                                }
                            } catch
                            {
                                rolesexport.Text += "<br>Error cannot create rol " + HttpUtility.HtmlEncode(splitted[1]);
                            }
                        }
                    }
                    else   if (splitted.Length == 2)
                    {
                        if (rolsPostponedProcess.Any())
                        {
                            CreateRolInRols(rolsPostponedProcess);
                            rolsPostponedProcess = new List<string>();
                        }
                        Item item = db.GetItem(splitted[0]);
                        if (item == null)
                        {
                            rolesexport.Text += "<br>Error unknow item path or no read rights" + HttpUtility.HtmlEncode(splitted[0]);
                        } else
                        {
                            var accessRules = item.Security.GetAccessRules();
                            var rules = AccessRuleCollection.FromString(splitted[1]);
                            if (rules != null)
                            {
                                if (item.Access.CanWrite())
                                {
                                    foreach (var rule in rules)
                                    {
                                        if (accessRules.Contains(rule))
                                        {
                                            accessRules.Remove(rule);
                                            updatecount++;
                                        } else
                                        {
                                            newcount++;
                                        }
                                        accessRules.Add(rule);
                                    }
                                    item.Editing.BeginEdit();
                                    item.Security.SetAccessRules(accessRules);
                                    item.Editing.EndEdit();
                                    rolesexport.Text += "<br>" + HttpUtility.HtmlEncode(splitted[0]) + "  =  " + HttpUtility.HtmlEncode(item.Fields["__Security"].Value);
                                }
                                else
                                {
                                    rolesexport.Text += "<br><span style=\"color:#880000;\">Skipped: No write Access for " + HttpUtility.HtmlEncode(splitted[0]) + "  =  " + HttpUtility.HtmlEncode(item.Fields["__Security"].Value)+ "<span>";
                                }
                            }
                        }
                    } else
                    {
                        rolesexport.Text += "<br>Error unknow line " + count + " : " + line;
                    }
                }
            }
            rolesexport.Text += "<p>Rights are imported, new rights " + newcount + " updated rights " + updatecount + "<br>Remember nothing is deleted, only the items that are in the import file are affected </p>";
        }

        private static void CreateRolInRols(List<string> rols)
        {
            foreach (var line in rols)
            {
                var splitted = line.Split(',');
                if (splitted.Length == 3 && splitted[0] == "role")
                {
                    var rol = Sitecore.Security.Accounts.Role.FromName(splitted[1]);
                    foreach (var subrolstring in splitted[2].Split('|'))
                    {
                        var subrol = Sitecore.Security.Accounts.Role.FromName(subrolstring);
                        if (rol != null && subrol != null)
                        {
                            if (RolesInRolesManager.RolesInRolesSupported && !RolesInRolesManager.IsRoleInRole(subrol, rol, false))
                            {
                                RolesInRolesManager.AddRoleToRole(subrol, rol);
                            }
                        }
                    }
                }
            }
        }

        private static bool CheckOnManagingRights()
        {
            if (Sitecore.Context.User.IsInRole("sitecore\\Developer"))
            {
                return true;
            }
            if (Sitecore.Context.User.IsAdministrator)
            {
                return true;
            }
            if (Sitecore.Context.User.IsInRole("sitecore\\Sitecore Client Account Managing"))
            {
                return true;
            }
            if (Sitecore.Context.User.IsInRole("sitecore\\Sitecore Client Securing"))
            {
                return true;
            }
            return false;
        }
    }
}