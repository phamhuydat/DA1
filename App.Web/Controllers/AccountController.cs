using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Extensions;
using App.Web.Common.Helpers;
using App.Web.ViewModels.Account;
using App.Web.WebConfig;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using System.Security.Claims;

namespace App.Web.Controllers
{
    public class AccountController : BaseController
    {
        private readonly INotyfService _notyf;
        public AccountController(IMapper mapper, GenericRepository repository, INotyfService notyf) : base(mapper, repository)
        {
            _notyf = notyf;
        }
        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction(nameof(Login));
            }
            return View();
        }

        public IActionResult Login() => User.Identity.IsAuthenticated ? RedirectToAction(nameof(Index)) : View();
        [HttpPost]
        public async Task<IActionResult> Login(LoginClientVM model)
        {
            if (!ModelState.IsValid)
            {
                _notyf.Error("Bạn chưa nhập dữ liệu!");
                return RedirectToAction("Index", "Home");
            }
            var user = await _repository.GetOneAsync<AppUser, UserDataForApp>
                (
                    where: x => x.Username == model.Username.ToLower(),
                    AutoMapperProfile.LoginConf
                );
            if (user == null)
            {
                _notyf.Error("Tên tài khoản không tồn tại!");
                return RedirectToAction("Index", "Home");
            }
            if (user.BlockedTo.HasValue && user.BlockedTo.Value >= DateTime.Now)
            {
                _notyf.Error($"Tài khoản của bạn bị khóa đến {user.BlockedTo.Value:dd/MM/yyyy HH:mm}");
                return RedirectToAction("Index", "Home");
            }
            if (user.BlockedTo.HasValue && user.BlockedTo.Value <= DateTime.Now)
            {
                var data = await _repository.FindAsync<AppUser>(user.Id);
                data.BlockedTo = null;
                data.BlockedBy = null;
                await _repository.UpdateAsync(data);
            }
            var pwdHash = this.HashHMACSHA512WithKey(model.Password, user.PasswordSalt);
            if (!pwdHash.SequenceEqual(user.PasswordHash))
            {
                _notyf.Error("Tên đăng nhập hoặc mật khẩu không chính xác!");
                return RedirectToAction("Index", "Home");
            }
            var claims = new List<Claim> {
                            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                            new Claim(ClaimTypes.Name, user.Username),
                            new Claim(ClaimTypes.Email, user.Email),
                            new Claim(AppClaimTypes.FullName, user.FullName),
                            new Claim(AppClaimTypes.PhoneNumber, user.PhoneNumber1),
                            new Claim(AppClaimTypes.RoleName, user.RoleName),
                            new Claim(AppClaimTypes.RoleId, user.AppRoleId.ToString()),
                            new Claim(AppClaimTypes.Permissions, user.Permission),
                        };
            var claimsIdentity = new ClaimsIdentity(claims, AppConst.COOKIES_AUTH);
            var principal = new ClaimsPrincipal(claimsIdentity);
            var authenPropeties = new AuthenticationProperties()
            {
                ExpiresUtc = DateTime.UtcNow.AddHours(AppConst.LOGIN_TIMEOUT),
                IsPersistent = true
            };
            await HttpContext.SignInAsync(AppConst.COOKIES_AUTH, principal, authenPropeties);

            CreateDirIfNotExist(model.Username);
            var returnUrl = Request.Query["ReturnUrl"].ToString();
            if (returnUrl.IsNullOrEmpty())
            {
                return RedirectToAction("Index", "Home");
            }
            return Redirect(returnUrl);
        }

        public IActionResult Logout() => View();



        public IActionResult Register () => User.Identity.IsAuthenticated ? RedirectToAction(nameof(Index)) : View();


        private static void CreateDirIfNotExist(string username)
        {
            var userPath = $"{AppConst.SYSTEM_FILE_PATH}{Path.DirectorySeparatorChar}{username}";
            var fullPath = PathHelper.MapPath(userPath);
            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
                // Thêm file tạm để giữ folder
                var file = PathHelper.MapPath($"{userPath}{Path.DirectorySeparatorChar}{username}.txt");
                System.IO.File.WriteAllText(file, $"Hello {username}!");
            }
        }
    }
}
