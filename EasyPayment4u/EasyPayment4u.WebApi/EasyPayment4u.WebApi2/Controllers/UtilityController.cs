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
    [RoutePrefix("Utility")]
    public class UtilityController : ApiController
    {
        [Route("WebSiteName")]
        [HttpGet]
        public string GetWebSiteName()
        {
            string strWebSiteName = "EasyPayment4u";
            return strWebSiteName;
        }
    }
}
