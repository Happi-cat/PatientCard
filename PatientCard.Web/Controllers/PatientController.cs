using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PatientCard.Core;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Web.Controllers
{
    public class PatientController : Controller
    {
		private readonly ISystemService _systemService;

		public PatientController()
		{
			_systemService = Bootstrap.BuildFactory.GetInstance<ISystemService>();
		}


		public ActionResult Overview()
		{
			return View();
		}

		public ActionResult Editor()
		{
			return View();
		}

		public ActionResult FirstSurvey()
		{
			var model = _systemService.GetFirstSurveyOptions().OrderBy(n => n.Key).ToList();
			return View(model);
		}

		public ActionResult ThreatmentPlan()
		{
			var model = _systemService.GetThreatmentOptions();
			ViewBag.View = true;
			return View(model);
		}

		public ActionResult ThreatmentPlanEditor()
		{
			var model = _systemService.GetThreatmentOptions();
			ViewBag.View = false;
			return View("ThreatmentPlan", model);
		}

		public ActionResult Survey()
		{
			return View();
		}

		public ActionResult VisitDiary()
		{
			return View();
		}

    }
}
