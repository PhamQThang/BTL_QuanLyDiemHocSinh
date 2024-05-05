using QLyDiemHocSinh.KetNoi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLyDiemHocSinh.XuLyAdmin.XuLyDuLieu
{
    class Admin_GiaoVien
    {
        public string maGV { get; set; }
        public string tenGV { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string cccd { get; set; }
        public Admin_GiaoVien()
        {

        }

        public Admin_GiaoVien(string maGV, string tenGV, string gioiTinh, DateTime ngaySinh, string cccd)
        {
            this.maGV = maGV;
            this.tenGV = tenGV;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.cccd = cccd;
        }

        Connect connect = new Connect();
        DataTable data = new DataTable();

        public DataTable infor_GiaoVien()
        {
            string pr_InforGiaoVien = "prInfor_GiaoVien";
            using (SqlConnection cnn = connect.Connection())
            {
                using(SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = pr_InforGiaoVien;

                    data.Load(cmd.ExecuteReader());

                    cnn.Close();
                }
            }
            return data;
        }

        public void insertORupdate_GiaoVien(string ma, string ten,
            DateTime ngaysinh, string gioitinh, string cccd, string proc)
        {
            int n;

            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@magv", ma);
                    cmd.Parameters.AddWithValue("@tengv", ten);
                    cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                    cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                    cmd.Parameters.AddWithValue("@cccd", cccd);
                    n = cmd.ExecuteNonQuery();

                    cnn.Close();
                }

            }
        }

        public DataTable search_GiaoVien(string magv, string ten, string gt, string ngay, string thang, string nam, string cccd)
        {
            int n;
            string proc = "prSearch_GiaoVien";
            using(SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@magv", magv);
                    cmd.Parameters.AddWithValue("@tengv", ten);
                    cmd.Parameters.AddWithValue("@gioitinh", gt);
                    cmd.Parameters.AddWithValue("@ngay", ngay);
                    cmd.Parameters.AddWithValue("@thang", thang);
                    cmd.Parameters.AddWithValue("@nam", nam);
                    cmd.Parameters.AddWithValue("@cccd", cccd);
                    data.Load(cmd.ExecuteReader());
                }
            }
            return data;
            
        }


        public int delete_GiaoVien(string magv)
        {
            int n;
            string procdelete = "prDelete_GiaoVien";
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procdelete;
                    cmd.Parameters.AddWithValue("@magv", magv);

                    n = cmd.ExecuteNonQuery();

                    cnn.Close();
                }

            }
            if (n > 0)
            {
                return 1;
            }
            else return 0;
        }

        public void timdulieu(string ma)
        {
            int n;
            string pr = "prAdapter_Giaovien";
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
                        maGV = ma;
                        // Tendangnhap = reader["Tentaikhoan"].ToString();
                        tenGV = reader["sTenGiaoVien"].ToString();

                        ngaySinh = DateTime.Parse(reader["dNgaysinh"].ToString());
                        gioiTinh = reader["sGioitinh"].ToString();

                    }
                    reader.Close();
                    cnn.Close();
                }

            }
        }
    }
}
