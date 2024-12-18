﻿using App.Data.Entities;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.DataSeeders
{
    public static class AppRoleSeeder
    {
        public static void SeedData(this EntityTypeBuilder<AppRole> builder)
        {
            var now = DateTime.Now;

            // Tạo vai trò
            var roleCustomer = new AppRole
            {
                Id = 1,
                Name = "Khách hàng",
                Desc = "Khách hàng",
                CreatedDate = now,
                UpdatedDate = now,
                CanDelete = false
            };

            var roleAdmin = new AppRole
            {
                Id = 2,
                Name = "Quản trị hệ thống",
                Desc = "Quản trị toàn bộ hệ thống",
                CreatedDate = now,
                UpdatedDate = now,
                CanDelete = true
            };

            builder.HasData(roleCustomer, roleAdmin);
        }
    }
}
