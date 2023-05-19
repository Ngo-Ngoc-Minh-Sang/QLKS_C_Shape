using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DAL_QLKS;
using DAMH_QuanLyKhachSan.DTO_QLKS;
namespace DAMH_QuanLyKhachSan.BLL_QLKS
{
    class NhanVienBLL
    {
        NhanVienDAO qlnv = new NhanVienDAO();
        public List<tNhanVien> getAllNhanVien()
        {
            try
            {
                return qlnv.getAllNhanVien();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tNhanVien> getAllNhanVienByUserName(string username)
        {
            try
            {
                return qlnv.getAllNhanVienUserName(username);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //reset pass
        public bool ResetPassword(string username, string hasspass)
        {
            try
            {
                return qlnv.ResetPassword(username, hasspass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //add
        public bool AddNewNhanVien(string TenDangNhap, string TenNV, string MatKhau, string MaLoaiNV, string CMND, DateTime NgaySinh, string GioiTinh,
      string DiaChi, int SDT, DateTime NgayVaoLam)
        {
            try
            {

                return qlnv.AddNhanVien(TenDangNhap, TenNV, MatKhau, MaLoaiNV, CMND, NgaySinh, GioiTinh, DiaChi, SDT, NgayVaoLam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Update
        public bool UpdateNewNhanVien(string TenDangNhap, string TenNV, string MaLoaiNV, string CMND, DateTime NgaySinh, string GioiTinh,
      string DiaChi, int SDT, DateTime NgayVaoLam)
        {
            try
            {

                return qlnv.UpdateNhanVien(TenDangNhap, TenNV, MaLoaiNV, CMND, NgaySinh, GioiTinh, DiaChi, SDT, NgayVaoLam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Đăng nhập
        public bool Login(string TenDangNhap, string MatKhau)
        {
            try
            {
                return qlnv.DangNhap(TenDangNhap, MatKhau);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
