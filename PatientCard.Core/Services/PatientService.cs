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

		private readonly IFirstSurveyRepository _firstSurveyRepository;
		private readonly IFirstSurveyDetailRepository _firstSurveyDetailRepository;
		private readonly IThreatmentPlanRepository _threatmentPlanRepository;
		private readonly ISurveyRepository _surveyRepository;
		private readonly IVisitDiaryRepository _visitRepository;


		public PatientService(IAccountService accountService, IRepository<Patient, int> repository, IFirstSurveyRepository firstSurveyRepository, IFirstSurveyDetailRepository firstSurveyDetailRepository,
			IThreatmentPlanRepository threatmentPlanRepository, ISurveyRepository surveyRepository, IVisitDiaryRepository visitDiaryRepository)
			: base(repository)
		{
			_firstSurveyRepository = firstSurveyRepository;
			_firstSurveyDetailRepository = firstSurveyDetailRepository;
			_threatmentPlanRepository = threatmentPlanRepository;
			_surveyRepository = surveyRepository;
			_visitRepository = visitDiaryRepository;
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

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrators")]
		public new void Delete(Patient item)
		{
			base.Delete(item);
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public FirstSurvey GetFirstSurvey(int patientId)
		{
			var firstSurvey = _firstSurveyRepository.GetPatientItems(patientId).FirstOrDefault();
			if (firstSurvey != null)
			{
				firstSurvey.Details = _firstSurveyDetailRepository.GetPatientItems(patientId);
			}
			return firstSurvey;
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrators")]
		[PrincipalPermission(SecurityAction.Demand, Role = "Doctors")]
		public void StoreFirstSurvey(FirstSurvey survey)
		{
			Validator.ValidateObject(survey, new ValidationContext(survey));
			if (_firstSurveyRepository.CheckExist(survey))
			{
				_firstSurveyRepository.Update(survey);
			}
			else
			{
				_firstSurveyRepository.Create(survey);
			}
			if (survey.Details != null)
			{
				StoreFirstSurveyDetails(survey.Details);
			}
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrators")]
		[PrincipalPermission(SecurityAction.Demand, Role = "Doctors")]
		private void StoreFirstSurveyDetails(IList<FirstSurveyDetail> surveyDetails)
		{
			foreach (var detail in surveyDetails)
			{
				Validator.ValidateObject(detail, new ValidationContext(detail));
				if (_firstSurveyDetailRepository.CheckExist(detail))
				{
					_firstSurveyDetailRepository.Update(detail);
				}
				else
				{
					_firstSurveyDetailRepository.Create(detail);
				}
			}
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public IList<Survey> GetSurveys(int patientId)
		{
			var list = _surveyRepository.GetPatientItems(patientId);
			foreach (var survey in list)
			{
				if (!string.IsNullOrEmpty(survey.Username))
				{
					survey.User = _accountService.Get(new User {Username = survey.Username});
				}
			}
			return list;
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrators")]
		[PrincipalPermission(SecurityAction.Demand, Role = "Doctors")]
		public void StoreSurvey(Survey survey)
		{
			survey.Username = Thread.CurrentPrincipal.Identity.Name;
			Validator.ValidateObject(survey, new ValidationContext(survey));
			if (_surveyRepository.CheckExist(survey))
			{
				_surveyRepository.Update(survey);
			}
			else
			{
				_surveyRepository.Create(survey);
			}
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public IList<ThreatmentPlan> GetThreatmentPlan(int patientId)
		{
			var list = _threatmentPlanRepository.GetPatientItems(patientId);
			foreach (var plan in list)
			{
				if (!string.IsNullOrEmpty(plan.Username))
				{
					plan.User = _accountService.Get(new User { Username = plan.Username });
				}
			}
			return list;
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrators")]
		[PrincipalPermission(SecurityAction.Demand, Role = "Doctors")]
		public void StoreThreatmentPlan(IList<ThreatmentPlan> plan)
		{
			foreach (var p in plan)
			{
				p.Username = Thread.CurrentPrincipal.Identity.Name;
				Validator.ValidateObject(p, new ValidationContext(p));
				if (_threatmentPlanRepository.CheckExist(p))
				{
					_threatmentPlanRepository.Update(p);
				}
				else
				{
					_threatmentPlanRepository.Create(p);
				}
			}
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public IList<VisitDiary> GetVisitDiary(int patientId)
		{
			var list = _visitRepository.GetPatientItems(patientId);
			foreach (var visit in list)
			{
				if (!string.IsNullOrEmpty(visit.Username))
				{
					visit.User = _accountService.Get(new User { Username = visit.Username });
				}
			}
			return list;
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrators")]
		[PrincipalPermission(SecurityAction.Demand, Role = "Doctors")]
		public void StoreVisitDiary(VisitDiary visitDiary)
		{
			visitDiary.Username = Thread.CurrentPrincipal.Identity.Name;
			Validator.ValidateObject(visitDiary, new ValidationContext(visitDiary));
			if (_visitRepository.CheckExist(visitDiary))
			{
				_visitRepository.Update(visitDiary);
			}
			else
			{
				_visitRepository.Create(visitDiary);
			}
		}
	}
}