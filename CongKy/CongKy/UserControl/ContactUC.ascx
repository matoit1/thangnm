<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactUC.ascx.cs" Inherits="CongKy.UserControl.ContactUC" %>
<!-- contact start -->
    <div class="content contact" id="menu-5">
    <div class="container">
     	<div class="row">
        	<div class="col-md-4 col-sm-12">
            	<div class="templatemo_contactmap" style="background:url(../App_Themes/images/96DinhCong.PNG) no-repeat">
    			<div id="templatemo_map"></div>
                <img src="../App_Themes/images/templatemo_contactiframe.png" alt="contact map">
                </div>
                </div>
            <div class="col-md-3 col-sm-12 leftalign">
            	<div class="templatemo_contacttitle">Thông tin liên hệ</div>
                <div class="clear"></div>
                <p>Website học trực tuyến Công Kỳ Hero.</p>
                <div class="templatemo_address">
                	<ul>
                	<li class="left fa fa-map-marker"></li>
                    <li class="right">96 Định Công, Hoàng Mai, Hà Nội</li>
                    <li class="clear"></li>
                    <li class="left fa fa-phone"></li>
                    <li class="right">0988 308 110</li>
                    <li class="clear"></li>
                    <li class="left fa fa-envelope"></li>
                    <li class="right">daomanhky@gmail.com</li>
                    </ul>
                </div>
            </div>
            <div class="col-md-5 col-sm-12">
            	</div>
            	<form role="form">
              	<div class="templatemo_form">
                	<input name="fullname" type="text" class="form-control" id="fullname" placeholder="Họ và Tên" maxlength="40">
              	</div>
              	<div class="templatemo_form">
                	<input name="email" type="text" class="form-control" id="email" placeholder="Địa chỉ Email" maxlength="40">
              	</div>
               	<div class="templatemo_form">
                	<input name="subject" type="text" class="form-control" id="subject" placeholder="Tiêu đề" maxlength="40">
              	</div>
              	<div class="templatemo_form">
	            	<textarea name="message" rows="10" class="form-control" id="message" placeholder="Nội dung"></textarea>
              	</div>
              	<div class="templatemo_form"><button type="button" class="btn btn-primary">Gửi tin nhắn</button></div>
            </form>
            </div>
        </div>
    	
    </div>
    </div>
    </div>
    <!-- contact end -->