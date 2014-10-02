using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Services.Interfaces
{
	public interface IPatientService : IService<Patient, int>
	{
		FirstSurvey GetFirstSurvey(int patientId);
		void StoreFirstSurvey(FirstSurvey survey);
		
		IList<Survey> GetSurveys(int patientId);
		void StoreSurvey(Survey survey);

		IList<TreatmentPlan> GetTreatmentPlan(int patientId);
		void StoreTreatmentPlan(IList<TreatmentPlan> plan);

		IList<Visit> GetVisits(int patientId);
		void StoreVisit(Visit visit);

		IList<DentistStatus> GetDentistStatuses(int patientId);
		void StoreDentistStatus(DentistStatus dentistStatus);

		IList<CpiStatus> GetCpiStatuses(int patientId);
		void StoreCpiStatus(CpiStatus cpiStatus);

		IList<DfmStatus> GetDfmStatuses(int patientId);
		void StoreDfmStatus(DfmStatus dfmStatus);

		IList<OhisStatus> GetOhisStatuses(int patientId);
		void StoreOhisStatus(OhisStatus ohisStatus);
	}
}