using EasyPayment4u.Data;
using EasyPayment4u.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EasyPayment4u.WebAPI.Controllers
{
    [RoutePrefix("ProductTest")]
    public class ProductController : ApiController
    {
        private readonly ITestService _objITestService;
        private readonly IProductService _objIProductService;
        public ProductController(ITestService objITestService,IProductService objIProductService)
        {
            this._objITestService = objITestService;
            this._objIProductService = objIProductService;

        }

        public ProductController()
        {

        }

        IEnumerable<Product> _productList = new List<Product>
        {
            new Product{Name="Samsung",ID=1,ProductTypeID=1,Description="Samsung Description"},
            new Product{Name="Motorola",ID=2,ProductTypeID=1,Description="Motorola Description"},
            new Product{Name="Nokia",ID=3,ProductTypeID=1,Description="Nokia Description"},
            new Product{Name="Sony",ID=4,ProductTypeID=1,Description="Sony Description"},
            new Product{Name="Ausus",ID=5,ProductTypeID=1,Description="Ausus Description"},
            new Product{Name="Intex",ID=6,ProductTypeID=1,Description="Intex Description"},
        };

        public Product Get(int id)
        {
            return _productList.FirstOrDefault();
        }

        [Route("GetProducts")]
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return _productList;
        }

        [Route("GetAllProduct")]
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _objIProductService.GetProducts();
        }

    }
}
