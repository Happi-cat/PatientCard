using PatientCard.Core.Injection;
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
			            .Register<IUnityOfWork>(() => new NHUnityOfWork());

			buildFactory.Singleton()
			            .Register<IAccountService>(
				            () => new AccountService(buildFactory.GetInstance<IUnityOfWork>()))
			            .Register<ISystemService>(
				            () => new SystemService(buildFactory.GetInstance<IUnityOfWork>()))
			            .Register<IPatientService>(
				            () => new PatientService(buildFactory.GetInstance<IAccountService>(),
				                                     buildFactory.GetInstance<IUnityOfWork>()));
		}
	}
}