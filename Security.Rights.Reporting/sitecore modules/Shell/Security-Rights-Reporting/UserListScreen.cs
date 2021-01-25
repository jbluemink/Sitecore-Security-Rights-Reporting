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
        public static void DisplayAccountRight(HtmlGenericControl userrightstable, Literal userrights, Literal jsallaccounts, Literal jssitecoreaccounts, Literal usersnolimit, string nolimit)
        {
            userrightstable.Visible = true;
            userrights.Text = string.Format("For Classic view with more checks: <a href=\"?{0}\">Classic</a> ", "classic=1");
            userrights.Text += " or <a href=\"?rolesexport=step1\">Export Roles and Right</a> or <a href=\"?rolesexport=import1\">Import Roles and Right</a><br>";
            var totaluser = -1;
            try
            {
                totaluser = Sitecore.Security.Accounts.UserManager.GetUserCount();
                userrights.Text += string.Format("Total real Membership users is {0} (sitecore\\Anonymous does not count)", totaluser);
            }
            catch (Exception  ex) {
                userrights.Text += "SQL timeout on UserManager.GetUserCount ";
                totaluser = 999;
            }
            if (!string.IsNullOrEmpty(nolimit))
            {
                usersnolimit.Visible = true;
            }
            else if (totaluser > 500)
            {
                userrights.Text += "<br/>To many users the user are filtered, show only the sitecore domain. (max 500 users) ";
                userrights.Text += "<br/>For no user limit <a href=\"?nolimit=true\">Get all users in batches of 10</a> ";
                jssitecoreaccounts.Visible = true;
            } 
            else
            {
                jsallaccounts.Visible = true;
            }
        }
    }
}