<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PhanCongCongTac_ListUC.ascx.cs" Inherits="DO_AN_TN.UserControl.PhanCongCongTac_ListUC" %>
<script type="text/javascript">
    function CheckAll(oCheckbox) {
        var GridView2 = document.getElementById("<%=grvListPhanCongCongTac.ClientID %>");
        for (i = 1; i < GridView2.rows.length; i++) {
            GridView2.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = oCheckbox.checked;
        }
    }
</script>
<div>
    <table>
        <tr>
            <td>
                <asp:Button ID="btnSearch" runat="server" Text="Tìm kiếm" onclick="btnSearch_Click" />
                <asp:Button ID="btnRefresh" runat="server" Text="Làm mới" onclick="btnRefresh_Click" />
                <asp:Button ID="btnAddNew" runat="server" Text="Thêm" onclick="btnAddNew_Click" />
                <asp:Button ID="btnDeleteList" runat="server" Text="Xóa" onclick="btnDeleteList_Click" />
                <asp:Button ID="btnExportExcel" runat="server" Text="Xuất ra Excel" onclick="btnExportExcel_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvListPhanCongCongTac" runat="server" CssClass="mGrid" 
                    AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                                FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="PK_sMaPCCT"
                                emptydatatext="Không có bản ghi nào." 
                    EnableModelValidation="True" onrowcommand="grvListPhanCongCongTac_RowCommand" 
                    onselectedindexchanged="grvListPhanCongCongTac_SelectedIndexChanged" 
                    onpageindexchanging="grvListPhanCongCongTac_PageIndexChanging" 
                    onrowdatabound="grvListPhanCongCongTac_RowDataBound"  PageSize="5" 
                    AllowSorting="true" onsorting="grvListPhanCongCongTac_Sorting">
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
                                <asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Eval("PK_sMaPCCT")%>'>Chi tiết</asp:LinkButton>
                                </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center"  />
                        </asp:TemplateField>
                        <asp:BoundField  DataField="PK_sMaPCCT"  HeaderText="Mã phân công công tác" SortExpression="PK_sMaPCCT">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="FK_sMaGV" HeaderText="Mã giáo viên" SortExpression="FK_sMaGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="FK_sMaMonhoc" HeaderText="Mã môn học" SortExpression="FK_sMaMonhoc">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tNgayBatDau" HeaderText="Ngày bắt đầu" SortExpression="tNgayBatDau">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tNgayKetThuc" HeaderText="Ngày kết thúc" SortExpression="tNgayKetThuc">
                            <ItemStyle CssClass="GridItemCode" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iTrangThai" HeaderText="Trạng thái" SortExpression="iTrangThai">
                            <ItemStyle CssClass="GridItemCode" />
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