using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSI3304Project1
{
    
    class DatabaseConnection
    {
        static void CreateConnection()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ImageBaseDatabase;Persist Security Info=True;User ID=sa;Password=pw2server1;"))
            {
                con.Open();
            }
        }
    }
}
