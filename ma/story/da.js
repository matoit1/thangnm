/**
 * Agent 객체를 생성한다. Agent객체는 브라우저의 종류를 파악해주는 역할을 한다.
 * @class Agent
 * @constructor
 */
var Agent = function () {
	var a = navigator.userAgent;
	function is(s,t) {
		return ((s||"").indexOf(t)>-1);
	}
	this.isWin = is(a,"Windows");
	this.isMac = is(a,"Macintosh");
	this.isOP = typeof window.opera != "undefined" || is(a,"Opera");
	this.isIE = !this.isOP && is(a,"MSIE");
	this.isFF = is(a,"Firefox");
	this.isCR = is(a,"Chrome");
	this.isSF = !this.isCR && is(a,"Apple");
	if (this.isIE) {
		var v = parseFloat(a.match(/MSIE ([0-9\.]+)/)[1]);
		if (isNaN(v)) this.isIE0 = true;
		if (6 <= v && v < 7) {
			this.isIE6 = true;
			return;
		} else if (7 <= v && v < 8) {
			this.isIE7 = true;
			return;
		} else if (5.5 <= v && v < 6) {
			this.isIE55 = true;
			return;
		} else if (v < 5.5) {
			this.isIE5 = true;
			this.isIE = false;
			return;
		} else if (8 <= v && v < 9) {
			this.isIE8 = true;
			return;
		} else if (9 <= v && v < 10) {
			this.isIE9 = true;
			return;
		}
	}
};

