//using App.Data.Entities;
//using App.Data.Entities.Products;
//using App.Data.Repositories;
//using App.Share.Consts;
//using App.Share.Extensions;
//using App.Web.Areas.Admin.ViewModels.Product;
//using App.Web.Areas.Admin.ViewModels.ProductCategory;
//using App.Web.Common;
//using App.Web.WebConfig;
//using AutoMapper;
//using AutoMapper.QueryableExtensions;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using X.PagedList;
//using static log4net.Appender.ColoredConsoleAppender;

//namespace App.Web.Areas.Admin.Controllers
//{
//	public class ProductController : AppControllerBase
//	{
//		private readonly GenericRepository _repo;
//		public ProductController(IMapper mapper, GenericRepository repo) : base(mapper)
//		{
//			_repo = repo;
//		}

//		[AppAuthorize(AuthConst.AppProduct.VIEW_LIST)]
//		public async Task<IActionResult> Index(SearchProductVM search, int page = 1, int size = DEFAULT_PAGE_SIZE)
//		{
//			var data = await GetListProductAsync(search, page, size);

//			var listCate = await _repo
//				.GetAll<AppProductCategory>(x => (x.CateLevel.Equals(2) || x.CateLevel.Equals(3)) && x.DeletedDate == null)
//				.Include(x => x.ParentCategory)
//				.ProjectTo<ListProductCateSelectVM>(AutoMapperProfile.ProductCategorySelectConf)
//				.ToListAsync();
//			var listBrand = await _repo
//				.GetAllMst<MstProductBrand>()
//				.Where(x => x.DeletedDate == null)
//				.ToListAsync();
//			var listColor = await _repo
//				.GetAllMst<MstProductColor>()
//				.Where(x => x.DeletedDate == null)
//				.ToListAsync();
//			var listSize = await _repo
//				.GetAllMst<MstProductSize>()
//				.Where(x => x.DeletedDate == null)
//				.ToListAsync();

//			ViewBag.ProductCategories = new SelectList(listCate, "Id", "Name", search.CateId, "CateLevel");
//			ViewBag.Brands = new SelectList(listBrand, "Id", "Name", search.BrandId);
//			ViewBag.Colors = new SelectList(listColor, "Id", "ColorName", search.ColorId);
//			ViewBag.Size = new SelectList(listSize, "Id", "SizeCode", search.SizeId);

//			ViewBag.ProductName = search.ProductName;
//			ViewBag.CateId = search.CateId;
//			ViewBag.BrandId = search.BrandId;
//			ViewBag.ColorId = search.ColorId;
//			ViewBag.SizeId = search.SizeId;
//			ViewBag.IsDiscount = search.IsDiscount;
//			return View(data);
//		}
//		private async Task<IPagedList<ListItemProductVM>> GetListProductAsync(SearchProductVM search, int page, int size)
//		{
//			var defaultWhere = _repo.GetDefaultWhereExpr<AppProduct>(false);
//			var query = _repo.DbContext
//							.AppProducts
//							.AsNoTracking()
//							.Where(defaultWhere);
//			if (!search.ProductName.IsNullOrEmpty())
//			{
//				query = query.Where(x => x.ProductName.Contains(search.ProductName) || x.Slug.Contains(search.ProductName.Slugify()));
//			}
//			if (search.CateId != null)
//			{
//				query = query.Where(x => x.CategoryId == search.CateId || x.ProductCategory.ParentCateId == search.CateId
//						|| x.ProductCategory.ParentCategory.ParentCateId == search.CateId);
//			}
//			if (search.BrandId != null)
//			{
//				query = query.Where(x => x.BrandId == search.BrandId);
//			}
//			if (search.IsDiscount == true)
//			{
//				var now = DateTime.Now;
//				query = query.Where(x => x.DiscountPrice.HasValue
//					&& (x.DiscountFrom ?? DateTime.MinValue) < now
//					&& (x.DiscountTo ?? DateTime.MaxValue) > now);
//			}
//			var data = (await query.Include(x => x.AppIntermediateProducts)
//									.ThenInclude(x => x.AppProductQuantities)
//									.Include(x => x.AppIntermediateProducts)
//									.ThenInclude(x => x.MstProductSize)
//									.OrderByDescending(m => m.DisplayOrder)
//									.ThenByDescending(m => m.Id)
//									.ProjectTo<ListItemProductVM>(AutoMapperProfile.ProductsConf)
//									.ToPagedListAsync(page, size))
//								.GenRowIndex();
//			return data;
//		}
//		[AppAuthorize(AuthConst.AppProduct.CREATE)]
//		public async Task<IActionResult> Create()
//		{
//			ViewBag.CheckProductCode = true;
//			ViewBag.ListSize = await GetListSize();
//			return View();
//		}
//		[AppAuthorize(AuthConst.AppProduct.CREATE)]
//		[HttpPost]
//		public async Task<IActionResult> Create([FromServices] AddOrUpdateProductVM model)
//		{
//			var imgs = new string[] { model.LinkImage1 , model.LinkImage2 , model.LinkImage3,
//										model.LinkImage4 , model.LinkImage5 , model.LinkImage6 };
//			var now = DateTime.Now;
//			for (var i = 0; i < imgs.Length; i++)
//			{
//				var img = imgs[i] ?? "";

