namespace PatientCard.Core.Services.Interfaces
{
	public interface IAuthService
	{
		bool Login(string username, string password);

		bool SignUp(string username, string password);

		bool Logout(string username);
	}
}