//$("#small-search-box-form").on("submit", function (n) {
//    $("#small-searchterms").focus();
//    $("#small-searchterms").val() == ""
//        && (alert("Vui lòng nhập một số từ khóa tìm kiếm"),
//            $("#small-searchterms").focus(), n.preventDefault())
//});

//$(document).ready(function () {
//    var n, t; $("#small-searchterms").autocomplete({
//        delay: 1e3,
//        minLength: 3,
//        source: "/catalog/searchtermautocomplete",
//        appendTo: ".search-box",
//        select: function (n, t) {
//            return $("#small-searchterms").val(t.item.label),
//                setLocation(t.item.producturl), !1
//        },
//        open: function () {
//            n && (t = document.getElementById("small-searchterms").value,
//                $(".ui-autocomplete").append(
//                    '<li class="ui-menu-item" role="presentation"><a href="/search?q=' + t + '">Xem tất cả kết quả ...<\/a><\/li>'))
//        }
//    }).data("ui-autocomplete")._renderItem = function (t, i) {
//        var r = i.label;
//        return n = i.showlinktoresultsearch,
//            r = htmlEncode(r), $("<li><\/li>")
//                .data("item.autocomplete", i)
//                .append("<a><img src='" + i.productpictureurl + "'><span>" + r + "<\/span><\/a>")
//                .appendTo(t)
//    }
//})

function myFunction() {
    document.getElementById("myDropdown")
        .classList.toggle("show")
} window.onclick = function (n) {
    var i, t, r; if (!n.target.matches(".dropbtn"))
        for (i = document.getElementsByClassName("dropdown-content"),
            t = 0; t < i.length; t++)r = i[t],
                r.classList.contains("show") && r.classList.remove("show")
}
$(document).ready(function () {
    $(".header").on("mouseenter",
        "#topcartlink", function () {
            $("#flyout-cart").addClass("active")
        });
    $(".header").on("mouseleave", "#topcartlink", function () {
        $("#flyout-cart").removeClass("active")
    });
    $(".header").on("mouseenter", "#flyout-cart", function () {
        $("#flyout-cart").addClass("active")
    });
    $(".header").on("mouseleave", "#flyout-cart", function () {
        $("#flyout-cart").removeClass("active")
    })
})

$(document).ready(function () {
    $(".menu-toggle").on("click", function () {
        $(this).toggleClass("active").siblings(".top-menu.mobile").slideToggle("slow")
    });
    $(".top-menu.mobile .sublist-toggle").on("click", function () {
        $(this).siblings(".sublist").slideToggle("slow")
    });
    $(".header-links li a").hasClass("ico-login") && $(".ico-logout").css("display", "none")
})
$(document).ready(function () {
    $(".ic_lg_show.s-down").click(function () {
        $(".show-down").slideToggle()
    });
    $(".ic_lg_show-news.s-down").click(function () {
        $(".show-down-news").slideToggle()
    })
})
//var localized_data = {
//    AjaxCartFailure: "Thêm sản phẩm thất bại. Xin tải lại trang và thử một lần nữa."
//};
//AjaxCart.init(!1, ".header-links .cart-qty",
//    ".header-links .wishlist-qty",
//    "#flyout-cart", localized_data);
$(window).resize(function () {
    window.matchMedia("(max-width: 1000px)")
        .matches && ($(".search-icon").click(function () {
            $(".header-menu.mobile").css("display", "none")
        }), $(".bg-sg").click(function () {
            $(".header-menu.mobile").css("display", "block")
        }))
});
$(window).resize(function () {
    window.matchMedia("(min-width: 1001px)")
        .matches && ($(".search-icon").click(function () {
            $(".header-menu.mobile").css("display", "none")
        }), $(".bg-sg").click(function () {
            $(".header-menu.mobile").css("display", "none")
        }))
});
$(".search-icon").click(function () {
    $(".search-box").css("display", "block");
    $(".bg-sg").css("display", "block");
    $(".header .header-lower").css("max-width", "100%");
    $(".admin-header-links").css("display", "none");
    $("input#small-searchterms").focus()
});
$(".bg-sg").click(function () {
    $(".search-box").css("display", "none");
    $(".bg-sg").css("display", "none");
    $(".header .header-lower").css("max-width", "1200px");
    $(".admin-header-links").css("display", "block")
});
$(".login-icon").hover(function () {
    $(".account-desktop").css("display", "block");
    $(".account-desktop").css("tr", "block");

}, function () {
    $(".account-desktop").css("display", "none");
});


$(".account-desktop").hover(function () {
    $(this).css("display", "block")
}, function () {
    $(".account-desktop").css("display", "none")
});

$("ul.top-menu.mobile .header-links a")
    .hasClass("ico-login") && $(".block.block-account-navigation.customer-navigation")
        .css("display", "none");
