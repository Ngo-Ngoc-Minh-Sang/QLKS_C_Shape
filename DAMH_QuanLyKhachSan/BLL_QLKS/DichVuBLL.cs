using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DAL_QLKS;
using DAMH_QuanLyKhachSan.DTO_QLKS;

namespace DAMH_QuanLyKhachSan.BLL_QLKS
{
    class DichVuBLL
    {
        DichVuDAO qldv = new DichVuDAO();
        public List<tDichVu> getAllDichVu()
        {
            try
            {
                return qldv.getAllDichVu();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tDichVu> getAllDichVuByName(string name)
        {
            try
            {
                return qldv.getAllDichVuByName(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddNewService(string tenDV, string maLoai, int gia)
        {
            try
            {
                return qldv.AddDichVu(tenDV, maLoai, gia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateService(string maDV, string tenDV, string loaiDV, int gia)
        {
            try
            {
                return qldv.UpdateService(maDV, tenDV, loaiDV, gia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
