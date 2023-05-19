using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using System.Data;

namespace DAMH_QuanLyKhachSan.DAL_QLKS
{
    class ChiTietHoaDonDAO
    {
        DataHelper help = new DataHelper();

        public List<ChiTietHoaDon> getAllChiTietHoaDonByMaHD(string MaHD)
        {
            DataTable table = new DataTable();
            int n = 0;
            try
            {
                table = help.execeuteQuery("sp_TimChiTietHoaDonTheoMaHD '" + MaHD + "'");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<ChiTietHoaDon> listCTHD = new List<ChiTietHoaDon>();
                for(int i = 0 ; i < n ; i++)
                {
                    ChiTietHoaDon a = new ChiTietHoaDon();
                    a.TenPH = table.Rows[i][0].ToString();
                    a.DonGia = table.Rows[i][1].ToString();
                    a.NgayNhanPhong = table.Rows[i][2].ToString();
                    a.NgayTraPhong = (table.Rows[i][3].ToString() != null) ? table.Rows[i][3].ToString() : "";
                    a.TamTinh = (table.Rows[i][4].ToString() != null) ? table.Rows[i][4].ToString() : "";
                    a.PhuThu = (table.Rows[i][5].ToString() != null) ? table.Rows[i][5].ToString() : "";
                    a.ThanhTien = (table.Rows[i][6].ToString() != null) ? table.Rows[i][6].ToString() : "";

                    listCTHD.Add(a);
                }
                return listCTHD;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool updateChiTietHoaDonKhiDoiPhong(string MaHD, string TenPH)
        {
            try
            {
                help.executeNonQuery(string.Format("sp_capNhatCTHoaDonKhiDoiPhong '{0}',N'{1}'",MaHD,TenPH));
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool updateChiTietHoaDonKhiTraPhong(string MaHD, string TenPH)
        {
            try
            {
                help.executeNonQuery(string.Format("sp_capNhatChiTietHoaDonKhiTraPhong '{0}',N'{1}'", MaHD, TenPH));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int tinhSoPhongChuaTraCuaKhach(string MaHD)
        {
            DataTable table = new DataTable();
            try
            {
                table = help.execeuteQuery(string.Format("sp_tinhSoPhongChuaTraCuaKhach '{0}'",MaHD));
                return int.Parse(table.Rows[0][0].ToString());
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DataTable hienThiChiTietHoaDonTheoMaHD (string MaHD)
        {
            DataTable table = new DataTable();
            int n = 0;
            try
            {
                table = help.execeuteQuery("sp_HienThiChiTietHoaDonTheoMaHoaDon '" + MaHD + "'");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                return table;
            }    
            catch(Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
