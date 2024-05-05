using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyDiemHocSinh.KetNoi
{
    class Connect
    {
        string connect = "Data Source=.;Initial Catalog=QLyDiem;Integrated Security=True";
        public Connect()
        {

        }
        public Connect(string connect)
        {
            this.connect = connect;
        }

        public SqlConnection Connection()
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            return sqlConnection;
        }
    }
}
