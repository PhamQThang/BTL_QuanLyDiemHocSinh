using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLyDiemHocSinh.KetNoi;
using QLyDiemHocSinh.XuLyAdmin.XuLyDuLieu;
using System.Data.SqlClient;
using System.Data;

namespace QLyDiemHocSinh.XuLyAdmin.XuLyDuLieu
{
    class Admin_HocSinh
    {
        public string maHS { get; set; }
        public string tenHS { get; set; }
        public string diaChi { get; set; }
        public string maLop { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string diem { get; set; }
   
        public Admin_HocSinh()
        {

        }

        public Admin_HocSinh(string maHS, string tenHS, string diaChi, string maLop, string gioiTinh, DateTime ngaySinh)
        {
            this.maHS = maHS;
            this.tenHS = tenHS;
            this.diaChi = diaChi;
            this.maLop = maLop;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
        }

        Connect connect = new Connect();
        DataTable data = new DataTable();

        public DataTable infor_HocSinh()
        {
            string pr = "prInfor_HocSinh";
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


        public void insertORupdate_HocSinh(string mahs, string ten, DateTime ngaysinh, string gioitinh, string diachi, string malop, string proc)
        {
            int n;

            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@mahs", mahs);
                    cmd.Parameters.AddWithValue("@ten", ten);
                    cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                    cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                    cmd.Parameters.AddWithValue("@diachi", diachi);
                    cmd.Parameters.AddWithValue("@malop", malop);

                    n = cmd.ExecuteNonQuery();

                    cnn.Close();
                }

            }
        }

        public int delete_HocSinh(string ma)
        {
            int n;
            string procdelete = "prDelete_HocSinh";
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procdelete;
                    cmd.Parameters.AddWithValue("@ma", ma);

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

        public DataTable search_HocSinh(string mahs, string ten, string diachi, string malop, string gt, string ngay, string thang, string nam)
        {
            int n;
            string proc = "prSearch_HocSinh";
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@mahs", mahs);
                    cmd.Parameters.AddWithValue("@tenhs", ten);
                    cmd.Parameters.AddWithValue("@diachi", diachi);
                    cmd.Parameters.AddWithValue("@malop", malop);
                    cmd.Parameters.AddWithValue("@gioitinh", gt);
                    cmd.Parameters.AddWithValue("@ngay", ngay);
                    cmd.Parameters.AddWithValue("@thang", thang);
                    cmd.Parameters.AddWithValue("@nam", nam);
                    data.Load(cmd.ExecuteReader());
                }
            }
            return data;

        }

        public void timdulieu(string ma)
        {
            int n;
            string pr = "prAdapter_HocSinh";
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
                        maHS = ma;
                        tenHS = reader["sTenHS"].ToString();
                        diaChi = reader["sDiaChi"].ToString();
                        ngaySinh = DateTime.Parse(reader["dNgaysinh"].ToString());
                        gioiTinh = reader["sGioitinh"].ToString();
                        maLop = reader["sMalop"].ToString();
                    }
                    reader.Close();
                    cnn.Close();
                }

            }
        }


        public void timdulieuhs()
        {
            int n;
            string pr = "InforHS";
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = pr;

                    n = cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {                        diem = reader["fDiemCC"].ToString();
                    }
                    reader.Close();
                    cnn.Close();
                }

            }
        }


    }
}
