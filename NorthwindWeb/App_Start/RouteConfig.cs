using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NorthwindWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Product",
            //    url: "Product/{AccessType}",
            //    defaults: new { controller = "Product", action = "ProductRedirect", id = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "Cat",
            //    url: "Cat/{AccessType}",
            //    defaults: new { controller = "Cat", action = "CatRedirect", id = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "Supplier",
            //    url: "Supplier/{AccessType}",
            //    defaults: new { controller = "Supplier", action = "SupplierRedirect", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
