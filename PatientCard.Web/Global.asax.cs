using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using PatientCard.Core;
using PatientCard.Core.Auth;

namespace PatientCard.Web
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.Register(BundleTable.Bundles);
			InjectionConfig.Register(Bootstrap.BuildFactory);
		}

		protected void Application_PostAuthenticateRequest(Object sender, EventArgs e)
		{
			var principalService = new FormsAuthPrincipalService(HttpContext.Current);
			HttpContext.Current.User = principalService.GetCurrent();
			Thread.CurrentPrincipal = principalService.GetCurrent();
		}
	}
}