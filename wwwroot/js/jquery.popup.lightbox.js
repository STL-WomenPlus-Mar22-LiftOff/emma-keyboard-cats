/*   Project: Popup Lightbox 
 *   Author: Asif Mughal
 *   URL: www.codehim.com
 *   License: MIT License
 *   Copyright (c) 2019 - Asif Mughal
 */
/* File: jquery.popup.lightbox.js */
(function ($) {
	$.fn.popupLightbox = function (options) {

		var setting = $.extend({
			width: 560,
			height: 340,
			inAnimation: "ZoomIn",

		}, options);

		return this.each(function () {

			var target = $(this);

			var popupWindow = $section();

			var closeBtn = $button();

			var nextBtn = $button();

			var prevBtn = $button();

			var imgStat = $div();

			var imgFig = $figure();

			var capBar = $figcaption();

			var imgs = $(target).find("img");

			var totalImgs = imgs.length;

			var imgNum = 0;
			var current, thisCaption;


			$(nextBtn).addClass("btn-next")
				.appendTo(popupWindow);

			$(prevBtn).addClass("btn-prev")
				.appendTo(popupWindow);

			$(closeBtn).addClass("btn-close")
				.appendTo(popupWindow)
				.html("\&times;");

			$(imgStat).addClass("lightbox-status")
				.appendTo(popupWindow);


			$(imgFig).addClass("img-show")
				.appendTo(popupWindow);

			$(popupWindow).addClass("lightbox animated faster " + setting.inAnimation).appendTo("body");


			//set up unique number for each image 

			for (var i = 0; i < imgs.length; i++) {

				$(imgs).eq(i).attr({
					'data-num': i,
					'id': '#img' + i,
				});


			}

			if ($(window).width() > 620) {


				$(popupWindow).css({
					'width': setting.width,
					'height': setting.height,
					'position': 'fixed',
					'top': '50%',
					'marginTop': -(setting.height / 2),
					'left': '50%',
					'marginLeft': -(setting.width / 2),
					'zIndex': '999',
					'overflow': 'hidden',

				});

			} else {
				$(popupWindow).css({
					'width': '100%',
					'height': '100%',
					'top': 0,
					'left': 0,


				});


			}


			$(capBar).addClass("img-caption animated fadeInUp");


			$(imgs).click(function () {

				var thisImg = $(this).clone();
				var thisNum = $(this).attr("data-num") * 1;
				var $caption = $(this).attr('alt');
				if ($(this).prop('alt') == false) {
					$caption = "This image has no caption";
				}


				imgNum = thisNum;

				if (thisNum + 1 == totalImgs) {
					$(nextBtn).hide();
					$(prevBtn).show();
				} else if (thisNum == 0) {
					$(prevBtn).hide();
					$(nextBtn).show();
				} else {
					$(nextBtn).show();
					$(prevBtn).show();
				}

				$(imgStat).html(thisNum + 1 + " / " + totalImgs);

				$(imgFig).html(thisImg)
					.parent().fadeIn();

				$(capBar).html($caption).appendTo(imgFig);

			});


			//Next image 

			$(nextBtn).click(function () {

				var y = totalImgs - 1;


				if (imgNum < y) {
					imgNum += 1;
				}

				if (imgNum + 1 == totalImgs) {
					$(nextBtn).hide();
				}

				$(prevBtn).fadeIn();


				$(imgFig).find("img").animate({
					'left': '-100%',
					'opacity': 0,
				}, 200, function () {

					$(imgFig).html($(imgs).eq(imgNum).clone());

					current = $(imgFig).find("img");

					thisCaption = $(current).attr("alt");

					if ($(current).prop('alt') == false) {
						thisCaption = "This image has no caption";
					}

					$(capBar).html(thisCaption).appendTo(imgFig);

					$(imgStat).html(imgNum + 1 + " / " + totalImgs);

				});


			});

			//Previous image 

			$(prevBtn).click(function () {


				if (imgNum > 0) {

					imgNum -= 1;
				}
				$(nextBtn).fadeIn();


				$(imgFig).find("img").animate({
					'right': '-100%',
					'opacity': 0,
				}, 200, function () {
					$(imgFig).html($(imgs).eq(imgNum).clone());

					current = $(imgFig).find("img");

					thisCaption = $(current).attr("alt");
					$(capBar).html(thisCaption).appendTo(imgFig);


					$(imgStat).html(imgNum + 1 + " / " + totalImgs);

				});

				if (imgNum == 0) {
					$(prevBtn).hide();
				}


			});


			function $div() {
				return document.createElement("div");
			}

			function $button() {
				return document.createElement("button");

			}

			function $section() {

				return document.createElement("section");

			}

			function $figure() {
				return document.createElement("figure");
			}

			function $figcaption() {
				return document.createElement("figcaption");

			}


			$(".btn-close").click(function () {
				$(this).parent().fadeOut();
				imgNum = 0;


			});


		});
	};

})(jQuery);
