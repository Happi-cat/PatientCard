using System;
using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Repositories
{
	public interface ITreatmentPlanRepository : IRepository<TreatmentPlan,Tuple<int, int>>
	{
		IList<TreatmentPlan> GetPatientItems(int patientId);
		IList<TreatmentPlan> GetUsernameItems(string username);
	}
}