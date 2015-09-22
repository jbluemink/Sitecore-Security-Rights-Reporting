using System.Collections.Generic;
using Security.Rights.Reporting.Shell.Model;

namespace Security.Rights.Reporting.Shell
{
    public class DefaultUsers
    {
        public static List<DefaultUser> GetDefaultUsers()
        {
            var users = GetDefaultUsersByVersion();
            var returnlist = new List<DefaultUser>();
            foreach (var user in users)
            {
                var tmp = new DefaultUser { User = user, Hit = false };
                returnlist.Add(tmp);
            }
            return returnlist;
        }

        public static string[] GetDefaultUsersByVersion()
        {
            if (Sitecore.Configuration.About.Version.StartsWith("8"))
            {
                return DefaultsUsersSitecore75;
            }
            if (Sitecore.Configuration.About.Version.StartsWith("7.5"))
            {
                return DefaultsUsersSitecore75;
            }
            if (Sitecore.Configuration.About.Version.StartsWith("7"))
            {
                return DefaultsUsersSitecore65;
            }
            if (Sitecore.Configuration.About.Version.StartsWith("6"))
            {
                return DefaultsUsersSitecore65;
            }
            return new string[0];
        }

        public static string[] DefaultsUsersSitecore75 =
        {
            "default\\Anonymous"
            , "extranet\\Anonymous"
            , "sitecore\\Admin"
            , "sitecore\\ServicesAPI"
        };
        public static string[] DefaultsUsersSitecore65 =
        {
            "default\\Anonymous"
            , "extranet\\Anonymous"
            , "sitecore\\Admin"
        };

        public static Dictionary<string, string> UserComment = new Dictionary<string, string>()
        {
              {"default\\Anonymous", "a virtual user who is assigned to an unauthenticated visitor who is viewing a website that does not have an assigned domain"}
            , {"extranet\\Anonymous", "a user who is viewing the free to access parts of a website."}
            , {"sitecore\\Admin","A predefined administrator user."}
            , {"sitecore\\ServicesAPI","Sitecore.Services.Client service Web API&#13;The default is that the extranet\\Anonymous user does not have access to the ItemService. You set this behavior with the Sitecore.Services.AllowAnonymousUser setting in the Sitecore.Services.Client.config configuration file.&#13;When you set Sitecore.Services.AllowAnonymousUser to true, then the ItemService will run anonymous requests in the security context of the user defined in the Sitecore.Services.AnonymousUser configuration setting. Such requests will, by default, do  user impersonation and run as the sitecore\\ServicesAPI user."}
        };
    }
}