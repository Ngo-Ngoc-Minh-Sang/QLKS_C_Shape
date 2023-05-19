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
    public partial class frmKhachHang : Form
    {
        KhachHangBLL qlkh = new KhachHangBLL();
        LoaiKhachHangBLL qllkh = new LoaiKhachHangBLL();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loadDataGridViewKhachHang()
        {
            dataGridViewCustomer.DataSource = qlkh.getAllKhachHang().Select(o => new
            {
                MaKH = o.MaKH,
                TenKH = o.TenKH,
                CMND = o.CMND,
                LoaiKH = o.MaLoaiKH,
                SDT = o.SDT,
                DiaChi = o.DiaChi,
                QuocTich = o.QuocTich
            }).ToList();
        }

  
        public void loadCbo_MaKH()
        {
            comboboxID.DataSource = qlkh.getAllKhachHang();
            comboboxID.DisplayMember = "MaKH";
            comboboxID.ValueMember = "MaKH";
        }
        public void loadCbo_LoaiKH()
        {
            comboBoxCustomerType.DataSource = qllkh.getAllLoaiKH();
            comboBoxCustomerType.DisplayMember = "LoaiKH";
            comboBoxCustomerType.ValueMember = "MaLoaiKH";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAdd_KhachHang themKH = new frmAdd_KhachHang(this);
            themKH.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string ma, ten, loaiKH, cmnd, ngaySinh, gioiTinh, diaChi, quocTich, sdt;
                ma = comboboxID.SelectedValue.ToString().Trim();
                ten = txbFullName.Text.Trim();
                loaiKH = comboBoxCustomerType.SelectedValue.ToString().Trim();
                cmnd = txbIDCard.Text.Trim();
                ngaySinh = datepickerDateOfBirth.Text.Trim();
                gioiTinh = comboBoxSex.Text.Trim();
                diaChi = txbAddress.Text.Trim();
                quocTich = txbNationality.Text.Trim();
                sdt = txbPhoneNumber.Text.Trim();
                if (qlkh.UpdateCutomer(ma, ten, cmnd, loaiKH, sdt, diaChi, quocTich, gioiTinh, ngaySinh))
                {
                    MessageBox.Show("Thay đổi thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Thay đổi thông tin khách hàng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                loadDataGridViewKhachHang();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbSearch.Text))
            {
                MessageBox.Show("Vui lòng nhập thông số để tìm khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (qlkh.getAllDichVuByKey(cbCustomerSearch.Text, txbSearch.Text) == null)
                {
                    MessageBox.Show("Không tồn tại khách hàng thỏa yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (qlkh.getAllDichVuByKey(cbCustomerSearch.Text, txbSearch.Text) != null)
                {
                    dataGridViewCustomer.DataSource = qlkh.getAllDichVuByKey(cbCustomerSearch.Text, txbSearch.Text).Select(o => new
                    {
                        MaKH = o.MaKH,
                        TenKH = o.TenKH,
                        CMND = o.CMND,
                        LoaiKH = o.MaLoaiKH,
                        SDT = o.SDT,
                        DiaChi = o.DiaChi,
                        QuocTich = o.QuocTich
                    }).ToList();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi load dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dataGridViewCustomer.Rows[e.RowIndex];
            comboboxID.Text = row.Cells[2].Value.ToString();
            tKhachHang kh = qlkh.selectKhachHang(row.Cells[2].Value.ToString());
            txbFullName.Text = row.Cells[3].Value.ToString();
            txbIDCard.Text = row.Cells[4].Value.ToString();
            comboBoxCustomerType.Text = row.Cells[5].Value.ToString();
            comboBoxSex.Text = kh.GioiTinh;
            datepickerDateOfBirth.Text = kh.NgSinh;
            txbAddress.Text = row.Cells[7].Value.ToString();
            txbPhoneNumber.Text = row.Cells[6].Value.ToString();
            txbNationality.Text = row.Cells[8].Value.ToString();

        }

        public void frmKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                loadDataGridViewKhachHang();
                loadCbo_MaKH();
                loadCbo_LoaiKH();
            }
            catch
            {
                MessageBox.Show("Lỗi load dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
