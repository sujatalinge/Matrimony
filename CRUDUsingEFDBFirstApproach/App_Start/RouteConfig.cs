using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CRUDUsingEFDBFirstApproach
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Trainers", action = "Index", id = UrlParameter.Optional }
            );
        //    routes.MapRoute(
         //       name: "RoutingWithTwoParameters",
         //       url: "{controller}/{action}/{id}/{name}",
         //       defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, name = UrlParameter.Optional }
          //  );


          //  routes.MapRoute(
           //   name: "RoutingWithTwoControllerName",
           //   url: "Vikul/{controller}/{action}/{id}",
           //   defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, name = UrlParameter.Optional }
         // );

            //  routes.MapRoute(
            //    name: "Tedhahaiparmerahai",
            //  url: "{action}/{controller}",
            //  defaults: new { controller = "Home", action = "Index" }
            //  );
        }
    }
}
