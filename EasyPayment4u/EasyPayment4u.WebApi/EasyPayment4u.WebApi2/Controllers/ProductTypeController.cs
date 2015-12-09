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
    [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
    [AllowCrossSiteJson]
    [RoutePrefix("ProductType")]
    public class ProductTypeController : ApiController
    {
        private readonly IProductTypeService _objIProductTypeService;

        List<test> obj = new List<test>();
        public ProductTypeController(IProductTypeService objIProductTypeService)
        {
            this._objIProductTypeService = objIProductTypeService;
        }

        [Route("GetProductTypes")]
        [HttpGet]
        public List<ProductType> GetProductTypes()
        {

            try
            {
                var productTypeList = _objIProductTypeService.GetProductTypes();
                return productTypeList.ToList();

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [Route("GetProductType/{id}")]
        [HttpGet]
        public ProductType GetProductType(int id)
        {
            return _objIProductTypeService.GetProductType(id);
        }
    }
}
