﻿using App.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
	public class AppUser : AppEntityBase
	{
		public AppUser()
		{
			AppVerifyCodeNavigation = new HashSet<AppVerifyCode>();
			AppNewsNavigation = new HashSet<AppNews>();
			AppPolicyNavigation = new HashSet<AppPolicy>();
			OwnerOrders = new HashSet<AppOrder>();
			VerifiedOrders = new HashSet<AppOrder>();
		}
		public string Username { get; set; }
		public byte[] PasswordHash { get; set; }
		public byte[] PasswordSalt { get; set; }
		public string FullName { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string? Address { get; set; }
		public string? Avatar { get; set; }
		public DateTime? BlockedTo { get; set; }
		public int? BlockedBy { get; set; }
		public int? AppRoleId { get; set; }
		public AppRole AppRole { get; set; }
		public ICollection<AppPolicy> AppPolicyNavigation { get; set; }
		public ICollection<AppVerifyCode> AppVerifyCodeNavigation { get; set; }
		public ICollection<AppNews> AppNewsNavigation { get; set; }
		public ICollection<AppOrder> OwnerOrders { get; set; }
		public ICollection<AppOrder> VerifiedOrders { get; set; }
	}
}
