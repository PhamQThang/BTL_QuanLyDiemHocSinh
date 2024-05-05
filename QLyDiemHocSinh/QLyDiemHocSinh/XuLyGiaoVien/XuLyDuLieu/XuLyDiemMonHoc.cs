using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLyDiemHocSinh.KetNoi;
using QLyDiemHocSinh.XuLyDuLieu;
namespace QLyDiemHocSinh.XuLyGiaoVien.XuLyDuLieu
{
    class XuLyDiemMonHoc
    {
        public string tenHS { get; set; }
        public string maMon { get; set; }
        public string tenMonHoc { get; set; }
        public float diemCC { get; set; }
        public float diemGK { get; set; }
        public float diemCK { get; set; }
        public XuLyDiemMonHoc()
        {

        }

        public XuLyDiemMonHoc(string tenSV, string maMon, string tenMonHoc, float diemCC, float diemGK, float diemCK)
        {
            this.tenHS = tenSV;
            this.maMon = maMon;
            this.tenMonHoc = tenMonHoc;
            this.diemCC = diemCC;
            this.diemGK = diemGK;
            this.diemCK = diemCK;
        }

        DataTable data = new DataTable();
        Connect connect = new Connect();
        ThongTinTaiKhoan tttk = new ThongTinTaiKhoan();
        public DataTable LoadDiem()
        {
            tttk.LoadThongTin(Properties.Settings.Default.tenNguoiSD);
            string pr = "prInfor_Diem";
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = pr;
                    cmd.Parameters.AddWithValue("@ma", tttk.maxx);

                    data.Load(cmd.ExecuteReader());


                    cnn.Close();

                }
            }
            return data;
        }

        public int timdulieu(string ma)
        {
            int n;
            tttk.LoadThongTin(Properties.Settings.Default.tenNguoiSD);
            string procUpdate = "prSearch_DiemMonHoc";
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procUpdate;
                    cmd.Parameters.AddWithValue("@magv", tttk.maxx);
                    cmd.Parameters.AddWithValue("@mahs", ma);

                    n = cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Tendangnhap = reader["Tentaikhoan"].ToString();
                        tenHS = reader["sTenHS"].ToString();

                        maMon = reader["sMaMonHoc"].ToString();
                        tenMonHoc = reader["sTenMonHoc"].ToString();
                        diemCC = float.Parse(reader["fDiemCC"].ToString());
                        diemGK = float.Parse(reader["fDiemGK"].ToString());
                        diemCK = float.Parse(reader["fDiemThi"].ToString());
                      }
                    reader.Close();
                    cnn.Close();
                }
                if (n > 0)
                {
                    return 1;
                }
                else return 0;
            }


        }

        public int Insert_Update(string madiem, string mamonhoc, float diemcc, float diemgk, float diemthhi) {
            int n;
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "prUpdate_Diem";
                    cmd.Parameters.AddWithValue("@ma", madiem);
                    cmd.Parameters.AddWithValue("@mamon", mamonhoc);
                    cmd.Parameters.AddWithValue("@diemcc", diemcc);
                    cmd.Parameters.AddWithValue("@diemgk", diemgk);
                    cmd.Parameters.AddWithValue("@diemthi", diemthhi);

                    n = cmd.ExecuteNonQuery();

                    cnn.Close();
                }
                if (n > 0)
                {
                    return 1;
                }
                else return 0;
            }
        }

        public DataTable timdiemsv(string ma, string ten)
        {
            tttk.LoadThongTin(Properties.Settings.Default.tenNguoiSD);
            string procUpdate = "prSearch_DiemAccGiaoVien";
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procUpdate;
                    cmd.Parameters.AddWithValue("@magv", tttk.maxx);
                    cmd.Parameters.AddWithValue("@mahs", ma);
                    cmd.Parameters.AddWithValue("@tenhs", ten);
                    data.Load(cmd.ExecuteReader());
                    cnn.Close();
                }

            }
            return data;
        }
    }
}
