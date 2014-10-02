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
			return _unityOfWork.Job.GetAll();
		}

		public IList<SurveyType> GetSurveyTypes()
		{
			return _unityOfWork.SurveyType.GetAll();
		}

		public IList<FirstSurveyOption> GetFirstSurveyOptions()
		{
			return _unityOfWork.FirstSurveyOption.GetAll();
		}

		public IList<TreatmentOption> GetTreatmentOptions()
		{
			return _unityOfWork.TreatmentOption.GetAll();
		}
	}
}