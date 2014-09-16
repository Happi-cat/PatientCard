using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Repositories
{
	public interface ISurveyRepository : IRepository<Survey, int>
	{
		IList<Survey> GetPatientItems(int patientId);
		IList<Survey> GetUsernameItems(string username);
	}
}