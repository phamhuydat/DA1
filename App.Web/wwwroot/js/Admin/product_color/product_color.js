$(document).ready(function () {
	$(".js-update-colorName").on("click", function (ev) {
		const idColor = $(this).attr('data-id');
		const modalUpdate = $("#modalUpdate");
		$.get(`/Admin/MstProductColor/GetDataForUpdate/${idColor}`, function (res) {
			if (res) {
				modalUpdate.find(".field-validation-error").html('');
				modalUpdate.find("#Id").val(res.id);
				modalUpdate.find("#ColorNameUpdate").val(res.colorName);
			}
		});
	});
});