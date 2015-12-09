using EasyPayment4u.Data;
using EasyPayment4u.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EasyPayment4u.WebApi2.Controllers
{
    //http://www.asp.net/web-api/overview/security/enabling-cross-origin-requests-in-web-api
    //http://stackoverflow.com/questions/6290053/setting-access-control-allow-origin-in-asp-net-mvc-simplest-possible-method
    [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
    [AllowCrossSiteJson]
    [RoutePrefix("Product")]
    public class ProductController : ApiController
    {
        private readonly ITestService _objITestService;
        private readonly IProductService _objIProductService;

        List<test> obj = new List<test>(); 
        public ProductController(ITestService objITestService, IProductService objIProductService)
        {
            this._objITestService = objITestService;
            this._objIProductService = objIProductService;



            obj.Add(new test { UserName ="Jatin", Password = "jatin" });
        }

        IEnumerable<Product> _productList = new List<Product>
        {
            new Product{Name="Samsung",ID=1,ProductTypeID=1,Description="Samsung Description"},
            new Product{Name="Motorola",ID=2,ProductTypeID=1,Description="Motorola Description"},
            new Product{Name="Nokia",ID=1,Description="Nokia Description"},
            new Product{Name="Sony",ID=4,ProductTypeID=1,Description="Sony Description"},
            new Product{Name="Ausus",ID=5,ProductTypeID=1,Description="Ausus Description"},
            new Product{Name="Intex",ID=6,ProductTypeID=1,Description="Intex Description"},
        };

        [Route("GetProduct")]
        [HttpGet]
        public Product GetProduct()
        {
            return _productList.ToList()[0];
        }

        [Route("Get-Products")]
        [HttpGet]
        [Authorize]
        public IEnumerable<Product> GetAllProducts()
        {
            return _productList;
        }

        [Route("GetProductsByProductType/{id}")]
        [HttpGet]
        public IEnumerable<Product> GetProductsByProductType(int id)
        {
            var productList = _objIProductService.GetProductbyType(id);
            return productList;
        }

        [Route("GetProduct/{id}")]
        [HttpGet]
        public Product GetProduct(int id)
        {
            return _objIProductService.GetProduct(id);
        }



        [Route("GetProducts")]
        [HttpGet]
        public List<Product> GetProducts()
        {
            
            try
            {
                var productList = _objIProductService.GetProducts();
                return productList.ToList();
                
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [Route("UpdateProduct")]
        [HttpPost]
        public void UpdateProduct(Product product)
        {
            try
            {
                _objIProductService.UpdateProduct(product);
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

        [Route("DeleteProduct")]
        [HttpGet]
        public void DeleteProduct(Product product)
        {
            try
            {
                _objIProductService.DeleteProduct(product);
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

        [Route("AddProduct")]
        [HttpPost]
        public void InsertProduct(Product product)
        {
            try
            {
                _objIProductService.InsertProduct(product);
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
    }



    public class test
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
