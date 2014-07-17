<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tblAccountUI.aspx.cs" Inherits="Profile.tblAccountUI" %>

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
FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="PK_iAccountsID" 
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
		<asp:BoundField  DataField="PK_iAccountsID"  HeaderText="PK_iAccountsID" SortExpression="PK_iAccountsID">
			<ItemStyle CssClass="GridItemNumber"/>
		</asp:BoundField>
		<asp:BoundField  DataField="sUsername"  HeaderText="sUsername" SortExpression="sUsername">
			<ItemStyle CssClass="GridItemText"/>
		</asp:BoundField>
		<asp:BoundField  DataField="sPassword"  HeaderText="sPassword" SortExpression="sPassword">
			<ItemStyle CssClass="GridItemText"/>
		</asp:BoundField>
		<asp:BoundField  DataField="sEmail"  HeaderText="sEmail" SortExpression="sEmail">
			<ItemStyle CssClass="GridItemText"/>
		</asp:BoundField>
		<asp:BoundField  DataField="sFullName"  HeaderText="sFullName" SortExpression="sFullName">
			<ItemStyle CssClass="GridItemText"/>
		</asp:BoundField>
		<asp:BoundField  DataField="sAddress"  HeaderText="sAddress" SortExpression="sAddress">
			<ItemStyle CssClass="GridItemText"/>
		</asp:BoundField>
		<asp:BoundField  DataField="tDateOfBirth"  HeaderText="tDateOfBirth" SortExpression="tDateOfBirth">
			<ItemStyle CssClass="GridItemDate"/>
		</asp:BoundField>
		<asp:BoundField  DataField="sPhoneNumber"  HeaderText="sPhoneNumber" SortExpression="sPhoneNumber">
			<ItemStyle CssClass="GridItemText"/>
		</asp:BoundField>
		<asp:BoundField  DataField="iPermission"  HeaderText="iPermission" SortExpression="iPermission">
			<ItemStyle CssClass="GridItemNumber"/>
		</asp:BoundField>
		<asp:BoundField  DataField="sLinkAvatar"  HeaderText="sLinkAvatar" SortExpression="sLinkAvatar">
			<ItemStyle CssClass="GridItemText"/>
		</asp:BoundField>
		<asp:BoundField  DataField="sSignature"  HeaderText="sSignature" SortExpression="sSignature">
			<ItemStyle CssClass="GridItemText"/>
		</asp:BoundField>
		<asp:BoundField  DataField="iAlias"  HeaderText="iAlias" SortExpression="iAlias">
			<ItemStyle CssClass="GridItemNumber"/>
		</asp:BoundField>
		<asp:BoundField  DataField="bNotification"  HeaderText="bNotification" SortExpression="bNotification">
			<ItemStyle CssClass="N/A"/>
		</asp:BoundField>
		<asp:BoundField  DataField="iStatus"  HeaderText="iStatus" SortExpression="iStatus">
			<ItemStyle CssClass="GridItemNumber"/>
		</asp:BoundField>
		<asp:BoundField  DataField="tRegisterDate"  HeaderText="tRegisterDate" SortExpression="tRegisterDate">
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
			<td class="name_field_row">PK_iAccountsID:</td>
			<td class="field_row">
				<asp:TextBox id="txtPK_iAccountsID" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lblPK_iAccountsID" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">sUsername:</td>
			<td class="field_row">
				<asp:TextBox id="txtsUsername" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lblsUsername" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">sPassword:</td>
			<td class="field_row">
				<asp:TextBox id="txtsPassword" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lblsPassword" runat="server"></asp:Label>
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
			<td class="name_field_row">sFullName:</td>
			<td class="field_row">
				<asp:TextBox id="txtsFullName" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lblsFullName" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">sAddress:</td>
			<td class="field_row">
				<asp:TextBox id="txtsAddress" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lblsAddress" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">tDateOfBirth:</td>
			<td class="field_row">
				<asp:TextBox id="txttDateOfBirth" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lbltDateOfBirth" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">sPhoneNumber:</td>
			<td class="field_row">
				<asp:TextBox id="txtsPhoneNumber" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lblsPhoneNumber" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">iPermission:</td>
			<td class="field_row">
				<asp:TextBox id="txtiPermission" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lbliPermission" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">sLinkAvatar:</td>
			<td class="field_row">
				<asp:TextBox id="txtsLinkAvatar" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lblsLinkAvatar" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">sSignature:</td>
			<td class="field_row">
				<asp:TextBox id="txtsSignature" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lblsSignature" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">iAlias:</td>
			<td class="field_row">
				<asp:TextBox id="txtiAlias" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lbliAlias" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">bNotification:</td>
			<td class="field_row">
				<asp:TextBox id="txtbNotification" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lblbNotification" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">iStatus:</td>
			<td class="field_row">
				<asp:TextBox id="txtiStatus" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lbliStatus" runat="server"></asp:Label>
			</td>
		</tr>
		<tr>
			<td class="name_field_row">tRegisterDate:</td>
			<td class="field_row">
				<asp:TextBox id="txttRegisterDate" runat="server" Width="200px"></asp:TextBox>
			</td>
			<td class="notify_fild_row">
				<asp:Label id="lbltRegisterDate" runat="server"></asp:Label>
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