using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DAL_QLKS;
using DAMH_QuanLyKhachSan.DTO_QLKS;

namespace DAMH_QuanLyKhachSan.BLL_QLKS
{
    class LoaiKhachHangBLL
    {
        LoaiKhachHangDAO qllkh = new LoaiKhachHangDAO();
        public List<tLoaiKhachHang> getAllLoaiKH()
        {
            try
            {
                return qllkh.getAllLoaiKH();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
