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
	public class AppBranchConfig : IEntityTypeConfiguration<AppBranch>
	{
		public void Configure(EntityTypeBuilder<AppBranch> builder)
		{
			builder.ToTable(DB.AppBranch.TABLE_NAME);

			// Khóa chính
			builder.HasKey(x => x.Id);

			builder.Property(x => x.GroupName)
				.HasMaxLength(DB.AppBranch.MAX_LENGTH);

			builder.Property(x => x.Address)
				.HasMaxLength(DB.AppBranch.MAX_LENGTH);

            builder.Property(x => x.IdMap)
                .HasMaxLength(DB.AppBranch.MAX_LENGTH);
        }
	}
}
