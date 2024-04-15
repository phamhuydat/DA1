﻿namespace App.Web.Common.Helpers
{
	public static class PathHelper
	{
        static string GetFullPathNormalized(string path)
		{
			return Path.TrimEndingDirectorySeparator(Path.GetFullPath(path));
		}

        public static string MapPath(string path, string basePath = null)
		{
			//if (string.IsNullOrEmpty(basePath))
			//{
			//	basePath = Environment.w
			//}

			path = path.Replace("~/", "").TrimStart('/').Replace('/', '\\');
			return GetFullPathNormalized(Path.Combine(basePath, path));
		}
	}
}
