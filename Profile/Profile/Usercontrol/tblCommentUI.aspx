<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tblCommentUI.aspx.cs" Inherits="Profile.tblCommentUI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title></title>
	<script type="text/javascript">
	    function CheckAll(oCheckbox) {
	        var grvList = document.getElementById("<%=grvList.ClientID %>");
	        for (i = 1; i < grvList.rows.length; i++) {
	            grvList.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = oCheckbox.checked;
	        }
	    }
	</script>
</head>
<body>
	<form id="form1" runat="server">
	<div class="wrapper">
	<asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
	<asp:View ID="vList" runat="server" >
	<table id="tblList" style="border-collapse: collapse" cellpadding="0" width="100%" border="0">

		<tr>

			<td>

				<asp:Button ID="btnRefresh" runat="server" CssClass="btnRefresh" Text="Làm mới" onclick="btnRefresh_Click" /><asp:Button ID="btnInsertNew" runat="server" CssClass="btnInsert" Text="Thêm mới" onclick="btnInsertNew_Click" /><asp:Button ID="btnDeleteList" runat="server" CssClass="btnDeleteList" Text="Xóa" onclick="btnDeleteList_Click" /><asp:Button ID="btnExportExcel" runat="server" CssClass="btnExportExcel" Text="Xuất ra Excel" onclick="btnExportExcel_Click" />

			</td>

		</tr>

<tr>
<td>
<asp:Panel ID="pnlSearch" runat="server" Visible="true">
<asp:TextBox ID="txtTextSearch" runat="server"></asp:TextBox>
<asp:DropDownList ID="ddlTypeSearch" runat="server" ontextchanged="ddlTypeSearch_TextChanged">
<asp:ListItem Value="0">Tìm theo mã</asp:ListItem>
<asp:ListItem Value="1">Tìm theo tên</asp:ListItem>
</asp:DropDownList>
<asp:Button ID="btnSearch" runat="server" Text="Tìm kiếm" onclick="btnSearch_Click" />
</asp:Panel>
</td>
</tr>		<tr>
			<td height="6">
				<asp:GridView ID="grvList" runat="server" CssClass="mGrid" 
AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="PK_lComment_ID" 
emptydatatext="Không có bản ghi nào."
EnableModelValidation="True" onrowcommand="grvList_RowCommand" 
onselectedindexchanged="grvList_SelectedIndexChanged" 
onpageindexchanging="grvList_PageIndexChanging" 
onrowdatabound="grvList_RowDataBound"  PageSize="10" 
AllowSorting="true" onsorting="grvList_Sorting">
<AlternatingRowStyle CssClass="GridAlternatingItem"></AlternatingRowStyle>
	<Columns>
		<asp:TemplateField>
			<HeaderTemplate>
				<input id="Checkbox2" type="checkbox" onclick="CheckAll(this)" runat="server" />
			</HeaderTemplate>
			<ItemTemplate>
				<asp:CheckBox ID="ItemCheckBox" runat="server" />
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField>
			<ItemTemplate>
				<asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Container.DataItemIndex %>'>Chi tiết</asp:LinkButton>
				</ItemTemplate>
			<ItemStyle HorizontalAlign="Center"  />
		</asp:TemplateField>
		<asp:BoundField  DataField="PK_lComment_ID"  HeaderText="PK_lComment_ID" SortExpression="PK_lComment_ID">
			<ItemStyle CssClass="GridItemNumber"/>
		</asp:BoundField>
		<asp:BoundField  DataField="FK_lTopicID"  HeaderText="FK_lTopicID" SortExpression="FK_lTopicID">
			<ItemStyle CssClass="GridItemNumber"/>
		</asp:BoundField>
		<asp:BoundField  DataField="sName"  HeaderText="sName" SortExpression="sName">
			<ItemStyle CssClass="GridItemText"/>
		</asp:BoundField>
		<asp:BoundField  DataField="sEmail"  HeaderText="sEmail" SortExpression="sEmail">
			<ItemStyle CssClass="GridItemText"/>
		</asp:BoundField>
		<asp:BoundField  DataField="sWebsite"  HeaderText="sWebsite" SortExpression="sWebsite">
			<ItemStyle CssClass="GridItemText"/>
		</asp:BoundField>
		<asp:BoundField  DataField="sContent"  HeaderText="sContent" SortExpression="sContent">
			<ItemStyle CssClass="GridItemText"/>
		</asp:BoundField>
		<asp:BoundField  DataField="bStatus"  HeaderText="bStatus" SortExpression="bStatus">
			<ItemStyle CssClass="N/A"/>
		</asp:BoundField>
		<asp:BoundField  DataField="tLastUpdate"  HeaderText="tLastUpdate" SortExpression="tLastUpdate">
			<ItemStyle CssClass="GridItemDate"/>
		</asp:BoundField>
	</Columns>
	<RowStyle CssClass="GridItem"></RowStyle>
	<HeaderStyle CssClass="GridHeader"></HeaderStyle>
	<FooterStyle CssClass="GridFooter"></FooterStyle>
</asp:GridView>			</td>
		</tr>		<tr>			<td><asp:Label id="lblRowCount" runat="server" ForeColor="Blue"></asp:Label>			</td>		</tr>
	</table>
</asp:View>

	<asp:View ID="vDetail" runat="server" ><asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton><br />	<table id="tblDetail" style="border-collapse: collapse" cellpadding="0" width="100%" border="0">
		<tr>
			<td></td>
			<td></td>
		</tr>
		<tr>
			<td></td>
			<td>
				<asp:Label id="lblTitle" runat="server" ForeColor="Blue"></asp:Label><br /><br />
				<asp:Label id="lblMsg" runat="server" ForeColor="Red"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">PK_lComment_ID:</td>
			<td class="field_row">
				<asp:TextBox id="txtPK_lComment_ID" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lblPK_lComment_ID" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">FK_lTopicID:</td>
			<td class="field_row">
				<asp:DropDownList id="ddlFK_lTopicID" runat="server" Width="200px"></asp:DropDownList>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lblFK_lTopicID" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">sName:</td>
			<td class="field_row">
				<asp:TextBox id="txtsName" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lblsName" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">sEmail:</td>
			<td class="field_row">
				<asp:TextBox id="txtsEmail" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lblsEmail" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">sWebsite:</td>
			<td class="field_row">
				<asp:TextBox id="txtsWebsite" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lblsWebsite" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">sContent:</td>
			<td class="field_row">
				<asp:TextBox id="txtsContent" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lblsContent" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">bStatus:</td>
			<td class="field_row">
				<asp:TextBox id="txtbStatus" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lblbStatus" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">tLastUpdate:</td>
			<td class="field_row">
				<asp:TextBox id="txttLastUpdate" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lbltLastUpdate" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td></td>
			<td>
				<asp:Button ID="btnInsert" CssClass="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Thêm mới" />
				<asp:Button ID="btnUpdate" CssClass="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Cập nhật" />
				<asp:Button ID="btnDelete" CssClass="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Xóa" />
				<asp:Button ID="btnReset" CssClass="btnInsert" runat="server" OnClick="btnReset_Click" Text="Làm mới" />
			</td>
		</tr>
	</table>
</asp:View>
</asp:MultiView>

	</div>
	</form>
</body>
</html>