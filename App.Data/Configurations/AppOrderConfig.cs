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
    public class AppOrderConfig : IEntityTypeConfiguration<AppOrder>
    {
        public void Configure(EntityTypeBuilder<AppOrder> builder)
        {
            builder.ToTable(DB.AppOrder.TABLE_NAME);

            // Khóa chính
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CusName)
                .HasMaxLength(DB.AppOrder.CUS_NAME_LENGTH);
            builder.Property(x => x.CusPhone)
                .HasMaxLength(DB.AppOrder.CUS_PHONE_LENGTH);
            builder.Property(x => x.CusEmail)
                .HasMaxLength(DB.AppOrder.CUS_EMAIL_LENGTH);
            builder.Property(x => x.DeliveryAddress)
                .HasMaxLength(DB.AppOrder.DELIVERY_ADDRESS_LENGTH);
            //builder.Property(x => x.CusNote)
            //	.HasMaxLength(DB.AppOrder.CUS_NOTE_LENGTH);

            // Khóa ngoại
            builder.HasOne(x => x.Employee)
                .WithMany(x => x.VerifiedOrders)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.OwnerOrders)
                .HasForeignKey(x => x.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.MstOrderStatus)
                .WithMany(x => x.AppOrders)
                .HasForeignKey(x => x.StatusId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.AppDiscountCode)
                .WithMany(x => x.AppOrders)
                .HasForeignKey(x => x.DiscountCodeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
