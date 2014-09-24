using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using PatientCard.Core;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Web.Controllers
{
	public class PageController : Controller
	{
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
