using EasyPayment4u.Core.Data;
using EasyPayment4u.Data;
using EasyPayment4u.Services;
using Microsoft.Practices.Unity;
using System.Web;
using System.Web.Http;
using Unity.WebApi;

namespace EasyPayment4u.WebAPI
{
    public static class UnityConfig
    {
        public static IUnityContainer RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IDbContext, DataModel>();
            container.RegisterType(typeof(IRepository<>), typeof(EFRepository<>));
           // container.RegisterType<IAuthenticationManager>(new InjectionFactory(c => HttpContext.Current.GetOwinContext().Authentication));


            //container.RegisterType<UserManager<MyUser,long>,MyUserManager>();
            //container.RegisterType<IUserStore<MyUser>, UserStore<MyUser>>(new InjectionConstructor(typeof(ApplicationDbContext)));
            //container.RegisterType<ApplicationDbContext>();
            //container.RegisterType<ApplicationSignInManager>();
            // container.RegisterType<ApplicationUserManager>();
            // container.RegisterType<IAuthenticationManager>(new InjectionFactory(c => HttpContext.Current.GetOwinContext().Authentication));



            container.RegisterType<ITestService, TestService>();
            

            return container;
            //GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}