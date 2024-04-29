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
        public AccountController(IMapper mapper,
            GenericRepository repository,
            INotyfService notyf) : base(mapper, repository)
        {
            _notyf = notyf;
        }

        public IActionResult Login() => User.Identity.IsAuthenticated ? RedirectToAction(nameof(Index)) : View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginClientVM model)
        {
            if (!ModelState.IsValid)
            {
                _notyf.Error("Bạn chưa nhập dữ liệu!");
                return View(model);
            }
            var user = await _repository.GetOneAsync<AppUser, UserDataForApp>
                (
                    where: x => x.Username == model.Username.ToLower(),
                    AutoMapperProfile.LoginConf
                );
            if (user == null)
            {
                _notyf.Error("Tài khoản không tồn tại!");
                return View(model);
            }
            if (user.BlockedTo.HasValue && user.BlockedTo.Value >= DateTime.Now)
            {
                _notyf.Error($"Tài khoản của bạn bị khóa đến {user.BlockedTo.Value:dd/MM/yyyy HH:mm}");
                return View(model);
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
                return View(model);
            }
            var claims = new List<Claim> {
                            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                            new Claim(ClaimTypes.Name, user.Username),
                            new Claim(ClaimTypes.Email, user.Email),
                            new Claim(AppClaimTypes.FullName, user.FullName),
                            new Claim(AppClaimTypes.PhoneNumber, user.PhoneNumber),
                            new Claim(AppClaimTypes.RoleName, user.RoleName),
                            new Claim(AppClaimTypes.RoleId, user.AppRoleId.ToString()),
                            new Claim(AppClaimTypes.Permissions, user.Permission),
                        };
            var claimsIdentity = new ClaimsIdentity(claims, AppConst.COOKIES_AUTH);
            var principal = new ClaimsPrincipal(claimsIdentity);
            var authenPropeties = new AuthenticationProperties()
            {
                ExpiresUtc = DateTime.UtcNow.AddHours(AppConst.LOGIN_TIMEOUT),
                IsPersistent = model.RemeberMe
            };

            await HttpContext.SignInAsync(AppConst.COOKIES_AUTH, principal, authenPropeties);
            _notyf.Success("Đăng nhập thành công");

            return RedirectToAction(nameof(Index), "Home");
        }

        public IActionResult Register() => User.Identity.IsAuthenticated ? RedirectToAction(nameof(Index)) : View();

        [HttpPost]
        public async Task<IActionResult> Register(RegisterClientVM model)
        {
            if (!ModelState.IsValid)
            {
                _notyf.Error("sai r");
                return View(model);
            }

            model.Username = model.Username.ToLower();
            if (await _repository.AnyAsync<AppUser>(x => x.Username.ToLower() == model.Username.ToLower()))
            {
                _notyf.Error("Tên đăng nhập đã tồn tại vui lòng kiểm tra lại!");
                return View(model);
            }
            try
            {
                var hashResult = HashHMACSHA512(model.Password);
                model.PasswordHash = hashResult.Value;
                model.PasswordSalt = hashResult.Key;
                var user = _mapper.Map<AppUser>(model);
                user.AppRoleId = AppConst.ROLE_CUSTOMER_ID;
                user.Avatar = "~/Images/Avatar/default.png";
                await _repository.AddAsync(user);
                _notyf.Success($"Đăng ký tài khoản [{user.Username}] thành công!");
                return RedirectToAction(nameof(Login));
            }
            catch (Exception ex)
            {
                return View(model);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(AppConst.COOKIES_AUTH);
            _notyf.Information("bạn đã đăng xuất");
            return RedirectToAction("Index", "Home");
        }

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
