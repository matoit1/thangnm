// http://db.tt/NIrVfvEE
var gameCanvas = null;

var time_to_update = 25;//ms

var BGImage = new Array(3);
var current_BG_index = 0;

//MC variables
var planeImage = null;
var heart_image = null;
var heart_halft_image = null;
var heart_startX = 2;
var heartY = 5;
var heart_offsetW = 16;
var planeW = 0;
var planeH = 0;
var planeX = 0;
var planeY = 0
var planeHP = 10;
var is_immu = false;
var max_immu_time = (1000/time_to_update) * 2;//immu in 4s
var immu_time = max_immu_time;//immu in 4s
var is_alive = true;

var miniblast_image = null;

var CONTEXT = null;

//bullets variables
var enemy_bullet_image = null;
var spec_bullet_image = new Array(3);
var bullet_image = new Array(3);
var bulletX = [];
var bulletVX = [];
var bulletY = [];
var bulletVY = [];
var bulletNum = 0;
var max_bullet_lvl = 3;
var bullet_lvl = 0;
var bullet_type = 0;
var shooting_type_single = 0;
var shooting_type_3lines = 1;
var shooting_type_split = 2;
var bullet_DMG = [3,4,5];
var spec_bullet_index = [];

var change_lvl = false;

//item variables
var item_image = new Array(4);
var item_availX = [];
var item_availY = [];
var item_type = [];

//meteor variables
var meteor_image = new Array(3);
var meteor_image_index = [];
var meteorX = [];
var meteorY = [];
var meteorVY = [];
var meteor_degree = [];

var meteorW = [35,45,24];
var meteorH = [30,40,17];
var meteorOffX = [10,15,4];
var meteorOffY = [10,10,7];

//enemy variables
var enemy_planeImage = null;
var enemy_bossImage = null;
var enemyX = [];
var enemyY = [];
var enemyVY = [];
var enemyHP = [];
var enemyHP_per_LVL = [10,15,20,25];
var enemyType = [];
var normalType = 0;
var bossType = 99;

var enemy_bulletX = [];
var enemy_bulletY = [];
var enemy_bulletVX = [];

var enemyDMG = [2,4,6,8];
var enemyShootingDelay = [40,30,20,15];
var enemymaxHP = 20;
var enemy_lines = 6;
var enemy_per_line = 10;
var enemy_offset_W = 50;
var enemy_line_height = 60;
var enemy_move_boder_x = 50;
var enemy_move_boder_x2 = 50;
var enemy_fly_left = true;
var boss_HP = 3000;
var boss_shooting_VX = 3;

//explosion variables
var explosion_image = new Array(10);
var explosionX = [];
var explosionY = [];
var explosion_time_index = [];
var explosion_time = 10;
var explosion_num = 0;
var explosion_counter = 0;

var bulletW = 0;
var bulletH = 0
var enemyW = 0;
var enemyH = 0;

var FrameStickCount = 0;
var enemykilled = 0;
var retried_count = 0;

var need_init = true;
var first_downX = 0;
var first_downY = 0;

var last_planeX = 0;
var last_planeY = 0;

var max_lvl = 4;
var cur_lvl = -1;

var sfx_explosion =null;
var sfx_shoot =null;

var complete_lvlX = 100
var retry_text_posX1 = 200
var retry_text_posX2 = 200

var killed_textY = 35;
var retried_textY = 55;

function firstclick()
{
	if(need_init)
	{
		gameCanvas =  document.getElementById("gameCanvas");
		CONTEXT = gameCanvas.getContext("2d");

		enemy_move_boder_x2 = gameCanvas.width - enemy_move_boder_x;
		
		loadBG(setUpGame);
	}
	if(!is_alive)
	{
		is_alive = true;
		is_immu = false;
		planeHP = 10;
	}
	if(change_lvl)
	{
		change_lvl=false
		cur_lvl++;
		clear_enemy();
		clear_bullet();
		init_enemy();
	}
}

function loadBG(callback)
{
	var temp=0;
	var BGsources = ["img/BG.png",
						"img/BG2.png",
						"img/BG3.png"
					]	
	for(var i=0;i<BGImage.length;i++)
	{
		BGImage[i] = new Image();
		BGImage[i].onload = function()
		{
			if(++temp >= BGImage.length)
				callback();
		}
		BGImage[i].src = BGsources[i];
	}
}

