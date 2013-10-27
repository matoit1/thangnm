<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DetailTopicUC.ascx.cs" Inherits="nguyenmanhthang.UserControl.DetailTopicUC" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<link rel="stylesheet" href="css/layout.css" type="text/css" media="screen" />
<div class="clear"></div>
    <asp:Label ID="lblMessage" runat="server"></asp:Label><br />
    <div class="module width_full">
		<div class="header"><h3>Post New Article</h3></div>
		<div class="module_content">
				<fieldset>
					<p>Tiêu đề bài viết</p>
					<asp:TextBox ID="txtTopic_Title" runat="server"></asp:TextBox>
				</fieldset>
				<fieldset>
					<p>Nội dung</p>
					<span style="float:left; margin-left:10px; width:920px;"><CKEditor:CKEditorControl ID="txtTopic_Content" runat="server" CssClass="ck"></CKEditor:CKEditorControl></span>
				</fieldset>
                <fieldset>
					<p>Link Ảnh bìa bài viết</p>
					<asp:TextBox ID="txtTopic_LinkImage" runat="server"></asp:TextBox>
				</fieldset>
				<fieldset style="width:48%; float:left; margin-right: 3%;"> <!-- to make two field float next to one another, adjust values accordingly -->
					<p>Thể loại</p>
                    <asp:DropDownList ID="ddlTopic_Category" runat="server" Width="92%"></asp:DropDownList>
				</fieldset>
				<fieldset style="width:48%; float:left;"> <!-- to make two field float next to one another, adjust values accordingly -->
					<p>Gắn thẻ</p>
					<asp:TextBox ID="txtTopic_Tag" runat="server"></asp:TextBox>
                    <br /><asp:TextBox ID="txtTest" runat="server"></asp:TextBox>
				</fieldset><div class="clear"></div>
		</div>
		<div>
			<div class="submit_link">
                <asp:DropDownList ID="ddlTopic_Status" runat="server"></asp:DropDownList>
                <asp:Button ID="btnPublish" runat="server" Text="Publish" class="alt_btn" onclick="btnPublish_Click"></asp:Button>
                <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" class="alt_btn" ></asp:Button>
				<input type="reset" value="Reset">
			</div>
		</div>
	</div><!-- end of post new article -->
