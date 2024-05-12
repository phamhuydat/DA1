$(document).ready(function () {
	$(".btn-getSEO").on("click", function (ev) {
		const titleVal = $("#Title").val();
		const summaryVal = $("#Summary").val();
		const pathImageVal = $(".image-review").attr('src');

		if (titleVal == "" && summaryVal == "" && typeof pathImageVal == "undefined") {
			Toast.danger("Chưa có thông tin để lấy!");
			return;
		}

		$("#SEOTitle").val(titleVal);
		$("#SEODescription").val(summaryVal);
		$("#SEOImagePath").val(pathImageVal);
	});
});