using EasyPayment4u.Windows.Services;
using EasyPayment4u.Windows.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EasyPayment4u.Windows
{
    /// <summary>
    /// Interaction logic for CreateOrderWindow.xaml
    /// </summary>
    public partial class CreateOrderWindow : Window, IChildWindow1
    {
        public CreateOrderWindow(IConsumerOrderViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }


        public void SetOwner(object window)
        {
            Owner = window as Window;
        }
    }
}
