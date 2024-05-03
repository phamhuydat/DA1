using App.Share.Consts;
using App.Shared.Attributes;

namespace App.Web.Areas.Admin.ViewModels.News
{
    public class AddOrUpdateNewsVM : SEOEntityBaseVM
    {
        [AppRequired]
        [AppMaxLength(DB.AppNews.TITLE_LENGTH)]
        public string Title { get; set; }
        [AppMaxLength(DB.AppNews.SUMMARY_LENGTH)]
        [AppRequired]
        public string Summary { get; set; }
        [AppRequired]
        public string Content { get; set; }
        [AppRequired]
        public int CategoryId { get; set; }
        [AppRequired]
        public string CoverImgPath { get; set; }
        public string CoverImgThumbnailPath { get; set; }
        public string StampPath { get; set; }
        public bool SendAllEmail { get; set; }
    }
}
