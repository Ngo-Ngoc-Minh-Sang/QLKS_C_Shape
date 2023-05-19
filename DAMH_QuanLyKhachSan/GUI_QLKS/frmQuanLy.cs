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
    public partial class frmQuanLy : Form
    {
        LoaiNhanVienBLL qllnv = new LoaiNhanVienBLL();
        tLoaiNhanVen lnv = new tLoaiNhanVen();
        private string userName;

        public frmQuanLy(string username)
        {
            this.userName = username;
            InitializeComponent();
        }

        public bool IsAdmin()
        {
            return qllnv.getNameLoaiNhanVienByUsername(userName) == "CD001";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tileQLPhong_Click(object sender, EventArgs e)
        {
            frmPhong phong = new frmPhong();
            phong.ShowDialog();
        }

        private void tileQLKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang khach = new frmKhachHang();
            khach.ShowDialog();
        }

        private void TileDatPhong_Click(object sender, EventArgs e)
        {
            frmDatPhong datph = new frmDatPhong(userName);
            datph.ShowDialog();
        }

        private void tileQLNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.ShowDialog();
        }

        private void tileQLDichVu_Click(object sender, EventArgs e)
        {
            frmDichVu dv = new frmDichVu();
            dv.ShowDialog();
        }

        private void tileNhanPhong_Click(object sender, EventArgs e)
        {
            frmCT_NhanPhong nph = new frmCT_NhanPhong(userName);
            nph.ShowDialog();
        }

        private void tileQlQuyDinh_Click(object sender, EventArgs e)
        {
            frmQuyDinh qdinh = new frmQuyDinh();
            qdinh.ShowDialog();
        }

        private void tilePay_Click(object sender, EventArgs e)
        {
            frmDichVuAndThanhToan dvuthanhtoan = new frmDichVuAndThanhToan();
            dvuthanhtoan.ShowDialog();
        }

        private void tileQlHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            hd.ShowDialog();
        }

        private void tileThongke_Click(object sender, EventArgs e)
        {
            frmDoanhThu dt = new frmDoanhThu();
            dt.ShowDialog();
        }

        private void btnAccountProfile_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan prf = new frmThongTinCaNhan();
            prf.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
