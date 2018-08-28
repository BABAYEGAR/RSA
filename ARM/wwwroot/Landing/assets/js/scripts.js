/*<![CDATA[*/
            window._wpemojiSettings = {
                "baseUrl": "https:\/\/s.w.org\/images\/core\/emoji\/11\/72x72\/",
                "ext": ".png",
                "svgUrl": "https:\/\/s.w.org\/images\/core\/emoji\/11\/svg\/",
                "svgExt": ".svg",
                "source": {
                    "concatemoji": "https:\/\/demo.goodlayers.com\/financity\/demo2\/wp-includes\/js\/wp-emoji-release.min.js?ver=4.9.8"
                }
            };
            !function(a, b, c) {
                function d(a, b) {
                    var c = String.fromCharCode;
                    l.clearRect(0, 0, k.width, k.height),
                    l.fillText(c.apply(this, a), 0, 0);
                    var d = k.toDataURL();
                    l.clearRect(0, 0, k.width, k.height),
                    l.fillText(c.apply(this, b), 0, 0);
                    var e = k.toDataURL();
                    return d === e
                }
                function e(a) {
                    var b;
                    if (!l || !l.fillText)
                        return !1;
                    switch (l.textBaseline = "top",
                    l.font = "600 32px Arial",
                    a) {
                    case "flag":
                        return !(b = d([55356, 56826, 55356, 56819], [55356, 56826, 8203, 55356, 56819])) && (b = d([55356, 57332, 56128, 56423, 56128, 56418, 56128, 56421, 56128, 56430, 56128, 56423, 56128, 56447], [55356, 57332, 8203, 56128, 56423, 8203, 56128, 56418, 8203, 56128, 56421, 8203, 56128, 56430, 8203, 56128, 56423, 8203, 56128, 56447]),
                        !b);
                    case "emoji":
                        return b = d([55358, 56760, 9792, 65039], [55358, 56760, 8203, 9792, 65039]),
                        !b
                    }
                    return !1
                }
                function f(a) {
                    var c = b.createElement("script");
                    c.src = a,
                    c.defer = c.type = "text/javascript",
                    b.getElementsByTagName("head")[0].appendChild(c)
                }
                var g, h, i, j, k = b.createElement("canvas"), l = k.getContext && k.getContext("2d");
                for (j = Array("flag", "emoji"),
                c.supports = {
                    everything: !0,
                    everythingExceptFlag: !0
                },
                i = 0; i < j.length; i++)
                    c.supports[j[i]] = e(j[i]),
                    c.supports.everything = c.supports.everything && c.supports[j[i]],
                    "flag" !== j[i] && (c.supports.everythingExceptFlag = c.supports.everythingExceptFlag && c.supports[j[i]]);
                c.supports.everythingExceptFlag = c.supports.everythingExceptFlag && !c.supports.flag,
                c.DOMReady = !1,
                c.readyCallback = function() {
                    c.DOMReady = !0
                }
                ,
                c.supports.everything || (h = function() {
                    c.readyCallback()
                }
                ,
                b.addEventListener ? (b.addEventListener("DOMContentLoaded", h, !1),
                a.addEventListener("load", h, !1)) : (a.attachEvent("onload", h),
                b.attachEvent("onreadystatechange", function() {
                    "complete" === b.readyState && c.readyCallback()
                })),
                g = c.source || {},
                g.concatemoji ? f(g.concatemoji) : g.wpemoji && g.twemoji && (f(g.twemoji),
                f(g.wpemoji)))
            }(window, document, window._wpemojiSettings);
            /*]]>*/


//Snazzy scripts


