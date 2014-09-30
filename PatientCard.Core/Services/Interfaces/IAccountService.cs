using PatientCard.Core.Models;

namespace PatientCard.Core.Services.Interfaces
{
	public interface IAccountService : IAuthService, IService<User, string>
	{
		
	}
}