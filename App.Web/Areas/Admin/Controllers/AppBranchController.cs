using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Areas.Admin.ViewModels.AppBranch;
using App.Web.Areas.Admin.ViewModels.MstProductBrand;
using App.Web.Common;
using App.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.Areas.Admin.Controllers
{
    public class AppBranchController : AppControllerBase
    {
        private readonly GenericRepository _repo;

        public AppBranchController(IMapper mapper, GenericRepository repo) : base(mapper)
        {
            _repo = repo;
        }
        [AppAuthorize(AuthConst.AppBranch.VIEW_LIST)]
        public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
        {
            var data = (await _repo
                .GetAll<AppBranch>(x => x.DeletedDate == null)
                .ProjectTo<BranchListItemVM>(AutoMapperProfile.AppBranchConf)
                .ToPagedListAsync(page, size))
                ;
            return View(data);
        }
        [AppAuthorize(AuthConst.AppBranch.CREATE)]
        [HttpPost]
        public async Task<IActionResult> Index(AddOrUpdateBranchVM model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (await _repo.AnyAsync<AppBranch>(u => u.Address.Equals(model.Address) && u.DeletedDate == null))
            {
                SetErrorMesg("Chi nhánh đã tồn tại!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            try
            {
                var branch = _mapper.Map<AppBranch>(model);
                branch.CreatedBy = CurrentUserId;
                await _repo.AddAsync(branch);
                SetSuccessMesg($"Thêm chi nhánh [{branch.Address}] thành công");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            catch (Exception ex)
            {
                LogException(ex);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
        }

        [AppAuthorize(AuthConst.AppBranch.UPDATE)]
        public async Task<IActionResult> GetDataForUpdate(int id)
        {
            var branch = await _repo.FindAsync<AppBranch>(id);
            var branchVM = _mapper.Map<AddOrUpdateBranchVM>(branch);
            return Ok(branchVM);
        }

        [AppAuthorize(AuthConst.AppBranch.UPDATE)]
        [HttpPost]
        public async Task<IActionResult> Update(AddOrUpdateBranchVM model)
        {
            var branch = await _repo.FindAsync<AppBranch>(model.Id);
            if (!ModelState.IsValid)
            {
                SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (branch == null)
            {
                SetErrorMesg(PAGE_NOT_FOUND_MESG);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (await _repo.AnyAsync<AppBranch>(u => u.Address.ToLower().Equals(model.Address.ToLower()) && u.Address != branch.Address && u.DeletedDate == null))
            {
                SetErrorMesg("Chi nhánh này đã tồn tại!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            try
            {
                _mapper.Map<AddOrUpdateBranchVM, AppBranch>(model, branch);
                await _repo.UpdateAsync(branch);
                SetSuccessMesg($"Cập nhật chi nhánh [{branch.Address}] thành công!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            catch (Exception ex)
            {
                LogException(ex);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
        }

        [AppAuthorize(AuthConst.AppBranch.DELETE)]
        public async Task<IActionResult> Delete(int id)
        {
            var branch = await _repo.FindAsync<AppBranch>(id);
            if (branch == null)
            {
                SetErrorMesg("Chi nhánh không tồn tại hoặc đã được xóa trước đó!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            await _repo.DeleteAsync(branch);
            SetSuccessMesg($"Chi nhánh [{branch.Address}] được xóa thành công!");
            return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
        }
    }
}