//$(".popup-remind-search .check_close").click(function () {
//    localStorage.setItem("SearchPopup", "0");
//    $(".popup-remind-search").hide()
//});

//$(document).ready(function () {
//    var n = localStorage.getItem("SearchPopup");
//    (n == null || n == undefined || n != "0") && $(".popup-remind-search").show();
//    $(".banner_cate_slick").slick({
//        autoplay: !0,
//        autoplaySpeed: 7e3,
//        dots: !0,
//        slidesToShow: 1,
//        slidesToScroll: 1,
//        infinite: !0
//    });
//    $(".banner_home-page.desktop").show()
//})
//$(document).ready(function () {
//    $("#backTop").backTop();
//    $('[data-toggle="tooltip"]').tooltip({ placement: "bottom" })
//})
function newsletter_subscribe(n) {
    var i = $("#subscribe-loading-progress"), t;
    i.show(); t = {
        subscribe: n,
        email: $("#newsletter-email").val()
    };
    addAntiForgeryToken(t);
    $.ajax({
        cache: !1,
        type: "POST",
        url: "/subscribenewsletter",
        data: t, success: function (n) {
            $("#newsletter-result-block").html(n.Result);
            n.Success ? ($("#newsletter-subscribe-block").hide(),
                $("#newsletter-result-block").show()) : $("#newsletter-result-block").fadeIn("slow").delay(2e3).fadeOut("slow")
        },
        error: function () {
            alert("Failed to subscribe.")
        }, complete: function () { i.hide() }
    })
}
$(document).ready(function () {
    $("#newsletter-subscribe-button").on("click", function () {
        newsletter_subscribe("true")
    });
    $("#newsletter-email").on("keydown", function (n) { if (n.keyCode == 13) return $("#newsletter-subscribe-button").trigger("click"), !1 })
})
$(document).ready(function () {
    $(".footer-block .title")
        .on("click", function () {
            var n = window,
                t = "inner", i;
            "innerWidth" in window || (
                t = "client", n = document.documentElement || document.body);
            i = { width: n[t + "Width"], height: n[t + "Height"] };
            i.width < 769 && $(this).siblings(".list").slideToggle("slow")
        })
});
//$(".chat-box_toggle")
//    .on("click", function () {
//        $(this)
//            .toggleClass("active")
//            .siblings(".all_chat-box")
//            .toggle(200, "swing");
//        $(".items-chat-icon")
//            .animate({ opacity: "1" }, 1e3);
//        $("#backTop").css("display", "none")
//    })
$(document).ready(function () {
    $(".block .title").on("click", function () {
        var n = window,
            t = "inner", i;
        "innerWidth" in window || (
            t = "client",
            n = document.documentElement || document.body);
        i = { width: n[t + "Width"], height: n[t + "Height"] };
        i.width < 1001 && $(this).siblings(".listbox").slideToggle("slow")
    })
})
//(function (n, t, i, r, u) {
//    n[r] = n[r] || [];
//    n[r].push({
//        "gtm.start": (new Date).getTime(), event: "gtm.js"
//    });
//    var e = t.getElementsByTagName(i)[0],
//        f = t.createElement(i), o = r != "dataLayer" ? "&l=" + r : "";
//    f.async = !0;
//    f.src = "https://www.googletagmanager.com/gtm.js?id=" + u + o;
//    e.parentNode.insertBefore(f, e)
//})
//(window, document, "script", "dataLayer", "GTM-WXNN4ZT")
function setGlobalLoading(n) {
    var t = $(".global-busy");
    n ? ($("body").addClass("loading-open"),
        t.show()) : ($("body").removeClass("loading-open"),
            t.hide())
} $(".once-submit-button").on("click", function () {
    $(this).disabled = !0; setGlobalLoading(!0)
})
//!function (n, t, i, r, u) {
//    var f, e, o, s; n[r] || (n._sbzaccid = u, n[r] = function () {
//        n[r].q.push(arguments)
//    },
//        n[r].q = [], n[r]("setAccount", u),
//        o = ["widget.subiz.net", "storage.googleapis" + (e = ".com"),
//            "app.sbz.workers.dev",
//            r + "a" + (f = function (n, t) {
//                var i = t <= 6 ? 5 : f(n, t - 1) + f(n, t - 3);
//                return n !== t ? i : i.toString(32)
//            })(20, 20) + e, r + "b" + f(30, 30) + e, r + "c" + f(40, 40) + e],
//        (s = function (r) {
//            var f, e;
//            n._subiz_init_2094850928430 || o[r] && (f = t.createElement(i),
//                e = t.getElementsByTagName(i)[0],
//                f.async = 1,
//                f.src = "https://" + o[r] + "/sbz/app.js?accid=" + u,
//                e.parentNode.insertBefore(f, e),
//                setTimeout(s, 2e3, r + 1))
//        })(0))
//}(window, document, "script", "subiz", "acrymzsitjyjmoduuvgx")
