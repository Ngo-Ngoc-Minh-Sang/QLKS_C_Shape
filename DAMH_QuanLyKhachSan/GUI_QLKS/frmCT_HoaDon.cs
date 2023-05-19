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
    public partial class frmCT_HoaDon : Form
    {
        string MaHD;
        ChiTietHoaDonBLL qlChiTietHoaDon = new ChiTietHoaDonBLL();
        HoaDonBLL qlHoaDon = new HoaDonBLL();
        public frmCT_HoaDon()
        {
            InitializeComponent();
        }

        public frmCT_HoaDon(string id)
        {
            InitializeComponent();
            MaHD = id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int tinhTienTam(DataGridView data)
        {
            int tong = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                tong += int.Parse(data.Rows[i].Cells[6].Value.ToString());
            }
            return tong;
        }

        private void frmCT_HoaDon_Load(object sender, EventArgs e)
        {
            dataPhongDaNhan.DataSource = qlChiTietHoaDon.getAllChiTietHoaDonByMaHD(MaHD);
            HoaDon hd = qlHoaDon.getHoaDonByHoaDonID(MaHD);
            lblIDBill.Text = hd.MaHD;
            lblStaffSetUp.Text = hd.TenNV;
            lblDateCreate.Text = hd.NgayLapHD;
            lblCustomerName.Text = hd.TenKH;
            lblIDCustomer.Text = hd.MaKH;
            lblAddress.Text = hd.DiaChi;
            lblPhoneNumber.Text = hd.SoDienThoai;
            

            lblFinalPrice.Text = tinhTienTam(dataPhongDaNhan).ToString();
        }

        private void btnClose__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmInHoaDon formHoaDon = new frmInHoaDon(MaHD);
            formHoaDon.ShowDialog();
        }
    }
}
