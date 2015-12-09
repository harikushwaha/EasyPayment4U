using EasyPayment4u.Core.Data;
using EasyPayment4u.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Services.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        public OrderService(IRepository<Order> orderRepository)
        {
            this._orderRepository = orderRepository;
        }


        public Order GetItem(int ID)
        {
            if (ID == 0)
                return null;

            return _orderRepository.GetById(ID);
        }

        public IList<Order> GetItems()
        {
            return _orderRepository.Table.ToList<Order>();
        }

        public IList<Order> GetItemByIds(int[] Ids)
        {
            if (Ids == null || Ids.Length == 0)
                return new List<Order>();

            var query = from o in _orderRepository.Table
                        where Ids.Contains(o.OrderID)
                        select o;
            var orders = query.ToList();
            //sort by passed identifiers
            var sortedOrders = new List<Order>();
            foreach (int id in Ids)
            {
                var order = orders.Find(x => x.OrderID == id);
                if (order != null)
                    sortedOrders.Add(order);
            }
            return sortedOrders;
        }

        public void DeleteItem(Order item)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            // product.Deleted = true;
            UpdateItem(item);
        }

        public void InsertItem(Order item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            _orderRepository.Insert(item);
        }

        public void UpdateItem(Order item)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            _orderRepository.Update(item);
        }
    }
}
