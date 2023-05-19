using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using System.Data;

namespace DAMH_QuanLyKhachSan.DAL_QLKS
{
    class TinhTrangPhongDAO
    {
        DataHelper help = new DataHelper();
        public List<tTinhTrangPhong> getAllTinhTrangPhong()
        {
            DataTable table = new DataTable();
            int n = 0;

            try
            {
                table = help.execeuteQuery("Select * from TINHTRANGPHONG");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tTinhTrangPhong> listTTPh = new List<tTinhTrangPhong>();
                for(int i = 0; i< n; i++)
                {
                    tTinhTrangPhong tt = new tTinhTrangPhong();
                    tt.MaTT = int.Parse(table.Rows[i][0].ToString());
                    tt.TenTT = table.Rows[i][1].ToString();

                    listTTPh.Add(tt);
                }
                return listTTPh;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
