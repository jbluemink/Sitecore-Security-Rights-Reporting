using System;
using System.Web.UI.WebControls;

namespace Security.Rights.Reporting.sitecore_modules.Shell.Security_Rights_Reporting
{
    public static class Uninstall
    {
        #region setup

        internal static class Removetoken
        {
            internal static string Securitytoke = Guid.NewGuid().ToString();
        }

        public static void ApplicationSetup(Literal userlist, System.Web.UI.Page page, string mode, string securitytoke)
        {
            if (CheckSetupRights())
            {
                if (mode == "uninstall")
                {
                    userlist.Text +=
                        "<h1>Uninstall the Security Rights Reporting Module</h1><p>Are you sure you want to delete the Security Rights Reporting Module? <a href=\"?mode=unistallyes&token=" + Removetoken.Securitytoke + "\">Yes remove</a> - <a href=\"?\">No cancel</a>";
                }
                else if (mode == "unistallyes" && securitytoke == Removetoken.Securitytoke)
                {
                    DeleteFileFromWebroot(userlist,page,"~\\App_Config\\Include\\Security.Rights.Reporting.Module.config");
                    DeleteFileFromWebroot(userlist,page,"~\\bin\\Security.Rights.Reporting.dll");
                    DeleteFileFromWebroot(userlist,page,"~\\sitecore modules\\Shell\\Security-Rights-Reporting\\Download.aspx");
                    DeleteFileFromWebroot(userlist,page,"~\\sitecore modules\\Shell\\Security-Rights-Reporting\\UserInfo.aspx");
                    DeleteDirectoryFromWebroot(userlist,page,"~\\sitecore modules\\Shell\\Security-Rights-Reporting");
                    DeleteSitecoreCoreItem(userlist,"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Security Tools/Userinfo");
                    DeleteSitecoreCoreItem(userlist,"/sitecore/content/Documents and settings/All users/Start menu/Right/Security Tools/Security Reporting");
                    DeleteSitecoreCoreItem(userlist,"/sitecore/content/Applications/Security Reporting");

                    userlist.Text +=
                        "<p>The Security Rights Reporting Module is removed, Thank you for using <a href=\"javascript:window.close()\">Close</a>";
                }
            }
            else
            {
                userlist.Text += "access denied, you need Development or Admin rights";
            }
        }

        private static void DeleteFileFromWebroot(Literal userlist, System.Web.UI.Page page, string file)
        {

            userlist.Text += "<br>Delete File " + file;
            try
            {
                var path = page.MapPath(file);
                System.IO.File.Delete(path);
            }
            catch (Exception e)
            {
                userlist.Text += "<br><strong>Error</strong> delete dir " + file;
                userlist.Text += string.Format("<p>{0}</p>", e);
            }
        }

        private static void DeleteDirectoryFromWebroot(Literal userlist, System.Web.UI.Page page, string dir)
        {

            userlist.Text += "<br>Delete Directory " + dir;
            try
            {
                var path = page.MapPath(dir);
                System.IO.Directory.Delete(path);
            }
            catch (Exception e)
            {
                userlist.Text += "<br><strong>Error</strong> delete Directory " + dir;
                userlist.Text += string.Format("<p>{0}</p>", e);
            }
        }

        private static void DeleteSitecoreCoreItem(Literal userlist, string itempath)
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

        #endregion
    }
}