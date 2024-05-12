$(document).ready(function () {
	$(".js-update-branch").on("click", function (ev) {
		const idBranch = $(this).attr('data-id');
		const modalUpdate = $("#modalUpdate");
		$.get(`/Admin/AppBranch/GetDataForUpdate/${idBranch}`, function (res) {
			if (res) {
				modalUpdate.find("#Id").val(res.id);
				modalUpdate.find("#AddressUpdate").val(res.address);
			}
		});
	});
});