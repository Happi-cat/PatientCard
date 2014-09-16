using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;

namespace PatientCard.Repositories.NHibernate
{
	public class NHSurveyRepository : NHibernateRepository<Survey, int>, ISurveyRepository
	{
		public IList<Survey> GetPatientItems(int patientId)
		{
			IList<Survey> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<Survey>().Add(Restrictions.Eq("PatientId", patientId)).List<Survey>();
				transaction.Commit();
			}
			return result;
		}

		public IList<Survey> GetUsernameItems(string username)
		{
			IList<Survey> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<Survey>().Add(Restrictions.Eq("Username", username)).List<Survey>();
				transaction.Commit();
			}
			return result;
		}
	}
}