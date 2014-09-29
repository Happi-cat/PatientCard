using System.Security.Principal;

namespace PatientCard.Core.Auth
{
	public interface IPrincipalService
	{
		IPrincipal GetCurrent();
	}
}