using PatientCard.Core.Models;

namespace PatientCard.Core.Services.Interfaces
{
	public interface IAccountService : IService<User, string>
	{
		bool Login(string username, string password);

		bool SignUp(string username, string password);
	}
}