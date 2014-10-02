using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Repositories
{
	public interface IVisitRepository : IRepository<Visit, int>
	{
		IList<Visit> GetPatientItems(int patientId);
		IList<Visit> GetUsernameItems(string username);
	}
}