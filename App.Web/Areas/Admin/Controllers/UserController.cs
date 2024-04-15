﻿using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Common;
using App.Web.Areas.Admin.ViewModels.Role;
using App.Web.Areas.Admin.ViewModels.User;
using App.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using System.Security.Claims;

namespace App.Web.Areas.Admin.Controllers
{
	public class UserController : AppControllerBase
	{
		readonly GenericRepository _repository;

		public UserController(GenericRepository repository, IMapper mapper) : base(mapper)
		{
			_repository = repository;
		}

		[AppAuthorize()]
		public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			// Chú ý dấu ngoặc khi dùng await cùng với GenRowIndex
			var data = (await _repository
				.GetAll<AppUser>(u => u.Username != this.CurrentUsername)
				.ProjectTo<UserListItemVM>(AutoMapperProfile.UserIndexConf)
				.ToPagedListAsync(page, size))
				.GenRowIndex();
			return View(data);
		}

		[AppAuthorize(AuthConst.AppUser.CREATE)]
		public IActionResult Create() => View();

		[HttpPost]
		[AppAuthorize(AuthConst.AppUser.CREATE)]
		public async Task<IActionResult> Create(UserAddOrEditVM model)
		{
			model.Username = model.Username.ToLower();
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return View(model);
			}

			if (await _repository.AnyAsync<AppUser>(u => u.Username.Equals(model.Username)))
			{
				SetErrorMesg("Tên đăng nhập này đã tồn tại!");
				return View(model);
			}

			try
			{
				var hashResult = HashHMACSHA512(model.Password);
				model.PasswordHash = hashResult.Value;
				model.PasswordSalt = hashResult.Key;
				var user = _mapper.Map<AppUser>(model);
				await _repository.AddAsync(user);
				SetSuccessMesg($"Thêm tài khoản [{user.Username}] thành công!");
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex)
			{
				LogException(ex);
				return View(model);
			}
		}

		[AppAuthorize(AuthConst.AppUser.UPDATE)]
		public async Task<IActionResult> Edit(int id)
		{
			var user = await _repository.FindAsync<AppUser>(id);
			if (user == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index));
			}
			var userEditVM = _mapper.Map<UserAddOrEditVM>(user);
			return View(userEditVM);
		}

		[HttpPost]
		[AppAuthorize(AuthConst.AppUser.UPDATE)]
		public async Task<IActionResult> Edit(UserAddOrEditVM model)
		{
			var user = await _repository.FindAsync<AppUser>(model.Id);
			// Không validate các trường dưới dây khi cập nhật
			ModelState.Remove("Password");
			ModelState.Remove("ConfirmPwd");

			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return View(model);
			}
			if (user == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index));
			}
			if (model.Username != user.Username)
			{
				SetErrorMesg("Không được thay đổi tên đăng nhập");
				return View(model);
			}

			try
			{
				user.Address = model.Address;
				user.AppRoleId = model.AppRoleId;
				user.Email = model.Email;
				user.FullName = model.FullName;
				user.PhoneNumber1 = model.PhoneNumber1;
				user.PhoneNumber2 = model.PhoneNumber2;
				await _repository.UpdateAsync(user);
				SetSuccessMesg($"Cập nhật tài khoản [{user.Username}] thành công");
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex)
			{
				LogException(ex);
				return View(model);
			}
		}

		//[AppAuthorize(AuthConst.AppUser.DELETE)]
		//public async Task<IActionResult> Delete(int id)
		//{
		//	var user = await _repository.FindAsync<AppUser>(id);
		//	if (user == null)
		//	{
		//		SetErrorMesg("Tài khoản không tồn tại hoặc đã được xóa trước đó");
		//		return RedirectToAction(nameof(Index));
		//	}
		//	await _repository.DeleteAsync(user);
		//	SetSuccessMesg($"Tài khoản [{user.Username}] được xóa thành công");
		//	return RedirectToAction(nameof(Index));
		//}

		//[AppAuthorize(AuthConst.AppUser.BLOCK)]
		//public async Task<IActionResult> BlockUser(int id)
		//{
		//	var data = await _repository.FindAsync<AppUser>(id);
		//	return PartialView(data);
		//}
		[HttpPost]
		[AppAuthorize(AuthConst.AppUser.BLOCK)]
		public async Task<IActionResult> BlockUser(BlockUserVM data)
		{
			try
			{
				var user = await _repository.FindAsync<AppUser>(data.Id);
				user.BlockedBy = CurrentUserId;
				if (data.Permanentblock)
				{
					var date = DateTime.Now;
					var blockTime = date.AddYears(100);
					user.BlockedTo = blockTime;
				}
				else
				{
					user.BlockedTo = data.BlockedTo;
				}
				SetSuccessMesg($"Khóa tài khoản [{user.Username}] thành công!");
				await _repository.UpdateAsync<AppUser>(user);
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				SetErrorMesg($"Có lỗi trong quá trình xử lý!");
				return RedirectToAction(nameof(Index));
			}

		}
		[AppAuthorize(AuthConst.AppUser.UNBLOCK)]
		public async Task<IActionResult> UnBlockUser(int id)
		{
			var user = await _repository.FindAsync<AppUser>(id);
			user.BlockedTo = null;
			user.BlockedBy = null;
			await _repository.UpdateAsync(user);
			SetSuccessMesg($"Mở khóa tài khoản [{user.Username}] thành công!");
			return RedirectToAction(nameof(Index));
		}
	}
}
