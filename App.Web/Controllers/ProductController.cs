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
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

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
		[Route(RouteConst.PRODUCT_ROUTE)]
		public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			var data = (await _repository
			.GetAll<AppProduct>()
					.Where(s => s.IsActive == true && s.DeletedDate == null)
					.OrderByDescending(m => m.DisplayOrder)
					.ThenByDescending(m => m.Id)
					.ToListAsync());

			return View(data);
		}

		public async Task<IActionResult> ListProduct(string CategoryId)
		{

			return View();
		}

		public IActionResult ProductDetail(string ProductId)
		{

			return View();
		}



	}
}
