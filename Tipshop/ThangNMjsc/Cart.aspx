<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="ThangNMjsc.Product.Cart"  MasterPageFile="~/MasterPage/PublicProduct.Master"%>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead_Product" runat="server">
    <link href="../../Css/calendar.css" rel="stylesheet" type="text/css"/>
    <link href="Css/public.css" rel="stylesheet" type="text/css"/>
    <script src="../../Scripts/calendar1.js" type="text/javascript"></script>  
    <script src="../../Scripts/calendar2.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $(".startdate").datepicker({ dateFormat: "dd/mm/yy" }).val()
            $(".enddate").datepicker({ dateFormat: "dd/mm/yy" }).val()
        });
    </script>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMainContent_Product" runat="server">
    <div>
    <center><asp:Label ID="Label8" runat="server" Text="Giỏ hàng của bạn" CssClass="tieude"></asp:Label><hr /><br /></center>
        <cc1:GridViewExt ID="grvListMyCart" runat="server" CssClass="mGrid" AutoGenerateColumns="False"
                FileTypeDownload="Excel" Width="100%" AllowPaging="True" PageSize="15" DataKeyNames="Products_ID"
                WidthCheckBoxColumn="50" 
            emptydatatext="Giỏ hàng của bạn chưa có sản phẩm nào" 
            onrowcommand="grvListMyCart_RowCommand" 
            onrowdatabound="grvListMyCart_RowDataBound" 
            onpageindexchanging="grvListMyCart_PageIndexChanging" 
            AutoGenerateCheckBoxColumn="False" classCheckedRow="" classHoverRow="" 
            ColumnShowOnclick="">

            <alternatingrowstyle cssclass="GridAlternatingItem"></alternatingrowstyle>
            <columns>
                <asp:TemplateField HeaderText="Xem">
                    <ItemTemplate><asp:HyperLink ID="hpView" runat="server" class="GridItemlink" >Xem Sản phẩm</asp:HyperLink></ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Products_Name" HeaderText="Tên sản phẩm">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
                <asp:BoundField DataField="Products_Price" HeaderText="Đơn giá">
                    <ItemStyle CssClass="GridItemNumber" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="Số lượng">
                    <ItemTemplate><asp:TextBox ID="txtsl" runat="server" Text='<%#Eval("Products_Numbers")%>'></asp:TextBox></ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Products_Total" HeaderText="Thành tiền">
                    <ItemStyle CssClass="GridItemNumber" />
                </asp:BoundField>
                <asp:CommandField ButtonType="Image"  DeleteImageUrl="~/images/delete.png" HeaderText="Xóa" ShowDeleteButton="True" />
            </columns>
        </cc1:gridviewext>
        <span style="color: #000099">Tổng Tiền Giỏ hàng = </span><asp:Label ID="lblTongtien" runat="server" Font-Bold="True" ForeColor="#FF3399" Text="0"></asp:Label><asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#FF3399" Text=" VNĐ"></asp:Label>
        <center>
            <asp:ImageButton ID="imgbtnContinue" runat="server" Height="30px" 
                ImageUrl="~/Css/Product/theme/BuyContinue.png" PostBackUrl="~/Default.aspx" 
                CausesValidation="False" />&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="imgbtnDeleteCart" runat="server" Height="30px" 
                ImageUrl="~/Css/Product/theme/DeleteCart.png" OnClick="imgbtnDeleteCart_Click" 
                CausesValidation="False" />&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="imgbtnUpdate" runat="server" Height="30px" 
                ImageUrl="~/Css/Product/theme/UpdateCart.png" OnClick="imgbtnUpdate_Click" 
                CausesValidation="False" />
        </center><br /><br />
    </div>
    <asp:Panel ID="Panel1" runat="server" DefaultButton="imgbtnPay">
    <div class="input">
        <h2 class="title">Thông tin đơn hàng</h2>
        <asp:ValidationSummary DisplayMode="BulletList" ID="ValidationSummary1" runat="server" HeaderText="Thanh toán không thành công" ShowMessageBox="false"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bạn chưa nhập họ tên" ControlToValidate="txtPay_FullName" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Bạn chưa nhập Email" ControlToValidate="txtPay_Email" Display="None"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email ko hợp lệ" ControlToValidate="txtPay_Email" Display="None" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Bạn chưa nhập số điện thoại" ControlToValidate="txtPay_PhoneNumber" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Bạn chưa nhập địa chỉ" ControlToValidate="txtPay_Address" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Bạn chưa nhập ngày đặt hàng" ControlToValidate="txtPay_DateOfStart" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Bạn chưa nhập ngày nhận hàng" ControlToValidate="txtPay_DateOfFinish" Display="None"></asp:RequiredFieldValidator>
        <p>Tên người nhận: <asp:TextBox ID="txtPay_FullName" runat="server" class="text"></asp:TextBox></p>
        <p>Điện chỉ Email: <asp:TextBox ID="txtPay_Email" runat="server" class="text"></asp:TextBox></p>
        <p>Điện thoại liên hệ: <asp:TextBox ID="txtPay_PhoneNumber" runat="server" class="text"></asp:TextBox></p>
        <p>Địa chỉ giao hàng: <asp:TextBox ID="txtPay_Address" runat="server" class="text"></asp:TextBox></p>
        <p>Ngày đặt hàng: <asp:TextBox ID="txtPay_DateOfStart" runat="server" style="float:right; margin-right: 250px;" Width= "300px" Height="20px" class="startdate"></asp:TextBox></p>
        <p>Ngày nhận hàng: <asp:TextBox ID="txtPay_DateOfFinish" runat="server" style="float:right; margin-right: 250px;" Width= "300px" Height="20px" class="startdate"></asp:TextBox></p>
        <p>Hình thức thanh toán: <asp:DropDownList ID="dropPayMethod" runat="server" class="dropbox"></asp:DropDownList></p>
        <p>Ghi chú: <asp:TextBox ID="txtPay_Note" runat="server" class="text"></asp:TextBox></p>
        <center><asp:ImageButton ID="imgbtnPay" runat="server" Height="30px" ImageUrl="~/images/nganluong.png" OnClick="imgbtnPay_Click" /></center><br />
        <br></br>
    </div>
    </asp:Panel>
</asp:Content>