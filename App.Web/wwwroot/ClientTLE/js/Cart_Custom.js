
function setCookie(cname, cvalue, exdays) {
    var d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    var expires = "expires=" + d.toUTCString();
    document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
}

function getCookie(cname) {
    var name = cname + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}

window.addEventListener("load", () => {
    recountCart();
    $(".voucher").click((ev) => {
        ev.preventDefault();
        var voucher = $(".discount-coupon-code").val();
        $.post("/cart/addVoucher", { voucher }, (res) => {
            if (res == false) {
                //new AWN().alert('Không tìm thấy mã giảm giá', { durations: { success: 0 }, labels: { alert: "Thất bại" } });
                $(".dis-voucher").addClass("d-none");
                $(".text-error-voucher").text("(*) Không tìm thấy Voucher.");
                var totalprice = $(".value-summary.total-price").text();
                $(".value-summary.new").text(totalprice.toLocaleString("en-US"));
                allprice();
                return;
            }

            $(".dis-voucher").removeClass("d-none");
            $(".text-error-voucher").text("");
            $(".useVoucher").val(voucher);
            if (res.percent !== null) {
                var totalprice = $(".value-summary.total-price").text();
                var text = splittotal(totalprice);
                var pay = parseFloat(text.replace(/,/g, '')) - ((parseFloat(text.replace(/,/g, '')) * res.percent) / 100);
                var pricevoucher = res.percent + "%";
                $(".price-voucher").text(pricevoucher)
                $(".value-summary.new").text(pay.toLocaleString("en-US"));
            }
            else if (res.price != null) {
                var totalprice = $(".value-summary.total-price").text();
                var text = splittotal(totalprice);
                var pay = parseFloat(text.replace(/,/g, '')) - Number(res.price);
                var pricevoucher = res.price.toLocaleString("en-US")
                $(".price-voucher").text(pricevoucher + " " + "đ")
                $(".value-summary.new").text(pay.toLocaleString("en-US"))
                console.log(pay);
            }
            allprice();
            //new AWN().success('Thêm mã giảm giá thành công', { durations: { success: 0 }, labels: { success: " thành công" } })
        })
    })
})

function splittotal(text) {
    var total = "";
    text = text.split(" ")[0];
    //text = text.split(" ")[0];
    for (let i = 0; i < text.length; i++) {
        total = total + text[i];
    }
    return total
}

function updateProductCount(isUp = true, quan = 1) {
    var point = document.querySelector(".cart-shopping .cart-qty");
    var num = Number(point.innerText);
    num = isUp ? quan + num : num - quan;
    point.innerText = num;
}

function setProductCount(val = 1) {
    var point = $(`<span class="cart-qty color">${val}</span>`);
    var cart = $("a.cart-shopping");
    cart.find(".cart-qty").remove();
    cart.append(point);
}

function hasProductCount() {
    var point = $(".cart-shopping .cart-qty");
    return point.length > 0;
}

function addToCart(productId, idDetail) {
    var cName = "prodcutcart_" + productId + "_" + idDetail;
    var quan = 1;   // Chỉ thêm vào 1 sản phẩm mỗi lần click
    var expDay = 30;    // Giỏ hàng tồn tại 1 tháng
    // setCookie(cName, 1, -1);
    if (getCookie(cName)) {
        setCookie(cName, Number(getCookie(cName)) + quan, expDay);
    }
    else {
        setCookie(cName, quan, expDay);
    }
    recountCart();
    var totalEle = $(".value-summary");
    if (!totalEle.length) {
        // ở trang giỏ hàng thì không show thông báo
        notyf.success("Đã thêm sản phẩm này vào giỏ hàng");
    }
}

function deleteProductFromCart(evt, id, idDetail) {
    setCookie("prodcutcart_" + id + "_" + idDetail, 0, -1);
    $(evt.target).closest(".append-item").remove();
    recountCart();
    setTimeout(() => {
        $(".append-item .cart-no").each(function (i, ele) {
            $(ele).text(i + 1);
        });
    }, 0);
}

function removeFromCart(productId, idDetail) {
    var cName = "prodcutcart_" + productId + "_" + idDetail;
    var quan = -1;   // Giảm 1 sản phẩm mỗi lần click
    var expDay = 30;    // Giỏ hàng tồn tại 1 tháng
    if (Number(getCookie(cName)) <= 1) {
        return;
    }
    if (getCookie(cName)) {
        setCookie(cName, Number(getCookie(cName)) + quan, expDay);
    }
    recountCart();
}


function recountCart() {
    var cookie = document.cookie.split(";");
    var numOfProduct = 0;
    for (let i = 0; i < cookie.length; i++) {
        if (cookie[i].indexOf("prodcutcart_") >= 0) {
            numOfProduct += Number(cookie[i].split("=").slice(-1)[0]);
        }
    }
    setProductCount(numOfProduct);
    var totalEle = $(".value-summary");
    if (totalEle.length) {
        setTimeout(() => {
            let prices = $(".cart-price[data-price]");
            let total = 0;
            prices.each(function () {
                let quan = Number($(this).closest('td').next().find("input.input-quantity").val());
                //let quan = Number($(this).prev().find("input").val());
                total += quan * Number($(this).attr("data-price"));
            });
            totalEle.text(total.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",") + " " + "đ");
            allprice();
        }, 100);
    }
    if (numOfProduct <= 0) {
        $(".cart-shopping .cart-qty").remove();
    }
    allprice();
}

function updateInput(ev, productId, idDetail) {
    $(ev.target)
        .closest(".cart-quantity")
        .find("input")
        .val(getCookie("prodcutcart_" + productId + "_" + idDetail));

}

$(function () {
    recountCart();
});

function buyNow(evt, productId) {
    var idDetail = $("#pro-detail-id").val();

    var check = $("#new-price-discount").text();
    if (check == "Hêt hàng" || idDetail == "") {
        notyf.error("Hiện tại sản phẩm đang hết hàng vui lòng thử lại");
        setTimeout(function () {
            location.reload();
        }, 2000);
    }
    else {
        addToCart(productId, idDetail);
        setTimeout(function () {
            location.reload();
        }, 2000);
        evt.preventDefault();
    }

}


function allprice() {
    var postprice = $(".totalMoney");
    var price = $(".value-summary.new").text();
    var temp = splittotal(price);
    postprice.val(temp)
}