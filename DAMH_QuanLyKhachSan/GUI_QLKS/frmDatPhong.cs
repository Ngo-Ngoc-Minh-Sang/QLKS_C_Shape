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
using System.Globalization;

namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    public partial class frmDatPhong : Form
    {
        PhongDaDatBLL qlyPHDaDat = new PhongDaDatBLL();
        string idDangNhap;
        public frmDatPhong()
        {
            InitializeComponent();
        }

        public frmDatPhong(string id)
        {
            InitializeComponent();
            idDangNhap = id;
        }
        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            dpkDateCheckIn.Value = DateTime.Now;
            dpkDateCheckOut.Value = DateTime.Now.AddDays(1);
            loadDataGridViewPhongDaDat();
        }

        public void loadDataGridViewPhongDaDat()
        {
            string NgayDen = dpkDateCheckIn.Value.ToString("dd/MM/yyyy");
            string NgayDi = dpkDateCheckOut.Value.ToString("dd/MM/yyyy");
            dataGridViewRoom.DataSource = qlyPHDaDat.getAllPhongDaDat(NgayDen, NgayDi);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemPhongDat_Click(object sender, EventArgs e)
        {
            loadDataGridViewPhongDaDat();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            frmCT_DatPhong ctDatPhong = new frmCT_DatPhong(this);
            ctDatPhong.ShowDialog();
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];
            if (DateTime.Compare(DateTime.Now, DateTime.ParseExact(row.Cells[4].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture)) <= 0)
            {
                btnXoa.Enabled = false;
                btnCapNhat.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa đặt phòng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow row = dataGridViewRoom.SelectedRows[0];
                    string TenKH = row.Cells[1].Value.ToString().Trim();
                    string TenPH = row.Cells[0].Value.ToString().Trim();
                    string NgayDen = row.Cells[4].Value.ToString().Trim();
                    qlyPHDaDat.deleteCTDatPhong(TenKH, TenPH, NgayDen);
                    MessageBox.Show("Đã xóa thành công thông tin đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGridViewPhongDaDat();
                }
                catch
                {
                    MessageBox.Show("Lỗi xóa thông tin đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn cập nhật thông tin đặt phòng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow row = dataGridViewRoom.SelectedRows[0];
                    string TenKH = row.Cells[1].Value.ToString().Trim();
                    string TenPH = row.Cells[0].Value.ToString().Trim();
                    string NgayDen = row.Cells[4].Value.ToString().Trim();
                    string MaDP = qlyPHDaDat.getMaDatPhongByName(TenKH, TenPH, NgayDen);
                    frmCT_DatPhong form = new frmCT_DatPhong(this, MaDP);
                    form.ShowDialog();
                    loadDataGridViewPhongDaDat();
                }
                catch
                {
                    MessageBox.Show("Lỗi xóa thông tin đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void nhanPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewRoom.SelectedRows[0];
            string TenKH = row.Cells[1].Value.ToString().Trim();
            string TenPH = row.Cells[0].Value.ToString().Trim();
            string NgayDen = row.Cells[4].Value.ToString().Trim();
            string MaDP = qlyPHDaDat.getMaDatPhongByName(TenKH, TenPH, NgayDen);

            frmCT_NhanPhong form = new frmCT_NhanPhong(this, "admin", MaDP);
            form.ShowDialog();
            loadDataGridViewPhongDaDat();
        }
    }
}
