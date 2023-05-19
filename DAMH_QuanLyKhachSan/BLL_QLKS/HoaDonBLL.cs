using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DAL_QLKS;
using DAMH_QuanLyKhachSan.DTO_QLKS;

namespace DAMH_QuanLyKhachSan.BLL_QLKS
{
    class HoaDonBLL
    {
        HoaDonDAO qlHD = new HoaDonDAO();

        public HoaDon getHoaDonByHoaDonID(string MaHD)
        {
            try
            {
                return qlHD.getHoaDonTheoMaHD(MaHD);
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
                return qlHD.updateHoaDonKhiTraHetPhong(MaHD);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
