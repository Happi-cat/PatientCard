using System;
using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Repositories
{
	public interface IThreatmentPlanRepository : IRepository<ThreatmentPlan,Tuple<int, int>>
	{
		IList<ThreatmentPlan> GetPatientItems(int patientId);
		IList<ThreatmentPlan> GetUsernameItems(string username);
	}
}