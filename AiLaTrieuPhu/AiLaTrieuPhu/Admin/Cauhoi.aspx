<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cauhoi.aspx.cs" Inherits="AiLaTrieuPhu.Admin.Cauhoi" MasterPageFile="~/Admin/Common.Master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="cbody" ContentPlaceHolderID="cphBody" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <cc1:TabContainer ID="TabContainer1" runat="server">
        <cc1:TabPanel ID="TabMuc1" HeaderText="Mức 1" runat="server">
            <ContentTemplate><br /><br />
                <center><asp:Label ID="lblTitle1" runat="server" Text="Danh sách các câu hỏi Mức 1"></asp:Label></center><br />
                <asp:GridView ID="grvDanhsachCauhoiMuc1" runat="server"></asp:GridView>
            </ContentTemplate>
        </cc1:TabPanel>
        <cc1:TabPanel ID="TabMuc2" HeaderText="Mức 2" runat="server">
            <ContentTemplate><br /><br />
                <center><asp:Label ID="Label1" runat="server" Text="Danh sách các câu hỏi Mức 2"></asp:Label></center><br />
                <asp:GridView ID="grvDanhsachCauhoiMuc2" runat="server"></asp:GridView>
            </ContentTemplate>
        </cc1:TabPanel>
    </cc1:TabContainer>

</asp:Content>