//				model.AppProductImages.Add(new AppProductImage
//				{
//					ImagePath = img,
//					CreatedBy = CurrentUserId,
//					UpdatedBy = CurrentUserId,
//					CreatedDate = now,
//					UpdatedDate = now
//				});
//			}
//			var product = _mapper.Map<AppProduct>(model);
//			if (!ModelState.IsValid)
//			{
//				ViewBag.ListSize = await GetListSize();
//				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
//				ViewBag.CheckProductCode = true;
//				return View(model);
//			}
//			if (await _repo.AnyAsync<AppProduct>(s => s.ProductCode.Equals(model.ProductCode) && s.DeletedDate == null))
//			{
//				ViewBag.ListSize = await GetListSize();
//				ViewBag.CheckProductCode = true;
//				ModelState.AddModelError("ProductCode", "Mã sản phẩm đã tồn tại!");
//				return View(model);
//			}
//			if (model.Price <= model.DiscountPrice)
//			{
//				ViewBag.ListSize = await GetListSize();
//				SetErrorMesg("Giá khuyến mãi không thể cao hơn hoặc bằng giá gốc!");
//				ViewBag.CheckProductCode = true;
//				return View(model);
//			}
//			try
//			{
//				product.Slug = product.ProductName.Slugify();
//				product.CreatedBy = CurrentUserId;
//				product.IsActive = true;

//				await _repo.AddAsync(product);
//				SetSuccessMesg($"Thêm sản phẩm [{product.ProductName}] thành công!");
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//			catch (Exception ex)
//			{
//				ViewBag.ListSize = await GetListSize();
//				ViewBag.CheckProductCode = true;
//				LogException(ex);
//				return View(model);
//			}
//		}
//		[AppAuthorize(AuthConst.AppProduct.DELETE)]
//		public async Task<IActionResult> Delete(int id)
//		{
//			var product = await _repo.FindAsync<AppProduct>(id);
//			if (product == null)
//			{
//				SetErrorMesg("Bài viết này không tồn tại hoặc đã được xóa trước đó!");
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//			// Gỡ khóa ngoại
//			product.CategoryId = null;
//			product.BrandId = null;
//			product.ProductColorId = null;

