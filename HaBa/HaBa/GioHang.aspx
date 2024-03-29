﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="HaBa.GioHang" MasterPageFile="~/ShareInterface/ProductSI.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="server">
    <link href="../App_Themes/calendar.css" rel="stylesheet" type="text/css"/>  
    <script src="../Scripts/calendar1.js" type="text/javascript"></script>  
    <script src="../Scripts/calendar2.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $(".startdate").datepicker({ dateFormat: "mm/dd/yy" }).val()
            $(".enddate").datepicker({ dateFormat: "mm/dd/yy" }).val()
        });
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <div id="body-wrapper"><br /><br /><br /><br />
        <center><h2><asp:Label ID="lblNotify" runat="server"></asp:Label></h2>
            <asp:HyperLink ID="hplPK_lHoaDonID" runat="server"></asp:HyperLink>
        </center>
        <asp:Panel ID="pnlGioHang" runat="server" DefaultButton="imgbtnBuy">
            <asp:GridView ID="grvGioHang" runat="server" CssClass="mGrid" 
                AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="PK_sSanPhamID"
                emptydatatext="Không có bản ghi nào."   PageSize="10" 
                EnableModelValidation="True" onrowcommand="grvGioHang_RowCommand" 
                onpageindexchanging="grvGioHang_PageIndexChanging" 
                onrowdatabound="grvGioHang_RowDataBound"
                AllowSorting="true">
                <AlternatingRowStyle CssClass="GridAlternatingItem"></AlternatingRowStyle>
                <Columns>
                    <asp:TemplateField HeaderText="STT">
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%#Container.DataItemIndex + 1 %>'></asp:Label>
                            </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center"  />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Xem">
                        <ItemTemplate><asp:HyperLink ID="hpView" runat="server" class="GridItemlink" >Xem lại sản phẩm</asp:HyperLink></ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="sTenSanPham" HeaderText="Tên sản phẩm">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="lGiaBan" HeaderText="Đơn giá">
                        <ItemStyle CssClass="GridItemNumber" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="Số lượng">
                        <ItemTemplate><asp:TextBox ID="txtsl" runat="server" Text='<%#Eval("iSoLuong")%>' style="text-align:right;"></asp:TextBox></ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="lThanhTien" HeaderText="Thành tiền">
                        <ItemStyle CssClass="GridItemNumber" />
                    </asp:BoundField>
                    <asp:CommandField ButtonType="Image"  DeleteImageUrl="~/App_Themes/Images/delete.png" HeaderText="Xóa" ShowDeleteButton="True" />
                </Columns>
                <RowStyle CssClass="GridItem"></RowStyle>
                <HeaderStyle CssClass="GridHeader"></HeaderStyle>
                <FooterStyle CssClass="GridFooter"></FooterStyle>
            </asp:GridView>
            <span style="color: #000099">Tổng Tiền Giỏ hàng = </span><asp:Label ID="lblTongtien" runat="server" Font-Bold="True" ForeColor="#FF3399" Text="0"></asp:Label><asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#FF3399" Text=" VNĐ"></asp:Label>
            <center>
                <asp:ImageButton ID="imgbtnContinue" runat="server" Height="30px" ImageUrl="~/App_Themes/Images/BuyContinue.png" PostBackUrl="~/Default.aspx" CausesValidation="False" />&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="imgbtnDeleteCart" runat="server" Height="30px" ImageUrl="~/App_Themes/Images/DeleteCart.png" OnClick="imgbtnDeleteCart_Click" CausesValidation="False" />&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="imgbtnUpdate" runat="server" Height="30px" ImageUrl="~/App_Themes/Images/UpdateCart.png" OnClick="imgbtnUpdate_Click" CausesValidation="False" />&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="imgbtnBuy" runat="server" Height="30px" ImageUrl="~/App_Themes/Images/Buy.png" CausesValidation="False" onclick="imgbtnBuy_Click" />
            </center><br /><br />
        </asp:Panel>
        <asp:Panel ID="pnlThanhToan" runat="server" DefaultButton="imgbtnPay">
            <div class="input" style="width: 700px; margin: 0px auto 0px auto;">
                <table>
                    <tr>
                        <td></td>
                        <td><center><h2 class="title">Thông tin đơn hàng</h2></center></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <center>
                                <asp:Label ID="lblMsg" runat="server"></asp:Label><br />
                                <asp:HyperLink ID="hplLogin" runat="server" NavigateUrl="~/Client/Accounts/Login.aspx?Return_Url=~/GioHang.aspx">Đăng nhập / </asp:HyperLink>
                                <asp:HyperLink ID="hplRegister" runat="server" NavigateUrl="~/Client/Accounts/Register.aspx">Đăng ký!</asp:HyperLink>
                            </center>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>Chúng tôi sẽ giao hàng cho ai?</td>
                        <td>
                            <asp:RadioButtonList ID="rblCheck" runat="server" RepeatDirection="Horizontal" ontextchanged="rblCheck_TextChanged" AutoPostBack="true" RepeatLayout="Flow">
                                <asp:ListItem Value="false" Selected="True">Là tôi</asp:ListItem>
                                <asp:ListItem Value="true">Một người khác !</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td><asp:Label ID="Label3" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Tên người nhận: </td>
                        <td><asp:TextBox ID="txtsHoTen" runat="server" class="text" Width="400px"></asp:TextBox></td>
                        <td><asp:Label ID="lblsHoTen" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Điện chỉ Email:  </td>
                        <td><asp:TextBox ID="txtsEmail" runat="server" class="text" Width="400px"></asp:TextBox></td>
                        <td><asp:Label ID="lblsEmail" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Địa chỉ giao hàng: </td>
                        <td><asp:TextBox ID="txtsDiaChi" runat="server" class="text" Width="400px"></asp:TextBox></td>
                        <td><asp:Label ID="lblsDiaChi" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Điện thoại liên hệ: </td>
                        <td><asp:TextBox ID="txtsSoDienThoai" runat="server" class="text" Width="400px" 
                                MaxLength="13"></asp:TextBox></td>
                        <td><asp:Label ID="lblsSoDienThoai" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Hình thức thanh toán: </td>
                        <td><asp:DropDownList ID="ddlFK_iThanhToanID" runat="server" class="dropbox"  Width="405px"></asp:DropDownList></td>
                        <td><asp:Label ID="lblFK_iThanhToanID" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Ghi chú: </td>
                        <td><asp:TextBox ID="txtsGhiChu" runat="server" class="text" TextMode="MultiLine" Rows="3" Width="400px"></asp:TextBox></td>
                        <td><asp:Label ID="lblsGhiChu" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Ngày giao hàng: </td>
                        <td><asp:TextBox ID="txttNgayGiaoHang" runat="server" CssClass="startdate" Width="400px"></asp:TextBox></td>
                        <td><asp:Label ID="lbltNgayGiaoHang" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:ImageButton ID="imgbtnPay" runat="server" Height="30px" ImageUrl="~/App_Themes/Images/nganluong.png" OnClick="imgbtnPay_Click" /></td>
                    </tr>
                </table>
            </div>
        </asp:Panel>
    <br /><br /><br /><br /></div>
</asp:Content>