using EasyPayment4u.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Services.Consumers
{
    public interface IConsumerService
    {
        /// <summary>
        /// Get slected product based on ProductID
        /// </summary>
        /// <param name="productID">Product ID</param>
        /// <returns>Product</returns>
        Consumer GetConsumer(int consumerID);
        /// <summary>
        /// Get All Products
        /// </summary>
        /// <returns>Return list of products</returns>
        IList<Consumer> GetConsumers();
        /// <summary>
        /// Get Product based on ids
        /// </summary>
        /// <param name="orderIds">array of id's</param>
        /// <returns>List of product</returns>
        IList<Consumer> GetConsumerByIds(int[] consumerIDs);
        /// <summary>
        /// Delete selected product
        /// </summary>
        /// <param name="product">pass product</param>
        void DeleteConsumer(Consumer consumer);
        /// <summary>
        /// insert product in database
        /// </summary>
        /// <param name="product">object of product as a parameter</param>
        void InsertConsumer(Consumer consumer);
        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="product">object of product as a parameter</param>
        void UpdateConsumer(Consumer consumer);
    }
}
