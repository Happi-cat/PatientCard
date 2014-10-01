using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using PatientCard.Core;
using PatientCard.Core.Models;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Web.Controllers.Api
{
	public class PatientController : ApiController
	{
		private readonly IPatientService _patientService;

		public PatientController()
		{
			_patientService = Bootstrap.BuildFactory.GetInstance<IPatientService>();
		}

		[HttpGet]
		public IList<Patient> Get()
		{
			var principal = Thread.CurrentPrincipal;
			return _patientService.GetAll();
		}

		[HttpGet]
		public Patient Get(int id)
		{
			return _patientService.Get(new Patient {Key = id});
		}

		[HttpPost]
		public HttpResponseMessage Post(Patient patient)
		{
			_patientService.Store(patient);
			return new HttpResponseMessage(HttpStatusCode.Created);
		}

		[HttpDelete]
		public HttpResponseMessage Delete(int id)
		{
			_patientService.Delete(new Patient {Key = id});
			return new HttpResponseMessage(HttpStatusCode.NoContent);
		}

		[HttpGet]
		[ActionName("First-Survey")]
		public FirstSurvey GetFirstSurvey(int patientId)
		{
			return _patientService.GetFirstSurvey(patientId);
		}

		[HttpPost]
		[ActionName("First-Survey")]
		public HttpResponseMessage PostFirstSurvey(FirstSurvey survey)
		{
			_patientService.StoreFirstSurvey(survey);
			return new HttpResponseMessage(HttpStatusCode.Created);
		}

		[HttpGet]
		[ActionName("Survey")]
		public IList<Survey> GetSurveys(int patientId)
		{
			return _patientService.GetSurveys(patientId);
		}

		[HttpPost]
		[ActionName("Survey")]
		public HttpResponseMessage PostSurvey(Survey survey)
		{
			_patientService.StoreSurvey(survey);
			return new HttpResponseMessage(HttpStatusCode.Created);
		}

		[HttpGet]
		[ActionName("Threatment-Plan")]
		public IList<ThreatmentPlan> GetThreatmentPlan(int patientId)
		{
			return _patientService.GetThreatmentPlan(patientId);
		}

		[HttpPost]
		[ActionName("Threatment-Plan")]
		public HttpResponseMessage PostThreatmentPlan([FromBody]IList<ThreatmentPlan> plan)
		{
			_patientService.StoreThreatmentPlan(plan);
			return new HttpResponseMessage(HttpStatusCode.Created);
		}

		[HttpGet]
		[ActionName("Visit-Diary")]
		public IList<VisitDiary> GetVisitDiary(int patientId)
		{
			return _patientService.GetVisitDiary(patientId);
		}

		[HttpPost]
		[ActionName("Visit-Diary")]
		public HttpResponseMessage PostVisitDiary(VisitDiary visitDiary)
		{
			_patientService.StoreVisitDiary(visitDiary);
			return new HttpResponseMessage(HttpStatusCode.Created);
		}
	}
}
