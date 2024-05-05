using QLyDiemHocSinh.XuLyAdmin.XuLyDuLieu;
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
    public partial class Admin_FormHocSinh_Sua : Form
    {

        private string mahs;
        Admin_HocSinh xlhs = new Admin_HocSinh();
        public Admin_FormHocSinh_Sua(string ma)
        {
            InitializeComponent();
            this.mahs = ma;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (tbMaHS.Text == "")
                {
                    errorProvider1.SetError(tbMaHS, "Mã Học Sinh không được để trống");
                }
                else if (tbTenHS.Text == "")
                {
                    errorProvider1.SetError(tbTenHS, "Tên Học Sinh không được để trống");
                }
                else if (tbDiaChi.Text == "")
                {
                    errorProvider1.SetError(tbDiaChi, "Địa Chỉ không được để trống");
                }
                else if (tbMaLop.Text == "")
                {
                    errorProvider1.SetError(tbMaLop, "Địa Chỉ không được để trống");
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
                    xlhs.insertORupdate_HocSinh(tbMaHS.Text, tbTenHS.Text, dateTime, gt, tbDiaChi.Text, tbMaLop.Text, "prUpdate_HocSinh");
                    this.Dispose();
                    //MessageBox.Show("Sửa Thành Công !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa Thất Bại !" );
            }
        }

        private void Admin_FormHocSinh_Sua_Load(object sender, EventArgs e)
        {
            /*try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã Học Sinh đã tồn tại", "Thông Báo");
            }*/
            xlhs.timdulieu(mahs);
            tbMaHS.Text = mahs;
            tbTenHS.Text = xlhs.tenHS;
            tbDiaChi.Text = xlhs.diaChi;
            tbMaLop.Text = xlhs.maLop;
            DateTime abc = xlhs.ngaySinh;
            dtpk_Ngaysinh.Value = abc;
            string kt = xlhs.gioiTinh;
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
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
