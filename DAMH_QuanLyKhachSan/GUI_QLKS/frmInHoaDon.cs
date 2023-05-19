using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DAMH_QuanLyKhachSan.BLL_QLKS;

namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    public partial class frmInHoaDon : Form
    {
        string MaHD;
        ChiTietHoaDonBLL qlChiTietHoaDon = new ChiTietHoaDonBLL();
        HoaDonBLL qlHoaDon = new HoaDonBLL();
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        public frmInHoaDon(string id)
        {
            InitializeComponent();
            MaHD = id.Trim();
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            rpHoaDon.LocalReport.ReportEmbeddedResource = "DAMH_QuanLyKhachSan.reportHoaDon.rdlc";
            ReportDataSource data = new ReportDataSource();
            data.Name = "DataSet1";
            data.Value = qlChiTietHoaDon.hienThiChiTietHoaDonTheoMaHD(MaHD);
            rpHoaDon.LocalReport.DataSources.Add(data);
            this.rpHoaDon.RefreshReport();
        }
    }
}
