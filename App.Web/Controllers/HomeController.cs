using App.Data.Entities.Products;
using App.Data.Repositories;
using App.Web.Models;
using App.Web.ViewModels.Product;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToastNotifications.Core;
using App.Web.WebConfig;
using App.Share.Consts;
using X.PagedList;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.EntityFrameworkCore;
using App.Data.Entities;

namespace App.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly INotyfService _notyf;
        private const int DEFAULT_PAGE_SIZE = 12;

        public HomeController(IMapper mapper, GenericRepository repository, INotyfService notyf)
            : base(mapper, repository)
        {
            _notyf = notyf;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.iphone = _repository.GetAll<AppProduct, ProductListVM>(AutoMapperProfile.ProductClientConf)
                    .Where(x => x.IsActive == true
                        && x.CategoryId == DB.AppProductCategory.IPHONE).Take(4);

            ViewBag.ipad = _repository.GetAll<AppProduct, ProductListVM>(AutoMapperProfile.ProductClientConf)
                    .Where(x => x.IsActive == true
                        && x.CategoryId == DB.AppProductCategory.IPAD
                        && x.IsMain == true).Take(4);

            ViewBag.mac = _repository.GetAll<AppProduct, ProductListVM>(AutoMapperProfile.ProductClientConf)
                    .Where(x => x.IsActive == true
                        && x.CategoryId == DB.AppProductCategory.MAC
                        && x.IsMain == true).Take(4);

            ViewBag.watch = _repository.GetAll<AppProduct, ProductListVM>(AutoMapperProfile.ProductClientConf)
                    .Where(x => x.IsActive == true
                        && x.CategoryId == DB.AppProductCategory.WATCH
                        && x.IsMain == true).Take(4);

            ViewBag.accessory = _repository.GetAll<AppProduct, ProductListVM>(AutoMapperProfile.ProductClientConf)
                    .Where(x => x.IsActive == true
                        && x.CategoryId == DB.AppProductCategory.ACCESSORY
                        && x.IsMain == true).Take(8);
            return View();
        }

        public async Task<IActionResult> SearchProducts(string? search)
        {
            return View(search);
        }

        public async Task<IActionResult> GetProductByCategory(int id, int? filler = null, int page = 1, int size = DEFAULT_PAGE_SIZE)
        {
            ViewBag.Category = _repository.FindAsync<AppProductCategory>(id);
            if (filler == 1)
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                            (AutoMapperProfile.ProductClientConf)
                            .Where(x => x.DeletedDate == null)
                            .OrderBy(x => x.id).ToListAsync();
                return View(data);
            }
            if (filler == 2)
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                        (AutoMapperProfile.ProductClientConf)
                        .Where(x => x.DeletedDate == null)
                        .OrderBy(x => x.ProductName).ToListAsync();
                return View(data);
            }
            if (filler == 3)
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                        (AutoMapperProfile.ProductClientConf)
                        .Where(x => x.DeletedDate == null)
                        .OrderByDescending(x => x.ProductName).ToListAsync();
                return View(data);
            }
            if (filler == 4)
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                            (AutoMapperProfile.ProductClientConf)
                            .OrderBy(x => x.DiscountPrice)
                            .OrderBy(x => x.Price)
                            .Where(x => x.DeletedDate == null)
                            .ToListAsync();
                return View(data);
            }
            if (filler == 5)
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                        (AutoMapperProfile.ProductClientConf)
                        .OrderByDescending(x => x.DiscountPrice)
                        .OrderByDescending(x => x.Price)
                        .Where(x => x.DeletedDate == null)
                        .ToListAsync();
                return View(data);
            }

            else
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                        (AutoMapperProfile.ProductClientConf)
                        .Where(x => x.CategoryId == id)
                        .Where(x => x.DeletedDate == null)
                        .ToListAsync();
                return View(data);
            }
        }
    }
}
