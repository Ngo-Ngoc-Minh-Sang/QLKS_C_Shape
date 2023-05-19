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
    public partial class frmDoiPhong : Form
    {
        PhongDatBLL qlphdat = new PhongDatBLL();
        BindingList<tPhongDat> listPHTrong = new BindingList<tPhongDat>();
        string MaHD;
        frmDichVuAndThanhToan fDichVuThanhToan;

        public frmDoiPhong()
        {
            InitializeComponent();
        }
        public frmDoiPhong(frmDichVuAndThanhToan form, string id)
        {
            InitializeComponent();
            MaHD = id;
            fDichVuThanhToan = form;
        }

        private void frmDoiPhong_Load(object sender, EventArgs e)
        {
            string NgayDen = DateTime.Now.ToShortDateString();
            string NgayDi = DateTime.Now.AddDays(1).ToShortDateString();
            listPHTrong = new BindingList<tPhongDat>(qlphdat.getAllPhongTrong(NgayDen, NgayDi));
            dataRoomEmpty.DataSource = listPHTrong;
        }

        private void btnClose__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeRoom_Click(object sender, EventArgs e)
        {
            if(dataRoomEmpty.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 phòng để đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string TenPH = dataRoomEmpty.CurrentRow.Cells[0].Value.ToString().Trim();
            try
            {
                qlphdat.addNewCTNhanPhong(MaHD, TenPH);
                MessageBox.Show("Đổi phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fDichVuThanhToan.loadDataPhongCoNguoi();
                fDichVuThanhToan.hienPhongDangDon();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể đổi phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
