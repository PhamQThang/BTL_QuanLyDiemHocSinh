using QLyDiemHocSinh.ChucNangTimKiem.XLForm;
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
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        XuLyAdmin.XuLyForm.Admin_FormGIaoVien gvf = new XuLyAdmin.XuLyForm.Admin_FormGIaoVien();
        XuLyAdmin.XuLyForm.Admin_FormHocSinh hsf = new XuLyAdmin.XuLyForm.Admin_FormHocSinh();
        XuLyAdmin.XuLyForm.Admin_FormLopHoc lhf = new XuLyAdmin.XuLyForm.Admin_FormLopHoc();
        XuLyAdmin.XuLyForm.Admin_FormMonHoc mhf = new XuLyAdmin.XuLyForm.Admin_FormMonHoc();
        FormDiemTheoKhoi dtk = new FormDiemTheoKhoi();
        public void loadform(Form form)
        {
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

      
        //------------------------------------
        private void quảnLýGiáoViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mhf.Hide();
            hsf.Hide();
            lhf.Hide();
            dtk.Hide();
            loadform(gvf);
            gvf.LoadForm();
        }

        private void quảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mhf.Hide();
            gvf.Hide();
            lhf.Hide();
            dtk.Hide();
            loadform(hsf);
            hsf.LoadForm();

        }

        private void quảnLýHọcSinhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mhf.Hide();
            hsf.Hide();
            gvf.Hide();
            dtk.Hide();
            loadform(lhf);
            lhf.LoadForm();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lhf.Hide();
            hsf.Hide();
            gvf.Hide();
            dtk.Hide();
            loadform(mhf);
            mhf.LoadForm();
        }

        private void tìmKiếmĐIểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lhf.Hide();
            hsf.Hide();
            gvf.Hide();
            mhf.Hide();
            loadform(dtk);
            
        }
    }
}
