using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using System.Data;

namespace DAMH_QuanLyKhachSan.DAL_QLKS
{
    class NhanVienDAO
    {
        DataHelper help = new DataHelper();
        public List<tNhanVien> getAllNhanVien()
        {
            string sql = "sp_GetAllNhanVien";
            DataTable table = null;
            int n = 0;

            try
            {
                table = help.execeuteQuery(sql);
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tNhanVien> listPh = new List<tNhanVien>();
                for (int i = 0; i < n; i++)
                {
                    tNhanVien nv = new tNhanVien();
                    nv.TenDangNhap = table.Rows[i][0].ToString();
                    nv.TenNV = table.Rows[i][1].ToString();
                    nv.MatKhau = table.Rows[i][2].ToString();
                    nv.MaLoaiNV = table.Rows[i][3].ToString();
                    nv.CMND = table.Rows[i][4].ToString();
                    nv.ngaySinh = DateTime.Parse(table.Rows[i][5].ToString());
                    nv.GioiTinh = table.Rows[i][6].ToString();
                    nv.DiaChi = table.Rows[i][7].ToString();
                    nv.SDT = int.Parse(table.Rows[i][8].ToString());
                    nv.NgayVaoLam = DateTime.Parse(table.Rows[i][9].ToString());
                    nv.TenLoaiNV = table.Rows[i][10].ToString();

                    listPh.Add(nv);
                }
                return listPh;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public List<tNhanVien> getAllNhanVienUserName(string username)
        {
            string sql = "sp_SearchNhanVienByKey N'" + username + "'";
            DataTable table = null;
            int n = 0;
            try
            {
                table = help.execeuteQuery(sql);
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tNhanVien> listPh = new List<tNhanVien>();
                for (int i = 0; i < n; i++)
                {
                    tNhanVien nv = new tNhanVien();
                    nv.TenDangNhap = table.Rows[i][0].ToString();
                    nv.TenNV = table.Rows[i][1].ToString();
                    nv.MatKhau = table.Rows[i][2].ToString();
                    nv.MaLoaiNV = table.Rows[i][3].ToString();
                    nv.CMND = table.Rows[i][4].ToString();
                    nv.ngaySinh = DateTime.Parse(table.Rows[i][5].ToString());
                    nv.GioiTinh = table.Rows[i][6].ToString();
                    nv.DiaChi = table.Rows[i][7].ToString();
                    nv.SDT = int.Parse(table.Rows[i][8].ToString());
                    nv.NgayVaoLam = DateTime.Parse(table.Rows[i][9].ToString());
                    nv.TenLoaiNV = table.Rows[i][10].ToString();
                    listPh.Add(nv);
                }
                return listPh;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ResetPassword(string TenDangNhap, string MatKhau)
        {
            try
            {
                help.executeNonQuery("sp_UpdateMatKhau '" + TenDangNhap + "','" + MatKhau + "'");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Thêm
        public bool AddNhanVien(string TenDangNhap, string TenNV, string MatKhau, string MaLoaiNV, string CMND, DateTime NgaySinh, string GioiTinh,
            string DiaChi, int SDT, DateTime NgayVaoLam)
        {
            try
            {

                help.executeNonQuery("sp_InsertNhanVien '" + TenDangNhap + "', N'" + TenNV + "','" + MatKhau + "','" + MaLoaiNV + "','" + CMND + "','" + NgaySinh + "',N'" + GioiTinh + "',N'" + DiaChi + "','" + SDT + "','" + NgayVaoLam + "'");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Update
        public bool UpdateNhanVien(string TenDangNhap, string TenNV, string MaLoaiNV, string CMND, DateTime NgaySinh, string GioiTinh, string DiaChi, int SDT, DateTime NgayVaoLam)
        {
            try
            {
                help.executeNonQuery("sp_UpdateNhanVien'" + TenDangNhap + "', N'" + TenNV + "','" + MaLoaiNV + "','" + CMND + "','" + NgaySinh + "','" + GioiTinh + "',N'" + DiaChi + "','" + SDT + "','" + NgayVaoLam + "' ");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Account
        public bool DangNhap(string TenDangNhap, string MatKhau)
        {
           
            string sql = "sp_DangNhap'" + TenDangNhap + "', '" + MatKhau + "'";
            DataTable table = null;
            int n = 0;
            try
            {
                table = help.execeuteQuery(sql);
                n = table.Rows.Count;
                if (n == 0)
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
