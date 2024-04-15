using App.Share.Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Data.Entities.Base
{
	public abstract class AppSEOBase : AppEntityBase
	{
		[MaxLength(DB.SEOEntity.TITLE_LENGTH)]
		public string SEOTitle { get; set; }

		[MaxLength(DB.SEOEntity.DESC_LENGTH)]
		public string SEODescription { get; set; }

		[MaxLength(DB.SEOEntity.KEYWORD_LENGTH)]
		public string SEOKeyword { get; set; }

		[MaxLength(DB.SEOEntity.IMAGEPATH_LENGTH)]
		public string SEOImagePath { get; set; }
	}
}
