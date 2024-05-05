using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLyDiemHocSinh.XuLyAdmin;
using System.Data.SqlClient;
using QLyDiemHocSinh.XuLyAdmin.XuLyDuLieu;

namespace QLyDiemHocSinh.XuLyAdmin.XuLyForm
{
    public partial class Admin_FormHocSinh : Form
    {
        int a = 10;
        XuLyDuLieu.Admin_HocSinh xlhs = new XuLyDuLieu.Admin_HocSinh();
        KetNoi.Connect connect = new KetNoi.Connect();
        DataTable data = new DataTable();
        List<string> items = new List<string>();
        

        public Admin_FormHocSinh()
        {
            InitializeComponent();
        }

        public void LoadForm()
        {
            
            data.Clear();
            data = xlhs.infor_HocSinh();
            gvHocSinh.DataSource = data;
            /*using (SqlConnection cnn = new SqlConnection("Data Source=.;Initial Catalog=QLyDiem;Integrated Security=True"))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select sMaLop from tblLopHoc",cnn))
                {
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader.GetString(0);
                            items.Add(value);
                        }
                    }
                }
                cnn.Close();

            }
            tbMaLop.Items.AddRange(items.ToArray());*/

        }
        private void Admin_FormHocSinh_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                string gt = "";
                if (rdNam.Checked)
                {
                    gt = "Nam";
                }
                else gt = "Nữ";
                DateTime dateTime = dtpk_Ngaysinh.Value;
                xlhs.insertORupdate_HocSinh(tbMaHS.Text, tbTenHS.Text, dateTime, gt, tbDiaChi.Text, tbMaLop.Text, "prInsert_HocSinh");
                LoadForm();
            }catch(Exception ex)
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu !", "Thông báo ");
            }
        }

        private void gvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaHS.Text = gvHocSinh.Rows[e.RowIndex].Cells["sMaHS"].Value.ToString();
            tbTenHS.Text = gvHocSinh.Rows[e.RowIndex].Cells["sTenHS"].Value.ToString();
            dtpk_Ngaysinh.Text = gvHocSinh.Rows[e.RowIndex].Cells["dNgaySinh"].Value.ToString();
            tbDiaChi.Text = gvHocSinh.Rows[e.RowIndex].Cells["sDiaChi"].Value.ToString();
            tbMaLop.Text = gvHocSinh.Rows[e.RowIndex].Cells["sMaLop"].Value.ToString();
            xlhs.timdulieuhs();
            
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
            if(xlhs.diem == "9")
            {
                btnXoa.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
            }
           // MessageBox.Show(xlhs.diem);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbMaHS.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Mã Học Sinh", "Thông Báo");

            }
            else
            {
                int n = xlhs.delete_HocSinh(tbMaHS.Text);
                tbMaHS.Text = "";
                tbTenHS.Text = "";
                tbDiaChi.Text = "";
                rdNam.Checked = false;
                rdNu.Checked = false;
                LoadForm();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbMaHS.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã Học Sinh");
            }
            else
            {
                Admin_FormHocSinh_Sua form = new Admin_FormHocSinh_Sua(tbMaHS.Text);
                form.ShowDialog();
                LoadForm();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Admin_FormHocSinh_TimKiem form = new Admin_FormHocSinh_TimKiem(data);
            form.ShowDialog();
            data.Clear();
            data = form.data1;
            gvHocSinh.DataSource = data;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            data = (DataTable)gvHocSinh.DataSource;
            FormInDanhSach form = new FormInDanhSach();
            RptDSHS crp = new RptDSHS();
            crp.SetDataSource(data);
            form.crystalReportViewer1.ReportSource = crp;
            form.ShowDialog();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