function setUpGame()
{
	if(need_init)
	{
		item_image[0] = new Image();
		item_image[0].src ="img/icon_upgrade.png";
		
		item_image[1] = new Image();
		item_image[1].src ="img/heart_item.png";
		
		item_image[2] = new Image();
		item_image[2].src ="img/3_line_upgrade.png";
		
		item_image[3] = new Image();
		item_image[3].src ="img/angles_split_upgrade.png";
		
		planeImage = new Image();
		planeImage.onload = function()
		{			
			planeW = planeImage.width;
			planeH = planeImage.height;
		}
		planeImage.src ="img/plane.png";
		
		enemy_planeImage = new Image();
		enemy_planeImage.src ="img/enemy.png";
		
		heart_image = new Image();
		heart_image.src ="img/heart_full.png";
		
		heart_halft_image = new Image();
		heart_halft_image.src ="img/heart_haft.png";
		
		enemy_bossImage = new Image();
		enemy_bossImage.src ="img/boss.png";
		
		//bullet lvl 1
		bullet_image[0] = new Image();
		bullet_image[0].src ="img/bullet.png";
		//bullet lvl 2
		bullet_image[1] = new Image();
		bullet_image[1].src ="img/bullet2.png";
		//bullet lvl 3
		bullet_image[2] = new Image();
		bullet_image[2].src ="img/bullet3.png";
		
		//spec_bullet_image lvl 1
		spec_bullet_image[0] = new Image();
		spec_bullet_image[0].src ="img/spec_bullet1.png";
		//bullet lvl 2
		spec_bullet_image[1] = new Image();
		spec_bullet_image[1].src ="img/spec_bullet2.png";
		//bullet lvl 3
		spec_bullet_image[2] = new Image();
		spec_bullet_image[2].src ="img/spec_bullet3.png";
		
		//meteor 1
		meteor_image[0] = new Image();
		meteor_image[0].src ="img/meteor1.png";
		//meteor 2
		meteor_image[1] = new Image();
		meteor_image[1].src ="img/meteor2.png";
		//meteor 3
		meteor_image[2] = new Image();
		meteor_image[2].src ="img/meteor3.png";
		
		//enemy bullet
		enemy_bullet_image = new Image();
		enemy_bullet_image.src ="img/enemy_bullet.png";
		
		//image for explosion
		explosion_image[0] = new Image();
		explosion_image[0].src ="img/ex1.png";
		
		explosion_image[1] = new Image();
		explosion_image[1].src ="img/ex2.png";
		
		explosion_image[2] = new Image();
		explosion_image[2].src ="img/ex3.png";
		
		explosion_image[3] = new Image();
		explosion_image[3].src ="img/ex4.png";
		
		explosion_image[4] = new Image();
		explosion_image[4].src ="img/ex5.png";
		
		explosion_image[5] = new Image();
		explosion_image[5].src ="img/ex6.png";
		
		explosion_image[6] = new Image();
		explosion_image[6].src ="img/ex7.png";
		
		explosion_image[7] = new Image();
		explosion_image[7].src ="img/ex8.png";
		
		explosion_image[8] = new Image();
		explosion_image[8].src ="img/ex9.png";
		
		explosion_image[9] = new Image();
		explosion_image[9].src ="img/ex10.png";
		
		miniblast_image = new Image();
		miniblast_image.src ="img/hit.png";
		
		sfx_explosion = new Audio("sounds/sfx_explosion.mp3");
		sfx_explosion.volume = 0.9;
		
		sfx_shoot = new Audio("sounds/sfx_gun1.mp3");
		sfx_shoot.volume = 0.9;
		
		CONTEXT.drawImage(planeImage,gameCanvas.width/2,gameCanvas.height - planeH);
		
		cur_lvl++;
		init_enemy();
		FrameStickCount = 0;
		enemykilled = 0;
		retried_count = 0;
		
		gameCanvas.addEventListener("mousemove", handleMouseEvent);
		gameCanvas.addEventListener("mouseup", handleMouseEvent);
		gameCanvas.addEventListener("mousedown", handleMouseEvent);
		
		gameCanvas.addEventListener('touchmove', function(event) {
			event.preventDefault();
			var touch = event.touches[0];
			planeX = last_planeX + (touch.pageX - first_downX);
			planeY = last_planeY + (touch.pageY - first_downY);
			// alert("hieu X: " + (touch.pageX - first_downX) + "/ hieu Y: "+(first_downY - touch.pageY)+
				// "/ planeX: "+planeX + "/ planeY: "+planeY);
		}, false);
		
		gameCanvas.addEventListener('touchstart', function(event) {
			event.preventDefault();
			var touch = event.touches[0];
			first_downX = touch.pageX;
			first_downY = touch.pageY;
			last_planeX = planeX;
			last_planeY = planeY;
			// alert("first_downX : "+first_downX + "/first_downY : "+first_downY);
		}, false);
		// gameCanvas.addEventListener("touchmove", touchHandler);
		// gameCanvas.addEventListener("touchstart", touchHandler,false);
		// gameCanvas.addEventListener("touchend", touchHandler);
		// gameCanvas.addEventListener("touchcancel", touchHandler); 
		
		setInterval(handleTick,time_to_update);
		need_init = false;
	}
}

function handleMouseEvent(mouseEvent)//1plane theo cursor + 1 enemy plane co' dinh. + check collison
{
	planeX = mouseEvent.offsetX;
	planeY = mouseEvent.offsetY;
	
	// if (controlModel ==0)
    {
		var mousePos = getMousePos(gameCanvas, mouseEvent);
        //planeX = mouseEvent.offsetX;
        //planeX = mouseEvent.offsetX;
        planeX = mousePos.x;
        planeY = mousePos.y;
    }
	
	if(planeY + planeH > gameCanvas.height)
		planeY = gameCanvas.height - planeH;
		
	if(planeX + planeW > gameCanvas.width)
		planeX = gameCanvas.width - planeW;
}

