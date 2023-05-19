using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using DAMH_QuanLyKhachSan.DAL_QLKS;

namespace DAMH_QuanLyKhachSan.BLL_QLKS
{
    class PhongDatBLL
    {
        PhongDatDAO qlphdat = new PhongDatDAO();

        public List<tPhongDat> getAllPhongTrong(string NgayDen, string NgayDi)
        {
            try
            {
                return qlphdat.getAllPhongChuaDat(NgayDen, NgayDi);
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
                return qlphdat.addNewDonNhanPhong(MaKH, TenDN);
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
                return qlphdat.addNewDatPhong(MaKH, NgayDen, NgayDi);
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
                return qlphdat.updateDatPhongByMaDP(MADP, NgayDen, NgayDi);
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
                return qlphdat.addNewCTDatPhong(MaPH, SoNgayO, DonGia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tPhongDat> getPhongDatByMaDP(string MADP)
        {
            try
            {
                return qlphdat.getPhongDaDatByMaDP(MADP);
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
                return qlphdat.deleteCTDatPhongByMaDP(MADP);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool addNewCTDatPhongByMaDP(string MaDP, string MaPH, int SoNgayO, int DonGia)
        {
            try
            {
                return qlphdat.addNewCTDatPhongByMaDP(MaDP, MaPH, SoNgayO, DonGia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string getMaHoaDonCuoi()
        {
            try
            {
                return qlphdat.getMaHoaDonCuoi();
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
                return qlphdat.addNewCTNhanPhong(MaHD, TenPH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> getAllMaDP()
        {
            try
            {
                return qlphdat.getAllMaDP();
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
                qlphdat.updateTinhTrangDonDatPhong(MaDP);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
