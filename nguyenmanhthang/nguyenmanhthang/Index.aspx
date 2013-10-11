﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="nguyenmanhthang.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nguyễn Mạnh Thắng - Đơn giản là chia sẻ</title>
    <style type="text/css">
        .title{color: Red; text-align:center; font-size: 25px}
        .info{color: Blue; margin-left:400px;}
        .example{margin-left:400px; border:3px groove purple}
        .textbox{width: 200px}
    </style>
    <script language="javascript" type="text/javascript">
// <![CDATA[
        function btnRegister_onclick() {
            var Gender, Agree;
            if (rdoMen.checked) { Gender = "Nam"; }
            else { Gender = "Nữ"; }
            if (chkAgree.checked) { Agree = "Đồng ý!"; }
            else { Agree = "Không Đồng ý!"; }
            txtContent.innerHTML = "Họ và Tên: " + txtLastName.value + " " + txtMiddleName.value + " " + txtFirstName.value + "\r\n" +
                                    "Tên đăng nhập: " + txtUsername.value + "\r\n" +
                                    "Mật khẩu: " + txtPassword.value + "\r\n" +
                                    "Email: " + txtEmail.value + "\r\n" +
                                    "Ngày sinh: " + slDay.value + "/" +
                                    slMonth.value + "/" +
                                    slYear.value + "\r\n" +
                                    "Giới tính: " + Gender + "\r\n" +
                                    "Địa chỉ: " + slAddress.value + "\r\n" +
                                    "Điều khoản: " + Agree;
        }

        function txtUsername_onchange() {
            if (txtUsername.value != "") {
                txtContent.innerHTML = "Tên đăng nhập: " + txtUsername.value;
            }
            else {
                txtContent.innerHTML = "Tên đăng nhập: Bạn chưa nhập";
                txtUsername.focus();
            }
        }

        function txtPassword_onchange() {
            if (txtPassword.value != "") {
                txtContent.innerHTML = "Mật khẩu: " + txtPassword.value;
            }
            else {
                txtContent.innerHTML = "Mật khẩu: Bạn chưa nhập";
                txtPassword.focus();
            }
        }

        function txtEmail_onchange() {
            if (txtEmail.value != "") {
                if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(txtEmail.value)) {
                    txtContent.innerHTML = "Email: " + txtEmail.value;
                }
                else {
                    txtContent.innerHTML = "Email không đúng định dạng";
                }
            }
            else {
                txtContent.innerHTML = "Email: Bạn chưa nhập";
                txtEmail.focus();
            }
        }

        function slDay_onchange() {
            txtContent.innerHTML = "Ngày sinh: " + slDay.value + "/" + slMonth.value + "/" + slYear.value
        }
        function slMonth_onchange() {
            txtContent.innerHTML = "Ngày sinh: " + slDay.value + "/" + slMonth.value + "/" + slYear.value
        }

        function slYear_onchange() {
            txtContent.innerHTML = "Ngày sinh: " + slDay.value + "/" + slMonth.value + "/" + slYear.value
        }
        function rdoMen_onchange() {
            txtContent.innerHTML = "Giới tính: Nam";
        }
        function rdoWomen_onchange() {
            txtContent.innerHTML = "Giới tính: Nữ";
        }

        function slAddress_onchange() {
            txtContent.innerHTML = "Địa chỉ: " + slAddress.value;
        }

        function chkAgree_onchange() {
            var Agree;
            if (chkAgree.checked) { Agree = "Đồng ý!"; }
            else { Agree = "Không Đồng ý!"; }
            txtContent.innerHTML = "Điều khoản: " + Agree;
        }

        function txtLastName_onchange() {
            txtContent.innerHTML = "Họ: " + txtLastName.value;
        }

        function txtMiddleName_onchange() {
            txtContent.innerHTML = "Đệm: " + txtMiddleName.value;
        }

        function txtFirstName_onchange() {
            txtContent.innerHTML = "Tên: " + txtFirstName.value;
        }

