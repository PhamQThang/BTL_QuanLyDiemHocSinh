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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        int dem = 0;
        public bool kt { get; set; }
        
        public string tenNguoiSD { get; set; }

        public int loaiTK { get; set; }

        XuLyDuLieu.DangNhap dangNhap = new XuLyDuLieu.DangNhap();


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tenNguoiSD = "";
            errorProvider1.Clear();
            lbThongBao.Text = "";
            string tk = txtTK.Text;
            string mk = txtMK.Text;
            bool a, ktraDN;
            if (txtTK.Text == "")
            {
                errorProvider1.SetError(txtTK, "Tên đăng nhập không được để trống");
                a = false;
            }
            else if (txtMK.Text == "")
            {
                errorProvider1.SetError(txtMK, "Tên mật khẩu không được để trống");
                a = false;
            }
            else
            {
                ktraDN = dangNhap.kiemTraDangNhap(tk, mk);
                if (ktraDN == true)
                {
                    MessageBox.Show("Chào Mừng Bạn Đến Với Quản Lý Điểm Sinh Viên", dangNhap.tennguoisd.ToString());
                    tenNguoiSD = dangNhap.tennguoisd.ToString();
                    kt = true;
                    Properties.Settings.Default.tenNguoiSD = tenNguoiSD;
                    loaiTK = Properties.Settings.Default.loaiTK;
                    Properties.Settings.Default.Save();
                    if(loaiTK == 0)
                    {
                        FormTrangChu x = new FormTrangChu();
                        this.Hide();
                        x.ShowDialog();
                        this.Show();
                    }
                    else if(loaiTK == 1)
                    {
                        FormTrangChu_GiaoVien x = new FormTrangChu_GiaoVien();
                        this.Hide();
                        x.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        FormHocSinh x = new FormHocSinh();
                        this.Hide();
                        x.ShowDialog();
                        this.Show();
                    }

                 
                }
                /*else
                {
                    dem++;
                    MessageBox.Show("Ban da nhap sai " + dem + " lan. Qua 3 lan se bi khoa");
                    if (dem >= 3)
                    {
                        Application.Exit();
                    }
                }*/
            }
        }
    }
}
