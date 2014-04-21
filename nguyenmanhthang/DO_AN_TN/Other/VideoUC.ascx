<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VideoUC.ascx.cs" Inherits="DO_AN_TN.UserControl.VideoUC" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%-- Begin Thư viện CSS - JAVASCRIPT Video mp4/ogg/webm--%>
    <link href="http://vjs.zencdn.net/4.5/video-js.css" rel="stylesheet" />
    <script src="http://vjs.zencdn.net/4.5/video.js" type="text/javascript"></script>
    <%-- End Thư viện CSS - JAVASCRIPT Video mp4/ogg/webm--%>
<cc1:tabcontainer ID="tabMain" runat="server" ActiveTabIndex="0">
    <cc1:TabPanel runat="server" HeaderText="Định dạng Video không hỗ trợ" ID="tabVideoNotSupport">
    <ContentTemplate>
        <center><h1>3g2/avi/f4l/flv/mkv/mov/mpg/wmv</h1></center><br /><br />
        <br /><hr />
        <video id="video1" class="video-js vjs-default-skin" controls preload="auto" width="640" height="480" poster="preview.jpg"
            data-setup='{"controls" : true, "autoplay" : false, "preload" : "auto"}'>
            <source src="../upload/admin/video/movie.flv" type="video/x-flv">
            Trình duyệt của bạn không hỗ trợ xem video này!
        </video>
        <h3>1. FLV</h3>
        <br /><hr />
        <object id='mediaPlayer3' width="320" height="285" 
      classid='CLSID:22d6f312-b0f6-11d0-94ab-0080c74c7e95' 
      codebase='http://activex.microsoft.com/activex/controls/mplayer/en/nsmp2inf.cab#Version=5,1,52,701'
      standby='Loading Microsoft Windows Media Player components...' type='application/x-oleobject'>
      <param name='fileName' value="../upload/admin/video/movie.wmv">
      <param name='animationatStart' value='true'>
      <param name='transparentatStart' value='true'>
      <param name='autoStart' value="false">
      <param name='showControls' value="true">
      <param name='loop' value="true">
      <embed type='application/x-mplayer2'
        pluginspage='http://microsoft.com/windows/mediaplayer/en/download/'
        id='mediaPlayer1' name='mediaPlayer' displaysize='4' autosize='-1' 
        bgcolor='darkblue' showcontrols="true" showtracker='-1' 
        showdisplay='0' showstatusbar='-1' videoborder3d='-1' width="320" height="285"
        src="../upload/admin/video/movie.wmv" autostart="true" designtimesp='5311' loop="true">
      </embed>
      </object>
      <br />
      <OBJECT ID="MediaPlayer" WIDTH="192" HEIGHT="190" CLASSID="CLSID:22D6F312-B0F6-11D0-94AB-0080C74C7E95" STANDBY="Loading Windows Media Player components..." TYPE="application/x-oleobject">
<PARAM NAME="FileName" VALUE="../upload/admin/video/movie.wmv">
<PARAM name="ShowControls" VALUE="true">
<param name="ShowStatusBar" value="false">
<PARAM name="ShowDisplay" VALUE="false">
<PARAM name="autostart" VALUE="false">
<EMBED TYPE="application/x-mplayer2" SRC="../upload/admin/video/movie.wmv" NAME="MediaPlayer" WIDTH="192" HEIGHT="190" ShowControls="1" ShowStatusBar="0" ShowDisplay="0" autostart="0"> </EMBED>
      <h3>2. WMV</h3>
        <br /><hr />
        
 <br /><hr />
    </div>
      
 </div>
    </ContentTemplate>
    </cc1:TabPanel>
    <cc1:TabPanel runat="server" HeaderText="Định dạng Video hỗ trợ" ID="tabVideoSupport">
    <ContentTemplate>
        <center><h1>mp4/ogg/webm</h1></center><br /><br />
        <video id="my_video_1" class="video-js vjs-default-skin" controls preload="auto" width="640" height="264" poster="preview.jpg"
            data-setup='{"controls" : true, "autoplay" : false, "preload" : "auto"}' >
            <!-- HTML5 source list: -->
            <source src="../upload/admin/video/movie1.mp4" type="video/mp4">
            <source src="../upload/admin/video/movie1.ogg" type="video/ogg">
            <source src="../upload/admin/video/movie1.webm" type="video/webm">
            <source src="../upload/admin/video/movie.flv" type="video/x-flv">
            <source src="../upload/admin/video/movie.mkv" type="video/x-matroska">
            Trình duyệt của bạn không hỗ trợ xem video này!
        </video><br /><hr />
        <!-- Fallback to Flash: -->
        <video autoplay="autoplay" controls="controls" preload="auto">
            <object width="720" height="400" type="application/x-shockwave-flash" data="../Flash/FlashVideoPlayer.swf">
                <param name="movie" value="../Flash/FlashVideoPlayer.swf" />
                <param name="flashvars" value="file=../upload/admin/video/movie.flv" />
                <!-- Fallback image: -->
                <img src="../upload/admin/video/preview.jpg" width="720" height="400" alt="Can't load video." title="No video playback capabilities" /></object>
        </video>
    </ContentTemplate>
    </cc1:TabPanel>
</cc1:tabcontainer>