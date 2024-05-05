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
    public partial class GV_FormDiemTK : Form
    {
        public GV_FormDiemTK()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        GV_XLDiem xl = new GV_XLDiem();

        public void formload()
        {
            tbl.Clear();
            tbl = xl.loaddulieu();
            gvDiemTK.DataSource = tbl;
        }
        private void GV_FormDiemTK_Load(object sender, EventArgs e)
        {
            formload();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }
    }
}
