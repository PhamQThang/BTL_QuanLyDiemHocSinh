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
    public partial class HS_FormDiem : Form
    {
        public HS_FormDiem()
        {
            InitializeComponent();
        }
        Connect connect = new Connect();
        ThongTinTaiKhoan tt = new ThongTinTaiKhoan();
        DataTable data = new DataTable();

        public void LoadForm()
        {
            tt.LoadThongTin(Properties.Settings.Default.tenNguoiSD);
            string proc = "prInfor_BangDiemHS";
            using (SqlConnection cnn = connect.Connection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@mahs", tt.maxx);
                    data.Clear();
                    data.Load(cmd.ExecuteReader());
                    cnn.Close();
                }
                gvMonHoc.DataSource = data;
            }
        }

        private void gvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadForm();
        }

        private void HS_FormDiem_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
