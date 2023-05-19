using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using DAMH_QuanLyKhachSan.DAL_QLKS;

namespace DAMH_QuanLyKhachSan.BLL_QLKS
{
    class KhachHangBLL
    {
        KhachHangDAO qlKH = new KhachHangDAO();
        public List<KhachHangShort> getAllKhachHangShort()
        {
            try
            {
                return qlKH.getAllKhachHangByShort();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int getSDTByID(string id)
        {
            try
            {
                return qlKH.getSDTByID(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<tKhachHang> getAllKhachHang()
        {
            try
            {
                return qlKH.getAllKhachHang();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tKhachHang> getAllDichVuByKey(string mode, string var)
        {
            try
            {
                return qlKH.getAllKhachHangByKey(mode, var);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tKhachHang selectKhachHang(string maKH)
        {
            try
            {
                return qlKH.selectKhachHang(maKH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool insertNewCustomer(string tenKH, string maLoaiKH, string cmnd, string ngSinh, string diaChi, string sdt, string gioiTinh, string quocTich)
        {
            try
            {
                return qlKH.AddKhachHang(tenKH, maLoaiKH, cmnd, ngSinh, diaChi, sdt, gioiTinh, quocTich);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateCutomer(string makh, string ten, string cmnd, string loai, string sdt, string dc, string qt, string gt, string ns)
        {
            try
            {
                return qlKH.UpdateCustomer(makh, ten, cmnd, loai, sdt, dc, qt, gt, ns);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
