using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using System.Data;

namespace DAMH_QuanLyKhachSan.DAL_QLKS
{
    class DichVuDAO
    {
        DataHelper help = new DataHelper();
        public List<tDichVu> getAllDichVu()
        {
            string sql = "select * from DICHVU";
            DataTable table = null;
            int n = 0;
            try
            {
                table = help.execeuteQuery(sql);
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tDichVu> listDv = new List<tDichVu>();
                for (int i = 0; i < n; i++)
                {
                    tDichVu dv = new tDichVu();
                    dv.MaDV = table.Rows[i][0].ToString();
                    dv.TenDV = table.Rows[i][1].ToString();
                    dv.MaLoaiDV = table.Rows[i][2].ToString();
                    dv.GiaDV = int.Parse(table.Rows[i][3].ToString());
                    listDv.Add(dv);
                }
                return listDv;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tDichVu> getAllDichVuByName(string name)
        {
            string sql = "sp_GetDichVuByName N'" + name + "'";
            DataTable table = null;
            int n = 0;

            try
            {
                table = help.execeuteQuery(sql);
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tDichVu> listDV = new List<tDichVu>();
                for (int i = 0; i < n; i++)
                {
                    tDichVu dv = new tDichVu();
                    dv.MaDV = table.Rows[i][0].ToString();
                    dv.TenDV = table.Rows[i][1].ToString();
                    dv.MaLoaiDV = table.Rows[i][2].ToString();
                    dv.GiaDV = int.Parse(table.Rows[i][3].ToString());
                    listDV.Add(dv);
                }
                return listDV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string bornKeyAuto()
        {
            string key = "";
            int count = getAllDichVu().Count() + 1;
            return "DV0" + count;
        }
        public bool AddDichVu(string tenDV, string maLoai, int gia)
        {
            try
            {
                string sql = "exec sp_InsertNewService '" + bornKeyAuto() + "', N'" + tenDV.Trim() + "', '" + maLoai.Trim() + "', " + gia + "";
                help.executeNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateService(string maDV, string tenDV, string loaiDV, int gia)
        {
            try
            {
                string sql = "exec sp_UpdateService '" + maDV.Trim() + "', N'" + tenDV.Trim() + "', '" + loaiDV.Trim() + "', " + gia + "";
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
