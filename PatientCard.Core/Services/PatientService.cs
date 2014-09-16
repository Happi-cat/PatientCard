using System.Collections.Generic;
using System.Linq;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Core.Services
{
	public class PatientService : Service<Patient, int>, IPatientService
	{
		private readonly IFirstSurveyRepository _firstSurveyRepository;
		private readonly IFirstSurveyDetailRepository _firstSurveyDetailRepository;
		private readonly IThreatmentPlanRepository _threatmentPlanRepository;
		private readonly ISurveyRepository _surveyRepository;
		private readonly IVisitDiaryRepository _visitRepository;

		public PatientService(IRepository<Patient, int> repository, IFirstSurveyRepository firstSurveyRepository, IFirstSurveyDetailRepository firstSurveyDetailRepository,
			IThreatmentPlanRepository threatmentPlanRepository, ISurveyRepository surveyRepository, IVisitDiaryRepository visitDiaryRepository) : base(repository)
		{
			_firstSurveyRepository = firstSurveyRepository;
			_firstSurveyDetailRepository = firstSurveyDetailRepository;
			_threatmentPlanRepository = threatmentPlanRepository;
			_surveyRepository = surveyRepository;
			_visitRepository = visitDiaryRepository;
		}


		public FirstSurvey GetFirstSurvey(int patientId)
		{
			return _firstSurveyRepository.GetPatientItems(patientId).FirstOrDefault();
		}

		public void StoreFirstSurvey(FirstSurvey survey)
		{
			if (_firstSurveyRepository.CheckExist(survey))
			{
				_firstSurveyRepository.Update(survey);
			}
			else
			{
				_firstSurveyRepository.Create(survey);
			}
		}

		public IList<FirstSurveyDetail> GetFirstSurveyDetails(int patientId)
		{
			return _firstSurveyDetailRepository.GetPatientItems(patientId);
		}

		public void StoreFirstSurveyDetails(IList<FirstSurveyDetail> surveyDetails)
		{
			foreach (var detail in surveyDetails)
			{
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

		public IList<Survey> GetSurveys(int patientId)
		{
			return _surveyRepository.GetPatientItems(patientId);
		}

		public void StoreSurvey(Survey survey)
		{
			if (_surveyRepository.CheckExist(survey))
			{
				_surveyRepository.Update(survey);
			}
			else
			{
				_surveyRepository.Create(survey);
			}
		}

		public IList<ThreatmentPlan> GetThreatmentPlan(int patientId)
		{
			return _threatmentPlanRepository.GetPatientItems(patientId);
		}

		public void StoreThreatmentPlan(IList<ThreatmentPlan> plan)
		{
			foreach (var p in plan)
			{
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

		public IList<VisitDiary> GetVisitDiary(int patientId)
		{
			return _visitRepository.GetPatientItems(patientId);
		}

		public void StoreVisitDiary(VisitDiary visitDiary)
		{
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