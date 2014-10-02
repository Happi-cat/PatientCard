using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;

namespace PatientCard.Repositories.NHibernate
{
	public class NHDfmStatusRepository : NHibernateRepository<DfmStatus, int>, IDfmStatusRepository
	{
		public IList<DfmStatus> GetPatientItems(int patientId)
		{
			IList<DfmStatus> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<DfmStatus>().Add(Restrictions.Eq("PatientId", patientId)).List<DfmStatus>();
				transaction.Commit();
			}
			return result;
		}

		public IList<DfmStatus> GetUsernameItems(string username)
		{
			IList<DfmStatus> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<DfmStatus>().Add(Restrictions.Eq("Username", username)).List<DfmStatus>();
				transaction.Commit();
			}
			return result;
		}
	}
}