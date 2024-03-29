﻿using System.Collections.Generic;
using System.Linq;
using Security.Rights.Reporting.Shell.Model;
using Sitecore.Security.AccessControl;
using Sitecore.Security.Accounts;


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
                                AccountType = rule.Account.AccountType,
                                Right = rule.SecurityPermission.ToString(),
                                PropagationType = rule.PropagationType.ToString(),
                                Name = rule.AccessRight.Name,
                                Message = "Default Sitecore",
                                Hit = false
                            };
                            if (tmp.AccountType != AccountType.Role)
                            {
                                if (tmp.AccountType == AccountType.User)
                                {
                                    tmp.Message += " User role not recommend";
                                }
                                else
                                {
                                    tmp.Message += " User role Unknown";
                                }
                            }
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
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0.151127"))
            {
                //update 6 changes
                return JoinPathRight(Rights80.Core, Rights80.Core806Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0.160115"))
            {
                //update 7 changes core same as 6
                return JoinPathRight(Rights80.Core, Rights80.Core806Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0"))
            {
                message = "Sitecore version not supported show rights as 8 update 5";
                return JoinPathRight(Rights80.Core, Rights80.Core802Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.1.151003"))
            {
                //initial version 8.1
                return JoinPathRight(Rights80.Core, Rights80.Core811Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.1.151207"))
            {
                // update 1
                return JoinPathRight(Rights80.Core, Rights80.Core811Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.1.160302"))
            {
                // update 2 same as 1
                return JoinPathRight(Rights80.Core, Rights80.Core811Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.1.160519"))
            {
                // update 3
                return JoinPathRight(Rights80.Core, Rights80.Core813Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.1"))
            {
                message = "Sitecore version not supported show rights as 8.1 update 3";
                return JoinPathRight(Rights80.Core, Rights80.Core813Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.2.160729"))
            {
                // 8.2 initial
                return JoinPathRight(Rights80.Core, Rights80.Core820Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.2.161115"))
            {
                // 8.2 update 1
                return JoinPathRight(Rights80.Core, Rights80.Core821Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.2.161221"))
            {
                // 8.2 update 2
                return JoinPathRight(Rights80.Core, Rights80.Core821Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.2.170407"))
            {
                // 8.2 update 3
                return JoinPathRight(Rights80.Core, Rights80.Core821Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.2.170614"))
            {
                // 8.2 update 4
                return JoinPathRight(Rights80.Core, Rights80.Core824Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.2.170728"))
            {
                // 8.2 update 5
                return JoinPathRight(Rights80.Core, Rights80.Core824Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.2.171121"))
            {
                // 8.2 update 6
                return JoinPathRight(Rights80.Core, Rights80.Core824Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.2"))
            {
                message = "Sitecore version not supported show rights as 8.2 update 6";
                return JoinPathRight(Rights80.Core, Rights80.Core824Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.0.0.171002"))
            {
                // 9 initial version
                return JoinPathRight(Rights90.Core, Rights90.Core900Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.0.1.171219"))
            {
                // 9 update 1
                return Rights90.Core;
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.0.2.180604"))
            {
                // 9 update 2
                return JoinPathRight(Rights90.Core, Rights90.Core902Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.1.0.001564"))
            {
                // 9.1 inital
                return JoinPathRight(Rights90.Core, Rights90.Core910Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.1.1.002459"))
            {
                // 9.1 update-1
                return JoinPathRight(Rights90.Core, Rights90.Core911Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.1"))
            {
                message = "Sitecore version not supported show rights as 9.1 update-1";
                return JoinPathRight(Rights90.Core, Rights90.Core911Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.2.0.002893"))
            {
                return JoinPathRight(Rights90.Core, Rights90.Core920Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.2"))
            {
                message = "Sitecore version not supported show rights as 9.2 initial";
                return JoinPathRight(Rights90.Core, Rights90.Core920Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.3.0.003498"))
            {
                return JoinPathRight(Rights90.Core, Rights90.Core930Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.3"))
            {
                message = "Sitecore version not supported show rights as 9.3 initial";
                return JoinPathRight(Rights90.Core, Rights90.Core930Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("10.0.0.004346"))
            {
                return JoinPathRight(Rights90.Core, Rights90.Core100Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("10.0.1.004842"))
            {
                return JoinPathRight(Rights90.Core, Rights90.Core1001Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("10.0"))
            {
                message = "Sitecore version not supported show rights as 10.0 update 1";
                return JoinPathRight(Rights90.Core, Rights90.Core1001Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("10."))
            {
                message = "Sitecore version 10.1+ show all rights hide default Sitecore rights and color status not available ";
                return new string[0][];
            }
            message = "<span style=\"color:#000088;\">Sitecore version not supported for displaying default rights</span>";
            return new string[0][];
        }

        public static IEnumerable<string[]> GetDefaultMasterRightsByVersion(out string message)
        {
            message = string.Empty;
            if (Sitecore.Configuration.About.Version.StartsWith("8.0.14"))
            {
                return Rights80.Master;
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0.15"))
            {
                return Rights80.Master;
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0.160115"))
            {
                return JoinPathRight(Rights80.Master, Rights80.Master807Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.0"))
            {
                message = "Sitecore version not supported show rights as 8.0 update 7";
                return JoinPathRight(Rights80.Master, Rights80.Master807Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.1.151003"))
            {
                return JoinPathRight(Rights80.Master, Rights80.Master810Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.1.151207"))
            {
                // update 1
                return JoinPathRight(Rights80.Master, Rights80.Master810Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.1.160302"))
            {
                // update 2
                return JoinPathRight(Rights80.Master, Rights80.Master812Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.1.160519"))
            {
                // update 3
                return JoinPathRight(Rights80.Master, Rights80.Master813Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.1"))
            {
                message = "Sitecore version not supported show rights as 8.1 update 3";
                return JoinPathRight(Rights80.Master, Rights80.Master813Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.2.160729"))
            {
                // 8.2 initial version
                return JoinPathRight(Rights80.Master, Rights80.Master820Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.2.161115"))
            {
                // 8.2 update 1
                return JoinPathRight(Rights80.Master, Rights80.Master820Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.2.161221"))
            {
                // 8.2 update 2
                return JoinPathRight(Rights80.Master, Rights80.Master820Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.2.170407"))
            {
                // 8.2 update 3
                return JoinPathRight(Rights80.Master, Rights80.Master820Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.2.170614"))
            {
                // 8.2 update 4
                return JoinPathRight(Rights80.Master, Rights80.Master820Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.2.170728"))
            {
                // 8.2 update 5
                return JoinPathRight(Rights80.Master, Rights80.Master820Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.2.171121"))
            {
                // 8.2 update 6
                return JoinPathRight(Rights80.Master, Rights80.Master820Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("8.2"))
            {
                message = "Sitecore version not supported show rights as 8.2 update 6";
                return JoinPathRight(Rights80.Master, Rights80.Master820Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.0.0.171002"))
            {
                // 9 initial version
                return JoinPathRight(Rights90.Master,Rights90.Master900Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.0.1.171219"))
            {
                // 9 update 1
                return Rights90.Master;
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.0.2.180604"))
            {
                // 9 update 2
                return Rights90.Master;
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.1.0.001564"))
            {
                // 9.1 initial
                return Rights90.Master;
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.1.1.002459"))
            {
                // 9.1 update-1
                return Rights90.Master;
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.1"))
            {
                message = "Sitecore version not supported show rights as 9.1 update-1";
                return Rights90.Master;
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.2.0.002893"))
            {
                return JoinPathRight(Rights90.Master, Rights90.Master920Replace); 
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.2"))
            {
                message = "Sitecore version not supported show rights as 9.2 initial";
                return JoinPathRight(Rights90.Master, Rights90.Master920Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.3.0.003498"))
            {
                return JoinPathRight(Rights90.Master, Rights90.Master930Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("9.3"))
            {
                message = "Sitecore version not supported show rights as 9.3 initial";
                return JoinPathRight(Rights90.Master, Rights90.Master930Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("10.0.0.004346"))
            {
                return JoinPathRight(Rights90.Master, Rights90.Master930Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("10.0.1.004842"))
            {
                return JoinPathRight(Rights90.Master, Rights90.Master930Replace);
            }
            else if (Sitecore.Configuration.About.Version.StartsWith("10."))
            {
                message = "Sitecore version 10.1+ show all rights hide default Sitecore rights and color status not available ";
                return new string[0][];
            }
            message = "<span style=\"color:#000088;\">Sitecore version not supported for displaying default rights</span>";
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