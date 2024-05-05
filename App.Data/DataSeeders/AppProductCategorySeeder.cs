using App.Data.Entities;
using App.Share.Consts;
using App.Share.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.DataSeeders
{
    public static class AppProductCategorySeeder
    {
        public static void SeedData(this EntityTypeBuilder<AppProductCategory> builder)
        {
            var now = DateTime.Now;
            // Tạo danh mục cấp 1, Id tăng từ 1 => Length
            var cateLevel1 = new AppProductCategory[] {
                new AppProductCategory{
                    Id = 1,
                    Name = "Iphone"
                },
                new AppProductCategory{
                    Id = 2,
                    Name = "IPad"
                },
                new AppProductCategory{
                    Id = 3,
                    Name = "Mac"
                },
                new AppProductCategory{
                    Id = 4,
                    Name = "Watch"
                },
                new AppProductCategory{
                    Id= 5,
                    Name = "Phụ kiện"
                },
            };
            for (int i = 0; i < cateLevel1.Length; i++)
            {
                cateLevel1[i].Id = i + 1;
                cateLevel1[i].Slug = cateLevel1[i].Name.Slugify();
                cateLevel1[i].CateLevel = 1;
                cateLevel1[i].HasChild = true;
                cateLevel1[i].CreatedDate = now;
                cateLevel1[i].UpdatedDate = now;
            }
            builder.HasData(cateLevel1);

            // Tạo danh mục cấp 2
            var cateLevel2 = new AppProductCategory[] {
				// Phụ kiện
				new AppProductCategory{
                    ParentCateId = 5,
                    Name = "Chuột/ Bàn phím"
                },
                new AppProductCategory{
                    ParentCateId = 5,
                    Name = "Óp lưng"
                },
                new AppProductCategory{
                    ParentCateId = 5,
                    Name = "Balo/ Túi chống sốc"
                },
                new AppProductCategory{
                    ParentCateId = 5,
                    Name = "Ốp lưng"
                },
                new AppProductCategory{
                    ParentCateId = 5,
                    Name = "Kính cường lực"
                },
                new AppProductCategory{
                    ParentCateId = 4,
                    Name = "Apple Watch Ultra 2"
                },

				// Giải pháp chiếu sáng
				new AppProductCategory{
                    ParentCateId = 4,
                    Name = "Apple Watch SE"
                },
                new AppProductCategory{
                    ParentCateId = 3,
                    Name = "MacBook Pro"
                },
                new AppProductCategory{
                    ParentCateId = 3,
                    Name = "MacBook Air"
                },
                new AppProductCategory{
                    ParentCateId = 3,
                    Name = "MacBook Pro M1"
                },
                new AppProductCategory{
                    ParentCateId = 3,
                    Name = "MacBook Pro M2"
                },
                new AppProductCategory{
                    ParentCateId = 3,
                    Name = "IMac"
                },

				// Sản phẩm trang trí
				new AppProductCategory{
                    ParentCateId = 2,
                    Name = "IPad Pro M1"
                },
                new AppProductCategory{
                    ParentCateId = 2,
                    Name = "IPad Pro M2"
                },
                new AppProductCategory{
                    ParentCateId = 2,
                    Name = "IPad Air"
                },
                new AppProductCategory{
                    ParentCateId = 2,
                    Name = "IPad Mini"
                },

				// Vật liệu hoàn thiện
				new AppProductCategory{
                    ParentCateId = 1,
                    Name = "IPhone 15 series"
                },
                new AppProductCategory{
                    ParentCateId = 1,
                    Name = "IPhone 14 series"
                },
                new AppProductCategory{
                    ParentCateId = 1,
                    Name = "IPhone 13 series"
                },
                new AppProductCategory{
                    ParentCateId = 1,
                    Name = "IPhone 12 series"
                },
                new AppProductCategory{
                    ParentCateId = 1,
                    Name = "IPhone 11 series"
                },
                new AppProductCategory{
                    ParentCateId = 1,
                    Name = "IPhone SE"
                },
            };
            var nextId = cateLevel1.Length + 1;
            for (int i = 0; i < cateLevel2.Length; i++)
            {
                cateLevel2[i].Id = nextId + i;
                cateLevel2[i].Slug = cateLevel2[i].Name.Slugify();
                cateLevel2[i].CateLevel = 2;
                cateLevel2[i].CreatedDate = now;
                cateLevel2[i].UpdatedDate = now;
            }
            builder.HasData(cateLevel2);
        }
    }
}
