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
		private readonly ISystemService _systemService;

		public PageController()
		{
			_systemService = Bootstrap.BuildFactory.GetInstance<ISystemService>();
		}


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

		[ActionName("PatientOverview")]
		public ActionResult PatientOverview()
		{
			return View();
		}

		public ActionResult PatientEditor()
		{
			return View();
		}

		[ActionName("PatientFirstSurvey")]
		public ActionResult PatientFirstSurvey()
		{
			var model = _systemService.GetFirstSurveyOptions().OrderBy(n => n.Key).ToList();
			return View(model);
		}

		public ActionResult PatientThreatmentPlan()
		{
			var model = _systemService.GetThreatmentOptions();
			ViewBag.View = true;
			return View(model);
		}

		public ActionResult PatientThreatmentPlanEditor()
		{
			var model = _systemService.GetThreatmentOptions();
			ViewBag.View = false;
			return View("PatientThreatmentPlan", model);
		}

		public ActionResult PatientSurvey()
		{
			return View();
		}

		public ActionResult PatientVisitDiary()
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
