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
	public class MstProductColorConfig : IEntityTypeConfiguration<MstProductColor>
	{
		public void Configure(EntityTypeBuilder<MstProductColor> builder)
		{
			builder.ToTable(DB.MstProductColor.TABLE_NAME);

			builder.HasKey(x => x.Id);

			builder.Property(x => x.ColorName)
				.HasMaxLength(DB.MstProductColor.COLOR_NAME_LENGTH);

			builder.Property(x => x.CssColor)
				.HasMaxLength(DB.MstProductColor.COLOR_NAME_LENGTH);

		}
	}
}
