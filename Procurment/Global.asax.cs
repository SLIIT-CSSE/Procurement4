using AutoMapper;
using Procurment.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using Procurment.App_Start;

namespace Procurment
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            Mapper.Initialize(o => o.AddProfile<MappingSupplierOrderProfile>());


            Mapper.Initialize(c => c.AddProfile<MappingProfileNew>());

            Mapper.Initialize(c => c.AddProfile<MappingSearchProfile>());


            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
