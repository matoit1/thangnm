<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="HaBa.SanPham" MasterPageFile="~/ShareInterface/ProductSI.Master" %>

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
        <h1 style="line-height:30px"><asp:Label ID="lblsName" runat="server"></asp:Label></h1>
        <i><asp:Label ID="lbltLastUpdate" runat="server"></asp:Label></i>
        <hr />
    </div>
    <div class="sanpham">
        <div class="hinhanhmota">
            <div class="magnify">
                <div class="large" style="background:url('<%=Url_Image%>') no-repeat;"></div><!-- đây là kính lúp-ảnh zoom-->
                <asp:Image ID="imgsLinkImage" runat="server" class="small" Width="450px" Height="300px" /><!-- đây là ảnh sản phẩm -->
            </div>
            <div class="binhchon">
                <asp:Label ID="lblVote" runat="server" Text="Đánh giá sản phẩm: "></asp:Label><asp:Label ID="Label2" runat="server" CssClass="rw-js-container"></asp:Label>
                <script language="javascript" src="../Scripts/Vote.js" type="text/javascript"></script>
            </div>
            
        </div>
        <div class="thongtinsanpham">
            <table>
                <tr>
                    <td colspan="2">
                        <!-- AddThis Button BEGIN -->
                        <div class="addthis_toolbox addthis_default_style addthis_32x32_style">
                        <a class="addthis_button_preferred_1"></a>
                        <a class="addthis_button_preferred_2"></a>
                        <a class="addthis_button_preferred_3"></a>
                        <a class="addthis_button_preferred_4"></a>
                        <a class="addthis_button_compact"></a>
                        <a class="addthis_counter addthis_bubble_style"></a>
                        </div>
                        <script type="text/javascript" src="//s7.addthis.com/js/300/addthis_widget.js#pubid=ra-5367abe75d8d9028"></script>
                        <!-- AddThis Button END -->
                    </td>
                </tr>
                <tr >
                    <td class="tieudesanpham">Mã sản phẩm: </td>
                    <td><asp:Label ID="lblPK_sSanPhamID" runat="server"></asp:Label></td>
                </tr>
                <tr >
                    <td class="tieudesanpham">Nhóm sản phẩm: </td>
                    <td><asp:Label ID="lblFK_iNhomSanPhamID" runat="server"></asp:Label></td>
                </tr>
                <tr >
                    <td class="tieudesanpham">Tên sản phẩm: </td>
                    <td><asp:Label ID="lblsTenSanPham" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td class="tieudesanpham">Mô tả: </td>
                    <td><asp:Label ID="lblsMoTa" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td class="tieudesanpham">Thông tin: </td>
                    <td><asp:Label ID="lblsThongTin" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td class="tieudesanpham">Xuất xứ: </td>
                    <td><asp:Label ID="lblsXuatXu" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td class="tieudesanpham">Giá bán: </td>
                    <td><asp:Label ID="lbllGiaBan" runat="server"></asp:Label> VNĐ</td>
                </tr>
                <tr>
                    <td class="tieudesanpham">Trạng thái</td>
                    <td><asp:Label ID="lbliTrangThai" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td class="tieudesanpham"></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="tieudesanpham"></td>
                    <td><asp:Button ID="btnBuy" runat="server" Text="Mua hàng" onclick="btnBuy_Click" /></td>
                </tr>
            </table>
        </div>
    </div>
    <div class="binhluan">
        <div id="fb-root"></div>
        <script>            (function (d, s, id) {
                var js, fjs = d.getElementsByTagName(s)[0];
                if (d.getElementById(id)) return;
                js = d.createElement(s); js.id = id;
                js.src = "//connect.facebook.net/en_US/sdk.js#xfbml=1&appId=432781806807255&version=v2.0";
                fjs.parentNode.insertBefore(js, fjs);
            } (document, 'script', 'facebook-jssdk'));</script>
        <div class="fb-comments" data-href="<%=Request.Url.AbsoluteUri.ToString()%>" data-colorscheme="light" data-numposts="10" data-width="700"></div>
    </div>
</div>
</asp:Content>
