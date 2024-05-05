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
    public partial class GV_FormChamDiem_TimKiem : Form
    {       
        public DataTable data1 { get; set; }

        XuLyDiemMonHoc xld = new XuLyDiemMonHoc();
        public GV_FormChamDiem_TimKiem(DataTable data1)
        {
            InitializeComponent();
            this.data1 = data1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            data1 = xld.timdiemsv(tbMaHS.Text, tbTenHocSinh.Text);
            this.Dispose();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
