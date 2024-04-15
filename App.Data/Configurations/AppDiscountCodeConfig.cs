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
	public class AppDiscountCodeConfig : IEntityTypeConfiguration<AppDiscountCode>
	{
		public void Configure(EntityTypeBuilder<AppDiscountCode> builder)
		{
			builder.ToTable(DB.AppDiscountCode.TABLE_NAME);

			// Khóa chính
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Code)
				.HasMaxLength(DB.AppDiscountCode.CODE_LENGTH)
				.IsRequired();

			builder.Property(x => x.Description)
				.HasMaxLength(DB.AppDiscountCode.DES_LENGTH);
		}
	}
}
