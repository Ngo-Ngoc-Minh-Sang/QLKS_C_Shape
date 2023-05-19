using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAMH_QuanLyKhachSan.DAL_QLKS;
using DAMH_QuanLyKhachSan.BLL_QLKS;


namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    public partial class frmNhanVien : Form
    {

        #region Properties
        public static string HassPass = "123456"; // password default
        #endregion
        NhanVienBLL qlnv = new NhanVienBLL();
        LoaiNhanVienBLL qllnv = new LoaiNhanVienBLL();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        public void setMKDM(string mkmd)
        {
            HassPass = mkmd;
        }

        public string getHassPass()
        {
            return HassPass;
        }
        public void loadDataGridViewNhanVien()
        {
            dataGridStaff.DataSource = qlnv.getAllNhanVien().Select(o => new
            {
                TenDangNhap = o.TenDangNhap,
                TenNV = o.TenNV,
                TenLoaiNV = o.TenLoaiNV,
                CMND = o.CMND,
                NgaySinh = o.ngaySinh,
                SDT = o.SDT,
                DiaChi = o.DiaChi,
                GioiTinh = o.GioiTinh,
                MaLoaiNV = o.MaLoaiNV,
                NgayVaoLam = o.NgayVaoLam,

            }).ToList();
        }
        public void loadComboBoxLoaiNhanVien()
        {
            comboBoxStaffType.DataSource = qllnv.getAllLoaiNhanVien();
            comboBoxStaffType.DisplayMember = "TenLoaiNV";
            comboBoxStaffType.ValueMember = "MaLoaiNV";
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                loadDataGridViewNhanVien();
                loadComboBoxLoaiNhanVien();
            }
            catch
            {
                MessageBox.Show("Lỗi load dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //
        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //add nhân viên
        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAdd_NhanVien addNhanVien = new frmAdd_NhanVien(this);
            addNhanVien.ShowDialog();
        }

        private void dataGridStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = dataGridStaff.Rows[e.RowIndex];

            txbUserName.Text = row.Cells[colUserName.Name].Value.ToString();
            txbName.Text = row.Cells[colname.Name].Value.ToString();
            txbIDcard.Text = row.Cells[colIDCard.Name].Value.ToString();
            txbPhoneNumber.Text = row.Cells[colPhone.Name].Value.ToString();
            txbAddress.Text = row.Cells[colAddress.Name].Value.ToString();
            comboBoxStaffType.SelectedIndex = comboBoxStaffType.FindStringExact(row.Cells[colNameStaffType.Name].Value.ToString());
            comboBoxSex.SelectedIndex = comboBoxSex.FindStringExact(row.Cells[colSex.Name].Value.ToString());
            datepickerDateOfBirth.Value = DateTime.Parse(row.Cells[colDateOfBirth.Name].Value.ToString());
            datePickerStartDay.Value = DateTime.Parse(row.Cells[colStartDay.Name].Value.ToString());

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật nhân viên này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {

                if (CheckDate())
                {
                    try
                    {
                        int sdt = int.Parse(txbPhoneNumber.Text);
                        if (qlnv.UpdateNewNhanVien(txbUserName.Text, txbName.Text, comboBoxStaffType.SelectedValue.ToString(), txbIDcard.Text, datepickerDateOfBirth.Value, comboBoxSex.Text, txbAddress.Text, sdt, datePickerStartDay.Value))
                        {
                            MessageBox.Show("Cập nhật Nhân Viên Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDataGridViewNhanVien();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Nhân Viên bị(Trùng tên đăng nhập hoặc Số CMND)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Cập nhật nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đặt lại mật khẩu với tên đăng nhập " + txbUserName.Text + " không?", "Thông báo",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                ResetPassword();
            }
        }
        private void ResetPassword()
        {
            try
            {
                bool check = qlnv.ResetPassword(txbUserName.Text, HassPass);
                if (check)
                {
                    MessageBox.Show("Đặt lại mật khẩu thành công\nMật khẩu mặt định là: '"+HassPass+"'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Không thể đặt lại mật khẩu (Tên đăng nhập chưa tồn tại)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch
            {
                MessageBox.Show("Lỗi không xác định", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPassDF_Click(object sender, EventArgs e)
        {
            frmUpPassdefaut passdf = new frmUpPassdefaut();
            passdf.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbSearch.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (qlnv.getAllNhanVienByUserName(txbSearch.Text) == null)
                {
                    MessageBox.Show("Không tồn tại nhân viên thỏa yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (qlnv.getAllNhanVienByUserName(txbSearch.Text) != null)
                {
                    dataGridStaff.DataSource = qlnv.getAllNhanVienByUserName(txbSearch.Text).Select(o => new
                    {
                        TenDangNhap = o.TenDangNhap,
                        TenNV = o.TenNV,
                        TenLoaiNV = o.TenLoaiNV,
                        CMND = o.CMND,
                        NgaySinh = o.ngaySinh,
                        SDT = o.SDT,
                        DiaChi = o.DiaChi,
                        GioiTinh = o.GioiTinh,
                        MaLoaiNV = o.MaLoaiNV,
                        NgayVaoLam = o.NgayVaoLam,
                    }).ToList();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi load dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            frmQuyenTruyCap quyen = new frmQuyenTruyCap();
            quyen.ShowDialog();
        }
    }
}
