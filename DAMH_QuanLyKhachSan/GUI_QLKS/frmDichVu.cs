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
    public partial class frmDichVu : Form
    {
        DichVuBLL qldv = new DichVuBLL();
        LoaiDichVuBLL qlldv = new LoaiDichVuBLL();
        public frmDichVu()
        {
            InitializeComponent();
        }
        public void loadDataGridViewDichVu()
        {
            dataGridViewService.DataSource = qldv.getAllDichVu().Select(o => new
            {
                id = o.MaDV,
                name = o.TenDV,
                price_new = o.GiaDV,
                nameServiceType = o.MaLoaiDV

            }).ToList();
        }

        public void frmDichVu_Load(object sender, EventArgs e)
        {
            try
            {
                loadDataGridViewDichVu();
                loadComboboxMaDV();
                loadComboboxLoaiDV();
            }
            catch
            {
                MessageBox.Show("Lỗi load dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void loadComboboxMaDV()
        {
            comboboxID.DataSource = qldv.getAllDichVu().Select(o => new
            {
                MaDV = o.MaDV
            }).ToList();
            comboboxID.DisplayMember = "MaDV";
            comboboxID.ValueMember = "MaDV";
        }
        private void loadComboboxLoaiDV()
        {
            comboBoxServiceType.DataSource = qlldv.getAllLoaiDV();
            comboBoxServiceType.DisplayMember = "TenDV";
            comboBoxServiceType.ValueMember = "MaDV";
        }

        private void btnCLose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbSearch.Text))
            {
                MessageBox.Show("Vui lòng nhập thông số để tìm dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (qldv.getAllDichVuByName(txbSearch.Text) == null)
                {
                    MessageBox.Show("Không tồn tại dịch vụ thỏa yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (qldv.getAllDichVuByName(txbSearch.Text) != null)
                {
                    dataGridViewService.DataSource = qldv.getAllDichVuByName(txbSearch.Text).Select(o => new
                    {
                        id = o.MaDV,
                        name = o.TenDV,
                        price_new = o.GiaDV,
                        nameServiceType = o.MaLoaiDV
                    }).ToList();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi load dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAdd_DichVu themDV = new frmAdd_DichVu(this);
            themDV.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int lengthPrice = txbPrice.Text.Length;
            int price;
            try
            {
                if (txbPrice.Text.Contains("VN"))
                    price = int.Parse(txbPrice.Text.Trim().Substring(0, lengthPrice - 3));
                else
                    price = int.Parse(txbPrice.Text.Trim());
                if (qldv.UpdateService(comboboxID.SelectedValue.ToString(), txbName.Text, comboBoxServiceType.SelectedValue.ToString(), price))
                {
                    MessageBox.Show("Thay đổi thông tin phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Thay đổi thông tin phòng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                loadDataGridViewDichVu();
            }
        }

        private void btnServiceType_Click(object sender, EventArgs e)
        {
            frmLoaiDichVu loaiDV = new frmLoaiDichVu();
            loaiDV.ShowDialog();
        }

        private void dataGridViewService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dataGridViewService.Rows[e.RowIndex];
            comboboxID.Text = row.Cells[0].Value.ToString();
            txbName.Text = row.Cells[1].Value.ToString();
            comboBoxServiceType.Text = row.Cells[3].Value.ToString();
            txbPrice.Text = row.Cells[2].Value.ToString() + " VNĐ";
        }
    }
}
