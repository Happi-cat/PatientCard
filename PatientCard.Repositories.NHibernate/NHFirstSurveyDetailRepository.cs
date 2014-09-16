using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;

namespace PatientCard.Repositories.NHibernate
{
	public class NHFirstSurveyDetailRepository : NHibernateRepository<FirstSurveyDetail, Tuple<int, int>>, IFirstSurveyDetailRepository
	{
		public IList<FirstSurveyDetail> GetPatientItems(int patientId)
		{
			IList<FirstSurveyDetail> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<FirstSurveyDetail>().Add(Restrictions.Eq("PatientId", patientId)).List<FirstSurveyDetail>();
				transaction.Commit();
			}
			return result;
		}
	}
}