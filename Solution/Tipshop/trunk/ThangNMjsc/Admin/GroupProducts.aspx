<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GroupProducts.aspx.cs" Inherits="ThangNMjsc.Admin.GroupProducts" MasterPageFile="~/MasterPage/PublicAdmin.Master"%>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <div>
        <center><asp:Label ID="Label8" runat="server" Text="Danh mục Sản phẩm - Nhóm Sản phẩm" CssClass="tieude"></asp:Label><br /><br />
        <asp:Label ID="Label13" runat="server" style="margin-left:50px"></asp:Label>
        </center>
        <cc1:GridViewExt ID="grvListGroupProducts" runat="server" CssClass="mGrid" AutoGenerateCheckBoxColumn="True" AutoGenerateColumns="False"
                FileTypeDownload="Excel" Width="100%" AllowPaging="True" PageSize="15" DataKeyNames="Products_ID"
                classCheckedRow="" classHoverRow="" ColumnShowOnclick="" EnableModelValidation="True"
                WidthCheckBoxColumn="50" emptydatatext="Không có dữ liệu trả về."  onrowdatabound="grvListGroupProducts_RowDataBound" onpageindexchanging="grvListGroupProducts_PageIndexChanging">

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
                <asp:BoundField DataField="Products_ID" HeaderText="Mã Nhóm Sản phẩm">
                    <ItemStyle CssClass="GridItemNumber" />
                </asp:BoundField>
                <asp:BoundField DataField="Products_Parent" HeaderText="Nhóm Sản phẩm">
                    <ItemStyle CssClass="GridItemNumber" />
                </asp:BoundField>
                <asp:BoundField DataField="Products_Name" HeaderText="Tên Nhóm Sản phẩm">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
                <asp:BoundField DataField="Products_Description" HeaderText="Mô tả Nhóm Sản phẩm">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
                <asp:BoundField DataField="Products_Visible" HeaderText="Trạng thái kích hoạt">
                    <ItemStyle CssClass="GridItemNumber" />
                </asp:BoundField>
            </columns>
        </cc1:gridviewext>
        <br /><hr />
        <asp:Button ID="btnDelete" runat="server" Text="Xóa" onclick="btnDelete_Click" OnClientClick="return confirm('Bạn có muốn xóa nhóm sản phẩm đã chọn ko?');"/>
        <asp:Button ID="btnAdd" runat="server" Text="Thêm Nhóm Sản phẩm mới" PostBackUrl="Edit/EditGroupProducts.aspx" />
    </div>
</asp:Content>