function handleTick()
{
	var counter = 0;
	var bullet_counter = 0;

	FrameStickCount = FrameStickCount + 1;

	// if(bullet_lvl < max_bullet_lvl-1)
	{
		bulletW = bullet_image[bullet_lvl].width;
		bulletH = bullet_image[bullet_lvl].height;
	}
	// else
	// {
		// bulletW = spec_bullet_image[0].width;
		// bulletH = spec_bullet_image[0].height;
	// }
	
	// clear toan bo noi dung cua canvas
	CONTEXT.drawImage(BGImage[cur_lvl%BGImage.length],(gameCanvas.width - BGImage[cur_lvl%BGImage.length].width)/2,(gameCanvas.height - BGImage[cur_lvl%BGImage.length].height)/2);
	
	update_meteor();
	draw_meteor();
	draw_enemy();
	
	update_Explosion();
	update_bullet();
	draw_bullets();
	
	update_HUD();
	
	if(item_availY != -100)
	{
		update_item();
		draw_item();
	}
	
	if(!is_alive)
	{
		draw_retry_screen();
		return;
	}
	
	// Ve plane theo vi tri cua chuot (tru` di imagewidth,imageheight)
	if(!is_immu)
	{
		CONTEXT.drawImage(planeImage,planeX,planeY);
	}
	else
	{
		if(FrameStickCount%10 == 0)
			CONTEXT.drawImage(planeImage,planeX,planeY);
		immu_time--;
		if(immu_time <= 0)
		{
			is_immu = false;
		}
	}
	
	if(change_lvl)
	{
		draw_levle_notification();
		return;
	}
	
	//Bullets
	init_bullet();
	
	//meteor
	init_meteor();
	
	//Enemy
	update_enemy();
	
	// tinh va cham
	for(var i=0;i<meteorX.length;i++)
	{
		if (
			(((planeX < meteorX[i] + meteorOffX[meteor_image_index[i]]) && (meteorX[i] + meteorOffX[meteor_image_index[i]] < planeX + planeW))
				|| ((planeX < meteorX[i] + meteorOffX[meteor_image_index[i]] + meteorW[[meteor_image_index[i]]]) && (meteorX[i] + meteorOffX[meteor_image_index[i]] + meteorW[[meteor_image_index[i]]] < planeX + planeW))
			)
            && 
			(((planeY < meteorY[i] + meteorOffY[meteor_image_index[i]]) && (meteorY[i] + meteorOffY[meteor_image_index[i]] < planeY+ planeH))
				|| ((planeY < meteorY[i] + meteorOffY[meteor_image_index[i]] + meteorH[[meteor_image_index[i]]]) && (meteorY[i] + meteorOffY[meteor_image_index[i]] + meteorH[[meteor_image_index[i]]] < planeY+ planeH))
			)
        )
		{
			explosionX.push(planeX);
			explosionY.push(planeY);
			explosion_time_index.push(0);

			is_alive = false;
			
			planeHP = 0;
			
			retried_count++;
		}
	}
	
	counter = 0;
	var enemyNum = enemyX.length;
    while (counter < enemyX.length)
    {
        if (
			(((planeX < enemyX[counter]) && (enemyX[counter] < planeX + planeW))
				|| ((planeX < enemyX[counter] + enemyW) && (enemyX[counter] + enemyW < planeX + planeW))
			)
            && 
			(((planeY < enemyY[counter]) && (enemyY[counter] < planeY+ planeH))
				|| ((planeY < enemyY[counter] + enemyH) && (enemyY[counter] + enemyH < planeY+ planeH))
			)
        )
        {
			if(!is_immu)
			{
				is_immu = true;
				immu_time = max_immu_time;
				planeHP -= enemyDMG[cur_lvl];
				enemyHP[counter] -= 5;
				if(enemyHP[counter] <= 0)
				{
					explosionX.push(enemyX[counter]);
					explosionY.push(enemyY[counter]);
					explosion_time_index.push(0);
					
					enemyY.splice(counter,1);
					enemyX.splice(counter,1);
					enemyVY.splice(counter,1);
					enemyHP.splice(counter,1);
					enemyType.splice(counter,1);
					
					enemyNum--;
					
					enemykilled++;
					
					if(enemyNum <= 0)
					{
						init_item(Math.round(0),gameCanvas.width/2,-10);
						change_lvl = true;;
					}
				}
				if(planeHP <= 0)
				{
					explosionX.push(planeX);
					explosionY.push(planeY);
					explosion_time_index.push(0);

					is_alive = false;
					
					retried_count++;
				}
			}
        }
         
        counter = counter + 1;
    }
}

