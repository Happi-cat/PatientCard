using System;
using System.Web.Http;
using PatientCard.Core;
using PatientCard.Core.Models;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Web.Controllers.Api
{
    public class PatientController : ApiController
    {
	    private readonly IPatientService _patientService;

		public PatientController()
		{
			_patientService = Bootstrap.BuildFactory.GetInstance<IPatientService>();
		}
    }
}
