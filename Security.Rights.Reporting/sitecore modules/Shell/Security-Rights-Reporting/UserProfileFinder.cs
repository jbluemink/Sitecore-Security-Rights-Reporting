using System.Collections.Generic;

namespace Security.Rights.Reporting.Shell
{
    public class UserProfileFinder
    {
        private Dictionary<string, string> profiles = new Dictionary<string, string>();

        private string GetProfileFromDb(string id)
        {
            var coreDb = Sitecore.Configuration.Factory.GetDatabase("core");
            var profileItem = coreDb.GetItem(id);
            if (profileItem != null)
            {
                return profileItem.Name;
            }
            else return string.Empty;
        }

        public string GetProfile(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return "&nbsp;";
            }
            var profilename = string.Empty;
            if (!profiles.TryGetValue(id, out profilename))
            {
                profilename = GetProfileFromDb(id);
                profiles.Add(id, profilename);
            }
            return profilename;
        }
    }
}