using System.Collections.Generic;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Core.Services
{
	public class SystemService :ISystemService
	{
		private readonly IRepository<Job, string> _jobRepository;
		private readonly IRepository<SurveyType, int> _surveyTypesRepository;
		private readonly IRepository<FirstSurveyOption, int> _firstSurveyOptionRepository;
		private readonly IRepository<ThreatmentOption, int> _threatmentOptionsRepository;

		public SystemService(IRepository<Job, string > jobRepository, IRepository<SurveyType, int> surveyTypesRepository, IRepository<FirstSurveyOption, int> firstSurveyOptionRepository, IRepository<ThreatmentOption, int> threatmentOptionsRepository  )
		{
			_jobRepository = jobRepository;
			_surveyTypesRepository = surveyTypesRepository;
			_firstSurveyOptionRepository = _firstSurveyOptionRepository;
			_threatmentOptionsRepository = threatmentOptionsRepository;
		}

		public IList<Job> GetJobs()
		{
			return _jobRepository.GetAll();
		}

		public IList<SurveyType> GetSurveyTypes()
		{
			return _surveyTypesRepository.GetAll();
		}

		public IList<FirstSurveyOption> GetFirstSurveyOptions()
		{
			return _firstSurveyOptionRepository.GetAll();
		}

		public IList<ThreatmentOption> GetThreatmentOptions()
		{
			return _threatmentOptionsRepository.GetAll();
		}
	}
}