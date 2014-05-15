<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DiemThi_ListUC.ascx.cs" Inherits="EHOU.UserControl.DiemThi_ListUC" %>
<%@ Register src="Search/DiemThi_SearchUC.ascx" tagname="DiemThi_SearchUC" tagprefix="uc1" %>
<script type="text/javascript">
    function CheckAll(oCheckbox) {
        var GridView2 = document.getElementById("<%=grvListDiemThi.ClientID %>");
        for (i = 1; i < GridView2.rows.length; i++) {
            GridView2.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = oCheckbox.checked;
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
                            <asp:ListItem Value="0">Tìm theo mã SV</asp:ListItem>
                            <asp:ListItem Value="1">Tìm theo mã MH</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="btnSearch" runat="server" Text="Tìm kiếm" onclick="btnSearch_Click" />
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvListDiemThi" runat="server" CssClass="mGrid" 
                    AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                                FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="FK_sMaSV, FK_sMaMonhoc, PK_iSolanhoc"
                                emptydatatext="Không có bản ghi nào." 
                    EnableModelValidation="True" onrowcommand="grvListDiemThi_RowCommand" 
                    onselectedindexchanged="grvListDiemThi_SelectedIndexChanged" 
                    onpageindexchanging="grvListDiemThi_PageIndexChanging" 
                    onrowdatabound="grvListDiemThi_RowDataBound"  PageSize="5" 
                    AllowSorting="true" onsorting="grvListDiemThi_Sorting">
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
                        <asp:BoundField  DataField="FK_sMaSV"  HeaderText="Mã sinh viên" SortExpression="FK_sMaSV">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="FK_sMaMonhoc" HeaderText="Mã môn học" SortExpression="FK_sMaMonhoc">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="PK_iSolanhoc" HeaderText="Số lần học" SortExpression="PK_iSolanhoc">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="fDiemchuyencan" HeaderText="Điểm chuyển cần" SortExpression="fDiemchuyencan">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="fDiemgiuaky" HeaderText="Điểm giữa kỳ" SortExpression="fDiemgiuaky">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="fDiemthilan1" HeaderText="Điểm thi lần 1" SortExpression="fDiemthilan1">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="fDiemthilan2" HeaderText="Điểm thi lần 2" SortExpression="fDiemthilan2">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iTrangThai" HeaderText="Trạng thái" SortExpression="iTrangThai">
                            <ItemStyle CssClass="GridItemText" />
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
    <uc1:DiemThi_SearchUC ID="DiemThi_SearchUC1" runat="server" OnSearch="Search_Click" />
</div>
