<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProducts.aspx.cs" Inherits="ThangNMjsc.Admin.Edit.EditProducts" MasterPageFile="~/MasterPage/PublicAdmin.Master"%>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <div class="input">
        <p><br /><asp:Label ID="Label9" runat="server" class="title" Text="Sửa thông tin Sản phẩm."></asp:Label><br /></p>
        <p><asp:Label ID="Label10" runat="server" Text=""></asp:Label></p>
        <asp:ValidationSummary DisplayMode="List" HeaderText="Lỗi: " ShowMessageBox="false" ShowSummary="true" ID="ValidationSummary1" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="txtProducts_Name" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bạn chưa nhập tên Sản phẩm" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="txtProducts_Price" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Bạn chưa nhập giá bán Sản phẩm" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="txtProducts_Description" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Bạn chưa nhập mô tả Sản phẩm" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="txtProducts_Image1" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Bạn chưa nhập link hình ảnh" Display="None"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ControlToValidate="txtProducts_Price" ID="RegularExpressionValidator1" runat="server" ErrorMessage="Giá bán phải là 1 số VD: 10000" ValidationExpression="([0-9])*" Display="None"></asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ControlToValidate="txtProducts_Sale" ID="RegularExpressionValidator2" runat="server" ErrorMessage="Giá khuyến mại phải là 1 số VD: 10000" ValidationExpression="([0-9])*" Display="None"></asp:RegularExpressionValidator>
        <asp:Panel ID="Panel1" runat="server">
            <p><asp:Label ID="lblProducts_ID" runat="server" Text="Mã Sản phẩm: "></asp:Label>
                    <asp:TextBox ID="txtProducts_ID" runat="server" Enabled="false" class="number"></asp:TextBox><br />
            </p>
            <p><asp:Label ID="Label2" runat="server" Text="Nhóm Sản phẩm: "></asp:Label>
                    <asp:DropDownList ID="dropProducts_Group" runat="server" class="dropbox"></asp:DropDownList><br />
            </p>
            <p><asp:Label ID="Label11" runat="server" Text="Tên Sản phẩm: "></asp:Label>
                    <asp:TextBox ID="txtProducts_Name" runat="server" class="text"></asp:TextBox><br />
            </p>
            <p><asp:Label ID="Label12" runat="server" Text="Giá bán Sản phẩm: "></asp:Label>
                    <asp:TextBox ID="txtProducts_Price" runat="server" class="number"></asp:TextBox><br />
            </p>
            <p><asp:Label ID="Label13" runat="server" Text="Giá khuyến mại: "></asp:Label>
                    <asp:TextBox ID="txtProducts_Sale" runat="server" class="number"></asp:TextBox><br />
            </p>
            <p><asp:Label ID="Label14" runat="server" Text="Thuế giá trị gia tăng (VAT):  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"></asp:Label>
                    <asp:CheckBox ID="chkProducts_VAT" runat="server" /><asp:Label ID="Label3" runat="server" Text="&nbsp;&nbsp;&nbsp;&nbsp; Đã bao gồm VAT"></asp:Label>
            </p>
            <p><asp:Label ID="Label51" runat="server" Text="Mô tả cho Sản phẩm: "></asp:Label>
                <CKEditor:CKEditorControl ID="txtProducts_Description" runat="server" CssClass="ck"></CKEditor:CKEditorControl>
            </p>
            <p><asp:Label ID="Label4" runat="server" Text="Thông tin Sản phẩm: "></asp:Label>
                <CKEditor:CKEditorControl ID="txtProducts_Info" runat="server" CssClass="ck"></CKEditor:CKEditorControl>
            </p>
            <p><asp:Label ID="Label52" runat="server" Text="Xuất xứ: "></asp:Label>
                    <asp:TextBox ID="txtProducts_Origin" runat="server" class="text"></asp:TextBox><br />
            </p>
            <p>
                <asp:Label ID="Label6" runat="server" Text="Đính kèm ảnh 1:"></asp:Label>
                    <asp:TextBox ID="txtProducts_Image1" runat="server" class="text"></asp:TextBox><br />
            </p>
            <p>
                <asp:Label ID="Label7" runat="server" Text="Đính kèm ảnh 2:"></asp:Label>
                    <asp:TextBox ID="txtProducts_Image2" runat="server" class="text"></asp:TextBox><br />
            </p>
            <p>
                <asp:Label ID="Label8" runat="server" Text="Đính kèm ảnh 3:"></asp:Label>
                    <asp:TextBox ID="txtProducts_Image3" runat="server"  class="text"></asp:TextBox><br />
            </p>
            <p>
                <asp:Label ID="Label15" runat="server" Text="Đính kèm ảnh 4:"></asp:Label>
                    <asp:TextBox ID="txtProducts_Video" runat="server" class="text"></asp:TextBox><br />
            </p>
            <p><asp:Label ID="lblProducts_LastUpdate" runat="server" Text="Cập nhật lần cuối: "></asp:Label>
                    <asp:TextBox ID="txtProducts_LastUpdate" runat="server" Enabled="false" class="date"></asp:TextBox><br />
            </p>
            <p><asp:Label ID="Label16" runat="server" Text="Trạng thái kích hoạt: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"></asp:Label>
                <asp:CheckBox ID="chkProducts_Visible" runat="server" /><asp:Label ID="Label17" runat="server" Text="&nbsp;&nbsp;&nbsp;&nbsp; Đã kích hoạt"></asp:Label>
            </p>
            <center>
                <asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click"/>
                <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click"/>
            </center>
        </asp:Panel>
    </div>
</asp:Content>