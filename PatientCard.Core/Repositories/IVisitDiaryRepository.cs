using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Repositories
{
	public interface IVisitDiaryRepository : IRepository<VisitDiary, int>
	{
		IList<VisitDiary> GetPatientItems(int patientId);
		IList<VisitDiary> GetUsernameItems(string username);
	}
}