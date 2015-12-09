using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EasyPayment4u.WebApi2
{
    public class ApplicationAuthorizationAttribute :AuthorizeAttribute
    {
        protected override bool IsAuthorized(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            //var categoryId = HttpContext.Current.Request.QueryString[_securableObjectName];
            //var authenticatedUser = (System.Web.Http.AuthorizeAttribute AuthenticatedUser)HttpContext.Current.Items["AuthenticatedUser"];
            return base.IsAuthorized(actionContext);
        }
        public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            base.OnAuthorization(actionContext);
        }
        public override System.Threading.Tasks.Task OnAuthorizationAsync(System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken)
        {
            return base.OnAuthorizationAsync(actionContext, cancellationToken);
        }
       

        
    }
}