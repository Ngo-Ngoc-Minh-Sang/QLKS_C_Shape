using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DAL_QLKS;
using DAMH_QuanLyKhachSan.DTO_QLKS;

namespace DAMH_QuanLyKhachSan.BLL_QLKS
{
    class PhongBLL
    {
        PhongDAO qlph = new PhongDAO();
        public List<tPhong> getAllPhong()
        {
            try
            {
                return qlph.getAllPhong();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<tPhong> getAllPhongByID(string id)
        {
            try
            {
                return qlph.getAllPhongByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tPhong> getAllPhongByName(string name)
        {
            try
            {
                return qlph.getAllPhongByName(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddNewPhong(string TenPH, string MaLoaiPH)
        {
            try
            {
                return qlph.AddPhong(TenPH, MaLoaiPH);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdatePhong (string tenPH, string MaLoaiPH, string MAPH)
        {
            try
            {
                return qlph.UpdatePhong(tenPH, MaLoaiPH, MAPH);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateTinhTrangPhong(string tenPH)
        {
            try
            {
                return qlph.UpdateTinhTrangPhong(tenPH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tPhong> getAllPhongDangDon()
        {
            try
            {
                return qlph.getAllPhongDangDoc();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateTinhTrangPhongSauKhiDonXong(string tenPH)
        {
            try
            {
                return qlph.UpdateTinhTrangPhongSauKhiDonXong(tenPH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TenPhong> getTatCaPhongDangDon()
        {
            try
            {
                return qlph.getAllPhongDangDon();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
