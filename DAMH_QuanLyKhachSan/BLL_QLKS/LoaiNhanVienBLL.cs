using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DAL_QLKS;
using DAMH_QuanLyKhachSan.DTO_QLKS;

namespace DAMH_QuanLyKhachSan.BLL_QLKS
{
    class LoaiNhanVienBLL
    {

        LoaiNhanVienDAO qllnv = new LoaiNhanVienDAO();

        public List<tLoaiNhanVen> getAllLoaiNhanVien()
        {
            try
            {
                return qllnv.getAllLoaiNhanVien();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string getNameLoaiNhanVienByUsername(string username)
        {
            try
            {
                return qllnv.getNameLoaiNhanVienByUserName(username);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
