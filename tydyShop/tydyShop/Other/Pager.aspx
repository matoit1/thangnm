<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pager.aspx.cs" Inherits="tydyShop.Other.Pager" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <style>
        .box_outer
        {
            border-bottom: 2px solid #ebebeb;
            margin-bottom: 5px;
        }

        .cat_article
        {
            overflow: hidden;
            background: #fff;
            border: 1px solid #ccc;
            padding: 0 20px 0 20px;
        }

        .cat_article_title
        {
            font-size: 12px;
            font-weight: bold;
            color: #40454d;
            padding: 10px 10px 10px 10px;
            border-bottom: 1px solid #ebebeb;
            margin-bottom: 10px;
            background: #f8f8f8;
            margin: 0 -20px 0 -20px;
        }

            .cat_article_title a
            {
                font-weight: bold;
                color: black;
            }

        ul.pagination
        {
            overflow: hidden;
            margin: 0px;
            list-style-type: none;
            padding: 0px;
        }

            ul.pagination li
            {
                float: left;
                margin-right: 2px;
            }

                ul.pagination li a
                {
                    border: 1px solid #bdc7d8;
                    display: inline-block;
                    height: 22px;
                    line-height: 22px;
                    color: #666;
                    font-size: 11px;
                    padding: 0 8px;
                    background: #e6e9ed;
                    background-image: linear-gradient(bottom, #E2E5EA 17%, #EBEDF0 59%, #F4F4F4 80%, #F5F5F5 90%);
                    background-image: -o-linear-gradient(bottom, #E2E5EA 17%, #EBEDF0 59%, #F4F4F4 80%, #F5F5F5 90%);
                    background-image: -moz-linear-gradient(bottom, #E2E5EA 17%, #EBEDF0 59%, #F4F4F4 80%, #F5F5F5 90%);
                    background-image: -webkit-linear-gradient(bottom, #E2E5EA 17%, #EBEDF0 59%, #F4F4F4 80%, #F5F5F5 90%);
                    background-image: -ms-linear-gradient(bottom, #E2E5EA 17%, #EBEDF0 59%, #F4F4F4 80%, #F5F5F5 90%);
                    background-image: -webkit-gradient( linear, left bottom, left top, color-stop(0.17, #E2E5EA), color-stop(0.59, #EBEDF0), color-stop(0.8, #F4F4F4), color-stop(0.9, #F5F5F5) );
                    filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#F5F5F5', endColorstr='#E2E5EA', GradientType=0);
                    border-radius: 3px;
                }

        .pagination li a:hover, .pagination li a.active, .pagination li.selected a, .pagination li.active a
        {
            color: #fff;
            background: #f78f00;
            background-image: linear-gradient(bottom, #F58B00 17%, #F89100 59%, #FA9600 80%, #FD9C00 90%);
            background-image: -o-linear-gradient(bottom, #F58B00 17%, #F89100 59%, #FA9600 80%, #FD9C00 90%);
            background-image: -moz-linear-gradient(bottom, #F58B00 17%, #F89100 59%, #FA9600 80%, #FD9C00 90%);
            background-image: -webkit-linear-gradient(bottom, #F58B00 17%, #F89100 59%, #FA9600 80%, #FD9C00 90%);
            background-image: -ms-linear-gradient(bottom, #F58B00 17%, #F89100 59%, #FA9600 80%, #FD9C00 90%);
            background-image: -webkit-gradient( linear, left bottom, left top, color-stop(0.17, #F58B00), color-stop(0.59, #F89100), color-stop(0.8, #FA9600), color-stop(0.9, #FD9C00) );
            filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#FD9C00', endColorstr='#F58B00', GradientType=0);
        }
    </style>
    <form id="form1" runat="server">
    <asp:Repeater ID="rpData" runat="server">
    <ItemTemplate>
        <div class="box_outer">
            <div class="cat_article" itemscope itemtype="http://schema.org/Article">
                <h2 class="cat_article_title">
                    <a><span itemprop="name">
                        <%# Eval("Products_Name")%>
                    </span></a>
                </h2>
            </div>
        </div>
    </ItemTemplate>
</asp:Repeater>

<div class="clear">
</div>

<div class="paging">
    <ul class="pagination" runat="server" id="Paging">
    </ul>
</div>
    </form>
</body>
</html>

