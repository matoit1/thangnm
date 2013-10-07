<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="ThangNMjsc.Product.Search" MasterPageFile="~/MasterPage/PublicProduct.Master" %>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMainContent_Product" runat="server">
    <div id="primary">
    <div class="search">
        <center><asp:TextBox ID="txtProducts_Name" runat="server" CssClass="textboxmain"></asp:TextBox></center>
        <asp:LinkButton ID="btnShowSearchAdvanced" runat="server" OnClick="btnShowSearchAdvanced_Click">Tìm kiếm nâng cao</asp:LinkButton>
        <asp:Panel ID="PanelSearchAdvanced" runat="server" Visible="true">
            <p><asp:Label ID="Label2" runat="server" Text="Tìm kiếm theo mô tả"></asp:Label><asp:TextBox ID="txtProducts_Description" runat="server" CssClass="textbox"></asp:TextBox></p>
            <p><asp:Label ID="Label3" runat="server" Text="Tìm kiếm theo thông tin"></asp:Label><asp:TextBox ID="txtProducts_Info" runat="server" CssClass="textbox"></asp:TextBox></p>
            <p><asp:Label ID="Label4" runat="server" Text="Tìm kiếm theo xuất xứ"></asp:Label><asp:TextBox ID="txtProducts_Origin" runat="server" CssClass="textbox"></asp:TextBox></p>
        </asp:Panel>
        <center><asp:Button ID="btnSearch" runat="server" Text="Search" onclick="btnSearch_Click" /></center>
    </div>
    <div>
        <center><asp:Label ID="Label8" runat="server" Text="Kết quả tìm được" Font-Size="24px" Font-Bold="true" ForeColor="BlueViolet"></asp:Label><br /><br /></center>
        <cc1:GridViewExt ID="grvListProducts" runat="server" CssClass="mGrid" AutoGenerateCheckBoxColumn="True" AutoGenerateColumns="False"
                FileTypeDownload="Excel" Width="100%" AllowPaging="True" PageSize="15" DataKeyNames="Products_ID"
                classCheckedRow="" classHoverRow="" ColumnShowOnclick="" EnableModelValidation="True"
                WidthCheckBoxColumn="50" emptydatatext="Không có dữ liệu trả về."  onrowdatabound="grvListProducts_RowDataBound" onpageindexchanging="grvListProducts_PageIndexChanging">

            <alternatingrowstyle cssclass="GridAlternatingItem"></alternatingrowstyle>
            <columns>
                <asp:TemplateField HeaderText="Xem">
                    <ItemTemplate>
                        <asp:HyperLink ID="hpView" runat="server" class="GridItemlink">Xem</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Mua">
                    <ItemTemplate>
                        <asp:HyperLink ID="hpPaid" runat="server" class="GridItemlink">Mua</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Products_ID" HeaderText="Mã Sản phẩm">
                    <ItemStyle CssClass="GridItemNumber" />
                </asp:BoundField>
                <asp:BoundField DataField="Products_Group" HeaderText="Mã Nhóm Sản phẩm">
                    <ItemStyle CssClass="GridItemNumber" />
                </asp:BoundField>
                <asp:BoundField DataField="Products_Name" HeaderText="Tên Sản phẩm">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
                <asp:BoundField DataField="Products_Price" HeaderText="Giá bán">
                    <ItemStyle CssClass="GridItemNumber" />
                </asp:BoundField>
            </columns>
        </cc1:gridviewext>
    </div>
    </div><!-- End #primary -->
</asp:Content>
