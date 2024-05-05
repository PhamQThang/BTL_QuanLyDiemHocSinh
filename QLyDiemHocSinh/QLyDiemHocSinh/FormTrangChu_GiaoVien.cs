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
    public partial class FormTrangChu_GiaoVien : Form
    {
        public FormTrangChu_GiaoVien()
        {
            InitializeComponent();
        }

        XuLyGiaoVien.XuLyForm.GV_FormChamDiem gvd = new XuLyGiaoVien.XuLyForm.GV_FormChamDiem();
        XuLyGiaoVien.XuLyForm.GV_FormHocSinh fhs = new XuLyGiaoVien.XuLyForm.GV_FormHocSinh();
        XuLyGiaoVien.XuLyForm.GV_FormLopHoc flh = new XuLyGiaoVien.XuLyForm.GV_FormLopHoc();
        XuLyGiaoVien.XuLyForm.GV_FormDiemTK dtk = new XuLyGiaoVien.XuLyForm.GV_FormDiemTK();
        public void loadform(Form form)
        {
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flh.Hide();
            fhs.Hide();
            dtk.Hide();
            loadform(gvd);
            gvd.LoadForm();
        }

        private void quảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flh.Hide();
            gvd.Hide();
            dtk.Hide();
            loadform(fhs);
            fhs.LoadForm();
        }

        private void quảnLýHọcSinhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fhs.Hide();
            gvd.Hide();
            dtk.Hide();
            loadform(flh);
            flh.LoadForm();
        }

        private void điểmTổngKếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fhs.Hide();
            gvd.Hide();
            loadform(dtk);
            dtk.formload();
            flh.Hide();
        }
    }
}
