using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Services
{
    public interface IService<T>
    { /// <summary>
        /// Get slected item based on ID
        /// </summary>
        /// <param name="productID">ID</param>
        /// <returns>Product</returns>
        T GetItem(int ID);
        /// <summary>
        /// Get All items
        /// </summary>
        /// <returns>Return list of items</returns>
        IList<T> GetItems();
        /// <summary>
        /// Get item based on ids
        /// </summary>
        /// <param name="orderIds">array of id's</param>
        /// <returns>List of item</returns>
        IList<T> GetItemByIds(int[] Ids);
        /// <summary>
        /// Delete selected item
        /// </summary>
        /// <param name="product">pass item</param>
        void DeleteItem(T item);
        /// <summary>
        /// insert item in database
        /// </summary>
        /// <param name="product">object of item as a parameter</param>
        void InsertItem(T item);
        /// <summary>
        /// Update item
        /// </summary>
        /// <param name="product">object of item as a parameter</param>
        void UpdateItem(T item);

    }
}
