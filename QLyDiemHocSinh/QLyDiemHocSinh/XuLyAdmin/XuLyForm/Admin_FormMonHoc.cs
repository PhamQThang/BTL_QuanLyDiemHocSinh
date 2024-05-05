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
    public partial class Admin_FormMonHoc : Form
    {
        public Admin_FormMonHoc()
        {
            InitializeComponent();
        }
        DataTable data = new DataTable();
        XuLyAdmin.XuLyDuLieu.Admin_MonHoc xlmh = new XuLyDuLieu.Admin_MonHoc();

        public void LoadForm()
        {
            data.Clear();
            data = xlmh.infor_MonHoc("prInfor_DiemToan");
            gvMonHoc.DataSource = data;
        }

        private void Admin_FormMonHoc_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnLy_Click(object sender, EventArgs e)
        {
            data.Clear();
            data = xlmh.infor_MonHoc("prInfor_DiemLy");
            gvMonHoc.DataSource = data;
        }

        private void btnHoa_Click(object sender, EventArgs e)
        {
            data.Clear();
            data = xlmh.infor_MonHoc("prInfor_DiemHoa");
            gvMonHoc.DataSource = data;
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            data.Clear();
            data = xlmh.infor_MonHoc("prInfor_DiemSinh");
            gvMonHoc.DataSource = data;
        }

        private void btnToan_Click(object sender, EventArgs e)
        {
            data.Clear();
            data = xlmh.infor_MonHoc("prInfor_DiemToan");
            gvMonHoc.DataSource = data;
        }
    }
}
