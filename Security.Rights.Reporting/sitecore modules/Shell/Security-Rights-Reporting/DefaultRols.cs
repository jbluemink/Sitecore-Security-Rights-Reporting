using System.Collections.Generic;
using Security.Rights.Reporting.Shell.Model;

namespace Security.Rights.Reporting.Shell
{
    public static class DefaultRols
    {

        public static List<DefaultRol> GetDefaultRols()
        {
            var rols = GetDefaultRolsByVersion();
            var returnlist = new List<DefaultRol>();
            foreach (var rol in rols)
            {
                var tmp = new DefaultRol {Rol = rol, Hit = false};
                returnlist.Add(tmp);
            }
            return returnlist;
        }

        public static string[] GetDefaultRolsByVersion()
        {
            if (Sitecore.Configuration.About.Version.StartsWith("8"))
            {
                return DefaultsRolsSitecore8;
            } 
            if (Sitecore.Configuration.About.Version.StartsWith("7.5"))
            {
                return DefaultsRolsSitecore72;
            }
            if (Sitecore.Configuration.About.Version.StartsWith("7.2"))
            {
                return DefaultsRolsSitecore72;
            }
            if (Sitecore.Configuration.About.Version.StartsWith("7"))
            {
                return DefaultsRolsSitecore7;
            } 
            if (Sitecore.Configuration.About.Version.StartsWith("6"))
            {
                return DefaultsRolsSitecore65;
            }
            return  new string[0];
        }

