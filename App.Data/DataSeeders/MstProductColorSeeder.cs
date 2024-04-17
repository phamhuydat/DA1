using App.Data.Entities.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.DataSeeders
{
	public static class MstProductColorSeeder
	{
		public static void SeedData(this EntityTypeBuilder<MstProductColor> builder)
		{
			var now = DateTime.Now;
			builder.HasData(
				new MstProductColor
				{
					Id = 1,
					ColorName = "Red",
					CssColor = "#FF0000",
					CreatedDate = now
				},
				new MstProductColor
				{
					Id = 2,
					ColorName = "Black",
					CssColor = "#000000",
					CreatedDate = now
				},
				new MstProductColor
				{
					Id = 3,
					ColorName = "Blue",
					CssColor = "#0000FF",
					CreatedDate = now
				});
		}
	}
}
