using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLyDiemHocSinh.KetNoi;
using System.Data.SqlClient;
using System.Data;

namespace QLyDiemHocSinh.XuLyAdmin.XuLyDuLieu
{
    class Admin_LopHoc
    {
        public string maLop { get; set; }
        public string tenLopHoc { get; set; }
        public string khoiHoc { get; set; }

        public Admin_LopHoc()
        {

        }

        public Admin_LopHoc(string maLop, string tenLopHoc, string khoiHoc)
        {
            this.maLop = maLop;
            this.tenLopHoc = tenLopHoc;
            this.khoiHoc = khoiHoc;
        }

        Connect connect = new Connect();
        DataTable data = new DataTable();

        public DataTable infor_LopHoc(string khoihoc)
        {
            string pr = "prInfor_LopHoc";
            using(SqlConnection cnn = connect.Connection())
            {
                using(SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = pr;
                    cmd.Parameters.AddWithValue("@khoihoc", khoihoc);

                    data.Load(cmd.ExecuteReader());

                    cnn.Close();
                }
            }
            return data;
        }
        public DataTable infor_AllLopHoc()
        {
            string pr = "prInfor_AllLopHoc";
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = pr;

                    data.Load(cmd.ExecuteReader());

                    cnn.Close();
                }
            }
            return data;
        }
        public void insertORupdate_LopHoc(string malop, string tenlop, string khoihoc, string pr)
        {
            int n;
            using(SqlConnection cnn = connect.Connection())
            {
                using(SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = pr;
                    cmd.Parameters.AddWithValue("@malop", malop);
                    cmd.Parameters.AddWithValue("@tenlop", tenlop);
                    cmd.Parameters.AddWithValue("@khoihoc", khoihoc);
                    n = cmd.ExecuteNonQuery();

                    cnn.Close();
                }
            }
        }
        
        public void delete_LopHoc(string malop)
        {
            string pr = "prDelete_LopHoc";
            int n;
            using(SqlConnection cnn = connect.Connection())
            {
                using(SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = pr;
                    cmd.Parameters.AddWithValue("@malop", malop);
                    n = cmd.ExecuteNonQuery();
                    cnn.Close();

                }
            }
        }
        
        public DataTable search_LopHoc(string malop, string tenlop, string khoihoc)
        {
            string pr = "prSearch_LopHoc";
            int n;
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = pr;
                    cmd.Parameters.AddWithValue("@malop", malop);
                    cmd.Parameters.AddWithValue("@tenlop", tenlop);
                    cmd.Parameters.AddWithValue("@khoihoc", khoihoc);
                    data.Clear();
                    data.Load(cmd.ExecuteReader());
                    cnn.Close();

                }
            }
            return data;
        }

        public void timdulieu(string ma)
        {
            int n;
            string pr = "prAdapter_LopHoc";
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = pr;
                    cmd.Parameters.AddWithValue("@ma", ma);

                    n = cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        maLop = ma;
                        tenLopHoc = reader["sTenLopHoc"].ToString();
                        khoiHoc = reader["iKhoiHoc"].ToString();
                    }
                    reader.Close();
                    cnn.Close();
                }
            }
        }
    }
}
