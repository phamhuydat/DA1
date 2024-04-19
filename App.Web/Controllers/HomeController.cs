using App.Data.Repositories;
using App.Web.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IMapper mapper, GenericRepository repository) 
            : base(mapper, repository)
        {
            
        }

        public async Task<IActionResult> Index()
        {
            var data =  await _repository.GetAll().ToList();
            return View(data);
        }
    }
}
