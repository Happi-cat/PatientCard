using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;

namespace PatientCard.Repositories.NHibernate
{
	public class NHTreatmentPlanRepository : NHibernateRepository<TreatmentPlan, Tuple<int, int>>, ITreatmentPlanRepository
	{
		public IList<TreatmentPlan> GetPatientItems(int patientId)
		{
			IList<TreatmentPlan> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<TreatmentPlan>().Add(Restrictions.Eq("PatientId", patientId)).List<TreatmentPlan>();
				transaction.Commit();
			}
			return result;
		}

		public IList<TreatmentPlan> GetUsernameItems(string username)
		{
			IList<TreatmentPlan> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<TreatmentPlan>().Add(Restrictions.Eq("Username", username)).List<TreatmentPlan>();
				transaction.Commit();
			}
			return result;
		}


		public new TreatmentPlan Get(TreatmentPlan key)
		{
			using (ISession session = NHibernateHelper.OpenSession())
			{
				return session.Get<TreatmentPlan>(key);
			}
		}

		public new bool CheckExist(TreatmentPlan entity)
		{
			using (ISession session = NHibernateHelper.OpenSession())
			{
				return session.Get<TreatmentPlan>(new TreatmentPlan{ PatientId = entity.PatientId, TreatmentOptionId = entity.TreatmentOptionId}) != null;
			}
		}

		public void Update(TreatmentPlan item)
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