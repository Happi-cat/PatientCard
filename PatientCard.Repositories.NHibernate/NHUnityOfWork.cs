using PatientCard.Core.Models;
using PatientCard.Core.Repositories;

namespace PatientCard.Repositories.NHibernate
{
	public class NHUnityOfWork :IUnityOfWork
	{
		public NHUnityOfWork()
		{
			JobRepository = new NHibernateRepository<Job, string>();
			SurveyTypeRepository= new NHibernateRepository<SurveyType, int>();
			FirstSurveyOptionRepository = new NHibernateRepository<FirstSurveyOption, int>();
			ThreatmentOptionRepository = new NHibernateRepository<ThreatmentOption, int>();
			UserRepository = new NHibernateRepository<User, string>();
			PatientRepositopry = new NHibernateRepository<Patient, int>();
			FirstSurveyRepository = new NHFirstSurveyRepository();
			FirstSurveyDetailRepository = new NHFirstSurveyDetailRepository();
			SurveyRepository = new NHSurveyRepository();
			ThreatmentPlanRepository = new NHThreatmentPlanRepository();
			VisitDiaryRepository = new NHVisitDiaryRepository();
		}

		public IRepository<Job, string> JobRepository { get; private set; }
		public IRepository<SurveyType, int> SurveyTypeRepository { get; private set; }
		public IRepository<FirstSurveyOption, int> FirstSurveyOptionRepository { get; private set; }
		public IRepository<ThreatmentOption, int> ThreatmentOptionRepository { get; private set; }
		public IRepository<User, string> UserRepository { get; private set; }
		public IRepository<Patient, int> PatientRepositopry { get; private set; }
		public IFirstSurveyRepository FirstSurveyRepository { get; private set; }
		public IFirstSurveyDetailRepository FirstSurveyDetailRepository { get; private set; }
		public ISurveyRepository SurveyRepository { get; private set; }
		public IThreatmentPlanRepository ThreatmentPlanRepository { get; private set; }
		public IVisitDiaryRepository VisitDiaryRepository { get; private set; }
	}
}