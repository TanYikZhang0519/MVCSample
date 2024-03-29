﻿using MVCSample.Filters;
using System.Web;
using System.Web.Mvc;

namespace MVCSample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());//ExceptionFilter
            filters.Add(new EmployeeExceptionFilter());
            filters.Add(new AuthorizeAttribute());
        }
    }
}
