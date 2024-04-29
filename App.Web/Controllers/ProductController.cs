using App.Data.Entities;
using App.Data.Entities.Products;
using App.Data.Repositories;
using App.Share.Consts;
using App.Share.Extensions;
using App.Web.Common;
using App.Web.ViewModels.News;
using App.Web.ViewModels.Product;
using App.Web.WebConfig;
using App.Web.WebConfig.Consts;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Controllers
{
    public class ProductController : BaseController
    {
        private readonly INotyfService _notyf;
        private const int DEFAULT_PAGE_SIZE = 30;
        private const int MAX_RECENT_PRODUCT = 8;
        public ProductController(IMapper mapper, GenericRepository repository, INotyfService notyf) : base(mapper, repository)
        {
            _notyf = notyf;
        }

        public async Task<IActionResult> ProductDetail(int id)
        {
            var product = await _repository.GetOneAsync<AppProduct, ProductDetailClientVM>(id, p => new ProductDetailClientVM
            {
                Id = p.Id,
                ProductName = p.ProductName,
                CategoryName = p.AppProdcutCategory.Name,
                Price = p.AppProductDetails.First().Price,
                DiscountPrice = p.AppProductDetails.First().DiscountPrice,
                DiscountFrom = p.AppProductDetails.First().DiscountFrom,
                DiscountTo = p.AppProductDetails.First().DiscountTo,
                AppProductImages = p.AppProductImages.Where(x => x.ProductId == id).ToList(),
                CategoryId = p.AppProdcutCategory.Id,
                ProductColorId = p.AppProductDetails.First().ColorId,
                ProductCode = p.ProductCode,
            });

            if (product is null)
            {
                _notyf.Error("Sản phẩm không tồn tại!");
                return RedirectToAction(nameof(Index), "Home");
            }
            ViewBag.CategoryName = product.CategoryName;
            return View(product);
        }


        public async Task<IActionResult> ProductSearch(string search)
        {
            var listProduct = 1;

            return View(listProduct);
        }

    }
}
