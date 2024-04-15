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
					CreatedDate = now
				},
				new MstProductColor
				{
					Id = 2,
					ColorName = "Orange",
					CreatedDate = now
				},
				new MstProductColor
				{
					Id = 3,
					ColorName = "Yellow",
					CreatedDate = now
				},
				new MstProductColor
				{
					Id = 4,
					ColorName = "Greem",
					CreatedDate = now
				},
				new MstProductColor
				{
					Id = 5,
					ColorName = "Blue",
					CreatedDate = now
				},
				new MstProductColor
				{
					Id = 6,
					ColorName = "Purple",
					CreatedDate = now
				},
				new MstProductColor
				{
					Id = 7,
					ColorName = "Pink",
					CreatedDate = now
				},
				new MstProductColor
				{
					Id = 8,
					ColorName = "Brown",
					CreatedDate = now
				},
				new MstProductColor
				{
					Id = 9,
					ColorName = "White",
					CreatedDate = now
				},
				new MstProductColor
				{
					Id = 10,
					ColorName = "Grey",
					CreatedDate = now
				},
				new MstProductColor
				{
					Id = 11,
					ColorName = "Black",
					CreatedDate = now
				},
				new MstProductColor
				{
					Id = 12,
					ColorName = "Multi-Color",
					CreatedDate = now
				});
		}
	}
}