//function for enemy planes
function clear_enemy()
{
	enemyX=[];
	enemyY=[];
	enemyVY=[];
	enemyHP=[];
	enemyType=[];
}

function init_enemy()
{
	var itemp = 0;
	var enemy_start_x = (gameCanvas.width - (enemy_offset_W*enemy_per_line))/2;
	var enemy_start_y = -50;
	var county = 0;

	current_BG_index = Math.round(Math.random()*(BGImage.length - 1));
	
	if(cur_lvl == max_lvl - 1)
	{
		enemyX.push(enemy_start_x + (itemp%enemy_per_line)*(enemy_offset_W));
		enemyY.push(20);
		enemyVY.push(0);
		enemyHP.push(boss_HP);
		enemyType.push(bossType);
		
		// while(itemp < enemy_per_line)
		// {
			// if(itemp%10 == 0)
				// county++;
			// enemyX.push(enemy_start_x + (itemp%enemy_per_line)*(enemy_offset_W));
			// enemyY.push(250);
			// enemyVY.push(0);
			// enemyHP.push(enemyHP_per_LVL[cur_lvl]);
			// enemyType.push(normalType);
			// itemp++;
		// }
	}
	else if(cur_lvl > max_lvl - 1)
	{
		alert("DA NE'M GA.CH TOAN BO ASSMIN!");
		alert("THY'M DA GA.CH "+enemykilled +" ASSMIN, VOI THOI GIAN "+(FrameStickCount/40)+ " GIAY, VA BI THO^NG "+retried_count+" LAN!");
		enemykilled = 0;
		FrameStickCount = 0;
		return;
	}
	else
	{
		while(itemp < enemy_lines*enemy_per_line)
		{
			if(itemp%10 == 0)
				county++;
			enemyX.push(enemy_start_x + (itemp%enemy_per_line)*(enemy_offset_W));
			enemyY.push(enemy_start_y + (county)*enemy_line_height);
			enemyVY.push(0);
			enemyHP.push(enemyHP_per_LVL[cur_lvl]);
			enemyType.push(normalType);
			itemp++;
		}
	}
}

function draw_enemy()
{
	counter = 0;
	while(counter < enemyX.length)
	{
		//ve may bay dich
		if(enemyType[counter] == bossType)
		{
			CONTEXT.drawImage(enemy_bossImage,enemyX[counter],enemyY[counter]);
		}
		else
		{
			CONTEXT.drawImage(enemy_planeImage,enemyX[counter],enemyY[counter]);
		}
		counter = counter + 1;
	}
}

function update_enemy()
{
	//tinh toan toa do may bay dich
	var enemys_left = enemyX[0];
	var enemys_right = enemyX[enemyX.length-1] + enemyW;

	for(var i = 1;i<enemyX.length ;i++)
	{
		if(enemyX[i] < enemys_left)
			enemys_left = enemyX[i];
		
		if(enemyX[i] + enemyW > enemys_right)
			enemys_right = enemyX[i] + enemyW;
			
		enemyY[i] += enemyVY[i];
	}
	
	
	
	counter = 0;
	while(counter < enemyX.length)
	{
		if(enemy_fly_left)
			enemyX[counter] -= 2;
		else
			enemyX[counter] += 2;	
		
		if(FrameStickCount%enemyShootingDelay[cur_lvl] == 0)
		{
			if(enemyType[counter] == bossType)
			{
				{
					enemy_bulletX.push(enemyX[counter] + 65);
					enemy_bulletY.push(enemyY[counter] + 180);
					enemy_bulletVX.push(boss_shooting_VX);
					
					enemy_bulletX.push(enemyX[counter] + 335);
					enemy_bulletY.push(enemyY[counter] + 180);
					enemy_bulletVX.push(-boss_shooting_VX);
					
					enemy_bulletX.push(enemyX[counter] + 100);
					enemy_bulletY.push(enemyY[counter] + 106);
					enemy_bulletVX.push(boss_shooting_VX);
					
					enemy_bulletX.push(enemyX[counter] + 300);
					enemy_bulletY.push(enemyY[counter] + 106);
					enemy_bulletVX.push(-boss_shooting_VX);
					sfx_shoot.play();
				}
			}
			if(enemyType[counter] == normalType)
			{
				var shooted_enemy = -1;
				if(FrameStickCount % enemyShootingDelay[cur_lvl] == 0)
					shooted_enemy = Math.round(Math.random()*enemyX.length);

				if(counter == shooted_enemy)
				{
					enemy_bulletX.push(enemyX[counter]);
					enemy_bulletY.push(enemyY[counter]);
					sfx_shoot.play();
				}
			}
		}
		
		counter = counter + 1;
	}
	if(enemys_left < enemy_move_boder_x)
	{
		enemy_fly_left = false;
	}
	else if(enemys_right > enemy_move_boder_x2)
	{
		enemy_fly_left = true;
	}
}

