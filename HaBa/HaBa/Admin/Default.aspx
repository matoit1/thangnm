<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HaBa.Admin.Default" MasterPageFile="~/ShareInterface/AdminSI.Master" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="server">
    <link href="../App_Themes/jquery.circliful.css" rel="stylesheet" type="text/css" />
    <script src="http://code.jquery.com/jquery-1.10.2.min.js"></script>
    <script src="../Scripts/jquery.circliful.min.js"></script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <div id="myStathalf" data-dimension="250" data-text="35%" data-info="New Clients" data-width="30" data-fontsize="38" data-percent="35" data-fgcolor="#7ea568" data-bgcolor="#eee" data-type="half" data-fill="#ddd"></div>
    <div id="myStat" data-dimension="250" data-text="35%" data-info="New Clients" data-width="30" data-fontsize="38" data-percent="35" data-fgcolor="#61a9dc" data-bgcolor="#eee" data-fill="#ddd"></div>
    <div id="myStathalf2" data-dimension="250" data-text="35" data-info="New Clients" data-width="30" data-fontsize="38" data-percent="35" data-fgcolor="#7ea568" data-bgcolor="#eee" data-type="half" data-icon="fa-task"></div>
    <div id="myStat2" data-dimension="250" data-text="35%" data-info="New Clients" data-width="30" data-fontsize="38" data-percent="35" data-fgcolor="#61a9dc" data-bgcolor="#eee"></div>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#myStathalf').circliful();
            $('#myStat').circliful();
            $('#myStathalf2').circliful();
            $('#myStat2').circliful();
        });
    </script>
</asp:Content>