<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPayMethod.aspx.cs" Inherits="ThangNMjsc.Admin.Edit.EditPayMethod" MasterPageFile="~/MasterPage/PublicAdmin.Master"%>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <div class="input">
        <p><br /><asp:Label ID="lblTitle" runat="server" Text="Sửa phương thức thanh toán" class="title"></asp:Label><br /></p>
        <p><asp:Label ID="Label14" runat="server"></asp:Label><br />
        </p>
        <asp:Panel ID="panelEdit" runat="server">
            <table>
                <tr>
                    <td><asp:Label ID="lblPay_ID" runat="server" Text="Mã Thanh toán: "></asp:Label></td>
                    <td><asp:TextBox ID="txtPay_ID" runat="server" Enabled="false" class="text"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Tên loại thanh toán: </td>
                    <td><asp:TextBox ID="txtPay_Name" runat="server" class="text"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ControlToValidate="txtPay_Name" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bạn chưa nhập tên phương thức thanh toán"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:CheckBox ID="ChkPay_Visible" runat="server" Text="Trạng thái kích hoạt" class="checkbox" /></td>
                    <td></td>
                </tr>
                <tr><td><br /></td><td><br /></td><td><br /></td></tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click"/><asp:Button ID="btnAdd" runat="server" Text="Thêm mới" OnClick="btnAdd_Click"/></td>
                    <td></td>
                </tr>
            </table>
        </asp:Panel>
    </div>
</asp:Content>
