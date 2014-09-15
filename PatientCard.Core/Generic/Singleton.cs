using System;

namespace PatientCard.Core.Generic
{
	public class Singleton<T> where T : class
	{
        private static readonly object Sync = new object();

	    private static T _obj;

		public static T Current
		{
			get
			{
				if (_obj == null)
				{
				    lock (Sync)
				    {
				        if (_obj == null)
				        {
				            _obj = (T) Activator.CreateInstance(typeof (T), true);
				        }
				    }
				}
			    return _obj;
			}
		}
	}
}