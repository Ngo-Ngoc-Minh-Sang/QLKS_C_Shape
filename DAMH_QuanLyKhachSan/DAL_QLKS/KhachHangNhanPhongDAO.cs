using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using System.Data;

namespace DAMH_QuanLyKhachSan.DAL_QLKS
{
    class KhachHangNhanPhongDAO
    {
        DataHelper help = new DataHelper();

        public KhachHangNhanPhong getKhachHangNP(string madp)
        {
            DataTable table = new DataTable();
            int n = 0;
            try
            {
                table = help.execeuteQuery("sp_LayThongTinKhachDatByMaDP '" + madp+"'");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                KhachHangNhanPhong a = new KhachHangNhanPhong();
                a.HoTen = table.Rows[0][0].ToString();
                a.SDT = table.Rows[0][1].ToString();
                a.NgayNhan = table.Rows[0][2].ToString();
                a.NgayTra = table.Rows[0][3].ToString();

                return a;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
