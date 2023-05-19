using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using System.Data;

namespace DAMH_QuanLyKhachSan.DAL_QLKS
{
    class PhongCoNguoiDAO
    {
        DataHelper help = new DataHelper();

        public List<PhongCoNguoi> getAllPhongCoNguoi()
        {
            DataTable table = new DataTable();
            int n = 0;
            string maHD = layMaHD_Cuoi();
            try
            {
                table = help.execeuteQuery("sp_HienThiPhongCoNguoi " + "'" + maHD + "'");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<PhongCoNguoi> listPHCoNguoi = new List<PhongCoNguoi>();
                for(int i = 0; i<n; i++)
                {
                    PhongCoNguoi a = new PhongCoNguoi();
                    a.TenPhong = table.Rows[i][0].ToString();
                    a.TenKhach = table.Rows[i][1].ToString();

                    listPHCoNguoi.Add(a);
                }
                return listPHCoNguoi;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public string layMaHD_Cuoi()
        {
            DataTable dt = new DataTable();
            string strMHD = "HD00";
            string query = "select count(*) from HOADON";
            dt = help.execeuteQuery(query);
            int so = dt.Rows.Count;
            strMHD += so;
            return strMHD;
        }
    }
}
