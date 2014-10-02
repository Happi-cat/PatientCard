using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;

namespace PatientCard.Repositories.NHibernate
{
	public class NHCpiStatusRepository : NHibernateRepository<CpiStatus, int>, ICpiStatusRepository
	{
		public IList<CpiStatus> GetPatientItems(int patientId)
		{
			IList<CpiStatus> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<CpiStatus>().Add(Restrictions.Eq("PatientId", patientId)).List<CpiStatus>();
				transaction.Commit();
			}
			return result;
		}

		public IList<CpiStatus> GetUsernameItems(string username)
		{
			IList<CpiStatus> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<CpiStatus>().Add(Restrictions.Eq("Username", username)).List<CpiStatus>();
				transaction.Commit();
			}
			return result;
		}
	}
}