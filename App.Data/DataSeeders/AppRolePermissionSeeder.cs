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
    public static class AppRolePermissionSeeder
    {
        public static void SeedData(this EntityTypeBuilder<AppRolePermission> builder)
        {
            var now = DateTime.Now;
            // Danh sách các class chứa permission
            Type[] classType = new Type[]
            {
                typeof(AuthConst.AppRole),
                typeof(AuthConst.AppUser),
                typeof(AuthConst.FileManager),
                typeof(AuthConst.MstProductBrand),
                typeof(AuthConst.AppBranch),
                typeof(AuthConst.AppDiscountCode),
                typeof(AuthConst.MstProductColor),
                typeof(AuthConst.AppSlider),
                typeof(AuthConst.AppPolicy),
                typeof(AuthConst.AppNewsCategory),
                typeof(AuthConst.AppNews),
                typeof(AuthConst.AppAboutCompany),
                typeof(AuthConst.AppProductCategory),
                typeof(AuthConst.AppProduct),
                typeof(AuthConst.AppOrder),
                //typeof(AuthConst.)
            };


            // Cấp quyền cho vai trò
            var rolePermission = new List<AppRolePermission>();
            int i = 0;
            foreach (var type in classType)
            {
                var allPermission = GetConstants(type);
                foreach (var permission in allPermission)
                {
                    i++;
                    rolePermission.Add(new AppRolePermission
                    {
                        Id = i,
                        MstPermissionId = Convert.ToInt32(permission.GetRawConstantValue()),
                        UpdatedDate = now,
                        CreatedDate = now,
                        AppRoleId = 2,      // Vai trò được tạo ở AppRoleSeeder
                    });
                }
            }

            builder.HasData(rolePermission);
        }
        private static List<FieldInfo> GetConstants(Type type)
        {
            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Public |
                 BindingFlags.Static | BindingFlags.FlattenHierarchy);

            return fieldInfos.Where(fi => fi.IsLiteral && !fi.IsInitOnly).ToList();
        }
    }
}
