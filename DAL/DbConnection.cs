using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbConnection
    {
        private static SqlConnection _connection;

        private DbConnection() { }

        public static SqlConnection Instance
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection("Data Source=ARJAV-TAB;Initial Catalog=TourismDMS;Integrated Security=True;Encrypt=False");
                }
                return _connection;
            }
        }
    }
}