var SnazzyDataForSnazzyMaps = [];
            SnazzyDataForSnazzyMaps = {
                "id": 15,
                "name": "Subtle Grayscale",
                "description": "A nice, simple grayscale version of the map with color extremes that are never too harsh on the eyes. Originally created for http:\/\/barvinssurvins.fr\/situer.",
                "url": "https:\/\/snazzymaps.com\/style\/15\/subtle-grayscale",
                "imageUrl": "https:\/\/snazzy-maps-cdn.azureedge.net\/assets\/15-subtle-grayscale.png?v=20170626083535",
                "json": "[{\"featureType\":\"administrative\",\"elementType\":\"all\",\"stylers\":[{\"saturation\":\"-100\"}]},{\"featureType\":\"administrative.province\",\"elementType\":\"all\",\"stylers\":[{\"visibility\":\"off\"}]},{\"featureType\":\"landscape\",\"elementType\":\"all\",\"stylers\":[{\"saturation\":-100},{\"lightness\":65},{\"visibility\":\"on\"}]},{\"featureType\":\"poi\",\"elementType\":\"all\",\"stylers\":[{\"saturation\":-100},{\"lightness\":\"50\"},{\"visibility\":\"simplified\"}]},{\"featureType\":\"road\",\"elementType\":\"all\",\"stylers\":[{\"saturation\":\"-100\"}]},{\"featureType\":\"road.highway\",\"elementType\":\"all\",\"stylers\":[{\"visibility\":\"simplified\"}]},{\"featureType\":\"road.arterial\",\"elementType\":\"all\",\"stylers\":[{\"lightness\":\"30\"}]},{\"featureType\":\"road.local\",\"elementType\":\"all\",\"stylers\":[{\"lightness\":\"40\"}]},{\"featureType\":\"transit\",\"elementType\":\"all\",\"stylers\":[{\"saturation\":-100},{\"visibility\":\"simplified\"}]},{\"featureType\":\"water\",\"elementType\":\"geometry\",\"stylers\":[{\"hue\":\"#ffff00\"},{\"lightness\":-25},{\"saturation\":-97}]},{\"featureType\":\"water\",\"elementType\":\"labels\",\"stylers\":[{\"lightness\":-25},{\"saturation\":-100}]}]",
                "views": 431407,
                "favorites": 837,
                "createdBy": {
                    "name": "Paulo Avila",
                    "url": null
                },
                "createdOn": "2013-10-30T16:37:24.593",
                "tags": ["greyscale", "light"],
                "colors": ["gray", "white"]
            };


//end snazzy





 /*<![CDATA[*/
            function setREVStartSize(e) {
                try {
                    e.c = jQuery(e.c);
                    var i = jQuery(window).width()
                      , t = 9999
                      , r = 0
                      , n = 0
                      , l = 0
                      , f = 0
                      , s = 0
                      , h = 0;
                    if (e.responsiveLevels && (jQuery.each(e.responsiveLevels, function(e, f) {
                        f > i && (t = r = f,
                        l = e),
                        i > f && f > r && (r = f,
                        n = e)
                    }),
                    t > r && (l = n)),
                    f = e.gridheight[l] || e.gridheight[0] || e.gridheight,
                    s = e.gridwidth[l] || e.gridwidth[0] || e.gridwidth,
                    h = i / s,
                    h = h > 1 ? 1 : h,
                    f = Math.round(h * f),
                    "fullscreen" == e.sliderLayout) {
                        var u = (e.c.width(),
                        jQuery(window).height());
                        if (void 0 != e.fullScreenOffsetContainer) {
                            var c = e.fullScreenOffsetContainer.split(",");
                            if (c)
                                jQuery.each(c, function(e, i) {
                                    u = jQuery(i).length > 0 ? u - jQuery(i).outerHeight(!0) : u
                                }),
                                e.fullScreenOffset.split("%").length > 1 && void 0 != e.fullScreenOffset && e.fullScreenOffset.length > 0 ? u -= jQuery(window).height() * parseInt(e.fullScreenOffset, 0) / 100 : void 0 != e.fullScreenOffset && e.fullScreenOffset.length > 0 && (u -= parseInt(e.fullScreenOffset, 0))
                        }
                        f = u
                    } else
                        void 0 != e.minHeight && f < e.minHeight && (f = e.minHeight);
                    e.c.closest(".rev_slider_wrapper").css({
                        height: f
                    })
                } catch (d) {
                    console.log("Failure at Presize of Slider:" + d)
                }
            }
            ;/*]]>*/



