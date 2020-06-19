using Sitecore.Mvc.Pipelines.Request.RequestBegin;
using Sitecore.SecurityModel;
using Sitecore.Web.UI.XamlSharp.Xaml.Extensions;
using System;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
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
        }

        private static void Step2(HttpRequest request, Literal rolesexport)
        {
            rolesexport.Text += "Export<br/>";
            var rols = request.Form.Get("rol");
            if (rols != null)
            {
                foreach (var rol in rols.Split(','))
                {
                    rolesexport.Text += rol + "<br>";
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
            rolesexport.Text += "<input type=\"submit\"><form>";
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