using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;

namespace PatientCard.Repositories.NHibernate
{
	public class NHDentistStatusRepository : NHibernateRepository<DentistStatus, int>, IDentistStatusRepository
	{
		public IList<DentistStatus> GetPatientItems(int patientId)
		{
			IList<DentistStatus> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<DentistStatus>().Add(Restrictions.Eq("PatientId", patientId)).List<DentistStatus>();
				transaction.Commit();
			}
			return result;
		}

		public IList<DentistStatus> GetUsernameItems(string username)
		{
			IList<DentistStatus> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<DentistStatus>().Add(Restrictions.Eq("Username", username)).List<DentistStatus>();
				transaction.Commit();
			}
			return result;
		}
	}
}