var c = document.body.className;
            c = c.replace(/woocommerce-no-js/, 'woocommerce-js');
            document.body.className = c;






/*<![CDATA[*/
            function revslider_showDoubleJqueryError(sliderID) {
                var errorMessage = "Revolution Slider Error: You have some jquery.js library include that comes after the revolution files js include.";
                errorMessage += "<br> This includes make eliminates the revolution slider libraries, and make it not work.";
                errorMessage += "<br><br> To fix it you can:<br>&nbsp;&nbsp;&nbsp; 1. In the Slider Settings -> Troubleshooting set option:  <strong><b>Put JS Includes To Body</b></strong> option to true.";
                errorMessage += "<br>&nbsp;&nbsp;&nbsp; 2. Find the double jquery.js include and remove it.";
                errorMessage = "<span style='font-size:16px;color:#BC0C06;'>" + errorMessage + "</span>";
                jQuery(sliderID).show().html(errorMessage);
            }
            /*]]>*/



var wpcf7 = {
                "apiSettings": {
                    "root": "https:\/\/demo.goodlayers.com\/financity\/demo2\/wp-json\/contact-form-7\/v1",
                    "namespace": "contact-form-7\/v1"
                },
                "recaptcha": {
                    "messages": {
                        "empty": "Please verify that you are not a robot."
                    }
                },
                "cached": "1"
            };





var wc_add_to_cart_params = {
                "ajax_url": "\/financity\/demo2\/wp-admin\/admin-ajax.php",
                "wc_ajax_url": "\/financity\/demo2\/?wc-ajax=%%endpoint%%",
                "i18n_view_cart": "View cart",
                "cart_url": "https:\/\/demo.goodlayers.com\/financity\/demo2",
                "is_cart": "",
                "cart_redirect_after_add": "no"
            };


 var woocommerce_params = {
                "ajax_url": "\/financity\/demo2\/wp-admin\/admin-ajax.php",
                "wc_ajax_url": "\/financity\/demo2\/?wc-ajax=%%endpoint%%"
            };



 var wc_cart_fragments_params = {
                "ajax_url": "\/financity\/demo2\/wp-admin\/admin-ajax.php",
                "wc_ajax_url": "\/financity\/demo2\/?wc-ajax=%%endpoint%%",
                "cart_hash_key": "wc_cart_hash_e08a0c2d38ba6a5ece9dfdeb129f9556",
                "fragment_name": "wc_fragments_e08a0c2d38ba6a5ece9dfdeb129f9556"
            };


var financity_script_core = {
                "home_url": "https:\/\/demo.goodlayers.com\/financity\/demo2\/"
            };


var wpgmp_local = {
                "all_location": "All",
                "show_locations": "Show Locations",
                "sort_by": "Sort by",
                "wpgmp_not_working": "not working...",
                "place_icon_url": "https:\/\/demo.goodlayers.com\/financity\/demo2\/wp-content\/plugins\/wp-google-map-plugin\/assets\/images\/icons\/"
            };


var gdlr_core_pbf = {
                "admin": "",
                "video": {
                    "width": "640",
                    "height": "360"
                },
                "ajax_url": "https:\/\/demo.goodlayers.com\/financity\/demo2\/wp-admin\/admin-ajax.php",
                "ilightbox_skin": "dark"
            };



//Form Wizard
var sfw;
        $(document).ready(function () {
            sfw = $("#wizard_example").stepFormWizard({
//                 theme: 'sun',
                height: 'auto',
                onNext: function(i) {
                    var valid = $("#wizard_example").parsley().validate('block' + i);
                    sfw.refresh();
                    return valid;
                },
                onFinish: function(i) {
                    var valid = $("#wizard_example").parsley().validate();
                    // if use height: 'auto' call refresh metod after validation, because parsley can change content
                    sfw.refresh();
                    return valid;
                }
            });
        })
        $(window).load(function () {
            /* only if you want use mcustom scrollbar */
            $(".sf-step").mCustomScrollbar({
                theme: "dark-3",
                scrollButtons: {
                    enable: true
                }
            });
        });

