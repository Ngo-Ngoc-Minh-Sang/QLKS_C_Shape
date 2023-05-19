using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAMH_QuanLyKhachSan.BLL_QLKS;
using DAMH_QuanLyKhachSan.DTO_QLKS;

namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    public partial class frmNhanPhong : Form
    {
        public frmNhanPhong()
        {
            InitializeComponent();
        }

        string MADP;
        frmDatPhong frmDatPhong = new frmDatPhong();
        BindingList<tPhongDat> listPHChon = new BindingList<tPhongDat>();
        KhachHangNhanPhongBLL qlKHNhanPhong = new KhachHangNhanPhongBLL();

        public frmNhanPhong(frmDatPhong form, string madp)
        {
            InitializeComponent();
            MADP = madp.Trim();
            frmDatPhong = form;
        }

        private void frmNhanPhong_Load(object sender, EventArgs e)
        {
            
        }

        public int tinhTongTienPhaiTra(DataGridView data)
        {
            int tong = 0;
            for(int i = 0; i<data.Rows.Count; i++)
            {
                tong += int.Parse(data.Rows[0].Cells[2].Value.ToString());
            }
            return tong;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReceiveRoom_Click(object sender, EventArgs e)
        {

        }
    }
}
