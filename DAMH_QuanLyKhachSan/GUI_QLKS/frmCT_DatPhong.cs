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
    public partial class frmCT_DatPhong : Form
    {
        PhongDatBLL qlphdat = new PhongDatBLL();
        BindingList<tPhongDat> listPHDat;
        BindingList<tPhongDat> listPHChon = new BindingList<tPhongDat>();
        KhachHangBLL qlKH = new KhachHangBLL();
        bool first = true;
        string MADatPhong;

        private static frmDatPhong mainf;
        public frmCT_DatPhong()
        {
            InitializeComponent();
        }

        public frmCT_DatPhong(frmDatPhong form)
        {
            InitializeComponent();
            mainf = form;
        }

        public frmCT_DatPhong(frmDatPhong form, string MADP)
        {
            InitializeComponent();
            mainf = form;
            MADatPhong = MADP.Trim();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadComboboxTenKH ()
        {
            cboTenKH.DataSource = qlKH.getAllKhachHangShort();
            cboTenKH.DisplayMember = "TenKH";
            cboTenKH.ValueMember = "MaKH";
        }

        private void frmCT_DatPhong_Load(object sender, EventArgs e)
        {
            dpkDateCheckIn.Value = DateTime.Now;
            dpkDateCheckOut.Value = DateTime.Now.AddDays(1);
            loadComboboxTenKH();
            TimeSpan time = (dpkDateCheckOut.Value - dpkDateCheckIn.Value);
            txtSoNgayDat.Text = (time.Days).ToString();

            if(MADatPhong != null)
            {
                string NgayDen = dpkDateCheckIn.Value.ToShortDateString();
                string NgayDi = dpkDateCheckOut.Value.ToShortDateString(); ;
                listPHDat = new BindingList<tPhongDat>(qlphdat.getAllPhongTrong(NgayDen, NgayDi));
                dataEmptyRoom.DataSource = listPHDat;

                listPHChon = new BindingList<tPhongDat>(qlphdat.getPhongDatByMaDP(MADatPhong));
                dataChoosenRoom.DataSource = listPHChon;
                btnDatPhong.Visible = false;
                btnCapNhat.Visible = true;
                txtTamTinh.Text = tinhTienTam(dataChoosenRoom).ToString();
            }    
        }

        private void btnTimPhongTrong_Click(object sender, EventArgs e)
        {
            string NgayDen = dpkDateCheckIn.Value.ToShortDateString();
            string NgayDi = dpkDateCheckOut.Value.ToShortDateString();
            listPHDat = new BindingList<tPhongDat>(qlphdat.getAllPhongTrong(NgayDen, NgayDi));
            dataEmptyRoom.DataSource = listPHDat;
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

        public void thietLapLaiThongSoDataGridView(DataGridView data)
        {
            data.Columns[0].HeaderText = "Tên phòng";
            data.Columns[1].HeaderText = "Loại phòng";
            data.Columns[2].HeaderText = "Đơn giá";

            data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            data.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            data.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public int tinhTienTam(DataGridView data)
        {
            int days = int.Parse(txtSoNgayDat.Text);
            int tong = 0;
            for(int i = 0; i<data.Rows.Count; i++)
            {
                tong += days * int.Parse(data.Rows[i].Cells[2].Value.ToString());
            }
            return tong;
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
            listPHDat.Add(phDat);

            dataEmptyRoom.DataSource = null;
            dataEmptyRoom.DataSource = listPHDat;
            thietLapLaiThongSoDataGridView(dataEmptyRoom);

            dataChoosenRoom.Rows.Remove(DangChon);
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

        private void dpkDateCheckOut_onValueChanged(object sender, EventArgs e)
        {
            if(first)
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
            txtSoNgayDat.Text = (time.Days + 1).ToString();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            try
            {
                string makh = cboTenKH.SelectedValue.ToString().Trim();
                string NgayDen = dpkDateCheckIn.Value.ToString("dd/MM/yyyy").Trim();
                string NgayDi = dpkDateCheckOut.Value.ToString("dd/MM/yyyy").Trim();
                qlphdat.addNewDatPhong(makh, NgayDen, NgayDi);

                for(int i = 0; i<dataChoosenRoom.Rows.Count; i++)
                {
                    string tenph = dataChoosenRoom.Rows[i].Cells[0].Value.ToString().Trim();
                    int days = int.Parse(txtSoNgayDat.Text.Trim());
                    int dongia = int.Parse(dataChoosenRoom.Rows[i].Cells[2].Value.ToString().Trim());
                    qlphdat.addNewCTDatPhong(tenph, days, dongia);
                }
                MessageBox.Show("Đơn đặt phòng được ghi nhận thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if(mainf != null)
                    mainf.loadDataGridViewPhongDaDat();
                listPHChon = new BindingList<tPhongDat>();
                dataChoosenRoom.DataSource = null;
                dataChoosenRoom.DataSource = listPHChon;
                thietLapLaiThongSoDataGridView(dataChoosenRoom);
            }
            catch
            {
                MessageBox.Show("Lỗi không thể thêm đơn đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string makh = cboTenKH.SelectedValue.ToString().Trim();
                string NgayDen = dpkDateCheckIn.Value.ToString("dd/MM/yyyy").Trim();
                string NgayDi = dpkDateCheckOut.Value.ToString("dd/MM/yyyy").Trim();
                qlphdat.updateDatPhongByMaDP(makh, NgayDen, NgayDi);
                qlphdat.deleteCTDatPhongByMaDP(MADatPhong);

                for (int i = 0; i < dataChoosenRoom.Rows.Count; i++)
                {
                    string tenph = dataChoosenRoom.Rows[i].Cells[0].Value.ToString().Trim();
                    int days = int.Parse(txtSoNgayDat.Text.Trim());
                    int dongia = int.Parse(dataChoosenRoom.Rows[i].Cells[2].Value.ToString().Trim());
                    qlphdat.addNewCTDatPhongByMaDP(MADatPhong,tenph, days, dongia);
                }
                MessageBox.Show("Đơn đặt phòng được ghi nhận thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainf.loadDataGridViewPhongDaDat();
                listPHChon = new BindingList<tPhongDat>();
                dataChoosenRoom.DataSource = null;
                dataChoosenRoom.DataSource = listPHChon;
                thietLapLaiThongSoDataGridView(dataChoosenRoom);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể sửa thông tin đơn đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNewKH_Click(object sender, EventArgs e)
        {
            frmAdd_KhachHang addkh = new frmAdd_KhachHang(this);
            addkh.ShowDialog();
        }
    }
}
