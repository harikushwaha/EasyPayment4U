using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Unity.WebApi;
using System.Web.Mvc;

namespace EasyPayment4u.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           
            GlobalConfiguration.Configure(WebApiConfig.Register);
            Initialise();
        }

        private  void Initialise()
        {
            var container = UnityConfig.RegisterComponents();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            // register dependency resolver for WebAPI RC
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}
