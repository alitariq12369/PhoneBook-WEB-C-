﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace PhoneBookWEBAppplication
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
                routeTemplate: "api/{controller}/{action}//{id}",
                defaults: new { id = RouteParameter.Optional }
            );

             //XML TO JSON
            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);








        }
    }
}
