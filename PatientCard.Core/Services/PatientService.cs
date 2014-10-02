using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;
using PatientCard.Core.Services.Interfaces;
using PatientCard.Core.Utilities;

namespace PatientCard.Core.Services
{
	public class PatientService : Service<Patient, int>, IPatientService
	{
		private readonly IAccountService _accountService;

		private readonly IUnityOfWork _unityOfWork;


		public PatientService(IAccountService accountService, IUnityOfWork unityOfWork)
		{
			Repository = unityOfWork.Patient;
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
			var firstSurvey = _unityOfWork.FirstSurvey.GetPatientItems(patientId).FirstOrDefault();
			if (firstSurvey != null)
			{
				firstSurvey.Details = _unityOfWork.FirstSurveyDetail.GetPatientItems(patientId);
			}
			return firstSurvey;
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
		[PrincipalPermission(SecurityAction.Demand, Role = "Doctor")]
		public void StoreFirstSurvey(FirstSurvey survey)
		{
			Validator.ValidateObject(survey, new ValidationContext(survey));
			if (_unityOfWork.FirstSurvey.CheckExist(survey))
			{
				_unityOfWork.FirstSurvey.Update(survey);
			}
			else
			{
				_unityOfWork.FirstSurvey.Create(survey);
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
				if (_unityOfWork.FirstSurveyDetail.CheckExist(detail))
				{
					_unityOfWork.FirstSurveyDetail.Update(detail);
				}
				else
				{
					_unityOfWork.FirstSurveyDetail.Create(detail);
				}
			}
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public IList<Survey> GetSurveys(int patientId)
		{
			var list = _unityOfWork.Survey.GetPatientItems(patientId);
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
			if (_unityOfWork.Survey.CheckExist(survey))
			{
				_unityOfWork.Survey.Update(survey);
			}
			else
			{
				_unityOfWork.Survey.Create(survey);
			}
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public IList<TreatmentPlan> GetTreatmentPlan(int patientId)
		{
			var list = _unityOfWork.TreatmentPlan.GetPatientItems(patientId);
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
		public void StoreTreatmentPlan(IList<TreatmentPlan> plan)
		{
			foreach (var p in plan)
			{
				p.Username = Thread.CurrentPrincipal.Identity.Name;
				Validator.ValidateObject(p, new ValidationContext(p));
				if (_unityOfWork.TreatmentPlan.CheckExist(p))
				{
					_unityOfWork.TreatmentPlan.Update(p);
				}
				else
				{
					_unityOfWork.TreatmentPlan.Create(p);
				}
			}
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public IList<Visit> GetVisits(int patientId)
		{
			var list = _unityOfWork.Visit.GetPatientItems(patientId);
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
		public void StoreVisit(Visit visit)
		{
			visit.Username = Thread.CurrentPrincipal.Identity.Name;
			Validator.ValidateObject(visit, new ValidationContext(visit));
			if (_unityOfWork.Visit.CheckExist(visit))
			{
				_unityOfWork.Visit.Update(visit);
			}
			else
			{
				_unityOfWork.Visit.Create(visit);
			}
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public IList<DentistStatus> GetDentistStatuses(int patientId)
		{
			var list = _unityOfWork.DentistStatus.GetPatientItems(patientId);
			foreach (var dentistStatus in list)
			{
				if (!string.IsNullOrEmpty(dentistStatus.Username))
				{
					dentistStatus.User = _accountService.Get(new User { Username = dentistStatus.Username });
				}
			}
			return list;
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
		[PrincipalPermission(SecurityAction.Demand, Role = "Doctor")]
		public void StoreDentistStatus(DentistStatus dentistStatus)
		{
			dentistStatus.Username = Thread.CurrentPrincipal.Identity.Name;
			Validator.ValidateObject(dentistStatus, new ValidationContext(dentistStatus));
			if (_unityOfWork.DentistStatus.CheckExist(dentistStatus))
			{
				_unityOfWork.DentistStatus.Update(dentistStatus);
			}
			else
			{
				_unityOfWork.DentistStatus.Create(dentistStatus);
			}
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public IList<CpiStatus> GetCpiStatuses(int patientId)
		{
			var list = _unityOfWork.CpiStatus.GetPatientItems(patientId);
			foreach (var cpiStatus in list)
			{
				if (!string.IsNullOrEmpty(cpiStatus.Username))
				{
					cpiStatus.User = _accountService.Get(new User { Username = cpiStatus.Username });
				}
			}
			return list;
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
		[PrincipalPermission(SecurityAction.Demand, Role = "Doctor")]
		public void StoreCpiStatus(CpiStatus cpiStatus)
		{
			cpiStatus.Username = Thread.CurrentPrincipal.Identity.Name;
			Validator.ValidateObject(cpiStatus, new ValidationContext(cpiStatus));
			CalcHelper.CalcCpi(cpiStatus);
			if (_unityOfWork.CpiStatus.CheckExist(cpiStatus))
			{
				_unityOfWork.CpiStatus.Update(cpiStatus);
			}
			else
			{
				_unityOfWork.CpiStatus.Create(cpiStatus);
			}
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public IList<DfmStatus> GetDfmStatuses(int patientId)
		{
			var list = _unityOfWork.DfmStatus.GetPatientItems(patientId);
			foreach (var dfmStatus in list)
			{
				if (!string.IsNullOrEmpty(dfmStatus.Username))
				{
					dfmStatus.User = _accountService.Get(new User { Username = dfmStatus.Username });
				}
			}
			return list;
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
		[PrincipalPermission(SecurityAction.Demand, Role = "Doctor")]
		public void StoreDfmStatus(DfmStatus dfmStatus)
		{
			dfmStatus.Username = Thread.CurrentPrincipal.Identity.Name;
			Validator.ValidateObject(dfmStatus, new ValidationContext(dfmStatus));
			CalcHelper.CalcDfm(dfmStatus);
			if (_unityOfWork.DfmStatus.CheckExist(dfmStatus))
			{
				_unityOfWork.DfmStatus.Update(dfmStatus);
			}
			else
			{
				_unityOfWork.DfmStatus.Create(dfmStatus);
			}
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public IList<OhisStatus> GetOhisStatuses(int patientId)
		{
			var list = _unityOfWork.OhisStatus.GetPatientItems(patientId);
			foreach (var ohisStatus in list)
			{
				if (!string.IsNullOrEmpty(ohisStatus.Username))
				{
					ohisStatus.User = _accountService.Get(new User { Username = ohisStatus.Username });
				}
			}
			return list;
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
		[PrincipalPermission(SecurityAction.Demand, Role = "Doctor")]
		public void StoreOhisStatus(OhisStatus ohisStatus)
		{
			ohisStatus.Username = Thread.CurrentPrincipal.Identity.Name;
			Validator.ValidateObject(ohisStatus, new ValidationContext(ohisStatus));
			CalcHelper.CalcOhis(ohisStatus);
			if (_unityOfWork.OhisStatus.CheckExist(ohisStatus))
			{
				_unityOfWork.OhisStatus.Update(ohisStatus);
			}
			else
			{
				_unityOfWork.OhisStatus.Create(ohisStatus);
			}
		}
	}
}