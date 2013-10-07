<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="ThangNMjsc.UserControls.Test" %>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>
<%@ Register src="SearchProductUC.ascx" tagname="SearchProductUC" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:SearchProductUC ID="SearchProductUC1" runat="server" />
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
<%--        <asp:Button ID="btnDelete" runat="server" Text="Xóa" onclick="btnDelete_Click" OnClientClick="return confirm('Bạn có muốn xóa những sản phẩm đã chọn ko?');"/>
        <asp:Button ID="btnAddProducts" runat="server" Text="Thêm Sản phẩm mới" PostBackUrl="Edit/EditProducts.aspx" />
        <asp:Button ID="btnExportExel" runat="server" Text="Xuất ra Exel" OnClick="btnExportExel_Click" />--%>
    </div>
    </form>
</body>
</html>
