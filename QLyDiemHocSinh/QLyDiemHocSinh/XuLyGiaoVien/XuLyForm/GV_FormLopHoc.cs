using QLyDiemHocSinh.XuLyDuLieu;
using QLyDiemHocSinh.XuLyGiaoVien.XuLyDuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyDiemHocSinh.XuLyGiaoVien.XuLyForm
{
    public partial class GV_FormLopHoc : Form
    {
        public GV_FormLopHoc()
        {
            InitializeComponent();
        }

        GV_XLLop xll = new GV_XLLop();
        DataTable data = new DataTable();
        GV_XLHS xlhs = new GV_XLHS();
        ThongTinTaiKhoan tk = new ThongTinTaiKhoan();
        string malop = "";
        string magv;
        public void LoadForm()
        {
            data.Clear();
            data = xll.Infor_LopHoc();
            gvLopHoc.DataSource = data;

        }
        private void GV_FormLopHoc_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void gvLopHoc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            malop = gvLopHoc.Rows[e.RowIndex].Cells["sMaLop"].Value.ToString();
            data.Clear();
            data = xll.Infor_HocSinhTheoLop(malop);
            //gvLopHoc.DataSource = data;
            GV_FormHocSinh form = new GV_FormHocSinh(data);
            form.ShowDialog();
            LoadForm();
        }

        private void gvLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            malop = gvLopHoc.Rows[e.RowIndex].Cells["sMaLop"].Value.ToString();
        }
    }
}
