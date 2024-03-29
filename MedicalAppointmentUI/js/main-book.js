﻿/*------------------------------------------------------------------

Project:	Medical Appointment Management System (IU)
Version:	1.0
Author:	    Iwthemes www.iwthemes.com
Support:    support@iwthemes.com
Portfolio:  https://themeforest.net/user/iwthemes/portfolio

-------------------------------------------------------------------*/

(function ($) {
    "use strict";

    $(document).ready(function () {
        $('img').addClass('img-responsive');
        $('[data-toggle="tooltip"]').tooltip()
        $('.help-box, .notifications').fadeIn('slow');
    });

    $(document).ready(function () {
        $('.help-box .body-help .close-box').on("click", function () {
            $('.help-box').fadeOut('slow');
        });
    });

    $(document).ready(function () {
        $('.date-numer').on("click", function () {
            var id = $(this).attr("id");
            $(".list-available").each(function () {
                if ($(this).attr("id") == "list-book-" + id) {
                    $(this).fadeIn();
                } else {
                    $(this).hide();
                }
            });
        });
    });

    $(document).ready(function () {
        $('.close').on("click", function () {
            $(".list-available").fadeOut('slow');
        });
    });

    $(document).ready(function () {
        $('.btn-search-appointment').on("click", function () {
            $(".book-calendar").css('opacity', '1');
        });
    });

    $(document).ready(function () {
        $('.confirm').on("click", function () {
            alert("Â¿are you sure?");
            $(this).addClass('disable');
        });
    });

    $(document).ready(function () {
        $('.menu-nav ul li a').on("click", function () {
            var el = $(this).attr('href');
            var elWrapped = $(el);
            scrollToDiv(elWrapped, 40);
            return false;
        });
    });

    function scrollToDiv(element, navheight) {
        var offset = element.offset();
        var offsetTop = offset.top;
        var totalScroll = offsetTop - navheight;
        $('body,html').animate({
            scrollTop: totalScroll
        }, 500);
    }
})(jQuery);