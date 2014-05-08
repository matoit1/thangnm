<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LichDayVaHoc_ListUC.ascx.cs" Inherits="DO_AN_TN.UserControl.LichDayVaHoc_ListUC" %>
<%@ Register src="Search/LichDayVaHoc_SearchUC.ascx" tagname="LichDayVaHoc_SearchUC" tagprefix="uc1" %>
<script type="text/javascript">
    function CheckAll(oCheckbox) {
        var GridView2 = document.getElementById("<%=grvListLichDayVaHoc.ClientID %>");
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
                            <asp:ListItem Value="0">Tìm theo mã PCCT</asp:ListItem>
                            <asp:ListItem Value="1">Tìm theo mã Lớp</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="btnSearch" runat="server" Text="Tìm kiếm" onclick="btnSearch_Click" />
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvListLichDayVaHoc" runat="server" CssClass="mGrid" 
                    AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                                FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="FK_sMaPCCT, FK_sMalop, iCaHoc"
                                emptydatatext="Không có bản ghi nào." 
                    EnableModelValidation="True" onrowcommand="grvListLichDayVaHoc_RowCommand" 
                    onselectedindexchanged="grvListLichDayVaHoc_SelectedIndexChanged" 
                    onpageindexchanging="grvListLichDayVaHoc_PageIndexChanging" 
                    onrowdatabound="grvListLichDayVaHoc_RowDataBound"  PageSize="5" 
                    AllowSorting="true" onsorting="grvListLichDayVaHoc_Sorting">
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
                        <asp:BoundField  DataField="FK_sMaPCCT"  HeaderText="Mã phân công công tác" SortExpression="FK_sMaPCCT">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="FK_sMalop" HeaderText="Mã lớp học" SortExpression="FK_sMalop">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="FK_sMaMonHoc" HeaderText="Mã môn học" SortExpression="FK_sMaMonHoc">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iCaHoc" HeaderText="Ca học" SortExpression="iCaHoc">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tNgayDay" HeaderText="Ngày dạy" SortExpression="tNgayDay">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iSoTietDay" HeaderText="Số tiết dạy" SortExpression="iSoTietDay">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sSinhVienNghi" HeaderText="Sinh viên nghỉ" SortExpression="sSinhVienNghi">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sSinhVienChan" HeaderText="Sinh viên chặn" SortExpression="sSinhVienChan">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sLinkVideo" HeaderText="Link Video" SortExpression="sLinkVideo">
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
    <uc1:LichDayVaHoc_SearchUC ID="LichDayVaHoc_SearchUC1" runat="server" OnSearch="Search_Click"  />
</div>
