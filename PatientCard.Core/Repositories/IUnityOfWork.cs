using PatientCard.Core.Models;

namespace PatientCard.Core.Repositories
{
	public interface IUnityOfWork
	{
		IRepository<Job, string> Job { get; }
		IRepository<SurveyType, int> SurveyType { get; }
		IRepository<FirstSurveyOption, int> FirstSurveyOption { get; }
		IRepository<TreatmentOption, int> TreatmentOption { get; }
		IRepository<User, string> User { get; }
		IRepository<Patient, int> Patient { get;  }
		IFirstSurveyRepository FirstSurvey { get; }
		IFirstSurveyDetailRepository FirstSurveyDetail { get; }
		ISurveyRepository Survey { get; }
		ITreatmentPlanRepository TreatmentPlan { get; }
		IVisitRepository Visit { get; }
		IDentistStatusRepository DentistStatus { get; }
		ICpiStatusRepository CpiStatus { get; }
		IDfmStatusRepository DfmStatus { get; }
		IOhisStatusRepository OhisStatus { get; }
	}
}