//			await _repo.DeleteAsync(product);
//			SetSuccessMesg($"Sản phẩm [{product.ProductName}] được xóa thành công!");
//			if (Referer != null)
//			{
//				return Redirect(Referer);
//			}
//			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//		}
//		[AppAuthorize(AuthConst.AppProduct.PUBLIC)]
//		public async Task<IActionResult> PublicProduct(int id)
//		{
//			var product = await _repo.FindAsync<AppProduct>(id);
//			if (product == null)
//			{
//				SetErrorMesg(PAGE_NOT_FOUND_MESG);
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//			product.IsActive = true;
//			await _repo.UpdateAsync(product);
//			SetSuccessMesg($"Công khai sản phẩm [{product.ProductName}] thành công!");
//			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//		}
//		[AppAuthorize(AuthConst.AppProduct.UNPUBLIC)]
//		public async Task<IActionResult> UnPublicProduct(int id)
//		{
//			var product = await _repo.FindAsync<AppProduct>(id);
//			if (product == null)
//			{
//				SetErrorMesg(PAGE_NOT_FOUND_MESG);
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//			product.IsActive = false;
//			await _repo.UpdateAsync(product);
//			SetSuccessMesg($"Gỡ sản phẩm [{product.ProductName}] thành công!");
//			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//		}
//		[AppAuthorize(AuthConst.AppProduct.UPDATE)]
//		public async Task<IActionResult> ProductGhim(int id = 0)
//		{
//			if (id > 0)
//			{
//				var product = await _repo.FindAsync<AppProduct>(id);
//				var maxDisplayOrder = _repo
//						.DbContext.AppProducts.Max(x => x.DisplayOrder);
//				product.DisplayOrder = maxDisplayOrder != null ? maxDisplayOrder + 1 : 1;
//				await _repo.UpdateAsync(product);
//			}
//			return Redirect(Referer);
//		}
//		[AppAuthorize(AuthConst.AppProduct.UPDATE)]
//		public async Task<IActionResult> ProductUnGhim(int id = 0)
//		{
//			if (id > 0)
//			{
//				var product = await _repo.FindAsync<AppProduct>(id);
//				product.DisplayOrder = null;
//				await _repo.UpdateAsync(product);
//			}
//			return Redirect(Referer);
//		}
//		[AppAuthorize(AuthConst.AppProduct.UPDATE)]
//		public async Task<IActionResult> Update(int? id)
//		{
//			ViewBag.CheckProductCode = false;
//			ViewBag.ListSize = await GetListSize();
//			if (id is null)
//			{
//				SetErrorMesg("Không tìm thấy sản phẩm!");
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}

//			var product = await GetProductById(id.Value);
//			if (product is null)
//			{
//				SetErrorMesg("Không tìm thấy sản phẩm!");
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//			ViewBag.BeforeUrl = Referer;
//			return View(product);
//		}
//		[HttpPost]
//		[AppAuthorize(AuthConst.AppProduct.UPDATE)]
//		public async Task<IActionResult> Update(AddOrUpdateProductVM product)
//		{
//			if (product.Price <= product.DiscountPrice)
//			{
//				ViewBag.CheckProductCode = false;
//				ViewBag.ListSize = await GetListSize();
//				SetErrorMesg("Giá khuyến mãi không thể cao hơn hoặc bằng giá gốc!");
//				return View(product);
//			}
//			try
//			{
//				var oldProduct = await _repo.FindAsync<AppProduct>(product.Id);

//				if (oldProduct is null)
//				{
//					ViewBag.CheckProductCode = false;
//					ViewBag.ListSize = await GetListSize();
//					SetErrorMesg("Không tìm thấy sản phẩm cần cập nhật!");
//					return View(product);
//				}

//				// Cập nhật sản phẩm
//				_mapper.Map(product, oldProduct);
//				oldProduct.Slug = product.ProductName.Slugify();
//				oldProduct.AppIntermediateProducts = null;
//				await _repo.UpdateAsync(oldProduct);

//				// Cập nhật ảnh sản phẩm
//				var productImgs = (await _repo.GetAll<AppProductImage>(x => x.ProductId == product.Id)
//										.ToListAsync());
//				// Cố định thứ tự update
//				productImgs = productImgs.OrderBy(x => x.Id).ToList();
//				var imgs = new string[] { product.LinkImage1 , product.LinkImage2 , product.LinkImage3,
//										product.LinkImage4 , product.LinkImage5 , product.LinkImage6 };
//				var now = DateTime.Now;
//				for (var i = 0; i < productImgs.Count; i++)
//				{
//					var img = imgs[i];
//					productImgs[i].ImagePath = img;
//					productImgs[i].UpdatedBy = CurrentUserId;
//					productImgs[i].UpdatedDate = now;
//				}
//				await _repo.UpdateAsync(productImgs);

