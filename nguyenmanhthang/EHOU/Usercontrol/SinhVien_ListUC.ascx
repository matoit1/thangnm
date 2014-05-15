<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SinhVien_ListUC.ascx.cs" Inherits="EHOU.UserControl.SinhVien_ListUC" %>
<%@ Register src="Search/SinhVien_SearchUC.ascx" tagname="SinhVien_SearchUC" tagprefix="uc1" %>
<script type="text/javascript">
    function CheckAll(chkTemp) {
        var grvTemp = document.getElementById("<%=grvListSinhVien.ClientID %>");
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
                <asp:GridView ID="grvListSinhVien" runat="server" CssClass="mGrid" 
                    AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                    FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="PK_sMaSV"
                    emptydatatext="Không có bản ghi nào."   PageSize="5" 
                    EnableModelValidation="True" onrowcommand="grvListSinhVien_RowCommand" 
                    onselectedindexchanged="grvListSinhVien_SelectedIndexChanged" 
                    onpageindexchanging="grvListSinhVien_PageIndexChanging" 
                    onrowdatabound="grvListSinhVien_RowDataBound"
                    AllowSorting="true" onsorting="grvListSinhVien_Sorting">
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
                                <asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Eval("PK_sMaSV")%>'>Chi tiết</asp:LinkButton>
                                </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center"  />
                        </asp:TemplateField>
                        <asp:BoundField  DataField="FK_sMaLop"  HeaderText="Mã lớp học" SortExpression="FK_sMaLop">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField  DataField="PK_sMaSV"  HeaderText="Mã sinh viên" SortExpression="PK_sMaSV">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="sHoTenSV" HeaderText="Họ và tên" SortExpression="sHoTenSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sTendangnhapSV" HeaderText="Tên đăng nhập" SortExpression="sTendangnhapSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sMatkhauSV" HeaderText="Mật khẩu" SortExpression="sMatkhauSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sEmailSV" HeaderText="Địa chỉ Email" SortExpression="sEmailSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sDiachiSV" HeaderText="Địa chỉ" SortExpression="sDiachiSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sSdtSV" HeaderText="Số điện thoại" SortExpression="sSdtSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField  DataField="tNgaysinhSV"  HeaderText="Ngày sinh" SortExpression="tNgaysinhSV">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="bGioitinhSV" HeaderText="Giới tính" SortExpression="bGioitinhSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sCMNDSV" HeaderText="Số CMND" SortExpression="sCMNDSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tNgayCapCMNDSV" HeaderText="Ngày cấp cấp CMND" SortExpression="tNgayCapCMNDSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField  DataField="sNoiCapCMNDSV"  HeaderText="Nơi cấp CMND" SortExpression="sNoiCapCMNDSV">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="bHonNhanSV" HeaderText="Hôn nhân" SortExpression="bHonNhanSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sNguoiLienHeSV" HeaderText="Họ và tên người liên hệ" SortExpression="sNguoiLienHeSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sDiaChiNguoiLienHeSV" HeaderText="Địa chỉ người liên hệ" SortExpression="sDiaChiNguoiLienHeSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sSdtNguoiLienHeSV" HeaderText="Số điện thoại" SortExpression="sSdtNguoiLienHeSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iQuanHeVoiNguoiLienHeSV" HeaderText="Quan hệ với người liên hệ" SortExpression="iQuanHeVoiNguoiLienHeSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="bKetnapDoanSV" HeaderText="Kết nạp đoàn TNCS HCM" SortExpression="bKetnapDoanSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iNamketnapDoanSV" HeaderText="Năm kết nạp đoàn TNCS HCM" SortExpression="iNamketnapDoanSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sNoiketnapDoanSV" HeaderText="Nơi kết nạp đoàn TNCS HCM" SortExpression="sNoiketnapDoanSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iNamtotnghiepTHPTSV" HeaderText="Năm tốt nghiệp THPT" SortExpression="iNamtotnghiepTHPTSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tNgayNhapHocSV" HeaderText="Ngày nhập học" SortExpression="tNgayNhapHocSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tNgayRaTruongSV" HeaderText="Ngày ra trường" SortExpression="tNgayRaTruongSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tNgayCapTheSV" HeaderText="Ngày cấp thẻ SV" SortExpression="tNgayCapTheSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sLinkAvatarSV" HeaderText="Link Avatar" SortExpression="sLinkAvatarSV">
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
    <uc1:SinhVien_SearchUC ID="SinhVien_SearchUC1" runat="server" OnSearch="Search_Click" />
</div>