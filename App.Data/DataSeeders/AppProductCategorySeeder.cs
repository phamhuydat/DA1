using App.Data.Entities;
using App.Share.Consts;
using App.Share.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.DataSeeders
{
	public static class AppProductCategorySeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppProductCategory> buider)
		{
			var now = new DateTime(year: 2022, month: 09, day: 27);
			var groupName = "";

			// Tạo danh mục cấp 1
			var cateLevel1 = new List<AppProductCategory>();

			#region GroupName của Shop
			groupName = ProductCateConst.SHOP_GROUPNAME;
			var cateShop = new AppProductCategory[]
			{
				new AppProductCategory
				{
					GroupName =	groupName,
					Name = "Tops"
				},
				new AppProductCategory
				{
					GroupName = groupName,
					Name = "Bottoms"
				},
				new AppProductCategory
				{
					GroupName = groupName,
					Name = "Accessories"
				},
				new AppProductCategory
				{
					GroupName = groupName,
					Name = "Bags"
				},
				new AppProductCategory
				{
					GroupName = groupName,
					Name = "Restocks"
				},
			};
			cateLevel1.AddRange(cateShop);
			#endregion

			#region GroupName của Collab's
			groupName = ProductCateConst.COLLAB_GROUPNAME;
			var cateCollabs = new AppProductCategory[]
			{
				new AppProductCategory
				{
					GroupName = groupName,
					Name = "One Piece"
				},
				new AppProductCategory
				{
					GroupName = groupName,
					Name = "Lil'wuyn"
				},
				new AppProductCategory
				{
					GroupName = groupName,
					Name = "Grab"
				},
				new AppProductCategory
				{
					GroupName = groupName,
					Name = "16Typh"
				},
				new AppProductCategory
				{
					GroupName = groupName,
					Name = "Million Dollar Boy"
				},
			};
			cateLevel1.AddRange(cateCollabs);
			#endregion
			// Tạo các trường dữ liệu còn lại cho category
			for(int i = 0; i < cateLevel1.Count; i++)
			{
				cateLevel1[i].Id = i + 1;
				cateLevel1[i].Slug = cateLevel1[i].Name.Slugify();
				cateLevel1[i].CateLevel = 1;
				cateLevel1[i].HasChild = true;
				cateLevel1[i].CreatedDate = now;
				cateLevel1[i].UpdatedDate = now;
			}
			buider.HasData(cateLevel1);

			// Tạo danh mục cấp 2
			var cateLevel2 = new List<AppProductCategory>();

			#region Dữ liệu cho danh mục Level 2
			var cateLv2All = new AppProductCategory[]
			{
				// TOPS
				new AppProductCategory
				{
					ParentCateId = 1,
					Name = "T-Shirts & Polo Shirts"
				},
				new AppProductCategory
				{
					ParentCateId = 1,
					Name = "Shirts"
				},
				new AppProductCategory
				{
					ParentCateId = 1,
					Name = "LongSleeves"
				},
				new AppProductCategory
				{
					ParentCateId = 1,
					Name = "Sweaters & Cardigans"
				},
				new AppProductCategory
				{
					ParentCateId = 1,
					Name = "Sweatshirts & Hoodies"
				},
				new AppProductCategory
				{
					ParentCateId = 1,
					Name = "Outerwear"
				},
				// ACCESSORIES
				new AppProductCategory
				{
					ParentCateId = 3,
					Name = "Other Accessories"
				},
				new AppProductCategory
				{
					ParentCateId = 3,
					Name = "Caps/Hats"
				},
				new AppProductCategory
				{
					ParentCateId = 3,
					Name = "Wallets"
				},
				new AppProductCategory
				{
					ParentCateId = 3,
					Name = "Masks"
				},
				// BAGS
				new AppProductCategory
				{
					ParentCateId = 4,
					Name = "Backpacks"
				},
				new AppProductCategory
				{
					ParentCateId = 4,
					Name = "Shoulder Bags"
				},
				new AppProductCategory
				{
					ParentCateId = 4,
					Name = "Bowler Bags"
				},
				// Collab's
				// One Piece
				new AppProductCategory
				{
					ParentCateId = 6,
					Name = "DC X OP - TOPS" // 24
				},
				new AppProductCategory
				{
					ParentCateId = 6,
					Name = "DC X OP - BOTTOMS"
				},
				new AppProductCategory
				{
					ParentCateId = 6,
					Name = "DC X OP - BAGS"
				},
				new AppProductCategory
				{
					ParentCateId = 6,
					Name = "DC X OP - ACCESSORIES"
				},
				// LIL'WUYN
				new AppProductCategory
				{
					ParentCateId = 7,
					Name = "DC X LW - TOPS"
				},
				new AppProductCategory
				{
					ParentCateId = 7,
					Name = "DC X LW - BOTTOMS"
				},
				new AppProductCategory
				{
					ParentCateId = 7,
					Name = "DC X LW - ACCESSORIES"
				},
				new AppProductCategory
				{
					ParentCateId = 7,
					Name = "DC X LW - BAGS"
				},
				// 16TYPH
				new AppProductCategory
				{
					ParentCateId = 9,
					Name = "TOPS"
				},
				new AppProductCategory
				{
					ParentCateId = 9,
					Name = "BAGS"
				},
				// 16TYPH
				new AppProductCategory
				{
					ParentCateId = 10,
					Name = "TOPS"
				},
				new AppProductCategory
				{
					ParentCateId = 10,
					Name = "ACCESSORIES"
				}
			};
			cateLevel2.AddRange(cateLv2All);
			#endregion

			// Tạo các trường dữ liệu còn lại cho category
			var nextId = cateLevel1.Count + 1;
			for(int i = 0; i < cateLevel2.Count; i++)
			{
				var nameParentCate = cateLevel1.SingleOrDefault(x => x.Id == cateLevel2[i].ParentCateId).Name;

				cateLevel2[i].Id = nextId + i;
				cateLevel2[i].Slug = $"{nameParentCate} {cateLevel2[i].Name}".Slugify();
				cateLevel2[i].CateLevel = 2;
				cateLevel2[i].HasChild = true;
				cateLevel2[i].CreatedDate = now;
				cateLevel2[i].UpdatedDate = now;
			}
			buider.HasData(cateLevel2);

			var cateLevel3 = new List<AppProductCategory>();

			#region Dữ lệu cho danh mục Level 3
			// Tạo danh mục cấp 3
			var cateLv3All = new AppProductCategory[]
			{
				new AppProductCategory
				{
					ParentCateId = 24,
					Name = "T-Shirts"
				},
				new AppProductCategory
				{
					ParentCateId = 24,
					Name = "Sweaters & Hoodies"
				},
				new AppProductCategory
				{
					ParentCateId = 24,
					Name = "Outerwear"
				}
			};
			cateLevel3.AddRange(cateLv3All);
			#endregion

			// Tạo dữ liệu category lv3
			var nextId2 = cateLevel2.LastOrDefault().Id;
			for(int i = 0; i < cateLevel3.Count; i++)
			{
				var parentCateLv2 = cateLevel2.SingleOrDefault(x => x.Id == cateLevel3[i].ParentCateId);
				var parentCateLv1 = cateLevel1.SingleOrDefault(x => x.Id == parentCateLv2.ParentCateId);

				cateLevel3[i].Id = nextId2 + i + 1;
				cateLevel3[i].Slug = $"{parentCateLv1.Name} {parentCateLv2.Name} {cateLevel3[i].Name}".Slugify();
				cateLevel3[i].CateLevel = 3;
				cateLevel3[i].CreatedDate = now;
				cateLevel3[i].UpdatedDate = now;
			}
			buider.HasData(cateLevel3);
		}
	}
}
