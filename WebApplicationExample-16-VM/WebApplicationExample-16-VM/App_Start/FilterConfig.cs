﻿using System.Web;
using System.Web.Mvc;

namespace WebApplicationExample_16_VM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}