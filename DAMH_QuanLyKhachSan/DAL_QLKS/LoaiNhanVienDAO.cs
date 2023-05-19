using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using System.Data;

namespace DAMH_QuanLyKhachSan.DAL_QLKS
{
    class LoaiNhanVienDAO
    {
        DataHelper help = new DataHelper();
        public List<tLoaiNhanVen> getAllLoaiNhanVien()
        {
            DataTable table = null;
            int n = 0;
            try
            {
                table = help.execeuteQuery("Select * from LOAINHANVIEN");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tLoaiNhanVen> listLoaiNv = new List<tLoaiNhanVen>();
                for (int i = 0; i < n; i++)
                {
                    tLoaiNhanVen lnv = new tLoaiNhanVen();
                    lnv.MaLoaiNV = table.Rows[i][0].ToString();
                    lnv.TenLoaiNV = table.Rows[i][1].ToString();
                    listLoaiNv.Add(lnv);
                }
                return listLoaiNv;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string getNameLoaiNhanVienByUserName(string username)
        {
            DataTable table = null;
            int n = 0;
            try
            {
                table = help.execeuteQuery("SP_GetNameLoaiNhanVienByUserName '" + username + "'");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                return table.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
 

    }
}
