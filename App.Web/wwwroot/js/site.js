$(function () {
    // tinnq
    // Tự động ẩn cảnh báo sau 4 giây
    $(".alert.js-alert").delay(4000).slideUp(300, function () {
        $(this).alert('close');
    });

    $(".bs-autocomplete").bsautocomplete();
});

$(document).on("click", ".js-delete-confirm", function (ev) {
    ev.preventDefault();
    let btnDelete = $(this);
    let msg = btnDelete.data('msg');
    let mode = btnDelete.data('mode');
    if (!msg) {
        msg = 'Xác nhận xóa?';
    }

    confirm(msg, () => {
        if (mode == "submit") {
            let form = btnDelete.closest("form");
            if (form.valid()) {
                form.submit();
            }
        }
        else {
            location.href = $(this).attr("href");
        }
    });
});


// Các hàm liên quan xóa nhiều
$("#chkAll").click(function () {
    var isCheckAll = $(this).prop('checked');
    // Tránh trường hợp count sai
    $('td.js-col-checkbox > input').each(function (i, item) {
        var statusBefore = item.checked;
        item.checked = isCheckAll;
        if (item.checked != statusBefore) {
            $(item).change();
        }
    });
});


$("#chkAllowBulkDel").change(function (ev) {
    var isCheck = $(this).is(":checked");
    if (isCheck) {
        $(".js-col-checkbox").removeClass("d-none");
        $("#btnBulkDel").removeClass("d-none");
    } else {
        $(".js-col-checkbox").addClass("d-none");
        $("#btnBulkDel").addClass("d-none");
    }
});

var chkCount = $("td.js-col-checkbox > input").length;
$("td.js-col-checkbox > input").change(function (ev) {
    var isCheck = $(this).is(":checked");
    var delCountEle = $("#delCount");
    var delCountVal = Number(delCountEle.text());
    if (isCheck) {
        delCountVal++;
    } else {
        delCountVal--;
    }
    delCountEle.text(delCountVal);
    $("#chkAll").prop('checked', delCountVal == chkCount);
});

$("#btnBulkDel").click(function (ev) {
    var delCountEle = $("#delCount");
    var delCountVal = Number(delCountEle.text());
    var keyword = $(this).data("keyword");
    var url = $(this).data("url");
    if (!delCountVal) {
        alert(`Chưa chọn ${keyword} để xóa`);
        return;
    }
    confirm(`Xác nhận xóa hàng loạt ${delCountVal} ${keyword}?`, function () {
        var ids = $("td.js-col-checkbox > input:checked").toArray().map(function (i) {
            return i.getAttribute("data-id");
        });
        url = url + "?ids=" + ids.join("&ids=");
        location.assign(url);
    });
});
