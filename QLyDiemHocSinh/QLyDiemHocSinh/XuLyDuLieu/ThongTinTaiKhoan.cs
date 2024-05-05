using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLyDiemHocSinh.KetNoi;
using System.Data.SqlClient;

namespace QLyDiemHocSinh.XuLyDuLieu
{
    class ThongTinTaiKhoan
    {
        public string taiKhoan { get; set; }
        public string matKhau { get; set; }
        public int loaiTaiKhoan { get; set; }
        public DateTime ngaySinh { get; set; }
        public string maxx { get; set; }
        public ThongTinTaiKhoan()
        {

        }

        public ThongTinTaiKhoan(string taiKhoan, string matKhau, int loaiTaiKhoan, DateTime ngaySinh, string maxx)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.loaiTaiKhoan = loaiTaiKhoan;
            this.ngaySinh = ngaySinh;
            this.maxx = maxx;
        }

        Connect connect = new Connect();

        public void LoadThongTin(string tenNguoiDung)
        {
            string pr = "prThongTinTaiKhoan";
            using (SqlConnection cnn = connect.Connection())
            {
                using(SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = pr;
                    cmd.Parameters.AddWithValue("@ten", tenNguoiDung);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        loaiTaiKhoan = int.Parse(reader["iLoaiTK"].ToString());
                       taiKhoan = reader["sTenTK"].ToString();
                        matKhau = reader["sMatKhau"].ToString();
                        Console.WriteLine(taiKhoan);
                        ngaySinh = DateTime.Parse(reader["dNgaysinh"].ToString());
                        maxx = reader["Maxx"].ToString();
                    }
                    reader.Close();
                    cnn.Close();
                }
            }
        }
    }
}
