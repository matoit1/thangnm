<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DongHoUC.ascx.cs" Inherits="DO_AN_TN.UserControl.DongHoUC" %>

<style type="text/css">	
	.clock {background:#202020; width:200px; margin:0 auto; padding:5px; border:1px solid #333; color:#fff; }
	#Date {font-size:14px; text-align:center; text-shadow:0 0 5px #00c6ff; }
	.clock ul { width:200px; margin:0 auto; padding:0px; list-style:none; text-align:center; }
	.clock ul li { display:inline; font-size:45px; text-align:center; text-shadow:0 0 5px #00c6ff; font-weight: 900;}
</style>
<script type="text/javascript" src="../../Scripts/jquery-1.5.2.min.js"></script>
<script type="text/javascript">
	$(document).ready(function () {
	    // Create two variable with the names of the months and days in an array
	    var monthNames = ["Tháng Một", "Tháng Hai", "Tháng Ba", "Tháng Tư", "Tháng Năm", "Tháng Sáu", "Tháng Bảy", "Tháng Tám", "Tháng Chín", "Tháng Mười", "Tháng Mười Một", "Tháng Mười Hai"];
	    var dayNames = ["Chủ Nhật, ", "Thứ Hai, ", "Thứ Ba, ", "Thứ Tư, ", "Thứ Năm, ", "Thứ Sáu, ", "Thứ Bảy, "]
	    // Create a newDate() object
	    var newDate = new Date();
	    // Extract the current date from Date object
	    newDate.setDate(newDate.getDate());
	    // Output the day, date, month and year    
	    $('#Date').html(dayNames[newDate.getDay()] + " " + newDate.getDate() + ' ' + monthNames[newDate.getMonth()] + ' ' + newDate.getFullYear());
	    setInterval(function () {
	        // Create a newDate() object and extract the seconds of the current time on the visitor's
	        var seconds = new Date().getSeconds();
	        // Add a leading zero to seconds value
	        $("#sec").html((seconds < 10 ? "0" : "") + seconds);
	    }, 1000);

	    setInterval(function () {
	        // Create a newDate() object and extract the minutes of the current time on the visitor's
	        var minutes = new Date().getMinutes();
	        // Add a leading zero to the minutes value
	        $("#min").html((minutes < 10 ? "0" : "") + minutes);
	    }, 1000);

	    setInterval(function () {
	        // Create a newDate() object and extract the hours of the current time on the visitor's
	        var hours = new Date().getHours();
	        // Add a leading zero to the hours value
	        $("#hours").html((hours < 10 ? "0" : "") + hours);
	    }, 1000);
	}); 
</script>
<div class="alldatetime">
	<div class="clock">
		<div id="Date"></div>
		<ul>
			<li id="hours"> </li>
			<li id="point">:</li>
			<li id="min"> </li>
			<li id="point">:</li>
			<li id="sec"> </li>
		</ul>
	</div>
</div>