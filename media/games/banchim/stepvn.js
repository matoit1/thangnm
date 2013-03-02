/*
	Coded by Leorius
	Website: http://step.vn
	Email: info@step.vn
*/
function StepVNRandom(from,to)
{
	return Math.floor(Math.random()*(to-from+1)+from);
}

function StepVNgenBird()
{
	var name = "bird"+StepVNRandom(1,3)+".png";
	var left = StepVNRandom(0,1);
	if(!left){left=$(".divStepVNGameFrame").width()-40;}else{left=0;}
	var top = StepVNRandom(0,$(".divStepVNGameFrame").height()-100);
	$(".divStepVNGameFrame").append("<div class='bird'/>");
	$(".divStepVNGameFrame .bird").css({"top":top,"left":left,"background":"url("+name+")"});
	if(left){$(".divStepVNGameFrame .bird").css("background-position","0px -40px");}
	if(left){left=0;}else{left=$(".divStepVNGameFrame").width()-40;}
	top = StepVNRandom(top,$(".divStepVNGameFrame").height()-40);
	StepVNgenCloud();
	$(".divStepVNGameFrame .bird").delay(200).animate({"left":left,"top":top},2000,function(){
		$(this).remove();
		var t = setTimeout("StepVNgenBird()",2000);
	});
}
function StepVNgenCloud()
{
	$(".divStepVNGameFrame").append("<a class='cloud'/>");
	xtop = $(".divStepVNGameFrame .bird").css("top") + "";
	xtop = eval(xtop.replace("px",""))+15+"px";
	$(".divStepVNGameFrame .cloud").last()
	.css({"background":"url("+"cloud"+StepVNRandom(1,3)+".png) no-repeat center center","top":xtop,"left":$(".divStepVNGameFrame .bird").css("left")})
	.animate({"opacity":0},1000,function(){$(this).remove();});
	if($(".divStepVNGameFrame .bird").length>0){
		var t = setTimeout("StepVNgenCloud()",30);
	}
}
function StepVNplaySound()
{
	$("#gameSound").trigger("play");
}
function StepVNsetVolume(val)
{
	document.getElementById("gameSound").volume=val;
}
$(document).ready(function(){
	$(".divGame").append('<div class="divStepVNGameFrame"></div>');
	$(".divStepVNGameFrame").height($(".divGame").height());
	var cursorX,cursorY,waiting=false;
	$(document).mousemove(function(e){
		cursorX=e.pageX;
		cursorY=(e.pageY-$(".divHeaderBar").height()-20);
	}); 
	StepVNgenBird();
	$(".divStepVNGameFrame").append("<span class='result'>Điểm của bạn: <span class='total'>0</span></span>");
	$(".result").css({"bottom":"20px","right":"50px"});
	$(".divStepVNGameFrame").append("<div class='cursor'/>");
	$(".divStepVNGameFrame").append("<audio id='gameSound' controls='controls'><source src='gun.ogg' type='audio/ogg'></audio>");
	$("#gameSound").hide();StepVNsetVolume(0);StepVNplaySound();
	$(".cursor").html("<style>.divStepVNGameFrame {cursor: url('aim.png'), auto;}}</style>");
	$(".divStepVNGameFrame,.divStepVNGameFrame .bird").click(function(){
		if(waiting){return false;}
		shootX=cursorX;
		shootY=cursorY;
		birdX = $(".divStepVNGameFrame .bird").css("left") + "";birdX = eval(birdX.replace("px",""));
		if(birdX ==undefined){return false;}
		birdY = $(".divStepVNGameFrame .bird").css("top") + "";birdY = eval(birdY.replace("px",""));
		waiting=true;
		StepVNsetVolume(0.5);
		StepVNplaySound();
		$(".divStepVNGameFrame").append("<div class='hole'/>");
		if(birdX >= (shootX-100) && birdX <= (shootX+100) && birdY >= (shootY-100) && birdY <= (shootY+100))
		{
			$(".divStepVNGameFrame").append("<span class='point'>50</span>");
			$(".result .total").html(eval($(".result .total").html()+"")+50);
			$(".divStepVNGameFrame .point").css({"top":birdY,"left":birdX}).animate({"top":"-=100px","opacity":0},1000);
			$(".divStepVNGameFrame .bird").stop().animate({rotate: '30deg'},1000,function(){
				$(this).animate({"top":$(".divStepVNGameFrame").height()+"px"},200,function(){
					$(this).remove();
					var t = setTimeout("StepVNgenBird()",500);
				});
			});
		}
		$(".divStepVNGameFrame .hole").last().rotate(StepVNRandom(0,180)+"deg").delay(200).css({"display":"inline","top":(shootY-100)+"px","left":(shootX-100)}).delay(1000).animate({"opacity":0},1000,function(){waiting=false;$(this).remove();});
	});
});