
	function clickx()
	{
	    var popup = document.getElementById("popup");
//		var notif = document.getElementById("notif");
//		var close = document.getElementById("close");
		var taskx = document.getElementById("taskx");
		if (popup.style.display != 'none') {
			//chat-box show
		    popup.style.display = 'none';
//			notif.style.display='block';
//			close.style.display='none';
		    taskx.style.bottom = "0px";
			game.style.opacity = "1";
			taskx.style.opacity = "0.2";
		}
		else { 
			// chat-box hidden
		    popup.style.display = '';
//			notif.style.display='none'; 
//			close.style.display='block';
		    taskx.style.bottom = "0px";
			popup.style.bottom = "0px";
			game.style.opacity = "0.2";
			taskx.style.opacity = "1";
		}
	} 
//});