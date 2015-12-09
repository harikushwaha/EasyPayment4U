using EasyPayment4u.Data;
using EasyPayment4u.Services.Consumers;
using EasyPayment4u.Services.OrderLines;
using EasyPayment4u.Services.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EasyPayment4u.Windows.ViewModel
{
    public class ConsumerOrderViewModel : ViewModelBase, IConsumerOrderViewModel
    {
        private readonly IConsumerService _consumerService;
        private readonly IOrderService _orderService;
        private readonly IOrderLineService _orderLineService;

        public ICommand OnCloseCmd { get; private set; }
        public ConsumerOrderViewModel(
            IConsumerService consumerService,
            IOrderService orderService,
             IOrderLineService orderLineService
            )
        {
            _consumerService = consumerService;
            _orderService = orderService;
            _orderLineService =orderLineService;
            this.Orders = this._orderService.GetItems().ToList();
            OnCloseCmd = new RelayCommand(ExecClose, CanClose);
        }


        private void ExecClose(object obj)
        {
           
        }

        private bool CanClose(object obj)
        {
            return (true);
        }

        private Order _selectedOrder;
        private List<Order> _orders;

        public List<Order> Orders
        {
            get
            {
                return this._orders;
            }
            set
            {

                this._orders = value;
                base.SetPropertyChanged("Orders");
            }
        }

    }
}
