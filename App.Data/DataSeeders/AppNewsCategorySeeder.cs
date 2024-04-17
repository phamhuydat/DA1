using App.Data.Entities;
using App.Share.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.DataSeeders
{
	public static class AppNewsCategorySeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppNewsCategory> builder)
		{
			var now = DateTime.Now;
			var dataCategories = new AppNewsCategory[]
			{
				new AppNewsCategory
				{
					Title = "Sản phẩm",
					CreatedDate = now
				},
				new AppNewsCategory
				{
					Title = "Bộ sưu tập",
					CreatedDate = now
				},
				new AppNewsCategory
				{
					Title = "	Kết hợp",
					CreatedDate = now
				},
				new AppNewsCategory
				{
					Title = "Sản phẩm mới",
					CreatedDate = now
				}
			};
			for (int i = 0; i < dataCategories.Length; i++)
			{
				dataCategories[i].Id = i + 1;
				dataCategories[i].Slug = dataCategories[i].Title.Slugify();
			}
			builder.HasData(dataCategories);
		}
	}
}
