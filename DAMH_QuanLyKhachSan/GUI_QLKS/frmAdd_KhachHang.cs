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
    public partial class frmAdd_KhachHang : Form
    {
        private frmKhachHang formKhachHang;
        KhachHangBLL qlkh = new KhachHangBLL();
        LoaiKhachHangBLL qllkh = new LoaiKhachHangBLL();
        frmCT_DatPhong formCTDatPhong;
        private frmCT_NhanPhong formCTNhanPhong;
        public frmAdd_KhachHang()
        {
            InitializeComponent();
        }

        public frmAdd_KhachHang(frmCT_DatPhong form)
        {
            InitializeComponent();
            formCTDatPhong = form;
        }
        public frmAdd_KhachHang(frmCT_NhanPhong form)
        {
            InitializeComponent();
            formCTNhanPhong = form;
        }
        public frmAdd_KhachHang(frmKhachHang form)
        {
            InitializeComponent();
            formKhachHang = form;
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbFullName.Text) || comboBoxCustomerType.SelectedIndex < 0 || string.IsNullOrEmpty(txbIDCard.Text) ||
               string.IsNullOrEmpty(txbPhoneNumber.Text) || string.IsNullOrEmpty(txbAddress.Text) || comboBoxSex.SelectedIndex < 0 ||
               cboNationality.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập đủ các trường để thêm khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string ten, loaiKH, cmnd, ngaySinh, gioiTinh, diaChi, quocTich, sdt;
                ten = txbFullName.Text.Trim();
                loaiKH = comboBoxCustomerType.SelectedValue.ToString().Trim();
                cmnd = txbIDCard.Text.Trim();
                ngaySinh = datepickerDateOfBirth.Text.Trim();
                gioiTinh = comboBoxSex.Text.Trim();
                diaChi = txbAddress.Text.Trim();
                quocTich = cboNationality.Text.Trim();
                sdt = txbPhoneNumber.Text.Trim();
                if (qlkh.insertNewCustomer(ten, loaiKH, cmnd, ngaySinh, diaChi, sdt, gioiTinh, quocTich))
                {
                    if(formKhachHang != null)
                    {
                        MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        formKhachHang.frmKhachHang_Load(sender, e);
                        return;
                    }
                    if(formCTDatPhong != null)
                    {
                        MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        formCTDatPhong.loadComboboxTenKH();
                        this.Close();
                    }
                    if (formCTNhanPhong != null)
                    {
                        MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        formCTNhanPhong.loadComboboxTenKH();
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thêm khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAdd_KhachHang_Load(object sender, EventArgs e)
        {
            comboBoxCustomerType.DataSource = qllkh.getAllLoaiKH();
            comboBoxCustomerType.DisplayMember = "LoaiKH";
            comboBoxCustomerType.ValueMember = "MaLoaiKH";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
