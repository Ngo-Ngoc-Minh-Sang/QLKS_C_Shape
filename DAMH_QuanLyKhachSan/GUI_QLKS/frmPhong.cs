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
    public partial class frmPhong : Form
    {
        PhongBLL qlph = new PhongBLL();
        LoaiPhongBLL qllp = new LoaiPhongBLL();
        TinhTrangPhongBLL qltinhtrangph = new TinhTrangPhongBLL();
        public frmPhong()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCLose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadDataGridViewPhong()
        {
            dataGridViewRoom.DataSource = qlph.getAllPhong().Select(o => new
            {
                MaPh = o.MaPh,
                TenPh = o.TenPh,
                TenLoaiPH = o.TenLoaiPH,
                GiaPH = o.GiaPH,
                SoNguoiTD = o.SoNguoiTD,
                TenTT = o.TenTT
            }).ToList();
        }

        public void loadComboBoxLoaiPhong()
        {
            comboBoxRoomType.DataSource = qllp.getAllLoaiPhong();
            comboBoxRoomType.DisplayMember = "TenLoaiPH";
            comboBoxRoomType.ValueMember = "MaLoaiPH";
        }

        public void loadComboboxMaPhong()
        {
            comboboxID.DataSource = qlph.getAllPhong().Select(o => new
            {
                MaPh = o.MaPh,
            }).ToList();
            comboboxID.DisplayMember = "MaPH";
            comboboxID.ValueMember = "MaPH";
        }

        //**************************************************************************
        //Phần thêm
        //**************************************************************************
        public void loadComboboxSeparate()
        {
            cbSeparateRoom.Items.Add("Mã phòng");
            cbSeparateRoom.Items.Add("Tên phòng");
        }

        public void loadComboboxTinhTrangPhong()
        {
            comboBoxStatusRoom.DataSource = qltinhtrangph.getAllTinhTrangPhong();
            comboBoxStatusRoom.DisplayMember = "TenTT";
            comboBoxStatusRoom.ValueMember = "MaTT";
        }    

        public void frmPhong_Load(object sender, EventArgs e)
        {
            try
            {
                loadDataGridViewPhong();
                loadComboBoxLoaiPhong();
                loadComboboxMaPhong();
                loadComboboxTinhTrangPhong();
                loadComboboxSeparate();
            }    
            catch
            {
                MessageBox.Show("Lỗi load dữ liệu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txbSearch.Text))
            {
                MessageBox.Show("Vui lòng nhập thông số để tìm phòng","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } 

            if(cbSeparateRoom.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại thông tin cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            
            try
            {
                if(cbSeparateRoom.SelectedItem.ToString() == "Mã phòng")
                {
                    if (qlph.getAllPhongByID(txbSearch.Text) == null)
                    {
                        MessageBox.Show("Không tồn tại phòng thỏa yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (qlph.getAllPhongByID(txbSearch.Text) != null)
                    {
                        dataGridViewRoom.DataSource = qlph.getAllPhongByID(txbSearch.Text).Select(o => new
                        {
                            MaPh = o.MaPh,
                            TenPh = o.TenPh,
                            TenLoaiPH = o.TenLoaiPH,
                            GiaPH = o.GiaPH,
                            SoNguoiTD = o.SoNguoiTD,
                            TenTT = o.TenTT
                        }).ToList();
                        return;
                    }
                }
                else
                {
                    if (qlph.getAllPhongByName(txbSearch.Text) == null)
                    {
                        MessageBox.Show("Không tồn tại phòng thỏa yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (qlph.getAllPhongByName(txbSearch.Text) != null)
                    {
                        dataGridViewRoom.DataSource = qlph.getAllPhongByName(txbSearch.Text).Select(o => new
                        {
                            MaPh = o.MaPh,
                            TenPh = o.TenPh,
                            TenLoaiPH = o.TenLoaiPH,
                            GiaPH = o.GiaPH,
                            SoNguoiTD = o.SoNguoiTD,
                            TenTT = o.TenTT
                        }).ToList();
                        return;
                    }
                }    
            }
            catch
            {
                MessageBox.Show("Lỗi load dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];
            txbNameRoom.Text = row.Cells[1].Value.ToString();
            txbPrice.Text = String.Format("{0:0,0}", row.Cells[3].Value.ToString()) + "VNĐ";
            txbLimitPerson.Text = row.Cells[4].Value.ToString();
            comboBoxRoomType.SelectedIndex = comboBoxRoomType.FindStringExact(row.Cells[2].Value.ToString());
            comboboxID.Text = row.Cells[0].Value.ToString();
            comboBoxStatusRoom.SelectedIndex = comboBoxStatusRoom.FindStringExact(row.Cells[5].Value.ToString());
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            frmAdd_Phong addPhong = new frmAdd_Phong(this);
            addPhong.ShowDialog();
        }

        private void btnRoomType_Click(object sender, EventArgs e)
        {
            comboboxID.Enabled = false;
            comboBoxStatusRoom.Enabled = false;
            btnUpdate.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (qlph.UpdatePhong(txbNameRoom.Text, comboBoxRoomType.SelectedValue.ToString(), comboboxID.SelectedValue.ToString()))
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
                comboboxID.Enabled = true;
                comboBoxStatusRoom.Enabled = true;
                btnUpdate.Visible = false;
                loadDataGridViewPhong();
            }
        }

        private void toolsmiDatPhong_Click(object sender, EventArgs e)
        {
            if (comboboxID.SelectedIndex < 0)
                return;
            MessageBox.Show(comboboxID.SelectedValue.ToString());
        }
    }
}
