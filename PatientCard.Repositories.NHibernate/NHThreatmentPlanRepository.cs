using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;

namespace PatientCard.Repositories.NHibernate
{
	public class NHThreatmentPlanRepository : NHibernateRepository<ThreatmentPlan, Tuple<int, int>>, IThreatmentPlanRepository
	{
		public IList<ThreatmentPlan> GetPatientItems(int patientId)
		{
			IList<ThreatmentPlan> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<ThreatmentPlan>().Add(Restrictions.Eq("PatientId", patientId)).List<ThreatmentPlan>();
				transaction.Commit();
			}
			return result;
		}

		public IList<ThreatmentPlan> GetUsernameItems(string username)
		{
			IList<ThreatmentPlan> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<ThreatmentPlan>().Add(Restrictions.Eq("Username", username)).List<ThreatmentPlan>();
				transaction.Commit();
			}
			return result;
		}


		public new ThreatmentPlan Get(ThreatmentPlan key)
		{
			using (ISession session = NHibernateHelper.OpenSession())
			{
				return session.Get<ThreatmentPlan>(key);
			}
		}

		public new bool CheckExist(ThreatmentPlan entity)
		{
			using (ISession session = NHibernateHelper.OpenSession())
			{
				return session.Get<ThreatmentPlan>(entity) != null;
			}
		}
	}
}