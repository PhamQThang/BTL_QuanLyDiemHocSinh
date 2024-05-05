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
    public partial class Admin_FormLopHoc : Form
    {
        public Admin_FormLopHoc()
        {
            InitializeComponent();
        }
        Admin_LopHoc xllh = new Admin_LopHoc();
        DataTable data = new DataTable();
        
        public void LoadForm()
        {
            //tbMaLop.Text = "";
            //tbTenLop.Text = "";
            //cbKhoiHoc.Text = "";
            data.Clear();
            data = xllh.infor_AllLopHoc();
            gvLopHoc.DataSource = data;
        }
        private void Admin_FormLopHoc_Load(object sender, EventArgs e)
        {
            LoadForm();
            //cbKhoiHoc.Text = "";
            //string[] cb = new string[4]
            //{
                //"6", "7", "8","9"
            //};
           // foreach(string i in cb)
           // {
               //cbKhoiHoc.Items.Add(i);
            //}
        }

        private void gvLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tbMaLop.Text = gvLopHoc.Rows[e.RowIndex].Cells["sMaLop"].Value.ToString();
           // tbTenLop.Text = gvLopHoc.Rows[e.RowIndex].Cells["sTenLopHoc"].Value.ToString();
            //cbKhoiHoc.Text = gvLopHoc.Rows[e.RowIndex].Cells["iKhoiHoc"].Value.ToString();
        }

        /*private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (tbMaLop.Text == "")
                {
                    errorProvider1.SetError(tbMaLop, "Mã Lớp không được để trống");
                }
                else if (tbTenLop.Text == "")
                {
                    errorProvider1.SetError(tbTenLop, "Tên Lớp không được để trống");
                }
                else if (cbKhoiHoc.Text == "")
                {
                    errorProvider1.SetError(cbKhoiHoc, "Khối Học không được để trống");
                }

                else
                {
                    xllh.insertORupdate_LopHoc(tbMaLop.Text, tbTenLop.Text, cbKhoiHoc.Text, "prInsert_LopHoc");
                    LoadForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã Lớp đã có. Vui lòng nhập lại !");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(tbMaLop.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã lớp");

            }
            else
            {
                Admin_FormLopHoc_Sua form = new Admin_FormLopHoc_Sua(tbMaLop.Text);
                form.ShowDialog();
                LoadForm();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                xllh.delete_LopHoc(tbMaLop.Text);
                LoadForm();
            }catch(Exception ex)
            {
                 MessageBox.Show("Lớp Học đang dạy, không thể xóa !", "Thông Báo");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                data.Clear();
                data = xllh.search_LopHoc(tbMaLop.Text, tbTenLop.Text, cbKhoiHoc.Text);
                gvLopHoc.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có lớp học tìm kiếm trong danh sách !", "Thông Báo");
            }
        }*/

        private void btnXemToanBo_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnKhoi6_Click(object sender, EventArgs e)
        {
            data.Clear();
            data = xllh.infor_LopHoc("6");
            gvLopHoc.DataSource = data;
        }

        private void btnKhoi7_Click(object sender, EventArgs e)
        {
            data.Clear();
            data = xllh.infor_LopHoc("7");
            gvLopHoc.DataSource = data;
        }

        private void btnKhoi8_Click(object sender, EventArgs e)
        {
            data.Clear();
            data = xllh.infor_LopHoc("8");
            gvLopHoc.DataSource = data;
        }

        private void btnKhoi9_Click(object sender, EventArgs e)
        {
            data.Clear();
            data = xllh.infor_LopHoc("9");
            gvLopHoc.DataSource = data;
        }
    }
}
