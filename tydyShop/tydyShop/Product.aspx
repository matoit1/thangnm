<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="tydyShop.Product" MasterPageFile="~/ShareInterface/ProductSI.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
    <link rel="stylesheet" type="text/css" href="../App_Themes/ZoomImage.css" />
    <script src="http://thecodeplayer.com/uploads/js/prefixfree.js" type="text/javascript"></script>
    <script src="http://thecodeplayer.com/uploads/js/jquery-1.7.1.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            var native_width = 0;
            var native_height = 0;
            $(".magnify").mousemove(function (e) {
                if (!native_width && !native_height) {
                    var image_object = new Image();
                    image_object.src = $(".small").attr("src");
                    native_width = image_object.width;
                    native_height = image_object.height;
                }
                else {
                    var magnify_offset = $(this).offset();
                    var mx = e.pageX - magnify_offset.left;
                    var my = e.pageY - magnify_offset.top;
                    if (mx < $(this).width() && my < $(this).height() && mx > 0 && my > 0) {
                        $(".large").fadeIn(100);
                    }
                    else {
                        $(".large").fadeOut(100);
                    }
                    if ($(".large").is(":visible")) {
                        var rx = Math.round(mx / $(".small").width() * native_width - $(".large").width() / 2) * -1;
                        var ry = Math.round(my / $(".small").height() * native_height - $(".large").height() / 2) * -1;
                        var bgp = rx + "px " + ry + "px";
                        var px = mx - $(".large").width() / 2;
                        var py = my - $(".large").height() / 2;
                        $(".large").css({ left: px, top: py, backgroundPosition: bgp });
                    }
                }
            })
        })
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
<div class="phanchinh">
    <div class="thongtin">
        <h1><asp:Label ID="lblProducts_Name" runat="server"></asp:Label></h1>
        <h4><i><asp:Label ID="lblProducts_LastUpdate" runat="server"></asp:Label></i></h4>
        <hr />
    </div>
    <div class="chiase">
        Facebook | Google + | ZingMe
    </div>
    <div class="sanpham">
        <div class="hinhanhmota">
            <div class="magnify">
                <div class="large" style="background:url('<%=Url_Image%>') no-repeat;"></div><!-- đây là kính lúp-ảnh zoom-->
                <asp:Image ID="imgProducts_Image1" runat="server" class="small"/>
                <%--<img class="small" src="http://thecodeplayer.com/uploads/media/iphone.jpg" width="200" alt="tydyShop" />--%><!-- đây là ảnh sản phẩm -->
            </div>
        </div>
        <div class="thongtinsanpham">
            <table>
                <tr>
                    <td>Tên sản phẩm: </td>
                    <td><asp:Label ID="lblProducts_Name1" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Mô tả: </td>
                    <td><asp:Label ID="lblProducts_Description" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Thông tin: </td>
                    <td><asp:Label ID="lblProducts_Info" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Xuất xứ: </td>
                    <td><asp:Label ID="lblProducts_Origin" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Giá bán: </td>
                    <td><asp:Label ID="lblProducts_Price" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btnBuy" runat="server" Text="Mua hàng" /></td>
                    <td></td>
                </tr>
            </table>
        </div>
    </div>
    <div class="ganthe">
        <asp:ListBox ID="lstbTag" runat="server"></asp:ListBox>
    </div>
</div>
</asp:Content>