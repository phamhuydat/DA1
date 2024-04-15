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
	public class SystemEnvConfig : IEntityTypeConfiguration<SystemEnv>
	{
		public void Configure(EntityTypeBuilder<SystemEnv> builder)
		{
			builder.ToTable(DB.SystemEnv.TABLE_NAME);

			// Khóa chính
			builder.HasKey(x => x.Key);
		}
	}
}
