using EasyPayment4u.Core.Data;
using EasyPayment4u.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Services.OrderLines
{
    public class OrderLineService : IOrderLineService
    {
        private readonly IRepository<OrderLine> _orderLineRepository;
        public OrderLineService(IRepository<OrderLine> orderLineRepository)
        {
            this._orderLineRepository = orderLineRepository;
        }

        public OrderLine GetItem(int ID)
        {
            if (ID == 0)
                return null;

            return _orderLineRepository.GetById(ID);
        }

        public IList<OrderLine> GetItems()
        {
            return _orderLineRepository.Table.ToList<OrderLine>();
        }

        public IList<OrderLine> GetItemByIds(int[] Ids)
        {
            if (Ids == null || Ids.Length == 0)
                return new List<OrderLine>();

            var query = from o in _orderLineRepository.Table
                        where Ids.Contains(o.OrderID)
                        select o;
            var orders = query.ToList();
            //sort by passed identifiers
            var sortedOrderLines = new List<OrderLine>();
            foreach (int id in Ids)
            {
                var order = orders.Find(x => x.OrderID == id);
                if (order != null)
                    sortedOrderLines.Add(order);
            }
            return sortedOrderLines;
        }

        public void DeleteItem(OrderLine item)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            // product.Deleted = true;
            UpdateItem(item);
        }

        public void InsertItem(OrderLine item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            _orderLineRepository.Insert(item);
        }

        public void UpdateItem(OrderLine item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            _orderLineRepository.Update(item);
        }
    }
}
