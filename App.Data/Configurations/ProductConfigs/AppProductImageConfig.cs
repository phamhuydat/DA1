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
	public class AppProductImageConfig : IEntityTypeConfiguration<AppProductImage>
	{
		public void Configure(EntityTypeBuilder<AppProductImage> builder)
		{
			builder.ToTable(DB.AppProductImage.TABLE_NAME);

			builder.HasKey(x => x.Id);

			builder.Property(s => s.ImagePath).HasMaxLength(DB.AppProductImage.IMAGE_PATH_LENGTH);

			// Khóa ngoại
			builder.HasOne(x => x.Product)
				.WithMany(x => x.AppProductImages)
				.HasForeignKey(x => x.ProductId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
