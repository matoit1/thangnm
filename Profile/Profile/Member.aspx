<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Profile.Member" MasterPageFile="~/PublicInterface.Master" %>

<asp:Content ID="cBody" runat="server" ContentPlaceHolderID="cphBody">
            <div class="main_bg"  id="about"><!-- start about us -->
            <div class="container">
	            <div class="row about">
		            <div class="col-md-3 about_img">
			            <img src="https://thangnm.googlecode.com/svn/profile/images/user.png" alt="" class="responsive"/>
		            </div>
		            <div class="col-md-9 about_text">
			            <h3><asp:Label ID="lblsFullName" runat="server"></asp:Label></h3>
			            <h4><asp:Label ID="lbliAlias" runat="server"></asp:Label></h4>
			            <p>
			            1. Kẻ thù lớn nhất của đời developer là tester.<br />
                        2. Ngu dốt lớn nhất của developer là lập chương trình Hello world bị lỗi.<br />
                        3. Thất bại lớn nhất của developer là được thăng chức quản lý.<br />
                        4. Bi ai lớn nhất của developer là PC bị hỏng.<br />
                        5. Sai lầm lớn nhất của developer là tin rằng chương trình của mình không có lỗi.<br />
                        6. Tội lỗi lớn nhất của developer là lập phần mềm quản lý tài chính cho vợ.<br />
                        7. Đáng thương lớn nhất của developer là lấy phải tester.<br />
                        8. Đáng khâm phục nhất trong đời developer là tự nhận phần mềm mình có lỗi.<br />
                        9. Phá sản lớn nhất của developer là bán mất cái PC duy nhất.<br />
                        10. Tài sản lớn nhất của developer là Google.<br />
                        11. Món nợ lớn nhất của developer là deadline.<br />
                        12. Lễ vật lớn nhất của developer là laptop.<br />
                        13. Khiếm khuyết lớn nhất của developer là không biết unit test.<br />
                        14. An ủi lớn nhất của developer là chương trình làm xong không bị lỗi biên dịch.<br />
			            </p>
			            <div class="soc_icons navbar-right">
				            <ul class="list-unstyled text-center">
					            <li><a href="https://www.facebook.com/thang.991992" target="_blank"><i class="fa fa-facebook"></i></a></li>
					            <li><a href="https://twitter.com/thang_991992" target="_blank"><i class="fa fa-twitter"></i></a></li>
					            <li><a href="https://plus.google.com/u/0/109664385150832451485" target="_blank"><i class="fa fa-google-plus"></i></a></li>
					            <li><a href="#"><i class="fa fa-pinterest"></i></a></li>
					            <li><a href="#"><i class="fa fa-linkedin"></i></a></li>
					            <li><a href="#"><i class="fa fa-dribbble"></i></a></li>
				            </ul>	
			            </div>
		            </div>
	            </div>
            </div>
            </div>
</asp:Content>