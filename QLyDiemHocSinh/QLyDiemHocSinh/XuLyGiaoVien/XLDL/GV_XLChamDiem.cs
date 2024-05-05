using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLyDiemHocSinh.XuLyGiaoVien.XLForm;
using System.Data.SqlClient;
using System.Data;
using QLyDiemHocSinh.KetNoi;
namespace QLyDiemHocSinh.XuLyGiaoVien.XLDL
{
    class GV_XLChamDiem
    {
        string tenHS { get; set; }
        string tenMH { get; set; }
        float diemCC { get; set; }
        float diemGK { get; set; }
        float diemCK { get; set; }
        public GV_XLChamDiem()
        {

        }

        public GV_XLChamDiem(string tenHS, string tenMH, float diemCC, float diemGK, float diemCK)
        {
            this.tenHS = tenHS;
            this.tenMH = tenMH;
            this.diemCC = diemCC;
            this.diemGK = diemGK;
            this.diemCK = diemCK;
        }

        DataTable data = new DataTable();
        Connect connect = new Connect();

    }
}
