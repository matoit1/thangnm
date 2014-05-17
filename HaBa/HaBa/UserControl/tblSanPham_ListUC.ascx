<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblSanPham_ListUC.ascx.cs" Inherits="HaBa.UserControl.tblSanPham_ListUC" %>
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
                <%--<asp:HyperLink ID="hplSearch" runat="server" NavigateUrl="#" CssClass="topopup style_button" >Tìm kiếm</asp:HyperLink>--%>
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
                        <asp:BoundField  DataField="FK_sMaGV"  HeaderText="Mã giáo viên" SortExpression="FK_sMaGV">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField  DataField="PK_lMaBaiViet"  HeaderText="Mã bài viết" SortExpression="PK_lMaBaiViet">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="sTieuDe" HeaderText="Tiêu đề" SortExpression="sTieuDe">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sLinkAnh" HeaderText="Link ảnh" SortExpression="sLinkAnh">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sTag" HeaderText="Tags" SortExpression="sTag">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <%--<asp:BoundField DataField="sNoiDung" HeaderText="Nội dung" SortExpression="sNoiDung">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>--%>
                        <asp:BoundField DataField="iLuotXem" HeaderText="Lượt xem" SortExpression="iLuotXem">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tNgayViet" HeaderText="Ngày viết" SortExpression="tNgayViet">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField  DataField="tNgayCapNhat"  HeaderText="Ngày cập nhật" SortExpression="tNgayCapNhat">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="sMoTa" HeaderText="Mô tả" SortExpression="sMoTa">
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
    <%--<uc1:BaiViet_SearchUC ID="BaiViet_SearchUC1" runat="server" OnSearch="Search_Click" />--%>
</div>