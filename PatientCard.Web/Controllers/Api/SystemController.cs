using System.Collections.Generic;
using System.Web.Http;
using PatientCard.Core;
using PatientCard.Core.Models;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Web.Controllers.Api
{
	public class SystemController : ApiController
	{
		private readonly ISystemService _systemService;

		public SystemController()
		{
			_systemService = Bootstrap.BuildFactory.GetInstance<ISystemService>();
		}

		[HttpGet]
		[ActionName("Jobs")]
		public IList<Job> GetJobs()
		{
			return _systemService.GetJobs();
		}

		[HttpGet]
		[ActionName("Survey-Types")]
		public IList<SurveyType> GetSurveyTypes()
		{
			return _systemService.GetSurveyTypes();
		}

		[HttpGet]
		[ActionName("First-Survey-Options")]
		public IList<FirstSurveyOption> GetFirstSurveyOptions()
		{
			return _systemService.GetFirstSurveyOptions();
		}

		[HttpGet]
		[ActionName("Threatment-Options")]
		public IList<ThreatmentOption> GetThreatmentOptions()
		{
			return _systemService.GetThreatmentOptions();
		}
	}
}
