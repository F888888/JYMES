using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JYMES
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "resources",
               url: "Content/resources"

           );
            // routes.MapRoute(
            //    name: "data",
            //    url: "~/Content/data"

            //); 
            // routes.MapRoute(
            //    name: "files",
            //    url: "~/Content/files"

            //);
            // routes.MapRoute(
            //    name: "images",
            //    url: "~/Content/images"

            //);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "System", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
