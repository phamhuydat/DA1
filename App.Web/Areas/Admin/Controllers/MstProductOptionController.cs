//using App.Data.Entities.Products;
//using App.Data.Repositories;
//using App.Share.Consts;
//using App.Web.Areas.Admin.ViewModels.Product.MstProductSize;
//using App.Web.Common;
//using App.Web.WebConfig;
//using AutoMapper;
//using AutoMapper.QueryableExtensions;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Linq;
//using System.Threading.Tasks;
//using X.PagedList;

//namespace App.Web.Areas.Admin.Controllers
//{
//	public class MstProductOptionController : AppControllerBase
//	{
//		private readonly GenericRepository _repo;
//		public MstProductOptionController(IMapper mapper, GenericRepository repo) : base(mapper)
//		{
//			_repo = repo;
//		}
//		[AppAuthorize(AuthConst.MstProductSize.VIEW_LIST)]
//		public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
//		{
//			var data = (await _repo
//				.GetAllMst<MstProductSize>()
//				.Where(x => x.DeletedDate == null)
//				.ProjectTo<ProductSizeListItemVM>(AutoMapperProfile.MstProductSizeConf)
//				.ToPagedListAsync(page, size))
//				.GenRowIndex();
//			return View(data);
//		}
//		[AppAuthorize(AuthConst.MstProductSize.CREATE)]
//		[HttpPost]
//		public async Task<IActionResult> Index(AddOrUpdateProductSizeVM model)
//		{
//			if (!ModelState.IsValid)
//			{
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//			if (await _repo.DbContext.MstProductSizes.AnyAsync(u => u.SizeCode.ToLower().Equals(model.SizeCode.ToLower()) && u.DeletedDate == null))
//			{
//				SetErrorMesg("Size này đã tồn tại!");
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//			try
//			{
//				var size = _mapper.Map<MstProductSize>(model);
//				await _repo.AddMstAsync(size);
//				SetSuccessMesg($"Thêm size [{size.SizeCode}] thành công");
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//			catch (Exception ex)
//			{
//				LogException(ex);
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//		}
//		[AppAuthorize(AuthConst.MstProductSize.UPDATE)]
//		public async Task<IActionResult> GetDataForUpdate(int id)
//		{
//			var size = await _repo.FindMstAsync<MstProductSize>(id);
//			var sizeVM = _mapper.Map<AddOrUpdateProductSizeVM>(size);
//			return Ok(sizeVM);
//		}

//		[AppAuthorize(AuthConst.MstProductSize.UPDATE)]
//		[HttpPost]
//		public async Task<IActionResult> Update(AddOrUpdateProductSizeVM model)
//		{
//			var size = await _repo.FindMstAsync<MstProductSize>(model.Id);
//			if (!ModelState.IsValid)
//			{
//				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//			if (size == null)
//			{
//				SetErrorMesg(PAGE_NOT_FOUND_MESG);
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//			if (await _repo.DbContext.MstProductSizes
//				.AnyAsync(u => u.SizeCode.ToLower().Equals(model.SizeCode.ToLower()) && u.SizeCode != size.SizeCode && u.DeletedDate == null))
//			{
//				SetErrorMesg("Size này đã tồn tại!");
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//			try
//			{
//				_mapper.Map<AddOrUpdateProductSizeVM, MstProductSize>(model, size);
//				await _repo.UpdateMstAsync(size);
//				SetSuccessMesg($"Cập nhật size [{size.SizeCode}] thành công!");
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//			catch (Exception ex)
//			{
//				LogException(ex);
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//		}

//		[AppAuthorize(AuthConst.MstProductSize.DELETE)]
//		public async Task<IActionResult> Delete(int id)
//		{
//			var size = await _repo.FindMstAsync<MstProductSize>(id);
//			if (size == null)
//			{
//				SetErrorMesg("Size không tồn tại hoặc đã được xóa trước đó!");
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//			if (await _repo.AnyAsync<AppIntermediateProduct>(x => x.MstProductSizeId.Equals(size.Id)))
//			{
//				SetErrorMesg("Size này có tồn tại sản phẩm, không thể xóa!");
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//			await _repo.DeleteMstAsync(size);
//			SetSuccessMesg($"Size [{size.SizeCode}] được xóa thành công!");
//			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//		}
//	}
//}
