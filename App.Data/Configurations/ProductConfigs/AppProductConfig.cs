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

			builder.Property(x => x.ProductName).HasMaxLength(DB.AppProduct.PRODUCTNAME_LENGTH);


			// Khóa ngoại
			builder.HasOne(x => x.AppProdcutCategory)
				.WithMany(c => c.AppProducts)
				.HasForeignKey(x => x.CategoryId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
