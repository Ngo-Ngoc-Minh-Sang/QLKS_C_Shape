using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DAL_QLKS;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using System.Data;

namespace DAMH_QuanLyKhachSan.BLL_QLKS
{
    class ChiTietHoaDonBLL
    {
        ChiTietHoaDonDAO qlChiTietHoaDon = new ChiTietHoaDonDAO();

        public List<ChiTietHoaDon> getAllChiTietHoaDonByMaHD (string MaHD)
        {
            try
            {
                return qlChiTietHoaDon.getAllChiTietHoaDonByMaHD(MaHD);
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
                return qlChiTietHoaDon.updateChiTietHoaDonKhiDoiPhong(MaHD, TenPH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool updateChiTietHoaDonKhiTraPhong(string MaHD, string TenPH)
        {
            try
            {
                return qlChiTietHoaDon.updateChiTietHoaDonKhiTraPhong(MaHD, TenPH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int tinhSoPhongChuaTraCuaKhach(string MaHD)
        {
            try
            {
                return qlChiTietHoaDon.tinhSoPhongChuaTraCuaKhach(MaHD);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable hienThiChiTietHoaDonTheoMaHD(string MaHD)
        {
            try
            {
                return qlChiTietHoaDon.hienThiChiTietHoaDonTheoMaHD(MaHD);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
