using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DAL_QLKS;
using DAMH_QuanLyKhachSan.DTO_QLKS;

namespace DAMH_QuanLyKhachSan.BLL_QLKS
{
    class LoaiPhongBLL
    {
        LoaiPhongDAOcs qllp = new LoaiPhongDAOcs();

        public List<tLoaiPhong> getAllLoaiPhong()
        {
            try
            {
                return qllp.getAllLoaiPhong();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public tLoaiPhong getLoaiPhongByID (string id)
        {
            try
            {
                return qllp.getLoaiPhongByID(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
