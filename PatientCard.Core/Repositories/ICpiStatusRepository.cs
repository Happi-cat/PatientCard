using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Repositories
{
	public interface ICpiStatusRepository : IRepository<CpiStatus, int>
	{
		IList<CpiStatus> GetPatientItems(int patientId);
		IList<CpiStatus> GetUsernameItems(string username);
	}
}