//function for explosion
function update_Explosion()
{
	explosion_counter = 0;
	explosion_num = explosionX.length;
	if(explosion_num >0)
	{
		while(explosion_counter < explosionX.length)
		{
			if(explosion_time_index[explosion_counter] < explosion_time)
			{
				CONTEXT.drawImage(explosion_image[explosion_time_index[explosion_counter]],explosionX[explosion_counter],explosionY[explosion_counter]);
				explosion_time_index[explosion_counter]++;
			}
			else
			{
				explosion_time_index.splice(explosion_counter,1);
				explosionX.splice(explosion_counter,1);
				explosionY.splice(explosion_counter,1);
				explosion_num--;
				explosion_counter--;
			}
			explosion_counter++;
		}
	}
}

function clear_Explosion()
{
	explosion_time_index = [];
	explosionX = [];
	explosionY = [];
}


//function for bullets
function init_bullet()
{
	if(cur_lvl < max_lvl)
	{
		// if(
			// (bullet_lvl < (max_bullet_lvl -1) && FrameStickCount%10 == 0)
			// || (bullet_lvl == (max_bullet_lvl -1) && FrameStickCount%40 == 0)
		// )
		if(FrameStickCount%10 == 0)
		{
			//center
			bulletX.push(planeX + (planeW - bulletW)/2 );
			bulletVX.push(0);
			bulletY.push(planeY - bulletH);
			bulletVY.push(15);
			
			//add bullets
			switch (bullet_type)
			{
				case shooting_type_3lines:
					// left
					bulletX.push(planeX + (planeW - bulletW)/2 - 15);
					bulletVX.push(0);
					bulletY.push(planeY - bulletH);
					bulletVY.push(15);
					// right
					bulletX.push(planeX + (planeW - bulletW)/2 + 15);
					bulletVX.push(0);
					bulletY.push(planeY - bulletH);
					bulletVY.push(15);
					break;
				case shooting_type_split:
					// left
					bulletX.push(planeX + (planeW - bulletW)/2);
					bulletVX.push(-2);
					bulletY.push(planeY - bulletH);
					bulletVY.push(15);
					// right
					bulletX.push(planeX + (planeW - bulletW)/2);
					bulletVX.push(2);
					bulletY.push(planeY - bulletH);
					bulletVY.push(15);
					break;
			}
			
			CONTEXT.drawImage(miniblast_image,bulletX[bullet_counter] + (bulletW/2 - miniblast_image.width/2),(planeY - miniblast_image.height/2));
			
			sfx_shoot.play();
		}
	}
}

