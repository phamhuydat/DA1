using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using App.Share.Extensions;
using App.Web.Areas.Admin.ViewModels.AppPolicy;
using App.Web.Common;
using App.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.Areas.Admin.Controllers
{
    public class AppPolicyController : AppControllerBase
    {
        private readonly GenericRepository _repo;
        public AppPolicyController(IMapper mapper, GenericRepository repo) : base(mapper)
        {
            _repo = repo;
        }
        [AppAuthorize(AuthConst.AppPolicy.VIEW_LIST)]
        public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
        {
            var data = (await _repo
                .GetAll<AppPolicy>()
                .Where(x => x.DeletedDate == null)
                .ProjectTo<PolicyListItemVM>(AutoMapperProfile.AppPolicyConf)
                .ToPagedListAsync(page, size))
                ;
            return View(data);
        }
        [AppAuthorize(AuthConst.AppPolicy.CREATE)]
        public IActionResult Create() => View();
        [AppAuthorize(AuthConst.AppPolicy.CREATE)]
        [HttpPost]
        public async Task<IActionResult> Create(AddOrUpdatePolicyVM model)
        {
            if (!ModelState.IsValid)
            {
                SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
                return View(model);
            }
            if (await _repo.AnyAsync<AppPolicy>(u => u.Slug.Equals(model.Title.Slugify().ToLower()) && u.DeletedDate == null))
            {
                SetErrorMesg("Chính sách này đã tồn tại");
                return View(model);
            }
            if (model.Content == null || model.Content == "")
            {
                ModelState.AddModelError("Content", "Trường này là bắt buộc!");
            }

            try
            {
                var policy = _mapper.Map<AppPolicy>(model);
                policy.CreatedBy = CurrentUserId;
                policy.UserId = CurrentUserId;
                policy.Slug = policy.Title.Slugify();
                await _repo.AddAsync(policy);
                SetSuccessMesg($"Thêm chính sách [{policy.Title}] thành công");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            catch (Exception ex)
            {
                LogException(ex);
                return View(model);
            }
        }
        [AppAuthorize(AuthConst.AppPolicy.UPDATE)]
        public async Task<IActionResult> Update(int id)
        {
            var policy = await _repo.FindAsync<AppPolicy>(id);
            if (policy == null)
            {
                SetErrorMesg(PAGE_NOT_FOUND_MESG);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            var policyVM = _mapper.Map<AddOrUpdatePolicyVM>(policy);
            return View(policyVM);
        }
        [AppAuthorize(AuthConst.AppPolicy.UPDATE)]
        [HttpPost]
        public async Task<IActionResult> Update(AddOrUpdatePolicyVM model)
        {
            var policy = await _repo.FindAsync<AppPolicy>(model.Id);

            if (!ModelState.IsValid)
            {
                SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
                return View(model);
            }
            if (policy == null)
            {
                SetErrorMesg(PAGE_NOT_FOUND_MESG);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (await _repo.AnyAsync<AppPolicy>(u => u.Slug.Equals(model.Title.Slugify()) && u.Slug != policy.Title.Slugify()))
            {
                SetErrorMesg("Chính sách này đã tồn tại !");
                return View(model);
            }
            try
            {
                _mapper.Map<AddOrUpdatePolicyVM, AppPolicy>(model, policy);
                policy.UpdatedDate = DateTime.Now;
                policy.Slug = model.Title.Slugify();
                await _repo.UpdateAsync(policy);
                SetSuccessMesg($"Cập nhật chính sách [{policy.Title}] thành công");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            catch (Exception ex)
            {
                LogException(ex);
                return View(model);
            }
        }
        [AppAuthorize(AuthConst.AppPolicy.VIEW_DETAIL)]
        public async Task<IActionResult> Detail(int id)
        {
            var policy = await _repo.FindAsync<AppPolicy>(id);
            if (policy == null)
            {
                SetErrorMesg(PAGE_NOT_FOUND_MESG);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            var policyVM = _mapper.Map<DetailPolicyVM>(policy);
            return View(policyVM);
        }
        [AppAuthorize(AuthConst.AppPolicy.DELETE)]
        public async Task<IActionResult> Delete(int id)
        {
            var policy = await _repo.FindAsync<AppPolicy>(id);
            if (policy == null)
            {
                SetErrorMesg("Chính sách này không tồn tại hoặc đã được xóa trước đó");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            await _repo.DeleteAsync(policy);
            SetSuccessMesg($"Chính sách [{policy.Title}] được xóa thành công");
            return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
        }
    }
}
