using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace PatientCard.Logic
{
    public class DataManager
    {
        public SqlDataAdapter DataAdapter { get; set; }

        public void CreateEntry(DataRow row)
        {
            DataAdapter.Update(new [] {row});
        }

        public void UpdateEntry(DataRow row)
        {
            DataAdapter.Update(new[] {row});
        }

        public void DeleteEntry(DataRow row)
        {
            row.Delete();
            DataAdapter.Update(new[] {row});
        }

       
    }
}