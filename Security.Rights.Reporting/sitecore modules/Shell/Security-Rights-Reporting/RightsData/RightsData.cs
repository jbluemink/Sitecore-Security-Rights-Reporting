using System.Collections.Generic;
using Security.Rights.Reporting.Shell.Model;

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
            
            var returnlist = new List<DefaultRight>();
            foreach (var r in rights)
            {
                if (account == "all" || account == r[1])
                {
                    var tmp = new DefaultRight {Path = r[0], Account = r[1], Right = r[2], Message = "Default Sitecore", Hit = false};
                    returnlist.Add(tmp);
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