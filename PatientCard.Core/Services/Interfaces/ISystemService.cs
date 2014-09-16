using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Services.Interfaces
{
	public interface ISystemService
	{
		IList<Job> GetJobs();

		IList<SurveyType> GetSurveyTypes();

		IList<ThreatmentOption> GetThreatmentOptions();
	}
}