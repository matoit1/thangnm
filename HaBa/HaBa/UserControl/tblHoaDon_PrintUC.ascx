<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblHoaDon_PrintUC.ascx.cs" Inherits="HaBa.UserControl.tblHoaDon_PrintUC" %>
<style type="text/css">
    .khoangcach
    {
        width: 20px;
    }
    .noidung
    {
        width: 233px;
    }
    .style2
    {
        width: 266px;
    }
    .style3
    {
        width: 865px;
    }
</style>
<div style="border: 2px groove red; margin: 10px 10px 10px 10px; padding: 5px 5px 5px 5px">
<table>
    <tr>
        <td class="style2" rowspan="3">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/App_Themes/Images/logo.jpg"/>
            </td>
        <td class="style3" align="center"><h2><b>CÔNG TY TRÁCH NHIỆM HỮU HẠN HABA</h2></b><br /></td>
        <td class="style2" rowspan="3" align="center">
                 <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/App_Themes/Images/barcode.png"/>
                 <br />
                 <span class="fca3bd1dbb-7e50-4711-901f-3140bc75359a-0" 
                style="font-size: 10pt; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-weight: normal; font-style: normal; font-variant: normal; letter-spacing: normal; line-height: 16px; orphans: auto; text-align: -webkit-center; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px;">
            HaBa JSC/2014</span></td>
    </tr>
    <tr>
        <td class="style3"></td>
    </tr>
    <tr>
        <td class="style3" align="center"><b>Báo Cáo Hóa đơn</b></td>
    </tr>
</table>
        <div>
            <center>
            <asp:Label ID="lblOrders_ID" runat="server"></asp:Label><br /><br />
            </center>
            <table border ="1">
                <tr >
                    <td colspan="2" align="center" style="border: 1px solid black;">Thông tin hóa đơn</td>
                    <td colspan="2" align="center" style="border: 1px solid black;">Thông tin người nhận</td>
                    <td colspan="2" align="center" style="border: 1px solid black;">Thông tin khác</td>
                </tr>
                <tr>
                    <td>Mã hóa đơn:</td><td class="noidung"><asp:Label ID="lblPK_lHoaDonID" runat="server"></asp:Label></td>
                    <td>Họ tên nhận:</td><td class="noidung"><asp:Label ID="lblsHoTen" runat="server"></asp:Label></td>
                    <td rowspan="4">Ghi chú:</td><td class="noidung" rowspan="4"><asp:Label ID="lblsGhiChu" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Nhân viên: </td><td class="noidung"><asp:Label ID="lblFK_iTaiKhoanID_Giao" runat="server"></asp:Label></td>
                    <td>Địa chỉ email:</td><td class="noidung"><asp:Label ID="lblsEmail" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Khách hàng: </td><td class="noidung"><asp:Label ID="lblFK_iTaiKhoanID_Nhan" runat="server"></asp:Label></td>
                    <td>Địa chỉ: </td><td class="noidung"><asp:Label ID="lblsDiaChi" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Thanh toán: </td><td class="noidung"><asp:Label ID="lblFK_iThanhToanID" runat="server"></asp:Label></td>
                    <td>Số điện thoại: </td><td class="noidung"><asp:Label ID="lblsSoDienThoai" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td></td><td class="noidung"></td>
                    <td>Ngày đặt hàng</td><td class="noidung"><asp:Label ID="lbltNgayDatHang" runat="server"></asp:Label></td>
                    <td></td><td class="noidung"></td>
                </tr>
                <tr>
                    <td></td><td></td>
                    <td>Ngày giao hàng</td><td class="noidung"><asp:Label ID="lbltNgayGiaoHang" runat="server"></asp:Label></td>
                    <td>Trạng thái:</td><td class="noidung"><asp:Label ID="lbliTrangThai" runat="server"></asp:Label></td>
                </tr>
            </table><br /><br />
        </div>
        <div style="padding-right: 50px;">
            <center><asp:Label ID="Label1" runat="server" Text="Thông tin chi tiết hóa đơn"></asp:Label></center>
            <asp:GridView ID="grvListChiTietHoaDon" runat="server" CssClass="mGrid" 
                    AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                    FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="FK_lHoaDonID,FK_sSanPhamID"
                    emptydatatext="Không có bản ghi nào."   PageSize="10" 
                    EnableModelValidation="True" 
                    onpageindexchanging="grvListChiTietHoaDon_PageIndexChanging">
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
                        <asp:TemplateField HeaderText="STT">
                            <ItemTemplate>
                            <asp:Label ID="lbliTrangThai" runat="server" Text='<%#Container.DataItemIndex + 1%>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center"  />
                        </asp:TemplateField>
                        <asp:BoundField  DataField="FK_lHoaDonID"  HeaderText="Mã hóa đơn" Visible="false" SortExpression="FK_lHoaDonID">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField  DataField="FK_sSanPhamID"  HeaderText="Mã sản phẩm" SortExpression="FK_sSanPhamID">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="lGiaBan" HeaderText="Giá bán" SortExpression="lGiaBan">
                            <ItemStyle CssClass="GridItemNumber" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iSoLuong" HeaderText="Số lượng" SortExpression="iSoLuong">
                            <ItemStyle CssClass="GridItemNumber" />
                        </asp:BoundField>
                    </Columns>
                    <RowStyle CssClass="GridItem"></RowStyle>
                    <HeaderStyle CssClass="GridHeader"></HeaderStyle>
                    <FooterStyle CssClass="GridFooter"></FooterStyle>
                </asp:GridView>
                <asp:Label ID="lblTotal" runat="server" style="float:right;"></asp:Label>
        </div>
        <div>
            <table style="width: 1240px">
                <tr>
                    <td align="center"><b>Người mua hàng</b></td>
                    <td align="center">Ngày ...... Tháng ...... Năm 20.....<br /><b>Người mua hàng</b></td>
                </tr>
                <tr>
                    <td align="center"><i>(ký, ghi rõ họ tên)</i></td>
                    <td align="center"><i>(ký, ghi rõ họ tên)</i></td>
                </tr>
                <tr>
                    <td><br /><br /><br /><br /></td>
                </tr>
            </table>
        </div>
    </div>