Agent.prototype = {
	/**
	 * 브라우저의 지원 여부를 반환한다.
	 * 해당 함수는 IE9을 지원하지 않는다.
	 * IE9을 지원하기 위해서는 checkAgent를 사용해야한다.
	 * 
	 * @method support
	 * @param {Number} i 10, 20, 30, 40, 45, 50, 60, 80, 90 중 관련된 숫자
	 * @return {Boolean}
	 */
	support : function (i) {
		if(this.isIE9) {
			return false;
		}
		
		if (i===10) {
			return (this.isWin)&&(this.isIE && !this.isIE8) ? true : false ;	
		} else if (i===20) {
			return (this.isWin)&&(this.isIE) ? true : false ;		
		} else if (i===30) {
			return (this.isWin)&&(this.isIE || this.isCR) ? true : false ;		
		} else if (i===40) {
			return (this.isWin)&&(this.isIE || this.isCR || this.isSF) ? true : false ;
		} else if (i===45) {
			return (this.isWin)&&(this.isIE || this.isSF || this.isOP) ? true : false ;
		} else if (i===50) {
			return (this.isWin)&&(this.isIE || this.isCR || this.isSF || this.isOP) ? true : false ;			
		} else if (i===60) {
			return (this.isWin)&&(this.isIE || this.isCR || this.isSF || this.isFF) ? true : false ;
		} else if (i===80) {
			return (this.isWin)&&(this.isIE || this.isFF || this.isCR || this.isSF || this.isOP) ? true : false ;
		} else if (i===90) {
			return (this.isIE || this.isFF || this.isCR || this.isSF || this.isOP) ? true : false ;			
		}
		return false;
	},
	
	/**
	 * 브라우저의 지원 여부를 반환한다.
	 * 해당 함수는 IE9을 지원한다.
	 * 
	 * @method checkAgent
	 * @param {Number} i 10, 20, 30, 40, 45, 50, 60, 80, 90 중 관련된 숫자
		<br>10 : (isWin)&&(isIE && !isIE8)
		<br>20 : (isWin)&&(isIE)
		<br>30 : (isWin)&&(isIE || isCR)
		<br>40 : (isWin)&&(isIE || isCR || isSF)
		<br>45 : (isWin)&&(isIE || isSF || isOP)
		<br>50 : (isWin)&&(isIE || isCR || isSF || isOP)
		<br>60 : (isWin)&&(isIE || isCR || isSF || isFF)
		<br>80 : (isWin)&&(isIE || isFF || isCR || isSF || isOP)
		<br>90 : (isIE || isFF || isCR || isSF || isOP)
	 * @return {Boolean}
	 * @example
		var oUA = new Agent();
		if (oUA.checkAgent(30)){
		
		}
	 */
	checkAgent : function(i){
		if (i===10) {
			return (this.isWin)&&(this.isIE && !this.isIE8) ? true : false ;	
		} else if (i===20) {
			return (this.isWin)&&(this.isIE) ? true : false ;		
		} else if (i===30) {
			return (this.isWin)&&(this.isIE || this.isCR) ? true : false ;		
		} else if (i===40) {
			return (this.isWin)&&(this.isIE || this.isCR || this.isSF) ? true : false ;
		} else if (i===45) {
			return (this.isWin)&&(this.isIE || this.isSF || this.isOP) ? true : false ;
		} else if (i===50) {
			return (this.isWin)&&(this.isIE || this.isCR || this.isSF || this.isOP) ? true : false ;			
		} else if (i===60) {
			return (this.isWin)&&(this.isIE || this.isCR || this.isSF || this.isFF) ? true : false ;
		} else if (i===80) {
			return (this.isWin)&&(this.isIE || this.isFF || this.isCR || this.isSF || this.isOP) ? true : false ;
		} else if (i===90) {
			return (this.isIE || this.isFF || this.isCR || this.isSF || this.isOP) ? true : false ;			
		}
		return false;
	},
	
	/**
	 * 해당 PC에 플래시 플레이어가 설치되어 있는지 확인한다.
	 * 
	 * @method hasFP
	 * @return {Boolean}
	 * @example
		var oUA = new Agent();
		if (oUA.hasFP()){
		
		}
	 */
	hasFP : function() {
		if(navigator.plugins&&navigator.mimeTypes.length){
			var x=navigator.plugins["Shockwave Flash"];
			if(x&&x.description){
				return true;
			}
		}else{
			try{
				var axo=new ActiveXObject("ShockwaveFlash.ShockwaveFlash");
				if(axo!=null) {
					return true;
				}
			}catch(e){}
		}
		return false;
	},
	dump : function() {
		document.write(navigator.userAgent +"<hr>");
		document.write("Win : " + this.isWin +"<br>");
		document.write("Mac : " + this.isMac +"<br>");
		document.write("IE : " + this.isIE +"<br>");
		document.write("IE0 : " + this.isIE0 +"<br>");
		document.write("IE5 : " + this.isIE5 +"<br>");
		document.write("IE55 : " + this.isIE55 +"<br>");
		document.write("IE6 : " + this.isIE6 +"<br>");				
		document.write("IE7 : " + this.isIE7 +"<br>");						
		document.write("IE8 : " + this.isIE8 +"<br>");								
		document.write("FF : " + this.isFF +"<br>");
		document.write("CR : " + this.isCR +"<br>");		
		document.write("SF : " + this.isSF +"<br>");
		document.write("OP : " + this.isOP +"<br>");
	}
};

/**
 * 플래시 객체를 생성해주는 Class
 * @class Flash
 * @constructor
 * @param {String} sSwfUrl 플래시 파일(swf)의 URL
 * @param {Number} iWidth 플래시 파일의 가로 사이즈
 * @param {Number} iHeight 플래시 파일의 세로 사이즈
 * @param {String} sWmode 플래시 파일의 wmode(wmode의 종류는 window, transparent, opaque 3종류가 있는데 광고에서는 transparent, opaque를 사용한다.)
 * @example
	var oF1 = new Flash(sF1, 335, 150, "opaque");
	oF1.setAtt("id", "ff335150");
	oF1.setAtt("name", "ff335150");
	oF1.setVal("click", sC1);
	// 쿠키 셋팅
	oPeach = new DaPeach(oF1, "[##_adline_##]");
	oF1.setVal("nfreq", 0);
	// DOM에 플래시를 삽입한다.
	Da.CE($$da_brand, "DIV", {id: "ad_brddrag"}, "position:absolute; width:335px; height:150px; left:600px; top:260px");
	oPeach.display(Da.$$("ad_brddrag"));
 */
