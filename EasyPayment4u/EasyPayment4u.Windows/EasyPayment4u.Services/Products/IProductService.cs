using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyPayment4u.Data;

namespace EasyPayment4u.Services
{
    public interface IProductService
    {
        /// <summary>
        /// Get slected product based on ProductID
        /// </summary>
        /// <param name="productID">Product ID</param>
        /// <returns>Product</returns>
        Product  GetProduct(int productID);
        /// <summary>
        /// Get All Products
        /// </summary>
        /// <returns>Return list of products</returns>
        IList<Product> GetProducts();
        /// <summary>
        /// Get Product based on ids
        /// </summary>
        /// <param name="orderIds">array of id's</param>
        /// <returns>List of product</returns>
        IList<Product> GetProductByIds(int[] productIds);
        /// <summary>
        /// Delete selected product
        /// </summary>
        /// <param name="product">pass product</param>
        void DeleteProduct(Product product);
        /// <summary>
        /// insert product in database
        /// </summary>
        /// <param name="product">object of product as a parameter</param>
        void InsertProduct(Product product);
        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="product">object of product as a parameter</param>
        void UpdateProduct(Product product);

    }
}
