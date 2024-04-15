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
	public class AppNewsCategoryConfig : IEntityTypeConfiguration<AppNewsCategory>
	{
		public void Configure(EntityTypeBuilder<AppNewsCategory> builder)
		{
			builder.ToTable(DB.AppNewsCategory.TABLE_NAME);

			// Khóa chính
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Title)
				.HasMaxLength(DB.AppNewsCategory.TITLE_LENGTH)
				.IsRequired();

			builder.Property(x => x.Slug)
				.HasMaxLength(DB.AppNewsCategory.SLUG_LENGTH);

			builder.Property(x => x.CreatedDate)
				.HasDefaultValueSql(DB.AppNewsCategory.DEFAULT_DATE);
		}
	}
}
