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
using QLyDiemHocSinh.XuLyAdmin.XuLyDuLieu;
using QLyDiemHocSinh.XuLyDuLieu;
using QLyDiemHocSinh.XuLyAdmin.XuLyForm;

namespace QLyDiemHocSinh.XuLyGiaoVien.XuLyForm
{
    public partial class GV_FormHocSinh : Form
    {
        public GV_FormHocSinh()
        {
            InitializeComponent();
        }
        public GV_FormHocSinh(DataTable data)
        {
            InitializeComponent();
            this.data = data;
        }
        GV_XLHS xlhs = new GV_XLHS();
        DataTable data = new DataTable();

        public void LoadForm()
        {
            data.Clear();
            data = xlhs.Infor_HocSinh();
            gvHocSinh.DataSource = data;
           
        }
        private void GV_FormHocSinh_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbMaHS.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã Học Sinh");
            }
            else
            {
                GV_FormHocSinh_Sua form = new GV_FormHocSinh_Sua(tbMaHS.Text);
                form.ShowDialog();
                LoadForm();
            }
        }

        private void gvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaHS.Text = gvHocSinh.Rows[e.RowIndex].Cells["sMaHS"].Value.ToString();
            tbTenHS.Text = gvHocSinh.Rows[e.RowIndex].Cells["sTenHS"].Value.ToString();
            dtpk_Ngaysinh.Text = gvHocSinh.Rows[e.RowIndex].Cells["dNgaySinh"].Value.ToString();
            tbDiaChi.Text = gvHocSinh.Rows[e.RowIndex].Cells["sDiaChi"].Value.ToString();
            tbMaLop.Text = gvHocSinh.Rows[e.RowIndex].Cells["sMaLop"].Value.ToString();

            if (gvHocSinh.Rows[e.RowIndex].Cells["sGioiTinh"].Value.ToString() == "Nam")
            {
                rdNam.Checked = true;
                rdNu.Checked = false;
            }
            else
            {
                rdNam.Checked = false;
                rdNu.Checked = true;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Admin_FormHocSinh_TimKiem form = new Admin_FormHocSinh_TimKiem(data);
            form.ShowDialog();
            data.Clear();
            data = form.data1;
            gvHocSinh.DataSource = data;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Admin_FormHocSinh_TimKiem form = new Admin_FormHocSinh_TimKiem(data);
            form.ShowDialog();
            data.Clear();
            data = form.data1;
            gvHocSinh.DataSource = data;
        }
    }
}
