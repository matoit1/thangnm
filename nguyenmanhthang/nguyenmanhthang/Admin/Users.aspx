<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="nguyenmanhthang.Admin.Users" MasterPageFile="~/Admin/Admin.Master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc2" %>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphBody_Admin" runat="server">
    <asp:MultiView ID="mtvUsers" runat="server">
        <asp:View ID="vListUsers" runat="server">
            <asp:Label ID="lblListTitle" runat="server" Text="Danh sách các tài khoản" class="alert_title"></asp:Label>
            <cc1:GridViewExt ID="grvListUser" runat="server" CssClass="mGrid" AutoGenerateCheckBoxColumn="True" AutoGenerateColumns="False"
                FileTypeDownload="Excel" Width="100%" AllowPaging="True" PageSize="15" DataKeyNames="Accounts_Username"
                classCheckedRow="" classHoverRow="" ColumnShowOnclick="" EnableModelValidation="True"
                WidthCheckBoxColumn="50" emptydatatext="Không có dữ liệu trả về."  onrowdatabound="grvListUser_RowDataBound" onpageindexchanging="grvListUser_PageIndexChanging">
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
                    <asp:BoundField DataField="Accounts_Username" HeaderText="Tên đăng nhập">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Accounts_FullName" HeaderText="Họ và tên">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Accounts_Email" HeaderText="Địa chỉ Email">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Accounts_DateOfBirth" HeaderText="Ngày sinh" DataFormatString="{0:dd/MM/yyyy HH:mm}">
                        <ItemStyle CssClass="GridItemDate" />
                    </asp:BoundField>
                </columns>
            </cc1:gridviewext><br /><br />
            <asp:Button ID="btnDelete" runat="server" Text="Xóa" onclick="btnDelete_Click" OnClientClick="return confirm('Bạn có muốn xóa những khách hàng đã chọn ko?');" />
            <asp:Button ID="btnAddUser" runat="server" Text="Thêm Tài khoản mới" onclick="btnAddUser_Click"/>
            <asp:Button ID="btnExportExcel" runat="server" Text="Xuất ra Excel" onclick="btnExportExcel_Click"/>
        </asp:View>
        <asp:View ID="vAddUsers" runat="server">
            <asp:Label ID="lblAddTitle" runat="server" Text="Thêm tài khoản" class="alert_info"></asp:Label>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </asp:View>
    </asp:MultiView>
    
</asp:Content>



