﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="Security.Rights.Reporting.Shell.UserInfo" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Security Rights Reporting</title>
    <script src="jquery.min.js"></script>
    <style>
body {
    margin: 5px 5px 5px 10px;
    font-family: "Open Sans",Arial,sans-serif;
    font-size: 12px;
}
.table-header-rotated {
    border-collapse: separate;
    border-spacing: 0px;
}
.xfield td {
    width: 18px;
}
td {
    position: relative;
    background-clip: padding-box;
}
.table-header-rotated td {
    background-clip: padding-box;
}
.table-header-rotated th {
    padding: 4px
    font-size: 11px;
}
.table-header-rotated td {
    border-bottom: 1px solid #ccc;
    border-right: 1px solid #ccc;
    padding: 5px 1px;
    text-align: center;
}
tr td:first-child {
    border-left: 1px solid #ccc;
}
th {
    border-bottom: 1px solid #ccc;
}
th.rotate {
    height: 226px;
    white-space: nowrap;
}
th.rotate > div {
    transform: translate(10px, 100px) rotate(315deg);
    width: 20px;
    font-size: 11px;
}
th.rotate > div > span {
    border-bottom: 1px solid #ccc;
    padding: 3px 5px;
}
.table-header-rotated th.row-header {
    border-bottom: 1px solid #ccc;
    padding: 0 10px;
}

