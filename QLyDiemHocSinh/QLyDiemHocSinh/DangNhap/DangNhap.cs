using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLyDiemHocSinh.KetNoi;

namespace QLyDiemHocSinh.XuLyDuLieu
{
    class DangNhap
    {
        public int loaitaikhoan { get; set; }
        public string tennguoisd { get; set; }
        KetNoi.Connect connect = new KetNoi.Connect();

        public DangNhap()
        {

        }

        public DangNhap(int loaitaikhoan, string tennguoisd, Connect connect)
        {
            this.loaitaikhoan = loaitaikhoan;
            this.tennguoisd = tennguoisd;
            this.connect = connect;
        }

        public bool kiemTraDangNhap(string tk, string mk)
        {
            string kiemtra = "prDangNhap";

            using (SqlConnection sqlConnection = connect.Connection())
            {
                using (SqlCommand command = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = kiemtra;
                    command.Parameters.AddWithValue("@tk", tk);
                    command.Parameters.AddWithValue("@mk", mk);
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        loaitaikhoan = int.Parse(dr["iMaTK"].ToString());
                        tennguoisd = dr["sTenNguoiDung"].ToString();
                    }
                    if (dr.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    sqlConnection.Close();
                }
            }
        }

    }

}
