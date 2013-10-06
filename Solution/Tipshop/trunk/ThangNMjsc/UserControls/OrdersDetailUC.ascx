<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OrdersDetailUC.ascx.cs" Inherits="ThangNMjsc.UserControls.OrdersDetail" %>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>

<div style="border: 2px groove red; margin: 10px 10px 10px 10px; padding: 5px 5px 5px 5px">
        <div>
            <div style="float: left; width:80%;">
                <p style="padding: 10px 10px 10px 10px;">
                    <span style="font-weight:bold;">Công ty Cổ phần ThangNM - ThangNMjsc</span><br />
                    Địa chỉ: 96 Định Công - Hoàng Mai - Hà Nội<br />
                    Liên hệ: Nguyễn Mạnh Thắng, SĐT: 0167 527 9562<br />
                    Email: thang.991992@gmail.com<br />
                    Mã số thuế: 0119238230381
                </p>
            </div>
            <div style="float: right; width:18%;">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/logo.gif"/>
            </div>
            <div style="clear:both"><hr /></div>
        </div>
        <div>
            <center><asp:Label ID="Label8" runat="server" Text="Đơn đặt hàng" CssClass="tieude"></asp:Label><br />
            <asp:Label ID="lblOrders_ID" runat="server"></asp:Label><br /><br />
            </center>
            <table>
                <tr>
                    <td>Tên Khách hàng:</td><td><asp:Label ID="lblCustomer" runat="server"></asp:Label></td>
                    <td style="width:300px"></td>
                    <td>Phương thức thanh toán:</td><td><asp:Label ID="lblPay_Name" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Tên Người nhận: </td><td><asp:Label ID="lblPay_FullName" runat="server"></asp:Label></td>
                    <td style="width:300px"></td>
                    <td>Ngày đặt hàng:</td><td><asp:Label ID="lblPay_DateOfStart" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Địa chỉ người nhận: </td><td><asp:Label ID="lblPay_Address" runat="server"></asp:Label></td>
                    <td style="width:300px"></td>
                    <td>Ngày nhận hàng: </td><td><asp:Label ID="lblPay_DateOfFinish" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Điện thoại người nhận: </td><td><asp:Label ID="lblPay_PhoneNumber" runat="server"></asp:Label></td>
                    <td style="width:300px"></td>
                    <td>Trạng thái xử lý: </td><td><asp:Label ID="lblPay_Status" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Email người nhận: </td><td><asp:Label ID="lblPay_Email" runat="server"></asp:Label></td>
                    <td style="width:300px"></td>
                    <td></td><td></td>
                </tr>
            </table><br /><br />
        </div>
        <div style="padding-right: 50px;">
            <center><asp:Label ID="Label1" runat="server" Text="Chi tiết đơn hàng"></asp:Label></center>
            <cc1:gridviewext id="grvListOrder" runat="server" cssclass="mGrid"
                autogeneratecolumns="False" filetypedownload="Excel" width="100%" allowpaging="True"
                pagesize="15" datakeynames="Orders_ID" widthcheckboxcolumn="50" 
                emptydatatext="Không có dữ liệu trả về." 
                onpageindexchanging="grvListOrder_PageIndexChanging">
                <alternatingrowstyle cssclass="GridAlternatingItem"></alternatingrowstyle>
                <columns>
                    <asp:BoundField DataField="Products_Name" HeaderText="Tên Sản phẩm">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="OrdersDetails_UnitPrice" HeaderText="Đơn giá">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="OrdersDetails_Quantity" HeaderText="Số lượng">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Pay_Note" HeaderText="Ghi chú">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                </columns>
            </cc1:gridviewext>
            <br /><asp:Label ID="lblTotal" runat="server" style="float:right;"></asp:Label>
        </div>
        <div>
            <table>
                <tr><td style="padding: 20px 150px 0 100px">NGƯỜI ĐẶT HÀNG</td><td style="padding: 20px 150px 0 100px">NGƯỜI BÁN HÀNG</td></tr>
                <tr><td style="padding: 10px 150px 0 100px">(Kí và ghi rõ họ tên)</td><td style="padding: 10px 150px 0 100px">(Kí và ghi rõ họ tên)</td></tr>
                <tr><td><br /><br /><br /><br /></td></tr>
            </table>
        </div>
    </div>