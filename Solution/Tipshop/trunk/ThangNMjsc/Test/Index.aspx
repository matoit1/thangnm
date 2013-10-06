<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ThangNMjsc.Product.Index" MasterPageFile="~/MasterPage/PublicProduct.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMainContent_Product" runat="server">
    <div id="content">
        <div id="sidebar">
            <div id="navBar">
                <img src="../Images/Products/Images/searchavd.png" alt="task" />
                <img src="../Images/Advertising/ads1.jpg" alt="quảng cáo" width="150px" height="150px"/>
                <img src="../Images/Advertising/ads2.jpg" alt="quảng cáo" width="150px" height="150px"/>
            </div>
        </div><!-- End #sidebar -->
        <div id="primary">
            <div id="welcome">
                <img src="../Images/Avatar/admin.jpg" alt="welcome" width="100px" height="100px" />
                <h1>Chào mừng bạn đến với Công ty cổ phần <span><a href="#">ThangNM</a></span></h1>
                <p>
                    - Công ty Cổ phần ThangNM Bắt đầu kinh doanh vào tháng 3/2013 được thành lập theo Giấy phép số 0103039251. Công ty chúng tôi đang sử dụng hình thức bán hàng trực tuyến trên mạng Internet (kinh doanh Thương mại điện tử) tại Việt Nam.<br />

                    - Công ty ThangNM là nhà bán lẻ chuyên nghiệp các sản phẩm Điện tử - IT - Kỹ thuật số của các thương hiệu nổi tiếng hàng đầu trên thế giới như Sony, Samsung, Panasonic, LG, JVC, Lenovo, HP, Acer….<br />
                    - Hi vọng đến với ThangNM các bạn sẽ tìm thấy được những gì mong muốn.<br />
                    - Vui lòng đọc kỹ các Điều khoản ở đây.<br />
                    Thay mặt công ty ThangNM!
                </p>
                <ul>
                    <li><a href="#">Đọc thêm...</a></li>
                    <li><a href="#">Điều khoản</a></li>
                    <li><a href="#">Liên hệ</a></li>
                    <li><a href="#">Địa điểm</a></li>
                </ul>
            </div><!-- End #welcome -->
            <div>
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" DataKeyField="Products_ID" DataSourceID="SqlDataSource1" Font-Bold="True" OnItemCommand="DataList1_ItemCommand">
                <ItemTemplate>
                    <table>
                        <tr><td rowspan="4" style="width: 100px"><asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("Products_Image1")%>' /></td>
                            <td style="width: 157px; height: 19px; text-align: left;"><asp:Label ID="lblProducts_ID" runat="server" Text='<%#Eval("Products_ID") %>'></asp:Label></td>
                        </tr>
                        <tr><td style="width: 157px; height: 21px; text-align: left;"><asp:Label ID="lblProducts_Name" runat="server" Text='<%#Eval("Products_Name") %>'></asp:Label></td></tr>
                        <tr><td style="width: 157px; height: 4px; text-align: left;"><asp:Label ID="lblProducts_Description" runat="server" Text='<%#Eval("Products_Description") %>'></asp:Label></td></tr>
                        <tr><td style="width: 157px; height: 4px; text-align: left;"><asp:Label ID="lblProducts_Price" runat="server" Text='<%#Eval("Products_Price") %> '></asp:Label></td></tr>
                        <tr><td style="width: 100px"><asp:ImageButton ID="ImageButton1" CommandName="add" runat="server" ImageUrl="~/images/chonmua.gif" /></td>
                            <td style="width: 157px"><asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/Images/icon_chitiet.gif" Width="98px">Click để Xem chi tiết Sản phẩm</asp:HyperLink></td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>"
                SelectCommand="SELECT * FROM Products Where Products_Group<>0">
            </asp:SqlDataSource>
            </div>
        </div><!-- End #primary -->
        <div class="clear"></div><!-- End #clear -->
    </div>
</asp:Content>
