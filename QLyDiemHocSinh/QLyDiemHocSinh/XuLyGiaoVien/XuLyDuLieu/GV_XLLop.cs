using QLyDiemHocSinh.XuLyDuLieu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyDiemHocSinh.XuLyGiaoVien.XuLyDuLieu
{
    class GV_XLLop
    {

        KetNoi.Connect connect = new KetNoi.Connect();
        ThongTinTaiKhoan tk = new ThongTinTaiKhoan();
        DataTable data = new DataTable();
        public DataTable Infor_LopHoc()
        {
            tk.LoadThongTin(Properties.Settings.Default.tenNguoiSD);
            string proc_Thongtin = "prInfor_LOPofGV";
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc_Thongtin;
                    cmd.Parameters.AddWithValue("@magv", tk.maxx);

                    data.Load(cmd.ExecuteReader());

                    cnn.Close();  
                }
            }
            return data;
        }
        public DataTable Infor_HocSinhTheoLop(string malop)
        {
            tk.LoadThongTin(Properties.Settings.Default.tenNguoiSD);
            string proc_Thongtin = "prInfor_HSofGV";
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc_Thongtin;
                    cmd.Parameters.AddWithValue("@magv", tk.maxx);
                    cmd.Parameters.AddWithValue("@malop", malop);
                    data.Load(cmd.ExecuteReader());

                    cnn.Close();
                }
            }
            return data;
        }
    }
}
