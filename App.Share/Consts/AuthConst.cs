using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Share.Consts
{
	public static class AuthConst
	{
		public const int NO_PERMISSION					= -1;
		public static class AppUser
		{
			public const int VIEW_LIST					= 1001;
			public const int VIEW_DETAIL				= 1002;
			public const int CREATE						= 1003;
			public const int UPDATE						= 1004;
			public const int UPDATE_PWD					= 1005;
			public const int BLOCK						= 1006;
			public const int UNBLOCK					= 1007;
			public const int DELETE						= 1008;
		}

		public static class AppRole
		{
			public const int VIEW_LIST					= 1101;
			public const int VIEW_DETAIL				= 1102;
			public const int CREATE						= 1103;
			public const int UPDATE						= 1104;
			public const int DELETE						= 1105;
		}

		public static class FileManager
		{
			public const int MANAGE_ALL_USER_FILES		= 1205;
		}

		public static class MstProductBrand
		{
			public const int VIEW_LIST = 1301;
			public const int CREATE = 1302;
			public const int UPDATE = 1303;
			public const int DELETE = 1304;
		}

		public static class AppBranch
		{
			public const int VIEW_LIST = 1401;
			public const int CREATE = 1402;
			public const int UPDATE = 1403;
			public const int DELETE = 1404;
		}

		public static class AppDiscountCode
		{
			public const int VIEW_LIST = 1501;
			public const int CREATE = 1502;
			public const int UPDATE = 1503;
			public const int DELETE = 1504;
		}

		public static class SystemEnv
		{
			public const int VIEW_LIST = 1601;
			public const int UPDATE = 1602;
		}

		public static class MstProductColor
		{
			public const int VIEW_LIST = 1701;
			public const int CREATE = 1702;
			public const int UPDATE = 1703;
			public const int DELETE = 1704;
		}

		public static class MstProductSize
		{
			public const int VIEW_LIST = 1801;
			public const int CREATE = 1802;
			public const int UPDATE = 1803;
			public const int DELETE = 1804;
		}
		public static class AppSlider
		{
			public const int VIEW_LIST = 1901;
			public const int CREATE = 1902;
			public const int UPDATE = 1903;
			public const int DELETE = 1904;
		}
		public static class AppPolicy
		{
			public const int VIEW_LIST = 2001;
			public const int VIEW_DETAIL = 2002;
			public const int CREATE = 2003;
			public const int UPDATE = 2004;
			public const int DELETE = 2005;
		}
		public static class AppNewsCategory
		{
			public const int VIEW_LIST = 2101;
			public const int CREATE = 2102;
			public const int UPDATE = 2103;
			public const int DELETE = 2104;
		}
		public static class AppNews
		{
			public const int VIEW_LIST = 2201;
			public const int CREATE = 2202;
			public const int UPDATE = 2203;
			public const int DELETE = 2204;
			public const int PUBLIC = 2205;
			public const int UNPUBLIC = 2206;
			public const int SENDMAILREGISTER = 2207;
			public const int VIEW_DETAIL = 2208;
		}
		public static class AppAboutCompany
		{
			public const int VIEW_LIST = 2301;
			public const int UPDATE = 2302;
		}

		public static class AppProductCategory
		{
			public const int VIEW_LIST = 2401;
			public const int CREATE = 2402;
			public const int UPDATE = 2403;
			public const int DELETE = 2404;
		}

		public static class AppProduct
		{
			public const int VIEW_LIST = 2501;
			public const int CREATE = 2502;
			public const int UPDATE = 2503;
			public const int DELETE = 2504;
			public const int PUBLIC = 2506;
			public const int UNPUBLIC = 2507;
			public const int VIEW_DETAIL = 2508;
		}
		public static class AppOrder
		{
			public const int VIEW_LIST = 2601;
			public const int DETAILS = 2602;
			public const int UPDATE = 2603;
			public const int DELETE = 2604;
		}
	}
}
