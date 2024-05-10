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
    public class AppVoucherConfig : IEntityTypeConfiguration<AppVoucher>
    {
        public void Configure(EntityTypeBuilder<AppVoucher> builder)
        {
            builder.ToTable(DB.AppVoucher.TABLE_NAME);

            // Khóa chính
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code)
                .HasMaxLength(DB.AppVoucher.CODE_LENGTH)
                .IsRequired();
        }
    }
}
