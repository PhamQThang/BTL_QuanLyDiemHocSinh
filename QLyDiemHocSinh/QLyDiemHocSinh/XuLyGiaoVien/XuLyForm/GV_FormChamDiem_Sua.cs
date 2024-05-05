using QLyDiemHocSinh.XuLyGiaoVien.XuLyDuLieu;
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
    public partial class GV_FormChamDiem_Sua : Form
    {
        string ma;
        public GV_FormChamDiem_Sua(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }
        XuLyDiemMonHoc xl = new XuLyDiemMonHoc();
        private void GV_FormChamDiem_Sua_Load(object sender, EventArgs e)
        {
            int n = xl.timdulieu(ma);
            tbMaBangDiem.Text = ma;
            tbTenHocSinh.Text = xl.tenHS;
            tbTenMonHoc.Text = xl.tenMonHoc;
            tbDCC.Text = xl.diemCC.ToString();
            tbDGK.Text = xl.diemGK.ToString();
            tbDCK.Text = xl.diemCK.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(float.Parse(tbDCC.Text)>10 || float.Parse(tbDCC.Text) < 0)
            {
                MessageBox.Show("Điểm Nhập Không Hợp Lệ !\n ( 0 <= Điểm <= 10 )");
            }
            else if(float.Parse(tbDCK.Text) > 10 || float.Parse(tbDCK.Text) < 0)
            {
                MessageBox.Show("Điểm Nhập Không Hợp Lệ !\n ( 0 <= Điểm <= 10 )");
            }
            else if (float.Parse(tbDGK.Text) > 10 || float.Parse(tbDGK.Text) < 0)
            {
                MessageBox.Show("Điểm Nhập Không Hợp Lệ !\n ( 0 <= Điểm <= 10 )");
            }
            else
            {
                int n = xl.Insert_Update(tbMaBangDiem.Text, xl.maMon,
                float.Parse(tbDCC.Text),
                float.Parse(tbDGK.Text),
                float.Parse(tbDCK.Text));
                this.Dispose();
            }
            
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
