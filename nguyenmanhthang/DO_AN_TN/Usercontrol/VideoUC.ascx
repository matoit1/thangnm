<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VideoUC.ascx.cs" Inherits="DO_AN_TN.UserControl.VideoUC" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%-- Begin Thư viện CSS - JAVASCRIPT Video mp4/ogg/webm--%>
    <link href="http://vjs.zencdn.net/4.5/video-js.css" rel="stylesheet" />
    <script src="http://vjs.zencdn.net/4.5/video.js" type="text/javascript"></script>
    <%-- End Thư viện CSS - JAVASCRIPT Video mp4/ogg/webm--%>

<asp:MultiView ID="mtvVideo" runat="server" ActiveViewIndex ="0">
    <asp:View ID="vFLV_MP4" runat="server">
        <video id="video_flv_mp4" class="video-js vjs-default-skin" controls preload="auto" width="755" height="400" poster="../Images/Avatar/default.png"
        data-setup='{"controls" : true, "autoplay" : false, "preload" : "auto"}'>
        <source src='<%=sLinkVideo%>' type="video/x-flv">
        Trình duyệt của bạn không hỗ trợ xem video này!</video>
        <i style="font-size: 10px; text-align: right">FLV_MP4_3G2</i>
    </asp:View>
    <asp:View ID="vOGG_WEBM_F4V_MKV" runat="server">
        <video id="video_ogg_webm_f4v_mkv" class="video-js vjs-default-skin" controls preload="auto" width="755" height="400" poster="../Images/Avatar/default.png"
            data-setup='{"controls" : true, "autoplay" : false, "preload" : "auto"}'>
             <source src='<%=sLinkVideo%>' type="video/ogg">
              Trình duyệt của bạn không hỗ trợ xem video này!</video>
        <i style="font-size: 10px; text-align: right">OGG_WEBM_F4V_MKV</i>
    </asp:View>
    <asp:View ID="vAVI_3G2_MOV_MPG_WMV" runat="server">
        <object id='video_avi_3g2_mov_mpg_wmv' width="755" height="400" 
            classid='CLSID:22d6f312-b0f6-11d0-94ab-0080c74c7e95' 
            codebase='http://activex.microsoft.com/activex/controls/mplayer/en/nsmp2inf.cab#Version=5,1,52,701'
            standby='Loading Microsoft Windows Media Player components...' type='application/x-oleobject'>
            <param name='fileName' value='<%=sLinkVideo%>'>
            <param name='animationatStart' value='true'>
            <param name='transparentatStart' value='true'>
            <param name='autoStart' value="false">
            <param name='showControls' value="true">
            <param name='loop' value="true">
            <embed type='application/x-mplayer2'
                pluginspage='http://microsoft.com/windows/mediaplayer/en/download/'
                id='mediaPlayer1' name='mediaPlayer' displaysize='4' autosize='-1' 
                bgcolor='darkblue' showcontrols="true" showtracker='-1' 
                showdisplay='0' showstatusbar='-1' videoborder3d='-1' width="755" height="400"
                src='<%=sLinkVideo%>' autostart="false" designtimesp='5311' loop="true">
            </embed>
        </object>
        <i style="font-size: 10px; text-align: right">AVI_3G2_MOV_MPG_WMV</i>
    </asp:View>
    <asp:View ID="vNoSupport" runat="server">
        <center><h1>Trình duyệt của bạn không hỗ trợ xem video này!</h1></center>
    </asp:View>
</asp:MultiView>
    