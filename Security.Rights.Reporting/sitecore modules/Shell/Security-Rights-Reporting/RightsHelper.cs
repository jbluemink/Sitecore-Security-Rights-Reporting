using Sitecore.Extensions;
using Sitecore.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Razor.Parser.SyntaxTree;

namespace Security.Rights.Reporting.sitecore_modules.Shell.Security_Rights_Reporting
{
    public static class RightsHelper
    {
        public static string RightToHtml(AccessRule rule)
        {
            string retvalue = "<span style=\"text-nowrap\">";
            if (rule.SecurityPermission == SecurityPermission.AllowAccess)
            {
                retvalue += "<img src=\"/sitecore/shell/themes/standard/Images/Security/large_allow_enabled.gif\" Width =\"16\" Height=\"16\" Align=\"middle\"/>";
            } else
            { 
                retvalue += "<img src=\"/sitecore/shell/themes/standard/Images/Security/large_allow_disabled.gif\" Width =\"16\" Height=\"16\" Align=\"middle\"/>";
            }

            if (rule.SecurityPermission == SecurityPermission.DenyAccess)
            {
                retvalue += "<img src=\"/sitecore/shell/themes/standard/Images/Security/large_deny_enabled.gif\" Width =\"16\" Height=\"16\" Align=\"middle\"/>";
            } else
            {
                retvalue += "<img src=\"/sitecore/shell/themes/standard/Images/Security/large_deny_disabled.gif\" Width =\"16\" Height=\"16\" Align=\"middle\"/>";
            }
            retvalue += " ";
            if (rule.SecurityPermission == SecurityPermission.AllowInheritance)
            {
                retvalue += "<img src=\"/sitecore/shell/themes/standard/Images/Security/large_allow_enabled.gif\" Width =\"16\" Height=\"16\" Align=\"middle\"/>";
            }
            else
            {
                retvalue += "<img src=\"/sitecore/shell/themes/standard/Images/Security/large_allow_disabled.gif\" Width =\"16\" Height=\"16\" Align=\"middle\"/>";
            }

            if (rule.SecurityPermission == SecurityPermission.DenyInheritance)
            {
                retvalue += "<img src=\"/sitecore/shell/themes/standard/Images/Security/large_deny_enabled.gif\" Width =\"16\" Height=\"16\" Align=\"middle\"/>";
            }
            else
            {
                retvalue += "<img src=\"/sitecore/shell/themes/standard/Images/Security/large_deny_disabled.gif\" Width =\"16\" Height=\"16\" Align=\"middle\"/>";
            }
            retvalue += "</span>";
            return retvalue;
        }
    }
}