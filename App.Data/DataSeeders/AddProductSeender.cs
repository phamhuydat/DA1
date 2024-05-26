using App.Data.Entities.Products;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.DataSeeders
{
    public static class AddProductSeender
    {
        public static void SeenData(this EntityTypeBuilder<AppProduct> builder)
        {
            var now = DateTime.Now;

            #region sender data Iphone
            builder.HasData(
                new AppProduct
                {
                    Id = 1,
                    ProductCode = "iphone-se",
                    ProductName = "Iphone SE (2022)",
                    IsActive = true,
                    CategoryId = DB.AppProductCategory.IPHONE,
                    Description = "Mẫu sản phẩm iphone pro ra mắt năm ",
                    CreatedBy = 1,
                    CreatedDate = now,
                    AppProductImages = new List<AppProductImage>
                    {
                        new AppProductImage
                        {
                            ProductId = 1,
                            ImagePath = "",
                            CreatedBy= 1,
                            CreatedDate = now,
                        },
                        new AppProductImage
                        {
                            ProductId = 1,
                            ImagePath = "",
                            CreatedBy= 1,
                            CreatedDate = now,
                        },
                        new AppProductImage
                        {
                            ProductId = 1,
                            ImagePath = "",
                            CreatedBy= 1,
                            CreatedDate = now,
                        },
                        new AppProductImage
                        {
                            ProductId = 1,
                            ImagePath = "",
                            CreatedBy= 1,
                            CreatedDate = now,
                        },
                        new AppProductImage
                        {
                            ProductId = 1,
                            ImagePath = "",
                            CreatedBy= 1,
                            CreatedDate = now,
                        },
                        new AppProductImage
                        {
                            ProductId = 1,
                            ImagePath = "",
                            CreatedBy= 1,
                            CreatedDate = now,
                        }

                    },
                    AppProductDetails = new List<AppProductDetail>
                    {
                        new AppProductDetail
                        {
                            Price = 123,
                            DiscountPrice = 000,
                            ColorId = 1,
                            Rom = "64Gb",
                            InStock = 100, // số lượng
                            ProductId = 1,
                            CreatedBy = 1,
                            CreatedDate = now,
                        },
                        new AppProductDetail
                        {
                            Price = 123,
                            DiscountPrice = 000,
                            ColorId = 1,
                            Rom = "128Gb",
                            InStock = 100, // số lượng
                            ProductId = 1,
                            CreatedBy = 1,
                            CreatedDate = now,
                        },
                    }
                },
                new AppProduct
                {

                });
            #endregion

            #region sender data Ipad
            builder.HasData(
                new AppProduct
                {
                    Id = 00,
                    ProductCode = "ipad-pro-m2",
                    ProductName = "IPad Pro M2",
                    IsActive = true,
                    CategoryId = DB.AppProductCategory.IPAD,
                    Description = "Mẫu sản phẩm ipad pro ra mắt năm ",
                    CreatedBy = 1,
                    CreatedDate = now,
                    AppProductImages = new List<AppProductImage>
                    {
                        new AppProductImage
                        {
                            ProductId = 00,
                            ImagePath = "",
                            CreatedBy= 1,
                            CreatedDate = now,
                        },
                        new AppProductImage
                        {
                            ProductId = 00,
                            ImagePath = "",
                            CreatedBy= 1,
                            CreatedDate = now,
                        },
                        new AppProductImage
                        {
                            ProductId = 00,
                            ImagePath = "",
                            CreatedBy= 1,
                            CreatedDate = now,
                        },
                        new AppProductImage
                        {
                            ProductId = 00,
                            ImagePath = "",
                            CreatedBy= 1,
                            CreatedDate = now,
                        },
                        new AppProductImage
                        {
                            ProductId = 00,
                            ImagePath = "",
                            CreatedBy= 1,
                            CreatedDate = now,
                        },
                        new AppProductImage
                        {
                            ProductId = 00,
                            ImagePath = "",
                            CreatedBy= 1,
                            CreatedDate = now,
                        }

                    },
                    AppProductDetails = new List<AppProductDetail>
                    {
                        new AppProductDetail
                        {
                            Price = 123,
                            DiscountPrice = 000,
                            ColorId = 1,
                            Rom = "64Gb",
                            InStock = 100, // số lượng
                            ProductId = 00,
                            CreatedBy = 1,
                            CreatedDate = now,
                        },
                        new AppProductDetail
                        {
                            Price = 123,
                            DiscountPrice = 000,
                            ColorId = 1,
                            Rom = "128Gb",
                            InStock = 100, // số lượng
                            ProductId = 00,
                            CreatedBy = 1,
                            CreatedDate = now,
                        },
                    }
                },
                new AppProduct
                {

                });
            #endregion

        }
    }
}
