using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyDiemHocSinh.XuLyAdmin.XuLyForm
{
    public partial class Admin_FormGIaoVien : Form
    {
        public Admin_FormGIaoVien()
        {
            InitializeComponent();
        }

        XuLyDuLieu.Admin_GiaoVien xlgv = new XuLyDuLieu.Admin_GiaoVien();
        DataTable data = new DataTable();
         string ma = "";
        public void LoadForm()
        {
            data.Clear();
            data = xlgv.infor_GiaoVien();
            gvGiaoVien.DataSource = data;
        }
        private void Admin_XuLyGiaoVien_Load(object sender, EventArgs e)
        {
            LoadForm();

        }



        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (tbMaGV.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập Mã Giáo Viên");
                }
                else if (tbTenGV.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập Tên Giáo Viên");
                }
                else if(tbCCCD.Text == "")
                {
                    MessageBox.Show("Căn Cước Công Dân không được để trống. Vui lòng nhập lại !", "Thông Báo :");
                }
                else
                {
                    string gt = "";
                    if (rdNam.Checked)
                    {
                        gt = "Nam";
                    }
                    else gt = "Nữ";
                    DateTime dateTime = dtpk_Ngaysinh.Value;
                    xlgv.insertORupdate_GiaoVien(tbMaGV.Text, tbTenGV.Text, dateTime, gt, tbCCCD.Text, "prInsert_GiaoVien");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã Giáo Viên đã tồn tại");
            }
            LoadForm();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Admin_FormGiaoVien_TimKiem form = new Admin_FormGiaoVien_TimKiem(data);
            form.ShowDialog();
            data.Clear();
            data = form.data1;
            gvGiaoVien.DataSource = data;
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(tbMaGV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Mã Giáo Viên", "Thông Báo");

            }
            else
            {
                int n = xlgv.delete_GiaoVien(tbMaGV.Text);
                tbMaGV.Text = "";
                tbTenGV.Text = "";
                tbCCCD.Text = "";
                rdNam.Checked = false;
                rdNu.Checked = false;
                LoadForm();
            }
           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(tbMaGV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Mã Giáo Viên", "Thông Báo");

            }
            else
            {
                Admin_FormGiaoVien_Sua form = new Admin_FormGiaoVien_Sua(tbMaGV.Text);
                form.ShowDialog();
                LoadForm();
            }

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            data = (DataTable)gvGiaoVien.DataSource;
            FormInDanhSach form = new FormInDanhSach();
            Crp crp = new Crp();
            crp.SetDataSource(data);
            form.crystalReportViewer1.ReportSource = crp;
            form.ShowDialog();
        }

        private void gvGiaoVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tbMaGV.Text = gvGiaoVien.Rows[e.RowIndex].Cells["sMaGV"].Value.ToString();
            tbTenGV.Text = gvGiaoVien.Rows[e.RowIndex].Cells["sTenGiaoVien"].Value.ToString();
            dtpk_Ngaysinh.Text = gvGiaoVien.Rows[e.RowIndex].Cells["dNgaySinh"].Value.ToString();
            tbCCCD.Text = gvGiaoVien.Rows[e.RowIndex].Cells["sCCCD"].Value.ToString();


            if (gvGiaoVien.Rows[e.RowIndex].Cells["sGioiTinh"].Value.ToString() == "Nam")
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
    }
}
