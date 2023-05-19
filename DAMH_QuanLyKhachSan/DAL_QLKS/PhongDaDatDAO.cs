using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using System.Data;

namespace DAMH_QuanLyKhachSan.DAL_QLKS
{
    class PhongDaDatDAO
    {
        DataHelper help = new DataHelper();
        public List<PhongDaDat> getAllPhongDaDat(string NgayDen, string NgayDi)
        {
            DataTable table = new DataTable();
            int n = 0;
            try
            {
                table = help.execeuteQuery("set dateformat dmy execute sp_XuatPhongDaDat '" + NgayDen + "', '" + NgayDi + "'");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<PhongDaDat> listPHDat = new List<PhongDaDat>();
                for(int i = 0; i<n; i++)
                {
                    PhongDaDat ph = new PhongDaDat();
                    ph.TenPH = table.Rows[i][0].ToString();
                    ph.TenKH = table.Rows[i][1].ToString();
                    ph.TenLoai = table.Rows[i][2].ToString();
                    ph.DonGia = int.Parse(table.Rows[i][3].ToString());
                    ph.NgayDat = Convert.ToDateTime(table.Rows[i][4]).ToString("dd/MM/yyyy");
                    ph.NgayTra = Convert.ToDateTime(table.Rows[i][5]).ToString("dd/MM/yyyy");

                    listPHDat.Add(ph);
                }
                return listPHDat;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool deleteCTDatPhong(string TenKH, string TenPH, string NgayDen)
        {
            try
            {
                help.executeNonQuery(string.Format("set dateformat dmy execute sp_deleteCTDatPhong N'{0}', N'{1}', '{2}'", TenKH, TenPH, NgayDen));
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string getMaDatPhongByName(string TenKH, string TenPH, string NgayDen)
        {
            DataTable table = new DataTable();
            try
            {
                table = help.execeuteQuery(string.Format("set dateformat dmy execute sp_TimMaDatPhongTheoTenKH N'{0}', N'{1}', '{2}'", TenKH, TenPH, NgayDen));
                return table.Rows[0][0].ToString();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string getMaDatPhongByNameAndTenPhong(string TenKH, string TenPH)
        {
            DataTable table = new DataTable();
            try
            {
                table = help.execeuteQuery(string.Format("sp_TimMaHDTheoTenKHTenPh N'{0}', N'{1}'", TenKH, TenPH));
                return table.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
