using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatientCard.Web.Controllers
{
    public class PageController : Controller
    {
        //
        // GET: /Page/

        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Home()
		{
			return View();
		}

		public ActionResult Patients()
		{
			return View();
		}

		public ActionResult Patient()
		{
			return View();
		}

		public ActionResult Help()
		{
			return View();
		}

		public ActionResult About()
		{
			return View();
		}
    }
}
