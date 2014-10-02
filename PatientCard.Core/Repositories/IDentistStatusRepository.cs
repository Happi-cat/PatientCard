using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Repositories
{
	public interface IDentistStatusRepository : IRepository<DentistStatus, int>
	{
		IList<DentistStatus> GetPatientItems(int patientId);
		IList<DentistStatus> GetUsernameItems(string username);
	}
}