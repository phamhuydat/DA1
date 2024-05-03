using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using App.Share.Extensions;
using App.Web.Areas.Admin.ViewModels.ProductCategory;
using App.Web.Common;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Areas.Admin.Controllers
{
    public class ProductCategoryController : AppControllerBase
    {
        private readonly GenericRepository _repo;
        public ProductCategoryController(IMapper mapper, GenericRepository repo) : base(mapper)
        {
            _repo = repo;
        }

        [AppAuthorize(AuthConst.AppProductCategory.VIEW_LIST)]
        public IActionResult Index()
        {
            return View();
        }
        [AppAuthorize(AuthConst.AppProductCategory.CREATE)]
        [HttpPost]
        public async Task<IActionResult> Index(AddOrUpdateProductCategoryVM productCate)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.IsShow = true;
                SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
                return View(productCate);
            }
            if (await _repo.AnyAsync<AppProductCategory>(u => u.Name.Equals(productCate.Name) && u.DeletedDate == null))
            {
                ViewBag.IsShow = true;
                SetErrorMesg("Danh mục này đã tồn tại!");
                return View(productCate);
            }
            try
            {
                var cate = _mapper.Map<AppProductCategory>(productCate);
                cate.CreatedBy = CurrentUserId;
                if (productCate.ParentCateId == -1 || productCate.ParentCateId == null)
                {
                    // Tính displayOrder
                    var newDisplayOrder = _repo.DbContext.AppProductCategories
                                            .Where(x => x.CateLevel == 1 && x.DisplayOrder != null)
                                            .Min(x => x.DisplayOrder) ?? 0;
                    cate.DisplayOrder = newDisplayOrder - 1;
                    cate.ParentCateId = null;
                    cate.HasChild = false;
                    cate.CateLevel = 1;
                    //cate.Slug = productCate.Name.Slugify();
                }
                else
                {
                    var parent = await _repo.FindAsync<AppProductCategory>((int)productCate.ParentCateId);
                    cate.CateLevel = parent.CateLevel + 1;
                    //cate.Slug = $"{parent.Name} {cate.Name}".Slugify();
                    parent.HasChild = true;
                    await _repo.UpdateAsync(parent);
                }
                await _repo.AddAsync(cate);
                SetSuccessMesg($"Thêm danh mục [{cate.Name}] thành công!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            catch (Exception ex)
            {
                LogException(ex);
                return View(productCate);
            }
        }
        [AppAuthorize(AuthConst.AppProductCategory.UPDATE)]
        public async Task<IActionResult> Update(int id)
        {
            var productCate = await _repo.FindAsync<AppProductCategory>(id);
            if (productCate == null)
            {
                SetErrorMesg(PAGE_NOT_FOUND_MESG);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            var postVM = _mapper.Map<AddOrUpdateProductCategoryVM>(productCate);
            return View(postVM);
        }
        [AppAuthorize(AuthConst.AppProductCategory.UPDATE)]
        [HttpPost]
        public async Task<IActionResult> Update(AddOrUpdateProductCategoryVM model)
        {
            var cate = await _repo.FindAsync<AppProductCategory>(model.Id);
            if (cate.CateLevel.Equals(1))
            {
                model.ParentCateId = null;
            }
            if (!ModelState.IsValid)
            {
                SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
                return View(model);
            }
            if (cate == null)
            {
                SetErrorMesg(PAGE_NOT_FOUND_MESG);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (await _repo.AnyAsync<AppProductCategory>(u => u.CateLevel.Equals(cate.CateLevel) && u.Name.Equals(model.Name) && u.Name != cate.Name && u.DeletedDate == null))
            {
                SetErrorMesg("Danh mục này đã tồn tại!");
                return View(model);
            }
            try
            {
                var data = _mapper.Map(model, cate);
                cate.UpdatedDate = DateTime.Now;
                // cate.Slug = cate.Name.Slugify();
                await _repo.UpdateAsync(data);
                SetSuccessMesg($"Cập nhật danh mục [{cate.Name}] thành công!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            catch (Exception ex)
            {
                LogException(ex);
                return View(model);
            }
        }
        [AppAuthorize(AuthConst.AppProductCategory.DELETE)]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _repo.FindAsync<AppProductCategory>(id);
            if (category == null)
            {
                SetErrorMesg("Danh mục này không tồn tại hoặc đã được xóa trước đó!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (category.HasChild)
            {
                SetErrorMesg("Danh mục có chứa danh mục con nên không thể xóa!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (category.CateLevel.Equals(1) && category.AppProducts.Count > 0)
            {
                SetErrorMesg("Danh mục có chứa sản phẩm nên không thể xóa!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (category.CateLevel.Equals(2) && category.AppProducts.Count > 0)
            {
                SetErrorMesg("Danh mục có chứa sản phẩm nên không thể xóa!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (category.ParentCateId != null)
            {
                var parent = await _repo.FindAsync<AppProductCategory>((int)category.ParentCateId);
                if (parent.ChildCategories.Count == 1)
                {
                    parent.HasChild = false;
                    await _repo.UpdateAsync(parent);
                }
            }
            await _repo.DeleteAsync(category);
            SetSuccessMesg($"Danh mục [{category.Name}] được xóa thành công!");
            return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
        }
    }
}
