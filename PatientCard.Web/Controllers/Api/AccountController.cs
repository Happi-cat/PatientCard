using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PatientCard.Core;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Web.Controllers.Api
{
    public class AccountController : ApiController
    {
	    private readonly IAccountService _accountService;

		public AccountController()
		{
			_accountService = Bootstrap.BuildFactory.GetInstance<IAccountService>();
		}

		
    }
}
