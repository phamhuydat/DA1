﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.ViewModels.Account
{
    public class UserDataForApp
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string Address { get; set; }
        public DateTime? BlockedTo { get; set; }
        public int? BlockedBy { get; set; }
        public string RoleName { get; set; }
        public string Permission { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? AppRoleId { get; set; }
    }
}
