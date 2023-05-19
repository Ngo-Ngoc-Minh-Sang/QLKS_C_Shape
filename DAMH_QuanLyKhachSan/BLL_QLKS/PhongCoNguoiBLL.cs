using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DAL_QLKS;
using DAMH_QuanLyKhachSan.DTO_QLKS;

namespace DAMH_QuanLyKhachSan.BLL_QLKS
{
    class PhongCoNguoiBLL
    {
        PhongCoNguoiDAO qlTraPhong = new PhongCoNguoiDAO();

        public List<PhongCoNguoi> getAllPhongCoNguoi()
        {
            try
            {
                return qlTraPhong.getAllPhongCoNguoi();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
