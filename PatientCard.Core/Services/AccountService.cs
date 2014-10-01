using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Core.Services
{
	public class AccountService : Service<User,string>, IAccountService
	{
		public AccountService(IUnityOfWork unityOfWork)
		{
			Repository = unityOfWork.UserRepository;
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public new User Get(User key)
		{
			return base.Get(key);
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public new IList<User> GetAll()
		{
			return base.GetAll();
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public new void Store(User item)
		{
			var permUser = new PrincipalPermission(item.Username, null);
			var permAdmin = new PrincipalPermission(null, "Administrator");
			
			(permUser.Union(permAdmin)).Demand();

			Validator.ValidateObject(item, new ValidationContext(item));

			base.Store(item);
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
		public new void Delete(User item)
		{
			base.Delete(item);
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = false)]
		public bool Login(string username, string password)
		{
			var user = Repository.Get(new User {Username = username});
			if (user != null)
			{
				return user.Password == password;
			}
			return false;
		}

		[PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
		public bool SignUp(string username, string password)
		{
			return false;
		}

		[PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
		public bool Logout(string username)
		{
			return true;
		}
	}
}