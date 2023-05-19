using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DAL_QLKS;
using DAMH_QuanLyKhachSan.DTO_QLKS;

namespace DAMH_QuanLyKhachSan.BLL_QLKS
{
    class PhongDaDatBLL
    {
        PhongDaDatDAO qlPH = new PhongDaDatDAO();
        public List<PhongDaDat> getAllPhongDaDat(string NgayDen, string NgayDi)
        {
            try
            {
                return qlPH.getAllPhongDaDat(NgayDen, NgayDi);
            }    
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool deleteCTDatPhong(string TenKH, string TenPH, string NgayDen)
        {
            try
            {
                return qlPH.deleteCTDatPhong(TenKH, TenPH, NgayDen);
            }
            catch(Exception EX)
            {
                throw EX;
            }
        }

        public string getMaDatPhongByName (string TenKH, string TenPH, string NgayDen)
        {
            try
            {
                return qlPH.getMaDatPhongByName(TenKH, TenPH, NgayDen);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string getMaDatPhongByNameAndTenPhong(string TenKH, string TenPH)
        {
            try
            {
                return qlPH.getMaDatPhongByNameAndTenPhong(TenKH, TenPH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
