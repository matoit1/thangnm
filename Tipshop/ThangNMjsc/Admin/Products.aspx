<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="ThangNMjsc.Admin.Products" MasterPageFile="~/MasterPage/PublicAdmin.Master"%>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <div class="search">
        <center><asp:TextBox ID="txtProducts_Name" runat="server" CssClass="textboxmain"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search"  onclick="btnSearch_Click" />
            <asp:LinkButton ID="btnShowSearchAdvanced" runat="server" OnClick="btnShowSearchAdvanced_Click">Tìm kiếm nâng cao</asp:LinkButton>
        </center>
        <asp:Panel ID="PanelSearchAdvanced" runat="server" Visible="false">
            <div class="left">
                <p><asp:Label ID="Label2" runat="server" Text="Tìm kiếm theo mô tả: "></asp:Label>
                <asp:TextBox ID="txtProducts_Description" runat="server" CssClass="textbox"></asp:TextBox></p>
                <p><asp:Label ID="Label3" runat="server" Text="Tìm kiếm theo thông tin: "></asp:Label><asp:TextBox ID="txtProducts_Info" runat="server" CssClass="textbox"></asp:TextBox></p>
            </div>
            <div class="right">
                <p><asp:Label ID="Label4" runat="server" Text="Tìm kiếm theo xuất xứ: "></asp:Label>
                <asp:TextBox ID="txtProducts_Origin" runat="server" CssClass="textbox"></asp:TextBox></p>
                <p>&nbsp;</p>
            </div>
        </asp:Panel>
    </div>
    <div>
        <center><asp:Label ID="Label8" runat="server" Text="Danh sách Sản phẩm" CssClass="tieude"></asp:Label><br /><br />
        <asp:Label ID="Label13" runat="server" style="margin-left:50px"></asp:Label>
        </center>

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
                <asp:TemplateField HeaderText="Sửa">
                    <ItemTemplate>
                        <asp:HyperLink ID="hpEdit" runat="server" class="GridItemlink">Sửa</asp:HyperLink>
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
                <asp:BoundField DataField="Products_Visible" HeaderText="Trạng thái kích hoạt">
                    <ItemStyle CssClass="GridItemNumber" />
                </asp:BoundField>
            </columns>
        </cc1:gridviewext>
        <br /><hr />
        <asp:Button ID="btnDelete" runat="server" Text="Xóa" onclick="btnDelete_Click" OnClientClick="return confirm('Bạn có muốn xóa những sản phẩm đã chọn ko?');"/>
        <asp:Button ID="btnAddProducts" runat="server" Text="Thêm Sản phẩm mới" PostBackUrl="Edit/EditProducts.aspx" />
        <asp:Button ID="btnExportExel" runat="server" Text="Xuất ra Exel" OnClick="btnExportExel_Click" />
    </div>
</asp:Content>