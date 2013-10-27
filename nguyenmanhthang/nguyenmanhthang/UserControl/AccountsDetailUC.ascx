<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AccountsDetailUC.ascx.cs" Inherits="nguyenmanhthang.UserControl.AccountsDetailUC" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<div class="clear"></div>
<asp:ImageButton ID="ibtnBack" runat="server" ImageUrl="~/Images/Template/ibtnBack.gif" onclick="ibtnBack_Click" CssClass="btnBack"/></span><br />
<asp:Label ID="lblMessage" runat="server"></asp:Label><br />
<div class="wrapper_input">
	<div class="header"><h3>Post New Article</h3></div>
	<div class="content">
        <asp:Panel ID="pnlInfo1" runat="server">
        <div class="item half1">
			<p>Mã bài viết</p>
            <asp:TextBox ID="txtTopic_ID" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        <div class="item half2">
			<p>Tác giả</p>
            <asp:TextBox ID="txtTopic_Author" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        </asp:Panel>
        <div class="clear"></div>
		<div class="item">
			<p>Tiêu đề bài viết</p>
            <asp:TextBox ID="txtTopic_Title" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        <div class="item">
			<p>Nội dung</p>
			<div class="ckeditor"><CKEditor:CKEditorControl ID="txtTopic_Content" runat="server" CssClass="textarea"></CKEditor:CKEditorControl></div>
		</div>
        <div class="item">
			<p>Link ảnh bài viết</p>
			<asp:TextBox ID="txtTopic_LinkImage" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
		<div class="item">
			<p>Gắn thẻ</p>
			<asp:TextBox ID="txtTopic_Tag" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
        <div class="item partthree1">
			<p>Thể loại</p>
            <asp:DropDownList ID="ddlTopic_Category" runat="server" CssClass="select"></asp:DropDownList>
		</div>
        <asp:Panel ID="pnlInfo2" runat="server">
        <div class="item partthree1">
			<p>Lượt xem</p>
            <asp:TextBox ID="txtTopic_Visit" runat="server" CssClass="textbox"></asp:TextBox>
		</div>
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