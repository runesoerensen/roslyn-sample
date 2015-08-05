using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoslynSample.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return Content($"Hello there. The clock is {DateTime.UtcNow}");
		}
	}
}
