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

//$("ul.top-menu.mobile .header-links a")
//    .hasClass("ico-login") && $(".block.block-account-navigation.customer-navigation")
//        .css("display", "none");


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

function setGlobalLoading(n) {
    var t = $(".global-busy");
    n ? ($("body").addClass("loading-open"),
        t.show()) : ($("body").removeClass("loading-open"),
            t.hide())
} $(".once-submit-button").on("click", function () {
    $(this).disabled = !0; setGlobalLoading(!0)
})

$("#sl_bill_company").on("click", function () {
    $(".answer").toggle(this.checked)
}); $(".items_international").hide();
$(".items_installment").hide();
