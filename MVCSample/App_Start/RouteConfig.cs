﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCSample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.config");
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Home",
                url: "Home",
                defaults: new { controller = "Home", action = "GotoHome", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Home2",
                url: "",
                defaults: new { controller = "Home", action = "GotoHome", id = UrlParameter.Optional }
            );
            routes.MapRoute(
            name: "Upload",
            url: "Employee/BulkUpload",
            defaults: new { controller = "BulkUpload", action = "Index" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
