$(document).ready(function () {

    const autocompleteOrderStatus = $("#autocompleteOrderStatus").bsautocomplete();
    const orderStatus = {
        1: "border border-dark",
        2: "bg-info",
        3: "bg-success",
        4: "bg-dark"
    }
    let orderIdGlobal = 0;
    $(".btn-update-status").on("click", function (ev) {
        const modalUpdateStatus = $("#modalUpdateStatus");
        const orderId = $(this).attr("data-order-id");
        const statusId = $(this).attr('data-status-id');
        orderIdGlobal = orderId;
        modalUpdateStatus.find(".modal-status-title").text(`Cập nhật trạng thái đơn hàng #${orderIdGlobal}`);
        autocompleteOrderStatus.autocompleteVal(statusId);
    });

    $("#modalUpdateStatus .btn-submit-status").on("click", function (ev) {
        const statusId = $("#modalUpdateStatus .select-status").val();
        const data = {
            id: orderIdGlobal,
            statusId
        };
        $.post("/Admin/AppOrder/UpdateOrderStatus", data, function (res) {
            if (res.statusResult) {
                Toast.success(`Cập nhật trạng thái cho đơn hàng #${orderIdGlobal} thành công!`);
                $(`.btn-status-${orderIdGlobal}`).attr('data-status-id', statusId);
                $(`.status-${orderIdGlobal}`)
                    .text(res.orderStatusName)
                    .removeClass(`${orderStatus[1]} ${orderStatus[2]} ${orderStatus[3]} ${orderStatus[4]}`)
                    .addClass(orderStatus[statusId]);
                $("#modalUpdateStatus").modal("hide");
                $('.modal-backdrop').remove();
                $('body').removeClass("modal-open");
                if (statusId == 3 || statusId == 4) {
                    $(`.btn-update-status[data-status-id=${statusId}]`).addClass('invisible');
                }
                autocompleteOrderStatus.autocompleteVal(0);
            }
        });
    });
});
