$(document).ready(function () {
	const day = $(".input-day-report").val();
	getDataReport();

	$(".btn-submit-report").click(ev => {
		const day = $(".input-day-report").val();
		getDataReport(day);
	});
});

const getDataReport = () => {
	$.get("/admin/home/report", function (res) {
		const listDate = [];
		const listMoney = [];
		console.log(res);
		res.forEach(item => {
			listDate.push("Tháng " + item.date);
			listMoney.push(item.tongTien);
		});

		$("#myChart").remove();
		$(".container-canvas").append('<canvas id="myChart" style="width: 100%; height: 500px;"></canvas>');
		const ctx = document.getElementById('myChart');
		const myChart = new Chart(ctx, {
			type: 'line',
			data: {
				labels: [...listDate],
				datasets: [{
					label: 'Tổng thu nhập',
					data: [...listMoney],
					backgroundColor: [
						'rgba(255, 99, 132, 0.2)',
						'rgba(54, 162, 235, 0.2)',
						'rgba(255, 206, 86, 0.2)',
						'rgba(75, 192, 192, 0.2)',
						'rgba(153, 102, 255, 0.2)',
						'rgba(255, 159, 64, 0.2)'
					],
					borderColor: [
						'rgba(255, 99, 132, 1)',
						'rgba(54, 162, 235, 1)',
						'rgba(255, 206, 86, 1)',
						'rgba(75, 192, 192, 1)',
						'rgba(153, 102, 255, 1)',
						'rgba(255, 159, 64, 1)'
					],
					borderWidth: 1,
					pointRadius: 10,
					pointHoverRadius: 15
				}]
			},
			options: {
				responsive: true,
			}
		});
	});
}