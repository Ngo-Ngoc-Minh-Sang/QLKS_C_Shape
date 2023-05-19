using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using System.Data;

namespace DAMH_QuanLyKhachSan.DAL_QLKS
{
    class LoaiPhongDAOcs
    {
        DataHelper help = new DataHelper();
        public List<tLoaiPhong> getAllLoaiPhong()
        {
            DataTable table = null;
            int n = 0;
            try
            {
                table = help.execeuteQuery("Select * from LOAIPHONG");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tLoaiPhong> listLoaiPh = new List<tLoaiPhong>();
                for(int i=0; i<n; i++)
                {
                    tLoaiPhong lph = new tLoaiPhong();
                    lph.MaLoaiPH = table.Rows[i][0].ToString();
                    lph.TenLoaiPH = table.Rows[i][1].ToString();
                    lph.GiaPH = int.Parse(table.Rows[i][2].ToString());
                    lph.SoNguoiTD = int.Parse(table.Rows[i][3].ToString());

                    listLoaiPh.Add(lph);
                }
                return listLoaiPh;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public tLoaiPhong getLoaiPhongByID(string id)
        {
            DataTable table = null;
            int n = 0;

            try
            {
                table = help.execeuteQuery("Select * from LOAIPHONG where MALOAIPHONG = '" + id.TrimEnd() + "'");
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                tLoaiPhong loaiph = new tLoaiPhong();
                loaiph.MaLoaiPH = table.Rows[0][0].ToString();
                loaiph.TenLoaiPH = table.Rows[0][1].ToString();
                loaiph.GiaPH = int.Parse(table.Rows[0][2].ToString());
                loaiph.SoNguoiTD = int.Parse(table.Rows[0][3].ToString());

                return loaiph;
            }    
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
