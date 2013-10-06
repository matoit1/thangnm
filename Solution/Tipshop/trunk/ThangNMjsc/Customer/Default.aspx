<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ThangNMjsc.Customer.Default" MasterPageFile="~/MasterPage/PublicCustomer.Master"%>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Customer" runat="server">
    <asp:Label ID="Label2" runat="server" Text="Thông tin cá nhân"  Font-Bold="true" ForeColor="#9933CC" Font-Size="Large"></asp:Label><br /><hr />
    <div class="post-item" title="Thông tin cá nhân">
        <center>
            <asp:ImageButton ID="imgbtnProfile" runat="server" PostBackUrl="~/Customer/Profile.aspx" CssClass="item"  style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label5" runat="server" Text="Thông tin cá nhân" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
    <div class ="clear"></div>
    <asp:Label ID="Label11" runat="server" Text="Quản lý Đơn hàng"  Font-Bold="true" ForeColor="#9933CC" Font-Size="Large"></asp:Label><br /><hr />
    <div class="post-item" title="Đơn hàng đang chờ xử lý">
        <center>
            <asp:ImageButton ID="ImageButton9" runat="server" 
                ImageUrl="~/Images/Admin/NewOrders.png" PostBackUrl="~/Customer/WaittingOrders.aspx" 
                CssClass="item" style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label13" runat="server" Text="Đơn hàng đang chờ xử lý" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
    <div class="post-item" title="Đơn hàng đã xử lý">
        <center>
            <asp:ImageButton ID="ImageButton10" runat="server" 
                ImageUrl="~/Images/Admin/Orders.jpg" 
                PostBackUrl="~/Customer/FinishOrders.aspx" CssClass="item" 
                style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label14" runat="server" Text="Đơn hàng đã xử lý" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
    <div class ="clear"></div>
    <asp:Label ID="Label3" runat="server" Text="Quản lý Hỗ trợ"  Font-Bold="true" ForeColor="#9933CC" Font-Size="Large"></asp:Label><br /><hr />
    <div class="post-item" title="Viết Hỗ trợ mới">
        <center>
            <asp:ImageButton ID="ImageButton1" runat="server" 
                ImageUrl="~/Images/Admin/NewQuestions.jpg" 
                PostBackUrl="~/Customer/NewSupport.aspx" CssClass="item" 
                style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label1" runat="server" Text="Viết Hỗ trợ mới" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
    <div class="post-item" title="Hỗ trợ chưa được xử lý">
        <center>
            <asp:ImageButton ID="ImageButton6" runat="server" 
                ImageUrl="~/Images/Admin/NewQuestions.jpg" 
                PostBackUrl="~/Customer/WaittingSupport.aspx" CssClass="item" 
                style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label10" runat="server" Text="Hỗ trợ chưa được xử lý" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
    <div class="post-item" title="Hỗ trợ đã được xử lý">
        <center>
            <asp:ImageButton ID="ImageButton7" runat="server" 
                ImageUrl="~/Images/Admin/Support.png" PostBackUrl="~/Customer/FinishSupport.aspx" 
                CssClass="item" style="border: 2px Dotted Orange;"/><br />
            <asp:Label ID="Label6" runat="server" Text="Hỗ trợ đã được xử lý" ForeColor="DarkOliveGreen"></asp:Label>
        </center>
    </div>
</asp:Content>