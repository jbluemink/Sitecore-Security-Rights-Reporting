using System.Collections.Generic;
using Security.Rights.Reporting.Shell.Model;

namespace Security.Rights.Reporting.Shell
{
    public static class DefaultRols
    {

        public static List<DefaultRol> GetDefaultRols()
        {
            var roles = GetDefaultRolsByVersion();
            var returnlist = new List<DefaultRol>();
            foreach (var rol in roles)
            {
                var tmp = new DefaultRol {Rol = rol, Hit = false};
                returnlist.Add(tmp);
            }
            return returnlist;
        }

        public static string[] GetDefaultRolsByVersion()
        {
            if (Sitecore.Configuration.About.Version.StartsWith("9.0.0"))
            {
                return DefaultsRolsSitecore9;
            }
            if (Sitecore.Configuration.About.Version.StartsWith("9.0"))
            {
                return DefaultsRolsSitecore901;
            }
            if (Sitecore.Configuration.About.Version.StartsWith("9.1"))
            {
                return DefaultsRolsSitecore901;
            }
            if (Sitecore.Configuration.About.Version.StartsWith("9.2"))
            {
                return DefaultsRolsSitecore901;
            }
            if (Sitecore.Configuration.About.Version.StartsWith("9."))
            {
                return DefaultsRolsSitecore930;
            }
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
        public static string[] DefaultsRolsSitecore930 =
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
            , "sitecore\\EXM Users"
            , "sitecore\\EXM Advanced Users"
            , "sitecore\\Forms Data Administrator"
            , "sitecore\\Forms Editor"
            , "sitecore\\Forms Publisher"
            , "sitecore\\List Manager Editors"
            , "sitecore\\Marketing Automation Editors"
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
            , "sitecore\\Everyone"
            , "extranet\\Everyone"
            , "default\\Everyone"
            , "Everyone"
        };
        public static string[] DefaultsRolsSitecore901 =
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
            , "sitecore\\EXM Users"
            , "sitecore\\EXM Advanced Users"
            , "sitecore\\Forms Editor"
            , "sitecore\\List Manager Editors"
            , "sitecore\\Marketing Automation Editors"
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
            , "sitecore\\Everyone"
            , "extranet\\Everyone"
            , "default\\Everyone"
            , "Everyone"
        };
        public static string[] DefaultsRolsSitecore9 =
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
            , "sitecore\\Forms Editor"
            , "sitecore\\List Manager Editors"
            , "sitecore\\Marketing Automation Editors"
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
            , "sitecore\\Everyone"
            , "extranet\\Everyone"
            , "default\\Everyone"
            , "Everyone"
        };
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
            , "sitecore\\Everyone"
            , "extranet\\Everyone"
            , "default\\Everyone"
            , "Everyone"
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
            , "sitecore\\Everyone"
            , "extranet\\Everyone"
            , "default\\Everyone"
            , "Everyone"
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
            , "sitecore\\Everyone"
            , "extranet\\Everyone"
            , "default\\Everyone"
            , "Everyone"
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
            , "sitecore\\Everyone"
            , "extranet\\Everyone"
            , "default\\Everyone"
            , "Everyone"
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
            , {"sitecore\\Designer","Gives the user read and write access to the areas of the content tree that are required when changing layout details for individual items and groups of items via template standard values, as well as items required when configuring the Experience Editor Design Pane. &#13;This role also has two of the Sitecore Client roles assigned to it, so if you assign just this role to a user, the Sitecore Client Designing and Sitecore Client Users roles will be automatically assigned to the user. &#13;This role provides access to the Experience Editor Design Pane features and the designer options in the Content Editor.&#13;Note This role is not a member of the Author and Authoring roles, so it does not allow users to edit items."}
            , {"sitecore\\Developer","Gives the user access to content manipulation facilities in the Content Editor, plus all the design and authoring roles normally used by client authors and client designers. It also provides access to more functionality on the ribbon of the Content Editor to allow full development features for users assigned to this role. &#13;This role also has access to the Development Tools menu in the Sitecore menu, which gives the user access to further development tools, such as the Package Designer."}
            , {"sitecore\\Experience Explorer","Removed in Sitecore 9, Gives the user access to the explore mode in the Experience Editor and to manage the Presets of the Explore mode in the Marketing Control Panel.&#13;The role is intended for marketers who set up campaigns and personalization."}
            , {"sitecore\\Forms Data Administrator","New in Sitecore 9.3, Gives users access to the Sitecore Forms application from the Launchpad. The user can export form data and delete submitted form data from the Forms Dashboard. The user can view forms, but is not allowed to edit or save."}
            , {"sitecore\\Forms Editor","New in Sitecore 9, With the Forms Editor role, a user can access the Sitecore Forms application from the Launchpad and is able to create, edit, and delete forms."}
            , {"sitecore\\Forms Publisher","New in Sitecore 9.3, Gives users access to the Sitecore Forms application from the Launchpad. The user can publish forms from the Forms Dashboard. The user can view forms, but is not allowed to edit or save."}
            , {"sitecore\\Facebook Message Reviewer","Removed in Sitecore 9, Gives the user access to edit Facebook messages."}
            , {"sitecore\\Marketing Automation Editors","New in Sitecore 9, Gives the user access to the Marketing Automation application so they can create, edit, and manage marketing automation campaigns. In addition, this role gives the user access to the Marketing Control Panel application so they can create, edit, and manage marketing definitions that are part of the automation campaigns and the Analytics workflow."}
            , {"sitecore\\List Manager Editors","Gives the user access to the List Manager application for marketers who need to manage contact lists. This is primarily given to EXM users.&#13;Members of this role are:&#13;-Sitecore\\ECM Users&#13;-Sitecore\\ECM Advanced Users"}
            , {"sitecore\\Sitecore Client Account Managing","Gives the user access to maintain users, roles, and domains in the Access Manager, the Domain Manager, the Role Manager, and the User Manager."}
            , {"sitecore\\Sitecore Client Advanced Publishing","Gives the user access to the publishing functionality in the Experience Editor and in the Content Editor.&#13; This role has access to republish in addition to the same access rights as the Sitecore Client Publishing role."}
            , {"sitecore\\Sitecore Client Authoring","Gives the user access to basic item editing features. The role is intended for client users to allow access to basic authoring features. The role only influences the Content Editor commands available, it does not influence the Desktop interface's menu or the Control Panel commands."}
            , {"sitecore\\Sitecore Client Bucket Management","Gives the user access rights to the //sitecore//content//Applications//Content Editor//Ribbons//Chunks//Item Buckets item in the Core database."}
            , {"sitecore\\Sitecore Client Configuring","Gives the user access to the Content Editor features that allow a user to change the configuration details associated with items, such as the icon associated with the item and whether the item is protected or hidden.&#13;This role adds the Configure tab to the Content Editor and displays the Appearance, Masters, and Attribute groups."}
            , {"sitecore\\Sitecore Client Designing","Gives the user access to Experience Editor Design pane features that allow a user to set layout details associated with items in the Sitecore client."}
            , {"sitecore\\Sitecore Client Developing","Gives the user access to application shortcuts and commands commonly required by developers."}
            , {"sitecore\\Sitecore Client Maintaining","Gives the user access to template editing features and reporting tools. This role is intended for Sitecore super-users and developers"}
            , {"sitecore\\Sitecore Client Publishing","Gives the user access to the publishing functionality in the Experience Editor and in the Content Editor. Users that are not members of the Publishing role may still be able to publish, but only via automatic publishing features associated with Workflows.&#13;This role has access to Incremental publish, Smart publish, and Publish related items."}
            , {"sitecore\\Sitecore Client Securing","Gives the user access rights to security features in the Content Editor and other relevant applications.&#13;This role is intended for users who need to maintain users and access rights. "}
            , {"sitecore\\Sitecore Client Social Authoring","Removed in Sitecore 9, Gives the user access to create messages and post them to social networks.&#13;The role is a member of the Sitecore\\Author role."}
            , {"sitecore\\Sitecore Client Translating","Gives the user access to Sitecore’s translation features, such as the command Scan the database for untranslated fields.&#13;The role is intended for content authors who need access to languages other than the site's default language."}
            , {"sitecore\\Sitecore Client Users","Gives the user minimal access to Sitecore. With this role, the user can log in to the Sitecore Desktop, but will not have access to any applications.&#13;All of the other Sitecore client roles are members of the Sitecore Client Users role, which means that users in any Sitecore client role are automatically members of the Sitecore Client Users role."}
            , {"sitecore\\Sitecore Limited Content Editor","Limits the amount of Content Editor functionality provided by the Sitecore Client Authoring role (which is still required for users given this role).&#13;When a content author is assigned this role, they only have access to the Home, Review, and Publish tabs on the Content Editor ribbon and have no access to copy, move, or sort from the item's right-click menu."}
            , {"sitecore\\Sitecore Limited Page Editor","Restricts the amount of functionality that is available in the Experience Editor. However, unlike the Minimal Page Editor role, users assigned this role see a simple version of the standard Experience Editor ribbon.&#13;This role limits the amount of functionality provided by the Sitecore Client Authoring role (which is still required for users given this role), but allows more functional access than the Sitecore Minimal Page Editor role."}
            , {"sitecore\\Sitecore Local Administrators","Sitecore local administrators can log in to Sitecore and manage the security applications (including assigning security) within that domain. A local administrator cannot create domains or associate domains to users.&#13;Note&#13;The local administrator role is a member of the Sitecore Client Users, Sitecore Client Account Managing, and Sitecore Client Securing roles. You can use this role as a shortcut to adding these roles to a user."}
            , {"sitecore\\Sitecore Minimal Page Editor","Restricts the amount of functionality provided in the Experience Editor to the absolute minimum and users who have been assigned this role do not have access to the Experience Editor ribbon. For example, members of the Minimal Page Editor role cannot switch personalization variations.&#13;This role limits the amount of functionality provided by the Sitecore Client Authoring role (which is still required for users given this role)."}
            , {"sitecore\\Social Marketer Message Reviewer","Removed in Sitecore 9, Gives the user access to edit social marketer messages."}
            , {"sitecore\\Social Message Author","Removed in Sitecore 9,Gives the user access to create, edit, and remove all social marketer messages."}
            , {"sitecore\\Social Message Workflow Editor","Removed in Sitecore 9, Gives the user access to use the Draft state and its commands in the Social Message workflow and the Social Marketer Message workflow."}
            , {"sitecore\\Social Message Workflow Reviewer","Removed in Sitecore 9, Gives the user access to use the Awaiting Approval state and its commands in the Social Message workflow. In addition, the user also has access to the Awaiting Post Review, Post Accepted, and Post Removed states and their commands in the Social Marketer Message workflow."}
            , {"sitecore\\Twitter Message Reviewer","Removed in Sitecore 9, Gives the user access to edit Twitter messages."}
            , {"sitecore\\ECM Advanced Users","For Email Experience Manager Module 3.4 and lower.&#13;Gives the user full access to all the functionality in the Email Experience Manager. This role is a member of the List Manager Editors role.&#13;Members of this role can:&#13;-Delete a message.&#13;-Change the default settings.&#13;-Open or edit the engagement plan.&#13;-Change the recipient lists of a subscription message.&#13;-Save a message as a subscription message template.&#13;-Change the target device."}
            , {"sitecore\\ECM Users","For Email Experience Manager Module 3.4 and lower.e&#13;Gives the user access to all the basic functionality in the Email Experience Manager, such as create, send, and manage messages. This role is a member of the List Manager Editors role"}
            , {"sitecore\\EXM Users","For Email Experience Manager 3.5 and higher. Gives the user access to all the basic functionality in the Email Experience Manager, such as create, send, and manage messages. This role is a member of the List Manager Editors role."}
            , {"sitecore\\EXM Advanced Users","For Email Experience Manager 3.5 and higher. Gives the user full access to all the functionality in the Email Experience Manager. This role is a member of the List Manager Editors role.&#13;Members of this role can:&#13;-Delete a message.&#13;-Change the default settings.&#13;-Open or edit the engagement plan.&#13;-Change the recipient lists of a subscription message.&#13;-Save a message as a subscription message template.&#13;-Change the target device."}
            , {"sitecore\\Sitecore Client Forms Author", "Web Forms for Marketers Module&#13;Gives the user access to the minimum features of the Web Forms for Marketers module. This role allows the user to:&#13;-Insert a new form&#13;-Edit an existing form&#13;-View the Summary report"}
            , {"sitecore\\Sitecore Marketer Form Author", "Web Forms for Marketers Module&#13;This role inherits access rights from the following roles, and can be used as a shortcut to assign a user all the access rights from those roles:&#13;-Sitecore Client Form Author&#13;-Analytics Maintaining&#13;-Analytics Reporting "}
            , {"sitecore\\JSS Import Service Users","Denying item:write and item:create access to the sitecore\\JSS Import Service Users role or the specific import user allows a Sitecore developer or admin to limit items that the front-end developer can create and update."}
            , {"sitecore\\Publishing Service Administrator","Publishing Service module&#13;This role has full access to the Publishing Service features, including the full republish functionality on the Publishing Dashboard. The Sitecore Client Publishing and the Sitecore Client Advanced Publishing roles do not grant access to the full republish functionality."}
            , {"sitecore\\PowerShell Extensions Remoting","Sitecore PowerShell Community Module&#13;If powershell/services/remoting enabled=true in the config, this is the default rol for getting authorization for access to use SPE Remoting, Be aware that it is dependent on the config, since multiple or other roles can be defined. Typical the deploy user has this role if deployment is automate with PowerShell." }
            , {"Everyone", "All users are assigned the Everyone role.This role is a virtual role. It mirrors the Windows Everyone group. It does not exist in the role database but is only used for assigning and resolving security. You can use the Everyone role to assign access rights to every user or every user in a specific domain. The Everyone role is available as both a global role and a local role in every domain."}
            , {"sitecore\\Everyone", "All users are assigned the Everyone role. This role is a virtual role. It mirrors the Windows Everyone group. It does not exist in the role database but is only used for assigning and resolving security. You can use the Everyone role to assign access rights to every user or every user in a specific domain. The Everyone role is available as both a global role and a local role in every domain."}
            , {"extranet\\Everyone", "All users are assigned the Everyone role. This role is a virtual role. It mirrors the Windows Everyone group. It does not exist in the role database but is only used for assigning and resolving security. You can use the Everyone role to assign access rights to every user or every user in a specific domain. The Everyone role is available as both a global role and a local role in every domain."}
            , {"default\\Everyone", "All users are assigned the Everyone role. This role is a virtual role. It mirrors the Windows Everyone group. It does not exist in the role database but is only used for assigning and resolving security. You can use the Everyone role to assign access rights to every user or every user in a specific domain. The Everyone role is available as both a global role and a local role in every domain."}
        };

    }
}