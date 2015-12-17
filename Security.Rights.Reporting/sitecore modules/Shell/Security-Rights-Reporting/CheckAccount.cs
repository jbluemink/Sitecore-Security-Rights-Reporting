using System.Collections.Generic;

namespace Security.Rights.Reporting.Shell
{
    public class CheckAccount
    {
        private Dictionary<string, bool> users;
        private Dictionary<string, bool> rols;

        public CheckAccount()
        {
            users = new Dictionary<string, bool>();
            rols = new Dictionary<string, bool>();
        }

        public bool IsUserExsisting(string username)
        {
            if (users.ContainsKey(username))
            {
                return users[username];
            }
            var isUser = Sitecore.Security.Accounts.User.Exists(username);
            users.Add(username,isUser);
            return isUser;
        }

        public bool IsRolExsisting(string rolname)
        {
            if (rols.ContainsKey(rolname))
            {
                return rols[rolname];
            }
            var isRol = Sitecore.Security.Accounts.Role.Exists(rolname);
            rols.Add(rolname, isRol);
            return isRol;
        }

        public bool IsRolDefaultAnonymous(string rolname)
        {
            if (Sitecore.Security.Domains.Domain.GetDefaultAnonymousUser().Name == rolname)
            {
                return true;
            }
            var isRol = Sitecore.Security.Accounts.Role.Exists(rolname);
            rols.Add(rolname, isRol);
            return isRol;
        }
    }
}