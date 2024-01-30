using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyMovieApp
{
    public class MySqlConnection
    {
        public SqlConnection connection()
        {
            SqlConnection conn = new SqlConnection(@"Data Source = .;Initial Catalog = MOVIE; Integrated Security = True");
            conn.Open();
            return conn;
        }
    }
}
