using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLyDiemHocSinh.XuLyAdmin.XuLyDuLieu;


namespace QLyDiemHocSinh.XuLyAdmin.XuLyForm
{
    public partial class Admin_FormGiaoVien_Them : Form
    {
        public Admin_FormGiaoVien_Them(string ma)
        {
            InitializeComponent();
        }

        Admin_GiaoVien xlgv = new Admin_GiaoVien();

        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (tbMaGV.Text == "")
                {
                    errorProvider1.SetError(tbMaGV, "Mã Giáo Viên không được để trống");
                }
                else if (tbTenGV.Text == "")
                {
                    errorProvider1.SetError(tbTenGV, "Tên Giáo Viên không được để trống");
                }
                else if (tbCCCD.Text == "")
                {
                    MessageBox.Show("CCCD Không được để trống");
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
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã Giáo Viên đã tồn tại");
            }
        }

        private void btlQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
