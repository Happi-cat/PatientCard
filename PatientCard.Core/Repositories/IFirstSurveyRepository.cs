using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Repositories
{
	public interface IFirstSurveyRepository :IRepository<FirstSurvey, int>
	{
		IList<FirstSurvey> GetPatientItems(int patientId);
	}
}