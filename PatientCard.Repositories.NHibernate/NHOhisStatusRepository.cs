using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;

namespace PatientCard.Repositories.NHibernate
{
	public class NHOhisStatusRepository : NHibernateRepository<OhisStatus, int>, IOhisStatusRepository
	{
		public IList<OhisStatus> GetPatientItems(int patientId)
		{
			IList<OhisStatus> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<OhisStatus>().Add(Restrictions.Eq("PatientId", patientId)).List<OhisStatus>();
				transaction.Commit();
			}
			return result;
		}

		public IList<OhisStatus> GetUsernameItems(string username)
		{
			IList<OhisStatus> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<OhisStatus>().Add(Restrictions.Eq("Username", username)).List<OhisStatus>();
				transaction.Commit();
			}
			return result;
		}
	}
}