<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ThangNMjsc.Admin.Default" MasterPageFile="~/MasterPage/PublicAdmin.Master"%>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <asp:Label ID="Label2" runat="server" Text="Quản lý Sản phẩm"  Font-Bold="true" ForeColor="#9933CC" Font-Size="Large"></asp:Label><br /><hr />
    <div class="post-item" title="Nhóm Sản phẩm">
        <center>
            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Images/Admin/GroupProduct.jpg" PostBackUrl="~/Admin/GroupProducts.aspx" CssClass="item" style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label5" runat="server" Text="Nhóm Sản phẩm" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
    <div class="post-item" title="Sản phẩm">
        <center>
            <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Images/Admin/Product.jpg" PostBackUrl="~/Admin/Products.aspx" CssClass="item" style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label8" runat="server" Text="Sản phẩm" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
    <div class="post-item" title="Thêm Sản phẩm mới">
        <center>
            <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Images/Admin/NewProduct.jpg" PostBackUrl="~/Admin/Edit/EditProducts.aspx" CssClass="item" style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label9" runat="server" Text="Thêm Sản phẩm mới" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
    <div class ="clear"></div>
    <asp:Label ID="Label11" runat="server" Text="Quản lý Hóa đơn"  Font-Bold="true" ForeColor="#9933CC" Font-Size="Large"></asp:Label><br /><hr />
    <div class="post-item" title="Phương thức thanh toán">
        <center>
            <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/Images/Admin/paymethod.jpg" PostBackUrl="~/Admin/PayMethod.aspx" CssClass="item" style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label12" runat="server" Text="Phương thức thanh toán" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
    <div class="post-item" title="Hóa đơn chưa xử lý">
        <asp:Label ID="lblCountNewOrder" runat="server" Font-Size="18px" ForeColor="Blue" style="margin:0 10px auto 169px; position: absolute;"></asp:Label>
        <center>
            <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/Images/Admin/NewOrders.png" PostBackUrl="~/Admin/NewOrders.aspx" CssClass="item" style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label13" runat="server" Text="Hóa đơn chưa xử lý" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
    <div class="post-item" title="Hóa đơn đã xử lý">
        <center>
            <asp:ImageButton ID="ImageButton10" runat="server" ImageUrl="~/Images/Admin/Orders.jpg" PostBackUrl="~/Admin/Orders.aspx" CssClass="item" style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label14" runat="server" Text="Hóa đơn đã xử lý" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
    <div class ="clear"></div>
    <asp:Label ID="Label1" runat="server" Text="Quản lý Tài khoản" Font-Bold="true" ForeColor="#9933CC" Font-Size="Large"></asp:Label><br /><hr />
    <div class="post-item" title="Quản lý Nhân viên">
        <center>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/Admin/Staff.png" PostBackUrl="~/Admin/Staff.aspx" CssClass="item" style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label4" runat="server" Text="Quản lý Nhân viên" ForeColor="DarkOliveGreen" ></asp:Label>
        </center>
    </div>
    <div class="post-item" title="Quản lý Khách hàng">
        <center>
            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/Admin/Customer.jpg" PostBackUrl="~/Admin/Customer.aspx" CssClass="item" style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label7" runat="server" Text="Quản lý Khách hàng" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
    <div class ="clear"></div>
    <asp:Label ID="Label3" runat="server" Text="Quản lý Hỗ trợ"  Font-Bold="true" ForeColor="#9933CC" Font-Size="Large"></asp:Label><br /><hr />
    <div class="post-item" title="Hỗ trợ chưa được xử lý">
    <asp:Label ID="lblCountNewSupport" runat="server" Text="Label" Font-Size="18px" ForeColor="Blue" style="margin:0 10px auto 169px; position: absolute;"></asp:Label>
        <center>
            <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/Images/Admin/NewQuestions.jpg" PostBackUrl="~/Admin/NewSupport.aspx" CssClass="item" style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label10" runat="server" Text="Hỗ trợ chưa được xử lý" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
    <div class="post-item" title="Hỗ trợ đã được xử lý">
        <center>
            <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/Images/Admin/Support.png" PostBackUrl="~/Admin/Support.aspx" CssClass="item" style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label6" runat="server" Text="Hỗ trợ đã được xử lý" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
    <div class ="clear"></div>
    <asp:Label ID="Label15" runat="server" Text="Quản lý Giao diện và Nội dung"  Font-Bold="true" ForeColor="#9933CC" Font-Size="Large"></asp:Label><br /><hr />
    <div class="post-item" title="Cài đặt chung">
        <center>
            <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="~/Images/Admin/Setting.png" PostBackUrl="~/Admin/Setting.aspx" CssClass="item" style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label18" runat="server" Text="Cài đặt" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
    
    <div class="post-item" title="Backup & Restore Dastabase">
        <center>
            <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="~/Images/Admin/Database.jpg" PostBackUrl="~/Admin/Database.aspx" CssClass="item" style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label16" runat="server" Text="Backup & Restore Dastabase" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
</asp:Content>