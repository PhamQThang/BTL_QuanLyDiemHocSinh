using QLyDiemHocSinh.KetNoi;
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
    class GV_XLDiem
    {
        Connect connect = new Connect();
        ThongTinTaiKhoan tt = new ThongTinTaiKhoan();
        DataTable data = new DataTable();

        public DataTable loaddulieu()
        {
            tt.LoadThongTin(Properties.Settings.Default.tenNguoiSD);
            string proc = "inforDTK_danhhieutkgv";
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@Magv", tt.maxx);

                    data.Load(cmd.ExecuteReader());


                    cnn.Close();

                }
            }
            return data;

        }
    }
}
