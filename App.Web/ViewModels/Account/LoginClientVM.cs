using App.Web.WebConfig;
using App.Shared.Attributes;
using System.ComponentModel.DataAnnotations;

namespace App.Web.ViewModels.Account
{
    public class LoginClientVM
    {
        [AppRequired]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [AppRequired]
        public string Password { get; set; }
        public bool RemeberMe { get; set; }
    }
}
