﻿using System.Web;
using System.Web.Mvc;

namespace NguyenDinhHoangLan_BaiTap5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}