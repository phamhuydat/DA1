using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using App.Share.Extensions;
using App.Web.Areas.Admin.ViewModels.NewsCategory;
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
    public class NewsCategoryController : AppControllerBase
    {
        private readonly GenericRepository _repo;
        public NewsCategoryController(IMapper mapper, GenericRepository repo) : base(mapper)
        {
            _repo = repo;
        }

        [AppAuthorize(AuthConst.AppNewsCategory.VIEW_LIST)]
        public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
        {
            var data = (await _repo
                .GetAll<AppNewsCategory>()
                .Where(x => x.DeletedDate == null)
                .ProjectTo<NewsCategoryListItemVM>(AutoMapperProfile.NewsCategoryConf)
                .ToPagedListAsync(page, size))
                ;
            return View(data);
        }
        [AppAuthorize(AuthConst.AppNewsCategory.CREATE)]
        public IActionResult Create() => View();
        [AppAuthorize(AuthConst.AppNewsCategory.CREATE)]
        [HttpPost]
        public async Task<IActionResult> Create(AddOrUpdateNewsCategoryVM model)
        {
            if (!ModelState.IsValid)
            {
                SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
                return View(model);
            }

            if (await _repo.AnyAsync<AppNewsCategory>(u => u.Slug.Equals(model.Title.Slugify()) && u.DeletedDate == null))
            {
                SetErrorMesg("Thể loại này đã tồn tại!");
                return View(model);
            }
            try
            {
                var category = _mapper.Map<AppNewsCategory>(model);
                category.CreatedBy = CurrentUserId;
                category.Slug = category.Title.Slugify();
                await _repo.AddAsync(category);
                SetSuccessMesg($"Thêm thể loại [{category.Title}] thành công!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            catch (Exception ex)
            {
                LogException(ex);
                return View(model);
            }
        }
        [AppAuthorize(AuthConst.AppNewsCategory.UPDATE)]
        public async Task<IActionResult> Update(int id)
        {
            var cate = await _repo.FindAsync<AppNewsCategory>(id);
            if (cate == null)
            {
                SetErrorMesg(PAGE_NOT_FOUND_MESG);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            var categoryVM = _mapper.Map<AddOrUpdateNewsCategoryVM>(cate);
            return View(categoryVM);
        }
        [AppAuthorize(AuthConst.AppNewsCategory.UPDATE)]
        [HttpPost]
        public async Task<IActionResult> Update(AddOrUpdateNewsCategoryVM model)
        {
            var category = await _repo.FindAsync<AppNewsCategory>(model.Id);

            if (!ModelState.IsValid)
            {
                SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
                return View(model);
            }
            if (category == null)
            {
                SetErrorMesg(PAGE_NOT_FOUND_MESG);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (await _repo.AnyAsync<AppNewsCategory>(u => u.Slug.Equals(model.Title.Slugify()) && u.Slug != category.Title.Slugify()))
            {
                SetErrorMesg("Thể loại này đã tồn tại!");
                return View(model);
            }
            try
            {
                _mapper.Map<AddOrUpdateNewsCategoryVM, AppNewsCategory>(model, category);
                category.UpdatedDate = DateTime.Now;
                category.Slug = model.Title.Slugify();
                await _repo.UpdateAsync(category);
                SetSuccessMesg($"Cập nhật thể loại [{category.Title}] thành công!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            catch (Exception ex)
            {
                LogException(ex);
                return View(model);
            }
        }
        [AppAuthorize(AuthConst.AppNewsCategory.DELETE)]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _repo.FindAsync<AppNewsCategory>(id);
            if (category == null)
            {
                SetErrorMesg("Thể loại không tồn tại hoặc đã được xóa trước đó!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (await _repo.AnyAsync<AppNews>(s => s.CategoryId.Equals(category.Id) && s.DeletedDate == null))
            {
                SetErrorMesg("Thể loại có tồn tại bài viết nên không thể xóa!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            await _repo.DeleteAsync(category);
            SetSuccessMesg($"Thê loại [{category.Title}] được xóa thành công!");
            return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
        }
    }
}
