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

function updateProductCount(isUp = true, quan = 1) {
    var point = document.querySelector(".cart-shopping .cart-text");
    var num = Number(point.innerText);
    num = isUp ? quan + num : num - quan;
    point.innerText = num;
}

function setProductCount(val = 1) {
    var point = $(`<span class="cart-text color">${val}</span>`);
    var cart = $("a.cart-shopping");
    cart.find(".cart-text").remove();
    cart.append(point);
}

function hasProductCount() {
    var point = $(".cart-shopping .cart-text");
    return point.length > 0;
}

function addToCart(productId) {
    var cName = "sp_" + productId;
    var quan = 1;   // Chỉ thêm vào 1 sản phẩm mỗi lần click
    var expDay = 30;    // Giỏ hàng tồn tại 1 tháng
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

function deleteProductFromCart(evt, id) {
    setCookie("sp_" + id, 0, -1);
    $(evt.target).closest(".append-item").remove();
    recountCart();
    setTimeout(() => {
        $(".append-item .cart-no").each(function (i, ele) {
            $(ele).text(i + 1);
        });
    }, 0);
}

function removeFromCart(productId) {
    var cName = "sp_" + productId;
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
        if (cookie[i].indexOf("sp_") >= 0) {
            numOfProduct += Number(cookie[i].split("=").slice(-1)[0]);
        }
    }
    setProductCount(numOfProduct);
    var totalEle = $(".cart-total");
    if (totalEle.length) {
        setTimeout(() => {
            let prices = $(".cart-price[data-price]");
            let total = 0;
            prices.each(function () {
                let quan = Number($(this).prev().find("input").val());
                total += quan * Number($(this).attr("data-price"));
            });
            totalEle.text(total.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
        }, 100);
    }
    if (numOfProduct <= 0) {
        $(".cart-shopping .cart-text").remove();
    }
}

const getcart = () => {
    const allCookie = document.cookie;
    const cookieArray = allCookie.split(';');

    var newArrayCookie = [];
    for (var i = 0; i < cookieArray.length; i++) {
        if (cookieArray[i].indexOf("products_") != -1) {
            newArrayCookie.push(parseInt(cookieArray[i].replace("products_", "").split("=")[0].trim()));
        }
    };
    const tbody = document.querySelector("#cart-body");
    tbody.innerHTML = "";
    if (newArrayCookie.length == 0) {

    }
    else {
        $.post("/cart/getProduct", { listid: newArrayCookie }, (data) => {
            if (data.length > 0) {
                const tbody = document.querySelector("#cart-body");
                tbody.innerHTML = "";
                for (var i = 0; i < data.length; i++) {
                    if (data[i] != ",") {
                        console.log(data[i])
                        const { productName, price, pathImgP, id, option, size, color } = data[i];
                        var cookies = getCookie("products_" + id)
                        var stringaray = cookies.split("-");
                        var html = ``;


                        //                  var html = `<tr>
                        //                  <td class="align-middle">
                        //                      <img src="/img/products/${pathImgP}" alt="" style="width: 50px;">
                        //                      <div style="width: 90px;height: 30px;text-overflow:ellipsis;overflow:hidden"> ${productName} 
                        //                      </div>
                        //                  </td>
                        //                  <td class="align-middle">${price.toLocaleString("de-DE")}</td>
                        //                  <td class="align-middle price" hidden>${price}</td>
                        //<td class="align-middle"> ${color}</td> 
                        //<td class="align-middle"> ${size} </td> 
                        //                  <td class="align-middle">
                        //                      <div class="input-group quantity mx-auto" style="width: 100px;">
                        //                          <div class="input-group-btn">
                        //                              <a data-id="${id}" class="btn btn-sm btn-primary btn-minus giam">
                        //                                  -
                        //                              </a>
                        //                          </div>
                        //                          <input type="text" class="form-control form-control-sm bg-secondary border-0 text-center amount" value="${stringaray[0]}">
                        //                          <div class="input-group-btn">
                        //                              <a data-id="${id}" class="btn btn-sm btn-primary btn-plus tang">
                        //                                  +
                        //                              </a>
                        //                          </div>
                        //                      </div>
                        //                  </td>
                        //                  <td class="align-middle total"></td>
                        //                  <td class="align-middle"><a data-id="${id}" class="btn btn-sm btn-danger removecookies">X</i></a></td>
                        //              </tr>`;
                        tbody.insertAdjacentHTML('beforeend', html);
                    }
                }
                totalprice()
                allprice()
            }
        }).then(function () {
            $('.tang').on('click', function (ev) {
                ev.preventDefault();

                var btn = ev.target;
                var div = btn.parentElement;
                var td = div.parentElement;
                var input = td.querySelector("input");

                var value = input.value;
                var value1 = Number(value) + 1;

                input.value = value1;



                var id = ev.currentTarget.getAttribute("data-id")
                var cookies = getCookie("products_" + id)
                var stringaray = cookies.split("-");
                stringaray[0] = value1;
                var string = stringaray[0] + "-" + stringaray[1] + "-" + stringaray[2]
                setCookie("products_" + id, string, 200)
                totalprice()
                allprice()
            })
            $('.giam').on('click', function (ev) {
                ev.preventDefault();
                var btn = ev.target;
                var div = btn.parentElement;
                var td = div.parentElement;
                var input = td.querySelector("input");
                var value = input.value;
                if (value === "1") {
                    return;
                }
                var value1 = Number(value) - 1;

                input.value = value1;

                var id = ev.currentTarget.getAttribute("data-id")
                var cookies = getCookie("products_" + id)
                var stringaray = cookies.split("-");
                stringaray[0] = value1;
                var string = stringaray[0] + "-" + stringaray[1] + "-" + stringaray[2]
                setCookie("products_" + id, string, 200)
                totalprice()
                allprice()
            })
            $(".removecookies").on("click", (ev) => {
                ev.preventDefault();
                var id = ev.target.getAttribute("data-id")
                console.log("đã vô đât", id);
                setCookie("products_" + id, "", -1);
                getcart();
                allprice()
            })
        })
    }
}

window.addEventListener("load", () => {
    getcart();
    countproduct();
    $(".voucher").click((ev) => {
        ev.preventDefault();
        var voucher = $(".discount-coupon-code").val();
        $.post("/cart/addVoucher", { voucher }, (res) => {
            if (res == false) {
                new AWN().alert('Không tìm thấy mã giảm giá', { durations: { success: 0 }, labels: { alert: "Thất bại" } })
                return;
            }
            $(".useVoucher").val(voucher)
            if (res.percent !== null) {
                var totalprice = $(".total-price").text();
                var text = splittotal(totalprice);
                var pay = Number(text) - ((Number(text) * res.percent) / 100);
                var pricevoucher = res.percent + "%";
                $(".price-voucher").text(pricevoucher)
                $(".pay").text(pay.toLocaleString("de-DE"))
            } else if (res.price != null) {
                var totalprice = $(".total-price").text();
                var text = splittotal(totalprice);
                var pay = Number(text) - Number(res.price);
                var pricevoucher = res.price.toLocaleString("de-DE")
                $(".price-voucher").text(pricevoucher)
                $(".pay").text(pay.toLocaleString("de-DE"))
            }
            allprice()
            new AWN().success('Thêm mã giảm giá thành công', { durations: { success: 0 }, labels: { success: " thành công" } })
        })
    })
})
function totalprice() {
    var price = document.querySelectorAll("tbody tr")
    var allprice = 0;
    if (price.length != 0) {
        for (var i = 0; i < price.length; i++) {
            var tong = 0;
            var gia = price[i].querySelector(".price").innerHTML;
            var soluong = price[i].querySelector("input").value;
            tong = (gia * soluong)
            allprice += tong;
            var total = price[i].querySelector(".total");
            total.innerHTML = tong.toLocaleString("de-DE");
        }
    }
    $(".total-price").text(allprice.toLocaleString("de-DE"))
    $(".pay").text(allprice.toLocaleString("de-DE"))
}
function allprice() {
    var postprice = $(".totalMoney");
    var price = $(".pay").text();
    var temp = splittotal(price)
    postprice.val(temp)
}



function updateInput(ev, productId) {
    $(ev.target)
        .closest(".cart-quantity")
        .find("input")
        .val(getCookie("sp_" + productId));
}

$(function () {
    recountCart();
});

function buyNow(evt, productId) {
    evt.preventDefault();
    addToCart(productId);
    location.href = $(evt.currentTarget).attr("href");
}