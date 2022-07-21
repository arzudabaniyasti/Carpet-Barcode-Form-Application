using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SIRMA_CARPET
{
    class sql_connection
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=ARZU\\SQLEXPRESS;Initial Catalog=SIRMA_CARPET;Integrated Security=True");
            connect.Open();
            return connect;
            }
    }
}
