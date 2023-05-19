using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    public partial class frmUpPassdefaut : Form
    {
        public frmUpPassdefaut()
        {
            InitializeComponent();
            Load();
        }


        private void btn_Click(object sender, EventArgs e)
        {
            if (txbMatKhauMoi.Text != frmNhanVien.HassPass && txbMatKhauMoi.Text != string.Empty)
            {
                frmNhanVien.HassPass = txbMatKhauMoi.Text;
                MessageBox.Show("Mat khau mặc định hiện tại là: " + frmNhanVien.HassPass);
                Load();
            }
            else
                MessageBox.Show("Lỗi");
        }

        public void Load()
        {
            txbMatKhauHT.Text = frmNhanVien.HassPass;
            txbMatKhauMoi.Text = string.Empty;
            txbMatKhauHT.Enabled = false;
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
