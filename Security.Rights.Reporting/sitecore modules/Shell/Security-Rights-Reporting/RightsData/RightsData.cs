using System;
using System.Collections.Generic;
using System.Linq;
using Security.Rights.Reporting.Shell.Model;
using Sitecore.Security.AccessControl;
using Sitecore.Web.UI.XamlSharp.Xaml.Extensions;

namespace Security.Rights.Reporting.Shell.RightsData
{
    public class RightsData
    {
        public static List<DefaultRight> GetDefaultRights(string database, string account, out string message)
        {
            IEnumerable<string[]> rights;
            if (database.ToLower() == "core")
            {
                rights = GetDefaultCoreRightsByVersion(out message);
            }
            else
            {
                rights = GetDefaultMasterRightsByVersion(out message);
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

        public static IEnumerable<string[]> GetDefaultCoreRightsByVersion(out string message)
        {
            message = string.Empty;
            if (Sitecore.Configuration.About.Version.StartsWith("8.0.141212"))
            {
                return Rights80.Core;
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0.150121"))
            {
                return Rights80.Core.Concat(Rights80.Core801);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0.150223"))
            {
                message = "Sitecore version not supported show rights as 8.0";
                return Rights80.Core;
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0.150427"))
            {
                message = "Sitecore version not supported show rights as 8.0";
                return Rights80.Core;
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0.150621")) 
            {
                message = "Sitecore version not supported show rights as 8.0";
                return Rights80.Core;
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0.150812"))
            {
                message = "Sitecore version not supported show rights as 8.0";
                return Rights80.Core;
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0"))
            {
                message = "Sitecore version not supported show rights as 8.0";
                return Rights80.Core;
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.1.151003"))
            {
                message = "Sitecore version not supported show rights as 8.0";
                return Rights80.Core;
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.1"))
            {
                message = "Sitecore version not supported show rights as 8.1 initial version";
                return Rights80.Core;
            }
            message = "Sitecore version not supported for displaying default rights";
            return new string[0][];
        }
        public static string[][] GetDefaultMasterRightsByVersion(out string message)
        {
            message = string.Empty;
            if (Sitecore.Configuration.About.Version.StartsWith("8"))
            {
                return Rights80.Master;
            }
            message = "Sitecore version not supported for displayong default rights";
            return new string[0][];
        }


        public static string[][] JoinPathRight(string[][] l1, string[][] l2)
        {
            var x = l1.ToList().Concat(l2.ToList());

            return x.ToArray();
        }
    }
}