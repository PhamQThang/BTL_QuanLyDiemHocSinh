using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLyDiemHocSinh.KetNoi;
using QLyDiemHocSinh.XuLyDuLieu;
namespace QLyDiemHocSinh.XuLyGiaoVien.XuLyDuLieu
{
    class GV_XLHS
    {
        public string maHS { get; set; }
        public string tenHS { get; set; }
        public DateTime ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string lopHoc { get; set; }

        KetNoi.Connect connect = new KetNoi.Connect();
        ThongTinTaiKhoan tk = new ThongTinTaiKhoan();
        DataTable data = new DataTable();
        public GV_XLHS()
        {

        }

        public GV_XLHS(string maHS, string tenHS, DateTime ngaySinh, string gioiTinh, string diaChi, string lopHoc, Connect connect, ThongTinTaiKhoan tk)
        {
            this.maHS = maHS;
            this.tenHS = tenHS;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.lopHoc = lopHoc;
            this.connect = connect;
            this.tk = tk;
        }

        public DataTable Infor_HocSinh()
        {
            tk.LoadThongTin(Properties.Settings.Default.tenNguoiSD);
            string proc_Thongtin = "prInfor_DSHSofGV";
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
