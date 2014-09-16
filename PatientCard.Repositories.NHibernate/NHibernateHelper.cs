using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace PatientCard.Repositories.NHibernate
{
	internal class NHibernateHelper
	{
		private static ISessionFactory _sessionFactory;

		private static ISessionFactory SessionFactory
		{
			get
			{
				if (_sessionFactory == null)
				{
					var configuration = Fluently.Configure()
					                            .Database(
						                            MsSqlConfiguration.MsSql2008.ConnectionString(
							                            c => c.FromConnectionStringWithKey("PatientCard.Repositories.NHibernate.Database")))
					                            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernateHelper>())
					                            .BuildConfiguration();
					_sessionFactory = configuration.BuildSessionFactory();
				}
				return _sessionFactory;
			}
		}

		public static ISession OpenSession()
		{
			return SessionFactory.OpenSession();
		}
	}
}