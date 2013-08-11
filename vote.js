// Async Rating-Widget initialization.
function RW_Async_Init(){
	RW.init({
		uid: "0DE4311001648E7CD55DFF7A47093172",
		huid: "123467",
		options: {
			size: "medium",
			lng: "vi",
			theme: "star_quartz"
		}
	});
	RW.render();
}

// Append Rating-Widget JavaScript library.
if (typeof(RW) == "undefined"){
	(function(){
		var rw = document.createElement("script"),
			d = new Date(), ck = "Y" + d.getFullYear() + "M" + d.getMonth() + "D" + d.getDate();
		rw.type = "text/javascript"; rw.async = true;
		rw.src = "http://js.rating-widget.com/external.min.js?ck=" + ck;
		var s = document.getElementsByTagName("script")[0];
		s.parentNode.insertBefore(rw, s);
	})();
}