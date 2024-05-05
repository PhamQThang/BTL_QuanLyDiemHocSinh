using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLyDiemHocSinh.XuLyGiaoVien.XuLyDuLieu;
namespace QLyDiemHocSinh.XuLyGiaoVien.XuLyForm
{
    public partial class GV_FormChamDiem : Form
    {
        public GV_FormChamDiem()
        {
            InitializeComponent();
        }
        DataTable data = new DataTable();
        string ma = "";
        XuLyDiemMonHoc xl = new XuLyDiemMonHoc();
        public void LoadForm()
        {
            tbMaHS.Text = "";
            tbTenHS.Text = "";
            tbTenMonHoc.Text = "";
            tbCC.Text = "";
            tbGK.Text = "";
            tbDT.Text = "";
            data.Clear();
            data = xl.LoadDiem();
            gvMonHoc.DataSource = data;
        }
        private void btnChamDiem_Click(object sender, EventArgs e)
        {
            GV_FormChamDiem_Sua form = new GV_FormChamDiem_Sua(ma);
            if (ma == "")
            {
                MessageBox.Show("Vui lòng chọn mã học sinh cần sửa", "Thông báo");
            }
            else
            {
                form.ShowDialog();
                data.Clear();
                data = xl.LoadDiem();
                gvMonHoc.DataSource = data;
            }
        }

        private void GV_FormChamDiem_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            data = (DataTable)gvMonHoc.DataSource;
            FormInDanhSach form = new FormInDanhSach();
            CrpDiemHS crp = new CrpDiemHS();

            crp.SetDataSource(data);
            form.crystalReportViewer1.ReportSource = crp;
            form.ShowDialog();
        }
            

        private void gvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ma = gvMonHoc.Rows[e.RowIndex].Cells["sMaHS"].Value.ToString();
            tbMaHS.Text = gvMonHoc.Rows[e.RowIndex].Cells["sMaHS"].Value.ToString();
            tbTenHS.Text = gvMonHoc.Rows[e.RowIndex].Cells["sTenHS"].Value.ToString();
            tbTenMonHoc.Text = gvMonHoc.Rows[e.RowIndex].Cells["sTenMonHoc"].Value.ToString();
            tbCC.Text = gvMonHoc.Rows[e.RowIndex].Cells["fDiemCC"].Value.ToString();
            tbGK.Text = gvMonHoc.Rows[e.RowIndex].Cells["fDiemGK"].Value.ToString();
            tbDT.Text = gvMonHoc.Rows[e.RowIndex].Cells["fDiemThi"].Value.ToString();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            GV_FormChamDiem_TimKiem form = new GV_FormChamDiem_TimKiem(data);
            form.ShowDialog();
            data.Clear();
            data = form.data1;
            gvMonHoc.DataSource = data;
            gvMonHoc.DataSource = data;
        }
    }
}
