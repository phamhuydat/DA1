using App.Data.Entities.Products;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Areas.Admin.ViewModels.AppBranch;
using App.Web.Areas.Admin.ViewModels.MstProductColor;
using App.Web.Common;
using App.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.Areas.Admin.Controllers
{
    public class MstProductColorController : AppControllerBase
    {
        private readonly GenericRepository _repo;

        public MstProductColorController(IMapper mapper, GenericRepository repo) : base(mapper)
        {
            _repo = repo;
        }
        [AppAuthorize(AuthConst.MstProductColor.VIEW_LIST)]
        public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
        {
            var data = (await _repo
                .GetAllMst<MstProductColor>()
                .Where(x => x.DeletedDate == null)
                .ProjectTo<ProductColorListItemVM>(AutoMapperProfile.MstProductColorConf)
                .ToPagedListAsync(page, size))
                ;
            return View(data);
        }
        [AppAuthorize(AuthConst.MstProductColor.CREATE)]
        [HttpPost]
        public async Task<IActionResult> Index(AddOrUpdateProductColorVM model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (await _repo.DbContext.MstProductColors.AnyAsync(u => u.ColorName.ToLower().Equals(model.ColorName.ToLower()) && u.DeletedDate == null))
            {
                SetErrorMesg("Màu sắc này đã tồn tại!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            try
            {
                var color = _mapper.Map<MstProductColor>(model);
                await _repo.AddMstAsync(color);
                SetSuccessMesg($"Thêm màu sắc [{color.ColorName}] thành công");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            catch (Exception ex)
            {
                LogException(ex);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
        }

        [AppAuthorize(AuthConst.MstProductColor.UPDATE)]
        public async Task<IActionResult> GetDataForUpdate(int id)
        {
            var color = await _repo.FindMstAsync<MstProductColor>(id);
            var colorVM = _mapper.Map<AddOrUpdateProductColorVM>(color);
            return Ok(colorVM);
        }

        [AppAuthorize(AuthConst.MstProductColor.UPDATE)]
        [HttpPost]
        public async Task<IActionResult> Update(AddOrUpdateProductColorVM model)
        {
            var color = await _repo.FindMstAsync<MstProductColor>(model.Id);
            if (!ModelState.IsValid)
            {
                SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (color == null)
            {
                SetErrorMesg(PAGE_NOT_FOUND_MESG);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (await _repo.DbContext.MstProductColors
                .AnyAsync(u => u.ColorName.ToLower().Equals(model.ColorName.ToLower()) && u.ColorName != color.ColorName && u.DeletedDate == null))
            {
                SetErrorMesg("Màu sắc này đã tồn tại!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            try
            {
                _mapper.Map<AddOrUpdateProductColorVM, MstProductColor>(model, color);
                await _repo.UpdateMstAsync(color);
                SetSuccessMesg($"Cập nhật màu sắc [{color.ColorName}] thành công!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            catch (Exception ex)
            {
                LogException(ex);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
        }

        [AppAuthorize(AuthConst.MstProductColor.DELETE)]
        public async Task<IActionResult> Delete(int id)
        {
            var color = await _repo.FindMstAsync<MstProductColor>(id);
            if (color == null)
            {
                SetErrorMesg("Màu này không tồn tại hoặc đã được xóa trước đó!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (await _repo.AnyAsync<AppProductDetail>(x => x.ColorId.Equals(color.Id)))
            {
                SetErrorMesg("Màu sắc này có tồn tại sản phẩm, không thể xóa!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            await _repo.DeleteMstAsync(color);
            SetSuccessMesg($"Màu [{color.ColorName}] được xóa thành công!");
            return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
        }
    }
}
