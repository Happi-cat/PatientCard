using PatientCard.Core.Generic;
using PatientCard.Core.Injection;

namespace PatientCard.Core
{
	public class Bootstrap
	{
		public static BuildFactory BuildFactory
		{
			get { return Singleton<BuildFactory>.Current; }
		}
	}
}