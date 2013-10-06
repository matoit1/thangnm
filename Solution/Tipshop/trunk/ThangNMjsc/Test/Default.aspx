<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ThangNMjsc._Default" %>

<%@ Register src="test.ascx" tagname="test" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <title>Homepage - ThangNM Joint Stock Company</title>
	<meta name="description" content="Trang chủ Công ty Cổ phần ThangNM, Homepage - ThangNM Joint Stock Company, ThangNMjsc" />
	<meta name="keywords" content="ThangNM, Homepage - ThangNM Joint Stock Company, Homepage, thang.991992@gmail.com"/>
    <meta content="ThangNMjsc" name="generator"/>
    <meta name="generator" content="ASP.Net 3.5"/>
    <meta name="robots" content="all"/>
<%--    <base href="http://thangnm.somee.com"/>--%>
    <link rel="author" href="https://plus.google.com/109664385150832451485"/>
    <meta name="copyright" content=" &copy; 2013 Copyright ThangNM &trade;"/>
    <link href="../favicon.ico" rel="Shortcut Icon" type="image/x-icon" />
    <meta http-equiv="Content-Language" content="vi"/>
    <!-- CSS & JavaScript -->
    <style type="text/css">
        .button{
            background: #007eff;
            color: White;
            border: 1px solid #b4b5b0;
            padding: 3px;
            cursor: pointer;
            margin-bottom: 5px;
            height: 30px;
            width: 100px;
            text-align:center;
        }
        .button:hover{background: #ff6600;}
	</style>
</head>
<body>
    <form id="form1" runat="server"> 
    <div style="margin: -1px auto;width: 500px; border: 1px solid white;">
        <center>
            <a href="../Default.aspx" title="ThangNM Join Stock Company"><img src="Images/logo.gif" alt="logo ThangNM Joint Stock Company"/></a>
            <h4 style="text-align:center; color:#660099;">Joint Stock Company</h4><br />
            <a href="Admin/Default.aspx"><input value="Admin" class="button" /></a>
            &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
            <a href="Product/Default.aspx"><input value="Product" class="button" /></a>
            &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
            <a href="Customer/Default.aspx"><input value="Customer" class="button" /></a>
        </center>
    </div>
    </form>
</body>
</html>
