using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.OleDb;

namespace Access
{
    class Program
    {
        static readonly string AppPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        static readonly string DbPath = Path.Combine(AppPath, "Documents", "Database2.accdb");
        static readonly string DbConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\плотниковс\Documents\Database2.accdb';Persist Security Info=False;";


        static void Main(string[] args)
        {
            Context context = new Context(DbConnString);
            var result = context.GetEmployes();


        }
    }
}
