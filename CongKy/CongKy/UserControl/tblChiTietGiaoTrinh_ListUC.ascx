<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblChiTietGiaoTrinh_ListUC.ascx.cs" Inherits="CongKy.UserControl.tblChiTietGiaoTrinh_ListUC" %>
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
                <asp:Button ID="btnRefresh" runat="server" Text="Làm mới" onclick="btnRefresh_Click" />
                <asp:Button ID="btnAddNew" runat="server" Text="Thêm" onclick="btnAddNew_Click" />
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
                    FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="PK_iGiaoTrinhID"
                    emptydatatext="Không có bản ghi nào."   PageSize="10" 
                    EnableModelValidation="True" onrowcommand="grvListBaiViet_RowCommand" 
                    onpageindexchanging="grvListBaiViet_PageIndexChanging" 
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
                                <asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Eval("PK_iGiaoTrinhID")%>'>Chi tiết</asp:LinkButton>
                                </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center"  />
                        </asp:TemplateField>
                        <asp:BoundField  DataField="PK_iGiaoTrinhID"  HeaderText="Mã giáo trình" SortExpression="PK_iGiaoTrinhID">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField  DataField="sTenBaiHoc"  HeaderText="Tên bài học" SortExpression="sTenBaiHoc">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="sThongTin" HeaderText="Thông tin" SortExpression="sThongTin">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                         <asp:BoundField DataField="sLinkDownload" HeaderText="Link download" SortExpression="sLinkDownload">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                         <asp:BoundField DataField="iType" HeaderText="Loại" SortExpression="iType">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                         <asp:BoundField DataField="tNgayCapNhat" HeaderText="Ngày cập nhật" SortExpression="tNgayCapNhat">
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
</div>