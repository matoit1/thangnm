<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MonHoc_ListUC.ascx.cs" Inherits="DO_AN_TN.UserControl.MonHoc_ListUC" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register src="~/UserControl/LoginUC.ascx" tagname="LoginUC" tagprefix="uc1" %>

<link href="../App_Themes/popup.css" rel="stylesheet" type="text/css" />
<link href="../App_Themes/login.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Scripts/jquery-1.4.1.min.js"> </script>
<script type="text/javascript" src="../Scripts/popup.js"></script>
<script type="text/javascript">
    function CheckAll(oCheckbox) {
        var GridView2 = document.getElementById("<%=grvListMonHoc.ClientID %>");
        for (i = 1; i < GridView2.rows.length; i++) {
            GridView2.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = oCheckbox.checked;
        }
    }
</script>
<%--<style type="text/css">
.modalBackground
{
    background-color:Gray;
    filter:alpha(opacity=70);
    opacity:0.7;
}
.modalPopup
{
    background-color:#EEEEEE;
    border-width:3px;
    border-style:solid;
    border-color:Gray;
    padding:3px;
}
</style>
<cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
</cc1:ToolkitScriptManager>--%>
<%--    <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="pnlSearch" TargetControlID="btnTimKiem" BackgroundCssClass="modalBackground" 
    OkControlID="" CancelControlID="" DropShadow="true" Drag="false" >
    </cc1:ModalPopupExtender>--%>
<div>
    <table>
        <tr>
            <td>
                <asp:Button ID="btnSearch" runat="server" Text="Tìm kiếm" onclick="btnSearch_Click" />
                <asp:Button ID="btnRefresh" runat="server" Text="Làm mới" onclick="btnRefresh_Click" />
                <asp:Button ID="btnAddNew" runat="server" Text="Thêm" onclick="btnAddNew_Click" />
                <asp:Button ID="btnDeleteList" runat="server" Text="Xóa" />
                <asp:Button ID="btnExportExcel" runat="server" Text="Xuất ra Excel" 
                    onclick="btnExportExcel_Click" />
                <%--<asp:LinkButton ID="LinkButton1" runat="server" CssClass="topopup" >LinkButton</asp:LinkButton>
                <asp:Button ID="btnTimKiem" runat="server" Text="Tìm kiếm"/>--%>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvListMonHoc" runat="server" CssClass="mGrid" 
                    AutoGenerateColumns="False" Width="100%" AllowPaging="True" datakeynames="PK_sMaMonhoc"
                                emptydatatext="Không có bản ghi nào." 
                    EnableModelValidation="True" onrowcommand="grvListMonHoc_RowCommand" 
                    onselectedindexchanged="grvListMonHoc_SelectedIndexChanged" 
                    onpageindexchanging="grvListMonHoc_PageIndexChanging" 
                    onrowdatabound="grvListMonHoc_RowDataBound"  PageSize="5" 
                    AllowSorting="true" onsorting="grvListMonHoc_Sorting">
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
                                <asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Eval("PK_sMaMonhoc")%>'>Chi tiết</asp:LinkButton>
                                </ItemTemplate>
                            <ItemStyle Wrap="true" CssClass="GridItemLink" />
                        </asp:TemplateField>
                        <asp:BoundField  DataField="PK_sMaMonhoc"  HeaderText="Mã môn học" SortExpression="PK_sMaMonhoc">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="sTenMonhoc" HeaderText="Tên môn học" SortExpression="sTenMonhoc">
                            <ItemStyle Wrap="true" CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iSotrinh" HeaderText="Số trình" SortExpression="iSotrinh">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iSotietday" HeaderText="Số tiết dạy" SortExpression="iSotietday">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iTrangThai" HeaderText="Trạng thái" SortExpression="iTrangThai">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber" />
                        </asp:BoundField>
                    </Columns>
                    <RowStyle CssClass="GridItem"></RowStyle>
                    <HeaderStyle CssClass="GridHeader"></HeaderStyle>
                    <FooterStyle CssClass="GridFooter"></FooterStyle>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblTongSoBanGhi" runat="server"></asp:Label></td>
        </tr>
    </table>
</div>
<%--<asp:Panel ID="pnlSearch" runat="server" CssClass="modalPopup">
<uc1:LoginUC ID="LoginUC2" runat="server" OnNavigation="Navigation_Click" />
</asp:Panel>
<div id="toPopup">
	<div class="close"></div>
	<span class="ecs_tooltip">Press Esc to close</span>
	<div id="popup_content"> <!--your content start-->
		<uc1:LoginUC ID="LoginUC1" runat="server" OnNavigation="Navigation_Click" />
	</div> <!--your content end-->
</div> <!--toPopup end-->
<div id="backgroundPopup"></div>--%>