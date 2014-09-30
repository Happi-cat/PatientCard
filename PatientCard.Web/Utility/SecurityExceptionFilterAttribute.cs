using System.Net;
using System.Net.Http;
using System.Security;
using System.Web.Http.Filters;

namespace PatientCard.Core.Web
{
	public class SecurityExceptionFilterAttribute :ExceptionFilterAttribute
	{
		public override void OnException(HttpActionExecutedContext context)
		{
			if (context.Exception is SecurityException)
			{
				context.Response = new HttpResponseMessage(HttpStatusCode.Forbidden);
			}
		}
	}
}