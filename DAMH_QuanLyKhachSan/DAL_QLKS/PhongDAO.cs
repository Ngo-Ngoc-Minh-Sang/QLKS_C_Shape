using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using System.Data;

namespace DAMH_QuanLyKhachSan.DAL_QLKS
{
    class PhongDAO
    {
        DataHelper help = new DataHelper();
        public List<tPhong> getAllPhong()
        {
            string sql = "sp_GetAllPhong";
            DataTable table = null;
            int n = 0;

            try
            {
                table = help.execeuteQuery(sql);
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tPhong> listPh = new List<tPhong>();
                for(int i = 0; i<n; i++)
                {
                    tPhong ph = new tPhong();
                    ph.MaPh = table.Rows[i][0].ToString();
                    ph.TenPh = table.Rows[i][1].ToString();
                    ph.MaLoaiPh = table.Rows[i][2].ToString();
                    ph.MaTT = int.Parse(table.Rows[i][3].ToString());
                    ph.GiaPH = int.Parse(table.Rows[i][4].ToString());
                    ph.SoNguoiTD = int.Parse(table.Rows[i][5].ToString());
                    ph.TenLoaiPH = table.Rows[i][6].ToString();
                    ph.TenTT = table.Rows[i][7].ToString();

                    listPh.Add(ph);
                }
                return listPh;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<tPhong> getAllPhongByID(string id)
        {
            string sql = "sp_GetPhongById " + id;
            DataTable table = null;
            int n = 0;

            try
            {
                table = help.execeuteQuery(sql);
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tPhong> listPh = new List<tPhong>();
                for (int i = 0; i < n; i++)
                {
                    tPhong ph = new tPhong();
                    ph.MaPh = table.Rows[i][0].ToString();
                    ph.TenPh = table.Rows[i][1].ToString();
                    ph.MaLoaiPh = table.Rows[i][2].ToString();
                    ph.MaTT = int.Parse(table.Rows[i][3].ToString());
                    ph.GiaPH = int.Parse(table.Rows[i][4].ToString());
                    ph.SoNguoiTD = int.Parse(table.Rows[i][5].ToString());
                    ph.TenLoaiPH = table.Rows[i][6].ToString();
                    ph.TenTT = table.Rows[i][7].ToString();

                    listPh.Add(ph);
                }
                return listPh;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tPhong> getAllPhongByName(string name)
        {
            string sql = "sp_GetPhongByName N'" + name + "'";
            DataTable table = null;
            int n = 0;

            try
            {
                table = help.execeuteQuery(sql);
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tPhong> listPh = new List<tPhong>();
                for (int i = 0; i < n; i++)
                {
                    tPhong ph = new tPhong();
                    ph.MaPh = table.Rows[i][0].ToString();
                    ph.TenPh = table.Rows[i][1].ToString();
                    ph.MaLoaiPh = table.Rows[i][2].ToString();
                    ph.MaTT = int.Parse(table.Rows[i][3].ToString());
                    ph.GiaPH = int.Parse(table.Rows[i][4].ToString());
                    ph.SoNguoiTD = int.Parse(table.Rows[i][5].ToString());
                    ph.TenLoaiPH = table.Rows[i][6].ToString();
                    ph.TenTT = table.Rows[i][7].ToString();

                    listPh.Add(ph);
                }
                return listPh;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddPhong (string tenPH, string MaLoaiPH)
        {
            try
            {
                help.executeNonQuery("sp_InsertNewPhong N'" + tenPH + "', '" + MaLoaiPH.Trim()+"'");
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdatePhong(string tenPH, string MaLoaiPH, string MAPH)
        {
            try
            {
                help.executeNonQuery("update PHONG set TENPH = N'" + tenPH + "', MALOAIPHONG = '" + MaLoaiPH.Trim() + "' where MaPH = '" + MAPH.Trim() + "'");
                return true;
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
                help.executeNonQuery(string.Format("sp_capNhatTrangThaiPhongSauKhiTraDoiPhong N'{0}'",tenPH));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tPhong> getAllPhongDangDoc()
        {
            DataTable table = new DataTable();
            int n = 0;
            try
            {
                table = help.execeuteQuery("Select Tenph from PHONG where MATT = 3");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tPhong> listPhong = new List<tPhong>();
                for(int i = 0; i < n; i++)
                {
                    tPhong a = new tPhong();
                    a.TenPh = table.Rows[i][0].ToString();
                    listPhong.Add(a);
                }
                return listPhong;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateTinhTrangPhongSauKhiDonXong(string tenPH)
        {
            try
            {
                help.executeNonQuery(string.Format("sp_CapNhatTinhTrangPhongSauKhiDonXong N'{0}'", tenPH));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TenPhong> getAllPhongDangDon()
        {
            DataTable table = new DataTable();
            int n = 0;
            try
            {
                table = help.execeuteQuery("Select Tenph from PHONG where MATT = 3");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<TenPhong> listPhong = new List<TenPhong>();
                for (int i = 0; i < n; i++)
                {
                    TenPhong a = new TenPhong();
                    a.TenPH = table.Rows[i][0].ToString();

                    listPhong.Add(a);
                }
                return listPhong;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
