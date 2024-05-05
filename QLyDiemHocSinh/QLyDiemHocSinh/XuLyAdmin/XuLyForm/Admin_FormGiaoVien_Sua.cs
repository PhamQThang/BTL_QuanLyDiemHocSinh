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
    public partial class Admin_FormGiaoVien_Sua : Form
    {
        private string magv;
        Admin_GiaoVien xlgv = new Admin_GiaoVien();
        public Admin_FormGiaoVien_Sua(string ma)
        {
            InitializeComponent();
            this.magv = ma;
        }

        private void btnSua_Click(object sender, EventArgs e)
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
                    xlgv.insertORupdate_GiaoVien(tbMaGV.Text, tbTenGV.Text, dateTime, gt, tbCCCD.Text, "prUpdate_GiaoVien");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
               
            }
        }

        private void Admin_FormGiaoVien_Sua_Load(object sender, EventArgs e)
        {
            try
            {
                xlgv.timdulieu(magv);
                tbMaGV.Text = magv;
                tbTenGV.Text = xlgv.tenGV;
                DateTime abc = xlgv.ngaySinh;
                dtpk_Ngaysinh.Value = abc;
                string kt = xlgv.gioiTinh;
                if (kt == "Nam")
                {
                    rdNam.Checked = true;
                    rdNu.Checked = false;
                }
                else
                {
                    rdNam.Checked = false;
                    rdNu.Checked = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Mã Giáo Viên đã tồn tại", "Thông Báo");
            }
        }

        private void btlQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
