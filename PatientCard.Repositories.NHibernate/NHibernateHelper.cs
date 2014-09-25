using System.Diagnostics;
using System.Linq;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.SqlCommand;

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
					                            .ExposeConfiguration(x => x.SetInterceptor(new SqlStatementInterceptor()))
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

	internal class SqlStatementInterceptor : EmptyInterceptor
	{
		public override SqlString OnPrepareStatement(SqlString sql)
		{
			Trace.WriteLine(sql.ToString());
			return sql;
		}
	}
}