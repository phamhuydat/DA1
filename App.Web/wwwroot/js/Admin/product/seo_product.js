$(document).ready(function () {
	$(".btn-getSEO").on("click", function (ev) {
		const titleVal = $("#ProductName").val();
		let descriptionVal = $("#Description").val();
		const pathImage = $(".image-review")[0];
		const pathImageVal = $(pathImage).attr('src');

		let regex = /(<([^>]+)>)/gi;
		const desVal = descriptionVal.replace(regex, "");

		if (titleVal == "" && summaryVal == "" && typeof pathImageVal == "undefined") {
			Toast.danger("Chưa có thông tin để lấy!");
			return;
		}

		$("#SEOTitle").val(titleVal);
		$("#SEODescription").val(desVal.slice(0, 200));
		$("#SEOImagePath").val(pathImageVal);
	});
});