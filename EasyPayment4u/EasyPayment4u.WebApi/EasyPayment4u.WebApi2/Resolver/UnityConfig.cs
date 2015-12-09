using EasyPayment4u.Core.Data;
using EasyPayment4u.Data;
using EasyPayment4u.Identity.Models;
using EasyPayment4u.Services;
using Microsoft.Owin.Security;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EasyPayment4u.WebApi2.Resolver
{
    public class UnityConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();



            container.RegisterType<IDbContext, DataModel>();
            container.RegisterType(typeof(IRepository<>), typeof(EFRepository<>));
            container.RegisterType<IAuthenticationManager>(new InjectionFactory(c => HttpContext.Current.GetOwinContext().Authentication));

            container.RegisterType<ApplicationDbContext>();
            //container.RegisterType<MySignInManager>();

            container.RegisterType<IDbContext, DataModel>();
            container.RegisterType(typeof(IRepository<>), typeof(EFRepository<>));
            container.RegisterType<ITestService, TestService>();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IProductTypeService, ProductTypeService>();

            config.DependencyResolver = new UnityResolver(container);
            // Other Web API configuration not shown.
        }
    }
}