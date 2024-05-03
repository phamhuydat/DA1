using App.Data.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class NewsController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly GenericRepository _repo;

        public NewsController(IMapper mapper, GenericRepository repo) : base(mapper, repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [Route("tin-tuc")]
        public async Task<IActionResult> Index()
        {


            return View();
        }
    }
}
