using App.Data.Entities;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class SystemEnvSeeder
	{
		public static void SeedData(this EntityTypeBuilder<SystemEnv> builder)
		{
			builder.HasData(
				new SystemEnv
				{
					Key = SystemEnvConst.LOGO,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.BRAND_NAME,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.BRAND_ADDRESS,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.PRIMARY_PHONE,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.SECONDARY_PHONE,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.FACEBOOK,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.ZALO,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.YOUTUBE,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.MESSENGER_EMBEDDED_CODE,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.PRIMARY_MAIL,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.SECONDARY_MAIL,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.ADMIN_RECIVER_MAIL,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.TAX_CODE,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.SEO_TITLE,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.SEO_DESCRIPTION,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.SEO_KEYWORD,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.SEO_IMAGEPATH,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.DEFAULT_IMAGE,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.ICON_IMAGEPATH,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.COMPANY_INTRODUCE,
					Value = ""

				},
				// COMPANY INTRODUCE
				new SystemEnv
				{
					Key = SystemEnvConst.COMPANY_INTRODUCE_TITLE,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.COMPANY_INTRODUCE_CONTENT,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.COMPANY_INTRODUCE_IMAGE_1,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.COMPANY_INTRODUCE_IMAGE_2,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.COMPANY_INTRODUCE_IMAGE_3,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.COMPANY_INTRODUCE_IMAGE_4,
					Value = ""
				},
				new SystemEnv
				{
					Key = SystemEnvConst.EMAIL_FOR_ORDER_INFORMATION,
					Value = ""
				});
		}
	}
}
