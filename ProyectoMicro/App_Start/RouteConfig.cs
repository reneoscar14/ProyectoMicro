using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProyectoMicro
{
    
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Parametros", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(

                name: "Parametros",
                url: "{controller}/{action}/{cultivo}/{modo}/{temperatura}/{humedad}/{calefaccion}/{ventilacion1}/{ventilacion2}/{iluminacion}/{riego}/{condicionRiego}/{temporizador}"
                );
        }
    }
}
