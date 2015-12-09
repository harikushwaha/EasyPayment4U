using EasyPayment4u.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Services.OrderLines
{
    public interface IOrderLineService
    {
        /// <summary>
        /// Get slected item based on ID
        /// </summary>
        /// <param name="productID">ID</param>
        /// <returns>Product</returns>
        OrderLine GetItem(int ID);
        /// <summary>
        /// Get All items
        /// </summary>
        /// <returns>Return list of items</returns>
        IList<OrderLine> GetItems();
        /// <summary>
        /// Get item based on ids
        /// </summary>
        /// <param name="orderIds">array of id's</param>
        /// <returns>List of item</returns>
        IList<OrderLine> GetItemByIds(int[] Ids);
        /// <summary>
        /// Delete selected item
        /// </summary>
        /// <param name="product">pass item</param>
        void DeleteItem(OrderLine item);
        /// <summary>
        /// insert item in database
        /// </summary>
        /// <param name="product">object of item as a parameter</param>
        void InsertItem(OrderLine item);
        /// <summary>
        /// Update item
        /// </summary>
        /// <param name="product">object of item as a parameter</param>
        void UpdateItem(OrderLine item);
    }
}