        public static string[] DefaultsRolsWffm =  {"sitecore\\Sitecore Client Forms Author", "sitecore\\Sitecore Marketer Form Author"};
        public static string[] DefaultsRolsSitecore8 =
        {
            "sitecore\\Analytics Advanced Testing"
            , "sitecore\\Analytics Content Profiling"
            , "sitecore\\Analytics Maintaining"
            , "sitecore\\Analytics Management Reporting"
            , "sitecore\\Analytics Personalization"
            , "sitecore\\Analytics Reporting"
            , "sitecore\\Analytics Testing"
            , "sitecore\\Author"
            , "sitecore\\Designer"
            , "sitecore\\Developer"
            , "sitecore\\Experience Explorer"
            , "sitecore\\Facebook Message Reviewer"
            , "sitecore\\List Manager Editors"
            , "sitecore\\Sitecore Client Account Managing"
            , "sitecore\\Sitecore Client Advanced Publishing"
            , "sitecore\\Sitecore Client Authoring"
            , "sitecore\\Sitecore Client Bucket Management"
            , "sitecore\\Sitecore Client Configuring"
            , "sitecore\\Sitecore Client Designing"
            , "sitecore\\Sitecore Client Developing"
            , "sitecore\\Sitecore Client Maintaining"
            , "sitecore\\Sitecore Client Publishing"
            , "sitecore\\Sitecore Client Securing"
            , "sitecore\\Sitecore Client Social Authoring"
            , "sitecore\\Sitecore Client Translating"
            , "sitecore\\Sitecore Client Users"
            , "sitecore\\Sitecore Limited Content Editor"
            , "sitecore\\Sitecore Limited Page Editor"
            , "sitecore\\Sitecore Local Administrators"
            , "sitecore\\Sitecore Minimal Page Editor"
            , "sitecore\\Social Marketer Message Reviewer"
            , "sitecore\\Social Message Author"
            , "sitecore\\Social Message Workflow Editor"
            , "sitecore\\Social Message Workflow Reviewer"
            , "sitecore\\Twitter Message Reviewer"
            , "sitecore\\Test Fail Rol"
        };
        public static string[] DefaultsRolsSitecore72 =
        {
            "sitecore\\Analytics Content Profiling"
            , "sitecore\\Analytics Maintaining"
            , "sitecore\\Analytics Personalization"
            , "sitecore\\Analytics Reporting"
            , "sitecore\\Analytics Testing"
            , "sitecore\\Author"
            , "sitecore\\Designer"
            , "sitecore\\Developer"
            , "sitecore\\Sitecore Client Account Managing"
            , "sitecore\\Sitecore Client Advanced Publishing"
            , "sitecore\\Sitecore Client Authoring"
            , "sitecore\\Sitecore Client Bucket Management"
            , "sitecore\\Sitecore Client Configuring"
            , "sitecore\\Sitecore Client Designing"
            , "sitecore\\Sitecore Client Developing"
            , "sitecore\\Sitecore Client Maintaining"
            , "sitecore\\Sitecore Client Publishing"
            , "sitecore\\Sitecore Client Securing"
            , "sitecore\\Sitecore Client Translating"
            , "sitecore\\Sitecore Client Users"
            , "sitecore\\Sitecore Limited Content Editor"
            , "sitecore\\Sitecore Limited Page Editor"
            , "sitecore\\Sitecore Local Administrators"
            , "sitecore\\Sitecore Minimal Page Editor"
        };
        public static string[] DefaultsRolsSitecore7 =
        {
            "sitecore\\Analytics Content Profiling"
            , "sitecore\\Analytics Maintaining"
            , "sitecore\\Analytics Personalization"
            , "sitecore\\Analytics Reporting"
            , "sitecore\\Analytics Testing"
            , "sitecore\\Author"
            , "sitecore\\Designer"
            , "sitecore\\Developer"
            , "sitecore\\Sitecore Client Account Managing"
            , "sitecore\\Sitecore Client Authoring"
            , "sitecore\\Sitecore Client Bucket Management"
            , "sitecore\\Sitecore Client Configuring"
            , "sitecore\\Sitecore Client Designing"
            , "sitecore\\Sitecore Client Developing"
            , "sitecore\\Sitecore Client Maintaining"
            , "sitecore\\Sitecore Client Publishing"
            , "sitecore\\Sitecore Client Securing"
            , "sitecore\\Sitecore Client Translating"
            , "sitecore\\Sitecore Client Users"
            , "sitecore\\Sitecore Limited Content Editor"
            , "sitecore\\Sitecore Limited Page Editor"
            , "sitecore\\Sitecore Local Administrators"
            , "sitecore\\Sitecore Minimal Page Editor"
        };
        public static string[] DefaultsRolsSitecore65 =
        {
            "sitecore\\Analytics Content Profiling"
            , "sitecore\\Analytics Maintaining"
            , "sitecore\\Analytics Personalization"
            , "sitecore\\Analytics Reporting"
            , "sitecore\\Analytics Testing"
            , "sitecore\\Author"
            , "sitecore\\Designer"
            , "sitecore\\Developer"
            , "sitecore\\Sitecore Client Account Managing"
            , "sitecore\\Sitecore Client Authoring"
            , "sitecore\\Sitecore Client Configuring"
            , "sitecore\\Sitecore Client Designing"
            , "sitecore\\Sitecore Client Developing"
            , "sitecore\\Sitecore Client Maintaining"
            , "sitecore\\Sitecore Client Publishing"
            , "sitecore\\Sitecore Client Securing"
            , "sitecore\\Sitecore Client Translating"
            , "sitecore\\Sitecore Client Users"
            , "sitecore\\Sitecore Limited Content Editor"
            , "sitecore\\Sitecore Limited Page Editor"
            , "sitecore\\Sitecore Local Administrators"
            , "sitecore\\Sitecore Minimal Page Editor"
        };

