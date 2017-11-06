﻿using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PostSharp.Samples.MiniProfiler
{
  public class MvcApplication : HttpApplication
  {
    protected void Application_Start()
    {
      AreaRegistration.RegisterAllAreas();
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);
    }

    protected void Application_BeginRequest()
    {
      StackExchange.Profiling.MiniProfiler.Start();
    }

    protected void Application_EndRequest()
    {
      StackExchange.Profiling.MiniProfiler.Stop();
    }
  }
}