# Sitecore-Security-Rights-Reporting Module
View all the Access right set on Sitecore rols or users. You can make a list of all users and roles. It can be used to do audits.

![Example](https://raw.githubusercontent.com/jbluemink/Sitecore-Security-Rights-Reporting/master/Sitecore-Security-Rights-Reporting-Module.PNG)

##Using
Go to the Sitecore Desktop (/sitecore/shell/)
And push the left-bottom start button in the right menu there is inside the Security Tools menu a new Security Reporting menu item

This tool is for Sitecore Domain users, if there too many (extranet) users it is skipping other domain users, this tool works for max 200 users in the Sitecore Domain.

##To Build:
Add Sitecore.Kernel.dll to External folder

##Deploy:
- Copy the builded Security.Rights.Reporting.dll to the Sitecore bin directory (CMS server)
- Copy the UserInfo.aspx to \sitecore modules\Shell\Security-Rights-Reporting of your Sitecore (CMS server)
- Create the application in the core database and create a link in the menu, see the Serialization folder

![Example user](https://raw.githubusercontent.com/jbluemink/Sitecore-Security-Rights-Reporting/master/user-rights.PNG)
