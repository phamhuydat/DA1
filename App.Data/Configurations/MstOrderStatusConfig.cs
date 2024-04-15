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
	public class MstOrderStatusConfig : IEntityTypeConfiguration<MstOrderStatus>
	{
		public void Configure(EntityTypeBuilder<MstOrderStatus> builder)
		{
			builder.ToTable(DB.MstOrderStatus.TABLE_NAME);

			builder.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.HasMaxLength(DB.MstOrderStatus.NAME_LENGTH);
		}
	}
}
