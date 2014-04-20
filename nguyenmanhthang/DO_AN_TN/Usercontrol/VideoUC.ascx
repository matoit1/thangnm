<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VideoUC.ascx.cs" Inherits="DO_AN_TN.UserControl.VideoUC" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%-- Begin Thư viện CSS - JAVASCRIPT Video mp4/ogg/webm--%>
    <link href="http://vjs.zencdn.net/4.5/video-js.css" rel="stylesheet" />
    <script src="http://vjs.zencdn.net/4.5/video.js" type="text/javascript"></script>
    <%-- End Thư viện CSS - JAVASCRIPT Video mp4/ogg/webm--%>
    <video id="video1" class="video-js vjs-default-skin" controls preload="auto" width="755" height="400" poster="../Images/Avatar/default.png"
        data-setup='{"controls" : true, "autoplay" : false, "preload" : "auto"}'>
        <source src='<%=sLinkVideo%>' type="video/x-flv">
        Trình duyệt của bạn không hỗ trợ xem video này!
    </video>