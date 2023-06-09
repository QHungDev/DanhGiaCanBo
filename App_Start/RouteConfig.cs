﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DanhGiaCanBo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "success ",
               url: "danh-gia-thanh-cong",
               defaults: new { controller = "Home", action = "Success", id = UrlParameter.Optional },
               namespaces: new string[] { "DanhGiaCanBo.Controllers" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "DanhGiaCanBo.Controllers" }
            );
        }
    }
}
