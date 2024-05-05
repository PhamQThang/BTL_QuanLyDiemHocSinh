using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLyDiemHocSinh.KetNoi;
namespace QLyDiemHocSinh.XuLyAdmin.XuLyDuLieu
{
    class Admin_MonHoc
    {
        public Admin_MonHoc()
        {

        }

        public Admin_MonHoc(string tenHS, string tenMH, float diemCC, float diemGK, float diemCK)
        {
            this.tenHS = tenHS;
            this.tenMH = tenMH;
            DiemCC = diemCC;
            DiemGK = diemGK;
            DiemCK = diemCK;
        }

        string tenHS { get; set; }
        string tenMH { get; set; }
        float DiemCC { get; set; }
        float DiemGK { get; set; }
        float DiemCK { get; set; }

        Connect connect = new Connect();
        DataTable data = new DataTable();
        public DataTable infor_MonHoc(string pr)
        {
            using(SqlConnection cnn = connect.Connection())
            {
                using(SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = pr;

                    data.Load(cmd.ExecuteReader());

                    cnn.Close();
                }
            }
            return data;
        }
    }
}
