using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;

namespace PatientCard.Repositories.NHibernate
{
	public class NHFirstSurveyRepository : NHibernateRepository<FirstSurvey, int>, IFirstSurveyRepository
	{
		public IList<FirstSurvey> GetPatientItems(int patientId)
		{
			IList<FirstSurvey> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<FirstSurvey>().Add(Restrictions.Eq("PatientId", patientId)).List<FirstSurvey>();
				transaction.Commit();
			}
			return result;
		}
	}
}