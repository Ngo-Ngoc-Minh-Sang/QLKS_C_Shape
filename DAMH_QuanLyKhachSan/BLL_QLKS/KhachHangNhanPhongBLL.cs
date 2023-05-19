using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DAL_QLKS;
using DAMH_QuanLyKhachSan.DTO_QLKS;

namespace DAMH_QuanLyKhachSan.BLL_QLKS
{
    class KhachHangNhanPhongBLL
    {
        KhachHangNhanPhongDAO qlKHNhanPhong = new KhachHangNhanPhongDAO();

        public KhachHangNhanPhong selectKhachHang(string madp)
        {
            try
            {
                return qlKHNhanPhong.getKhachHangNP(madp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