var Flash = function (sSwfUrl, iWidth, iHeight, sWmode) {	
	this.params = {};
	this.vals = {};
	this.atts = {};
	if (sSwfUrl) {
		this.setAtt("src", sSwfUrl);
		this.setParam("movie", sSwfUrl);
	}
	if (iWidth) {
		this.setAtt("width", iWidth); 
	}
	if (iHeight) {
		this.setAtt("height", iHeight);
	}
	if (sWmode) {
		this.setParam("wmode", sWmode);
	}
	
	var ssl = (sSwfUrl.toUpperCase().indexOf("HTTPS") > -1)? 's' : '';
	
	this.setAtt("classid", "clsid:D27CDB6E-AE6D-11cf-96B8-444553540000");
	this.setAtt("type", "application/x-shockwave-flash");
	this.setAtt("codebase", "http"+ssl+"://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,0,0");
	this.setParam("quality", "high");
	this.setParam("allowScriptAccess", "always");
	this.setParam("swliveconnect", "true");
};

Flash.prototype = {
	/**
	 * 플래시 객체(object, embed)의 속성을 설정한다.
	 * 
	 * @method setAtt
	 * @param {String} sName 추가될 속성의 이름
	 * @param {String} vValue 추가될 속성의 값
	 * @example
		var oF1 = new Flash(sF1, 335, 150, "opaque");
		oF1.setAtt("id", "ff335150");
	 */
	setAtt : function (sName, vValue) {
		this.atts[sName] = vValue;
	},
	/** @id Flash.getAtt */
	getAtt : function (sName) {
		return this.atts[sName];
	},
	/**
	 * 플래시 객체의 Flashvars를 설정한다.
	 * 
	 * @method setVal
	 * @param {String} sName 추가될 flashvars의 이름
	 * @param {String} vValue 추가될 flashvars의 값
	 * @return {Boolean}
	 * @example
		var oF1 = new Flash(sF1, 335, 150, "opaque");
		oF1.setVal("click", sC1);
	 */
	setVal : function (sName, vValue) {
		this.vals[sName] = vValue;
	},
	/** @id Flash.getVal */
	getVal : function (sName) {
		return this.vals[sName];
	},
	/**
	 * 플래시 객체의 Flashvars를 여러개를 셋팅할 때 배열로 처리해준다.
	 * 
	 * @method setValByArray
	 * @param {Array} aName 추가될 flashvars의 이름을 가지고 있는 배열
	 * @param {Array} aValue 추가될 flashvars의 값들을 가지고 있는 배열
	 * @example
		var aC = [
			Da.EF("http://[##_server_##]/adclick?unit=[##_adunit_##]&ac=[##_acid_##]&src=[##_srcid2_##]&br=[##_branch3_##]&:::cl:::"),
			Da.EF("http://[##_server_##]/adclick?unit=[##_adunit_##]&ac=[##_acid_##]&src=[##_srcid2_##]&br=[##_branch4_##]&:::cl:::"),
			Da.EF("http://[##_server_##]/adclick?unit=[##_adunit_##]&ac=[##_acid_##]&src=[##_srcid2_##]&br=[##_branch5_##]&:::cl:::"),
			Da.EF("http://[##_server_##]/adclick?unit=[##_adunit_##]&ac=[##_acid_##]&src=[##_srcid2_##]&br=[##_branch6_##]&:::cl:::"),
			Da.EF("http://[##_server_##]/adclick?unit=[##_adunit_##]&ac=[##_acid_##]&src=[##_srcid2_##]&br=[##_branch7_##]&:::cl:::")];
		var oF2 = new Flash(sF2, 880, 410, "transparent");
		oF2.setValByArray(["click1", "click2", "click3", "click4", "click5"], aC);
	 */
	setValByArray : function (aName, aValue) {
		if (aName !== null && aValue !== null && aName.length === aValue.length)  {
			for (var i = 0, n = aName.length ; i < n ; i++){
				this.setVal(aName[i], aValue[i]);
			}
		}
	},
	/** @id Flash.setParam */
	setParam : function (sName, vValue) {
		this.params[sName] = vValue;
	},	
	/** @id Flash.getParam */
	getParam : function (sName) {
		return this.params[sName];
	},
	/**
	 * 플래시 객체의 Flashvars를 여러개를 셋팅할 때 배열로 처리해준다.
	 * 
	 * @method getHTML
	 * @return {String} 플래시 객체(object, embed)의 HTML 문자열이 리턴된다.
	 * @example
		Da.CE(Da.$$("da_stake"), "DIV", {id:"da_drag"}, "position:absolute;left:0px;top:197px", oF2.getHTML());
	 */
	getHTML : function () {
		var a = [];
		var i;
		for (i in this.vals) {
			if (this.vals.hasOwnProperty(i)) {								
				a.push(i + "=" + this.vals[i]);								
			}
		}	
		var v = a.join("&");		
		if (v!==null && v.length > 0) {
			this.setParam("flashvars", v);
		}
		var s = "";
		var k;
		if (navigator.plugins && navigator.mimeTypes && navigator.mimeTypes.length) {
			s = "<embed ";
			for (k in this.atts) {
				if (this.atts.hasOwnProperty(k)) {
					s += k;
					s += "=\"";
					s += this.atts[k];
					s += "\" ";
				}
			}
			for (k in this.params) {
				if (this.params.hasOwnProperty(k)) {
					s += k;
					s += "=\"";
					s += this.params[k];
					s += "\" ";
				}
			}
			s += "/>";
		} else {
			s = "<object ";			
			for (k in this.atts) {
				if (this.atts.hasOwnProperty(k)) {
					s += k;
					s += "=\"";
					s += this.atts[k];
					s += "\" ";
				}
			}
			s += ">\n";
			for (k in this.params) {
				if (this.params.hasOwnProperty(k)) {
					s += "<param name=\"";
					s += k;
					s += "\" value=\"";
					s += this.params[k];
					s += "\" />";
				}
			}
			s += "</object>";
		}
		return s;
	}
};