function update_bullet()
{
	bulletNum = bulletX.length;
	for (bullet_counter = 0;bullet_counter < bulletNum;bullet_counter++)
	{
		if(bulletY[bullet_counter] > 0)
		{
			var enemyNum = enemyX.length;
			for (counter = 0; counter < enemyX.length;counter++)
			{
				if(enemyType[counter] == normalType)
				{
					enemyW = enemy_planeImage.width;
					enemyH = enemy_planeImage.height;
				}
				else if(enemyType[counter] == bossType)
				{
					enemyW = enemy_bossImage.width;
					enemyH = 100;
				}
				if(
					(((bulletX[bullet_counter] > enemyX[counter]) && (bulletX[bullet_counter] < enemyX[counter] + enemyW))
						|| (((bulletX[bullet_counter] + bulletW) > enemyX[counter]) && ((bulletX[bullet_counter] + bulletW) < enemyX[counter] + enemyW)))
					&&
					(((bulletY[bullet_counter] > enemyY[counter]) && (bulletY[bullet_counter] < enemyY[counter] + enemyH))
						|| ((bulletY[bullet_counter] + bulletH > enemyY[counter]) && (bulletY[bullet_counter] + bulletH < enemyY[counter] + enemyH)))
				)
				{
					enemyHP[counter] = enemyHP[counter] - bullet_DMG[bullet_lvl];
					
					CONTEXT.drawImage(miniblast_image,bulletX[bullet_counter] + (bulletW/2 - miniblast_image.width/2),bulletY[bullet_counter] - miniblast_image.height/2);
					// if(bullet_lvl == (max_bullet_lvl-1))
					// {
						// CONTEXT.drawImage(miniblast_image,bulletX[bullet_counter] - miniblast_image.width,bulletY[bullet_counter] - miniblast_image.height/2);
						// CONTEXT.drawImage(miniblast_image,bulletX[bullet_counter] + bulletW,bulletY[bullet_counter] - miniblast_image.height/2);
					// }
					
					if(enemyHP[counter] <= 0)
					{
						sfx_explosion.play();
						
						explosionX.push(enemyX[counter]);
						explosionY.push(enemyY[counter]);
						explosion_time_index.push(0);
						
						var change_to_recover = Math.random()*100;
						if(change_to_recover < 5)//5% tao ra item
						{
							init_item(Math.round(Math.random()*(item_image.length-1)),enemyX[counter],enemyY[counter]);
						}
						else if(change_to_recover < 10)
						{
							if(Math.round(Math.random()) == 1)
								init_item(2,enemyX[counter],enemyY[counter]);
							else
								init_item(3,enemyX[counter],enemyY[counter]);
								
							
						}
						enemyY.splice(counter,1);
						enemyX.splice(counter,1);
						enemyVY.splice(counter,1);
						enemyHP.splice(counter,1);
						
						enemyNum--;
						
						enemykilled++;
						
						if(enemyNum <= 0)
						{
							init_item(Math.round(0),gameCanvas.width/2,-10);
							change_lvl = true;;
						}
					}
					
					//remove the bullet if it's not the last bullet lvl
					// if(bullet_lvl < max_bullet_lvl-1 )
					{
						bulletX.splice(bullet_counter,1);
						bulletVX.splice(bullet_counter,1);
						bulletY.splice(bullet_counter,1);
						bulletVY.splice(bullet_counter,1);
						
						bulletNum--;
						bullet_counter--;
					}
				}				
			}
			for(var i=0;i<meteorX.length;i++)
			{
				if (
					(
						(
							(bulletX[bullet_counter] > meteorX[i] + meteorOffX[meteor_image_index[i]]) 
							&& (bulletX[bullet_counter] < meteorX[i] + meteorOffX[meteor_image_index[i]] + meteorW[meteor_image_index[i]])
						)
						|| 
						(
							(bulletX[bullet_counter] + bulletW > meteorX[i] + meteorOffX[meteor_image_index[i]]) 
							&& (bulletX[bullet_counter] + bulletW < meteorX[i] + meteorOffX[meteor_image_index[i]] + meteorW[meteor_image_index[i]])
						)
					)
					&& 
					(
						((bulletY[bullet_counter] < meteorY[i] + meteorOffY[meteor_image_index[i]]) && (meteorY[i] + meteorOffY[meteor_image_index[i]] < bulletY[bullet_counter]+ bulletH))
						|| 
						((bulletY[bullet_counter] < meteorY[i] + meteorOffY[meteor_image_index[i]] + meteorH[meteor_image_index[i]]) && (meteorY[i] + meteorOffY[meteor_image_index[i]] + meteorH[meteor_image_index[i]] < bulletY[bullet_counter] + bulletH))
					)
				)
				{
					CONTEXT.drawImage(miniblast_image,bulletX[bullet_counter] + (bulletW/2 - miniblast_image.width/2),bulletY[bullet_counter] - miniblast_image.height/2);
					meteorVY[i] -= 1/2;
					
					bulletX.splice(bullet_counter,1);
					bulletVX.splice(bullet_counter,1);
					bulletY.splice(bullet_counter,1);
					bulletVY.splice(bullet_counter,1);
					
					bulletNum--;
					bullet_counter--;
				}
			}
		}
		else
		{
			bulletX.splice(bullet_counter,1);
			bulletVX.splice(bullet_counter,1);
			bulletY.splice(bullet_counter,1);
			bulletVY.splice(bullet_counter,1);
			
			// spec_bullet_index.splice(bullet_counter,1);
				
			bulletNum--;
			bullet_counter--;
		}
	}
	update_enemy_bullet();
}

function update_enemy_bullet()
{
	//update enemy's bullets
	if(enemy_bulletX.length > 0)
	{
		var enemy_bulletNum = enemy_bulletX.length;
		for(var i=0;i<enemy_bulletNum;i++)
		{
			if(enemy_bulletY[i] < gameCanvas.height)
			{
				if(
					(((enemy_bulletX[i] > planeX) && (enemy_bulletX[i] < planeX + planeW))
						|| (((enemy_bulletX[i] + bulletW) > planeX) && ((enemy_bulletX[i] + bulletW) < planeX + planeW)))
					&&
					(((enemy_bulletY[i] > planeY) && (enemy_bulletY[i] < planeY + planeH))
						|| ((enemy_bulletY[i] + bulletH > planeY) && (enemy_bulletY[i] + bulletH < planeY + planeH)))
					)
				{
					if(!is_immu)
					{
						is_immu = true;
						immu_time = max_immu_time;
						planeHP -= enemyDMG[cur_lvl];
						if(planeHP <= 0)
						{
							explosionX.push(planeX);
							explosionY.push(planeY);
							explosion_time_index.push(0);
							
							is_alive = false;
							
							retried_count++;
						}
						enemy_bulletX.splice(i,1);
						enemy_bulletY.splice(i,1);
						
						if(cur_lvl == max_lvl-1)
							enemy_bulletVX.splice(i,1);
						i--;
						enemy_bulletNum--;
					}
				}
				if(meteorX.length > 0)
				{
					for(var j=0;j<meteorX.length;j++)
					{
						if(
							(
								(
									(enemy_bulletX[i] > meteorX[j] + meteorOffX[meteor_image_index[j]]) 
									&& (enemy_bulletX[i] < meteorX[j] + meteorOffX[meteor_image_index[j]] + meteorW[meteor_image_index[j]])
								)
								|| 
								(
									(enemy_bulletX[i] + bulletW > meteorX[j] + meteorOffX[meteor_image_index[j]]) 
									&& (enemy_bulletX[i] + bulletW < meteorX[j] + meteorOffX[meteor_image_index[j]] + meteorW[meteor_image_index[j]])
								)
							)
							&& 
							(
								(
									(enemy_bulletY[i] > meteorY[j] + meteorOffY[meteor_image_index[j]]) 
									&& (enemy_bulletY[i] < meteorY[j] + meteorOffY[meteor_image_index[j]] + meteorH[meteor_image_index[j]])
								)
								|| 
								(
									(enemy_bulletY[i] + bulletH > meteorY[j] + meteorOffY[meteor_image_index[j]]) 
									&& (enemy_bulletY[i] + bulletH < meteorY[j] + meteorOffY[meteor_image_index[j]] + meteorH[meteor_image_index[j]])
								)
							)
						)
						{
							CONTEXT.drawImage(miniblast_image,enemy_bulletX[i] + (bulletW/2 - miniblast_image.width/2),enemy_bulletY[i] - miniblast_image.height/2);
							meteorVY[j] += 1/2;
							
							enemy_bulletX.splice(i,1);
							enemy_bulletY.splice(i,1);
							
							if(cur_lvl == max_lvl-1)
								enemy_bulletVX.splice(i,1);
							
							enemy_bulletNum--;
							i--;
						}
					}
				}
			}
			else
			{
				enemy_bulletX.splice(i,1);
				enemy_bulletY.splice(i,1);
				if(cur_lvl == max_lvl-1)
					enemy_bulletVX.splice(i,1);
				// i--;
				// enemy_bulletNum--;
			}
		}
	}
}

