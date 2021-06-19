using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace FileUploadDemo.Controllers
{
    public class BaseController : Controller
    {
		protected override void OnAuthentication(AuthenticationContext filterContext)
		{
			base.OnAuthentication(filterContext);
		}
		protected override void OnAuthorization(AuthorizationContext filterContext)
		{
			base.OnAuthorization(filterContext);
		}
		protected override void OnException(ExceptionContext filterContext)
		{
			base.OnException(filterContext);
		}
		// GET: Base
		public ActionResult Index()
        {
            return Redirect("~");
        }
    }
}