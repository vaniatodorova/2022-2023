﻿using System.Web;
using System.Web.Mvc;

namespace Calculator_CSharp.Models
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