        public static Dictionary<string, string> RolComment = new Dictionary<string, string>()
        {
              {"sitecore\\Analytics Advanced Testing", "New in Sitecore 8. Gives the user access to see additional tabs and controls in the Marketing Control Panel. &#13;You typically give this role to optimization experts, who need expanded rights when performing tests, traffic allocation, and so on."}
            , {"sitecore\\Analytics Content Profiling", "Gives the user access to the content profiling functionality in the Experience Editor and in the Content Editor."}
            , {"sitecore\\Analytics Maintaining","Gives the user access to the Marketing Control Panel, the Engagement Plan Designer, and the Supervisor. &#13;The role gives the user permissions to create goal or page event messages and campaigns for messages."}
            , {"sitecore\\Analytics Management Reporting","Gives the user access to view the management reports for optimization efforts. &#13;This role is typically given to users working with optimization, who wants to view management reports for the optimization efforts. The user can still perform tests, but this is not their main objective."}
            , {"sitecore\\Analytics Personalization","Gives the user access to the personalization functionality in the Experience Editor and in the Content Editor. &#13;Members of this role can create and edit personalization rules. Users who are not members of this role can switch personalization variations."}
            , {"sitecore\\Analytics Reporting","Gives the user access to the Marketing Control Panel, the Engagement Plan Monitor, and to the Executive Dashboard."}
            , {"sitecore\\Analytics Testing","Gives the user access to the Test Lab in the Marketing Control Panel and to the test functionality in the Experience Editor and in the Content Editor. &#13;Members of this role can create and edit test variations. "}
            , {"sitecore\\Author","Gives the user access to content in the content tree. This role provides access to basic item editing features, such as the Media Library and the Content Editor, with a reduced set of tabs on the ribbon. &#13;This role also has two of the Sitecore Client roles as members, so if you assign just this role to a user, the Sitecore Client Authoring and Sitecore Client Users roles will be automatically assigned to the user."}
            , {"sitecore\\Designer","Gives the user read and write access to the areas of the content tree that are required when changing layout details for individual items and groups of items via template standard values, as well as items required when configuring the Experience Editor Design Pane. &#13;This role also has two of the Sitecore Client roles assigned to it, so if you assign just this role to a user, the Sitecore Client Designing and Sitecore Client Users roles will be automatically assigned to the user. &#13;This role provides access to the Experience Editor Design Pane features and the designer options in the Content Editor.&#13; Note This role is not a member of the Author and Authoring roles, so it does not allow users to edit items."}
            , {"sitecore\\Developer","Gives the user access to content manipulation facilities in the Content Editor, plus all the design and authoring roles normally used by client authors and client designers. It also provides access to more functionality on the ribbon of the Content Editor to allow full development features for users assigned to this role. &#13;This role also has access to the Development Tools menu in the Sitecore menu, which gives the user access to further development tools, such as the Package Designer."}
            , {"sitecore\\Experience Explorer","Gives the user access to the explore mode in the Experience Editor and to manage the Presets of the Explore mode in the Marketing Control Panel.&#13;The role is intended for marketers who set up campaigns and personalization."}
            , {"sitecore\\Facebook Message Reviewer","Gives the user access to edit Facebook messages."}
            , {"sitecore\\List Manager Editors","Gives the user access to the List Manager application for marketers who need to manage contact lists. This is primarily given to EXM users.&#13;Members of this role are:&#13;-Sitecore\\ECM Users-Sitecore\\ECM Advanced Users"}
            , {"sitecore\\Sitecore Client Account Managing",""}
            , {"sitecore\\Sitecore Client Advanced Publishing",""}
            , {"sitecore\\Sitecore Client Authoring",""}
            , {"sitecore\\Sitecore Client Bucket Management",""}
            , {"sitecore\\Sitecore Client Configuring",""}
            , {"sitecore\\Sitecore Client Designing",""}
            , {"sitecore\\Sitecore Client Developing",""}
            , {"sitecore\\Sitecore Client Maintaining",""}
            , {"sitecore\\Sitecore Client Publishing",""}
            , {"sitecore\\Sitecore Client Securing",""}
            , {"sitecore\\Sitecore Client Social Authoring",""}
            , {"sitecore\\Sitecore Client Translating",""}
            , {"sitecore\\Sitecore Client Users",""}
            , {"sitecore\\Sitecore Limited Content Editor",""}
            , {"sitecore\\Sitecore Limited Page Editor",""}
            , {"sitecore\\Sitecore Local Administrators",""}
            , {"sitecore\\Sitecore Minimal Page Editor",""}
            , {"sitecore\\Social Marketer Message Reviewer",""}
            , {"sitecore\\Social Message Author",""}
            , {"sitecore\\Social Message Workflow Editor",""}
            , {"sitecore\\Social Message Workflow Reviewer",""}
            , {"sitecore\\Twitter Message Reviewer",""}
            , {"sitecore\\ECM Advanced Users","Gives the user full access to all the functionality in the Email Experience Manager. This role is a member of the List Manager Editors role.&#13;Members of this role can:&#13;-Delete a message.&#13;-Change the default settings.&#13;-Open or edit the engagement plan.&#13;-Change the recipient lists of a subscription message.&#13;-Save a message as a subscription message template.&#13;-Change the target device."}
            , {"sitecore\\ECM Users","Gives the user access to all the basic functionality in the Email Experience Manager, such as create, send, and manage messages. This role is a member of the List Manager Editors role"}
        };

    }
}