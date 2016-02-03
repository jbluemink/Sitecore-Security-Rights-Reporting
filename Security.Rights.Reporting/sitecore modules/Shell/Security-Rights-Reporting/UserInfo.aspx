<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="Security.Rights.Reporting.Shell.UserInfo" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Security Rights Reporting</title>
    
    <style>
body {
    margin: 5px 5px 5px 10px;
}
.table-header-rotated {
    border-collapse: separate;
    border-spacing: 0px;
}
.xfield td {
    width: 20px;
}
td {
    position: relative;
    background-clip: padding-box;
}
.table-header-rotated td {
    background-clip: padding-box;
}
.table-header-rotated th {
    padding: 5px 10px;
}
.table-header-rotated td {
    border: 1px solid #cccccc;
    padding: 10px 5px;
    text-align: center;
}
th.rotate {
    height: 320px;
    white-space: nowrap;
}
th.rotate > div {
    transform: translate(16px, 148px) rotate(315deg);
    width: 20px;
}
th.rotate > div > span {
    border-bottom: 1px solid #ccc;
    padding: 5px 10px;
}
.table-header-rotated th.row-header {
    border-bottom: 1px solid #ccc;
    padding: 0 10px;
}

#table-accountrights td {
     padding-left: 8px;
}
</style>
</head>
<body bgcolor="#FFFFFF">

<h1>Security Rights Reporting</h1>

<asp:Literal runat="server" ID="userlist"></asp:Literal>
    
<asp:Literal runat="server" ID="userrights"></asp:Literal>
<p align="right">Sitecore community code on <a href="https://github.com/jbluemink" target="_blank">GitHub</a> <a href="https://nl.linkedin.com/in/jan-bluemink-6b4467" target="_blank">Jan Bluemink</a> <a href="?mode=uninstall">Uninstall</a></p>
</body>
</html>

