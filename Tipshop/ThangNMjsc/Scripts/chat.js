//$(document).ready(function() {
function Set_Cookie(name, value, expires, path, domain, secure) {
var today = new Date();
today.setTime(today.getTime());

if (expires) {
	expires = expires * 1000 * 60 * 60 * 24;
}
var expires_date = new Date(today.getTime() + (expires));

document.cookie = name + "=" + escape(value) +
((expires) ? ";expires=" + expires_date.toGMTString() : "") +
((path) ? ";path=" + path : "") +
((domain) ? ";domain=" + domain : "") +
((secure) ? ";secure" : "");
}

function Get_Cookie(name) {

    var start = document.cookie.indexOf(name + "=");
    var len = start + name.length + 1;
    if ((!start) &&
(name != document.cookie.substring(0, name.length))) {
        return null;
    }
    if (start == -1) return null;
    var end = document.cookie.indexOf(";", len);
    if (end == -1) end = document.cookie.length;
    return unescape(document.cookie.substring(len, end));
}

function Delete_Cookie(name, path, domain) {
    if (Get_Cookie(name)) document.cookie = name + "=" +
((path) ? ";path=" + path : "") +
((domain) ? ";domain=" + domain : "") +
";expires=Thu, 01-Jan-1970 00:00:01 GMT";
}

	var el = document.getElementById("chat-box");
	var taskx = document.getElementById("taskx");
	var notif = document.getElementById("notif");
	var close = document.getElementById("close");
	//if (getCookieValue("close") == "yes") 
	if (Get_Cookie('CHATBOX'))
	{ 
	el.style.display = 'none';
		notif.style.display='block';
		close.style.display='none';
		taskx.style.bottom="0px"; 
		
	}
	else 
	{
		
		el.style.display = 'block';
		notif.style.display='none';
		close.style.display='block';
		taskx.style.bottom="322px";
		el.style.bottom="0px";
	}
	function clickx()
	{
		var el = document.getElementById("chat-box");
		var notif = document.getElementById("notif");
		var close = document.getElementById("close");
		var taskx = document.getElementById("taskx");
		if ( el.style.display != 'none' ) {
			//chat-box show
			el.style.display = 'none';
			notif.style.display='block';
			close.style.display='none';
			//document.cookie="close=no";
			Set_Cookie('CHATBOX', 'CHATBOX chat', '1', '/', '', '');
			
			taskx.style.bottom="0px";			
		}
		else { 
			// chat-box hidden
			el.style.display = '';
			notif.style.display='none'; 
			close.style.display='block';
			//document.cookie="close=yes";
			
			Delete_Cookie('CHATBOX', '/','');
			taskx.style.bottom="322px";
			el.style.bottom="0px"; 
		}
	} 
//});