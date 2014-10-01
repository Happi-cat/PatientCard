using PatientCard.Core.Models;

namespace PatientCard.Core.Repositories
{
	public interface IUnityOfWork
	{
		IRepository<Job, string> JobRepository { get; }
		IRepository<SurveyType, int> SurveyTypeRepository { get; }
		IRepository<FirstSurveyOption, int> FirstSurveyOptionRepository { get; }
		IRepository<ThreatmentOption, int> ThreatmentOptionRepository { get; }
		IRepository<User, string> UserRepository { get; }
		IRepository<Patient, int> PatientRepositopry { get;  }
		IFirstSurveyRepository FirstSurveyRepository { get; }
		IFirstSurveyDetailRepository FirstSurveyDetailRepository { get; }
		ISurveyRepository SurveyRepository { get; }
		IThreatmentPlanRepository ThreatmentPlanRepository { get; }
		IVisitDiaryRepository VisitDiaryRepository { get; }
	}
}