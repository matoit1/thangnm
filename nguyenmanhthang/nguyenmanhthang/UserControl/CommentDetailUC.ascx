<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CommentDetailUC.ascx.cs" Inherits="nguyenmanhthang.UserControl.CommentDetailUC" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<div class="clear"></div>
<asp:ImageButton ID="ibtnBack" runat="server" ImageUrl="~/Images/Template/ibtnBack.gif" onclick="ibtnBack_Click" CssClass="btnBack"/><br />
<asp:Label ID="lblMessage" runat="server"></asp:Label><br />
<div class="wrapper_input">
	<div class="header"><h3>Post New Article</h3></div>
	<div class="content">
        <asp:Panel ID="pnlInfo1" runat="server">
        <div class="item half1">
			<p>Mã bình luận: </p>
            <asp:TextBox ID="txtComment_ID" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        <div class="item half2">
			<p>Người viết: </p>
            <asp:TextBox ID="txtComment_Name" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        <div class="item half1">
			<p>Email: </p>
            <asp:TextBox ID="txtComment_Email" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        <div class="item half2">
			<p>Website</p>
            <asp:TextBox ID="txtComment_Website" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        </asp:Panel>
        <div class="clear"></div>
        <div class="item">
			<p>Nội dung</p>
			<div class="ckeditor"><CKEditor:CKEditorControl ID="txtComment_Content" runat="server" CssClass="textarea"></CKEditor:CKEditorControl></div>
		</div>
        <asp:Panel ID="pnlInfo2" runat="server">
        <div class="item partthree2">
			<p>Ngày cập nhật</p>
            <asp:TextBox ID="txtTopic_LastUpdate" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        </asp:Panel>
        <div class="clear"></div>
    </div>
    <div class="footer">
        <div class="submit">
            <asp:DropDownList ID="ddlTopic_Status" runat="server"></asp:DropDownList>
            <asp:Button ID="btnPublish" runat="server" Text="Publish" CssClass="btnSubmit" onclick="btnPublish_Click" Visible="false"></asp:Button>
            <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" CssClass="btnSubmit" onclick="btnUpdate_Click" Visible="false" ></asp:Button>
			<input type="reset" value="Reset" class="btnReset">
        </div>
    </div>
</div>