#table-accountrights td {
     padding-left: 8px;
}
div.blueTable {
  border: 0px solid #1C6EA4;
  background-color: #EEEEEE;
  width: 100%;
  text-align: left;
  border-collapse: collapse;
}
.divTable.blueTable .divTableCell, .divTable.blueTable .divTableHead {
  border: 1px solid #AAAAAA;
  padding: 3px 2px;
}
.divTable.blueTable .divTableBody .divTableCell {
  font-size: 13px;
}
.divTable.blueTable .divTableRow:nth-child(even) {
  background: #D0E4F5;
}
.divTable.blueTable .divTableHeading {
  background: #1C6EA4;
  background: -moz-linear-gradient(top, #5592bb 0%, #327cad 66%, #1C6EA4 100%);
  background: -webkit-linear-gradient(top, #5592bb 0%, #327cad 66%, #1C6EA4 100%);
  background: linear-gradient(to bottom, #5592bb 0%, #327cad 66%, #1C6EA4 100%);
  border-bottom: 2px solid #444444;
}
.divTable.blueTable .divTableHeading .divTableHead {
  font-size: 15px;
  font-weight: bold;
  color: #FFFFFF;
  border-left: 2px solid #D0E4F5;
}
.divTable.blueTable .divTableHeading .divTableHead:first-child {
  border-left: none;
}

.blueTable .tableFootStyle {
  font-size: 14px;
  font-weight: bold;
  color: #FFFFFF;
  background: #D0E4F5;
  background: -moz-linear-gradient(top, #dcebf7 0%, #d4e6f6 66%, #D0E4F5 100%);
  background: -webkit-linear-gradient(top, #dcebf7 0%, #d4e6f6 66%, #D0E4F5 100%);
  background: linear-gradient(to bottom, #dcebf7 0%, #d4e6f6 66%, #D0E4F5 100%);
  border-top: 2px solid #444444;
}
.blueTable .tableFootStyle {
  font-size: 14px;
}
.blueTable .tableFootStyle .links {
	 text-align: right;
}
.blueTable .tableFootStyle .links a{
  display: inline-block;
  background: #1C6EA4;
  color: #FFFFFF;
  padding: 2px 8px;
  border-radius: 5px;
}
.blueTable.outerTableFooter {
  border-top: none;
}
.blueTable.outerTableFooter .tableFootStyle {
  padding: 3px 5px; 
}
/* DivTable.com */
.divTable{ display: table; }
.divTableRow { display: table-row; }
.divTableHeading { display: table-header-group;}
.divTableCell, .divTableHead { display: table-cell;}
.divTableHeading { display: table-header-group;}
.divTableFoot { display: table-footer-group;}
.divTableBody { display: table-row-group;}

blink {
    animation: blinker 0.6s linear infinite;
    color: #1c87c9;
}
@keyframes blinker {  
    50% { opacity: 0; }
}
</style>
<script>
    <% 
    var jsonSerialiser = new System.Web.Script.Serialization.JavaScriptSerializer();
    var json = jsonSerialiser.Serialize(Security.Rights.Reporting.Shell.DefaultRols.RolComment);
    %>
    var rolComment = <%=json%>;

    function getRightsDate(url, page, pagelimit) {
        $('#loading').show();
        var retusers = 0;
        $.ajax({
            dataType: 'json', url: url + page + "/?sc_site=shell", error: function () {
                console.log("error geting data retry"); 
                getRightsDate(url, page, pagelimit);
            }, success: function (result) {
                retusers = result.users.length;
                $.each(result.users, function (index, element) {
                    $('#TableRightsBody').append('<div class=\"divTableRow\"><div class=\"divTableCell\">' + element.name + '</div><div class=\"divTableCell\">' + element.ProfileState + '</div><div class=\"divTableCell\">' + element.IsAdmin + '</div><div class=\"divTableCell\">' + ParseRoles(element.Roles) + '</div></div>')
                });
                if (retusers >= 10 && page < pagelimit) {
                    getRightsDate(url, page + 1, pagelimit);
                } else {
                    $('#loading').hide();
                    $('#loaded').show();
                }
            }
        });
    }
    function ParseRoles(roles) {
        var retvalue = "";
        var role = roles.split(", ");
        $.each(role, function (index, element) {
            if (index != 0) { retvalue += ", "; }
            var title = "";
            if (rolComment[element]) {
                title = rolComment[element];
            }
            retvalue += "<a href=\"?account=" + element + "&t=d\" title=\"" + title + "\">" + element + "</a>";
        });
        return retvalue;
    }    
</script>
    <asp:Literal runat="server" ID="userlistjsall" Visible="False">
    <script>
        $(document).ready(function () {
            getRightsDate("/api/rightsreporting/users/", 0,49);
        });
    </script>
    </asp:Literal>
    <asp:Literal runat="server" ID="userlistjssitecore" Visible="False">
        <script>
            $(document).ready(function () {
                getRightsDate("/api/rightsreporting/sitecoreusers/", 0,49);
            });
        </script>
    </asp:Literal>
    <asp:Literal runat="server" ID="usersnolimit" Visible="False">
        <script>
            $(document).ready(function () {
                getRightsDate("/api/rightsreporting/users/", 0, 999999);
            });
        </script>
    </asp:Literal>
 </head>
<body bgcolor="#FFFFFF">
<div style="float: right;"><a href="https://doc.sitecore.com/developers/93/platform-administration-and-architecture/en/the-security-roles.html" target="_blank">Description predefined roles</a></div>
<h1>Security Rights Reporting</h1>
<asp:Literal runat="server" ID="userlist"></asp:Literal>
<asp:Literal runat="server" ID="userrights"></asp:Literal>
<asp:Literal runat="server" ID="rolesexport"></asp:Literal>
<div id="loading" style="display: none"><blink>Loading.</blink></div>
<div id="loaded" style="display: none"><a href="#" id="save-link">Download</a></div>
<div ID="rightstable" class="divTable blueTable" runat="server" Visible="False">
    <div class="divTableHeading">
        <div class="divTableRow">
            <div class="divTableHead">Name</div>
            <div class="divTableHead">State</div>
            <div class="divTableHead">Is Admin</div>
            <div class="divTableHead">Roles</div>
        </div>
    </div>
    <div class="divTableBody" id="TableRightsBody">
    </div>
</div>

<p align="right">Sitecore community code on <a href="https://github.com/jbluemink" target="_blank">GitHub</a> <a href="https://nl.linkedin.com/in/jan-bluemink-6b4467" target="_blank">Jan Bluemink</a> <a href="?mode=uninstall">Uninstall</a></p>
    <script>
        $('#save-link').click(function () {
            var retContent = [];
            retContent.push("Name,State,Is Admin,Roles");
            var retString = '';
            $('.divTableBody').each(function (idx, rootelem) {
                $(rootelem).children('.divTableRow').each(function (idx, elem) {
                    var elemText = [];
                    $(elem).children('.divTableCell').each(function (childIdx, childElem) {
                        elemText.push('"'+$(childElem).text()+'"');
                    });
                    retContent.push(elemText.join(','));
                });
            });
            retString = retContent.join('\r\n');
            var attachment = 'data:attachment/csv,' + encodeURI(retString)
            window.open(attachment)
        })
    </script>
</body>
</html>

