<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MonHoc_ListUC.ascx.cs" Inherits="DO_AN_TN.UserControl.MonHoc_ListUC" %>
<%@ Register src="Search/MonHoc_SearchUC.ascx" tagname="MonHoc_SearchUC" tagprefix="uc1" %>

<script type="text/javascript">
    function CheckAll(chkTemp) {
        var grvTemp = document.getElementById("<%=grvListMonHoc.ClientID %>");
        for (i = 1; i < grvTemp.rows.length; i++) {
            grvTemp.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = chkTemp.checked;
        }
    }
</script>
<div>
    <table>
        <tr>
            <td>
                <asp:HyperLink ID="hplSearch" runat="server" NavigateUrl="#" CssClass="topopup style_button" >Tìm kiếm</asp:HyperLink>
                <asp:Button ID="btnRefresh" runat="server" Text="Làm mới" onclick="btnRefresh_Click" />
                <asp:Button ID="btnAddNew" runat="server" Text="Thêm" onclick="btnAddNew_Click" />
                <asp:Button ID="btnDeleteList" runat="server" Text="Xóa" onclick="btnDeleteList_Click" />
                <asp:Button ID="btnExportExcel" runat="server" Text="Xuất ra Excel" onclick="btnExportExcel_Click" />
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
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvListMonHoc" runat="server" CssClass="mGrid" AllowSorting="true" PageSize="5" 
                    AutoGenerateColumns="False" Width="100%" AllowPaging="True" datakeynames="PK_sMaMonhoc"
                    emptydatatext="Không có bản ghi nào."
                    EnableModelValidation="True"
                    onrowcommand="grvListMonHoc_RowCommand"
                    onselectedindexchanged="grvListMonHoc_SelectedIndexChanged"
                    onpageindexchanging="grvListMonHoc_PageIndexChanging"
                    onrowdatabound="grvListMonHoc_RowDataBound"
                    onsorting="grvListMonHoc_Sorting">
                    <AlternatingRowStyle CssClass="GridAlternatingItem"></AlternatingRowStyle>
                    <Columns>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <input id="chkList" type="checkbox" onclick="CheckAll(this)" runat="server" />
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
    <uc1:MonHoc_SearchUC ID="MonHoc_SearchUC1" runat="server" OnSearch="Search_Click" />
</div>
