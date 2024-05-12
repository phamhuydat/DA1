$(document).ready(function () {
	$(".js-update-size").on("click", function (ev) {
		const idColor = $(this).attr('data-id');
		const modalUpdate = $("#modalUpdate");
		$.get(`/Admin/MstProductSize/GetDataForUpdate/${idColor}`, function (res) {
			if (res) {
				modalUpdate.find(".field-validation-error").html('');
				modalUpdate.find("#Id").val(res.id);
				modalUpdate.find("#SizeCodeUpdate").val(res.sizeCode);
			}
		});
	});
});