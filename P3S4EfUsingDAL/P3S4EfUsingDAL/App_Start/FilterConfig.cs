﻿using System.Web;
using System.Web.Mvc;

namespace P3S4EfUsingDAL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
