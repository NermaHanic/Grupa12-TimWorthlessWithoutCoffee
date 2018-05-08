﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DearWalletWeb
{
    public enum Stil { Casual, Elegant, RockPunkEmo, Vintage, Sport }
    public enum Odjel { Muski, Zenski, Djeciji }
    public enum DefaultVelicine { XS, S, M, L, XL, XXL }
    public enum Kategorija { Majica, Pantalone, Suknja, Haljina }

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}