<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPayMethod.aspx.cs" Inherits="ThangNMjsc.Admin.Edit.EditPayMethod" MasterPageFile="~/MasterPage/PublicAdmin.Master"%>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <div class="input">
        <p><br /><asp:Label ID="lblTitle" runat="server" Text="Sửa phương thức thanh toán" class="title"></asp:Label><br /></p>
        <p><asp:Label ID="Label14" runat="server"></asp:Label><br />
        </p>
        <asp:Panel ID="panelEdit" runat="server">
            <p><asp:Label ID="lblPay_ID" runat="server" Text="ID: "></asp:Label>
                <asp:TextBox ID="txtPay_ID" runat="server" Enabled="false" class="text"></asp:TextBox><br />
                <asp:RequiredFieldValidator ControlToValidate="txtPay_Name" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bạn chưa nhập tên phương thức thanh toán"></asp:RequiredFieldValidator><br />
                <asp:Label ID="Label11" runat="server" Text="Tên loại thanh toán: "></asp:Label>
                <asp:TextBox ID="txtPay_Name" runat="server" class="text"></asp:TextBox><br />
                <asp:CheckBox ID="ChkPay_Visible" runat="server" Text="Trạng thái kích hoạt" class="checkbox" /><br />
            </p>
            <span style="margin-left: 250px;">
                <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click"/>
                <asp:Button ID="btnAdd" runat="server" Text="Thêm mới" OnClick="btnAdd_Click"/>
            </span>
        </asp:Panel>
    </div>
</asp:Content>
