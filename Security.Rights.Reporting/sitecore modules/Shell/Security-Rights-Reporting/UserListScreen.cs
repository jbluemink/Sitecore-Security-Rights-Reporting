using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.HtmlControls;
using Sitecore.Data;
using System.Web.UI.WebControls;
using Sitecore.Data.Items;
using Security.Rights.Reporting.Shell;
using Security.Rights.Reporting.Shell.RightsData;
using Sitecore.Security.Accounts;

namespace Security.Rights.Reporting.sitecore_modules.Shell.Security_Rights_Reporting
{
    public static class UserListScreen
    {
        public static void DisplayAccountRight(HtmlGenericControl userrightstable, Literal userrights, Literal jsallaccounts, Literal jssitecoreaccounts)
        {
            userrightstable.Visible = true;
            userrights.Text = string.Format("For Classic view with more checks: <a href=\"?{0}\">Classic</a> ", "classic=1");
            userrights.Text += " or <a href=\"?rolesexport=step1\">Export Roles and Right</a> or <a href=\"?rolesexport=import1\">Import Roles and Right</a><br>";
            var totaluser = Sitecore.Security.Accounts.UserManager.GetUserCount();
            userrights.Text += string.Format("Total real Membership users is {0} (sitecore\\Anonymous does not count)", totaluser);
            if (totaluser > 500)
            {
                userrights.Text += "<br/>To many users the user are filtered, show only the sitecore domain. (max 500 users) ";
                jssitecoreaccounts.Visible = true;
            }
            else
            {
                jsallaccounts.Visible = true;
            }
        }
    }
}