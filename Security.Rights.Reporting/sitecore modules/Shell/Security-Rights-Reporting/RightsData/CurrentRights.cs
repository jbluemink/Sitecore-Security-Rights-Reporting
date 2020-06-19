using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Express;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Security.Rights.Reporting.sitecore_modules.Shell.Security_Rights_Reporting.RightsData
{
    public static class CurrentRights
    {
        static List<Item> allrightscore = null;
        static List<Item> allrightsmaster = null;
        static DateTime modified = new DateTime();
        static object lockGetAllRights = new object();

        //get all rights, with a micro 5 minutes cache... because this query is very havy and may kill your database if you run on a poor db
        public static List<Item> GetAllRights(Database db)
        {
            lock (lockGetAllRights)
            {
                if (db.Name.ToLower() == "core" && allrightscore != null && (DateTime.Now - modified).TotalMinutes < 5)
                {
                    return allrightscore;
                }
                if (db.Name.ToLower() == "master" && allrightsmaster != null && (DateTime.Now - modified).TotalMinutes < 5)
                {
                    return allrightsmaster;
                }
                //We use a query instead of index search because, security field data is not in query, will be slower by large resultset.
                const string query = "fast://*[@__Security != '' ]";

                var itemList = new List<Item>(db.SelectItems(query));

                if (db.Name.ToLower() == "core")
                {
                    allrightscore = itemList;
                    modified = DateTime.Now;
                }
                if (db.Name.ToLower() == "master")
                {
                    allrightsmaster = itemList;
                    modified = DateTime.Now;
                }

                return itemList;
            }
        }
    }
}