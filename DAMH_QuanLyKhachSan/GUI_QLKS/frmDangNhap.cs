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

namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    public partial class frmDangNhap : Form
    {
        NhanVienBLL qlnv = new NhanVienBLL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public bool Login()
        {
            return qlnv.Login(txbUserName.Text, txbPassWord.Text);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login())
            {

                frmQuanLy f = new frmQuanLy(txbUserName.Text);
                this.Hide();
                f.ShowDialog();

            }
            else
            {
                MessageBox.Show("Tên Đăng Nhập không tồn tại hoặc Mật Khẩu không đúng.\nVui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnExit__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin_Click(sender, null);
        }
    }
}
