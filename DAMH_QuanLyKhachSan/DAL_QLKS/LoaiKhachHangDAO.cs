using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using System.Data;

namespace DAMH_QuanLyKhachSan.DAL_QLKS
{
    class LoaiKhachHangDAO
    {
        DataHelper help = new DataHelper();
        public List<tLoaiKhachHang> getAllLoaiKH()
        {
            string sql = "select * from LOAIKHACHHANG";
            DataTable table = null;
            int n = 0;
            try
            {
                table = help.execeuteQuery(sql);
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tLoaiKhachHang> listLKH = new List<tLoaiKhachHang>();
                for (int i = 0; i < n; i++)
                {
                    tLoaiKhachHang kh = new tLoaiKhachHang();
                    kh.MaLoaiKH = table.Rows[i][0].ToString();
                    kh.LoaiKH = table.Rows[i][1].ToString();

                    listLKH.Add(kh);
                }
                return listLKH;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
