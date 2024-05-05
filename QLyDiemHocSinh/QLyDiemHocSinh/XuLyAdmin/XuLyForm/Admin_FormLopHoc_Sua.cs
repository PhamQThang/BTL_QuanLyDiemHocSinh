using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLyDiemHocSinh.XuLyAdmin;
namespace QLyDiemHocSinh.XuLyAdmin.XuLyForm
{
    public partial class Admin_FormLopHoc_Sua : Form
    {
        string malop; 
        XuLyDuLieu.Admin_LopHoc xllh = new XuLyDuLieu.Admin_LopHoc();
        public Admin_FormLopHoc_Sua(string ma)
        {
            InitializeComponent();
            this.malop = ma;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (tbTenLop.Text == "")
                {
                    errorProvider1.SetError(tbTenLop, "Tên Lớp không được để trống");
                }
                else if (cbKhoiHoc.Text == "")
                {
                    errorProvider1.SetError(cbKhoiHoc, "Khối Học không được để trống");
                }

                else
                {
                    xllh.insertORupdate_LopHoc(tbMaLop.Text, tbTenLop.Text, cbKhoiHoc.Text,"prUpdate_LopHoc");
                    this.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng nhập lại !");
            }
        }

        

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_FormLopHoc_Sua_Load(object sender, EventArgs e)
        {
            try
            {
                tbMaLop.Enabled = false;
                xllh.timdulieu(malop);
                tbMaLop.Text = xllh.maLop;
                tbTenLop.Text = xllh.tenLopHoc;
                cbKhoiHoc.Text = xllh.khoiHoc;
                string[] cb = new string[4]{"6", "7", "8","9" };
                foreach (string i in cb)
                {
                    cbKhoiHoc.Items.Add(i);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng nhập lại !!!!!!");

            }
        }
    }
}
