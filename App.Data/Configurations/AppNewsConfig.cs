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
	public class AppNewsConfig : IEntityTypeConfiguration<AppNews>
	{
		public void Configure(EntityTypeBuilder<AppNews> builder)
		{
			builder.ToTable(DB.AppNews.TABLE_NAME);

			// Khóa chính
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Title)
				.HasMaxLength(DB.AppNews.TITLE_LENGTH)
				.IsRequired();

			builder.Property(x => x.Slug)
				.HasMaxLength(DB.AppNews.SLUG_LENGTH)
				.IsRequired();

			builder.Property(x => x.Summary)
				.HasMaxLength(DB.AppNews.SUMMARY_LENGTH)
				.IsRequired();

			builder.Property(x => x.Published)
				.HasDefaultValue(DB.AppNews.PUBLIC_NEWS);

			builder.Property(s => s.CreatedDate)
				.HasDefaultValueSql(DB.AppNews.DEFAULT_DATE);

			builder.Property(s => s.PublishedAt)
				.HasDefaultValue(DB.AppNews.DEFAULT_VALUE);

			builder.Property(s => s.Votes)
				.HasDefaultValue(DB.AppNews.COUNT);

			builder.Property(s => s.Views)
				.HasDefaultValue(DB.AppNews.COUNT);

			builder.Property(s => s.CoverImgPath)
				.HasDefaultValue(DB.AppNews.DEFAULT_VALUE);

			builder.HasIndex(s => s.Slug, $"uq_slug")
				.IsUnique();

			// Khóa ngoại
			builder.HasOne(s => s.NewsCategory)
				.WithMany(s => s.NewsNavigation)
				.HasForeignKey(s => s.CategoryId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(s => s.Users)
				.WithMany(s => s.AppNewsNavigation)
				.HasForeignKey(s => s.UserId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
