using System;
using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Repositories
{
	public interface IFirstSurveyDetailRepository :IRepository<FirstSurveyDetail, Tuple<int, int>>
	{
		IList<FirstSurveyDetail> GetPatientItems(int patientId);
	}
}