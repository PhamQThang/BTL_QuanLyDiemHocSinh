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

namespace QLyDiemHocSinh.XuLyGiaoVien.XuLyForm
{
    public partial class GV_FormHocSinh_Sua : Form
    {

        private string mahs;
        Admin_HocSinh xlhs = new Admin_HocSinh();
        public GV_FormHocSinh_Sua(string ma)
        {
            InitializeComponent();
            this.mahs = ma;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                if (tbTenHS.Text == "")
                {
                    errorProvider1.SetError(tbTenHS, "Tên Học Sinh không được để trống");
                }
                else if (tbDiaChi.Text == "")
                {
                    errorProvider1.SetError(tbDiaChi, "Địa Chỉ không được để trống");
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa Thất Bại !");
            }
        }

        private void GV_FormHocSinh_Sua_Load(object sender, EventArgs e)
        {
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Mã Học Sinh đã tồn tại", "Thông Báo");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
