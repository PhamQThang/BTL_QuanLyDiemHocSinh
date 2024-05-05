using QLyDiemHocSinh.KetNoi;
using QLyDiemHocSinh.XuLyDuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyDiemHocSinh.XuLySinhVien
{
    public partial class HS_FormThongTin : Form
    {
        public HS_FormThongTin()
        {
            InitializeComponent();
        }

        ThongTinTaiKhoan tt = new ThongTinTaiKhoan();
        Connect cnn = new Connect();
        public void LoadForm()
        {
            string proc = "prInfor_HS";
            tt.LoadThongTin(Properties.Settings.Default.tenNguoiSD);
            using (SqlConnection cn = cnn.Connection())
            {
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@ma", tt.maxx);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tbMaHS.Text = reader["sMaHS"].ToString();
                        tbTenHS.Text = reader["sTenHS"].ToString();
                        dtpk_Ngaysinh.Value = DateTime.Parse(reader["dNgaySinh"].ToString());
                        string ktr;
                        tbGioiTinh.Text = reader["sGioiTinh"].ToString();
                        tbDiaChi.Text = reader["sDiaChi"].ToString();
                        tbMaLop.Text = reader["sTenLopHoc"].ToString();
                    }
                    reader.Close();
                    cn.Close();
                }
            }
        }
        private void HS_FormThongTin_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
