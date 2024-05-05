using QLyDiemHocSinh.KetNoi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyDiemHocSinh.ChucNangTimKiem.XLDuLIeu
{
    class XLDiemTheoKhoi
    {
        Connect connect = new Connect();
        DataTable tbl = new DataTable();
        public DataTable loadlieu()
        {
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = new SqlCommand("select * from vw_diemkhoifull", cnn))
                {
                    cnn.Open();
                    tbl.Clear();
                    tbl.Load(cmd.ExecuteReader());
                    cnn.Close();
                }
            }
            return tbl;
        }
        public DataTable Timkiem
            (string ten, string khoi, string danhhieu, int maxdiem, int mindiem)
        {
            string proc = "search_diemkhoi";
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@Ten", ten);
                    cmd.Parameters.AddWithValue("@ikhoihoc", khoi);
                    cmd.Parameters.AddWithValue("@danhhieu", danhhieu);
                    cmd.Parameters.AddWithValue("@diemtbmax", maxdiem);
                    cmd.Parameters.AddWithValue("@diemtbmin", mindiem);
                    tbl.Clear();
                    tbl.Load(cmd.ExecuteReader());
                    cnn.Close();
                }
            }

            return tbl;
        }
    }
}
