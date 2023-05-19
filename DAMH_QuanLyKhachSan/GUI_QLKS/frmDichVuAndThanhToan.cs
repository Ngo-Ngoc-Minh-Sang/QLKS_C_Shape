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
    public partial class frmDichVuAndThanhToan : Form
    {
        PhongCoNguoiBLL qlTraPhong = new PhongCoNguoiBLL();
        PhongDaDatBLL qlPhongDat = new PhongDaDatBLL();
        ChiTietHoaDonBLL qlChiTietHoaDon = new ChiTietHoaDonBLL();
        PhongBLL qlPhong = new PhongBLL();
        BindingList<TenPhong> listPHChon = new BindingList<TenPhong>();
        HoaDonBLL qlHoaDon = new HoaDonBLL();
        public frmDichVuAndThanhToan()
        {
            InitializeComponent();
        }

        public void loadDataPhongCoNguoi()
        {
            dataPhongCoNguoi.DataSource = qlTraPhong.getAllPhongCoNguoi();
        }

        private void frmDichVuAndThanhToan_Load(object sender, EventArgs e)
        {
            try
            {
                hienPhongDangDon();
                loadDataPhongCoNguoi();
            }
            catch
            {
                MessageBox.Show("Lỗi load dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataPhongCoNguoi.CurrentRow;
            string tenph = row.Cells[0].Value.ToString().Trim();
            string tenkh = row.Cells[1].Value.ToString().Trim();
            try
            {
                string mahd = qlPhongDat.getMaDatPhongByNameAndTenPhong(tenkh, tenph).Trim();
                qlChiTietHoaDon.updateChiTietHoaDonKhiTraPhong(mahd, tenph);
                dataPhongDaNhan.DataSource = qlChiTietHoaDon.getAllChiTietHoaDonByMaHD(mahd);
                loadDataPhongCoNguoi();
                hienPhongDangDon();

                if(qlChiTietHoaDon.tinhSoPhongChuaTraCuaKhach(mahd) == 0)
                {
                    MessageBox.Show("Khách đã trả hết phòng. Tiến hành thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    qlHoaDon.updateHoaDonKhiTraHetPhong(mahd);
                    frmCT_HoaDon formCTHoaDon = new frmCT_HoaDon(mahd);
                    formCTHoaDon.ShowDialog();
                }    
            }
            catch
            {
                MessageBox.Show("Lỗi không thể trả phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataPhongCoNguoi_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataPhongCoNguoi.CurrentRow;
            string tenph = row.Cells[0].Value.ToString().Trim();
            string tenkh = row.Cells[1].Value.ToString().Trim();
            try
            {
                string mahd = qlPhongDat.getMaDatPhongByNameAndTenPhong(tenkh, tenph);
                dataPhongDaNhan.DataSource = qlChiTietHoaDon.getAllChiTietHoaDonByMaHD(mahd);
            }
            catch
            {
                MessageBox.Show("Lỗi load dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void hienPhongDangDon()
        {
            try
            {
                if (qlPhong.getAllPhongDangDon() == null)
                {
                    dataPhongDangDon.DataSource = null;
                    //thietLapLaiThongSoDataGridView(dataPhongDangDon);
                    return;
                }
                dataPhongDangDon.DataSource = qlPhong.getTatCaPhongDangDon();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể chuyển phòng sang trạng thái dọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void doiPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataPhongCoNguoi.CurrentRow;
            string tenph = row.Cells[0].Value.ToString().Trim();
            string tenkh = row.Cells[1].Value.ToString().Trim();
            try
            {
                string mahd = qlPhongDat.getMaDatPhongByNameAndTenPhong(tenkh, tenph).Trim();
                qlChiTietHoaDon.updateChiTietHoaDonKhiDoiPhong(mahd, tenph);
                qlPhong.UpdateTinhTrangPhong(tenph);
                loadDataPhongCoNguoi();
                dataPhongDaNhan.DataSource = qlChiTietHoaDon.getAllChiTietHoaDonByMaHD(mahd);
                frmDoiPhong formDoiPhong = new frmDoiPhong(this, mahd);
                formDoiPhong.ShowDialog();
                hienPhongDangDon();
            }
            catch
            {
                MessageBox.Show("Lỗi load dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void thietLapLaiThongSoDataGridView(DataGridView data)
        {
            data.Columns[0].HeaderText = "Tên phòng";

            data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void donPhongXongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataPhongDangDon.CurrentRow;
            string tenph = row.Cells[0].Value.ToString().Trim();

            try
            {
                qlPhong.UpdateTinhTrangPhongSauKhiDonXong(tenph);
                hienPhongDangDon();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể cập nhật lại tình trạng phòng sau khi dọn phòng xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

       
    }
}
