using PatientCard.Core.Models;
using PatientCard.Core.Repositories;

namespace PatientCard.Repositories.NHibernate
{
	public class NHUnityOfWork :IUnityOfWork
	{
		public NHUnityOfWork()
		{
			Job = new NHibernateRepository<Job, string>();
			SurveyType= new NHibernateRepository<SurveyType, int>();
			FirstSurveyOption = new NHibernateRepository<FirstSurveyOption, int>();
			TreatmentOption = new NHibernateRepository<TreatmentOption, int>();
			User = new NHibernateRepository<User, string>();
			Patient = new NHibernateRepository<Patient, int>();
			FirstSurvey = new NHFirstSurveyRepository();
			FirstSurveyDetail = new NHFirstSurveyDetailRepository();
			Survey = new NHSurveyRepository();
			TreatmentPlan = new NHTreatmentPlanRepository();
			Visit = new NHVisitRepository();
			DentistStatus = new NHDentistStatusRepository();
			CpiStatus = new NHCpiStatusRepository();
			DfmStatus = new NHDfmStatusRepository();
			OhisStatus = new NHOhisStatusRepository();
		}

		public IRepository<Job, string> Job { get; private set; }
		public IRepository<SurveyType, int> SurveyType { get; private set; }
		public IRepository<FirstSurveyOption, int> FirstSurveyOption { get; private set; }
		public IRepository<TreatmentOption, int> TreatmentOption { get; private set; }
		public IRepository<User, string> User { get; private set; }
		public IRepository<Patient, int> Patient { get; private set; }
		public IFirstSurveyRepository FirstSurvey { get; private set; }
		public IFirstSurveyDetailRepository FirstSurveyDetail { get; private set; }
		public ISurveyRepository Survey { get; private set; }
		public ITreatmentPlanRepository TreatmentPlan { get; private set; }
		public IVisitRepository Visit { get; private set; }
		public IDentistStatusRepository DentistStatus { get; private set; }
		public ICpiStatusRepository CpiStatus { get; private set; }
		public IDfmStatusRepository DfmStatus { get; private set; }
		public IOhisStatusRepository OhisStatus { get; private set; }
	}
}