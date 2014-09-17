using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatientCard.Web.Controllers
{
    public class WidgetController : Controller
    {
        //
        // GET: /Widget/
		[ActionName("Patient-Overview")]
        public ActionResult PatientOverview()
        {
            return View();
        }

		[ActionName("Patient-First-Survey")]
		public ActionResult PatientFirstSurvey()
		{
			return View();
		}

    }
}
