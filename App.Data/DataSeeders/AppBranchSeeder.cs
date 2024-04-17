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
			var now = DateTime.Now;
			var groupName = "";

			#region Data tại Cần Thơ
			groupName = "Thành Phố Cần Thơ";
			builder.HasData(
				new AppBranch
				{
					Id = 1,
					GroupName = groupName,
					Address = "91 Trần Văn Khéo, Cái Khế, Ninh Kiều, Cần Thơ",
					IdMap = "113.188.249.73",
					CreatedDate = now
				});
			#endregion
		}
	}
}
