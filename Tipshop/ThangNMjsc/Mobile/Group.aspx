<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Group.aspx.cs" Inherits="ThangNMjsc.Mobile.Group" MasterPageFile="~/Mobile/Mobile.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead_Mobile" runat="server">
    <title>Nhóm Sản phẩm - Công ty Cổ phần ThangNM (Phiên bản Mobile)</title>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMainContent_Mobile" runat="server">
    <ul data-role="listview" data-inset="true" data-count-theme="b">
        <li data-role="list-divider">Mục con</li>
        <li><a href='Newstype.html'>CĂN BẢN<span class="ui-li-count">20</span></a></li>
        <li><a href='Newstype.html'>NÂNG CAO<span class="ui-li-count">6</span></a></li>
    </ul>
    <ul data-role="listview" data-inset="true" data-split-theme="d">
        <li data-role="list-divider">Các Sản phẩm nổi bật</li>
            <asp:DataList ID="datalistProduct" runat="server" RepeatColumns="1" DataKeyField="Products_ID" >
            <ItemTemplate>
                <li>
                    <asp:LinkButton ID="LinkButton1" runat="server"><asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("Products_Image1")%>' Width="180px" class="resize_thumb" AlternateText='<%#Eval("Products_Name") %>'/></asp:LinkButton><br />
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
            </asp:DataList>
    </ul>
    <div id="ctl00_ContentPlaceHolder1_ucNews1_divPaging" data-role="controlgroup" data-type="horizontal" style="text-align: center;"><a data-role="button" data-icon="arrow-r" data-inline="true" data-theme="b" data-iconpos="right" href="NewsType.html?page=2">Tới</a></div>
    <style>
        .ui-li-has-thumb .ui-btn-inner a.ui-link-inherit, .ui-li-static.ui-li-has-thumb
        {
            min-height: 59px !important;
            padding-left: 100px !important;
        }
    </style>
</asp:Content>