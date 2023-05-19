using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using System.Data;

namespace DAMH_QuanLyKhachSan.DAL_QLKS
{
    class HoaDonDAO
    {
        DataHelper help = new DataHelper();
        public HoaDon getHoaDonTheoMaHD (string MaHD)
        {
            DataTable table = new DataTable();
            int n = 0;
            try
            {
                table = help.execeuteQuery("sp_HienThiHoaDonTheoMaHoaDon '" + MaHD + "'");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                HoaDon a = new HoaDon();
                a.MaHD = table.Rows[0][0].ToString();
                a.TenNV = table.Rows[0][1].ToString();
                a.NgayLapHD = table.Rows[0][2].ToString();
                a.MaKH = table.Rows[0][3].ToString();
                a.TenKH = table.Rows[0][4].ToString();
                a.SoDienThoai = table.Rows[0][5].ToString();
                a.DiaChi = table.Rows[0][6].ToString();
                return a;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool updateHoaDonKhiTraHetPhong(string MaHD)
        {
            try
            {
                help.executeNonQuery("update HoaDon set MATTHD = 2 where MAHD = '" + MaHD + "'");
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
