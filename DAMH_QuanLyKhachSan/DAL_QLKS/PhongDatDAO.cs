using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using System.Data;

namespace DAMH_QuanLyKhachSan.DAL_QLKS
{
    class PhongDatDAO
    {
        DataHelper help = new DataHelper();

        public List<tPhongDat> getAllPhongChuaDat(string ngaydat, string ngaydi)
        {
            DataTable table = new DataTable();
            int n = 0;
            try
            {
                table = help.execeuteQuery("sp_HienPhongTrong '" + ngaydat + "', '" + ngaydi + "'");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tPhongDat> listPHDaDat = new List<tPhongDat>();
                for (int i = 0; i < n; i++)
                {
                    tPhongDat ph = new tPhongDat();
                    ph.TenPH = table.Rows[i][0].ToString();
                    ph.LoaiPH = table.Rows[i][1].ToString();
                    ph.DonGia = int.Parse(table.Rows[i][2].ToString());

                    listPHDaDat.Add(ph);
                }
                return listPHDaDat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool addNewDatPhong(string MaKH, string NgayDen, string NgayDi)
        {
            try
            {
                help.executeNonQuery(string.Format("sp_InsertNewDatPhong '{0}','{1}','{2}'", MaKH, NgayDen, NgayDi));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool addNewDonNhanPhong(string MaKH, string TenDN)
        {
            try
            {
                help.executeNonQuery(string.Format("sp_InsertNewDonDatPhong '{0}','{1}'", MaKH, TenDN));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool updateDatPhongByMaDP(string MADP, string NgayDen, string NgayDi)
        {
            try
            {
                help.executeNonQuery(string.Format("set dateformat dmy execute sp_UpdateDonDatPhongByMaDP '{0}','{1}','{2}'", MADP, NgayDen, NgayDi));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool addNewCTDatPhong(string MaPH, int SoNgayO, int DonGia)
        {
            try
            {
                help.executeNonQuery(String.Format("sp_InsertNewCTDatPhong N'{0}',{1},{2}", MaPH, SoNgayO, DonGia));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tPhongDat> getPhongDaDatByMaDP(string Madp)
        {
            DataTable table = new DataTable();
            int n = 0;
            try
            {
                table = help.execeuteQuery(string.Format("sp_HienPhongDaDatShortByMaDP '{0}'", Madp));
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tPhongDat> listPHDaDat = new List<tPhongDat>();
                for (int i = 0; i < n; i++)
                {
                    tPhongDat ph = new tPhongDat();
                    ph.TenPH = table.Rows[i][0].ToString();
                    ph.LoaiPH = table.Rows[i][1].ToString();
                    ph.DonGia = int.Parse(table.Rows[i][2].ToString());

                    listPHDaDat.Add(ph);
                }
                return listPHDaDat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool deleteCTDatPhongByMaDP(string MADP)
        {
            try
            {
                help.executeNonQuery("sp_deleteCTDatPhongByMaDP '" + MADP + "'");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool addNewCTDatPhongByMaDP(string MADP, string MaPH, int SoNgayO, int DonGia)
        {
            try
            {
                help.executeNonQuery(String.Format("sp_InsertNewCTDatPhongByMaDP '{0}',N'{1}',{2},{3}", MADP, MaPH, SoNgayO, DonGia));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string getMaHoaDonCuoi()
        {
            DataTable table = new DataTable();
            int n = 0;
            try
            {
                table = help.execeuteQuery(String.Format("sp_GetMaHoaDonCuoi"));
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                return table.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool addNewCTNhanPhong(string MaHD, string TenPH)
        {
            try
            {
                help.executeNonQuery(String.Format("sp_InsertNewCTHoaDon '{0}',N'{1}'", MaHD, TenPH));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> getAllMaDP()
        {
            DataTable table = new DataTable();
            int n = 0;
            try
            {
                table = help.execeuteQuery("sp_GetAllMaDP");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<string> listMaDP = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    string maph = table.Rows[i][0].ToString();
                    listMaDP.Add(maph);
                }
                return listMaDP;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool updateTinhTrangDonDatPhong(string MaDP)
        {
            try
            {
                help.executeNonQuery("update DATPHONG set MATTDATPHONG = 2 where MaDP = '" + MaDP + "'");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
