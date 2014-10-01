using System.Collections.Generic;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Core.Services
{
	public class SystemService :ISystemService
	{
		private readonly IUnityOfWork _unityOfWork;

		public SystemService(IUnityOfWork unityOfWork)
		{
			_unityOfWork = unityOfWork;
		}

		public IList<Job> GetJobs()
		{
			return _unityOfWork.JobRepository.GetAll();
		}

		public IList<SurveyType> GetSurveyTypes()
		{
			return _unityOfWork.SurveyTypeRepository.GetAll();
		}

		public IList<FirstSurveyOption> GetFirstSurveyOptions()
		{
			return _unityOfWork.FirstSurveyOptionRepository.GetAll();
		}

		public IList<ThreatmentOption> GetThreatmentOptions()
		{
			return _unityOfWork.ThreatmentOptionRepository.GetAll();
		}
	}
}