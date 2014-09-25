using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatientCard.Web.Controllers
{
    public class WidgetController : Controller
    {
        public ActionResult Landing()
        {
            return View();
        }

		public ActionResult Breadcrumb()
		{
			return View();
		}

	    public ActionResult TableHeader()
	    {
		    return View();
	    }
    }
}
