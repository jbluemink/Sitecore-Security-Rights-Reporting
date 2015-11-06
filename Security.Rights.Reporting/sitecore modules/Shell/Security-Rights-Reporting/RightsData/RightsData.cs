using System;
using System.Collections.Generic;
using System.Linq;
using Security.Rights.Reporting.Shell.Model;
using Sitecore.Data.Validators.FieldValidators;
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
            foreach (var r in rights.OrderBy(x => x[0]))
            {
                var accessRules = AccessRuleCollection.FromString(r[1]);
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
                //initial version
                return Rights80.Core;
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0.150121"))
            {
                //update 1
                return Rights80.Core.Concat(Rights80.Core801);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0.150223"))
            {
                //update 2
                return JoinPathRight(Rights80.Core, Rights80.Core802Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0.150427"))
            {
                //update 3, same as 2
                return JoinPathRight(Rights80.Core, Rights80.Core802Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0.150621")) 
            {
                //update 4 same as 2
                return JoinPathRight(Rights80.Core, Rights80.Core802Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0.150812"))
            {
                //update 5 same as 2
                return JoinPathRight(Rights80.Core, Rights80.Core802Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0"))
            {
                message = "Sitecore version not supported show rights as 8 update 5";
                return JoinPathRight(Rights80.Core, Rights80.Core802Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.1.151003"))
            {
                //initial version 8.1
                return JoinPathRight( Rights80.Core, Rights80.Core810Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.1"))
            {
                message = "Sitecore version not supported show rights as 8.1 initial version";
                return Rights80.Core;
            }
            message = "Sitecore version not supported for displaying default rights";
            return new string[0][];
        }

        public static IEnumerable<string[]> GetDefaultMasterRightsByVersion(out string message)
        {
            message = string.Empty;
            if (Sitecore.Configuration.About.Version.StartsWith("8.0"))
            {
                return Rights80.Master;
            }
            if (Sitecore.Configuration.About.Version.StartsWith("8.1.151003"))
            {
                return JoinPathRight(Rights80.Master, Rights80.Master810Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.1"))
            {
                message = "Sitecore version not supported show rights as 8.1 initial version";
                return Rights80.Core;
            }
            message = "Sitecore version not supported for displaying default rights";
            return new string[0][];
        }


        public static IEnumerable<string[]> JoinPathRight(List<string[]> l1, List<string[]> l2)
        {
            var joinedlist = l1;
            foreach (var pr in l2)
            {
                bool found = false;
                foreach (string[] obj in joinedlist)
                {
                    if (obj[0] == pr[0])
                    {
                        obj[1] = pr[1];
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    joinedlist.Add(pr);
                }
            }

            return joinedlist;
        }
    }
}