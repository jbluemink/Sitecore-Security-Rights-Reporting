using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using System.Web.Security;
using Security.Rights.Reporting.Models;
using Security.Rights.Reporting.Shell;
using Sitecore.Mvc.Controllers;

namespace Security.Rights.Reporting.Controllers
{

    public class RightsReportingController : SitecoreController
    {

        public RightsReportingController()
        {
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

        [System.Web.Http.HttpGet, System.Web.Http.HttpPost]
        public ActionResult Users(int page)
        {
            if (!CheckAccessRight())
            {
                return new JsonResult { Data = "access denied", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
            var users = Sitecore.Security.Accounts.UserManager.GetUsers().GetPage(page,10);
            var profileFinder = new UserProfileFinder();
            var reportingUsers = new ReportingUsers();
            reportingUsers.users = new List<ReportingUser>();
            foreach (var user in users)
            {
                var reportUser = new ReportingUser();
                reportUser.name = user.Name;
                reportUser.profileType = string.Empty;
                if (user.Profile != null)
                {
                    reportUser.ProfileComment = user.Profile.Comment;
                    reportUser.ProfileState =user.Profile.State;
                    reportUser.profileType = profileFinder.GetProfile(user.Profile.ProfileItemId);
                }
                reportingUsers.users.Add(reportUser);

            }

            //int totalUsers;
            //MembershipUserCollection allUsers = Membership.GetAllUsers(0, 10, out totalUsers);
            //Membership.GetUser()

            return new JsonResult { Data = reportingUsers, JsonRequestBehavior = JsonRequestBehavior.AllowGet};
        }

    }
}