function draw_bullets()
{
	for (bullet_counter = 0;bullet_counter < bulletX.length;bullet_counter++)
	{
		// if(bullet_lvl < max_bullet_lvl-1)
		{
			bulletY[bullet_counter] -= bulletVY[bullet_counter];
			bulletX[bullet_counter] += bulletVX[bullet_counter];
			CONTEXT.drawImage(bullet_image[bullet_lvl],bulletX[bullet_counter],bulletY[bullet_counter]);
		}
		// else
		// {
			// bulletY[bullet_counter] = bulletY[bullet_counter] - 10;
			// CONTEXT.drawImage(spec_bullet_image[spec_bullet_index[bullet_counter]],bulletX[bullet_counter],bulletY[bullet_counter]);
			// spec_bullet_index[bullet_counter]++;
			// if(spec_bullet_index[bullet_counter] >= 3)
				// spec_bullet_index[bullet_counter] = 0;
		// }
	}
	
	//draw enemy's bullets
	if(enemy_bulletX.length > 0)
	{
		for(var i=0;i<enemy_bulletX.length;i++)
		{
			enemy_bulletY[i] += 25;
			if(cur_lvl == max_lvl-1)
			{
				enemy_bulletX[i] += enemy_bulletVX[i];
			}
			CONTEXT.drawImage(enemy_bullet_image,enemy_bulletX[i],enemy_bulletY[i]);
		}
	}
}

function clear_bullet()
{
	bulletX = [];
	bulletY = [];
	// spec_bullet_index = [];
	enemy_bulletX = [];
	enemy_bulletY = [];
	enemy_bulletVX = [];
}

//function for items
function init_item(item_init_type,cx,cy)
{
	item_availX.push(cx);
	item_availY.push(cy);
	item_type.push(item_init_type);
}

function update_item()
{
	var tempNum = item_availY.length;
	if(tempNum > 0)
	{
		for(var i=0;i<tempNum;i++)
		{
			item_availY[i] = item_availY[i] + 5;
			if(item_availY[i] > gameCanvas.height)
			{
				item_availX.splice(i,1);
				item_availY.splice(i,1);
				item_type.splice(i,1);
				i--;
				tempNum--;
			}
			else
			{
				if (
					(((planeX < item_availX[i]) && (item_availX[i] < planeX + planeW))
						|| ((planeX < item_availX[i] + item_image[item_type[i]].width) && (item_availX[i] + item_image[item_type[i]].width < planeX + planeW))
					)
					&& 
					(((planeY < item_availY[i]) && (item_availY[i] < planeY+ planeH))
						|| ((planeY < item_availY[i] + item_image[item_type[i]].height) && (item_availY[i] + item_image[item_type[i]].height < planeY+ planeH))
					)
				)
				{
					switch(item_type[i])
					{
						case 0://upgrade weapon
							bullet_lvl++;
							if(bullet_lvl == max_bullet_lvl)
								bullet_lvl = max_bullet_lvl-1;
							break;
						case 1://recover HP
							planeHP += 2;
						break;
						case 2://
							bullet_type = 1;
						break;
						case 3://
							bullet_type = 2;
						break;
					}
					item_availX.splice(i,1);
					item_availY.splice(i,1);
					item_type.splice(i,1);
					i--;
					tempNum--;
				}
			}
		}
	}
}

