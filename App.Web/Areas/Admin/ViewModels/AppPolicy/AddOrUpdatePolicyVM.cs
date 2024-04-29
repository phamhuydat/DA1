using App.Share.Consts;
using DNews.Shared.Attributes;

namespace App.Web.Areas.Admin.ViewModels.AppPolicy
{
	public class AddOrUpdatePolicyVM
	{
		public int Id { get; set; }
		[AppRequired]
		[AppMaxLength(DB.AppPolicy.TITLE_LENGTH)]
		public string Title { get; set; }

		[AppRequired]
		public string Content { get; set; }

		[AppRequired]
		public string CoverImgPath { get; set; }
		public string CoverImgThumbnailPath { get; set; }
	}
}
