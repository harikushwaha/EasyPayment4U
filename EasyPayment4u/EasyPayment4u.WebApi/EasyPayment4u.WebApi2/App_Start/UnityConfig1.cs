using EasyPayment4u.Core.Data;
using EasyPayment4u.Data;
using EasyPayment4u.Identity.Models;
using EasyPayment4u.Services;
using Microsoft.Owin.Security;
using Microsoft.Practices.Unity;
using System.Web;
using System.Web.Http;
using Unity.WebApi;

namespace EasyPayment4u.WebApi2
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();


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
            

            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}