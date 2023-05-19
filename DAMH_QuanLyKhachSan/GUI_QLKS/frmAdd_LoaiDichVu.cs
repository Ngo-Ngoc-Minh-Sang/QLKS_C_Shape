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
    public partial class frmAdd_LoaiDichVu : Form
    {
        LoaiDichVuBLL qlldv = new LoaiDichVuBLL();
        private frmLoaiDichVu formLoaiDV;
        public frmAdd_LoaiDichVu()
        {
            InitializeComponent();
        }
        public frmAdd_LoaiDichVu(frmLoaiDichVu form)
        {
            InitializeComponent();
            formLoaiDV = form;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbName.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ các trường để thêm loại dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (qlldv.AddNewTypeService(txbName.Text))
                {
                    MessageBox.Show("Thêm loại dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formLoaiDV.frmLoaiDichVu_Load(sender, e);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Thêm loại dịch vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
