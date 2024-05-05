using QLyDiemHocSinh.XuLySinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyDiemHocSinh
{
    public partial class FormHocSinh : Form
    {
        public FormHocSinh()
        {
            InitializeComponent();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HS_FormThongTin x = new HS_FormThongTin();
            x.Show();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HS_FormDiem x = new HS_FormDiem();
            x.Show();
        }
    }
}
