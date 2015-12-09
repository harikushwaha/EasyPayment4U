using EasyPayment4u.Core.Data;
using EasyPayment4u.Data;
using EasyPayment4u.Services;
using EasyPayment4u.Windows.Services;
using EasyPayment4u.Windows.ViewModel;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EasyPayment4u.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindow
    {
        public MainWindow(ITextViewModel viewmodel)
        {
            InitializeComponent();
            this.DataContext = viewmodel;
        }

      
        //[Dependency]
        //public IChildWindow ChildWindow { get; set; }

        //[Dependency]
        //public ITestService TestServices { get; set; }

    }
}
