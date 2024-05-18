using App.Data.Entities;
using App.Data.Repositories;
using App.Web.ViewModels.Slider;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Components.Slider
{
    public class SliderViewComponent : ViewComponent
    {
        readonly GenericRepository _repo;
        public SliderViewComponent(GenericRepository repo)
        {
            _repo = repo;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id = 0)
        {
            var now = DateTime.Now;

            if (id == 0)
            {
                var data = await _repo
                    .GetAll<AppSlider>(x => x.DeletedDate == null
                        && ((x.FromDate ?? DateTime.MinValue) < now
                        && (x.ToDate ?? DateTime.MaxValue) > now))
                    .Take(10)
                    .OrderBy(x => x.Id)
                    .ProjectTo<ListSliderVM>(AutoMapperProfile.AppSliderConf)
                    .ToListAsync();
                return View(data);
            }
            else
            {
                var data = await _repo
                    .GetAll<AppSlider>(x => x.DeletedDate == null
                        && ((x.FromDate ?? DateTime.MinValue) < now
                        && (x.ToDate ?? DateTime.MaxValue) > now) && x.CategoryId == id)
                    .Take(10)
                    .OrderBy(x => x.Id)
                    .ProjectTo<ListSliderVM>(AutoMapperProfile.AppSliderConf)
                    .ToListAsync();
                return View(data);
            }
        }
    }
}
