using App.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.DataSeeders
{
    public static class AppVoucherSeender
    {
        public static void SeedData(this EntityTypeBuilder<AppVoucher> builder)
        {
            var now = DateTime.Now;
            #region Data Voucher Test
            var dataVoucher = new AppVoucher[]
            {
                new AppVoucher
                {
                    Id = 1,
                    Code = "voucher",
                    Amount = 10,
                    Price = 50, // mức giá đc giảm tối đa
                    Percent = 10, // % giảm giá của đơn hàng với voucher code ko cao hơn Price
                    CreatedBy = 1,
                    CreatedDate = now,
                    StartDate = now,
                },
                new AppVoucher
                {
                    Id = 2,
                    Code = "voucher1",
                    Amount = 10,
                    Price = 50, // mức giá đc giảm tối đa
                    CreatedBy = 1,
                    CreatedDate = now,
                    StartDate = now,
                },
            };
            builder.HasData(dataVoucher);

            #endregion
        }
    }
}
