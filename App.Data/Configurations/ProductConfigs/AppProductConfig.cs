using App.Data.Entities.Products;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Configurations.ProductConfigs
{
	public class AppProductConfig : IEntityTypeConfiguration<AppProduct>
	{
		public void Configure(EntityTypeBuilder<AppProduct> builder)
		{
			builder.ToTable(DB.AppProduct.TABLE_NAME);

			builder.HasKey(x => x.Id);

			//builder.Property(x => x.View).HasDefaultValue(0);
			builder.Property(x => x.ProductName).HasMaxLength(DB.AppProduct.PRODUCTNAME_LENGTH);
			//builder.Property(x => x.Slug).HasMaxLength(DB.AppProduct.SLUG_LENGTH);
			//builder.Property(x => x.StampPath).HasMaxLength(DB.AppProduct.STAMP_PATH_LENGTH);
			builder.Property(x => x.ProductCode).HasMaxLength(DB.AppProduct.PRODUCT_CODE_LENGTH);

			// Khóa ngoại
			builder.HasOne(x => x.ProductCategory)
				.WithMany(c => c.AppProducts)
				.HasForeignKey(x => x.CategoryId)
				.OnDelete(DeleteBehavior.NoAction);


			builder.HasMany(x => x.AppOrderDetails)
				.WithOne(x => x.AppProduct)
				.HasForeignKey(x => x.ProductId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
