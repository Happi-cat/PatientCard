using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Core.Services
{
	public class PatientService : Service<Patient, int>, IPatientService
	{
		private readonly IAccountService _accountService;

		private readonly IUnityOfWork _unityOfWork;


		public PatientService(IAccountService accountService, IUnityOfWork unityOfWork)
		{
			Repository = unityOfWork.PatientRepositopry;
			_unityOfWork = unityOfWork;
			_accountService = accountService;
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public new Patient Get(Patient key)
		{
			return base.Get(key);
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public new IList<Patient> GetAll()
		{
			return base.GetAll();
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public new void Store(Patient item)
		{
			Validator.ValidateObject(item, new ValidationContext(item));
			base.Store(item);
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
		public new void Delete(Patient item)
		{
			base.Delete(item);
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public FirstSurvey GetFirstSurvey(int patientId)
		{
			var firstSurvey = _unityOfWork.FirstSurveyRepository.GetPatientItems(patientId).FirstOrDefault();
			if (firstSurvey != null)
			{
				firstSurvey.Details = _unityOfWork.FirstSurveyDetailRepository.GetPatientItems(patientId);
			}
			return firstSurvey;
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
		[PrincipalPermission(SecurityAction.Demand, Role = "Doctor")]
		public void StoreFirstSurvey(FirstSurvey survey)
		{
			Validator.ValidateObject(survey, new ValidationContext(survey));
			if (_unityOfWork.FirstSurveyRepository.CheckExist(survey))
			{
				_unityOfWork.FirstSurveyRepository.Update(survey);
			}
			else
			{
				_unityOfWork.FirstSurveyRepository.Create(survey);
			}
			if (survey.Details != null)
			{
				StoreFirstSurveyDetails(survey.Details);
			}
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
		[PrincipalPermission(SecurityAction.Demand, Role = "Doctor")]
		private void StoreFirstSurveyDetails(IList<FirstSurveyDetail> surveyDetails)
		{
			foreach (var detail in surveyDetails)
			{
				Validator.ValidateObject(detail, new ValidationContext(detail));
				if (_unityOfWork.FirstSurveyDetailRepository.CheckExist(detail))
				{
					_unityOfWork.FirstSurveyDetailRepository.Update(detail);
				}
				else
				{
					_unityOfWork.FirstSurveyDetailRepository.Create(detail);
				}
			}
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public IList<Survey> GetSurveys(int patientId)
		{
			var list = _unityOfWork.SurveyRepository.GetPatientItems(patientId);
			foreach (var survey in list)
			{
				if (!string.IsNullOrEmpty(survey.Username))
				{
					survey.User = _accountService.Get(new User {Username = survey.Username});
				}
			}
			return list;
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
		[PrincipalPermission(SecurityAction.Demand, Role = "Doctor")]
		public void StoreSurvey(Survey survey)
		{
			survey.Username = Thread.CurrentPrincipal.Identity.Name;
			Validator.ValidateObject(survey, new ValidationContext(survey));
			if (_unityOfWork.SurveyRepository.CheckExist(survey))
			{
				_unityOfWork.SurveyRepository.Update(survey);
			}
			else
			{
				_unityOfWork.SurveyRepository.Create(survey);
			}
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public IList<ThreatmentPlan> GetThreatmentPlan(int patientId)
		{
			var list = _unityOfWork.ThreatmentPlanRepository.GetPatientItems(patientId);
			foreach (var plan in list)
			{
				if (!string.IsNullOrEmpty(plan.Username))
				{
					plan.User = _accountService.Get(new User { Username = plan.Username });
				}
			}
			return list;
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
		[PrincipalPermission(SecurityAction.Demand, Role = "Doctor")]
		public void StoreThreatmentPlan(IList<ThreatmentPlan> plan)
		{
			foreach (var p in plan)
			{
				p.Username = Thread.CurrentPrincipal.Identity.Name;
				Validator.ValidateObject(p, new ValidationContext(p));
				if (_unityOfWork.ThreatmentPlanRepository.CheckExist(p))
				{
					_unityOfWork.ThreatmentPlanRepository.Update(p);
				}
				else
				{
					_unityOfWork.ThreatmentPlanRepository.Create(p);
				}
			}
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public IList<VisitDiary> GetVisitDiary(int patientId)
		{
			var list = _unityOfWork.VisitDiaryRepository.GetPatientItems(patientId);
			foreach (var visit in list)
			{
				if (!string.IsNullOrEmpty(visit.Username))
				{
					visit.User = _accountService.Get(new User { Username = visit.Username });
				}
			}
			return list;
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
		[PrincipalPermission(SecurityAction.Demand, Role = "Doctor")]
		public void StoreVisitDiary(VisitDiary visitDiary)
		{
			visitDiary.Username = Thread.CurrentPrincipal.Identity.Name;
			Validator.ValidateObject(visitDiary, new ValidationContext(visitDiary));
			if (_unityOfWork.VisitDiaryRepository.CheckExist(visitDiary))
			{
				_unityOfWork.VisitDiaryRepository.Update(visitDiary);
			}
			else
			{
				_unityOfWork.VisitDiaryRepository.Create(visitDiary);
			}
		}
	}
}