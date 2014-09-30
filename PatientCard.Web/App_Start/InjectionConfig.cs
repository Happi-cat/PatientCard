using PatientCard.Core.Injection;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;
using PatientCard.Core.Services;
using PatientCard.Core.Services.Interfaces;
using PatientCard.Repositories.NHibernate;

namespace PatientCard.Web
{
	public class InjectionConfig
	{
		public static void Register(BuildFactory buildFactory)
		{
			buildFactory.Transient()
						.Register<IRepository<Job, string>>(() => new NHibernateRepository<Job, string>())
						.Register<IRepository<SurveyType, int>>(() => new NHibernateRepository<SurveyType, int>())
						.Register<IRepository<FirstSurveyOption, int>>(() => new NHibernateRepository<FirstSurveyOption, int>())
						.Register<IRepository<ThreatmentOption, int>>(() => new NHibernateRepository<ThreatmentOption, int>())
						.Register<IRepository<User, string>>(() => new NHibernateRepository<User, string>())
						.Register<IRepository<Patient, int>>(() => new NHibernateRepository<Patient, int>())
						.Register<IFirstSurveyRepository>(() => new NHFirstSurveyRepository())
						.Register<IFirstSurveyDetailRepository>(() => new NHFirstSurveyDetailRepository())
						.Register<ISurveyRepository>(() => new NHSurveyRepository())
						.Register<IThreatmentPlanRepository>(() => new NHThreatmentPlanRepository())
						.Register<IVisitDiaryRepository>(() => new NHVisitDiaryRepository());

			buildFactory.Singleton()
						.Register<IAccountService>(
							() => new AccountService(buildFactory.GetInstance<IRepository<User, string>>()))
						.Register<ISystemService>(
							() => new SystemService(buildFactory.GetInstance<IRepository<Job, string>>(),
													buildFactory.GetInstance<IRepository<SurveyType, int>>(),
													buildFactory.GetInstance<IRepository<FirstSurveyOption, int>>(),
													buildFactory.GetInstance<IRepository<ThreatmentOption, int>>()
									  ))
						.Register<IPatientService>(
							() => new PatientService(buildFactory.GetInstance<IAccountService>(),
													 buildFactory.GetInstance<IRepository<Patient, int>>(),
													 buildFactory.GetInstance<IFirstSurveyRepository>(),
													 buildFactory.GetInstance<IFirstSurveyDetailRepository>(),
													 buildFactory.GetInstance<IThreatmentPlanRepository>(),
													 buildFactory.GetInstance<ISurveyRepository>(),
													 buildFactory.GetInstance<IVisitDiaryRepository>()
									  ));
		}
	}
}