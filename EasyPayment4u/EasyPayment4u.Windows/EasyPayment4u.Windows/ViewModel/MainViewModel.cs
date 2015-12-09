using EasyPayment4u.Data;
using EasyPayment4u.Services;
using EasyPayment4u.Services.Consumers;
using EasyPayment4u.Services.OrderLines;
using EasyPayment4u.Services.Orders;
using EasyPayment4u.Windows.Model;
using EasyPayment4u.Windows.Services;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace EasyPayment4u.Windows.ViewModel
{
    public class MainViewModel : ViewModelBase, ITextViewModel
    {
        private readonly IProductService _productService;
        private readonly ITestService _testService;
        private readonly IConsumerService _consumerService;
        private readonly IOrderService _orderService;
        private readonly IOrderLineService _orderLineService;


        public ICommand AddCmd { get; private set; }
        public ICommand UpdateCmd { get; private set; }
        public ICommand RefreshCmd { get; private set; }
        public ICommand DeleteCmd { get; private set; }
        public ICommand NewCmd { get; private set; }
        public ICommand OnCreateOrder { get; private set; }


        public ICommand NewOrderCmd { get; private set; }
        public ICommand AddOrderCmd { get; private set; }
        public ICommand UpdateOrderCmd { get; private set; }
        public ICommand DeleteOrderCmd { get; private set; }


        public MainViewModel(IProductService productService,
            ITestService testService,
            IConsumerService consumerService,
            IOrderService orderService,
            IOrderLineService _orderLineService
            )
        {
            //var d = this.ConsumerServices;
            //var ss = d.GetConsumer(1);
            try
            {
                this._productService = productService;
                this._consumerService = consumerService;
                this._testService = testService;
                this._orderService = orderService;
                this._orderLineService = _orderLineService;

                this._orders = this._orderService.GetItems().ToList();
                this._orderLines = this._orderLineService.GetItems().ToList();
                this._consumers = this._consumerService.GetConsumers().ToList();

                RefreshCmd = new RelayCommand(ExecRefresh, CanRefresh);
                NewCmd = new RelayCommand(ExecNew, CanNew);
                DeleteCmd = new RelayCommand(ExecDelete, CanDelete);
                UpdateCmd = new RelayCommand(ExecUpdate, CanUpdate);
                AddCmd = new RelayCommand(ExecAdd, CanAdd);
                OnCreateOrder = new RelayCommand(ExecCreateOrder, CanCreateOrder);

                NewOrderCmd = new RelayCommand(ExecNewOrder, CanNewOrder);
                AddOrderCmd = new RelayCommand(ExecAddOrder, CanAddOrder);
                UpdateOrderCmd = new RelayCommand(ExecUpdateOrder, CanUpdateOrder);
                DeleteOrderCmd = new RelayCommand(ExecDeleteOrder, CanDeleteOrder);
                this.ConsumerModelP = new ConsumerModel();
            }
            catch(Exception exp)
            {

            }
            //this._selectedConsumer = new Consumer();
        }

        private void ExecDeleteOrder(object obj)
        {
            throw new NotImplementedException();
        }

        private bool CanDeleteOrder(object obj)
        {
            return true;
        }

        private bool CanUpdateOrder(object obj)
        {
            return true;
        }

        private void ExecUpdateOrder(object obj)
        {
            throw new NotImplementedException();
        }

        private bool CanAddOrder(object obj)
        {
            return true;
        }

        private void ExecAddOrder(object obj)
        {
            try
            {
                var newOrder = new Order
                {
                    ConsumerID = this._selectedCombConsumer.ConsumerID,
                    OrderDate = DateTime.Now,
                    OrderLines = new List<OrderLine>(),

                };
                _orderService.InsertItem(newOrder);

                this.Consumers = this._consumerService.GetConsumers().ToList();
                // this.Orders = this._orderService.GetItems().ToList();

            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

        private void ExecNewOrder(object obj)
        {
            this.IsOrderSave = true;
            this.IsOrderEdit = false;
            this.SelectedOrder = new Order();

        }

        private bool CanNewOrder(object obj)
        {
            return true;
        }

        private ConsumerOrderViewModel _consumerOrderVM;

        #region viewmodels

        public ConsumerOrderViewModel ConsumerOrderVM
        {
            get { return _consumerOrderVM; }
            set
            {
                _consumerOrderVM = value;
                base.SetPropertyChanged("ConsumerOrderVM");
            }
        }

        #endregion


        #region Private Method

        private bool CanCreateOrder(object obj)
        {
            return (true);
        }

        private void ExecCreateOrder(object obj)
        {
            if (CreateConsumer != null)
                CreateConsumer.ShowDialog();
        }


        private bool CanAdd(object obj)
        {
            return (true);
        }

        private void ExecAdd(object obj)
        {
            // this.SelectedConsumer = new Consumer();
            try
            {
                _consumerService.InsertConsumer(new Consumer
                {
                    ConsumerID = this._selectedConsumer.ConsumerID,
                    FirstName = this._selectedConsumer.FirstName,
                    MiddleName = this._selectedConsumer.MiddleName,
                    LastName = this._selectedConsumer.LastName,
                    MobileNumber = this._selectedConsumer.MobileNumber,
                    OrderID = this._selectedConsumer.OrderID,
                });

                this.Consumers = this._consumerService.GetConsumers().ToList();
                // this.Orders = this._orderService.GetItems().ToList();

            }
            catch (Exception exp)
            {
                throw exp;
            }
            //IsConsumerEdit = false;
            //IsConsumerNew = true;
            //IsConsumerDelete = false;
        }

        private bool CanUpdate(object obj)
        {
            return (true);
        }

        private void ExecUpdate(object obj)
        {
            try
            {
                this._consumerService.UpdateConsumer(SelectedConsumer);
                this.Consumers = this._consumerService.GetConsumers().ToList();
                // this.Orders = this._orderService.GetItems().ToList();

            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

        private bool CanDelete(object obj)
        {
            return (true);
        }

        private void ExecDelete(object obj)
        {
            try
            {
                //_consumerService.DeleteConsumer(new Consumer
                //{
                //    ConsumerID = this.ConsumerModelP.ConsumerID,
                //    FirstName = this.ConsumerModelP.FirstName,
                //    MiddleName = this.ConsumerModelP.MiddleName,
                //    LastName = this.ConsumerModelP.LastName,
                //    MobileNumber = this.ConsumerModelP.MobileNumber,
                //    OrderID = this.ConsumerModelP.OrderID,
                //});

                _consumerService.DeleteConsumer(SelectedConsumer);
                this.Consumers = this._consumerService.GetConsumers().ToList();
                // this.Orders = this._orderService.GetItems().ToList();

            }
            catch (Exception exp)
            {
                ErrorMessage = exp.Message;
            }
        }

        private bool CanNew(object obj)
        {
            return (true);
        }

        private void ExecNew(object obj)
        {
            //this.SelectedConsumer = null;
            this.IsConsumerSave = true;
            this.ConsumerModelP = new ConsumerModel();
        }

        private void ExecRefresh(object obj)
        {
            this.SelectedConsumer = new Consumer();
            IsConsumerEdit = false;
            IsConsumerNew = true;
            IsConsumerDelete = false;
            IsConsumerSave = false;
            this.Orders = this._orderService.GetItems().ToList();
            this.Consumers = this._consumerService.GetConsumers().ToList();
            this.OrderLines = this._orderLineService.GetItems().ToList();
        }

        private bool CanRefresh(object obj)
        {
            return (true);
        }

        #endregion

        #region Private Variable

        private List<Product> _myComboBoxData;
        private List<Consumer> _consumers;
        private List<Order> _orders;
        private List<OrderLine> _orderLines;

        private Product _selectedItem;
        private Consumer _selectedConsumer;
        private Order _selectedOrder;
        private OrderLine _selectedOrderLine;
        private ConsumerModel _consumerModel;
        private Consumer _selectedCombConsumer;

        private string _errorMessage;

        private bool _isConsumerNew = true;
        private bool _isConsumerEdit = false;
        private bool _isConsumerDelete;
        private bool _isConsumerSave = true;

        private bool _isOrderDelete = false;
        private bool _isOrderNew = true;
        private bool _isOrderEdit = false;
        private bool _isOrderSave = false;

      

        #endregion

        #region DP Properties


        public bool IsConsumerEdit
        {
            get { return _isConsumerEdit; }
            set
            {
                _isConsumerEdit = value;
                base.SetPropertyChanged("IsConsumerEdit");
            }
        }

        public bool IsConsumerDelete
        {
            get { return _isConsumerDelete; }
            set
            {
                _isConsumerDelete = value;
                base.SetPropertyChanged("IsConsumerDelete");
            }
        }

        public bool IsConsumerNew
        {
            get { return _isConsumerNew; }
            set
            {
                _isConsumerNew = value;
                base.SetPropertyChanged("IsConsumerNew");
            }
        }

        public bool IsConsumerSave
        {
            get { return _isConsumerSave; }
            set
            {
                _isConsumerSave = value;
                base.SetPropertyChanged("IsConsumerSave");
            }
        }

        public bool IsOrderDelete
        {
            get { return _isOrderDelete; }
            set
            {
                _isConsumerDelete = value;
                base.SetPropertyChanged("IsOrderDelete");
            }
        }

        public bool IsOrderNew
        {
            get { return _isConsumerNew; }
            set
            {
                _isOrderNew = value;
                base.SetPropertyChanged("IsOrderNew");
            }
        }

        public bool IsOrderSave
        {
            get { return _isOrderSave; }
            set
            {
                _isOrderSave = value;
                base.SetPropertyChanged("IsOrderSave");
            }
        }

        public bool IsOrderEdit
        {
            get { return _isOrderEdit; }
            set
            {
                _isOrderEdit = value;
                base.SetPropertyChanged("IsOrderEdit");
            }
        }

       
        public Consumer SelectedCombConsumer
        {
            get
            {
                return this._selectedCombConsumer;
            }
            set
            {

                this._selectedCombConsumer = value;
                base.SetPropertyChanged("SelectedCombConsumer");
            }
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                base.SetPropertyChanged("ErrorMessage");
            }
        }

        public Product SelectedItem
        {
            get
            {
                return this._selectedItem;
            }
            set
            {

                this._selectedItem = value;
                base.SetPropertyChanged("SelectedItem");
            }
        }

        public Consumer SelectedConsumer
        {
            get
            {
                return this._selectedConsumer;
            }
            set
            {

                this._selectedConsumer = value;
                if (_selectedConsumer != null)
                {
                    IsConsumerEdit = true;
                    IsConsumerNew = true;
                    IsConsumerDelete = true;
                    IsConsumerSave = false;

                    //this.ConsumerModelP.ConsumerID=_selectedConsumer.ConsumerID;
                    //this.ConsumerModelP.FirstName = this._selectedConsumer.FirstName;
                    //this.ConsumerModelP.MiddleName = this._selectedConsumer.MiddleName;
                    //this.ConsumerModelP.LastName = this._selectedConsumer.LastName;
                    //this.ConsumerModelP.MobileNumber = this._selectedConsumer.MobileNumber;
                    //this.ConsumerModelP.OrderID = this._selectedConsumer.OrderID;


                    var ii = int.Parse(_selectedConsumer.ConsumerID.ToString());
                    var data = this._orderService.GetItems();
                    Orders = data.Where(p => p.ConsumerID == ii).ToList();

                }
                else
                {
                    IsConsumerSave = true;
                    IsConsumerEdit = false;
                    IsConsumerNew = true;
                    IsConsumerDelete = false;
                }
                //this.SelectedOrder= data;

                base.SetPropertyChanged("SelectedConsumer");
            }
        }

        public Order SelectedOrder
        {
            get
            {
                return this._selectedOrder;
            }
            set
            {

                this._selectedOrder = value;
                if (this._selectedOrder != null && this._selectedOrder.OrderID>0)
                {
                    var orderID = int.Parse(_selectedOrder.OrderID.ToString());
                    var data = this._orderLineService.GetItems();
                    OrderLines = data.Where(p => p.OrderID == orderID).ToList();
                    this.IsOrderSave = true;
                    this.IsOrderDelete = true;
                    this.IsOrderEdit = true;
                }
                else
                {
                    this.IsOrderEdit = false;
                    this.IsOrderDelete = false;
                    this.IsOrderSave = true;
                }
                base.SetPropertyChanged("SelectedOrder");
            }
        }

        public OrderLine SelectedOrderLine
        {
            get
            {
                return this._selectedOrderLine;
            }
            set
            {

                this._selectedOrderLine = value;
                base.SetPropertyChanged("SelectedOrderLine");
            }
        }


        public ConsumerModel ConsumerModelP
        {
            get
            {
                return this._consumerModel;
            }
            set
            {

                this._consumerModel = value;
                base.SetPropertyChanged("ConsumerModelP");
            }
        }

        #endregion

        #region DP List Properties

        public List<Product> MyListBoxData
        {
            get
            {
                this._myComboBoxData = this._productService.GetProducts().ToList();
                return this._myComboBoxData;
            }
            set
            {

                this._myComboBoxData = value;
                base.SetPropertyChanged("MyListBoxData");
            }
        }

        public List<Consumer> Consumers
        {
            get
            {

                return this._consumers;
            }
            set
            {

                this._consumers = value;
                base.SetPropertyChanged("Consumers");
            }
        }

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

        public List<OrderLine> OrderLines
        {
            get
            {

                return this._orderLines;
            }
            set
            {

                this._orderLines = value;
                base.SetPropertyChanged("OrderLines");
            }
        }


        #endregion

        public string LabelContnet
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #region Dependacy Injactions

        [Dependency]
        public IConsumerService ConsumerServices { get; set; }

        [Dependency]
        public IProductService ProductServices { get; set; }

        [Dependency]
        public IChildWindow ChildWindow { get; set; }

        [Dependency]
        public IChildWindow1 CreateConsumer { get; set; }

        #endregion



    }
}
