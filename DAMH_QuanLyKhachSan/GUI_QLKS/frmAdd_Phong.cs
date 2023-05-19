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
    public partial class frmAdd_Phong : Form
    {
        private frmPhong formPhong;
        LoaiPhongBLL qlLoaiPhong = new LoaiPhongBLL();
        PhongBLL qlPhong = new PhongBLL();
        public frmAdd_Phong()
        {
            InitializeComponent();
        }

        public frmAdd_Phong(frmPhong form)
        {
            InitializeComponent();
            formPhong = form;
        }

        private void btnClose__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txbNameRoom.Text) || comboBoxRoomType.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập đủ các trường để thêm phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if(qlPhong.AddNewPhong(txbNameRoom.Text,comboBoxRoomType.SelectedValue.ToString()))
                {
                    MessageBox.Show("Thêm phòng thành cộng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formPhong.frmPhong_Load(sender, e);
                    return;
                }    
            }
            catch
            {
                MessageBox.Show("Thêm phòng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmAdd_Phong_Load(object sender, EventArgs e)
        {
            comboBoxRoomType.DataSource = qlLoaiPhong.getAllLoaiPhong();
            comboBoxRoomType.DisplayMember = "TenLoaiPH";
            comboBoxRoomType.ValueMember = "MaLoaiPH";
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaloaiPH = comboBoxRoomType.SelectedValue.ToString();
            if (MaloaiPH == "DAMH_QuanLyKhachSan.DTO_QLKS.tLoaiPhong")
                return;
            try
            {
                tLoaiPhong loaiph = new tLoaiPhong();
                loaiph = qlLoaiPhong.getLoaiPhongByID(MaloaiPH);
                txbLimitPerson.Text = loaiph.SoNguoiTD.ToString();
                txbPrice.Text = string.Format("{0:0,0}", loaiph.GiaPH.ToString()) + " VNĐ";
            }
            catch
            {
                MessageBox.Show("Lỗi load dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
