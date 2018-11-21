using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.Security;
using Security.Rights.Reporting.Models;
using Security.Rights.Reporting.Shell;
using Sitecore.Extensions;
using Sitecore.Mvc.Controllers;
using Sitecore.Security.Accounts;
using Sitecore.Security.Domains;

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

            reportingUsers.users = GetUserData(users);

            //int totalUsers;
            //MembershipUserCollection allUsers = Membership.GetAllUsers(0, 10, out totalUsers);
            //Membership.GetUser()

            return new JsonResult { Data = reportingUsers, JsonRequestBehavior = JsonRequestBehavior.AllowGet};
        }

        private static List<ReportingUser> GetUserData(IEnumerable<User> users)
        {
            var reportingusers = new List<ReportingUser>();
            foreach (var user in users)
            {
                var reportUser = new ReportingUser();
                reportUser.name = user.Name;
                if (user.Profile != null)
                {
                    reportUser.ProfileState = user.Profile.State;
                    reportUser.IsAdmin = user.Profile.IsAdministrator ? "*" : "";
                    reportUser.Roles = "";
                    foreach (var rol in user.Roles)
                    {
                        if (!string.IsNullOrEmpty(reportUser.Roles))
                        {
                            reportUser.Roles += ", ";
                        }

                        reportUser.Roles += rol.DisplayName;
                    }
                }

                reportingusers.Add(reportUser);
            }

            return reportingusers;
        }

        [System.Web.Http.HttpGet, System.Web.Http.HttpPost]
        public ActionResult SitecoreUsers(int page)
        {
            if (!CheckAccessRight())
            {
                return new JsonResult { Data = "access denied", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
            var sitecoreDomain = Domain.GetDomain("sitecore");
            var users = sitecoreDomain.GetUsers().Skip(page*10).Take(10);
            var profileFinder = new UserProfileFinder();
            var reportingUsers = new ReportingUsers();
            reportingUsers.users = new List<ReportingUser>();
            reportingUsers.users = GetUserData(users);

            //int totalUsers;
            //MembershipUserCollection allUsers = Membership.GetAllUsers(0, 10, out totalUsers);
            //Membership.GetUser()

            return new JsonResult { Data = reportingUsers, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
}
}