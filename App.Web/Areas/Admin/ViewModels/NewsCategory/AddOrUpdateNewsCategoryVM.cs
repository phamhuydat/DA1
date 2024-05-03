using App.Share.Consts;
using App.Web.WebConfig;
using App.Shared.Attributes;
using System;

namespace App.Web.Areas.Admin.ViewModels.NewsCategory
{
    public class AddOrUpdateNewsCategoryVM
    {
        public int Id { get; set; }

        [AppRequired]
        [AppStringLength(VM.AppNewsCategory.MIN_LENGTH, VM.AppNewsCategory.MAX_LENGTH)]
        public string Title { get; set; }
        public string Content { get; set; }
        [AppRequired]
        public string CoverImgPath { get; set; }
    }
}
