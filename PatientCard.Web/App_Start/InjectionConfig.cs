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
			            .Register<IRepository<ThreatmentOption, int>>(() => new NHibernateRepository<ThreatmentOption, int>());

			buildFactory.Singleton()
			            .Register<IService<Job, string>>(
				            () => new Service<Job, string>(buildFactory.GetInstance<IRepository<Job, string>>()))
			            .Register<IService<SurveyType, int>>(
				            () => new Service<SurveyType, int>(buildFactory.GetInstance<IRepository<SurveyType, int>>()))
			            .Register<IService<ThreatmentOption, int>>(
				            () => new Service<ThreatmentOption, int>(buildFactory.GetInstance<IRepository<ThreatmentOption, int>>()));
		}
	}
}