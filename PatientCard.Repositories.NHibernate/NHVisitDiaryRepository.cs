using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;

namespace PatientCard.Repositories.NHibernate
{
	public class NHVisitDiaryRepository :NHibernateRepository<VisitDiary,int> , IVisitDiaryRepository
	{
		public IList<VisitDiary> GetPatientItems(int patientId)
		{
			IList<VisitDiary> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<VisitDiary>().Add(Restrictions.Eq("PatientId", patientId)).List<VisitDiary>();
				transaction.Commit();
			}
			return result;
		}

		public IList<VisitDiary> GetUsernameItems(string username)
		{
			IList<VisitDiary> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<VisitDiary>().Add(Restrictions.Eq("Username", username)).List<VisitDiary>();
				transaction.Commit();
			}
			return result;
		}
	}
}