// ]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 class="title">Bài tập môn <br />Lập trình Web</h1>
    <ul class="info">
        <li>Giáo viên hướng dẫn: Thái Thanh Tùng</li>
        <li>Sinh viên thực hiện: Nguyễn Mạnh Thắng</li>
        <li>E-Mail: <a href="mailto:thang.991992@gmal.com">thang.991992@gmail.com</a></li>
        <li>Lớp chính khóa: 10B3</li>
        <li>Lớp chuyên ngành: Mạng</li>
    </ul>
    <table class="example" cellpadding= "5px">
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                Họ: &nbsp;&nbsp;<input id="txtLastName" type="text" size="8" value="Nguyễn" onchange="return txtLastName_onchange()" /> 
                Đệm: &nbsp;&nbsp;<input id="txtMiddleName" type="text" size="8" value="Mạnh" onchange="return txtMiddleName_onchange()" />
                Tên: &nbsp;&nbsp;<input id="txtFirstName" type="text" size="8" value="Thắng" onchange="return txtFirstName_onchange()" />
            </td>
            <td style="color: Red">*</td>
        </tr>
        <tr>
            <td>Tên đăng nhập</td>
            <td><input id="txtUsername" type="text" class="textbox" title="(10 -> 25 ký tự)" onchange="return txtUsername_onchange()" /></td>
            <td style="color: Red">*</td>
        </tr>
        <tr>
            <td>Mật khẩu</td>
            <td><input id="txtPassword" type="password" class="textbox" title="(10 -> 25 ký tự)" onchange="return txtPassword_onchange()" /></td>
            <td style="color: Red">*</td>
        </tr>
        <tr>
            <td>Email</td>
            <td><input id="txtEmail" type="text" class="textbox" title="name@example.com" onchange="return txtEmail_onchange()" /></td>
            <td style="color: Red">*</td>
        </tr>
        <tr>
            <td>Ngày sinh</td>
            <td>
                <select id="slDay" title="9" onchange="return slDay_onchange()">
                    <option>01</option>
                    <option>02</option>
                    <option>03</option>
                    <option>04</option>
                    <option>05</option>
                    <option>06</option>
                    <option>07</option>
                    <option>08</option>
                    <option>09</option>
                    <option>10</option>
                    <option>11</option>
                    <option>12</option>
                    <option>13</option>
                    <option>14</option>
                    <option>15</option>
                    <option>16</option>
                    <option>17</option>
                    <option>18</option>
                    <option>19</option>
                    <option>20</option>
                    <option>21</option>
                    <option>22</option>
                    <option>23</option>
                    <option>24</option>
                    <option>25</option>
                    <option>26</option>
                    <option>27</option>
                    <option>28</option>
                    <option>29</option>
                    <option>30</option>
                    <option>31</option>
              </select>
              <select id="slMonth" title="9" onchange="return slMonth_onchange()">
                    <option>01</option>
                    <option>02</option>
                    <option>03</option>
                    <option>04</option>
                    <option>05</option>
                    <option>06</option>
                    <option>07</option>
                    <option>08</option>
                    <option>09</option>
                    <option>10</option>
                    <option>11</option>
                    <option>12</option>
                </select>
                <select id="slYear" title="1992" onchange="return slYear_onchange()">
                    <option>1992</option>
                    <option>1993</option>
                    <option>1994</option>
                    <option>1995</option>
                    <option>1996</option>
                    <option>1997</option>
                    <option>1998</option>
                    <option>1999</option>
                    <option>2000</option>
                    <option>...</option>
                </select>
                (dd/mm/yyyy)
            </td>
            <td style="color: Red">*</td>
        </tr>
        <tr>
            <td>Giới tính</td>
            <td><input id="rdoMen" type="radio" title="Nam" value="Nam"  checked="checked" name="R1" onchange="return rdoMen_onchange()"/> Nam &nbsp;&nbsp;&nbsp;
                <input id="rdoWomen" type="radio" title="Nữ" value="Nữ" name="R1" onchange="return rdoWomen_onchange()"/> Nữ
            </td>
            <td style="color: Red">*</td>
        </tr>
        <tr>
            <td>Địa chỉ</td>
            <td>
                <select id="slAddress" class="textbox" title="Hà Nội" onchange="return slAddress_onchange()">
                    <option>Hà Nội</option>
                    <option>Nam Định</option>
                    <option>Vĩnh Phúc</option>
                    <option>Hải Phòng</option>
                    <option>Thái Bình</option>
                    <option>...</option>
                </select>
            </td>
            <td style="color: Red">*</td>
        </tr>
        <tr>
            <td>Đồng ý với các điều khoản</td>
            <td><input id="chkAgree" type="checkbox" title="Đồng ý với các điều khoản" onchange="return chkAgree_onchange()"/> Đồng ý !</td>
            <td style="color: Red">*</td>
        </tr>
        <tr>
            <td>Nội dung bạn đã nhập</td>
            <td><textarea id="txtContent" cols="30" rows="7" disabled="disabled" >Create by ThangNM &#10; http://fb.com/thang.991992 </textarea></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <input id="btnRegister" type="button" value="Đăng ký" onclick="return btnRegister_onclick()" />
                <input id="btnReset" type="reset" value="Reset"/>
            </td>
        </tr>
    </table>
    <div>
        <center>&copy; 2013 Designed by ThangNM</center>
    </div>
    </div>
    </form>
</body>
</html>