//end form wizard



//datepicker
$(document).ready(function(){
      var date_input=$('input[name="exampleInputText1"]'); //our date input has the name "date"
      var container=$('.bootstrap-iso form').length>0 ? $('.bootstrap-iso form').parent() : "body";
      var options={
        format: 'dd/mm/yyyy',
        container: container,
        todayHighlight: true,
        autoclose: true,
      };
      date_input.datepicker(options);
    });

//end date picker

//tooltip
$(document).ready(function(){
    $('[data-toggle="tooltip"]').tooltip();   
});

//endtooltip



 //slider javascript
/*! rangeslider.js - v2.0.2 | (c) 2015 @andreruffert | MIT license | https://github.com/andreruffert/rangeslider.js */
! function(a) {
  "use strict";
  "function" == typeof define && define.amd ? define(["jquery"], a) : a("object" == typeof exports ? require("jquery") : jQuery)
}(function(a) {
  "use strict";

  function b() {
    var a = document.createElement("input");
    return a.setAttribute("type", "range"), "text" !== a.type
  }

  function c(a, b) {
    var c = Array.prototype.slice.call(arguments, 2);
    return setTimeout(function() {
      return a.apply(null, c)
    }, b)
  }

  function d(a, b) {
    return b = b || 100,
      function() {
        if (!a.debouncing) {
          var c = Array.prototype.slice.apply(arguments);
          a.lastReturnVal = a.apply(window, c), a.debouncing = !0
        }
        return clearTimeout(a.debounceTimeout), a.debounceTimeout = setTimeout(function() {
          a.debouncing = !1
        }, b), a.lastReturnVal
      }
  }

  function e(a) {
    return a && (0 === a.offsetWidth || 0 === a.offsetHeight || a.open === !1)
  }

  function f(a) {
    for (var b = [], c = a.parentNode; e(c);) b.push(c), c = c.parentNode;
    return b
  }

  function g(a, b) {
    function c(a) {
      "undefined" != typeof a.open && (a.open = a.open ? !1 : !0)
    }
    var d = f(a),
      e = d.length,
      g = [],
      h = a[b];
    if (e) {
      for (var i = 0; e > i; i++) g[i] = d[i].style.cssText, d[i].style.display = "block", d[i].style.height = "0", d[i].style.overflow = "hidden", d[i].style.visibility = "hidden", c(d[i]);
      h = a[b];
      for (var j = 0; e > j; j++) d[j].style.cssText = g[j], c(d[j])
    }
    return h
  }

  function h(a, b) {
    var c = parseFloat(a);
    return Number.isNaN(c) ? b : c
  }

  function i(a) {
    return a.charAt(0).toUpperCase() + a.substr(1)
  }

  function j(b, e) {
    if (this.$window = a(window), this.$document = a(document), this.$element = a(b), this.options = a.extend({}, n, e), this.polyfill = this.options.polyfill, this.orientation = this.$element[0].getAttribute("data-orientation") || this.options.orientation, this.onInit = this.options.onInit, this.onSlide = this.options.onSlide, this.onSlideEnd = this.options.onSlideEnd, this.DIMENSION = o.orientation[this.orientation].dimension, this.DIRECTION = o.orientation[this.orientation].direction, this.DIRECTION_STYLE = o.orientation[this.orientation].directionStyle, this.COORDINATE = o.orientation[this.orientation].coordinate, this.polyfill && m) return !1;
    this.identifier = "js-" + k + "-" + l++, this.startEvent = this.options.startEvent.join("." + this.identifier + " ") + "." + this.identifier, this.moveEvent = this.options.moveEvent.join("." + this.identifier + " ") + "." + this.identifier, this.endEvent = this.options.endEvent.join("." + this.identifier + " ") + "." + this.identifier, this.toFixed = (this.step + "").replace(".", "").length - 1, this.$fill = a('<div class="' + this.options.fillClass + '" />'), this.$handle = a('<div class="' + this.options.handleClass + '" />'), this.$range = a('<div class="' + this.options.rangeClass + " " + this.options[this.orientation + "Class"] + '" id="' + this.identifier + '" />').insertAfter(this.$element).prepend(this.$fill, this.$handle), this.$element.css({
      position: "absolute",
      width: "1px",
      height: "1px",
      overflow: "hidden",
      opacity: "0"
    }), this.handleDown = a.proxy(this.handleDown, this), this.handleMove = a.proxy(this.handleMove, this), this.handleEnd = a.proxy(this.handleEnd, this), this.init();
    var f = this;
    this.$window.on("resize." + this.identifier, d(function() {
      c(function() {
        f.update()
      }, 300)
    }, 20)), this.$document.on(this.startEvent, "#" + this.identifier + ":not(." + this.options.disabledClass + ")", this.handleDown), this.$element.on("change." + this.identifier, function(a, b) {
      if (!b || b.origin !== f.identifier) {
        var c = a.target.value,
          d = f.getPositionFromValue(c);
        f.setPosition(d)
      }
    })
  }
  Number.isNaN = Number.isNaN || function(a) {
    return "number" == typeof a && a !== a
  };
  var k = "rangeslider",
    l = 0,
    m = b(),
    n = {
      polyfill: !0,
      orientation: "horizontal",
      rangeClass: "rangeslider",
      disabledClass: "rangeslider--disabled",
      horizontalClass: "rangeslider--horizontal",
      verticalClass: "rangeslider--vertical",
      fillClass: "rangeslider__fill",
      handleClass: "rangeslider__handle",
      startEvent: ["mousedown", "touchstart", "pointerdown"],
      moveEvent: ["mousemove", "touchmove", "pointermove"],
      endEvent: ["mouseup", "touchend", "pointerup"]
    },
    o = {
      orientation: {
        horizontal: {
          dimension: "width",
          direction: "left",
          directionStyle: "left",
          coordinate: "x"
        },
        vertical: {
          dimension: "height",
          direction: "top",
          directionStyle: "bottom",
          coordinate: "y"
        }
      }
    };
  j.prototype.init = function() {
    this.update(!0, !1), this.$element[0].value = this.value, this.onInit && "function" == typeof this.onInit && this.onInit()
  }, j.prototype.update = function(a, b) {
    a = a || !1, a && (this.min = h(this.$element[0].getAttribute("min"), 0), this.max = h(this.$element[0].getAttribute("max"), 100), this.value = h(this.$element[0].value, this.min + (this.max - this.min) / 2), this.step = h(this.$element[0].getAttribute("step"), 1)), this.handleDimension = g(this.$handle[0], "offset" + i(this.DIMENSION)), this.rangeDimension = g(this.$range[0], "offset" + i(this.DIMENSION)), this.maxHandlePos = this.rangeDimension - this.handleDimension, this.grabPos = this.handleDimension / 2, this.position = this.getPositionFromValue(this.value), this.$element[0].disabled ? this.$range.addClass(this.options.disabledClass) : this.$range.removeClass(this.options.disabledClass), this.setPosition(this.position, b)
  }, j.prototype.handleDown = function(a) {
    if (a.preventDefault(), this.$document.on(this.moveEvent, this.handleMove), this.$document.on(this.endEvent, this.handleEnd), !((" " + a.target.className + " ").replace(/[\n\t]/g, " ").indexOf(this.options.handleClass) > -1)) {
      var b = this.getRelativePosition(a),
        c = this.$range[0].getBoundingClientRect()[this.DIRECTION],
        d = this.getPositionFromNode(this.$handle[0]) - c,
        e = "vertical" === this.orientation ? this.maxHandlePos - (b - this.grabPos) : b - this.grabPos;
      this.setPosition(e), b >= d && b < d + this.handleDimension && (this.grabPos = b - d)
    }
  }, j.prototype.handleMove = function(a) {
    a.preventDefault();
    var b = this.getRelativePosition(a),
      c = "vertical" === this.orientation ? this.maxHandlePos - (b - this.grabPos) : b - this.grabPos;
    this.setPosition(c)
  }, j.prototype.handleEnd = function(a) {
    a.preventDefault(), this.$document.off(this.moveEvent, this.handleMove), this.$document.off(this.endEvent, this.handleEnd), this.$element.trigger("change", {
      origin: this.identifier
    }), this.onSlideEnd && "function" == typeof this.onSlideEnd && this.onSlideEnd(this.position, this.value)
  }, j.prototype.cap = function(a, b, c) {
    return b > a ? b : a > c ? c : a
  }, j.prototype.setPosition = function(a, b) {
    var c, d;
    void 0 === b && (b = !0), c = this.getValueFromPosition(this.cap(a, 0, this.maxHandlePos)), d = this.getPositionFromValue(c), this.$fill[0].style[this.DIMENSION] = d + this.grabPos + "px", this.$handle[0].style[this.DIRECTION_STYLE] = d + "px", this.setValue(c), this.position = d, this.value = c, b && this.onSlide && "function" == typeof this.onSlide && this.onSlide(d, c)
  }, j.prototype.getPositionFromNode = function(a) {
    for (var b = 0; null !== a;) b += a.offsetLeft, a = a.offsetParent;
    return b
  }, j.prototype.getRelativePosition = function(a) {
    var b = i(this.COORDINATE),
      c = this.$range[0].getBoundingClientRect()[this.DIRECTION],
      d = 0;
    return "undefined" != typeof a["page" + b] ? d = a["client" + b] : "undefined" != typeof a.originalEvent["client" + b] ? d = a.originalEvent["client" + b] : a.originalEvent.touches && a.originalEvent.touches[0] && "undefined" != typeof a.originalEvent.touches[0]["client" + b] ? d = a.originalEvent.touches[0]["client" + b] : a.currentPoint && "undefined" != typeof a.currentPoint[this.COORDINATE] && (d = a.currentPoint[this.COORDINATE]), d - c
  }, j.prototype.getPositionFromValue = function(a) {
    var b, c;
    return b = (a - this.min) / (this.max - this.min), c = Number.isNaN(b) ? 0 : b * this.maxHandlePos
  }, j.prototype.getValueFromPosition = function(a) {
    var b, c;
    return b = a / (this.maxHandlePos || 1), c = this.step * Math.round(b * (this.max - this.min) / this.step) + this.min, Number(c.toFixed(this.toFixed))
  }, j.prototype.setValue = function(a) {
    a !== this.value && this.$element.val(a).trigger("input", {
      origin: this.identifier
    })
  }, j.prototype.destroy = function() {
    this.$document.off("." + this.identifier), this.$window.off("." + this.identifier), this.$element.off("." + this.identifier).removeAttr("style").removeData("plugin_" + k), this.$range && this.$range.length && this.$range[0].parentNode.removeChild(this.$range[0])
  }, a.fn[k] = function(b) {
    var c = Array.prototype.slice.call(arguments, 1);
    return this.each(function() {
      var d = a(this),
        e = d.data("plugin_" + k);
      e || d.data("plugin_" + k, e = new j(this, b)), "string" == typeof b && e[b].apply(e, c)
    })
  }
});

//custom slider javascript
var $element = $('input[type="range"]');
var $handle;

$element
  .rangeslider({
    update: true,
    polyfill: false,
    onInit: function() {
      $handle = $('.rangeslider__handle', this.$range);
      updateHandle($handle[0], this.value);
    }
  })
  .on('input', function() {
//    updateHandle($handle[0], this.value);
     $thisrange = $(this)[0].id;
         $thisrangev = $(this)[0].value;
        $('#'+$thisrange).siblings('.rangeslider').find('.rangeslider__handle').text($thisrangev);
  });

function updateHandle(el, val) {
  el.textContent = " " + "₦" + val + " ";
}

$(document).ready(function(){
  
  //when slider changes, hide start message
$("input").on("change", function() {
  $("#helper").fadeOut("slow");
});

//promo-box
$("#js-promo-box").hide();
$("#promo-link").on("click", function(){
  $("#js-promo-box").slideToggle();
  return false;
});
  
});