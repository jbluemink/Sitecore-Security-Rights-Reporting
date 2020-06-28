using Security.Rights.Reporting.sitecore_modules.Shell.Security_Rights_Reporting.RightsData;
using Sitecore.Data.Items;
using Sitecore.Security.AccessControl;
using Sitecore.SecurityModel;
using Sitecore.Visualization;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Razor.Editor;
using System.Web.UI.WebControls;

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
            rolesexport.Text += "<form method=\"post\" action=\"?rolesexport=import2\" enctype=\"multipart/form-data\"><input type=\"file\" name=\"fileToUpload\" id=\"fileToUpload\" ><input type=\"submit\" value=\"Upload Image\" name=\"submit\" ></form>";
        }
        private static void Import2(HttpRequest request, Literal rolesexport)
        {
            rolesexport.Text += "Import<br/>";
            var file = request.Form.Get("fileToUpload");
            rolesexport.Text += file;
            var db = Sitecore.Configuration.Factory.GetDatabase("master");

            using (StringReader reader = new StringReader(file))
            {
                string line;
                int count = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    count++;
                    var splitted = line.Split(',');
                    if (splitted.Length == 2)
                    {
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
                                    //maar wat als die al bestaat?
                                    accessRules.Add(rule);
                                }
                            }
                        }
                    } else
                    {
                        rolesexport.Text += "<br>Error unknow line " + count + " : " + line;
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