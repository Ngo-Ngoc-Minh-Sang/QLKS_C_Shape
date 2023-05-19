using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAMH_QuanLyKhachSan.BLL_QLKS;
using DAMH_QuanLyKhachSan.DTO_QLKS;

namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    public partial class frmAdd_NhanVien : Form
    {
        private frmNhanVien formNhanVien;
        LoaiNhanVienBLL qlLoaiNhanVien = new LoaiNhanVienBLL();
        NhanVienBLL qlNhanVien = new NhanVienBLL();

        public frmAdd_NhanVien(frmNhanVien form)
        {
            InitializeComponent();
            formNhanVien = form;
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm nhân viên mới không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {

                if (CheckDate())
                {
                    try
                    {
                        string password = frmNhanVien.HassPass;
                        bool check = qlNhanVien.ResetPassword(txbUser.Text, password);
                        int sdt = int.Parse(txbPhoneNumber.Text);
                        if (check)
                        {

                            if (qlNhanVien.AddNewNhanVien(txbUser.Text, txbFullName.Text, password, comboBoxStaffType.SelectedValue.ToString(), txbIDcard.Text, datepickerDateOfBirth.Value, comboBoxSex.Text, txbAddress.Text, sdt, datePickerStartDay.Value))
                                MessageBox.Show("Thêm nhân viên thành cộng và mật khẩu mặt định là: '" + password + "'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            formNhanVien.loadDataGridViewNhanVien();
                            return;

                        }
                        else
                        {
                            MessageBox.Show("Nhân Viên Đã Tồn Tại(Trùng tên đăng nhập hoặc Số CMND)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thêm Nhân Viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }
        }

        private bool CheckDate()
        {
            if (!CheckTrueDate(datepickerDateOfBirth.Value, DateTime.Now))
            {
                MessageBox.Show("Ngày sinh không hợp lệ (Tuổi phải lớn hơn 18)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                if (!CheckTrueDate(datepickerDateOfBirth.Value, datePickerStartDay.Value))
            {
                MessageBox.Show("Ngày vào làm không hợp lệ (Lớn hơn 18 tuổi)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool CheckTrueDate(DateTime date1, DateTime date2)
        {
            if (date2.Subtract(date1).Days < 6574)
                return false;
            return true;
        }

        private void frmAdd_NhanVien_Load(object sender, EventArgs e)
        {
            comboBoxStaffType.DataSource = qlLoaiNhanVien.getAllLoaiNhanVien();
            comboBoxStaffType.DisplayMember = "TenLoaiNV";
            comboBoxStaffType.ValueMember = "MaLoaiNV";
        }

        private void btnClose__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
