function playfile(a,c,b,e,f,g,d){Left(a,22)=="http://www.youtube.com"&&EmbedYoutube(a,c,b,e);a=a.toLowerCase();(Right(a,3)=="swf"||Right(a,3)=="xml")&&EmbedFlash(a,c,b,d);Right(a,3)=="flv"&&PlayFlash(a,c,b,e,f,g,d);(Right(a,3)=="mp3"||Right(a,3)=="wma"||Right(a,3)=="wmv"||Right(a,3)=="avi"||Right(a,3)=="wav"||Right(a,3)=="dat")&&PlayVideo(a,c,b,e,d);(Right(a,3)=="jpg"||Right(a,4)=="jpeg"||Right(a,3)=="gif"||Right(a,3)=="png"||Right(a,3)=="bmp")&&PlayImage(a,c,b,d)}function EmbedYoutube(a,c,b,f){var d=0;if(f==true)d=1;a=a.replace("/watch?v=","/v/")+"&amp;hl=en&amp;fs=1&autoplay="+d;var e='<object width="'+c+'" height="'+b+'"><param name="movie" value="'+a+'"></param><param name="allowFullScreen" value="true"></param><param name="allowscriptaccess" value="always"></param><embed src="'+a+'" type="application/x-shockwave-flash" allowscriptaccess="always" allowfullscreen="true" width="'+c+'" height="'+b+'"></embed></object>';document.write(e)}function PlayFlash(i,h,f,e,g,c,a){auto=false;if(e==true)auto=true;var b="";if(c.length>0)b="&link="+c+"&linktarget=_blank";var d='<embed name="PlayFlash" id="PlayFlash" wmode="transparent" type="application/x-shockwave-flash" src="/scripts/player.swf" bgcolor="#FFFFFF" quality="high" allowscriptaccess="always" allowfullscreen="true" flashvars="file='+i+"&image="+g+b+"&autostart="+auto+'&volume=100&overstretch=fit&showeq=true&linkfromdisplay=true&duration=auto" width="'+h+'" height="'+f+'"></embed>';if(a!="")$Get(a).innerHTML=d;else document.write(d)}function PlayImage(d,c,b,a){str='<img src="'+d+'" width="'+c+'" height="'+b+'" />';if(a!="")$Get(a).innerHTML=str;else document.write(str)}function PlayVideo(d,c,b,e,a){auto=false;if(e==true)auto=true;str='<object id="MediaPlayer" classid="CLSID:6BF52A52-394A-11D3-B153-00C04F79FAA6"  codeBase="http://activex.microsoft.com/activex/controls/mplayer/en/nsmp2inf.cab#Version=6,4,5,715" width="'+c+'" height="'+b+'"> <param name="autoplay" value="'+auto+'"/> <param name="autostart" value="'+auto+'"/> <param name="showcontrols" value="true">  <param name="EnableContextMenu" value="true"/> <param name="showstatusbar" value="false"/> <param name="URL" value="'+d+'"/><param name="wmode" value="transparent"><embed name="MediaPlayer" type="application/x-mplayer2" src="'+d+'" autoplay="'+auto+'" autostart="'+auto+'" showcontrols="true" enablecontextmenu="true" showstatusbar="false" pluginspage="http://www.microsoft.com/windows/windowsmedia/download" wmode="transparent" width="'+c+'" height="'+b+'"></embed> </object>';if(a!="")$Get(a).innerHTML=str;else document.write(str)}function EmbedFlash(c,b,a,d){if(a.length==0)a="100%";if(b.length==0)b="100%";str='<object id="FlashContent" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000"  codeBase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0" quality="high" width="'+b+'" height="'+a+'"> <param name="flashvars" value="'+d+'"/> <param name="allowScriptAccess" value="always">  <param name="allowFullScreen" value="true"/> <param name="movie" value="'+c+'"/> <param name="src" value="'+c+'"/> <param name="quality" value="high"/> <param name="wmode" value="transparent"/> <param name="bgcolor" value="#000000"/> <embed name="FlashContent" src="'+c+'" quality="high" flashvars="'+d+'" allowFullScreen="true"  allowScriptAccess="always" wmode="transparent" pluginspage="http://www.macromedia.com/go/getflashplayer" type="application/x-shockwave-flash" width="'+b+'" height="'+a+'"></embed> </object>';document.write(str)}function ChangeImage(d,c,a,b){document.write('<object id="FlashContent" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0" width="'+c+'" height="'+a+'" style="margin: 0px 0px 0px 0px;"> <param name="movie" value="'+d+'"> <param name="quality" value="high"> <param name="wmode" value="transparent"> <param name="FlashVars" value="'+b+'"> <embed style="margin: 0px 0px 0px 0px;" src="'+d+'" FlashVars="'+b+'" quality="high" width="'+c+'" height="'+a+'" allowScriptAccess="sameDomain" type="application/x-shockwave-flash" wmode="transparent" pluginspage="http://www.macromedia.com/go/getflashplayer"> </object>')}function $Get(a){return document.getElementById?document.getElementById(a):document.all?document.all[a]:document.layers?document.layers[a]:null}function Trim(a){while(a.charCodeAt(0)<=32)a=a.substr(1);while(a.charCodeAt(a.length-1)<=32)a=a.substr(0,a.length-1);return a}function Left(a,b){return b<=0?"":b>String(a).length?a:String(a).substring(0,b)}function Right(a,b){if(b<=0)return"";else if(b>String(a).length)return a;else{var c=String(a).length;return String(a).substring(c,c-b)}}function chkSelect_OnMouseMove(a){var b=a.childNodes[1].childNodes[1];if(b.checked==false)a.style.backgroundColor="#ffffcc"}function chkSelect_OnMouseOut(b,d){var c=b.childNodes[1].childNodes[1];if(c.checked==false){var a;if(d%2==0)a="#ffffff";else a="#f5f5f5";b.style.backgroundColor=a}}function chkSelect_OnClick(b,d){var a,c=b.parentNode.parentNode;if(d%2==0)a="#ffffff";else a="#f5f5f5";if(b.checked==true)c.style.backgroundColor="#b0c4de";else c.style.backgroundColor=a}function chkSelectAll_OnClick(b){re=new RegExp("chkSelect");re2=new RegExp("chkSelectAll");for(i=0;i<document.forms[0].elements.length;i++){elm=document.forms[0].elements[i];if(elm.type=="checkbox")if(re.test(elm.id)&&re2.test(elm.id)==false){elm.checked=b.checked;var a=elm.parentNode.parentNode.id,c=a.substring(a.length-1,a.length);chkSelect_OnClick(elm,c)}}}function OnlyInputNumber(a){var c,b=String.fromCharCode(event.keyCode);if(event.keyCode<32)return;if(event.keyCode<=57&&event.keyCode>=48)if(!event.shiftKey)return;if(a.length>0&&b==a)return;event.returnValue=false}function readCookie(e){for(var c=e+"=",d=document.cookie.split(";"),b=0;b<d.length;b++){var a=d[b];while(a.charAt(0)==" ")a=a.substring(1,a.length);if(a.indexOf(c)==0)return a.substring(c.length,a.length)}return""}function toggleXPMenu(b,c){var e="/App_Themes/admin/images/closed.gif",f="/App_Themes/admin/images/open.gif",a=b,d="img"+b;if($Get(a).style.display==""&&c.toLowerCase()!="open"||c=="close"){$Get(a).style.display="none";$Get(d).src=f;return false}else{$Get(a).style.display="";$Get(d).src=e;return false}}