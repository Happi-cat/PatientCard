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

		public new FirstSurveyDetail Get(FirstSurveyDetail key)
		{
			using (ISession session = NHibernateHelper.OpenSession())
			{
				return session.Get<FirstSurveyDetail>(key);
			}
		}

		public new bool CheckExist(FirstSurveyDetail entity)
		{
			using (ISession session = NHibernateHelper.OpenSession())
			{
				return session.Get<FirstSurveyDetail>(new FirstSurveyDetail{ PatientId = entity.PatientId, SurveyOptionId = entity.SurveyOptionId }) != null;
			}
		}
		public new void Update(FirstSurveyDetail item)
		{

			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				session.Update(item);
				transaction.Commit();
			}
		}
	}
}