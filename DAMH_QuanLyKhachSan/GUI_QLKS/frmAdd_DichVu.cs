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
    public partial class frmAdd_DichVu : Form
    {
        private frmDichVu formDichVu;
        DichVuBLL qldv = new DichVuBLL();
        LoaiDichVuBLL qlldv = new LoaiDichVuBLL();
        public frmAdd_DichVu()
        {
            InitializeComponent();
        }
        public frmAdd_DichVu(frmDichVu form)
        {
            InitializeComponent();
            formDichVu = form;
        }

        private void frmAdd_DichVu_Load(object sender, EventArgs e)
        {
            comboBoxServiceType.DataSource = qlldv.getAllLoaiDV();
            comboBoxServiceType.DisplayMember = "TenDV";
            comboBoxServiceType.ValueMember = "MaDV";
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbName.Text) || comboBoxServiceType.SelectedIndex < 0 || string.IsNullOrEmpty(txbPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ các trường để thêm dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (qldv.AddNewService(txbName.Text, comboBoxServiceType.SelectedValue.ToString(), int.Parse(txbPrice.Text)))
                {
                    MessageBox.Show("Thêm dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formDichVu.frmDichVu_Load(sender, e);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Thêm dịch vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
