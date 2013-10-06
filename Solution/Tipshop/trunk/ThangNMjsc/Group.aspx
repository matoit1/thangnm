<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Group.aspx.cs" Inherits="ThangNMjsc.Group" MasterPageFile="~/MasterPage/PublicProduct.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead_Product" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMainContent_Product" runat="server">
    <div>
        <div id="welcome">
        </div><!-- End #welcome -->
        <div class="ienlarger">
            <h1><a href="">&nbsp;&nbsp;&nbsp;Các Sản phẩm nổi bật</a></h1>
            <asp:DataList ID="datalistProduct" runat="server" RepeatColumns="3" DataKeyField="Products_ID" >
            <ItemTemplate>
                <div style="width:228px; margin: 5px 5px 5px 5px; padding: 5px 5px 5px 5px; border: 3px outset seagreen; float: left;">
                    <asp:LinkButton ID="LinkButton1" runat="server"><asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("Products_Image1")%>' Width="180px" class="resize_thumb" AlternateText='<%#Eval("Products_Name") %>'/>
                    <span><asp:Image ID="Image2" runat="server" ImageUrl='<%#Eval("Products_Image1")%>' Width="180px" AlternateText='<%#Eval("Products_Name") %>'/> Tên SP: <%#Eval("Products_Name")%></span></asp:LinkButton><br />
                    <asp:Label ID="Label1" runat="server" Text="Mã SP: " Font-Bold="true"></asp:Label>
                    <asp:Label ID="lblProducts_ID" runat="server" Text='<%#Eval("Products_ID") %>'></asp:Label><br />
                    <asp:Label ID="Label2" runat="server" Text="Tên SP: " Font-Bold="true"></asp:Label>
                    <asp:Label ID="lblProducts_Name" runat="server" Text='<%#Eval("Products_Name") %>'></asp:Label><br />
                    <asp:Label ID="Label4" runat="server" Text="Giá bán: " Font-Bold="true"></asp:Label>
                    <asp:Label ID="lblProducts_Price" runat="server" Text='<%#Eval("Products_Price") %> '></asp:Label><br />
                    <asp:ImageButton ID="ImageButton2" runat="server"  ImageUrl="~/Images/icon_chitiet.gif" CommandName="Detail"/>
                    <asp:ImageButton ID="ImageButton1" CommandName="add" runat="server" ImageUrl="~/Css/Product/theme/buy.png" /><br /><br />
                </div>
            </ItemTemplate>
            </asp:DataList>
        </div>
    </div><!-- End #primary -->
</asp:Content>
