﻿using App.Share.Consts;
using App.Web.WebConfig;
using DNews.Shared.Attributes;
using System.ComponentModel.DataAnnotations;

namespace App.Web.ViewModels.Account
{
	public class RegisterClientVM
	{
		[AppRequired]
		[AppUsername]
		[AppStringLength(VM.UserVM.USERNAME_MINLEN, DB.AppUser.USERNAME_LENGTH)]
		public string Username { get; set; }

		[AppRequired]
		[DataType(DataType.Password)]
		[AppStringLength(VM.UserVM.PWD_MINLEN, DB.AppUser.PWD_LENGTH)]
		public string Password { get; set; }

		[AppRequired]
		[AppConfirmPwd]
		[DataType(DataType.Password)]
		public string ConfirmPwd { get; set; }

		[AppRequired]
		public string FullName { get; set; }

		[AppRequired]
		[AppPhone]
		public string PhoneNumber1 { get; set; }

		[AppRequired]
		[AppEmail]
		public string Email { get; set; }

		public byte[] PasswordHash { get; internal set; }
		public byte[] PasswordSalt { get; internal set; }
	}
}
