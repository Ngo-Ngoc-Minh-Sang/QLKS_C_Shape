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
    public partial class frmCT_NhanPhong : Form
    {
        bool first = true;
        frmDatPhong formDP;
        string MaDP;
        PhongDatBLL qlphdat = new PhongDatBLL();
        KhachHangNhanPhongBLL qlKHNhanPhong = new KhachHangNhanPhongBLL();
        BindingList<tPhongDat> listPHChon = new BindingList<tPhongDat>();
        BindingList<tPhongDat> listPHTrong = new BindingList<tPhongDat>();
        KhachHangBLL qlKH = new KhachHangBLL();
        string idDangNhap = "admin";

        public frmCT_NhanPhong()
        {
            InitializeComponent();
        }

        public frmCT_NhanPhong(frmDatPhong form, string madp)
        {
            InitializeComponent();
            formDP = form;
            MaDP = madp.Trim();
        }

        public frmCT_NhanPhong(frmDatPhong form, string id,string madp)
        {
            InitializeComponent();
            formDP = form;
            MaDP = madp.Trim();
            idDangNhap = id;
        }

        public frmCT_NhanPhong(string id)
        {
            InitializeComponent();
            idDangNhap = id.Trim();
        }

        public void loadComboboxTenKH()
        {
            cboTenKH.DataSource = qlKH.getAllKhachHangShort();
            cboTenKH.DisplayMember = "TenKH";
            cboTenKH.ValueMember = "MaKH";
        }

        private void frmCT_NhanPhong_Load(object sender, EventArgs e)
        {
            dpkDateCheckIn.Value = DateTime.Now;
            dpkDateCheckOut.Value = DateTime.Now.AddDays(1);
            loadComboboxTenKH();
            TimeSpan time = (dpkDateCheckOut.Value - dpkDateCheckIn.Value);
            txtSoNgayDat.Text = (time.Days).ToString();

            if (MaDP != null)
            {
                string NgayDen = dpkDateCheckIn.Value.ToString("dd/MM/yyyy");
                string NgayDi = dpkDateCheckOut.Value.ToString("dd/MM/yyyy");
                listPHChon = new BindingList<tPhongDat>(qlphdat.getPhongDatByMaDP(MaDP));
                dataChoosenRoom.DataSource = listPHChon;

                KhachHangNhanPhong khNhanPhong = qlKHNhanPhong.selectKhachHang(MaDP.Trim());
                cboTenKH.Text = khNhanPhong.HoTen;
                txbPhoneNumber.Text = khNhanPhong.SDT;
                txtNgayNhan.Text = DateTime.Now.ToShortDateString();
                dpkDateCheckOut.Value = DateTime.Now.AddDays(1);

                dpkDateCheckIn.Visible = false;
                txtNgayNhan.Visible = true;
                cboTenKH.Enabled = false;
                txtTamTinh.Text = tinhTienTam(dataChoosenRoom).ToString();
            }    
            else
            {
                dpkDateCheckIn.Visible = true;
                txtNgayNhan.Visible = false;
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimPhongTrong_Click(object sender, EventArgs e)
        {
            string NgayDen = dpkDateCheckIn.Value.ToShortDateString();
            string NgayDi = dpkDateCheckOut.Value.ToShortDateString();
            listPHTrong = new BindingList<tPhongDat>(qlphdat.getAllPhongTrong(NgayDen, NgayDi));
            dataEmptyRoom.DataSource = listPHTrong;
        }
        public int tinhTienTam(DataGridView data)
        {
            int days = int.Parse(txtSoNgayDat.Text);
            int tong = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                tong += days * int.Parse(data.Rows[i].Cells[2].Value.ToString());
            }
            return tong;
        }

        public void thietLapLaiThongSoDataGridView(DataGridView data)
        {
            data.Columns[0].HeaderText = "Tên phòng";
            data.Columns[1].HeaderText = "Loại phòng";
            data.Columns[2].HeaderText = "Đơn giá";

            data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            data.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            data.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataChoosenRoom_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow ThemMoi = new DataGridViewRow();
            ThemMoi.CreateCells(dataEmptyRoom);
            DataGridViewRow DangChon = dataChoosenRoom.CurrentRow;
            tPhongDat phDat = new tPhongDat();
            phDat.TenPH = DangChon.Cells[0].Value.ToString();
            phDat.LoaiPH = DangChon.Cells[1].Value.ToString();
            phDat.DonGia = int.Parse(DangChon.Cells[2].Value.ToString());
            listPHTrong.Add(phDat);

            dataEmptyRoom.DataSource = null;
            dataEmptyRoom.DataSource = listPHTrong;
            thietLapLaiThongSoDataGridView(dataEmptyRoom);

            dataChoosenRoom.Rows.Remove(DangChon);
            txtTamTinh.Text = tinhTienTam(dataChoosenRoom).ToString();
        }

        private void dpkDateCheckOut_onValueChanged(object sender, EventArgs e)
        {
            if (first)
            {
                first = false;
                return;
            }

            if (DateTime.Compare(dpkDateCheckIn.Value, dpkDateCheckOut.Value) >= 0)
            {
                MessageBox.Show("Vui lòng điều chỉnh thời gian chọn phòng phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TimeSpan time = (dpkDateCheckOut.Value - dpkDateCheckIn.Value);
            txtSoNgayDat.Text = (time.Days).ToString();
        }

        private void dataEmptyRoom_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow ThemMoi = new DataGridViewRow();
            ThemMoi.CreateCells(dataChoosenRoom);
            DataGridViewRow DangChon = dataEmptyRoom.CurrentRow;
            tPhongDat phDat = new tPhongDat();
            phDat.TenPH = DangChon.Cells[0].Value.ToString();
            phDat.LoaiPH = DangChon.Cells[1].Value.ToString();
            phDat.DonGia = int.Parse(DangChon.Cells[2].Value.ToString());
            listPHChon.Add(phDat);

            dataChoosenRoom.DataSource = null;
            dataChoosenRoom.DataSource = listPHChon;
            thietLapLaiThongSoDataGridView(dataChoosenRoom);

            dataEmptyRoom.Rows.Remove(DangChon);
            txtTamTinh.Text = tinhTienTam(dataChoosenRoom).ToString();
        }

        private void cboTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenKH.SelectedIndex < 0)
                return;
            KhachHangShort a = cboTenKH.SelectedValue as KhachHangShort;
            string id;
            if (a != null)
            {
                txtHoTenKH.Text = a.TenKH;
                id = a.MaKH.Trim();
            }
            else
            {
                id = cboTenKH.SelectedValue.ToString().Trim();
                txtHoTenKH.Text = cboTenKH.Text;
            }
            txbPhoneNumber.Text = txtSoDienThoai.Text = qlKH.getSDTByID(id).ToString();
        }

        private void btnAddNewKH_Click(object sender, EventArgs e)
        {
            frmAdd_KhachHang addkh = new frmAdd_KhachHang(this);
            addkh.ShowDialog();
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            try
            {
                string makh = cboTenKH.SelectedValue.ToString().Trim();
                qlphdat.addNewDonNhanPhong(makh, idDangNhap);
                
                if (MaDP != null)
                    qlphdat.updateTinhTrangDonDatPhong(MaDP);
                
                string hoaDonID = qlphdat.getMaHoaDonCuoi().Trim();

                for (int i = 0; i < dataChoosenRoom.Rows.Count; i++)
                {
                    string tenph = dataChoosenRoom.Rows[i].Cells[0].Value.ToString().Trim();
                    qlphdat.addNewCTNhanPhong(hoaDonID, tenph);
                }
                MessageBox.Show("Đơn nhận phòng được ghi nhận thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formDP.loadDataGridViewPhongDaDat();
                listPHChon = new BindingList<tPhongDat>();
                dataChoosenRoom.DataSource = null;
                dataChoosenRoom.DataSource = listPHChon;
                thietLapLaiThongSoDataGridView(dataChoosenRoom);

                dpkDateCheckIn.Enabled = true;
                dpkDateCheckIn.Visible = true;
                txtNgayNhan.Visible = false;
            }
            catch
            {
                MessageBox.Show("Lỗi không thể thêm đơn đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboTimKiemMaDP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataEmptyRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
