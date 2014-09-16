using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Services.Interfaces
{
	public interface IPatientService : IService<Patient, int>
	{
		FirstSurvey GetFirstSurvey(int patientId);
		void StoreFirstSurvey(FirstSurvey survey);
		
		IList<FirstSurveyDetail> GetFirstSurveyDetails(int patientId);
		void StoreFirstSurveyDetails(IList<FirstSurveyDetail> surveyDetails);

		IList<Survey> GetSurveys(int patientId);
		void StoreSurvey(Survey survey);

		IList<ThreatmentPlan> GetThreatmentPlan(int patientId);
		void StoreThreatmentPlan(IList<ThreatmentPlan> plan);

		IList<VisitDiary> GetVisitDiary(int patientId);
		void StoreVisitDiary(VisitDiary visitDiary);
	}
}