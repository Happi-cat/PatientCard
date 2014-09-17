using System.Collections.Generic;
using System.Net;
using System.Net.Http;
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

		//[HttpPost]
		//[Authorize]
		//[ActionName("Jobs")]
		//public HttpResponseMessage PostJob(Job job)
		//{
		//	_jobService.StoreItem(job);
		//	return new HttpResponseMessage(HttpStatusCode.Created);
		//}

		//[HttpDelete]
		//[Authorize]
		//[ActionName("Jobs")]
		//public HttpResponseMessage DeleteJob(string id)
		//{
		//	_jobService.DeleteItem(new Job { Name = id });
		//	return new HttpResponseMessage(HttpStatusCode.NoContent);
		//}

		[HttpGet]
		[ActionName("Survey-Types")]
		public IList<SurveyType> GetSurveyTypes()
		{
			return _systemService.GetSurveyTypes();
		}

		//[HttpPost]
		//[Authorize]
		//[ActionName("Survey-Types")]
		//public HttpResponseMessage PostSurveyTypes(SurveyType survey)
		//{
		//	_surveyTypesService.StoreItem(survey);
		//	return new HttpResponseMessage(HttpStatusCode.Created);
		//}

		//[HttpDelete]
		//[Authorize]
		//[ActionName("Survey-Types")]
		//public HttpResponseMessage DeleteSurveyTypes(int? id)
		//{
		//	if (id.HasValue)
		//		_surveyTypesService.DeleteItem(new SurveyType { Key = id.Value });
		//	return new HttpResponseMessage(HttpStatusCode.NoContent);
		//}

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

		//[HttpPost]
		//[Authorize]
		//[ActionName("Threatment-Options")]
		//public HttpResponseMessage PostThreatmentOptions(ThreatmentOption option)
		//{
		//	_threatmentOptionsService.StoreItem(option);
		//	return new HttpResponseMessage(HttpStatusCode.Created);
		//}

		//[HttpDelete]
		//[Authorize]
		//[ActionName("Threatment-Options")]
		//public HttpResponseMessage DeleteThreatmentOptions(int? id)
		//{
		//	if (id.HasValue)
		//		_threatmentOptionsService.DeleteItem(new ThreatmentOption { Key = id.Value });
		//	return new HttpResponseMessage(HttpStatusCode.NoContent);
		//}
	}
}
