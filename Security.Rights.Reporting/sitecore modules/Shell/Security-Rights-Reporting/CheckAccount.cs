using System.Collections.Generic;

namespace Security.Rights.Reporting.Shell
{
    public class CheckAccount
    {
        private Dictionary<string, bool> users;
        private Dictionary<string, bool> roles;

        public CheckAccount()
        {
            users = new Dictionary<string, bool>();
            roles = new Dictionary<string, bool>();
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

        public bool IsRolExsisting(string rolename)
        {
            if (roles.ContainsKey(rolename))
            {
                return roles[rolename];
            }
            var isRol = Sitecore.Security.Accounts.Role.Exists(rolename);
            roles.Add(rolename, isRol);
            return isRol;
        }

        public bool IsRolDefaultAnonymous(string rolename)
        {
            if (Sitecore.Security.Domains.Domain.GetDefaultAnonymousUser().Name == rolename)
            {
                return true;
            }
            var isRol = Sitecore.Security.Accounts.Role.Exists(rolename);
            roles.Add(rolename, isRol);
            return isRol;
        }
    }
}