using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using OperasWebSite.Models;

namespace OperasWebSite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
#if(DEBUG)
            Database.SetInitializer(new OperaInitializer());
#endif

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
