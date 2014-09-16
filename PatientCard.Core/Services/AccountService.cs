using PatientCard.Core.Models;
using PatientCard.Core.Repositories;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Core.Services
{
	public class AccountService : Service<User,string>, IAccountService
	{
		public AccountService(IRepository<User, string> repository) : base(repository)
		{
		}

		public bool Login(string username, string password)
		{
			var user = Repository.Get(new User {Username = username});
			if (user != null)
			{
				return user.Password == password;
			}
			return false;
		}

		public bool SignUp(string username, string password)
		{
			var user = Repository.Get(new User { Username = username });
			if (user == null)
			{
				user = new User{ Username = username, Password = password};
				Repository.Create(user);
				return true;
			}
			return false;
		}
	}
}