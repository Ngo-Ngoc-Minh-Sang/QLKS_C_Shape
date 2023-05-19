using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAMH_QuanLyKhachSan.DTO_QLKS;

namespace DAMH_QuanLyKhachSan.DAL_QLKS
{
    class KhachHangDAO
    {
        DataHelper help = new DataHelper();
        public List<KhachHangShort> getAllKhachHangByShort()
        {
            DataTable table = new DataTable();
            int n = 0;
            try
            {
                table = help.execeuteQuery("select TENKH,SDT, MAKH from KHACHHANG");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<KhachHangShort> listKH = new List<KhachHangShort>();
                for(int i = 0; i<n; i++)
                {
                    KhachHangShort a = new KhachHangShort();
                    a.TenKH = table.Rows[i][0].ToString();
                    a.DienThoai = table.Rows[i][1].ToString();
                    a.MaKH = table.Rows[i][2].ToString();

                    listKH.Add(a);
                }
                return listKH;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int getSDTByID (string id)
        {
            DataTable table = new DataTable();
            try
            {
                table = help.execeuteQuery("Select * from dbo.f_GetSDTByName('" + id + "')");
                return int.Parse(table.Rows[0][0].ToString());
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<tKhachHang> getAllKhachHang()
        {
            DataTable table = null;
            int n = 0;
            try
            {
                table = help.execeuteQuery("Select * from KHACHHANG");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tKhachHang> listKH = new List<tKhachHang>();
                for (int i = 0; i < n; i++)
                {
                    tKhachHang lkh = new tKhachHang();
                    lkh.MaKH = table.Rows[i][0].ToString();
                    lkh.TenKH = table.Rows[i][3].ToString();
                    lkh.CMND = table.Rows[i][1].ToString();
                    lkh.MaLoaiKH = table.Rows[i][2].ToString();
                    lkh.SDT = table.Rows[i][6].ToString();
                    lkh.DiaChi = table.Rows[i][5].ToString();
                    lkh.QuocTich = table.Rows[i][8].ToString();
                    listKH.Add(lkh);
                }
                return listKH;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tKhachHang> getAllKhachHangByKey(string mode, string var)
        {
            string sql = "exec sp_SearchCustomerByKey N'" + mode + "', N'" + var + "'";
            DataTable table = null;
            int n = 0;
            try
            {
                table = help.execeuteQuery(sql);
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tKhachHang> listKH = new List<tKhachHang>();
                for (int i = 0; i < n; i++)
                {
                    tKhachHang lkh = new tKhachHang();
                    lkh.MaKH = table.Rows[i][0].ToString();
                    lkh.TenKH = table.Rows[i][3].ToString();
                    lkh.CMND = table.Rows[i][1].ToString();
                    lkh.MaLoaiKH = table.Rows[i][2].ToString();
                    lkh.SDT = table.Rows[i][6].ToString();
                    lkh.DiaChi = table.Rows[i][5].ToString();
                    lkh.QuocTich = table.Rows[i][8].ToString();
                    listKH.Add(lkh);
                }
                return listKH;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tKhachHang selectKhachHang(string maKH)
        {
            string sql = "select * from KHACHHANG where MaKH = '" + maKH + "'";
            DataTable table = null;
            int n = 0;
            try
            {
                table = help.execeuteQuery(sql);
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                tKhachHang kh = new tKhachHang();
                kh.MaKH = table.Rows[0][0].ToString();
                kh.TenKH = table.Rows[0][3].ToString();
                kh.CMND = table.Rows[0][1].ToString();
                kh.MaLoaiKH = table.Rows[0][2].ToString();
                kh.SDT = table.Rows[0][6].ToString();
                kh.DiaChi = table.Rows[0][5].ToString();
                kh.QuocTich = table.Rows[0][8].ToString();
                kh.GioiTinh = table.Rows[0][7].ToString();
                kh.NgSinh = table.Rows[0][4].ToString();
                return kh;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string bornKeyAuto()
        {
            string key = "";
            int count = getAllKhachHang().Count() + 1;
            return "KH0" + count;
        }
        public bool AddKhachHang(string tenKH, string maLoaiKH, string cmnd, string ngSinh, string diaChi, string sdt, string gioiTinh, string quocTich)
        {
            try
            {
                string sql = "exec sp_InsertNewCustomer '" + bornKeyAuto() + "', N'" + tenKH + "', '" + cmnd + "', '" + maLoaiKH + "', '" + ngSinh + "', N'" + diaChi + "', '" + sdt + "', N'" + gioiTinh + "', N'" + quocTich + "'";
                help.executeNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateCustomer(string makh, string ten, string cmnd, string loai, string sdt, string dc, string qt, string gt, string ns)
        {
            try
            {
                string sql = "exec sp_UpdateCustomer '" + makh + "', N'" + ten + "', '" + cmnd + "', '" + loai + "', '" + sdt + "', N'" + dc + "' , N'" + qt + "', N'" + gt + "', '" + ns + "'";
                help.executeNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
