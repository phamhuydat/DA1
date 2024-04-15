﻿using App.Data;
using System.Collections.Generic;
using System.Linq;

namespace App.Web.Common
{
	public class SystemEnvironment
	{
		private readonly WebAppDbContext _db;
		private Dictionary<string, string> _sysEnv = new Dictionary<string, string>();
		public SystemEnvironment(WebAppDbContext db)
		{
			_db = db;
		}

		public string this[string key]
		{
			get
			{
				if (_sysEnv.ContainsKey(key))
				{
					return _sysEnv[key];
				}
				else
				{
					throw new System.Exception($"Giá trị ${key} không tồn tại");
				}
			}
		}

		public void LoadSysEnv()
		{
			var data = _db.SystemEnvs.ToList();

			foreach (var item in data)
			{
				_sysEnv.Add(item.Key, item.Value);
			}
		}

		public IEnumerable<string> GetKeys()
		{
			return _sysEnv.Keys;
		}

		public void UpdateSysEnv(string key, string value)
		{
			if (_sysEnv.ContainsKey(key))
			{
				_sysEnv[key] = value;

				var data = _db.SystemEnvs.SingleOrDefault(x => x.Key == key);
				data.Value = value != null ? value : "";
				_db.SystemEnvs.Update(data);
				_db.SaveChanges();
			}
		}
	}
}
