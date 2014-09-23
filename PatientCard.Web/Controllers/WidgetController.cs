using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PatientCard.Core;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Web.Controllers
{
    public class WidgetController : Controller
    {
        private readonly ISystemService _systemService;

		public WidgetController()
		{
			_systemService = Bootstrap.BuildFactory.GetInstance<ISystemService>();
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
			var model = _systemService.GetFirstSurveyOptions();
			return View(model);
		}

		[ActionName("PatientThreatmentPlan")]
		public ActionResult PatientThreatmentPlan()
		{
			var model = _systemService.GetThreatmentOptions();
			return View(model);
		}

		public ActionResult PatientSurvey()
		{
			return View();
		}

		public ActionResult PatientVisitDiary()
		{
			return View();
		}
    }
}
