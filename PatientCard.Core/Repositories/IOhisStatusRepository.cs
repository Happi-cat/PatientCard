using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Repositories
{
	public interface IOhisStatusRepository : IRepository<OhisStatus, int>
	{
		IList<OhisStatus> GetPatientItems(int patientId);
		IList<OhisStatus> GetUsernameItems(string username);
	}
}