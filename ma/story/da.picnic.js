/**
 * @author ellen ellen@nhncorp.com
 * @version 1.0
 * @since 2008.4.10
 * @sdoc ./sdoc/da.picnic.sdoc
 */
/** @id getFreq */
function getFreq(sKey, iExpireDays, sDomain){
	var iFreq = 0;
	iFreq = parseNumber(Cookie.get(sKey), 0);
	Cookie.set(sKey, iFreq+1, iExpireDays, sDomain);
	return iFreq;
}

/** @id DaPeach */
var DaPeach = function (oFlash, iAdline, iExpireDays, sDomain){
	this.freq = getFreq("f" + iAdline, iExpireDays, sDomain);
	this.flash = oFlash;
	this.flash.setVal("nfreq", this.freq);
};
DaPeach.prototype = {
	/** @id DaPeach.display */
	display : function (oElement) {
		oElement.innerHTML = this.flash.getHTML();	
	}
};

/** @id DaApple */
var DaApple = function (oElement1, oFlash1, oElement2, oFlash2, bRun, iAdline) {	
	this.freq = 0;
	if (bRun) {
		var oPeach = new DaPeach(oFlash1, iAdline);
		this.freq = oPeach.freq;
		oPeach.display(oElement1);
	} else { 
		oElement2.innerHTML = oFlash2.getHTML();
	}
};

/** @id DaMango */
var DaMango = function (oElement1, oFlash1, oElement2, oFlash2, iAdline) {	
	this.freq = getFreq("f" + iAdline); 
	oFlash1.setVal("nfreq", this.iFreq);
	oFlash2.setVal("nfreq", this.iFreq);
	oFlash1.setVal("bannerid", this.iFreq);		
	oFlash2.setVal("bannerid", this.iFreq);
	oElement1.innerHTML = oFlash1.getHTML();
	oElement2.innerHTML = oFlash2.getHTML();
};

/** @id DaKiwi */
var DaKiwi = function (oElement1, oFlash1, oElement2, oFlash2) {	
	oElement1.innerHTML = oFlash1.getHTML();
	oElement2.innerHTML = oFlash2.getHTML();
};

/** @id DaCherry */
var DaCherry = function (oFlash1, oFlash2, oFlash3, iAdline) {
	this.freq = getFreq("f" + iAdline);
	this.flash1 = oFlash1;
	this.flash2 = oFlash2;		
	this.flash3 = oFlash3;
	
	this.flash1.setVal("nfreq", this.freq);
	this.flash3.setVal("nfreq", this.freq);
	this.flash1.setVal("bannerid", this.freq);		
	this.flash3.setVal("bannerid", this.freq);		
};
DaCherry.prototype = {
	/** @id DaCherry.display */
	display : function (oElement) {
		oElement.innerHTML = this.flash1.getHTML();
	},	
	/** @id DaCherry.displaySuperExpnd */
	displaySuperExpnd : function (oElement) {
		oElement.innerHTML = this.flash2.getHTML();
	},
	/** @id DaCherry.displayFirstExpnd */
	displayFirstExpnd : function (oElement) {
		oElement.innerHTML = this.flash3.getHTML();
	},
	/** @id DaCherry.writeFreq */
	writeFreq : function (oElement) {
		var oFd = parent.document.createElement("div");
		oFd.id = "topfreq";
		oFd.innerHTML = this.freq;
		oFd.style.display = "none";
		oElement.appendChild(oFd);		
	}
};

/** @id DaMelon */
var DaMelon = function (oFlash1, oFlash2) {
	this.flash1 = oFlash1;
	this.flash2 = oFlash2;
	this.freq = 9999;
	var oFreq = parent.document.getElementById("topfreq");
	if (oFreq !== null) {
		this.freq = parseNumber(oFreq.innerHTML, 0);
	}
	this.flash1.setVal("nfreq", this.freq);
	this.flash2.setVal("nfreq", this.freq);
	this.flash1.setVal("bannerid", this.freq);		
	this.flash2.setVal("bannerid", this.freq);	
};
DaMelon.prototype = {
	/** @id DaMelon.display1 */
	display1 : function (oElement) {
		oElement.innerHTML = this.flash1.getHTML();
	},
	/** @id DaMelon.display2 */
	display2 : function (oElement) {
		oElement.innerHTML = this.flash2.getHTML();
	},
	/** @id DaMelon.displayReset */
	displayReset : function (oElement1, oElement2) {
		this.freq++;
		this.flash1.setVal("nfreq", this.freq);
		this.flash2.setVal("nfreq", this.freq);
		oElement1.innerHTML = this.flash1.getHTML();	
		oElement2.innerHTML = this.flash2.getHTML();	
	}
};

/** @id DaPlum */
var DaPlum = function (oFlash, iAdline, oElement) {	
	this.freq = getFreq("f" + iAdline);
	this.flash = oFlash;
	this.flash.setVal("nfreq", this.freq);
	this.element = oElement;
};
DaPlum.prototype = {
	/** @id DaPlum.display */
	display : function () {
		this.element.innerHTML = this.flash.getHTML();	
	}, 
	/** @id DaPlum.clear*/
	clear : function () {
		this.element.innerHTML = "";
	}, 
	/** @id DaPlum.redisplay*/
	displayReset : function () {
		this.flash.setVal("nfreq", this.freq+1);
		this.flash.setVal("nclose", 1);
		this.element.innerHTML = this.flash.getHTML();		
	}
	
};