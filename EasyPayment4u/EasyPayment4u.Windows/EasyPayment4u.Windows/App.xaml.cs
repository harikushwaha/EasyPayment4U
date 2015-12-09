using EasyPayment4u.Core.Data;
using EasyPayment4u.Data;
using EasyPayment4u.Services;
using EasyPayment4u.Services.Consumers;
using EasyPayment4u.Services.OrderLines;
using EasyPayment4u.Services.Orders;
using EasyPayment4u.Windows.Services;
using EasyPayment4u.Windows.View;
using EasyPayment4u.Windows.ViewModel;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EasyPayment4u.Windows
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IDbContext, EasyPayment4uEntities>();
            container.RegisterType(typeof(IRepository<>), typeof(EFRepository<>));

            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IConsumerService, ConsumerService>();
            container.RegisterType<ITestService, TestService>();

            container.RegisterType<IOrderService, OrderService>();
            container.RegisterType<IOrderLineService, OrderLineService>();
            container.RegisterType<IChildWindow, ChildWindow>();
            container.RegisterType<IChildWindowNested, ChildWindowNested>();
            container.RegisterType<IMainWindow, MainWindow>();
            container.RegisterType<IChildWindow1, CreateOrderWindow>();


            container.RegisterType<ITextViewModel, MainViewModel>();
            container.RegisterType<IConsumerOrderViewModel, ConsumerOrderViewModel>();




            var childWindow = container.Resolve<IChildWindow>();
            var window = container.Resolve<IMainWindow>();
            window.Show();
        }
    }
}
