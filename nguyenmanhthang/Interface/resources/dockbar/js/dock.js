var cookie_domain = '.ehou.edu.vn';
var account_url = 'https://account.ehou.edu.vn';
var html_content = 
 '<div id="inner">'
+ '<a href="http://ehou.edu.vn" class="leftDocbar portal">CỔNG THÔNG TIN</a>'
+'<a href="http://learning.ehou.edu.vn" class="leftDocbar learning">HỌC TRỰC TUYẾN</a>'
+'<a href="http://support.ehou.edu.vn/" class="leftDocbar  support">HỖ TRỢ HỌC TẬP (H113)</a>'
+'<a href="http://forum.ehou.edu.vn" class="leftDocbar forum">DIỄN ĐÀN</a>'
+'<div class="pinicon" id="pinClick"><br/></div> '
+'<a class="rightDocbar" id="buttondb" href="'+account_url+'/">ĐĂNG NHẬP</a>'
+'<a class="rightDocbar account" id="namedb" href="https://account.ehou.edu.vn"  >TRANG CÁ NHÂN</a>'
+'<div class="rightDocbar notify" id="notifydb"><div id="notenoti"></div><br/>'
+'    <div id="listnotify">'
+'        <img src="'+account_url+'/resources/dockbar/img/up.png" id="imgtop_no"/>'
+'        <div id="topnotify">Thông báo</div>'
+'        <div id="content_1" class="content">'
+'        </div>'
+'        <div id="footnotify"><a href="'+account_url+'/common/notification.html">Xem toàn bộ</a></div>'
+'    </div>'
+'</div>' ;
+'</div>' ;
jQuery('#idockbar').html(html_content);
var target_div = jQuery('#idockbar').attr('to');
jQuery('#idockbar .'+target_div).addClass('active');
/* Jquery Time */
(function($) { 

(function (factory) {
    if (typeof define === 'function' && define.amd) {
        // AMD. Register as an anonymous module.
        define(['jquery'], factory);
    } else {
        // Browser globals
        factory(jQuery);
    }
}(function ($) {
    $.timeago = function(timestamp) {
        if (timestamp instanceof Date) {
            return inWords(timestamp);
        } else if (typeof timestamp === "string") {
            return inWords($.timeago.parse(timestamp));
        } else if (typeof timestamp === "number") {
            return inWords(new Date(timestamp));
        } else {
            return inWords($.timeago.datetime(timestamp));
        }
    };
    var $t = $.timeago;

    $.extend($.timeago, {
        settings: {
            refreshMillis: 60000,
            allowFuture: false,
            localeTitle: false,
            strings: {
                prefixAgo: null,
                prefixFromNow: null,
                suffixAgo: "trước",
                suffixFromNow: "from now",
                seconds: "1 phút trước",
                minute: "khoảng 1 phút",
                minutes: "%d phút ",
                hour: "khoảng 1 giờ",
                hours: " %d giờ ",
                day: "1 ngày",
                days: "%d ngày",
                month: "khoảng 1 tháng",
                months: "%d tháng",
                year: "1 năm",
                years: "%d năm",
                wordSeparator: " ",
                numbers: []
            }
        },
        inWords: function(distanceMillis) {
            var $l = this.settings.strings;
            var prefix = $l.prefixAgo;
            var suffix = $l.suffixAgo;
            if (this.settings.allowFuture) {
                if (distanceMillis < 0) {
                    prefix = $l.prefixFromNow;
                    suffix = $l.suffixFromNow;
                }
            }

            var seconds = Math.abs(distanceMillis) / 1000;
            var minutes = seconds / 60;
            var hours = minutes / 60;
            var days = hours / 24;
            var years = days / 365;

            function substitute(stringOrFunction, number) {
                var string = $.isFunction(stringOrFunction) ? stringOrFunction(number, distanceMillis) : stringOrFunction;
                var value = ($l.numbers && $l.numbers[number]) || number;
                return string.replace(/%d/i, value);
            }

            var words = seconds < 45 && substitute($l.seconds, Math.round(seconds)) ||
            seconds < 90 && substitute($l.minute, 1) ||
            minutes < 45 && substitute($l.minutes, Math.round(minutes)) ||
            minutes < 90 && substitute($l.hour, 1) ||
            hours < 24 && substitute($l.hours, Math.round(hours)) ||
            hours < 42 && substitute($l.day, 1) ||
            days < 30 && substitute($l.days, Math.round(days)) ||
            days < 45 && substitute($l.month, 1) ||
            days < 365 && substitute($l.months, Math.round(days / 30)) ||
            years < 1.5 && substitute($l.year, 1) ||
            substitute($l.years, Math.round(years));

            var separator = $l.wordSeparator || "";
            if ($l.wordSeparator === undefined) {
                separator = " ";
            }
            return $.trim([prefix, words, suffix].join(separator));
        },
        parse: function(iso8601) {
            var s = $.trim(iso8601);
            s = s.replace(/\.\d+/,""); // remove milliseconds
            s = s.replace(/-/,"/").replace(/-/,"/");
            s = s.replace(/T/," ").replace(/Z/," UTC");
            s = s.replace(/([\+\-]\d\d)\:?(\d\d)/," $1$2"); // -04:00 -> -0400
            return new Date(s);
        },
        datetime: function(elem) {
            var iso8601 = $t.isTime(elem) ? $(elem).attr("datetime") : $(elem).attr("title");
            return $t.parse(iso8601);
        },
        isTime: function(elem) {
            // jQuery's `is()` doesn't play well with HTML5 in IE
            return $(elem).get(0).tagName.toLowerCase() === "time"; // $(elem).is("time");
        }
    });

    // functions that can be called via $(el).timeago('action')
    // init is default when no action is given
    // functions are called with context of a single element
    var functions = {
        init: function(){
            var refresh_el = $.proxy(refresh, this);
            refresh_el();
            var $s = $t.settings;
            if ($s.refreshMillis > 0) {
                setInterval(refresh_el, $s.refreshMillis);
            }
        },
        update: function(time){
            $(this).data('timeago', {
                datetime: $t.parse(time)
            });
            refresh.apply(this);
        }
    };

    $.fn.timeago = function(action, options) {
        var fn = action ? functions[action] : functions.init;
        if(!fn){
            throw new Error("Unknown function name '"+ action +"' for timeago");
        }
        // each over objects here and call the requested function
        this.each(function(){
            fn.call(this, options);
        });
        return this;
    };

    function refresh() {
        var data = prepareData(this);
        if (!isNaN(data.datetime)) {
            $(this).text(inWords(data.datetime));
        }
        return this;
    }

    function prepareData(element) {
        element = $(element);
        if (!element.data("timeago")) {
            element.data("timeago", {
                datetime: $t.datetime(element)
            });
            var text = $.trim(element.text());
            if ($t.settings.localeTitle) {
                element.attr("title", element.data('timeago').datetime.toLocaleString());
            } else if (text.length > 0 && !($t.isTime(element) && element.attr("title"))) {
                element.attr("title", text);
            }
        }
        return element.data("timeago");
    }

    function inWords(date) {
        return $t.inWords(distance(date));
    }

    function distance(date) {
        return (new Date().getTime() - date.getTime());
    }

    // fix for IE6 suckage
    document.createElement("abbr");
    document.createElement("time");
}));

(function(factory) {
    if (typeof define === 'function' && define.amd) {
        // AMD. Register as anonymous module.
        define([ 'jquery' ], factory);
    } else {
        // Browser globals.
        factory(jQuery);
    }
}(function($) {
    var pluses = /\+/g;
    function raw(s) {
        return s;
    }
    function decoded(s) {
        return decodeURIComponent(s.replace(pluses, ' '));
    }
    function converted(s) {
        if (s.indexOf('"') === 0) {
            // This is a quoted cookie as according to RFC2068, unescape
            s = s.slice(1, -1).replace(/\\"/g, '"').replace(/\\\\/g, '\\');
        }
        try {
            return config.json ? JSON.parse(s) : s;
        } catch (er) {
        }
    }
    var config = $.cookie = function(key, value, options) {
        // write
        if (value !== undefined) {
            options = $.extend({}, config.defaults, options);
            if (typeof options.expires === 'number') {
                var days = options.expires, t = options.expires = new Date();
                t.setDate(t.getDate() + days);
            }
            value = config.json ? JSON.stringify(value) : String(value);
            return (document.cookie = [
                config.raw ? key : encodeURIComponent(key),
                '=',
                config.raw ? value : encodeURIComponent(value),
                options.expires ? '; expires='
                + options.expires.toUTCString() : '', // use
                options.path ? '; path=' + options.path : '',
                options.domain ? '; domain=' + options.domain : '',
                options.secure ? '; secure' : '' ].join(''));
        }
        // read
        var decode = config.raw ? raw : decoded;
        var cookies = document.cookie.split('; ');
        var result = key ? undefined : {};
        for ( var i = 0, l = cookies.length; i < l; i++) {
            var parts = cookies[i].split('=');
            var name = decode(parts.shift());
            var cookie = decode(parts.join('='));
            if (key && key === name) {
                result = converted(cookie);
                break;
            }
            if (!key) {
                result[name] = converted(cookie);
            }
        }
        return result;
    };
    config.defaults = {};
    $.removeCookie = function(key, options) {
        if ($.cookie(key) !== undefined) {
            $.cookie(key, '', $.extend(options, {
                expires : -1
            }));
            return true;
        }
        return false;
    };
}));
})(jQuery);

function runDockbar() {
    jQuery("#idockbar a#buttondb").attr('href',account_url+'/?redirect='+window.location);
    updateDockbar(jQuery.cookie('pindockbar'));
    jQuery.getJSON(account_url+'/status?callback=?', function(json) {
        var status = parseInt(json.status);
        if (status != 0 ) {
            jQuery("#idockbar .rightDocbar").css('display','block');
            jQuery("#idockbar a#buttondb").html('THOÁT');
            jQuery("#idockbar a#namedb").html(json.screenname);
            jQuery("#idockbar a#buttondb").attr('href',account_url+'/logout?redirect='+window.location);
            if(json.totalAlert > 0 )

                if(json.totalAlert > 0 )
                {
                    jQuery("#notenoti").html(json.totalAlert);
                    jQuery("#notenoti").css('display','block');

                }
        }
        updateWidth();
        jQuery(window).resize(function() {
            updateWidth();
        });
        jQuery('#idockbar #pinClick').click(function() {
        	
            updateDockbar(1 - jQuery.cookie('pindockbar'));
        });
    });
}
function updateDockbar(status) {
    if (status == '0') {
        jQuery('#idockbar').attr('class', 'pin-dockbar');
        updateWidth();
        jQuery.cookie('pindockbar', 0, {
            path : '/', 
            domain: cookie_domain
        });
    } else {
        jQuery('#idockbar').attr('class', 'unpin-dockbar');
        jQuery.cookie('pindockbar', 1, {
            path : '/', 
            domain: cookie_domain
        });
    }
}
function updateWidth() {
    jQuery('#idockbar #inner').css('width', jQuery("body").width() + 'px');
}


jQuery(document).ready(function(){
    var ischeck = false;
    runDockbar();
    jQuery("#notifydb").click(function() {
        if(jQuery("#listnotify").css("margin-left")=="-2000px") {
            jQuery("#listnotify").css("margin-left","0");
            if(ischeck == false) {
                jQuery.getJSON(account_url+'/notification?callback=?', function(json) {
                    var  dem = 0;
                    jQuery.each( json, function( i, item ) {
                        dem++;
                        jQuery('#content_1').append('<div class="textnoti"> <a href="'+account_url+'/common/notification-detail.html?id='+item.id +'" >'+ item.title + 
                            '</a></div><div class="timenoti"> <span class="timeago" title="' +
                            item.sentDate.year+'-'+
                            item.sentDate.month+'-'+
                            item.sentDate.day+'T'+
                            item.sentDate.hour+':'+
                            item.sentDate.minute+':'+
                            item.sentDate.second+ '"></span></div>');
                    });
                    jQuery("span.timeago").timeago();
                    if(dem == 0 ) {
                        jQuery("#content_1").html('<div class="textnoti">Không có tin nhắn mới</div>');
                    }
		
                });
                ischeck = true;
            }
        }
        else jQuery("#listnotify").css("margin-left","-2000px");
    });
	
    jQuery("body").click(function(e) {
        if (e.target.id == "notifydb" || jQuery(e.target).parents("#notifydb").size()) { 
        } else { 
            jQuery("#listnotify").css("margin-left","-2000px");
        }
    });

});
