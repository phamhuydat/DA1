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
using App.Share.Extensions;
using AutoMapper.QueryableExtensions;

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
                        && x.CategoryId == DB.AppProductCategory.IPAD).Take(4);

            ViewBag.mac = _repository.GetAll<AppProduct, ProductListVM>(AutoMapperProfile.ProductClientConf)
                    .Where(x => x.IsActive == true
                        && x.CategoryId == DB.AppProductCategory.MAC
                      ).Take(4);

            ViewBag.watch = _repository.GetAll<AppProduct, ProductListVM>(AutoMapperProfile.ProductClientConf)
                    .Where(x => x.IsActive == true
                        && x.CategoryId == DB.AppProductCategory.WATCH
                        ).Take(4);

            ViewBag.accessory = _repository.GetAll<AppProduct, ProductListVM>(AutoMapperProfile.ProductClientConf)
                    .Where(x => x.IsActive == true
                        && x.CategoryId == DB.AppProductCategory.ACCESSORY
                       ).Take(8);
            return View();
        }

        public async Task<IActionResult> SearchProducts(string search = "", int orderby = 0, int page = 1, int size = DEFAULT_PAGE_SIZE)
        {
            if (search is null)
            {
                _notyf.Error("Không tìm thấy sản phẩm");
                return View();
            }
            var data = await _repository.GetAll<AppProduct, ProductListVM>(AutoMapperProfile.ProductClientConf)
                        .Where(x => x.IsActive == true
                         && x.DeletedDate == null && x.ProductName.Contains(search.Slugify()))
                                .ToPagedListAsync(page, size);

            ViewBag.keyword = search;
            ViewBag.countSearch = data.Count;
            return View(data);
        }
        [Route("San-pham-theo-danh-muc/{id}")]
        public async Task<IActionResult> GetProductByCategory(int id = 0, int orderby = 0, int page = 1, int size = DEFAULT_PAGE_SIZE)
        {

            var cate = await _repository
                        .GetOneAsync<AppProductCategory>(s => s.Id == id);

            if (cate == null) return NotFound();

            var listCateId = new List<int>();
            if (cate.CateLevel == 1)
            {
                listCateId = await _repository.GetAll<AppProductCategory>(s => s.ParentCateId.Equals(cate.Id))
                        .Select(x => x.Id)
                        .ToListAsync();

                listCateId.Add(cate.Id);
            }
            else
            {
                listCateId.Add(cate.Id);
            }
            ViewBag.cateId_by = listCateId.Last();

            if (orderby == 15)
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                            (AutoMapperProfile.ProductClientConf)
                            .Where(x => x.CategoryId == id)
                            .Where(x => x.DeletedDate == null)
                            .OrderBy(x => x.id)
                            .ToPagedListAsync(page, size);
                return View(data);
            }
            if (orderby == 5)
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                        (AutoMapperProfile.ProductClientConf)
                        .Where(x => x.CategoryId == id)
                        .Where(x => x.DeletedDate == null)
                        .OrderBy(x => x.ProductName).ToPagedListAsync(page, size);

                return View(data);
            }
            if (orderby == 6)
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                        (AutoMapperProfile.ProductClientConf)
                        .Where(x => x.CategoryId == id)

                        .Where(x => x.DeletedDate == null)
                        .OrderByDescending(x => x.ProductName).ToPagedListAsync(page, size);
                return View(data);
            }

            if (orderby == 4)
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                            (AutoMapperProfile.ProductClientConf)
                            .OrderBy(x => x.DiscountPrice)
                            .Where(x => x.CategoryId == id)
                            .OrderBy(x => x.Price)
                            .Where(x => x.DeletedDate == null)
                            .ToPagedListAsync(page, size);
                return View(data);
            }
            if (orderby == 10)
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                        (AutoMapperProfile.ProductClientConf)
                        .OrderByDescending(x => x.DiscountPrice)
                        .OrderByDescending(x => x.Price)
                        .Where(x => x.CategoryId == id)
                        .Where(x => x.DeletedDate == null)
                        .ToPagedListAsync(page, size);
                return View(data);
            }
            else
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                        (AutoMapperProfile.ProductClientConf, false,
                        s => s.IsActive == true && (s.CategoryId != null && listCateId.Contains(s.CategoryId.Value)))
                        .ToPagedListAsync(page, size);

                ViewBag.TitleName = cate.Name;
                return View(data);
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            return View(statusCode.ToString());
        }
    }
}
