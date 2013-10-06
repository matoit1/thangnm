<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ThangNMjsc.Mobile.Demo" MasterPageFile="~/Mobile/Mobile.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead_Mobile" runat="server">
    <title>Công ty Cổ phần ThangNM (Phiên bản Mobile)</title>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMainContent_Mobile" runat="server">
    <ul data-role="listview" data-count-theme="b" data-filter="true" data-filter-placeholder="Tìm kiếm sản phẩm..." data-inset="true">
        <asp:Repeater ID="rpListProductGroup" runat="server" OnItemDataBound="rpListProductGroup_ItemDataBound">
        <HeaderTemplate><li></HeaderTemplate>
        <ItemTemplate>
            <h1><a href="Group.aspx?Products_ID=<%#Eval("Products_ID")%>"><%#Eval("Products_Name")%></a></h1>
                <asp:Repeater ID="rpListProduct" runat="server" onitemcommand="rpListProduct_ItemCommand">
                        <ItemTemplate>
                            <li>
                                <asp:LinkButton ID="LinkButton1" runat="server"><asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("Products_Image1")%>' Width="180px" AlternateText='<%#Eval("Products_Name") %>'/></asp:LinkButton><br />
                                <asp:Label ID="Label1" runat="server" Text="Mã SP: " Font-Bold="true"></asp:Label>
                                <asp:Label ID="lblProducts_ID" runat="server" Text='<%#Eval("Products_ID") %>'></asp:Label><br />
                                <asp:Label ID="Label2" runat="server" Text="Tên SP: " Font-Bold="true"></asp:Label>
                                <asp:Label ID="lblProducts_Name" runat="server" Text='<%#Eval("Products_Name") %>'></asp:Label><br />
                                <asp:Label ID="Label4" runat="server" Text="Giá bán: " Font-Bold="true"></asp:Label>
                                <asp:Label ID="lblProducts_Price" runat="server" Text='<%#Eval("Products_Price") %> '></asp:Label><br />
                                <asp:ImageButton ID="ImageButton2" runat="server"  ImageUrl="~/Images/icon_chitiet.gif" CommandName="Detail"/>
                                <asp:ImageButton ID="ImageButton1" CommandName="add" runat="server" ImageUrl="~/Css/Product/theme/buy.png" /><br /><br />
                            </li>
                        </ItemTemplate>
                </asp:Repeater>
            <asp:HiddenField ID="hrID" runat="server" Value='<%#Eval("Products_ID")%>' /> <!-- cai nay de luu ID cua danh muc cap cha  -->
        </ItemTemplate>
        <FooterTemplate></li></FooterTemplate>
        </asp:Repeater>
    </ul>
    <style>
        .ui-mobile a img, .ui-mobile fieldset {margin: 6px 6px;}
        .ui-li-has-thumb .ui-btn-inner a.ui-link-inherit, .ui-li-static.ui-li-has-thumb {min-height: 48px !important; padding-left: 70px !important;}
    </style>
</asp:Content>