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

        private static void Step2(HttpRequest request, Literal rolesexport)
        {
            rolesexport.Text += "Export<br/>";
            var allright = CurrentRights.GetAllRightsMaster();
            var rols = request.Form.Get("rol");
            if (rols != null)
            {
                foreach (var rol in rols.Split(','))
                {
                    rolesexport.Text += "<strong>"+ rol + "</strong>  :<br> ";
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
                                    rolesexport.Text += itemWithRights.Paths.FullPath + " |" + rule.SecurityPermission.ToString() + "|" +rule.AccessRight.Name+ "|  serialized =" + ruleCollection.ToString() +"<br>";
                                }
                            }
                        }
                    }
                    rolesexport.Text += "<br>\n";
                }
            }
        }

        private static void Step1(Literal rolesexport)
        {
            rolesexport.Text +=
            "<h1>Export Rols with the Rights set on Items </h1>Select Rols<br/><form method=\"post\" action=\"?rolesexport=step2\">";
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
                    + rol.Name + "\" name=\"rol\" value=\"" + rol.Name + "\" >" + rol.Name + "<br/>";
            }
            rolesexport.Text += "<input type=\"submit\" name=\"Submit\"><form>";
        }

        private static void Import1(Literal rolesexport)
        {
            rolesexport.Text += "<form method=\"post\" action=\"?rolesexport=import2\" enctype=\"multipart/form-data\"><input type=\"file\" name=\"fileToUpload\" id=\"fileToUpload\" ><input type=\"submit\" value=\"Upload\" name=\"submit\" ></form>";
        }
        private static void Import2(HttpRequest request, Literal rolesexport)
        {    
            var file = request.Files.Get("fileToUpload");           
            if (file == null || file.ContentLength == 0) {
                rolesexport.Text += "Select an import csv file.<br/>";
                Import1(rolesexport);
                return;
            }
            rolesexport.Text += "Import size=" + file.ContentLength +"<br/>";
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
                                rolesexport.Text += "<br>rol created" + splitted[1];
                                if (!string.IsNullOrEmpty(splitted[0]))
                                {
                                    rolsPostponedProcess.Add(line);
                                }
                            } catch
                            {
                                rolesexport.Text += "<br>Error cannot create rol " + splitted[1];
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
                            rolesexport.Text += "<br>Error unknow item path " + splitted[0];
                        } else
                        {
                            var accessRules = item.Security.GetAccessRules();
                            var rules = AccessRuleCollection.FromString(splitted[1]);
                            if (rules != null)
                            {
                                foreach (var rule in rules)
                                {
                                    if (!accessRules.Contains(rule))
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
                                rolesexport.Text += "<br>" + splitted[0] + "  =  " + item.Fields["__Security"].Value;
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
    }
}