using System.Collections.Generic;
using Security.Rights.Reporting.Shell.Model;
using Sitecore.Security.AccessControl;

namespace Security.Rights.Reporting.Shell.RightsData
{
    public class RightsData
    {
        public static List<DefaultRight> GetDefaultRights(string database, string account)
        {
            string[][] rights;
            if (database.ToLower() == "core")
            {
                rights = GetDefaultCoreRightsByVersion();
            }
            else
            {
                rights = GetDefaultMasterRightsByVersion();
            }
            
            //Here is a issue, we handle account without looking for user or rol... so if a user has same name as rol, it is mixing.
            var returnlist = new List<DefaultRight>();
            foreach (var r in rights)
            {
                var accessRules = new AccessRuleCollection();
                accessRules = AccessRuleCollection.FromString(r[1]);
                if (accessRules != null)
                {
                    foreach (var rule in accessRules)
                    {
                        if (account == "all" || account == rule.Account.Name)
                        {
                            var tmp = new DefaultRight
                            {
                                Path = r[0],
                                Account = rule.Account.Name,
                                Right = rule.SecurityPermission.ToString(),
                                PropagationType = rule.PropagationType.ToString(),
                                Name = rule.AccessRight.Name,
                                Message = "Default Sitecore",
                                Hit = false
                            };
                            returnlist.Add(tmp);
                        }
                    }
                }
            }
            return returnlist;
        }

        public static string[][] GetDefaultCoreRightsByVersion()
        {
            if (Sitecore.Configuration.About.Version.StartsWith("8"))
            {
                return Rights80.Core;
            }
          
            return new string[0][];
        }
        public static string[][] GetDefaultMasterRightsByVersion()
        {
            if (Sitecore.Configuration.About.Version.StartsWith("8"))
            {
                return Rights80.Master;
            }

            return new string[0][];
        }
    }
}