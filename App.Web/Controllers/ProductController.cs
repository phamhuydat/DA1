using App.Data.Repositories;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class ProductController : BaseController
    {
        private readonly INotyfService _notyf;
        private const int DEFAULT_PAGE_SIZE = 30;
        private const int MAX_RECENT_PRODUCT = 8;
        public ProductController(IMapper mapper, GenericRepository repository, INotyfService notyf): base(mapper, repository)
        {
            _notyf = notyf;
        }
        public IActionResult ListProduct()    
        {
            return View();
        }
        public IActionResult ProductDetail(int id)
        {
            return View();
        }

    }
}
