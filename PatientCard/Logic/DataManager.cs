using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using PatientCard.Data;
using PatientCard.Data.ClinicDataSetTableAdapters;

namespace PatientCard.Logic
{
    public class DataManager
    {
	    private static object _sync = new object();
	    private static ClinicDataSet _dataSet;

	    public static ClinicDataSet ClinicDataSet
	    {
		    get
		    {
			    if (_dataSet == null)
			    {
				    lock (_sync)
				    {
					    if (_dataSet == null)
					    {
						    _dataSet = new ClinicDataSet();
							Init(_dataSet);
					    }
				    }
			    }
			    return _dataSet;
		    }
	    }

		private static void Init(ClinicDataSet dataSet)
		{
			var usersAdapter = new UsersTableAdapter();
			usersAdapter.Fill(dataSet.Users);
		}
    }
}