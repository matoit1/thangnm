<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataList.aspx.cs" Inherits="ThangNMjsc.Test.DataList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="rpListProductGroup" runat="server" OnItemDataBound="rpListProductGroup_ItemDataBound">
            <HeaderTemplate></HeaderTemplate>
            <ItemTemplate>
                <div class="ienlarger">
                <h1><a href="../Group.aspx?Products_ID=<%#Eval("Products_ID")%>">&nbsp;&nbsp;&nbsp;<%#Eval("Products_Name")%></a></h1>
                    <asp:DataList ID="dtlDemo" runat="server" RepeatColumns="3" DataKeyField="Products_ID" OnItemCommand="dtlDemo_ItemCommand">
                    <ItemTemplate>
                        <div style="width:240px; padding: 5px 5px 5px 5px; border: 1px dotted red">
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
                <asp:HiddenField ID="hrID" runat="server" Value='<%#Eval("Products_ID")%>' /> <!-- cai nay de luu ID cua danh muc cap cha  -->
                </div><div class="clear"></div>
            </ItemTemplate>
            <FooterTemplate></FooterTemplate>
        </asp:Repeater>
    </div>
<%--    <div class="ienlarger">
            <h1><a href="ThoitrangBegai/Default.aspx">&nbsp;&nbsp;&nbsp;Thời trang Bé Gái</a></h1>
            <asp:DataList ID="DataList2" runat="server" RepeatColumns="3" DataKeyField="Products_ID" DataSourceID="SqlDataSource2" OnItemCommand="DataList1_ItemCommand">
            <ItemTemplate>
                <div style="width:240px; padding: 5px 5px 5px 5px; border: 1px dotted red">
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
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>"
                SelectCommand="SELECT TOP 3 * FROM Products Where (Products_Group<>0)">
            </asp:SqlDataSource>
        </div>--%>
    </form>
</body>
</html>
