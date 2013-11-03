<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AccountsDetailUC.ascx.cs" Inherits="nguyenmanhthang.UserControl.AccountsDetailUC" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<div class="clear"></div>
<asp:ImageButton ID="ibtnBack" runat="server" ImageUrl="~/Images/Template/ibtnBack.gif" onclick="ibtnBack_Click" CssClass="btnBack"/><br />
<asp:Label ID="lblMessage" runat="server"></asp:Label><br />
<div class="wrapper_input">
	<div class="header"><h3>Thông tin chi tiết tài khoản</h3></div>
	<div class="content">
        <asp:Panel ID="pnlAccounts_ID" runat="server">
        <div class="item partthree1">
			<p>Mã tài khoản</p>
            <asp:TextBox ID="txtAccounts_ID" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        </asp:Panel>
        <div class="item partthree1">
			<p>Tên đăng nhập</p>
            <asp:TextBox ID="txtAccounts_Username" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
		<div class="item partthree2">
			<p>Mật khẩu</p>
            <asp:TextBox ID="txtAccounts_Password" runat="server" TextMode="Password" CssClass="textbox"></asp:TextBox>
		</div>
        <div class="clear"></div>
        <div class="item">
			<p>Email</p>
            <asp:TextBox ID="txtAccounts_Email" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        <div class="item">
			<p>Họ và tên</p>
            <asp:TextBox ID="txtAccounts_FullName" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        <div class="item">
			<p>Địa chỉ</p>
            <asp:TextBox ID="txtAccounts_Address" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        <div class="item partthree1">
			<p>Ngày sinh</p>
            <asp:TextBox ID="txtAccounts_DateOfBirth" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        <div class="item partthree1">
			<p>Số điện thoại</p>
            <asp:TextBox ID="txtAccounts_PhoneNumber" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        <div class="item partthree2">
			<p>Quyền hạn</p>
            <asp:DropDownList ID="ddlAccounts_Permission" runat="server" CssClass="select"></asp:DropDownList>
		</div>
        <div class="clear"></div>
        <div class="item">
			<p>Link Avatar</p>
            <asp:TextBox ID="txtAccounts_LinkAvatar" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        <div class="item">
			<p>Chữ ký</p>
            <div class="ckeditor"><CKEditor:CKEditorControl ID="txtAccounts_Signature" runat="server" CssClass="textarea"></CKEditor:CKEditorControl></div>
		</div>
        <asp:Panel ID="pnlAccounts_Like" runat="server">
		<div class="item half1">
			<p>Like</p>
			<asp:TextBox ID="txtAccounts_Like" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        </asp:Panel> 
		<div class="item half2">
			<p>Thông báo</p>
            <asp:CheckBox ID="chkAccounts_Notification" runat="server" CssClass="select" />
		</div>
        <div class="clear"></div>
        <asp:Panel ID="pnlAccounts_RegisterDate" runat="server">
        <div class="item">
			<p>Ngày đăng ký</p>
            <asp:TextBox ID="txtAccounts_RegisterDate" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        </asp:Panel>
    </div>
    <div class="footer">
        <div class="submit">
            <asp:DropDownList ID="ddlAccounts_Status" runat="server"></asp:DropDownList>
            <asp:Button ID="btnPublish" runat="server" Text="Publish" CssClass="btnSubmit" onclick="btnPublish_Click" Visible="false"></asp:Button>
            <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" CssClass="btnSubmit" onclick="btnUpdate_Click" Visible="false" ></asp:Button>
			<input type="reset" value="Reset" class="btnReset">
        </div>
    </div>
</div>