using App.Data.Entities.Products;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Configurations.ProductConfigs
{
    public class AppProdcuctDetailConfig : IEntityTypeConfiguration<AppProductDetail>
    {
        public void Configure(EntityTypeBuilder<AppProductDetail> builder)
        {
            builder.ToTable(DB.AppProductDetail.TABLE_NAME);

            builder.HasOne(x => x.AppProduct)
                .WithMany(x => x.AppProductDetails)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.AppOrderDetails)
                .WithOne(x => x.AppProdcutDetail)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.MstProductColor)
                .WithMany(x => x.AppProdcutDetails)
                .HasForeignKey(x => x.ColorId)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }
}
