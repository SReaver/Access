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
        private OleDbConnection conn;
        public Context(string DbConnString)
        {
            //IDbConnection connection = new OleDbConnection(DbConnString);
            conn = new OleDbConnection(DbConnString);
        }

        public OleDbConnection ConnectionDb
        {
            get { return conn; }
        }


        public List<Employer> GetEmployes()
        {
            //OleDbCommand cmd = new OleDbCommand();
            //cmd.Connection = conn;
            //cmd.CommandText = "select * from Employes";

            //OleDbDataReader reader = cmd.ExecuteReader();

            //List<Employer> emplist = new List<Employer>();
            //while (reader.Read())
            //{
            //    Employer em1 = new Employer();
            //    em1.empid = reader.GetInt32(0);
            //    em1.empfio = reader.GetString(1);
            //    em1.address = reader.GetString(2);
            //    em1.depid = reader.GetInt32(3);
            //    em1.salary = reader.GetDecimal(4);
            //    emplist.Add(em1);
            //}



            //return emplist;
            return null;

        }

    }

}
