using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;

namespace PatientCard.Repositories.NHibernate
{
	public class NHVisitRepository :NHibernateRepository<Visit,int> , IVisitRepository
	{
		public IList<Visit> GetPatientItems(int patientId)
		{
			IList<Visit> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<Visit>().Add(Restrictions.Eq("PatientId", patientId)).List<Visit>();
				transaction.Commit();
			}
			return result;
		}

		public IList<Visit> GetUsernameItems(string username)
		{
			IList<Visit> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<Visit>().Add(Restrictions.Eq("Username", username)).List<Visit>();
				transaction.Commit();
			}
			return result;
		}
	}
}