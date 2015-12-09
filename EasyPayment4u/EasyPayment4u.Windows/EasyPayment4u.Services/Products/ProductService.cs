using EasyPayment4u.Core.Data;
using EasyPayment4u.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        public ProductService(IRepository<Product> productRepository)
        {
            this._productRepository = productRepository;
        }
        public Product GetProduct(int productID)
        {
            if(productID==0)
                return null;

            return _productRepository.GetById(productID);
        }

        public IList<Product> GetProducts()
        {
            return _productRepository.Table.ToList<Product>();
        }

        public IList<Product> GetProductByIds(int[] productIds)
        {
            if (productIds == null || productIds.Length == 0)
                return new List<Product>();

            var query = from o in _productRepository.Table
                        where productIds.Contains(o.ProductID)
                        select o;
            var orders = query.ToList();
            //sort by passed identifiers
            var sortedOrders = new List<Product>();
            foreach (int id in productIds)
            {
                var order = orders.Find(x => x.ProductID == id);
                if (order != null)
                    sortedOrders.Add(order);
            }
            return sortedOrders;

        }

        public void DeleteProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException("product");

           // product.Deleted = true;
            UpdateProduct(product);
        }

        /// <summary>
        /// Updates the product
        /// </summary>
        /// <param name="order">The Product</param>
        public virtual void UpdateProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException("product");

            _productRepository.Update(product);

            //event notification
            //_eventPublisher.EntityUpdated(order);
        }

        public void InsertProduct(Data.Product product)
        {
            if (product == null)
                throw new ArgumentNullException("product");
            _productRepository.Insert(product);
        }

    }
      
}
