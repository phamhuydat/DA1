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
	public class AppPolicyConfig : IEntityTypeConfiguration<AppPolicy>
	{
		public void Configure(EntityTypeBuilder<AppPolicy> builder)
		{
			builder.ToTable(DB.AppPolicy.TABLE_NAME);

			// Khóa chính
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Title)
				.HasMaxLength(DB.AppPolicy.TITLE_LENGTH)
				.IsRequired();

			builder.Property(x => x.Slug)
				.HasMaxLength(DB.AppPolicy.SLUG_LENGTH)
				.IsRequired();

			builder.Property(x => x.CoverImgPath)
				.HasMaxLength(DB.AppPolicy.COVER_IMG_PATH_LENGTH);

			builder.Property(x => x.CoverImgThumbnailPath)
				.HasMaxLength(DB.AppPolicy.COVER_IMG_PATH_LENGTH);

			builder.Property(x => x.Like)
				.HasDefaultValue(DB.AppPolicy.LIKE_DEFAULT_VALUE);

			// Khóa ngoại
			builder.HasOne(x => x.User)
				.WithMany(x => x.AppPolicyNavigation)
				.HasForeignKey(x => x.UserId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
