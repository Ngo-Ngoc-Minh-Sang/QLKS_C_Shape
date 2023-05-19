using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMH_QuanLyKhachSan.DTO_QLKS;
using System.Data;

namespace DAMH_QuanLyKhachSan.DAL_QLKS
{
    class LoaiDichVuDAO
    {
        DataHelper help = new DataHelper();
        public List<tLoaiDichVu> getAllLoaiDV()
        {
            string sql = "select * from LOAIDICHVU";
            DataTable table = null;
            int n = 0;
            try
            {
                table = help.execeuteQuery(sql);
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tLoaiDichVu> listLdv = new List<tLoaiDichVu>();
                for (int i = 0; i < n; i++)
                {
                    tLoaiDichVu dv = new tLoaiDichVu();
                    dv.MaDV = table.Rows[i][0].ToString();
                    dv.TenDV = table.Rows[i][1].ToString();

                    listLdv.Add(dv);
                }
                return listLdv;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tLoaiDichVu> getAllLoaiDichVuByName(string name)
        {
            string sql = "sp_GetLoaiDichVuByName N'" + name + "'";
            DataTable table = null;
            int n = 0;

            try
            {
                table = help.execeuteQuery(sql);
                n = table.Rows.Count;
                if (n == 0)
                    return null;
                List<tLoaiDichVu> listLoaiDV = new List<tLoaiDichVu>();
                for (int i = 0; i < n; i++)
                {
                    tLoaiDichVu ldv = new tLoaiDichVu();
                    ldv.MaDV = table.Rows[i][0].ToString();
                    ldv.TenDV = table.Rows[i][1].ToString();
                    listLoaiDV.Add(ldv);
                }
                return listLoaiDV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string bornKeyAuto()
        {
            string key = "";
            int count = getAllLoaiDV().Count() + 1;
            return "LV00" + count;
        }
        public bool AddLoaiDichVu(string tenDV)
        {
            try
            {
                string sql = "exec sp_InsertNewTypeService '" + bornKeyAuto() + "', N'" + tenDV.Trim() + "'";
                help.executeNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateTypeService(string maLoaiDV, string tenLoaiDV)
        {
            try
            {
                string sql = "exec sp_UpdateTypeService '" + maLoaiDV.Trim() + "', N'" + tenLoaiDV.Trim() + "'";
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