function draw_item()
{
	for(var i = 0;i<item_availX.length;i++)
	{
		CONTEXT.drawImage(item_image[item_type[i]],item_availX[i],item_availY[i]);	
	}
}

//function for meteor
function init_meteor()
{
	if(FrameStickCount%80 == 0)
	{
		var random_meteor_image = Math.round(Math.random()*meteor_image.length);
		meteorX.push(Math.random()*(gameCanvas.width - meteor_image[random_meteor_image].width));
		meteorY.push(-50);
		meteorVY.push(8);
		meteor_image_index.push(random_meteor_image);
		meteor_degree.push(Math.round(Math.random()*360));
	}
}

function update_meteor()
{
	if(meteorX.length > 0)
	{
		var meteorNum = meteorX.length;
		for(var i=0; i < meteorNum;i++)
		{
			meteorY[i] += meteorVY[i];
			if(meteorY[i] > gameCanvas.height
				|| meteorY[i] < -50
			)
			{
				meteorY.splice(i,1);
				meteorX.splice(i,1);
				meteor_degree.splice(i,1);
				meteor_image_index.splice(i,1);
				meteorVY.splice(i,1);
				i--;
				meteorNum--;
			}
		}
	}
}

function draw_meteor()
{
	for(var i=0; i<meteorX.length;i++)
	{
		var cw = meteor_image[meteor_image_index[i]].width, 
			ch = meteor_image[meteor_image_index[i]].height, 
			cx = meteorX[i], cy = meteorY[i];
		
		CONTEXT.translate(cx + cw/2,cy + ch/2);
		
		CONTEXT.rotate(meteor_degree[i] * Math.PI / 180);
		
		CONTEXT.drawImage(meteor_image[meteor_image_index[i]],-cw/2,-ch/2);
		
		CONTEXT.rotate(-meteor_degree[i] * Math.PI / 180);
		
		CONTEXT.translate(-(cx + cw/2) ,-(cy + ch/2));
		
		meteor_degree[i] += 1;
		if(meteor_degree[i] > 360)
			meteor_degree[i] = 0;
	}
}

function clear_meteor()
{
	meteor_image_index = [];
	meteorX = [];
	meteorY = [];
	meteor_degree = [];
	meteorVY = [];
}

//function for mouse
function getMousePos(canvas, evt)
{
    // get canvas position
    var obj = canvas;
    var top = 0;
    var left = 0;
    while (obj && obj.tagName != 'BODY') {
        top += obj.offsetTop;
        left += obj.offsetLeft;
        obj = obj.offsetParent;
    }
 
    // return relative mouse position
    var mouseX = evt.clientX - left + window.pageXOffset;
    var mouseY = evt.clientY - top + window.pageYOffset;
    return {
        x: mouseX,
        y: mouseY
    };
}

function draw_retry_screen()
{
	if(FrameStickCount%3 == 0)
		CONTEXT.fillStyle = "rgb(255, 0, 255)";
	else
		CONTEXT.fillStyle = "rgb(155,155,155)";
	CONTEXT.font = "36px Arial";
	CONTEXT.fillText("Thym da bi tho^ng man ro.", retry_text_posX1, gameCanvas.height/2 - 20);
	CONTEXT.fillText("An vao de va' ass!", retry_text_posX2, gameCanvas.height/2 + 20);
}

function update_HUD()
{
	var num_heart = Math.floor(planeHP/2);
	var num_heart_half = planeHP%2;
	//draw HP
	if(num_heart > 0)
	{
		for(var i=0;i < num_heart;i++)
		{
			CONTEXT.drawImage(heart_image,heart_startX + i*heart_offsetW,heartY);
		}
	}
	if(num_heart_half > 0)
	{
		CONTEXT.drawImage(heart_halft_image,heart_startX + num_heart*heart_offsetW,heartY);
	}
	
	//draw score
	CONTEXT.font = "16px Arial";
	CONTEXT.fillStyle = "rgb(255, 0, 0)";
	CONTEXT.fillText("Ga.ch dc: "+enemykilled, heart_startX, killed_textY);
	CONTEXT.fillText("Bi. tho^ng: "+retried_count, heart_startX, retried_textY);
}

function draw_levle_notification()
{
	if(FrameStickCount%3 == 0)
		CONTEXT.fillStyle = "rgb(255, 0, 255)";
	else
		CONTEXT.fillStyle = "rgb(155,155,155)";
	CONTEXT.font = "36px Arial";
	if(cur_lvl+1 == max_lvl)
		CONTEXT.fillText("Thy'm da pha' dao game", complete_lvlX, gameCanvas.height/2 - 20);
	else
		CONTEXT.fillText("Thy'm da qua duoc cap do "+(cur_lvl+1), complete_lvlX, gameCanvas.height/2 - 20);
	CONTEXT.fillText("An tiep tuc!", retry_text_posX2, gameCanvas.height/2 + 20);
}
function encode_utf8( s )
{
  return unescape( encodeURIComponent( s ) );
}

function decode_utf8( s )
{
  return decodeURIComponent( escape( s ) );
}