using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DAL_QLKS;
using DAMH_QuanLyKhachSan.DTO_QLKS;

namespace DAMH_QuanLyKhachSan.BLL_QLKS
{
    class LoaiDichVuBLL
    {
        LoaiDichVuDAO qlldv = new LoaiDichVuDAO();
        public List<tLoaiDichVu> getAllLoaiDV()
        {
            try
            {
                return qlldv.getAllLoaiDV();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tLoaiDichVu> getAllLoaiDichVuByName(string name)
        {
            try
            {
                return qlldv.getAllLoaiDichVuByName(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddNewTypeService(string tenDV)
        {
            try
            {
                return qlldv.AddLoaiDichVu(tenDV);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateTypeService(string maLoaiDV, string tenLoaiDV)
        {
            try
            {
                return qlldv.UpdateTypeService(maLoaiDV, tenLoaiDV);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
