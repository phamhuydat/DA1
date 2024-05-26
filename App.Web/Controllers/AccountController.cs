using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Extensions;
using App.Web.Common;
using App.Web.Common.Helpers;
using App.Web.ViewModels.Account;
using App.Web.ViewModels.Order;
using App.Web.WebConfig;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
				_notyf.Error("Vui lòng điền đủ thông tin");
				return View(model);
			}
			var user = await _repository.GetOneAsync<AppUser, UserDataForApp>
				(
					where: x => x.Username == model.Username.ToLower(),
					AutoMapperProfile.LoginConf
				);
			if (user == null)
			{
				_notyf.Error("Tên đăng nhập hoặc mật khẩu không chính xác!");
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
		[HttpGet]
		[AppAuthorize]
		public async Task<IActionResult> UpdateProfile()
		{
			var user = await _repository.FindAsync<AppUser>(CurrentUserId);

			if (user == null)
			{
				_notyf.Error("Tài khoản không tồn tại");
				return RedirectToAction(nameof(Login), "Account");
			}
			var data = new UpdateProfileVM();
			data.Username = user.Username;
			data.address = user.Address;
			data.phone = user.PhoneNumber;
			data.email = user.Email;
			data.fullname = user.FullName;
			return View(data);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateProfile(UpdateProfileVM model)
		{
			if (ModelState.IsValid)
			{
				_notyf.Error("Thông tin bị lỗi");
				return RedirectToAction(nameof(UpdateProfile));
			}
			var user = await _repository.FindAsync<AppUser>(CurrentUserId);
			user.FullName = model.fullname;
			user.PhoneNumber = model.phone;
			user.Email = model.email;
			try
			{
				await _repository.UpdateAsync(user);
				_notyf.Success("Update thông tin tài khoản thành công");
			}
			catch (Exception ex)
			{
				_notyf.Error("Update thất bại");
			}

			return RedirectToAction(nameof(UpdateProfile));
		}

		[HttpGet]
		[AppAuthorize]
		public async Task<IActionResult> UpdateAddress()
		{
			var user = await _repository.FindAsync<AppUser>(CurrentUserId);
			if (user == null)
			{
				_notyf.Error("Tài khoản không tồn tại");
				return RedirectToAction(nameof(Login), "Account");
			}
			var data = new UpdateProfileVM();
			data.Username = user.Username;
			data.address = user.Address;
			data.phone = user.PhoneNumber;
			data.email = user.Email;
			data.fullname = user.FullName;
			return View(data);
		}

		public async Task<IActionResult> UpdateAddress(UpdateProfileVM model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}
			var user = await _repository.FindAsync<AppUser>(CurrentUserId);
			user.Address = model.address;
			user.Email = model.email;
			user.PhoneNumber = model.phone;
			user.FullName = model.fullname;
			await _repository.UpdateAsync(user);
			_notyf.Success("Cập nhật thông tin thành công");
			return View();
		}
		[Route("Doi-mat-khau")]

		public IActionResult ChangePassword()
		{
			return View();
		}
		[HttpPost]
		[AppAuthorize]
		public async Task<IActionResult> ChangePassword(ChangePwdVM model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}
			var user = await _repository.FindAsync<AppUser>(CurrentUserId);
			var encryptPassword = this.HashHMACSHA512WithKey(model.Pwd, user.PasswordSalt);
			if (!encryptPassword.SequenceEqual(user.PasswordHash))
			{
				_notyf.Error("Mật khẩu cũ không chính xác");
				return View();
			}

			var hashResult = this.HashHMACSHA512(model.NewPwd);
			user.PasswordHash = hashResult.Value;
			user.PasswordSalt = hashResult.Key;
			await _repository.UpdateAsync<AppUser>(user);

			if (model.LogoutAfterChangePwd)
			{
				_notyf.Success("Đổi mật khẩu thành công");
				return RedirectToAction(nameof(Logout));
			}

			_notyf.Success("Đổi mật khẩu thành công");
			return View();
		}

		[Route("Don-hang")]
		[Authorize]

		public async Task<IActionResult> History()
		{
			var order = new List<OrderClientVM>();

			var data = await _repository.GetAll<AppOrder>()
						.Where(x => x.CreatedBy == CurrentUserId).ToListAsync();

			_mapper.Map(data, order);

			return View(order);
		}
		[Route("chi-tiet-don-hang/{id}")]
		[Authorize]

		public async Task<IActionResult> HistoryDetail(int id)
		{
			ViewBag.Info = await _repository.FindAsync<AppOrder>(id);

			var data = await _repository.GetAll<AppOrderDetail>().Where(x => x.OrderId == id).ToListAsync();

			return View(data);
		}
		public async Task<IActionResult> UpdateImg()
		{
			var user = await _repository.FindAsync<AppUser>(CurrentUserId);

			var data = new UpdateProfileVM();
			data.AvatarPath = user.Avatar;
			return View(data);
		}
		[HttpPost]
		[Authorize]

		public async Task<IActionResult> UpdateImg(UpdateProfileVM model, [FromServices] IWebHostEnvironment env)
		{
			var user = await _repository.FindAsync<AppUser>(CurrentUserId);
			user.Avatar = UploadFile(model.Avatar, env.WebRootPath);
			try
			{
				await _repository.UpdateAsync(user);
				_notyf.Success("Cập nhật ảnh đại diện thành công");
				return RedirectToAction(nameof(UpdateImg));
			}
			catch (Exception ex)
			{
				_notyf.Error("Cập nhật thất bại");
				return View();
			}
		}

		private string UploadFile(IFormFile file, string dir)
		{
			var fName = file.FileName;
			fName = Path.GetFileNameWithoutExtension(fName)
					+ DateTime.Now.Ticks
					+ Path.GetExtension(fName);
			var res = "/Images/Avatar/" + fName;
			// tạo đường dẫn tuyệt đối (Ví dụ: E:/Project/wwwroot/upload/xxxx.jpg)
			// fName = Path.Combine(dir, "/Images/Avatar/", fName);

			fName = PathHelper.MapPath(res);
			// Tạo stream để lưu file
			var stream = System.IO.File.Create(fName);
			file.CopyTo(stream);
			stream.Dispose();   // Giải phóng bộ nhớ
			return res;
		}
	}
}
