using App.Data.Entities;
using App.Data.Repositories;
using App.Web.ViewModels.News;
using App.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using X.PagedList;

namespace App.Web.Controllers
{
    public class NewsController : BaseController
    {
        private readonly IMapper _mapper;
        private const int DEFAULT_PAGE_SIZE = 12;

        private readonly GenericRepository _repo;

        public NewsController(IMapper mapper, GenericRepository repo) : base(mapper, repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [Route("tin-tuc")]
        public async Task<IActionResult> News(int page = 1, int size = DEFAULT_PAGE_SIZE)
        {
            var dataCate = _repository.GetAll<AppNewsCategory>().ToList();
            ViewBag.TitleCate = "Tất cả tin tức";
            var random = new Random();
            ViewBag.ImageCate = dataCate[random.Next(0, dataCate.Count())].CoverImgPath;
            var data = await _repository
                .GetAll<AppNews>()
                .Where(s => s.Published == true)
                .ProjectTo<ListNewsVM>(AutoMapperProfile.NewsConf)
                .ToPagedListAsync(page, size);
            return View(data);
        }
        public async Task<IActionResult> NewsDetails(int id, string slug)
        {
            ViewBag.HasLocalSEO = true;
            var newsData = await _repository.FindAsync<AppNews>(id);
            if (newsData == null)
            {
                return NotFound();
            }
            var check = _repository.GetAll<AppNews>(s => s.Slug == slug).FirstOrDefault();
            if (check == null)
            {
                return NotFound();
            }
            await _repository.UpdateAsync(newsData);
            newsData.NewsCategory = await _repository.FindAsync<AppNewsCategory>(newsData.CategoryId ?? -1);
            ViewBag.CategoryNewsTitle = newsData.CategoryId;
            return View(newsData);
            return View();
        }
    }
}
