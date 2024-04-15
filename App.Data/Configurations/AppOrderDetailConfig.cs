using App.Data.Entities;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Configurations
{
	public class AppOrderDetailConfig : IEntityTypeConfiguration<AppOrderDetail>
	{
		public void Configure(EntityTypeBuilder<AppOrderDetail> builder)
		{
			builder.ToTable(DB.AppOrderDetail.TABLE_NAME);

			// Khóa chính
			builder.HasKey(x => x.Id);

			builder.Property(x => x.ProductName)
				.HasMaxLength(DB.AppOrderDetail.PRODUCT_NAME_LENGTH);

			builder.Property(x => x.ImagePath)
				.HasMaxLength(DB.AppOrderDetail.IMG_PATH_LENGTH);

			// Khóa ngoại
			builder.HasOne(x => x.AppOrder)
				.WithMany(x => x.AppOrderDetails)
				.HasForeignKey(x => x.OrderId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(x => x.AppProduct)
				.WithMany(x => x.AppOrderDetails)
				.HasForeignKey(x => x.ProductId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
