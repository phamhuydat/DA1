using App.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.DataSeeders
{
	public static class AppBranchSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppBranch> builder)
		{
			//var now = new DateTime(year: 2024, month: 04, day: 27);
			var now = DateTime.Now;

			var groupName = "";

			#region Data của địa chỉ tại HCM
			groupName = "Chi Nhánh Hồ Chí Minh";
			builder.HasData(
				new AppBranch
				{
					Id = 1,
					GroupName = groupName,
					Address = "Quận 10 - 561 Sư Vạn Hạnh, Phường 13.",
					CreatedDate = now
				},
				new AppBranch
				{
					Id = 2,
					GroupName = groupName,
					Address = "Quận Tân Bình - 136 Nguyễn Hồng Đào, Phường 14.",
					CreatedDate = now
				},
				new AppBranch
				{
					Id = 3,
					GroupName = groupName,
					Address = "Quận 1 - The New Playground 26 Lý Tự Trọng, Phường Bến Nghé.",
					CreatedDate = now
				},
				new AppBranch
				{
					Id = 4,
					GroupName = groupName,
					Address = "Quận 1 - Central Market 4 Phạm Ngũ Lão, Phường Phạm Ngũ Lão.",
					CreatedDate = now
				},
				new AppBranch
				{
					Id = 5,
					GroupName = groupName,
					Address = "Quận Gò Vấp - 41 Quang Trung, Phường 3.",
					CreatedDate = now
				});
			#endregion

			#region Chi nhánh tại Cần Thơ
			groupName = "Chi Nhánh Cần Thơ";
			builder.HasData(
				new AppBranch
				{
					Id = 6,
					GroupName = groupName,
					Address = "Quận Ninh Kiều - 52 Mậu Thân, Phường An Phú.",
					CreatedDate = now
				});
			#endregion

			#region Chi nhánh Biên Hòa
			groupName = "Chi Nhánh Biên Hòa";
			builder.HasData(
				new AppBranch
				{
					Id = 7,
					GroupName = groupName,
					Address = "TP.Biên Hòa - 151A Phan Trung, Phường Tân Mai.",
					CreatedDate = now
				});
			#endregion

			#region Chi nhánh Hà Nội
			groupName = "Chi Nhánh Hà Nội";
			builder.HasData(
				new AppBranch
				{
					Id = 8,
					GroupName = groupName,
					Address = "Đống Đa - 49-51 Hồ Đắc Di, Phường Nam Đồng.",
					CreatedDate = now
				});
			#endregion
		}
	}
}
