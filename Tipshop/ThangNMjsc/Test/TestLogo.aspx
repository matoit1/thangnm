<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestLogo.aspx.cs" Inherits="ThangNMjsc.Test.TestLogo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-top:-1px; position:fixed; text-indent:-99999px;" itemscope itemtype="http://data-vocabulary.org/Recipe">
    <h1 itemprop="name">TicSoft</h1>
    <img itemprop="photo" src="http://www.ticsoft.com/images/logo-voc.jpg" />
    By <span itemprop="author">VOC</span>
    <span itemprop="summary">Mô tả website của bạn</span>
    <span itemprop="review" itemscope itemtype="http://data-vocabulary.org/Review-aggregate">
    <span itemprop="rating">5.5</span>sao trên<span itemprop="count">1189</span>người dùng</span>
    </div>
    </form>
</body>
</html>
