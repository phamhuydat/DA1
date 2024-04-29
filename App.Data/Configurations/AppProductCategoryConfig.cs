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

            // Khóa ngoại
            builder.HasMany(m => m.AppSlider)
                .WithOne(m => m.ProductCategory)
                .HasForeignKey(m => m.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
