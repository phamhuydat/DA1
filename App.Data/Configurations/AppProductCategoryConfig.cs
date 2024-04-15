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
	public class AppProductCategoryConfig : IEntityTypeConfiguration<AppProductCategory>
	{
		public void Configure(EntityTypeBuilder<AppProductCategory> builder)
		{
			builder.ToTable(DB.AppProductCategory.TABLE_NAME);

			// Khóa chính
			builder.HasKey(s => s.Id);

			builder.Property(s => s.Name)
				.HasMaxLength(DB.AppProductCategory.NAME_LENGTH)
				.IsRequired();

			builder.Property(s => s.Slug)
				.HasMaxLength(DB.AppProductCategory.LENGTH_CATEGORY);

			builder.Property(x => x.GroupName)
				.HasMaxLength(DB.AppProductCategory.GROUP_NAME_LENGTH);

			builder.Property(s => s.CateLevel)
				.HasMaxLength(DB.AppProductCategory.LENGTH_LEVEL)
				.HasDefaultValue(1);

			builder.Property(s => s.HasChild)
				.HasDefaultValue(DB.AppProductCategory.DEFAULT_VALUE);

			builder.Property(s => s.Content)
				.HasMaxLength(DB.AppProductCategory.DEFAULT_CONTENT);

			builder.Property(x => x.CoverImgPath)
				.HasMaxLength(DB.AppProductCategory.IMG_LENGTH);

			builder.Property(x => x.StampPath)
				.HasMaxLength(DB.AppProductCategory.IMG_LENGTH);

			// Khóa ngoại
			builder.HasOne(s => s.ParentCategory)
				.WithMany(s => s.ChildCategories)
				.HasForeignKey(s => s.ParentCateId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
