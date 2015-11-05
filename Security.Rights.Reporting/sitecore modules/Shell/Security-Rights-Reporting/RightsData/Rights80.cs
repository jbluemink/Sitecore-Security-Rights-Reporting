using System.Collections.Generic;
using Security.Rights.Reporting.Shell.Model;

namespace Security.Rights.Reporting.Shell.RightsData
{
    public static class Rights80
    {
 
        public static List<string[]> Core802Replace = new List<string[]> 
        {
            new[]
            {
                "/sitecore/client/Applications/PathAnalyzer/PageAnalyzer",@""
            }
            ,new[]
            {
                "/sitecore/client/Applications/PathAnalyzer/PageAnalyzerDialog",@""
            }
            ,new[]
            {
                "/sitecore/client/Applications/PathAnalyzer/PathExplorer",@""
            }
        };

        public static List<string[]> Core801 = new List<string[]> 
        {
            new[]
            {
                "/sitecore/client/Applications/List Manager/Taskpages/Contact list/PageSettings/ListActions Parameters/ListActionColumn/ListActionGroup/Unlock list",@"ar|sitecore\Everyone|pe|!*|"
            }
        };

        public static List<string[]> Core = new List<string[]> 
        {
 new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Social",@"ar|sitecore\Sitecore Client Social Authoring|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Appearance/Set Contextual Tab",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Security/Role Manager/Ribbon/Home/Tools/Security Editor",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Full/Buttons/HTML View",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Clipboard/Paste",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Security",@"ar|sitecore\Sitecore Client Securing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Validation/Field Type Validation Rules/Validation Rules/Workflow",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Copy To/Transfer",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Analytics - Attributes/Attributes",@"ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Analytics Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Proofing/Subscribe",@"ar|sitecore\Sitecore Client Translating|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/View",@"ar|sitecore\Sitecore Limited Page Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Medium/WebEdit Buttons/Bold",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Clipboard/Cut",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Sitecore on the Net",@"ar|sitecore\Sitecore Client Users|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Database/Database Usage",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Dialogs/Rebuild link database",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/templates/System/Validation/Global Validation Rules/Validation Rules/Validate Button",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Security Tools/Userinfo",@"ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Templates/Template Builder/Ribbon/Options/Sorting/Move Up",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Separator",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Lifetime/Lifetime/__Hide version",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Common/Layouts/Composite/ReviewTest/PageSettings/Security/Statistics",@"ar|sitecore\Analytics Advanced Testing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Context Menues/Default/Sorting",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Preferences/Change wallpaper",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Left",@"ar|sitecore\Sitecore Client Users|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Templates/Template Builder/Ribbon/Options/Sorting/Move First",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Security/Assign",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Default/WebEdit Buttons/Bold",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Statistics/Statistics/__Created by",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Operations/Copy To",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/system/Settings/Security/Policies/Page Editor/Extended features/Testing",@"ar|sitecore\Sitecore Minimal Page Editor|pe|-item:read|ar|sitecore\Sitecore Client Users|pe|!*|ar|sitecore\Sitecore Limited Page Editor|pe|-item:read|ar|sitecore\Analytics Testing|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs",@"ar|sitecore\Sitecore Client Users|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Subscribe",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Locks/My Items",@"ar|sitecore\Sitecore Client Translating|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/client/Applications/ExperienceEditor/Pipelines",@"au|extranet\Anonymous|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Full/WebEdit Buttons/Italic",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Layouts/IDE/Toolbar/File/Publish",@"ar|sitecore\Sitecore Client Publishing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Preview",@"ar|sitecore\Sitecore Client Designing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Common/System/Security/BottomButtonPanel",@"ar|sitecore\Analytics Advanced Testing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Applications/Control Panel/Globalization",@"ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Security/Domain Manager/Ribbon/Home/Tools/Access Viewer",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Security/Domain Manager",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Securing|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Divider 2",@"ar|sitecore\Sitecore Client Users|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Strips/Configure/Item Buckets",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Publish Restrictions",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Publishing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Context Menues/Default/Rename",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Item Buckets/Bucket",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/system/Settings/Security/Policies/Page Editor/Can Edit",@"ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Workbox",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Analytics - Behavior",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Analytics Reporting|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Layout Presets",@"ar|sitecore\Sitecore Client Designing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Optimization Rendering Buttons/View Details",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Limited Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Template/Change Template",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks",@"ar|sitecore\Sitecore Client Users|pd|-item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Lifetime/Lifetime/__Valid from",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/system/Settings/Buckets/Settings/Search Operations/Marketing/Apply Campaigns to All Items",@"ar|sitecore\Author|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Translate",@"ar|sitecore\Sitecore Client Translating|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Layouts/IDE",@"ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Security Tools/User Manager",@"ar|sitecore\Sitecore Client Account Managing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Preferences/Change password",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Preview",@"ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/View/Hidden Items",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Proofing",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Serialize/Serialize Item",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/system/Settings/Buckets/Views/ID View",@"ar|sitecore\Author|pe|-item:read|pd|-item:read|ar|sitecore\Analytics Personalization|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/View/Show/Show Control bar",@"ar|sitecore\Sitecore Client Users|pe|!*|ar|sitecore\Analytics Personalization|pe|!*|+item:read|ar|sitecore\Analytics Testing|pe|!*|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Reporting Tools",@"ar|sitecore\Sitecore Client Users|pd|-item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Security/Security Editor/Ribbon/Home/Tools/User Manager",@"ar|sitecore\Sitecore Client Account Managing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Security/Role Manager",@"ar|sitecore\Sitecore Client Account Managing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Workflow/Workflow/__Workflow state",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Reporting Tools/Scan for Broken Links",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Indexing/Generate SOLR Schema",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Goto/Branch",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Analytics - Attributes/Goals",@"ar|sitecore\Analytics Content Profiling|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Duplicate/Clone",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Operations/Duplicate",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Versions",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Development Tools/Package Designer",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Template/Edit Template",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Style",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Page Editor/Edit/My Items",@"ar|sitecore\Sitecore Client Translating|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Layout/Layout/__Final Renderings",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Default/Buttons/HTML View",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Page Editor/Publish/Publish",@"ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Sitecore Client Publishing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Developer - Template",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Security/Security Editor",@"ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/Marketing/Path Analyzer",@"ar|sitecore\Analytics Reporting|pe|+item:read|"}
,new[] {"/sitecore/system/Settings/Security/Policies/Login/Can Kick",@"ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|##Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Security/Security Editor/Ribbon/Home/Security/Columns",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Publish",@"ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Sitecore Client Publishing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Workflow/Workflow/__Default workflow",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Insert Options/Reset",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Divider 1",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Reports/Broken Links",@"ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Indexing",@"ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|-item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Icon",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/layout",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Optimization/Status",@"ar|sitecore\Sitecore Client Users|pe|!*|ar|sitecore\Analytics Testing|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Database/Rebuild search index",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Workflow",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Left/Marketing Control Panel",@"ar|sitecore\Analytics Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Analytics Reporting|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/system",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Workbox",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Security/Access Viewer",@"ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Full/WebEdit Buttons/Insert Image",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Analytics/Engagement Automation Monitor",@"ar|Everyone|pe|!*|pd|!*|ar|sitecore\Analytics Reporting|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Statistics/Statistics/__Updated by",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Default Rendering Buttons/Personalize",@"ar|sitecore\Sitecore Minimal Page Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Recycle bin",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Menus/Other Views/Preview",@"ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Publishing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Versions/Compare",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Item Clones",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Keyboard Map",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Feed Presentation",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Common/System/Navigation/Reports/MostActive",@"ar|Everyone|pe|!*|pd|!*|ar|sitecore\Analytics Management Reporting|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/client/Applications/PathAnalyzer/PageAnalyzer",@"ar|sitecore\Analytics Reporting|pe|+item:read|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Default/WebEdit Buttons/Italic",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Layouts/PageDesigner/Ribbon/Design/Devices/Devices",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/system/Settings/Security/Policies/Shell/Can Switch Databases",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/System",@"ar|sitecore\Sitecore Client Users|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Help/Help/__Short description",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/View/Content Tree",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Publish",@"ar|sitecore\Sitecore Client Publishing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/templates/System/Layout/Sections/Rendering Options/Editor Options/Datasource Location",@"ar|sitecore\Sitecore Client Developing|pd|+field:write|pe|+field:write|ar|sitecore\Sitecore Client Maintaining|pd|+item:delete|+item:rename|+item:write|pe|+item:delete|+item:rename|+item:write|ar|sitecore\Everyone|pd|+field:read|+item:read|!*|pe|+field:read|+item:read|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Context Menues/Default/Copying",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/system/Settings/Security/Policies/Login/Can Boost",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|##Everyone|p*|!*|"}
,new[] {"/sitecore/templates/System/Layout/Sections/Rendering Options/Editor Options/Compatible Renderings",@"ar|sitecore\Sitecore Client Developing|pd|+field:write|pe|+field:write|ar|sitecore\Sitecore Client Maintaining|pd|+item:delete|+item:rename|+item:write|pe|+item:delete|+item:rename|+item:write|ar|sitecore\Everyone|pd|+field:read|+item:read|!*|pe|+field:read|+item:read|!*|"}
,new[] {"/sitecore/content/Applications/Security/Role Manager/Ribbon/Home/Tools/Access Viewer",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Optimization/Lists",@"ar|sitecore\Analytics Testing|pe|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Applications/Desktop/Context Menues/Desktop Link Menu",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/New",@"ar|sitecore\Sitecore Client Users|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/Preview/Buttons/Ribbon",@"ar|sitecore\Sitecore Minimal Page Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/ContentEditing/RecycleBin",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Search",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Designing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Validation/Global Validation Rules/Validation Rules/Quick Action Bar",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Analytics - View/Details",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Analytics Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/View/Standard Fields",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Analytics/Engagement Automation Supervisor",@"ar|sitecore\Analytics Maintaining|pe|+item:read|ar|Everyone|pe|!*|pd|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Item Clones/Clone",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Statistics/Statistics/__Revision",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Applications/Desktop/Tray/Database",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Publish/Preview",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Publishing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/Chunks/Modes/Page Editor",@"ar|sitecore\Sitecore Minimal Page Editor|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Limited Page Editor|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Publishing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Recycle Bin",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Workflow/Workflow/__Workflow",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Operations",@"ar|sitecore\Sitecore Limited Content Editor|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/system/Settings/Buckets/Settings/Search Operations/Information Architecture/Serialize Items",@"ar|sitecore\Author|pe|-item:read|pd|-item:read|ar|sitecore\Developer|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Layout",@"ar|sitecore\Sitecore Client Designing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Security Presets/Presets",@"ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/ContentEditing/ContentEditor",@"ar|sitecore\Sitecore Client Designing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/Marketing/MarketingCenter",@"ar|sitecore\Analytics Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Analytics Reporting|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Lifetime/Lifetime/__Valid to",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Default Placeholder Buttons/Settings",@"ar|sitecore\Sitecore Client Developing|pe|+item:delete|+item:create|+item:rename|+item:read|+item:write|ar|sitecore\Everyone|pe|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/View",@"ar|sitecore\Sitecore Client Designing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/system/Settings/Security/Policies/Publish/Can Perform Incremental Publish",@"ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Sitecore Client Publishing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Common/Layouts/Composite/ReviewTest/PageSettings/Security/Scheduling",@"ar|sitecore\Analytics Advanced Testing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right",@"ar|sitecore\Sitecore Client Users|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Show",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/client/Applications/ExperienceAnalytics",@"ar|sitecore\Developer|pe|+item:rename|+item:write|+item:read|+item:delete|+item:create|pd|+item:rename|+item:delete|+item:write|+item:create|+item:read|ar|sitecore\Analytics Reporting|pe|+item:read|pd|+item:read|ar|sitecore\Everyone|pe|!*|pd|!*|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Medium/WebEdit Buttons/Insert Link",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Editors/Analytics/Engagement Plan",@"ar|Everyone|pe|!*|pd|!*|ar|sitecore\Analytics Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Analytics Reporting|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Security Tools",@"ar|sitecore\Sitecore Client Account Managing|pd|-item:read|pe|+item:read|ar|sitecore\Sitecore Client Securing|pd|-item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Experience/Date",@"ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/system/Settings/Buckets/Settings/Search Operations/Information Architecture/Apply Security Rule",@"ar|sitecore\Author|pe|-item:read|pd|-item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|ar|sitecore\Developer|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Advanced/Url/Aliases",@"ar|sitecore\Sitecore Client Translating|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Languages/More Languages",@"ar|Everyone|pe|!*|-item:read|pd|!*|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Editing/HttpEdit",@"ar|sitecore\Sitecore Limited Content Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Fields",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Editors/Analytics/Campaign Category Dashboard",@"ar|Everyone|pe|!*|pd|!*|ar|sitecore\Analytics Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Analytics Reporting|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Publish/Publish",@"ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Sitecore Client Publishing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Desktop/Context Menues/Startbar/Divider 0",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/templates/System/Templates/Template field/Validation Rules/Validate Button",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Development Tools/Install Package",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Archive/Archive Version Now",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/system/Languages",@"ar|sitecore\Sitecore Client Developing|pe|+language:read|+language:write|pd|+language:read|+language:write|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Sorting",@"ar|sitecore\Sitecore Limited Content Editor|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Workflow Edit",@"ar|sitecore\Sitecore Limited Content Editor|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Proofing/Markup",@"ar|sitecore\Sitecore Client Translating|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Versions/Add Version",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Delete/Delete Subitems",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Attributes/Hide",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Reports/LogViewer",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Control Panel/Preferences/Regional and language options",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Layout/Sections/Rendering Options/Editor Options/Page Editor Buttons",@"ar|sitecore\Sitecore Client Developing|pd|+field:write|pe|+field:write|ar|sitecore\Sitecore Client Maintaining|pd|+item:delete|+item:rename|+item:write|pe|+item:delete|+item:rename|+item:write|ar|sitecore\Everyone|pd|+field:read|+item:read|!*|pe|+field:read|+item:read|!*|"}
,new[] {"/sitecore/templates/System/Templates/Template field/Validation Rules/Validator Bar",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text IDE/Buttons",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/Security/UserManager",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/Marketing/List Manager",@"ar|sitecore\List Manager Editors|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Left/Template Manager",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Show/ID",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Context Menues/Default/Divider 2",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Templates/Change Template",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Control Panel/Database",@"ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Schedule/Archive",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Control Panel/Analytics",@"ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Analytics Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Preferences/Change personal information",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Workflow/WorkflowPanel",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Context Menues/Default/Paste",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Sorting/Move Last",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/Marketing/ExperienceProfile",@"ar|sitecore\Analytics Reporting|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/system/Settings/Security/Policies/Publish/Can Perform Smart Publish",@"ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Sitecore Client Publishing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/Marketing/Experience Optimization",@"ar|sitecore\Analytics Management Reporting|pe|+item:read|ar|sitecore\Analytics Testing|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Reports/LogViewer/Commands/Download",@"ar|sitecore\Sitecore Client Users|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/Tools",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Left/Media Library",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit",@"ar|sitecore\Sitecore Minimal Page Editor|pe|-item:read|pd|-item:read|ar|sitecore\Sitecore Client Users|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Publish/Publish Item",@"ar|sitecore\Sitecore Client Publishing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Page Editor/Social/Messages",@"ar|sitecore\Sitecore Client Users|pe|!*|ar|sitecore\Sitecore Client Social Authoring|pe|+item:read|pd|+item:read|ar|sitecore\Analytics Content Profiling|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/system/Settings/Buckets/Settings/Search Operations/Information Architecture/Delete All Items in List",@"ar|sitecore\Author|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/Tools/Desktop",@"ar|sitecore\Sitecore Client Users|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Security/Security Editor",@"ar|sitecore\Sitecore Client Account Managing|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Securing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Left/Security Editor",@"ar|sitecore\Sitecore Client Securing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Appearance",@"ar|sitecore\Sitecore Client Configuring|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/system/Field types/Social/Campaign Tree/Menu/Create Campaign",@"ar|sitecore\Analytics Maintaining|pe|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Editors/Layouts/Preview/Ribbon/Design/Devices/Devices",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Attributes",@"ar|sitecore\Sitecore Client Configuring|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/New/Insert from Template",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Tasks/Tasks/__Archive date",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Applications/Layouts/IDE/Toolwindows/Templates",@"ar|sitecore\Sitecore Client Developing|pe|!*|ar|sitecore\Sitecore Client Users|pe|!*|ar|sitecore\Sitecore Client Maintaining|pe|!*|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Experience",@"ar|sitecore\Sitecore Limited Page Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/Security/SecurityEditor",@"ar|sitecore\Sitecore Client Securing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/Security/RoleManager",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Security Tools/User manager",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/Marketing",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Remove Version/Remove Versions",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/templates/System/Validation/Field Type Validation Rules/Validation Rules/Validate Button",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Analytics - View",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Analytics Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Reminder/Clear Reminder",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Optimization/Page Reports",@"ar|sitecore\Analytics Testing|pe|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Sorting/Move Down",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Security/User Manager/Ribbon/Home/Tools/Security Editor",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Analytics/Executive Dashboard",@"ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Analytics Reporting|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Appearance/Set Tree Node Style",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Medium/Buttons/HTML View",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Publish Restrictions/Change",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Layouts/IDE/Toolbar/Security/Security Editor",@"ar|sitecore\Sitecore Client Account Managing|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Securing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Menus/Other Views/Debug",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|"}
,new[] {"/sitecore/content/Applications/Control Panel/Database/Rebuild link database",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/system/Settings/Security/Policies/Shell/Can Search",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Security/User Manager",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Securing|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Help/Help/__Help link",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Default/WebEdit Buttons/Insert Link",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Administration/Install Package",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/System/Licenses",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Attributes/Protect",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Write/Save",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Security/Access Viewer/Ribbon/Home/Tools",@"ar|sitecore\Sitecore Client Account Managing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Security/Details",@"ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Serialize/Update Tree",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Analytics/Analytics Reports",@"ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Analytics Reporting|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Advanced/Advanced/__Standard values",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Serialize",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Reporting Tools/Log Viewer",@"ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Fields/Reset",@"ar|sitecore\Sitecore Client Translating|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Common/System/Security/IndividualModeOnly",@"ar|sitecore\Analytics Management Reporting|pe|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/System/License Details",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Security/Role Manager/Ribbon/Home/Serialization",@"ar|Everyone|pe|!*|ar|sitecore\Sitecore Client Developing|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Rename/Rename",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Security/Edit User",@"ar|sitecore\Sitecore Client Account Managing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Administration",@"ar|sitecore\Sitecore Client Users|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Reports",@"ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|-item:read|ar|sitecore\Sitecore Client Authoring|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Analytics/Engagement Automation Designer",@"ar|sitecore\Analytics Maintaining|pe|+item:read|ar|Everyone|pe|!*|pd|!*|"}
,new[] {"/sitecore/content/Applications/Security/Security Editor/Ribbon/Home/Tools/Access Viewer",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/templates/System/Validation/Global Validation Rules/Validation Rules/Workflow",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/content/Applications/Security/Item Security Editor",@"ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/system/Marketing Control Panel",@"ar|sitecore\Analytics Maintaining|pd|+item:delete|+item:create|+item:rename|+item:write|pe|+item:create|"}
,new[] {"/sitecore/content/Applications/Control Panel/Globalization/Export Language",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Layouts/IDE/Toolbar/Security/User Manager",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:write|pe|+item:write|ar|sitecore\Sitecore Client Securing|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Validation Rules/Validation Rules/__Validate Button Validation Rules",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/content/Applications/Tools/Installer",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|p*|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/FXM/Buttons/Ribbon",@"ar|sitecore\Sitecore Minimal Page Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Reports/Untranslated Fields",@"ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Translating|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Validation/Field Type Validation Rules/Validation Rules/Quick Action Bar",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Translate/Translate",@"ar|sitecore\Sitecore Client Translating|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Desktop/Context Menues/Desktop Background Menu",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Security/Security Editor/Ribbon/Home/Security/Assign",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/System/Exit",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Common/System/Navigation/Reports/HighestEffect",@"ar|Everyone|pe|!*|pd|!*|ar|sitecore\Analytics Management Reporting|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Help/Help/__Long description",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Tasks/Tasks/__Reminder text",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Security Presets",@"ar|sitecore\Sitecore Client Securing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Common Field Buttons/Personalize",@"ar|sitecore\Sitecore Minimal Page Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Template Manager",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/View/Show",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Translating|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Designing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/View/Entire Tree",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Left/Publish Site",@"ar|sitecore\Sitecore Client Publishing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/system/Field types/Deprecated Types",@"ar|Everyone|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Full/Buttons",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Validation Rules/Validation Rules/__Workflow Validation Rules",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/ContentEditing",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Security",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Administration/Licenses",@"ar|sitecore\Sitecore Client Users|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Workflow Edit/Edit",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Page Urls",@"ar|sitecore\Sitecore Client Configuring|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|ar|sitecore\Analytics Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Validation/Field Type Validation Rules/Validation Rules/Validator Bar",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/content/Applications/Security/Security Editor/Ribbon/Home/Tools",@"ar|sitecore\Sitecore Client Account Managing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Home",@"ar|extranet\Guest|pe|+item:read|pd|+item:read|ar|sitecore\##Everyone|pe|+item:create|+item:delete|+item:publish|+item:read|+item:read|+item:write|pd|+item:create|+item:delete|+item:publish|+item:read|+item:read|+item:write|"}
,new[] {"/sitecore/content/Applications/Content Editor/Context Menues/Default/Divider 1",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Page Editor",@"ar|sitecore\Sitecore Client Designing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Full/WebEdit Buttons/Bold",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Templates/Template Manager",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Templates/Template Builder/Ribbon/Options/Sorting/Move Down",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Security/Access Viewer/Ribbon/Home/Tools/Security Editor",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/Security/AccessViewer",@"ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Analytics/Marketing Control Panel",@"ar|sitecore\Analytics Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Analytics Reporting|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Security/Security Editor/Ribbon/Home/Attributes/Protect",@"ar|sitecore\Sitecore Client Configuring|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Sorting/Move Up",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Default/WebEdit Buttons/Insert Image",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Security/Security/__Security",@"ar|sitecore\Sitecore Client Securing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Archive/Set Archive",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Archive",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Medium/WebEdit Buttons/Italic",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Dialogs/CreateTest/PageSettings/Tabs/Objective",@"ar|Everyone|pe|!*|pd|!*|ar|sitecore\Analytics Advanced Testing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Insert Options/Assign",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/system/Settings/Buckets/Search Types/Debug",@"ar|sitecore\Author|pe|-item:read|"}
,new[] {"/sitecore/system/Settings/Key Map/Find",@"ar|sitecore\Limited Search|pe|-item:read|pd|-item:read|ar|sitecore\Bucket Management|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Sortorder",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Globalization/Import Language",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Security/Security Editor/Ribbon/Home/Users/Select",@"ar|sitecore\Analytics Maintaining|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Security Tools/Role Manager",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Common/System/Navigation/Reports/Leaderboard",@"ar|Everyone|pe|!*|pd|!*|ar|sitecore\Analytics Management Reporting|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Security/Domain Manager",@"ar|sitecore\Sitecore Client Account Managing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Image Editor",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Analytics - Attributes",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Analytics Content Profiling|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Analytics Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Editors/Analytics/Campaign Dashboard",@"ar|Everyone|pe|!*|pd|!*|ar|sitecore\Analytics Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Analytics Reporting|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Common/System/ReportingViews",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/templates/System/Item Buckets/Saved Search/__Standard Values",@"ar|sitecore\Everyone|pe|-item:read|au|$currentuser|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Page Editor/Publish/Change Restrictions",@"ar|sitecore\Sitecore Limited Content Editor|pe|-item:read|ar|sitecore\Sitecore Client Authoring|pe|+item:read|ar|sitecore\Sitecore Client Publishing|pe|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Serialize/Serialize Tree",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Publish/Publish Site",@"ar|sitecore\Sitecore Client Publishing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Favorites/Organize",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Item Buckets - Bucketable",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|^*|pd|+item:read|^*|ar|sitecore\Sitecore Client Bucket Management|pe|^*|+item:read|pd|^*|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Preview",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Security/Access Viewer/Ribbon/Home/Security/Columns",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Left/Content Editor",@"ar|sitecore\Sitecore Client Designing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/My Strip",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Designing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/system/Settings/Analytics",@"ar|sitecore\Sitecore Client Developing|pd|+item:delete|+item:create|+item:rename|+item:write|pe|+item:create|"}
,new[] {"/sitecore/masters/System/__Image/$name",@"ar|sitecore\Admin|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Security/Domain Manager/Ribbon/Home/Domains/New",@"ar|Everyone|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Serialize/Update Item",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/Security",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Control panel",@"ar|sitecore\Sitecore Client Users|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Reminder/Set Reminder",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Subscribe/Subscribe",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/system/Settings/Buckets/Settings/Search Operations/Presentation/Apply Presentation to All Items",@"ar|sitecore\Author|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Templates/Template Builder/Ribbon/Options/Sorting/Move Last",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Serialize/Update Database",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Display name",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Database/Transfer to Database",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Show/Path",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/system/Settings/Security/Policies/Page Editor/Can Design",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Designing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Sitecore Limited Page Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Versions/Remove",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Operations/Delete",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Common/Layouts/Composite/ReviewTest/PageSettings/Security/TrafficAllocation",@"ar|sitecore\Analytics Advanced Testing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Page Editor/Social",@"ar|sitecore\Sitecore Client Social Authoring|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Ownership",@"ar|sitecore\Sitecore Client Securing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Navigate",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Designing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Goto/Template",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Subitems Sorting",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Common/System/Security/TestObjective",@"ar|sitecore\Analytics Advanced Testing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Advanced/Url",@"ar|sitecore\Analytics Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/Marketing/Experience Analytics",@"ar|sitecore\Everyone|pe|!*|pd|!*|ar|sitecore\Analytics Reporting|pe|+item:read|ar|sitecore\Developer|pe|+item:rename|+item:create|+item:delete|+item:read|+item:write|"}
,new[] {"/sitecore/content/Applications/Search/RebuildSearchIndex",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/templates/System/Validation/Global Validation Rules/Validation Rules/Validator Bar",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Common/Layouts/Composite/ReviewTest/PageSettings/Security/TestObjective",@"ar|sitecore\Analytics Advanced Testing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Write",@"ar|sitecore\Sitecore Client Designing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/system/Settings/Security/Policies/Publish/Can Perform Republish",@"ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Sitecore Client Advanced Publishing|pe|+item:read|!*|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Common Field Buttons/Edit variations",@"ar|sitecore\Sitecore Minimal Page Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Editor",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/ExperienceAnalytics Stylesheet",@"ar|sitecore\Developer|pe|+item:rename|+item:write|+item:read|+item:delete|+item:create|pd|+item:rename|+item:delete|+item:write|+item:create|+item:read|ar|sitecore\Analytics Reporting|pe|+item:read|ar|sitecore\Everyone|pe|!*|pd|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Appearance/Set Help",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Default/WebEdit Buttons/Underline",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Full/WebEdit Buttons/Underline",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/system/Settings/Buckets/Settings/Search Operations/Marketing/Apply Profile Score to All Items",@"ar|sitecore\Author|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Security/User Manager/Ribbon/Home/Tools/Access Viewer",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Clipboard",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Debug",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Security",@"ar|sitecore\Sitecore Client Account Managing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Page Editor/New/Presets",@"ar|sitecore\Sitecore Limited Page Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Layout Presets/Presets",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Operations/Move To",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Publish/Page Editor",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Publishing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Control Panel/Database/Clean Up Databases",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Security/Domain Manager/Ribbon/Home/Tools/Security Editor",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/System/Application Options",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Indexing",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Template",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Context Menues/Default/Duplicate",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Optimization",@"ar|sitecore\Sitecore Limited Page Editor|pe|-item:read|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Common/System/Navigation/Reports/BestGuessing",@"ar|Everyone|pe|!*|pd|!*|ar|sitecore\Analytics Management Reporting|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/system/Settings/Analytics/Reports",@"ar|sitecore\Everyone|pd|-item:read|pe|-item:read|ar|sitecore\Analytics Reporting|pd|+item:delete|+item:create|+item:rename|+item:read|+item:write|pe|+item:delete|+item:create|+item:rename|+item:read|+item:write|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/View/Raw Values",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/templates/System/Templates/Template field/Validation Rules/Quick Action Bar",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Tasks/Tasks/__Reminder recipients",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Search",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Security/Access Viewer/Ribbon/Home/Tools/User Manager",@"ar|sitecore\Sitecore Client Account Managing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Templates/Template Builder",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Editors",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Dialogs/CreateTest/PageSettings/Tabs/Variables/PageSettings/Statistics Security",@"ar|sitecore\Analytics Advanced Testing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Page Editor/View Options For Limited Roles",@"ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Sitecore Limited Page Editor|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Advanced/Layout",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Designing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Publish/Publishing Viewer",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Publishing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Divider 3",@"ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Security/User Manager/Ribbon/Home/Serialization",@"ar|Everyone|pe|!*|ar|sitecore\Sitecore Client Developing|pe|+item:read|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Medium/WebEdit Buttons/Underline",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/templates/System/Layout/Sections/Rendering Options/Editor Options/Datasource Template",@"ar|sitecore\Sitecore Client Developing|pd|+field:write|pe|+field:write|ar|sitecore\Sitecore Client Maintaining|pd|+item:delete|+item:rename|+item:write|pe|+item:delete|+item:rename|+item:write|ar|sitecore\Everyone|pd|+field:read|+item:read|!*|pe|+field:read|+item:read|!*|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Layout/Layout/__Renderings",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/content/Applications/Security/Access Viewer/Ribbon/Home/Security/Assign",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Layout/Layout/__Renderers",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Default Rendering Buttons/Edit variations",@"ar|sitecore\Sitecore Minimal Page Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Schedule/Reminder",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Layouts/IDE/Toolbar/Security",@"ar|sitecore\Sitecore Client Account Managing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Security Tools/Access Viewer",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Common/System/Security/OverallMode",@"ar|sitecore\Analytics Management Reporting|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor",@"ar|sitecore\Sitecore Client Designing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Analytics Content Profiling|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/client",@"ar|Everyone|pe|!*|pd|!*|ar|sitecore\Sitecore Client Users|pe|+item:read|!*|pd|+item:read|!*|ar|sitecore\Sitecore Client Developing|pe|+item:create|+item:write|+item:delete|!*|+item:rename|pd|+item:create|+item:write|+item:delete|!*|+item:rename|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Dialogs/CreateTest",@"ar|sitecore\Analytics Testing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Preview/Preview",@"ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Medium/WebEdit Buttons/Insert Image",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Favorites/Add to Favorites",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Search",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Security/Security Editor/Ribbon/Home/Attributes",@"ar|sitecore\Sitecore Client Users|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/System/Properties",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Dialogs/CreateTest/PageSettings/Tabs/Variables/PageSettings/Traffic Allocation Security",@"ar|sitecore\Analytics Advanced Testing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/client/Applications/List Manager",@"ar|sitecore\Everyone|pe|!*|pd|!*|ar|sitecore\List Manager Editors|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Tasks/Tasks/__Reminder date",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Administration/About",@"ar|sitecore\Sitecore Client Users|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/ContentEditing/ExperienceEditor",@"ar|sitecore\Sitecore Client Designing|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pe|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Development Tools",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Indexing/Indexing Manager",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Goto",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Context Menues/Default/Search",@"ar|sitecore\Bucket Management|pe|+item:read|pd|+item:read|ar|sitecore\Limited Search|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Optimization/Create",@"ar|sitecore\Analytics Testing|pe|+item:read|!*|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Insert",@"ar|sitecore\Sitecore Limited Content Editor|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Common/System/Security/TrafficAllocation",@"ar|sitecore\Analytics Advanced Testing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Optimization Rendering Buttons/Edit variations",@"ar|sitecore\Sitecore Minimal Page Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Layouts/IDE/Toolbar/Security/Access Viewer",@"ar|sitecore\Sitecore Client Account Managing|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Securing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Log Viewer",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/ContentEditing/Workbox",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Experience/Language",@"ar|sitecore\Sitecore Client Translating|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Full/WebEdit Buttons/Insert Link",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit",@"ar|sitecore\Sitecore Client Developing|pe|+item:write|+item:rename|+item:delete|+item:create|pd|+item:write|+item:rename|+item:delete|+item:create|ar|sitecore\Sitecore Client Designing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Sitecore Limited Page Editor|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Delete",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/client/Applications/PathAnalyzer/PageAnalyzerDialog",@"ar|sitecore\Analytics Reporting|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Editing/WebDAVEdit",@"ar|sitecore\Sitecore Limited Content Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/client/Applications/ExperienceProfile",@"ar|sitecore\Author|pe|-item:read|pd|-item:read|ar|sitecore\Sitecore Client Users|pe|-bucket:makebucket|-bucket:unmake|!*|pd|-bucket:makebucket|-bucket:unmake|!*|ar|sitecore\Analytics Reporting|pe|+item:read|pd|+item:read|ar|sitecore\Designer|pe|-item:read|-item:write|pd|-item:read|-item:write|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Item Buckets/Item Buckets/__Is Bucket",@"ar|sitecore\Everyone|pe|-field:write|+field:read|pd|-field:write|+field:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Context Menues/Default/Copy",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Security/Role Manager",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Securing|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Statistics/Statistics/__Created",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Default/Buttons",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Ribbon",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/client/Applications/FXM",@"ar|sitecore\Everyone|pe|!*|pd|!*|ar|sitecore\FXM Marketers|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Desktop",@"ar|sitecore\Sitecore Client Users|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Appearance/Set Icon",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Common Field Buttons/Edit related item",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Limited Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Duplicate",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Limited Content Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Files/FileExplorer",@"ar|sitecore\Sitecore Client Developing|pe|+item:write|+item:read|+item:rename|+item:delete|+item:create|pd|+item:delete|+item:write|+item:rename|+item:read|+item:create|ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Close Preview",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Development Tools/Keyboard map",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Security Tools/Access Viewer",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Sitecore Client Securing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Analytics/Engagement Automation Previewer",@"ar|sitecore\Analytics Maintaining|pe|+item:read|ar|Everyone|pe|!*|pd|!*|ar|sitecore\Analytics Reporting|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Security/User Manager",@"ar|sitecore\Sitecore Client Account Managing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/media library",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Context Menues/Default/Edit",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Security/Access Viewer",@"ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Page Editor/Edit/Workbox",@"ar|sitecore\Sitecore Client Translating|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Buttons/Ribbon",@"ar|sitecore\Sitecore Minimal Page Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Default Rendering Buttons/Edit related item",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Limited Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Desktop/Context Menues/Desktop Background Menu/Create Shortcut",@"ar|sitecore\Sitecore Client Designing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Rename",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Optimization/PageProfileSettings/Profile Cards",@"ar|sitecore\Sitecore Client Users|pe|!*|ar|sitecore\Analytics Content Profiling|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Security/Open Role Manager",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/system/Settings/Security/Policies/Page Editor/Navigation bar/Can Edit",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Limited Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Schedule",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Security/Open User Manager",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Security Tools/Security Editor",@"ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Sitecore Client Securing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Template field/Validation Rules/Workflow",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Duplicate/Duplicate Item",@"ar|sitecore\Sitecore Client Publishing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Validation Rules/Validation Rules/__Quick Action Bar Validation Rules",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Appearance/Set Context Menu",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Preview/Menu/Publish",@"ar|sitecore\Sitecore Client Publishing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/templates",@"ar|sitecore\Sitecore Client Users|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Maintaining|pd|+item:delete|+item:create|+item:rename|+item:read|+item:write|pe|+item:delete|+item:create|+item:rename|+item:read|+item:write|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Publish",@"ar|sitecore\Sitecore Client Publishing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/FXM",@"ar|sitecore\Sitecore Minimal Page Editor|pe|-item:read|pd|-item:read|ar|sitecore\Sitecore Client Users|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Layouts/IDE/Toolbar/Security/Divider",@"ar|sitecore\Sitecore Client Securing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Control Panel/Preferences/Reset My Settings",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/client/Applications/ContentTesting/ExperienceOptimization",@"ar|Everyone|pe|!*|pd|!*|ar|sitecore\Analytics Testing|pe|+item:read|pd|+item:read|ar|sitecore\Analytics Management Reporting|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/Tools/ControlPanel",@"ar|sitecore\Sitecore Client Users|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Appearance/Set Custom Editors",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Desktop/Context Menues/Startbar/Run",@"ar|sitecore\Sitecore Client Users|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Templates/Template Lister",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Translate/Translate Options",@"ar|sitecore\Sitecore Client Translating|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Optimization/Attributes",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Analytics Content Profiling|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Analytics Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Templates/Create Template",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Social/Messages",@"ar|sitecore\Sitecore Client Social Authoring|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Item Buckets",@"ar|sitecore\Sitecore Client Configuring|pe|+item:read|^*|pd|+item:read|^*|ar|sitecore\Sitecore Client Bucket Management|pe|^*|+item:read|pd|^*|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Insert Options",@"ar|sitecore\Sitecore Client Configuring|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Menus/Other Views",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Authoring|pe|!*|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Common/System/Security/Scheduling",@"ar|sitecore\Analytics Advanced Testing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/Security/DomainManager",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Experience/Device",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Designing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/system/Field types/Simple Types/Image/WebEdit Buttons/Image Properties",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Hidden",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Control Panel",@"ar|sitecore\Sitecore Client Users|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Statistics/Statistics/__Updated",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/RibbonComponents/Strip",@"ar|sitecore\Sitecore Limited Page Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/system/Settings/Security/Policies/Publish/Can Publish Related Items",@"ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Sitecore Client Publishing|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Edit Frame Buttons/Default/Edit related item",@"ar|sitecore\Sitecore Minimal Page Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Limited Page Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Tools/Run",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Locks",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Security Tools/Domain Manager",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|"}
,new[] {"/sitecore/system/Settings/Security/Policies/Page Editor/Can Select Placeholder Settings",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Everyone|pd|!*|pe|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Context Menues/Default/Cut",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Feed Presentation/Configure",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Globalization/Untranslated Fields",@"ar|sitecore\Sitecore Client Translating|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Clipboard/Copy",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Right/Security Tools",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Sitecore Client Securing|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Analytics/Executive Dashboard Not Maximized",@"ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Analytics Reporting|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Context Menu",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Page Editor/New/Rendering",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Designing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Rename/Display Name",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Documents and settings",@"ar|sitecore\Sitecore Client Users|pe|+item:create|+item:delete|+item:publish|+item:read|+item:write|pd|+item:create|+item:delete|+item:publish|+item:read|+item:write|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/RibbonComponents/LargeButton",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Designing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Page Urls/Aliases",@"ar|sitecore\Sitecore Client Maintaining|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Translating|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/system/Settings/Security/Policies/Page Editor/Extended features/Personalization",@"ar|sitecore\Sitecore Minimal Page Editor|pe|-item:read|ar|sitecore\Sitecore Client Users|pe|!*|ar|sitecore\Analytics Personalization|pe|!*|+item:read|ar|sitecore\Sitecore Limited Page Editor|pe|-item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Language",@"ar|sitecore\Sitecore Limited Content Editor|pd|-item:read|pe|-item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Control Panel/Preferences/User Options",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Read Only",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Versions/Add",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Sorting/Move First",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Optimization/Attributes/Attributes",@"ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Analytics Maintaining|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Menues/Archive/Archive Item Now",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Developer - Template/Create",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Workbox",@"ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/system/Settings/Html Editor Profiles/Rich Text Medium/Buttons",@"ar|sitecore\Sitecore Client Users|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/content/Applications/Dialogs/Install Package",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/client/Applications/ContentTesting/Common/System/Security/Statistics",@"ar|sitecore\Analytics Advanced Testing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/system/Settings/Security/Policies/Page Editor/Keep Lock After Save",@"ar|sitecore\Sitecore Client Maintaining|pe|!*|+item:read|pd|!*|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Insert/New",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Proofing/Spellcheck",@"ar|sitecore\Sitecore Limited Content Editor|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Limited Page Editor|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Translating|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/Proofing/Validation Rules",@"ar|sitecore\Sitecore Client Translating|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Advanced",@"ar|sitecore\Sitecore Limited Page Editor|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/content/Applications/Tools/Keyboard Map",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Content Editor",@"ar|sitecore\Sitecore Client Designing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Security/Domain Manager/Ribbon/Home/Serialization",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|ar|Everyone|pe|^*|"}
,new[] {"/sitecore/system/Field types/Developer Types/Sitecore User/Menu/Select",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Validation Rules/Validation Rules/__Validator Bar Validation Rules",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Ribbons/WebEdit/Optimization/Attributes/Goals",@"ar|sitecore\Analytics Content Profiling|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|"}
,new[] {"/sitecore/system/Field types/Developer Types/Sitecore User/Menu/Clear",@"ar|sitecore\Sitecore Client Account Managing|pd|+item:read|pe|+item:read|ar|sitecore\Sitecore Client Users|pd|!*|pe|!*|"}
,new[] {"/sitecore/client/Applications/Launchpad/PageSettings/Buttons/ContentEditing/Media Library",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/WebEdit/Menus/Other Views/Explore",@"ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Experience Explorer|pe|+item:read|"}
,new[] {"/sitecore/content/Documents and settings/All users/Start menu/Programs/Media Library",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/content/Applications/Security",@"ar|Everyone|pd|!*|"}
,new[] {"/sitecore/content/Applications/Content Editor/Ribbons/Chunks/View/Buckets",@"ar|sitecore\Sitecore Client Developing|pe|+item:read|pd|+item:read|ar|sitecore\Sitecore Client Maintaining|pe|+item:read|pd|+item:read|a?|Everyone|p*|!*|"}
};

        public static string[][] Master =
        {
new[] {"/sitecore/templates/System/Validation/Field Type Validation Rules/Validation Rules/Workflow",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/templates/System/Validation/Global Validation Rules/Validation Rules/Validate Button",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Lifetime/Lifetime/__Hide version",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/system/Workflows/Sample Workflow/Approved",@"ar|sitecore\Sitecore Client Authoring|pd|+workflowState:delete|+workflowState:write|pe|+workflowState:delete|+workflowState:write|"}
,new[] {"/sitecore/layout/Renderings/App Center Sync",@"ar|sitecore\Sitecore Client Authoring|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Designing|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Developing|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Users|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Limited Page Editor|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|"}
,new[] {"/sitecore/templates/User Defined",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:create|+item:delete|+item:publish|+item:write|pd|+item:create|+item:delete|+item:publish|+item:write|ar|sitecore\Sitecore Client Securing|pe|+item:admin|pd|+item:admin|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Validators/Validation Rules/__Suppressed Validation Rules",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/system/Workflows/Path Analyzer Maps/Initializing/Deploy",@"ar|sitecore\Sitecore Client Authoring|pd|+workflowCommand:execute|pe|+workflowCommand:execute|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Lifetime/Lifetime/__Valid from",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/system/Settings/Buckets/Settings/Search Operations/Marketing/Apply Campaigns to All Items",@"ar|sitecore\Author|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/system/Workflows/Segment/Initializing",@"ar|sitecore\Sitecore Client Authoring|pd|+workflowState:delete|+workflowState:write|pe|+workflowState:delete|+workflowState:write|"}
,new[] {"/sitecore/system/Settings/Buckets/Views/ID View",@"ar|sitecore\Author|pe|-item:read|pd|-item:read|ar|sitecore\Analytics Personalization|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/system/Marketing Control Panel/Analytics Filters/Report Filters",@"ar|sitecore\Analytics Report Viewer|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/system/Workflows/Segment/Deployed",@"ar|sitecore\Sitecore Client Authoring|pd|+workflowState:delete|+workflowState:write|pe|+workflowState:delete|+workflowState:write|"}
,new[] {"/sitecore/system/Workflows/Analytics Testing Workflow/Deployed",@"ar|sitecore\Analytics Testing|pe|+workflowState:write|+workflowState:delete|pd|+workflowState:write|+workflowState:delete|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Workflow/Workflow/__Workflow state",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/system/Workflows/Sample Workflow/Awaiting Approval/Approve without Test",@"ar|sitecore\Sitecore Client Authoring|pe|+workflowCommand:execute|pd|+workflowCommand:execute|"}
,new[] {"/sitecore/system/List Manager",@"ar|sitecore\Everyone|pe|!*|pd|!*|"}
,new[] {"/sitecore/templates/Branches",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:create|+item:delete|+item:publish|+item:write|pd|+item:create|+item:delete|+item:publish|+item:write|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Layout/Layout/__Final Renderings",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/layout/Sublayouts/App Center Sync",@"ar|sitecore\Sitecore Client Authoring|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Designing|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Developing|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Users|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Limited Page Editor|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Workflow/Workflow/__Default workflow",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Icon",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/layout",@"au|sitecore\ServicesAPI|p*|-item:read|"}
,new[] {"/sitecore/system/Workflows/Analytics Workflow/Draft/Deploy",@"ar|sitecore\Sitecore Client Developing|pe|+workflowCommand:execute|pd|+workflowCommand:execute|ar|sitecore\Analytics Maintaining|pe|+workflowCommand:execute|pd|+workflowCommand:execute|"}
,new[] {"/sitecore/system",@"au|sitecore\ServicesAPI|p*|-item:read|"}
,new[] {"/sitecore/system/Workflows/Analytics Testing Workflow/Completed",@"ar|sitecore\Analytics Testing|pe|+workflowState:write|+workflowState:delete|pd|+workflowState:write|+workflowState:delete|"}
,new[] {"/sitecore/system/Workflows/Social Message Workflow",@"ar|Everyone|pe|!*|pd|!*|ar|sitecore\Social Message Workflow Editor|pe|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|ar|sitecore\Social Message Workflow Reviewer|pe|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|"}
,new[] {"/sitecore/system/Workflows/Sample Workflow/Draft/Submit",@"ar|sitecore\Sitecore Client Authoring|pd|+workflowCommand:execute|pe|+workflowCommand:execute|"}
,new[] {"/sitecore/system/Workflows/Analytics Workflow/Draft",@"ar|sitecore\Analytics Maintaining|pe|+workflowState:write|+workflowState:delete|pd|+workflowState:write|+workflowState:delete|ar|sitecore\Sitecore Client Developing|pe|+workflowState:write|+workflowState:delete|pd|+workflowState:write|+workflowState:delete|"}
,new[] {"/sitecore/system/Workflows/Analytics Testing Workflow/Deployed/End Test",@"ar|sitecore\Analytics Testing|pe|+workflowCommand:execute|pd|+workflowCommand:execute|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Help/Help/__Short description",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/templates/System/Layout/Sections/Rendering Options/Editor Options/Datasource Location",@"ar|sitecore\Sitecore Client Developing|pd|+field:write|pe|+field:write|ar|sitecore\Sitecore Client Maintaining|pd|+item:delete|+item:rename|+item:write|pe|+item:delete|+item:rename|+item:write|ar|sitecore\Everyone|pd|+field:read|+item:read|!*|pe|+field:read|+item:read|!*|"}
,new[] {"/sitecore/templates/System/Layout/Sections/Rendering Options/Editor Options/Compatible Renderings",@"ar|sitecore\Sitecore Client Developing|pd|+field:write|pe|+field:write|ar|sitecore\Sitecore Client Maintaining|pd|+item:delete|+item:rename|+item:write|pe|+item:delete|+item:rename|+item:write|ar|sitecore\Everyone|pd|+field:read|+item:read|!*|pe|+field:read|+item:read|!*|"}
,new[] {"/sitecore/templates/System/Validation/Global Validation Rules/Validation Rules/Quick Action Bar",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Layout/Layout/__Controller Action",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/system/Marketing Control Panel/Test Lab",@"ar|sitecore\Power Editors|pe|+item:create|pd|^*|+item:write|+item:delete|+item:rename|+item:read|+item:create|ar|sitecore\Analytics Testing|pe|+item:create|pd|^*|+item:write|+item:read|+item:rename|+item:delete|+item:create|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Workflow/Workflow/__Workflow",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/system/Settings/Buckets/Settings/Search Operations/Information Architecture/Serialize Items",@"ar|sitecore\Author|pe|-item:read|pd|-item:read|ar|sitecore\Developer|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/templates/System/Social/Posting Configuration/Posting Configuration/__Standard Values",@"ar|sitecore\Social Message Author|pe|+item:write|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Lifetime/Lifetime/__Valid to",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/system/Settings/Buckets/Settings/Search Operations/Information Architecture/Apply Security Rule",@"ar|sitecore\Author|pe|-item:read|pd|-item:read|ar|sitecore\Sitecore Client Securing|pe|+item:read|ar|sitecore\Developer|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Social/Message/Message/__Standard Values",@"ar|sitecore\Social Message Author|pe|+item:write|"}
,new[] {"/sitecore/templates/System/Templates/Template field/Validation Rules/Validate Button",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/system/Languages",@"ar|sitecore\Everyone|pd|+language:write|+language:read|pe|+language:write|+language:read|"}
,new[] {"/sitecore/system/Modules/Experience Explorer/Map Settings",@"ar|sitecore\Experience Explorer|pe|+item:create|pd|+item:rename|+item:create|+item:write|+item:delete|"}
,new[] {"/sitecore/templates/System/Layout/Sections/Rendering Options/Editor Options/Page Editor Buttons",@"ar|sitecore\Sitecore Client Developing|pd|+field:write|pe|+field:write|ar|sitecore\Sitecore Client Maintaining|pd|+item:delete|+item:rename|+item:write|pe|+item:delete|+item:rename|+item:write|ar|sitecore\Everyone|pd|+field:read|+item:read|!*|pe|+field:read|+item:read|!*|"}
,new[] {"/sitecore/templates/System/Templates/Template field/Validation Rules/Validator Bar",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/templates/System/WebDAV/FDAMediaFolder/FDA/Referrers",@"ar|Everyone|pe|-field:write|pd|-field:write|"}
,new[] {"/sitecore/system/Workflows/Sample Workflow/Awaiting Approval/Approve with Test",@"ar|sitecore\Analytics Testing|pe|+workflowCommand:execute|pd|+workflowCommand:execute|"}
,new[] {"/sitecore/system/Settings/Buckets/Settings/Search Operations/Information Architecture/Delete All Items in List",@"ar|sitecore\Author|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/system/Workflows/Analytics Testing Workflow/Draft/Deploy",@"ar|sitecore\Analytics Testing|pe|+workflowCommand:execute|pd|+workflowCommand:execute|"}
,new[] {"/sitecore/templates/System/Layout/Rendering Parameters/Standard Rendering Parameters/Test Lab/Tests",@"ar|sitecore\Analytics Maintaining|pe|+field:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/system/Workflows/Path Analyzer Maps/Initializing",@"ar|sitecore\Sitecore Client Authoring|pd|+workflowState:delete|+workflowState:write|pe|+workflowState:delete|+workflowState:write|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Tasks/Tasks/__Archive date",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/media library/System/List Manager",@"ar|sitecore\Everyone|pe|!*|pd|!*|ar|sitecore\List Manager Editors|pe|+item:read|+item:create|pd|+item:rename|+item:write|+item:read|+item:delete|+item:create| "}
,new[] {"/sitecore/system/Workflows/Path Analyzer Maps/Deployed",@"ar|sitecore\Sitecore Client Authoring|pd|+workflowState:delete|+workflowState:write|pe|+workflowState:delete|+workflowState:write|"}
,new[] {"/sitecore/content",@"au|sitecore\ServicesAPI|p*|+item:read|^*|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Advanced/Advanced/__Tracking",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/templates/System/Validation/Field Type Validation Rules/Validation Rules/Validate Button",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/templates/System/Feeds/RSS Feed/Extensibility/Type",@"ar|sitecore\Sitecore Client Developing|pd|+field:write|+field:read|!*|pe|+field:write|+field:read|!*|ar|sitecore\Sitecore Client Maintaining|pd|+field:write|+field:read|!*|pe|+field:write|+field:read|!*|"}
,new[] {"/sitecore/layout/Layouts/System/App Center Sync",@"ar|sitecore\Sitecore Client Authoring|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Designing|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Developing|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Users|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Limited Page Editor|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|"}
,new[] {"/sitecore/templates/System/Feeds/RSS Feed/Caching/Cacheable",@"ar|sitecore\Sitecore Client Developing|pd|+field:write|+field:read|!*|pe|+field:write|+field:read|!*|ar|sitecore\Sitecore Client Maintaining|pd|+field:write|+field:read|!*|pe|+field:write|+field:read|!*|"}
,new[] {"/sitecore/system/Workflows/Segment/Initializing/Deploy",@"ar|sitecore\Sitecore Client Authoring|pd|+workflowCommand:execute|pe|+workflowCommand:execute|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Help/Help/__Help link",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/system/App Center Sync",@"ar|sitecore\Sitecore Client Authoring|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Designing|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Developing|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Users|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Limited Page Editor|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Advanced/Advanced/__Standard values",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/system/Workflows/Social Message Workflow/Draft",@"ar|sitecore\Social Message Workflow Editor|pe|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|pd|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|"}
,new[] {"/sitecore/templates/System/Feeds/RSS Feed/Caching/Cache Duration",@"ar|sitecore\Sitecore Client Developing|pd|+field:write|+field:read|!*|pe|+field:write|+field:read|!*|ar|sitecore\Sitecore Client Maintaining|pd|+field:write|+field:read|!*|pe|+field:write|+field:read|!*|"}
,new[] {"/sitecore/system/Workflows/Analytics Workflow/Deployed",@"ar|sitecore\Sitecore Client Developing|pe|+workflowState:write|+workflowState:delete|pd|+workflowState:write|+workflowState:delete|ar|sitecore\Analytics Maintaining|pe|+workflowState:write|+workflowState:delete|pd|+workflowState:write|+workflowState:delete|"}
,new[] {"/sitecore/templates/System/Validation/Global Validation Rules/Validation Rules/Workflow",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/system/Marketing Control Panel/Personalization",@"ar|sitecore\Power Editors|pe|+item:create|pd|^*|+item:write|+item:rename|+item:read|+item:create|"}
,new[] {"/sitecore/system/Marketing Control Panel",@"ar|sitecore\Analytics Maintaining|pd|+item:delete|+item:create|+item:rename|+item:write|pe|+item:create|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Validators/Validation Rules/__Validate Button Validation Rules",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/templates/System/Validation/Field Type Validation Rules/Validation Rules/Quick Action Bar",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Help/Help/__Long description",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/layout/Layouts",@"ar|sitecore\Designer|pd|+item:delete|+item:create|+item:rename|+item:read|+item:write|pe|+item:create|"}
,new[] {"/sitecore/system/Workflows/Segment/Inactive",@"ar|sitecore\Sitecore Client Authoring|pd|+workflowState:delete|+workflowState:write|pe|+workflowState:delete|+workflowState:write|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Tasks/Tasks/__Reminder text",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Validators/Validation Rules/__Workflow Validation Rules",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/system/Marketing Control Panel/Goals",@"ar|sitecore\Power Editors|pe|+item:create|pd|^*|+item:write|+item:read|+item:rename|+item:delete|+item:create|"}
,new[] {"/sitecore/templates/System/Validation/Field Type Validation Rules/Validation Rules/Validator Bar",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Security/Security/__Security",@"ar|sitecore\Sitecore Client Securing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/system/Settings/Buckets/Search Types/Debug",@"ar|sitecore\Author|pe|-item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Sortorder",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/system/Marketing Control Panel/Campaigns",@"ar|sitecore\Power Editors|pd|^*|+item:create|+item:rename|+item:read|-item:delete|+item:write|pe|+item:create|-item:delete|"}
,new[] {"/sitecore/system/Marketing Control Panel/Experience Explorer",@"ar|sitecore\Sitecore Client Users|pe|!*|pd|!*|ar|sitecore\Experience Explorer|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/layout/Placeholder Settings/App Center Sync",@"ar|sitecore\Sitecore Client Authoring|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Designing|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Developing|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Users|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Limited Page Editor|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|"}
,new[] {"/sitecore/templates/System/Item Buckets/Saved Search/__Standard Values",@"ar|sitecore\Everyone|pe|-item:read|au|$currentuser|pe|+item:read|"}
,new[] {"/sitecore/system/Aliases",@"ar|sitecore\Analytics Maintaining|pd|+item:delete|+item:create|+item:rename|+item:read|+item:write|pe|+item:create|+item:read|+item:write|"}
,new[] {"/sitecore/system/Settings/Analytics",@"ar|sitecore\Sitecore Client Developing|pd|+item:delete|+item:create|+item:rename|+item:write|pe|+item:create|"}
,new[] {"/sitecore/system/Workflows/Social Account Renewal",@"ar|Everyone|pe|!*|pd|!*|"}
,new[] {"/sitecore/system/Settings/Buckets/Settings/Search Operations/Presentation/Apply Presentation to All Items",@"ar|sitecore\Author|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/templates/App Center Sync",@"ar|sitecore\Sitecore Client Authoring|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Designing|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Developing|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Client Users|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|ar|sitecore\Sitecore Limited Page Editor|pe|+item:rename|+item:write|+item:create|+item:delete|pd|+item:rename|+item:write|+item:create|+item:delete|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Display name",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/system/Settings/Buckets/TagRepository",@"ar|sitecore\Sitecore Client Authoring|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Subitems Sorting",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/templates/System/Layout/Rendering Parameters/Standard Rendering Parameters/Personalization",@"ar|sitecore\Analytics Maintaining|pd|+item:delete|+item:create|+item:rename|+item:read|+item:write|pe|+item:delete|+item:create|+item:rename|+item:read|+item:write|"}
,new[] {"/sitecore/templates/System/Validation/Global Validation Rules/Validation Rules/Validator Bar",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Editor",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/system/Settings/Buckets/Settings/Search Operations/Marketing/Apply Profile Score to All Items",@"ar|sitecore\Author|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/system/Workflows/Sample Workflow/Awaiting Approval",@"ar|sitecore\Sitecore Client Authoring|pd|+workflowState:delete|+workflowState:write|pe|+workflowState:delete|+workflowState:write|"}
,new[] {"/sitecore/system/Settings/Analytics/Reports",@"ar|sitecore\Sitecore Client Developing|pd|+item:read|pe|+item:read|ar|sitecore\Analytics Reporting|pd|+item:delete|+item:create|+item:rename|+item:read|+item:write|pe|+item:delete|+item:create|+item:rename|+item:read|+item:write|"}
,new[] {"/sitecore/templates/System/Templates/Template field/Validation Rules/Quick Action Bar",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Tasks/Tasks/__Reminder recipients",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/system/Workflows/Social Marketer Message Workflow/Draft",@"ar|sitecore\Social Message Workflow Editor|pe|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|pd|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|"}
,new[] {"/sitecore/layout/Devices",@"ar|sitecore\Sitecore Client Developing|pd|+item:delete|+item:create|+item:rename|+item:read|+item:write|pe|+item:create|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Editors",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Layout/Layout/__Controller",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/templates/System/Layout/Sections/Rendering Options/Editor Options/Datasource Template",@"ar|sitecore\Sitecore Client Developing|pd|+field:write|pe|+field:write|ar|sitecore\Sitecore Client Maintaining|pd|+item:delete|+item:rename|+item:write|pe|+item:delete|+item:rename|+item:write|ar|sitecore\Everyone|pd|+field:read|+item:read|!*|pe|+field:read|+item:read|!*|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Layout/Layout/__Renderings",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Layout/Layout/__Renderers",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/layout/Placeholder Settings",@"ar|sitecore\Sitecore Client Developing|pd|+item:delete|+item:create|+item:rename|+item:read|+item:write|pe|+item:create|"}
,new[] {"/sitecore/system/Workflows/Social Marketer Message Workflow/Post Accepted",@"ar|sitecore\Social Message Workflow Reviewer|pe|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|pd|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|"}
,new[] {"/sitecore/system/Workflows/Sample Workflow/Awaiting Approval/Reject",@"ar|sitecore\Sitecore Client Authoring|pe|+workflowCommand:execute|pd|+workflowCommand:execute|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Tasks/Tasks/__Reminder date",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/system/Marketing Control Panel/Analytics Filters",@"ar|sitecore\Power Editors|pe|+item:create|pd|^*|+item:write|+item:delete|+item:rename|+item:read|+item:create|au|sitecore\TestRepViewer|pe|+item:read|pd|+item:read|ar|sitecore\Analytics Report Viewer|pe|+item:read|pd|+item:read|"}
,new[] {"/sitecore/system/Workflows/Social Message Workflow/Awaiting Approval",@"ar|sitecore\Social Message Workflow Reviewer|pe|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|pd|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|"}
,new[] {"/sitecore/system/Marketing Control Panel/Experience Analytics",@"ar|sitecore\Everyone|pe|!*|pd|!*|ar|sitecore\Analytics Reporting|pe|+item:read|pd|+item:read|ar|sitecore\Developer|pe|+item:rename|+item:create|+item:delete|+item:read|+item:write|pd|+item:rename|+item:create|+item:delete|+item:read|+item:write|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Item Buckets/Item Buckets/__Is Bucket",@"ar|sitecore\Everyone|pe|-field:write|+field:read|pd|-field:write|+field:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Statistics/Statistics/__Created",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Ribbon",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/templates/System/Layout/Rendering Parameters/Standard Rendering Parameters/Test Lab",@"ar|sitecore\Analytics Maintaining|pe|+item:write|+item:read|+item:create|+item:delete|+item:rename|pd|+item:write|+item:read|+item:create|+item:delete|+item:rename|"}
,new[] {"/sitecore/system/Marketing Control Panel/Profiles/Persona/Cecile",@"au|sitecore\Persona|pe|-item:read|pd|-item:read|"}
,new[] {"/sitecore/media library",@"au|sitecore\ServicesAPI|p*|+item:read|^*|ar|sitecore\Sitecore Client Authoring|pe|+item:create|pd|+item:rename|+item:delete|+item:write|+item:create|"}
,new[] {"/sitecore/system/List Manager/All Lists",@"ar|sitecore\List Manager Editors|pe|+item:read|+item:create|pd|+item:rename|+item:create|+item:delete|+item:read|+item:write|"}
,new[] {"/sitecore/layout/Renderings",@"ar|sitecore\Designer|pd|+item:delete|+item:create|+item:rename|+item:read|+item:write|pe|+item:create|"}
,new[] {"/sitecore/templates/System/Layout/Rendering Parameters/Standard Rendering Parameters/Personalization/Personalization",@"ar|sitecore\Analytics Maintaining|pe|+field:read|ar|sitecore\Sitecore Client Users|pe|!*|"}
,new[] {"/sitecore/system/Settings/Analytics/Reports/Item Reports",@"ar|sitecore\Sitecore Client Authoring|pd|+item:read|pe|+item:read|"}
,new[] {"/sitecore/templates/System/Templates/Template field/Validation Rules/Workflow",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Validators/Validation Rules/__Quick Action Bar Validation Rules",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
,new[] {"/sitecore/system/Workflows/Social Message Workflow/Approved",@"ar|sitecore\Social Message Workflow Reviewer|pe|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|pd|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|"}
,new[] {"/sitecore/system/Workflows/Analytics Testing Workflow/Draft",@"ar|sitecore\Analytics Testing|pe|+workflowState:write|+workflowState:delete|pd|+workflowState:write|+workflowState:delete|"}
,new[] {"/sitecore/templates",@"ar|sitecore\Sitecore Client Maintaining|pe|+item:create|pd|+item:create|au|sitecore\ServicesAPI|p*|-item:read|ar|sitecore\Designer|pd|+item:read|+item:delete|+item:write|+item:create|+item:rename|"}
,new[] {"/sitecore/system/Workflows/Social Marketer Message Workflow",@"ar|Everyone|pe|!*|pd|!*|ar|sitecore\Social Message Workflow Editor|pe|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|ar|sitecore\Social Message Workflow Reviewer|pe|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|"}
,new[] {"/sitecore/system/Settings/Buckets/Settings/Search Operations/Fields/Search and Replace",@"ar|Everyone|pe|!*|pd|!*|"}
,new[] {"/sitecore/layout/Sublayouts",@"ar|sitecore\Designer|pd|+item:delete|+item:create|+item:rename|+item:read|+item:write|pe|+item:create|"}
,new[] {"/sitecore/system/Workflows/Social Marketer Message Workflow/Awaiting Post Review",@"ar|sitecore\Social Message Workflow Reviewer|pe|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|pd|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Hidden",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Statistics/Statistics/__Updated",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Maintaining|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/system/Marketing Control Panel/Experience Explorer/Presets",@"ar|sitecore\Experience Explorer|pe|+item:create|pd|+item:rename|+item:write|+item:create|+item:delete|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Context Menu",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/system/Workflows/Sample Workflow/Draft/__OnSave",@"ar|sitecore\Sitecore Client Authoring|pd|+workflowCommand:execute|pe|+workflowCommand:execute|"}
,new[] {"/sitecore/system/Workflows/Social Marketer Message Workflow/Post Removed",@"ar|sitecore\Social Message Workflow Reviewer|pe|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|pd|+workflowState:delete|+workflowCommand:execute|+item:write|+item:read|+workflowState:write|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Read Only",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/system/Workflows/Sample Workflow/Draft",@"ar|sitecore\Sitecore Client Authoring|pd|+workflowState:delete|+workflowState:write|pe|+workflowState:delete|+workflowState:write|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Appearance/Appearance/__Thumbnail",@"au|sitecore\Anonymous|pe|-field:read|pd|-field:read|ar|sitecore\Sitecore Client Configuring|pe|+field:read|pd|+field:read|"}
,new[] {"/sitecore/social/Messages",@"ar|Everyone|pe|!*|pd|!*|ar|sitecore\Social Message Author|pe|+item:create|+item:write|+item:read|+item:delete|pd|+item:create|+item:write|+item:read|+item:delete|"}
,new[] {"/sitecore/templates/System/Templates/Sections/Validators/Validation Rules/__Validator Bar Validation Rules",@"ar|sitecore\Sitecore Client Developing|pe|+field:read|pd|+field:read|au|sitecore\Anonymous|pe|-field:read|pd|-field:read|"}
        };
    }
}