/**
 * DOM을 컨트롤 하는 역할을 담당하는 Class
 * @class Da
 * @constructor
 */
var Da = {
	/**
	 * 현재 DOM에서 ID값에 해당하는 객체를 찾는다.
	 * 
	 * @static
	 * @method $
	 * @param {String} sIDValue 찾고자하는 객체의 ID값을 반환한다.
	 * @return {Object} sIDValue에 해당하는 DOM상의 객체가 반환된다.
	 * @example
		Da.$('mydiv');
	 */
	$ : function (sIDValue) {
		return document.getElementById(sIDValue);
	}, 
	/**
	 * 현재 DOM의 Parent DOM에서 ID값에 해당하는 객체를 찾는다.
	 * 
	 * @static
	 * @method $$
	 * @param {String} sIDValue 찾고자하는 객체의 ID값을 반환한다.
	 * @return {Object} sIDValue에 해당하는 Parent DOM상의 객체가 반환된다.
	 * @example
		Da.$$('mydiv');
	 */
	$$ : function (sIDValue) {
		return parent.document.getElementById(sIDValue);
	},
	/**
	 * 현재 DOM과 Parent DOM에서 ID값에 해당하는 객체를 찾는다.
	 * 
	 * @static
	 * @method $$$
	 * @param {String} sIDValue 찾고자하는 객체의 ID값을 반환한다.
	 * @return {Object} sIDValue에 해당하는 객체가 반환된다.
	 * @example
		Da.$$$('mydiv');
	 */
	$$$ : function (sIDValue) {
		return Da.$(sIDValue)!=null?Da.$(sIDValue):Da.$$(sIDValue);
	},
	/**
	 * 첫 번째 인자로 전달 받은 객체에 두 번째 인자로 전달받은 html을 innerHTML로 생성한다.
	 * 
	 * @static
	 * @method SH
	 * @param {Object} oElement innerHTML의 대상이되는 객체
	 * @param {String} sHTML innerHTML에 사용될 HTML 소스 문자열
	 * @example
		Da.SH(Da.$("addiv"), "<div id='mydiv'></div>");
	 */
	SH : function (oElement, sHTML) {
		oElement.innerHTML = sHTML;
	},
	/**
	 * 특정 객체에 style과 속성을 전달 받은 값으로 HTML코드가 innerHTML로 생성된다.
	 * 첫 번째 인자로 전달 받은 객체(oElement)에 두 번째 인자로 전달받은 테그(sTag)를 생성하고
	 * 두 번째 인자로 전달 받은 객체에 인자로 전달 받은 속성(oAttributes)과 style(sStyle)를 설정한다.
	 * 마지막 인자값으로 전달 받은 sHTML이 있는 경우 innerHTMl에서 사용되고 그렇지 않은 경우 전달 받은 인자값을 사용하여 innerHTML이 생성된다.
	 * 
	 * @static
	 * @method CE
	 * @param {Object} oElement innerHTML의 대상이되는 객체
	 * @param {String} sTag oElement에 추가될 tag
	 * @param {Object} oAttributes sTag에 추가될 속성
	 * @param {String} sStyle sTag에 적용될 css style
	 * @param {String} sHTML innerHTML에 사용될 HTML 소스 문자열, 생략 가능
	 * @example
		Da.CE($$da_brand, "DIV", {id: "ad_brddrag"}, "position:absolute; width:335px; height:150px; left:600px; top:260px");
	 */
	CE : function (oElement, sTag, oAttributes, sStyle, sHTML) {
		var o = parent.document.createElement(sTag);
		var k;
		for (k in oAttributes) {
			if (oAttributes.hasOwnProperty(k)) {
				o.setAttribute(k, oAttributes[k]);
			}
		}		
		if (sStyle!==null) {
			o.style.cssText = sStyle;
		}
		oElement.appendChild(o);
		if (sHTML !== null) {
			o.innerHTML = sHTML;
		}
	}, 
	/** @id Da.CS */
	CS : function (sText) { 
		var o = parent.document.createElement("script"); 
		o.type = "text/javascript"; 
		o.defer = true; 
		o.text = sText; 
		o.charset = "euc-kr";
		parent.document.getElementsByTagName('head')[0].appendChild(o); 
	},
	/** @id Da.EF */
	EF : function (sText) {
		if (typeof encodeURIComponent == "function" ) return encodeURIComponent(sText);
    	else return sText.replace(/\%/g, "%25").replace(/\&/g, "%26").replace(/\?/g, "%3F").replace(/\"/g, "%22").replace(/\+/g, "%2B");
	},
	/**
	 * DOM에서 전달 받은 객체를 포함해서 child nodes 까지 모두 제거한다.
	 * 
	 * @static
	 * @method RE
	 * @param {Object} oElement DOM에서 제거의 대상이되는 객체
	 * @example
		Da.RE(Da.$$("da_drag"));
	 */
	RE : function (oElement) {
		for(var oChild=oElement.firstChild; oChild ; oChild = oChild.nextSibling) {
			if(oChild.style)
				oChild.style.cssText = "width:0px;height:0px";
		}
		setTimeout(function() {
			oElement.innerHTML = "";
			oElement.parentNode.removeChild(oElement);
		}, 0);
	},
	/** @id Da.RM */
	RM : function (oElement) {
		for(var oChild=oElement.firstChild; oChild ; oChild = oChild.nextSibling) {
			if(oChild.style)
				oChild.style.cssText = "width:0px;height:0px";
		}
		oElement.innerHTML = "";
		oElement.parentNode.removeChild(oElement);
	},	
	/** @id Da.W */
    W : function (sText) {
        document.write(sText);
    },
	/** @id Da.AE */
	AE : function(oElement, sEvent, fn, bBubble) {
		var s = sEvent.toLowerCase();
		if (oElement != null) {
			if (typeof oElement.addEventListener != "undefined") {
				oElement.addEventListener(s, fn, false);
			} else if (typeof oElement.attachEvent != "undefined") {
				oElement.attachEvent("on" + s, fn);
			}
		}
	}, 
	/** @id Da.FE */
	FE : function(oElement, sEvent) {
		var s = sEvent.toLowerCase();
		if (typeof oElement.dispatchEvent != "undefined") {
			var e = document.createEvent("HTMLEvents");
			e.initEvent(s, true, true);
			oElement.dispatchEvent(e);			
		} else {
			oElement.fireEvent("on"+s);
		}
		return false;	
	}, 
	/** @id Da.SE */
	SE : function(oEvent) {
		if (typeof oEvent.stopPropagation != "undefined") oEvent.stopPropagation();
		else oEvent.cancelBubble = true;
	},
	/** @id Da.DE */
	DE: function(oElement, sEvent, fn){
		var s = sEvent.toLowerCase();
		if (typeof oElement.removeEventListener != "undefined") {
			oElement.removeEventListener(s, fn, false);
		} else {
			oElement.detachEvent("on"+s, fn);
		}
	},
	/**
	 * DOM에서 전달 받은 객체를 포함해서 child nodes 까지 모두 제거한다.
	 * 
	 * @static
	 * @method MF
	 * @param {String} sSwfURL 생성될 플래시(swf)파일의 URL
	 * @param {String} sID 플래시 객체의 ID
	 * @param {Number} iWidth 플래시 객체의 가로 사이즈
	 * @param {Number} iHeight 플래시 객체의 세로 사이즈
	 * @param {String} sWmode 플래시 객체의 wmode, wmode에는 window, transparent, opaque 3가지가 있는데 광고에서는 transparent, opaque만 사용한다.
	 * @param {Array} varsKey FlashVars에 사용될 변수들이 정의된 배열
	 * @param {Array} varsValue varsKey에 매칭되는 FlashVars에 대한 값이 정의된 배열
	 * @example
		Da.MF("[##_imageserver_##]/system/adcast/coupleexpand/090429.swf", "fuit_adcast", 466, 100, "transparent", ["runmode","expdmode"], [dj.runMode, dj.expdMode]);
	 */
	MF: function(sSwfURL, sID, iWidth, iHeight, sWmode, varsKey, varsValue){
		sWmode = (typeof sWmode == "undefined") ? "opaque" : sWmode;
		var s = "";
		if (typeof(varsKey)=="string" && typeof(varsValue)=="string") {
			s = varsKey + "=" + varsValue;
		}
		else 
			if (varsKey instanceof Array && varsValue instanceof Array) {
				if (varsKey.length > 0 && varsKey.length == varsValue.length) {
					for (var i = 0; i < varsKey.length; i++) {
						if (i > 0) 
							s += "&";
						s += varsKey[i] + "=" + varsValue[i];
					}
				}
			}
		var h = "";
		if (navigator.plugins && navigator.mimeTypes && navigator.mimeTypes.length) {
			h = "<embed src=\""+sSwfURL+"\" width=\""+iWidth+"\" height=\""+iHeight+"\" id=\""+sID+"\" tabindex=\"-1\" movie=\""+sSwfURL+"\" wmode=\""+sWmode+"\" quality=\"high\" allowScriptAccess=\"always\" swliveconnect=\"true\" ";
			h += "flashvars=\""+s+"\" type=\"application/x-shockwave-flash\" />";
		} else {
			h = "<object type=\"application/x-shockwave-flash\" classid=\"clsid:d27cdb6e-ae6d-11cf-96b8-444553540000\" codebase=\"http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,0,0\" width=\"" + iWidth + "\" height=\"" + iHeight + "\" id=\"" + sID + "\" tabindex=-1>";
			h += "<param name=\"movie\" value=\"" + sSwfURL + "\" />";
			h += "<param name=\"quality\" value=\"high\" />";
			h += "<param name=\"wmode\" value=\"" + sWmode + "\" />";
			h += "<param name=\"menu\" value=\"false\" />";
			h += "<param name=\"allowScriptAccess\" value=\"always\" />";
			h += "<param name=\"swliveconnect\" value=\"true\" />";
			h += "<param name=\"FlashVars\" value=\"" + s + "\" />";		
			h += "</object>";			
		}
		return h;
	}
};

/**
 * 님프의 로그와 관련된 업무를 처리한다.
 * @class Nimp
 * @constructor
 * @param {Array} aNimp 로그 URL이 정의된 배열
 */
var Nimp = function (aNimp) {
	/**
	 * 로그 URL이 정의된 배열
	 * @property aLists
	 * @type String
	 */
	this.aLists = aNimp;
	
	/**
	 * 로그 URL이 정의된 배열의 길이
	 * @property iSize
	 * @type Number
	 */
	this.iSize = aNimp.length;
};

Nimp.prototype = {
	/**
	 * 님프에 특정 리포트를 위한 로깅을 요청을 보낸다.
	 *
	 * @method log
	 * @param {Number} i aLists에 담긴 로깅을위한 URL의 index
	 * @example
		var oNimp = new Nimp([
		"http://[##_server_##]/adshow?unit=[##_adunit_##]&ac=[##_acid_##]&src=[##_srcid2_##]&t=i",
		"http://[##_server_##]/adclick?unit=[##_adunit_##]&ac=[##_acid_##]&src=[##_srcid1_##]&br=[##_branch2_##]&:::cl:::",
		"http://[##_server_##]/adshow?unit=[##_adunit_##]&ac=[##_acid_##]&src=[##_srcid3_##]&t=i"]);
		
		oNimp.log(1);
	 */
	log : function (i) {
		i--;		
		if (i >= 0 && i < this.iSize) {	
			this.init();		
			var dd = document.createElement("IMG");
			dd.setAttribute("width",0);
			dd.setAttribute("height",0);					
			dd.setAttribute("src", this.appendDummy(this.aLists[i]));
			this.logPlace.appendChild(dd);
		}
	},
	appendDummy : function(u) {
		if (u.indexOf("?") > 0) {
			u += "&dummy=";
			u += Math.random();
		} else {
			u += "?dummy=";
			u += Math.random();
		}
		return u;
	},
	init : function() {
		if (this.logPlace==null) {
			var dl = document.createElement("div");
			dl.setAttribute("id","daLog");
			dl.style.display = "none";
			document.body.appendChild(dl);
			this.logPlace = Da.$("daLog");
		}
	}	
};

/** @id Cookie */
var Cookie = {
	/** @id Cookie.set */
	set : function (sCookieName, sCookieValue, iExpireDays, sDomain) {
		if (!iExpireDays) {
			iExpireDays = 1;
		}
		if (!sDomain) {
			sDomain = document.URL.split("/")[2];
		}
		var d = new Date();
		d.setHours(24*iExpireDays);
		d.setMinutes(0);
		d.setSeconds(0);
		d.setMilliseconds(0);
		var c = escape(sCookieName);
		c += "=";
		c += escape(sCookieValue);
		c += "; path=/; expires=";
		c += d.toGMTString();
		c += "; domain=";
		c += sDomain;
		document.cookie = c;
	},
	/** @id Cookie.get */
	get : function (sCookieName) {
		var aC = document.cookie.match(new RegExp("(^|;)\\s*" + escape(sCookieName) + "=([^;\\s]+)"));
		return (aC ? unescape(aC[2]) : null);
	}, 
	/** @id Cookie.exist */
	exist : function (sCookieName) {
		var v = Cookie.get(sCookieName);
		if (!v) {
			return false;
		}
		return (v.toString() !== "");
	}
	
};

/** @id openWindow */
function openWindow(sURL, sWindowName, iWidth, iHeight, sScroll) {
	var x = (screen.width - iWidth) / 2;
	var y = (screen.height - iHeight) / 2;
	if (sScroll === null) {
		sScroll = "no";	
	}
	var s = "";
	s += "toolbar=no, channelmode=no, location=no, directories=no, resizable=no, menubar=no";
	s += ", scrollbars="; 
	s += ", left="; 
	s += x; 
	s += ", top="; 
	s += y; 
	s += ", width="; 
	s += iWidth; 
	s += ", height="; 
	s += iHeight;
	var win = window.open(sURL, sWindowName, s);
	return win;
}

/** @id openURL */
function openURL(url) {
	window.open(url, "_blank");
}

/** @id parseNumber */
function parseNumber(vValue, iDefault) {
	if (isNaN(parseInt(vValue))) {
		return iDefault;
	} else {
		return Number(vValue);
	}
}
/** @id setLoginLevel */
function setLoginLevel(iLevel) {
    if (parent.document.getElementById("loginframe") !== null) {
        parent.loginframe.checkAd(iLevel);
    }	
}

/** @id Timer */
var Timer = function () {
	var iBeginTime = 0;
	var iEndTime = 0;
	var bIsRunning = false;
};

Timer.prototype = {
	setStart : function() {
		this.iBeginTime = new Date().getTime();
		this.bIsRunning = true;
	},
	setStop : function() {
		this.iEndTime = new Date().getTime();
		this.bIsRunning = false;
	},
	getTime : function() {
		return this.iEndTime - this.iBeginTime;
	},
	isRunning : function() {
		return this.bIsRunning;
	},
	toString : function() {
		return this.iBeginTime + "~" + this.iEndTime;
	}
};