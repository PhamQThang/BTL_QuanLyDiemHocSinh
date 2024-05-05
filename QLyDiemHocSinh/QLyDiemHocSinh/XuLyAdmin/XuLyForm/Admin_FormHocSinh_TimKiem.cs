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
    public partial class Admin_FormHocSinh_TimKiem : Form
    {

        public DataTable data1 { get; set; }

        Admin_HocSinh xlhs = new Admin_HocSinh();
        public Admin_FormHocSinh_TimKiem(DataTable data)
        {
            InitializeComponent();
            this.data1 = data;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bool ktr = false;
            errorProvider1.Clear();
            string ngay = "", thang = "", nam = "";
            string ngaysinh = mtb_NgaySinh.Text;
            if (ngaysinh.Length == 6)
            {

                ngay = ngaysinh.Substring(0, 2);
                thang = ngaysinh.Substring(3, 2);
                if (ngay == "1 " || ngay == "2 " || ngay == "3 "
                || thang == "1 ")
                {
                    errorProvider1.SetError(mtb_NgaySinh, "Vui long nhập đủ thông tin");
                    ktr = true;
                }
            }
            else if (ngaysinh.Length == 10)
            {
                ngay = ngaysinh.Substring(0, 2);
                thang = ngaysinh.Substring(3, 2);
                nam = ngaysinh.Substring(6, 4);
                if (ngay == "1 " || ngay == "2 " || ngay == "3 " || thang == "1 ")
                {
                    errorProvider1.SetError(mtb_NgaySinh, "Vui long nhập đủ thông tin");
                    ktr = true;
                }
            }
            else
            {

                errorProvider1.SetError(mtb_NgaySinh, "Vui long nhập đủ thông tin");
                ktr = true;
            }

            if (ngay == "  ")
            {
                ngay = "";
            }
            if (thang == "  ")
            {
                thang = "";
            }
            string newday = ngay.TrimStart('0');
            string newmounth = thang.TrimStart('0');
            string gt = "";
            if (rdNam.Checked) gt = "Nam";
            if (rdNu.Checked) gt = "Nữ";
            if (ktr == false)
            {
                // tbl.Clear();
                data1 = xlhs.search_HocSinh(tbMaHS.Text, tbTenHS.Text, tbDiaChi.Text, tbMaLop.Text, gt, newday, newmounth, nam);
                this.Dispose();
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_FormHocSinh_TimKiem_Load(object sender, EventArgs e)
        {
            rdNam.Checked = false;
            rdNu.Checked = false;
            string[] cb_khoihoc = new string[8] { "LH6A", "LH7A", "LH8A", "LH9A",
                                                 "LH6B", "LH7B", "LH8B", "LH9B"};
            foreach (string i in cb_khoihoc)
            {
                tbMaLop.Items.Add(i);
            }
        }
    }
}
