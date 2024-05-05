using QLyDiemHocSinh.ChucNangTimKiem.XLDuLIeu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyDiemHocSinh.ChucNangTimKiem.XLForm
{
    public partial class FormDiemTheoKhoi : Form
    {
        public FormDiemTheoKhoi()
        {
            InitializeComponent();
        }

        XLDiemTheoKhoi x = new XLDiemTheoKhoi();
        DataTable tbl = new DataTable();
        private void FormDiemTheoKhoi_Load(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = x.loadlieu();
            gvDiem.DataSource = tbl;
            string[] cb_khoihoc = new string[4] { "6", "7", "8", "9" };
            foreach (string i in cb_khoihoc)
            {
                cb_khoi.Items.Add(i);
            }
            string[] mdanhhieu = new string[4] { "Giỏi", "Khá", "TB", "Yếu" };
            foreach (string i in mdanhhieu)
            {
                cb_danhhieu.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //formrepost form = new formrepost();
            this.Hide();
            //form.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tbl.Clear();
            int diemmax = int.Parse(max.Value.ToString());
            int diemmin = int.Parse(min.Value.ToString());
            tbl = x.Timkiem(tb_ten.Text, cb_khoi.Text,
                cb_danhhieu.Text, diemmax,
                diemmin);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tbl = (DataTable)gvDiem.DataSource;
            FormInDanhSach form = new FormInDanhSach();
            CrpDiemTheoKhoi crp = new CrpDiemTheoKhoi();
            crp.SetDataSource(tbl);
            form.crystalReportViewer1.ReportSource = crp;
            form.ShowDialog();
        }
    }
}
