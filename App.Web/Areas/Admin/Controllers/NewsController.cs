using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using App.Share.Extensions;
using App.Web.Areas.Admin.ViewModels.News;
using App.Web.Areas.Admin.ViewModels.NewsCategory;
using App.Web.Common;
using App.Web.Common.Mailer;
using App.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorEngine;
using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.Areas.Admin.Controllers
{
    public class NewsController : AppControllerBase
    {
        private readonly GenericRepository _repo;
        private readonly AppMailConfiguration _mailConfig;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _env;
        private readonly IHttpContextAccessor _contextAccessor;
        public NewsController(IMapper mapper,
            GenericRepository repo,
            AppMailConfiguration mailConfig,
            Microsoft.AspNetCore.Hosting.IHostingEnvironment env,
            IHttpContextAccessor contextAccessor) : base(mapper)
        {
            _repo = repo;
            _mailConfig = mailConfig;
            _contextAccessor = contextAccessor;
            _env = env;
        }

        [AppAuthorize(AuthConst.AppNews.VIEW_LIST)]
        public async Task<IActionResult> Index(string title = "", int cateId = 0, int page = 1, int size = DEFAULT_PAGE_SIZE)
        {
            var data = (await _repo.GetAll<AppNews>()
                .Where(x => x.DeletedDate == null)
                .Where(x => cateId > 0 ? x.CategoryId == cateId : true)
                .Where(x => !String.IsNullOrEmpty(title) ? x.Slug.Contains(title.Slugify()) : true)
                .ProjectTo<NewsListItemVM>(AutoMapperProfile.NewsConf)
                .ToPagedListAsync(page, size))
                ;

            var listCate = await _repo
                .GetAll<AppNewsCategory>()
                .ProjectTo<NewsCategoryListItemVM>(AutoMapperProfile.NewsCategoryConf)
                .ToListAsync();
            ViewBag.CategoryNews = new SelectList(listCate, "Id", "Title", cateId);
            ViewBag.CateId = cateId;
            ViewBag.TitleNews = title;
            return View(data);
        }
        [AppAuthorize(AuthConst.AppNews.CREATE)]
        public IActionResult Create() => View();
        [AppAuthorize(AuthConst.AppNews.CREATE)]
        [HttpPost]
        public async Task<IActionResult> Create([FromServices] AddOrUpdateNewsVM model)
        {
            if (!ModelState.IsValid)
            {
                SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
                return View(model);
            }
            if (await _repo.AnyAsync<AppNews>(u => u.Slug.Equals(model.Title.Slugify()) && u.DeletedDate == null))
            {
                SetErrorMesg("Bài viết này đã tồn tại");
                return View(model);
            }
            try
            {
                var user = CurrentUserId;
                var news = _mapper.Map<AppNews>(model);
                news.UserId = user;
                news.CreatedBy = user;
                news.Slug = news.Title.Slugify();

                if (model.SendAllEmail && User.IsInPermission(AuthConst.AppNews.SENDMAILREGISTER))
                {
                    SendMailToSubcribers(news);
                }

                await _repo.AddAsync(news);
                SetSuccessMesg($"Thêm bài viết [{news.Title}] thành công!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            catch (Exception ex)
            {
                LogException(ex);
                return View(model);
            }
        }
        [AppAuthorize(AuthConst.AppNews.UPDATE)]
        public async Task<IActionResult> Update(int id)
        {
            var post = await _repo.FindAsync<AppNews>(id);
            if (post == null)
            {
                SetErrorMesg(PAGE_NOT_FOUND_MESG);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            var postVM = _mapper.Map<AddOrUpdateNewsVM>(post);
            ViewBag.BeforeUrl = Referer;
            return View(postVM);
        }
        [AppAuthorize(AuthConst.AppNews.UPDATE)]
        [HttpPost]
        public async Task<IActionResult> Update(AddOrUpdateNewsVM model)
        {
            var post = await _repo.FindAsync<AppNews>(model.Id);

            if (!ModelState.IsValid)
            {
                SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
                return View(model);
            }
            if (post == null)
            {
                SetErrorMesg(PAGE_NOT_FOUND_MESG);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }

            if (await _repo.AnyAsync<AppNews>(u => u.Slug.Equals(model.Title.Slugify()) && u.Slug != post.Slug && u.DeletedDate == null))
            {
                SetErrorMesg("Tiêu đề bài viết này đã tồn tại!");
                return View(model);
            }
            try
            {
                _mapper.Map<AddOrUpdateNewsVM, AppNews>(model, post);
                post.UpdatedDate = DateTime.Now;
                post.Slug = model.Title.Slugify();
                await _repo.UpdateAsync(post);
                SetSuccessMesg($"Cập nhật bài viết [{post.Title}] thành công!");
                var beforeUrl = Request.Form["beforeUrl"].ToString();
                if (beforeUrl != null)
                {
                    return Redirect(beforeUrl);
                }
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            catch (Exception ex)
            {
                LogException(ex);
                return View(model);
            }
        }
        [AppAuthorize(AuthConst.AppNews.DELETE)]
        public async Task<IActionResult> Delete(int id)
        {
            var news = await _repo.FindAsync<AppNews>(id);
            if (news == null)
            {
                SetErrorMesg("Bài viết này không tồn tại hoặc đã được xóa trước đó!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            // Xóa khóa ngoại danh mục của bài viết
            news.CategoryId = null;
            await _repo.DeleteAsync(news);
            SetSuccessMesg($"Bài viết [{news.Title}] được xóa thành công!");
            if (Referer != null)
            {
                return Redirect(Referer);
            }
            return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
        }
        [AppAuthorize(AuthConst.AppNews.PUBLIC)]
        public async Task<IActionResult> PublicNews(int id)
        {
            var post = await _repo.FindAsync<AppNews>(id);
            if (post == null)
            {
                SetErrorMesg(PAGE_NOT_FOUND_MESG);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            post.Published = true;
            post.PublishedAt = DateTime.Now;
            await _repo.UpdateAsync(post);
            SetSuccessMesg($"Công khai bài viết [{post.Title}] thành công!");
            return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
        }
        [AppAuthorize(AuthConst.AppNews.UNPUBLIC)]
        public async Task<IActionResult> UnPublicNews(int id)
        {
            var post = await _repo.FindAsync<AppNews>(id);
            if (post == null)
            {
                SetErrorMesg(PAGE_NOT_FOUND_MESG);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            post.Published = false;
            post.PublishedAt = DateTime.Now;
            await _repo.UpdateAsync(post);
            SetSuccessMesg($"Ẩn bài viết [{post.Title}] thành công!");
            return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
        }
        private void SendMailToSubcribers(AppNews news)
        {
            var pathToFile = $"{_env.WebRootPath}" +
                    $"{Path.DirectorySeparatorChar}" +
                    $"emailTemplate{Path.DirectorySeparatorChar}InfoNewMessager.html";

            var appMailSender = new AppMailSender()
            {
                Name = "Admin",
                Subject = $"Thông tin tới bạn về cửa hàng."
            };

            using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile))
            {
                appMailSender.Content = SourceReader.ReadToEnd();
            };

            var listEmailSubscriber = _repo.GetAll<AppUser>().ToList();
            var listMailReciver = new List<AppMailReciver>();
            if (listEmailSubscriber.Count() > 0)
            {
                foreach (var item in listEmailSubscriber)
                {
                    AppMailReciver mailReciver = new AppMailReciver()
                    {
                        Name = item.Email,
                        Email = item.Email
                    };
                    listMailReciver.Add(mailReciver);
                }
            }
            var resultEmail = listMailReciver.AsEnumerable();
            var path = Url.Action("NewsDetails", "News", new { area = "", slug = news.Slug, id = news.Id });
            var doamin = $"{_contextAccessor.HttpContext.Request.Scheme}://{_contextAccessor.HttpContext.Request.Host}{path}";
            // var logo = @$"{_contextAccessor.HttpContext.Request.Scheme}://{_contextAccessor.HttpContext.Request.Host}{_sysEnv[SystemEnvConst.LOGO]}";

            var contentMessage = Engine.Razor
                .RunCompile(appMailSender.Content, "@Model",
                null,
                new
                {
                    //       LogoCompany = logo,
                    Linknews = doamin,
                    Signature = _mailConfig.Signature,
                    Year = DateTime.Now.Year,
                    CompanyName = appMailSender.Name
                });

            appMailSender.Content = contentMessage.ToString();
            AppMailer.SendToList(appMailSender, resultEmail, _mailConfig);
        }
    }
}
