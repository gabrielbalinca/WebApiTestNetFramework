﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiTestNetFramwork
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

<<<<<<< HEAD
=======
            config.Routes.MapHttpRoute(
                name: "PostApi",
                routeTemplate: "api/Licensing/PostDetails",
                defaults: new { id = RouteParameter.Optional }
            );
>>>>>>> 9409d13d33b29939157a7408540c0a60f6c8d1f0
        }
    }
}
