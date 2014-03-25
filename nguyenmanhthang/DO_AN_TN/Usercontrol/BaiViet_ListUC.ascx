<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BaiViet_ListUC.ascx.cs" Inherits="DO_AN_TN.UserControl.BaiViet_ListUC" %>
<script type="text/javascript">
    function CheckAll(chkTemp) {
        var grvTemp = document.getElementById("<%=grvListBaiViet.ClientID %>");
        for (i = 1; i < grvTemp.rows.length; i++) {
            grvTemp.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = chkTemp.checked;
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
                <asp:GridView ID="grvListBaiViet" runat="server" CssClass="mGrid" 
                    AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                    FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="PK_lMaBaiViet"
                    emptydatatext="Không có bản ghi nào."   PageSize="5" 
                    EnableModelValidation="True" onrowcommand="grvListBaiViet_RowCommand" 
                    onselectedindexchanged="grvListBaiViet_SelectedIndexChanged" 
                    onpageindexchanging="grvListBaiViet_PageIndexChanging" 
                    onrowdatabound="grvListBaiViet_RowDataBound"
                    AllowSorting="true" onsorting="grvListBaiViet_Sorting">
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
                                <asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Eval("PK_lMaBaiViet")%>'>Chi tiết</asp:LinkButton>
                                </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center"  />
                        </asp:TemplateField>
                        <asp:BoundField  DataField="FK_sMaGV"  HeaderText="Mã giáo viên" SortExpression="FK_sMaLop">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField  DataField="PK_lMaBaiViet"  HeaderText="Mã bài viết" SortExpression="PK_sMaSV">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="sTieuDe" HeaderText="Tiêu đề" SortExpression="sHoTenSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sLinkAnh" HeaderText="Link ảnh" SortExpression="sTendangnhapSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sTag" HeaderText="Tags" SortExpression="sMatkhauSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sNoiDung" HeaderText="Nội dung" SortExpression="sEmailSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iLuotXem" HeaderText="Lượt xem" SortExpression="sDiachiSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tNgayViet" HeaderText="Ngày viết" SortExpression="sSdtSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField  DataField="tNgayCapNhat"  HeaderText="Ngày cập nhật" SortExpression="tNgaysinhSV">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="sMoTa" HeaderText="Mô tả" SortExpression="bGioitinhSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iTrangThaiSV" HeaderText="Trạng thái" SortExpression="iTrangThaiSV">
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
</div>