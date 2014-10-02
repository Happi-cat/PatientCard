using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Repositories
{
	public interface IDfmStatusRepository : IRepository<DfmStatus, int>
	{
		IList<DfmStatus> GetPatientItems(int patientId);
		IList<DfmStatus> GetUsernameItems(string username);
	}
}