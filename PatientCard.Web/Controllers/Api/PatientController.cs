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
		[ActionName("Treatment-Plan")]
		public IList<TreatmentPlan> GetTreatmentPlan(int patientId)
		{
			return _patientService.GetTreatmentPlan(patientId);
		}

		[HttpPost]
		[ActionName("Treatment-Plan")]
		public HttpResponseMessage PostTreatmentPlan([FromBody]IList<TreatmentPlan> plan)
		{
			_patientService.StoreTreatmentPlan(plan);
			return new HttpResponseMessage(HttpStatusCode.Created);
		}

		[HttpGet]
		[ActionName("Visit")]
		public IList<Visit> GetVisits(int patientId)
		{
			return _patientService.GetVisits(patientId);
		}

		[HttpPost]
		[ActionName("Visit")]
		public HttpResponseMessage PostVisitDiary(Visit visit)
		{
			_patientService.StoreVisit(visit);
			return new HttpResponseMessage(HttpStatusCode.Created);
		}

		[HttpGet]
		[ActionName("Dentist-Status")]
		public IList<DentistStatus> GetDentistStatuses(int patientId)
		{
			return _patientService.GetDentistStatuses(patientId);
		}

		[HttpPost]
		[ActionName("Dentist-Status")]
		public HttpResponseMessage PostDentistStatus(DentistStatus dentistStatus)
		{
			_patientService.StoreDentistStatus(dentistStatus);
			return new HttpResponseMessage(HttpStatusCode.Created);
		}

		[HttpGet]
		[ActionName("Cpi-Status")]
		public IList<CpiStatus> GetCpiStatuses(int patientId)
		{
			return _patientService.GetCpiStatuses(patientId);
		}

		[HttpPost]
		[ActionName("Cpi-Status")]
		public HttpResponseMessage PostCpiStatus(CpiStatus cpiStatus)
		{
			_patientService.StoreCpiStatus(cpiStatus);
			return new HttpResponseMessage(HttpStatusCode.Created);
		}

		[HttpGet]
		[ActionName("Dfm-Status")]
		public IList<DfmStatus> GetDfmStatuses(int patientId)
		{
			return _patientService.GetDfmStatuses(patientId);
		}

		[HttpPost]
		[ActionName("Dfm-Status")]
		public HttpResponseMessage PostDfmStatus(DfmStatus dfmStatus)
		{
			_patientService.StoreDfmStatus(dfmStatus);
			return new HttpResponseMessage(HttpStatusCode.Created);
		}

		[HttpGet]
		[ActionName("Ohis-Status")]
		public IList<OhisStatus> GetOhisStatuses(int patientId)
		{
			return _patientService.GetOhisStatuses(patientId);
		}

		[HttpPost]
		[ActionName("Ohis-Status")]
		public HttpResponseMessage PostOhisStatus(OhisStatus ohisStatus)
		{
			_patientService.StoreOhisStatus(ohisStatus);
			return new HttpResponseMessage(HttpStatusCode.Created);
		}
	}
}
