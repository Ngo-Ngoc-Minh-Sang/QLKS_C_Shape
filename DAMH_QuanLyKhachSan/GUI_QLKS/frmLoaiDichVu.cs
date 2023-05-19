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
    public partial class frmLoaiDichVu : Form
    {
        LoaiDichVuBLL qlldv = new LoaiDichVuBLL();
        public frmLoaiDichVu()
        {
            InitializeComponent();
        }
        public void loadDataGridViewLoaiDichVu()
        {
            dataGridViewServiceType.DataSource = qlldv.getAllLoaiDV().Select(o => new
            {
                id = o.MaDV,
                name = o.TenDV

            }).ToList();
        }

        public void frmLoaiDichVu_Load(object sender, EventArgs e)
        {
            try
            {
                loadDataGridViewLoaiDichVu();
                loadComboboxLoaiDV();
            }
            catch
            {
                MessageBox.Show("Lỗi load dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void loadComboboxLoaiDV()
        {
            comboboxID.DataSource = qlldv.getAllLoaiDV();
            comboboxID.DisplayMember = "MaDV";
            comboboxID.ValueMember = "MaDV";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAdd_LoaiDichVu tldv = new frmAdd_LoaiDichVu(this);
            tldv.ShowDialog();
        }

        private void btnUpdateServiceType_Click(object sender, EventArgs e)
        {
            try
            {
                if (qlldv.UpdateTypeService(comboboxID.SelectedValue.ToString(), txbName.Text))
                {
                    MessageBox.Show("Thay đổi thông tin loại dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Thay đổi thông tin loại dịch vụ không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                loadDataGridViewLoaiDichVu();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewServiceType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dataGridViewServiceType.Rows[e.RowIndex];
            comboboxID.Text = row.Cells[0].Value.ToString();
            txbName.Text = row.Cells[1].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbSearch.Text))
            {
                MessageBox.Show("Vui lòng nhập thông số để tìm loại dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (qlldv.getAllLoaiDichVuByName(txbSearch.Text) == null)
                {
                    MessageBox.Show("Không tồn tại loại dịch vụ thỏa yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (qlldv.getAllLoaiDichVuByName(txbSearch.Text) != null)
                {
                    dataGridViewServiceType.DataSource = qlldv.getAllLoaiDichVuByName(txbSearch.Text).Select(o => new
                    {
                        id = o.MaDV,
                        name = o.TenDV
                    }).ToList();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi load dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCLose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
