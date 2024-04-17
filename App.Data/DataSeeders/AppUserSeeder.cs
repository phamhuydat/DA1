﻿using App.Data.Entities;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.DataSeeders
{
	public static class AppUserSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppUser> builder)
		{
			var now = new DateTime(year: 2021, month: 11, day: 10);

			// Tạo mật khẩu
			var defaultPassword = "1111";
			HMACSHA512 hmac = new();
			var pwByte = Encoding.UTF8.GetBytes(defaultPassword);
			var pwdHash = hmac.ComputeHash(pwByte);
			var pwdSalt = hmac.Key;

			// Tạo thông tin tài khoản admin
			builder.HasData(
				new AppUser
				{
					Id = 1,
					Username = "admin",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Thành phố Cần Thơ",
					Email = "hello@gmail.com",
					FullName = "Lilocon",
					PhoneNumber = "0928666158",
					Avatar = "~/Images/Avatar/default.png",
					CreatedBy = -1,
					UpdatedBy = -1,
					UpdatedDate = now,
					CreatedDate = now,
					AppRoleId = 2,              // Vai trò được tạo ở AppRoleSeeder
				}
			);
		}
	}
}
