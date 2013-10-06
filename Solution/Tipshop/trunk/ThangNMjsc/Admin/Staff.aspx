<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="ThangNMjsc.Admin.Staff" MasterPageFile="~/MasterPage/PublicAdmin.Master"%>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <div class="search">
        <center><asp:TextBox ID="txtAccounts_FullName" runat="server" CssClass="textboxmain"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" onclick="btnSearch_Click" />
            <asp:LinkButton ID="btnShowSearchAdvanced" runat="server" OnClick="btnShowSearchAdvanced_Click">Tìm kiếm nâng cao</asp:LinkButton>
        </center>
        <asp:Panel ID="PanelSearchAdvanced" runat="server" Visible="false">
            <div class="left">
                <p><asp:Label ID="Label1" runat="server" Text="Tìm kiếm theo tên đăng nhập: "></asp:Label>
                <asp:TextBox ID="txtAccounts_Username" runat="server" CssClass="textbox"></asp:TextBox></p>
                <p><asp:Label ID="Label3" runat="server" Text="Tìm kiếm theo địa chỉ: "></asp:Label>
                <asp:TextBox ID="txtAccounts_Address" runat="server" CssClass="textbox"></asp:TextBox></p>
            </div>
            <div class="right">
                <p><asp:Label ID="Label2" runat="server" Text="Tìm kiếm theo địa chỉ email: "></asp:Label>
                <asp:TextBox ID="txtAccounts_Email" runat="server" CssClass="textbox"></asp:TextBox></p>
                <p>&nbsp;</p>
            </div>
        </asp:Panel>
    </div>
    <div>
        <center><asp:Label ID="Label8" runat="server" Text="Danh sách Nhân viên" CssClass="tieude"></asp:Label><br /><br />
        <asp:Label ID="Label13" runat="server" style="margin-left:50px"></asp:Label>
        </center>
        <cc1:GridViewExt ID="grvListStaff" runat="server" CssClass="mGrid" AutoGenerateCheckBoxColumn="True" AutoGenerateColumns="False"
                FileTypeDownload="Excel" Width="100%" AllowPaging="True" PageSize="15" DataKeyNames="Accounts_Username"
                classCheckedRow="" classHoverRow="" ColumnShowOnclick="" EnableModelValidation="True"
                WidthCheckBoxColumn="50" emptydatatext="Không có dữ liệu trả về."  onrowdatabound="grvListStaff_RowDataBound" onpageindexchanging="grvListStaff_PageIndexChanging">

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
        </cc1:gridviewext>
        <br /><hr />
        <asp:Button ID="Delete" runat="server" Text="Xóa" onclick="btnDelete_Click" OnClientClick="return confirm('Bạn có muốn xóa những nhân viên đã chọn ko?');"/>
        <asp:Button ID="Button1" runat="server" Text="Thêm Nhân viên mới" PostBackUrl="~/Admin/Edit/EditAccounts.aspx" />
    </div>
</asp:Content>