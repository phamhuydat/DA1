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
using App.Web.ViewModels.News;
using Microsoft.Identity.Client;

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


        public IActionResult Index()
        {
            var products = _repository.GetAll<AppProduct>();

            if (products == null)
            {
                throw new Exception("Failed to retrieve products.");
            }

            if (AutoMapperProfile.ProductClientConf == null)
            {
                throw new Exception("AutoMapper profile configuration is null.");
            }
            var item = GetChildCategoryIds(DB.AppProductCategory.IPHONE);


            var iphone = _repository.GetAll<AppProduct, ProductListVM>(AutoMapperProfile.ProductClientConf)
                        .Where(x => x.IsActive && x.CategoryId.HasValue && GetChildCategoryIds(DB.AppProductCategory.IPHONE).Contains((int)x.CategoryId))
                        .Take(4).ToList();

            var ipad = _repository.GetAll<AppProduct, ProductListVM>(AutoMapperProfile.ProductClientConf)
                        .Where(x => x.IsActive && x.CategoryId.HasValue && GetChildCategoryIds(DB.AppProductCategory.IPAD).Contains((int)x.CategoryId))
                        .Take(4);

            var mac = _repository.GetAll<AppProduct, ProductListVM>(AutoMapperProfile.ProductClientConf)
                        .Where(x => x.IsActive && x.CategoryId.HasValue && GetChildCategoryIds(DB.AppProductCategory.MAC).Contains((int)x.CategoryId))
                        .Take(4);

            var watch = _repository.GetAll<AppProduct, ProductListVM>(AutoMapperProfile.ProductClientConf)
                        .Where(x => x.IsActive && x.CategoryId.HasValue && GetChildCategoryIds(DB.AppProductCategory.WATCH).Contains((int)x.CategoryId))
                        .Take(4);

            var accessory = _repository.GetAll<AppProduct, ProductListVM>(AutoMapperProfile.ProductClientConf)
                        .Where(x => x.IsActive && x.CategoryId.HasValue && GetChildCategoryIds(DB.AppProductCategory.ACCESSORY).Contains((int)x.CategoryId))
                        .Take(8);

            var news = _repository.GetAll<AppNews>()
                            .Where(s => s.Published == true)
                            .ProjectTo<ListNewsVM>(AutoMapperProfile.NewsConf)
                            .Take(3);

            ViewBag.news = news;
            ViewBag.iphone = iphone;
            ViewBag.ipad = ipad;
            ViewBag.mac = mac;
            ViewBag.watch = watch;
            ViewBag.accessory = accessory;
            ViewBag.iphoneCount = iphone.Count();
            ViewBag.ipadCount = ipad.Count();
            ViewBag.macCount = mac.Count();
            ViewBag.watchCount = watch.Count();
            ViewBag.accessoryCount = accessory.Count();
            ViewBag.newsCount = news.Count();


            return View();
        }
        public List<int> GetChildCategoryIds(int parentCategoryId)
        {
            List<int> list = _repository.GetAll<AppProductCategory>()
                .Where(c => c.ParentCateId == parentCategoryId)
                .Select(c => c.Id)
                .ToList();
            list.Add(parentCategoryId);
            return list;
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

            if (orderby == 101)
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                            (AutoMapperProfile.ProductClientConf)
                            .Where(x => x.CategoryId == id)
                            .Where(x => x.DeletedDate == null)
                            .OrderBy(x => x.DiscountPrice)
                            .OrderBy(x => x.Price)
                            .ToPagedListAsync(page, size);
                return View(data);
            }
            if (orderby == 102)
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                        (AutoMapperProfile.ProductClientConf)
                        .Where(x => x.CategoryId == id)
                        .Where(x => x.DeletedDate == null)
                        .OrderByDescending(x => x.DiscountPrice)
                        .OrderByDescending(x => x.Price)
                        .ToPagedListAsync(page, size);

                return View(data);
            }
            if (orderby == 103)
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                        (AutoMapperProfile.ProductClientConf)
                        .Where(x => x.CategoryId == id)
                        .Where(x => x.DeletedDate == null)
                        .OrderBy(x => x.id)
                        .ToPagedListAsync(page, size);
                return View(data);
            }

            if (orderby == 104)
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                            (AutoMapperProfile.ProductClientConf)
                            .Where(x => x.CategoryId == id)
                            .Where(x => x.DeletedDate == null)
                            .OrderBy(x => x.ProductName)
                            .ToPagedListAsync(page, size);
                return View(data);
            }
            if (orderby == 105)
            {
                var data = await _repository.GetAll<AppProduct, ProductListVM>
                       (AutoMapperProfile.ProductClientConf)
                       .Where(x => x.CategoryId == id)
                       .Where(x => x.DeletedDate == null)
                       .OrderByDescending(x => x.ProductName)
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
