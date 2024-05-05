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
                    Title = "Tin tức Apple",
                    CreatedDate = now
                },
                new AppNewsCategory
                {
                    Title = "Bài viết Review",
                    CreatedDate = now
                },
                new AppNewsCategory
                {
                    Title = "Khám phá",
                    CreatedDate = now
                },
                new AppNewsCategory
                {
                    Title = "Thủ thuật",
                    CreatedDate = now
                },
                new AppNewsCategory
                {
                    Title = "Khuyến mãi",
                    CreatedDate = now
                },
                new AppNewsCategory
                {
                    Title = "Tin khác",
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
