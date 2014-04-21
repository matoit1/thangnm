<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GiangVien_ListUC.ascx.cs" Inherits="DO_AN_TN.UserControl.GiangVien_ListUC" %>
<%@ Register src="Search/GiangVien_SearchUC.ascx" tagname="GiangVien_SearchUC" tagprefix="uc1" %>
<script type="text/javascript">
    function CheckAll(oCheckbox) {
        var GridView2 = document.getElementById("<%=grvListGiangVien.ClientID %>");
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
                            <asp:ListItem Value="0">Tìm theo mã</asp:ListItem>
                            <asp:ListItem Value="1">Tìm theo tên</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="btnSearch" runat="server" Text="Tìm kiếm" onclick="btnSearch_Click" />
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvListGiangVien" runat="server" CssClass="mGrid" 
                    AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                                FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="PK_sMaGV"
                                emptydatatext="Không có bản ghi nào." 
                    EnableModelValidation="True" onrowcommand="grvListGiangVien_RowCommand" 
                    onselectedindexchanged="grvListGiangVien_SelectedIndexChanged" 
                    onpageindexchanging="grvListGiangVien_PageIndexChanging" 
                    onrowdatabound="grvListGiangVien_RowDataBound"  PageSize="5" 
                    AllowSorting="true" onsorting="grvListGiangVien_Sorting">
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
                                <asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Eval("PK_sMaGV")%>'>Chi tiết</asp:LinkButton>
                                </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center"  />
                        </asp:TemplateField>
                        <asp:BoundField  DataField="PK_sMaGV"  HeaderText="Mã giáo viên" SortExpression="PK_sMaGV">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="sHoTenGV" HeaderText="Họ và tên" SortExpression="sHoTenGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sTendangnhapGV" HeaderText="Tên đăng nhập" SortExpression="sTendangnhapGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sMatkhauGV" HeaderText="Mật khẩu" SortExpression="sMatkhauGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sEmailGV" HeaderText="Địa chỉ Email" SortExpression="sEmailGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sDiachiGV" HeaderText="Địa chỉ" SortExpression="sDiachiGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sSdtGV" HeaderText="Số điện thoại" SortExpression="sSdtGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField  DataField="tNgaysinhGV"  HeaderText="Ngày sinh" SortExpression="tNgaysinhGV">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="bGioitinhGV" HeaderText="Giới tính" SortExpression="bGioitinhGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sCMNDGV" HeaderText="Số CMND" SortExpression="sCMNDGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tNgayCapCMNDGV" HeaderText="Ngày cấp cấp CMND" SortExpression="tNgayCapCMNDGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField  DataField="sNoiCapCMNDGV"  HeaderText="Nơi cấp CMND" SortExpression="sNoiCapCMNDGV">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="bHonNhanGV" HeaderText="Hôn nhân" SortExpression="bHonNhanGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tNgayNhanCongTacGV" HeaderText="Ngày nhận công tác" SortExpression="tNgayNhanCongTacGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iChucVuGV" HeaderText="Chức vụ" SortExpression="iChucVuGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iHocViGV" HeaderText="Học vị" SortExpression="sHocViGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="bCongChucGV" HeaderText="Công chức" SortExpression="bCongChucGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sLinkChannelsGV" HeaderText="Link Channels" SortExpression="sLinkChannelsGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sLinkChatRoomsGV" HeaderText="Link Chat Rooms" SortExpression="sLinkChatRoomsGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sLinkAvatarGV" HeaderText="Link Avatar" SortExpression="sLinkAvatarGV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iTrangThaiGV" HeaderText="Trạng thái" SortExpression="iTrangThaiGV">
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
    <uc1:GiangVien_SearchUC ID="GiangVien_SearchUC1" runat="server" OnSearch="Search_Click"  />
</div>
