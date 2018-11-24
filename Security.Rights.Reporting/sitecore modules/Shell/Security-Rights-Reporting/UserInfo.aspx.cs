using System;
using Sitecore.Data;
using Security.Rights.Reporting.sitecore_modules.Shell.Security_Rights_Reporting;

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
                var classic = Request.QueryString.Get("classic");
                var securitytoke = Request.QueryString.Get("token");
                if (!string.IsNullOrEmpty(mode))
                {
                    Uninstall.ApplicationSetup(userlist, Page, mode, securitytoke);
                }
                else if (!string.IsNullOrEmpty(classic))
                {
                    UserRightsClassicScreen.GetUserTabel(userlist);
                }
                else if (!string.IsNullOrEmpty(account))
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
                else
                {
                    UserListScreen.DisplayAccountRight(rightstable, userrights, userlistjsall, userlistjssitecore);
                }
            }
            else
            {
                userlist.Text += "access denied";
            }
        }
#endregion


        private void GetAccountRight(string account, bool showdefaultrights)
        {
            Database db = Sitecore.Configuration.Factory.GetDatabase("core");
            AccountRightScreen.DisplayAccountRight(userrights, db, account, showdefaultrights);
            db = Sitecore.Configuration.Factory.GetDatabase("master");
            AccountRightScreen.DisplayAccountRight(userrights, db, account, showdefaultrights);
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


    }
}