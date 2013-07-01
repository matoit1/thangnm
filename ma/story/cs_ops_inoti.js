// OPS
var OPS = function(){
	var OPS_WIDTH = 970;
	var OPS_HEIGHT_DEFAULT = 600; // 기본 세로사이즈
	var OPS_HEIGHT_RESIZE = 500; // 변경 세로사이즈
	var OPS_HEIGHT = (screen.availHeight > OPS_HEIGHT_DEFAULT) ? OPS_HEIGHT_DEFAULT : OPS_HEIGHT_RESIZE;

	var DOMAIN_URL = "http://help.naver.com";

	var OPS_URL = {};
	OPS_URL.MAIN = { url : '/',  name : 'webcc_naver', isLink : true };						// FAQ 메인
	OPS_URL.QUERY_UNSOUND = { url : 'http://help.naver.com/ops/step2/query.nhn?serviceType=unsound' };			// 불건전,음란,유해 게시물 신고
	OPS_URL.QUERY_INDIVIDUAL = { url : 'http://help.naver.com/ops/step2/query.nhn?serviceType=individual' };		// 개인정보도용신고
	OPS_URL.QUERY_QUERY = { url : 'http://help.naver.com/ops/step2/query.nhn?serviceType=query' };				// 서비스 장애/오류 신고
	OPS_URL.QUERY_CLOSEID = { url : 'http://help.naver.com/ops/step2/query.nhn?serviceType=closeid' };			// 도용 아이디 탈퇴 요청
	OPS_URL.QUERY_BANNINGUSE = { url : 'http://help.naver.com/ops/step2/query.nhn?serviceType=banninguse' };		// 이용제한 문의/해제요청
	OPS_URL.OPS = { url : '' };		// OPS 기본

	function openOPS(sUrl, sTitle, isCenter, parentClose){
		var sArgsUrl = "";
		if(sUrl){
			sArgsUrl = sUrl;
		}else{
			return;
		}
		var sArgsTitle = sTitle || "_blank";
		var bArgsCenter = isCenter || true;
		var bArgsParentClose = parentClose || false;

		var nWidth = OPS_WIDTH;
		var nHeight = OPS_HEIGHT;
		var sPosition = "";

		if(bArgsCenter){
			var nLeftPosition = (screen.availWidth - nWidth) / 2;
			var nTopPosition = (screen.availHeight - nHeight) / 2;
			sPosition = "left=" + nLeftPosition + ", top=" + nTopPosition + ",";
		}

		var sOptions = sPosition + " toolbar=no, scrollbars=no, location=no, status=yes, menubar=no, resizable=no, width=" + nWidth + ", height=" + nHeight;
		var oPop = window.open(sArgsUrl, sArgsTitle, sOptions);
		oPop.focus();

		if (bArgsParentClose) {
			closeParent(oPop);
		}
	}

	//전체창
	function openSelfOPS(sUrl, sTitle, isCenter, parentClose){
		var sArgsUrl = "";
		if(sUrl){
			sArgsUrl = sUrl;
		}else{
			return;
		}

		window.open(sArgsUrl, "_blank" ,"");
		//location.href = sArgsUrl;
	}

	function closeParent(popup) {
		self.opener = self;
		window.open('about:blank', '_self').close();
	}

	return {
		viewOPS : function(serviceType, option) {
			var oArgsOption = option || {};
			var sServiceType = serviceType || "";
			var oServiceType = OPS_URL[sServiceType.toUpperCase()];

			var oOption = {};
			// 1: OPS_URL[serviceType]의 프로퍼티를 oOption에 추가한다.
			for(var key in oServiceType) {
				oOption[key] = oServiceType[key];
			}
			// 2: viewOPS 함수호출 시 넘겨받은 두번째 전달인자의 프로퍼티를 oOption에 추가한다.
			for(var key2 in oArgsOption) {
				oOption[key2] = oArgsOption[key2];
			}

			var sWinName = oOption.name || "ops";
			var bWinParentClose = oOption.parentClose || false;		// 부모창 닫기, 기본 false

			var sWinUrl = oOption.url;
			if (oOption.param) {
				sWinUrl = sWinUrl + "?" + oOption.param;
			}

			if (oOption.isLink) {
				var oTempWin = window.open(sWinUrl, sWinName);
				oTempWin.focus();

				if (bWinParentClose) {
					closeParent(oTempWin);
				}
			} else {
//				openOPS(sWinUrl, sWinName, true, bWinParentClose);
				openSelfOPS(sWinUrl, sWinName, true, bWinParentClose);
			}
		},

		// 메일 문의 페이지 카테고리 번호로 직접 호출
		viewMailOPS : function(sCatg, bParentClose) {
			viewOPS("OPS", {
				url : DOMAIN_URL + "/ops/step2/mail.nhn",
				param : "serviceType=mail&upCatg=" + sCatg,
				parentClose : bParentClose || false
			});
		}
	};
}();




