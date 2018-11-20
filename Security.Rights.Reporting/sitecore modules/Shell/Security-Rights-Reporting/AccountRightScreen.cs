using System;
using System.Collections.Generic;
using System.Linq;
using Sitecore.Data;
using System.Web.UI.WebControls;
using Sitecore.Data.Items;
using Security.Rights.Reporting.Shell;
using Security.Rights.Reporting.Shell.RightsData;
using Sitecore.Security.Accounts;

namespace Security.Rights.Reporting.sitecore_modules.Shell.Security_Rights_Reporting
{
    public static class AccountRightScreen
    {
        #region Account rights screen
        public static void DisplayAccountRight(Literal userrights, Database db, string account, bool showdefaultrights)
        {
            if (account == "all")
            {
                userrights.Text += string.Format("<h2 id=\"{0}\">Item Rights set on all users and roles on {0} Database</h2>", db.Name);
            }
            else
            {
                userrights.Text += string.Format("<h2 id=\"{1}\">Item Rights set on account {0} on {1} Database</h2>", System.Web.HttpUtility.HtmlEncode(account), db.Name);
            }
            //We use a query instead of index search because, security field data is not in query, will be slower by large resultset.
            const string query = "fast://*[@__Security != '' ]";

            var itemList = new List<Item>(db.SelectItems(query));

            var count = 0;

            var checkAccount = new CheckAccount();

            string outmessage;
            var defaultRights = RightsData.GetDefaultRights(db.Name, account, out outmessage);
            if (!string.IsNullOrEmpty(outmessage))
            {
                userrights.Text += "<p>" + outmessage + "</p>";
            }
            userrights.Text += "<table id=\"table-accountrights\">";
            foreach (var item in itemList)
            {
                var accessRules = item.Security.GetAccessRules();
                if (accessRules != null)
                {
                    if (account == "devexport")
                    {
                        userrights.Text += string.Format(",new[] {{\"{0}\",@\"{1}\"}}\n<br>", item.Paths.FullPath, item.Fields["__Security"].Value);
                    }
                    else
                    {
                        foreach (var rule in accessRules)
                        {
                            var defaultRight = defaultRights.FirstOrDefault(x => x.Path == item.Paths.FullPath && x.Account == rule.Account.Name && x.Right == rule.SecurityPermission.ToString() && x.Name == rule.AccessRight.Name && x.PropagationType == rule.PropagationType.ToString());
                            var style = "";
                            var message = "";
                            if (defaultRight != null)
                            {
                                defaultRight.Hit = true;
                                style = " style=\"color:#008800;\" class=\"green\"";
                                message = string.Format(", ({0})", defaultRight.Message);
                                if (!showdefaultrights)
                                {
                                    continue;
                                }
                            }
                            var accountExsist = true;
                            if (rule.Account.AccountType == AccountType.Role)
                            {
                                accountExsist = checkAccount.IsRolExsisting(rule.Account.Name);
                            }
                            else
                            {
                                accountExsist = checkAccount.IsUserExsisting(rule.Account.Name);
                            }
                            if (!accountExsist)
                            {
                                message += ", Account unknown";
                                style = " style=\"color:#FFA500;\" class=\"orange\"";
                            }

                            if (rule.Account.Name == account)
                            {
                                userrights.Text += string.Format("<tr{3}><td>{0}</td><td>{1}</td><td>{6}</td><td>{2}{4}</td><td>{5}</td></tr>\n", item.Paths.FullPath, rule.AccessRight.Comment, rule.SecurityPermission, style, message, rule.PropagationType, rule.AccessRight.Name);
                                count++;
                            }
                            else if (account == "all")
                            {
                                userrights.Text += string.Format("<tr{4}><td>{0}</td><td>{8} : {1}</td><td>{7}</td><td>{2}{5}</td><td>{3}</td><td>{6}</td></tr>\n", item.Paths.FullPath, rule.Account.Name, rule.AccessRight.Comment, rule.SecurityPermission, style, message, rule.PropagationType, rule.AccessRight.Name, rule.Account.AccountType.ToString());
                                count++;
                            }
                            else if (account == "alldevexport")
                            {
                                userrights.Text += string.Format(",new[] {{\"{0}\",\"{1}\",\"{2}\",\"{3}\"}}\n<br>", item.Paths.FullPath, rule.Account.Name.Replace("\\", "\\\\"), rule.SecurityPermission, rule.PropagationType);
                                count++;
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                if (showdefaultrights)
                {
                    userrights.Text += "<tr><td>No rights found in this Database for the user or role.</td></tr>";
                }
                else
                {
                    userrights.Text += "<tr><td>No custom rights found in this Database.</td></tr>";
                }
            }
            userrights.Text += "</table>";

            var warningRights = defaultRights.Where(x => x.Hit == false).ToList();
            if (warningRights.Any())
            {
                userrights.Text += "<br><span style=\"color:#880000;\">WARNING:</span> Expected rights not found:<br><table style=\"color:#880000;\">";
                foreach (var warningRight in warningRights)
                {
                    userrights.Text += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td></tr>\n", warningRight.Path, warningRight.Account, warningRight.Name, warningRight.Message, warningRight.Right, warningRight.PropagationType);
                }
                userrights.Text += "</table>";
            }
        }
        #endregion
    }
}