//				// Update số lượng size
//				var listTemp = await _repo
//					.GetAll<AppIntermediateProduct>(x => x.ProductId == product.Id)
//					.OrderBy(x => x.Id)
//					.ToListAsync();
//				var newListQuantity = product.AppIntermediateProducts.ToList();
//				for (int i = 0; i < listTemp.Count; i++)
//				{
//					var item = listTemp[i];
//					var listQuantity = newListQuantity[i].AppProductQuantities.ToList();
//					var quantity = await _repo.GetOneAsync<AppProductQuantity>(x => x.AppIntermediateId == item.Id);
//					quantity.InStock = listQuantity[0].InStock;
//					quantity.UpdatedBy = CurrentUserId;
//					quantity.UpdatedDate = now;
//					await _repo.UpdateAsync(quantity);
//				}

//				SetSuccessMesg($"Cập nhật sản phẩm [{product.ProductName}] thành công!");
//				var indexUrl = Request.Form["beforeUrl"].ToString();
//				if (indexUrl.IsNullOrEmpty())
//				{
//					return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//				}
//				return Redirect(indexUrl);
//			}
//			catch (Exception ex)
//			{
//				ViewBag.CheckProductCode = false;
//				ViewBag.ListSize = await GetListSize();
//				LogException(ex);
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//		}
//		private async Task<AddOrUpdateProductVM> GetProductById(int id)
//		{
//			var product = await _repo.GetAll<AppProduct>()
//				.Include(s => s.AppProductImages)
//				.Include(s => s.AppIntermediateProducts)
//				.ThenInclude(x => x.AppProductQuantities)
//				.SingleOrDefaultAsync(s => s.Id.Equals(id));
//			return _mapper.Map<AddOrUpdateProductVM>(product);
//		}
//		private async Task<List<MstProductSize>> GetListSize()
//		{
//			return await _repo
//						.GetAllMst<MstProductSize>()
//						.ToListAsync();
//		}

//		public async Task<IActionResult> ProductDetail(int? id)
//		{
//			if (id is null)
//			{
//				SetErrorMesg("Không tìm thấy sản phẩm!");
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}

//			var product = await GetProductDetail(id.Value);
//			if (product is null)
//			{
//				SetErrorMesg("Không tìm thấy sản phẩm!");
//				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//			}
//			ViewBag.ListSize = await GetListSize();
//			ViewBag.BeforeUrl = Referer;
//			return View(product);
//		}
//		private async Task<ProductDetailVM> GetProductDetail(int id)
//		{
//			var product = await _repo.GetAll<AppProduct>()
//				.Include(s => s.AppProductImages)
//				.Include(s => s.AppIntermediateProducts)
//				.ThenInclude(x => x.AppProductQuantities)
//				.Include(s => s.AppIntermediateProducts)
//				.ThenInclude(x => x.MstProductSize)
//				.ProjectTo<ProductDetailVM>(AutoMapperProfile.ProductDetailConf)
//				.SingleOrDefaultAsync(s => s.Id.Equals(id));
//			return product;
//		}
//		[AppAuthorize(AuthConst.AppProduct.DELETE)]
//		public async Task<IActionResult> BulkDelete(List<int> ids)
//		{
//			if (ids.Count > 0)
//			{
//				await _repo.DeleteAsync<AppProduct>(ids);
//				SetSuccessMesg($"Đã xóa {ids.Count} sản phẩm!");
//			}
//			else
//			{
//				SetErrorMesg("Chưa có sản phẩm nào được chọn!");
//			}
//			if (!Referer.IsNullOrEmpty())
//			{
//				return Redirect(Referer);
//			}
//			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
//		}
//	}
//}
