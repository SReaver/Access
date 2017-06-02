using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access
{
    public class Context
    {
        public Context(string dbConnString)
        {
            ConnectionDb = new OleDbConnection(dbConnString);
        }

        public OleDbConnection ConnectionDb { get; }


        public List<Employer> GetEmployes()
        {
            var cmd = new OleDbCommand();
            cmd.Connection = ConnectionDb;
            cmd.CommandText = "select * from Employes";
            
            var emplist = new List<Employer>();

            var reader = cmd.ExecuteReader();
            while (reader != null && reader.Read())
            {
                Employer em1 = new Employer(Int32.Parse(reader.GetInt32(0).ToString()), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetDecimal(4));
                emplist.Add(em1);
            }
            return emplist;
        }

    }

}
