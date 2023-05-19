
namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    partial class frmCT_HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCT_HoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose_ = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIDBill = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStaffSetUp = new System.Windows.Forms.Label();
            this.lblCustom = new System.Windows.Forms.Label();
            this.lblDateCreate = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblIDCustomer = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label24 = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataPhongDaNhan = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimitPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhNgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhNgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhongDaNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(952, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 73;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 41);
            this.label2.TabIndex = 72;
            this.label2.Text = "Hóa Đơn";
            // 
            // btnClose_
            // 
            this.btnClose_.ActiveBorderThickness = 1;
            this.btnClose_.ActiveCornerRadius = 20;
            this.btnClose_.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnClose_.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose_.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnClose_.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose_.BackColor = System.Drawing.Color.White;
            this.btnClose_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose_.BackgroundImage")));
            this.btnClose_.ButtonText = "Đóng";
            this.btnClose_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose_.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose_.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnClose_.IdleBorderThickness = 1;
            this.btnClose_.IdleCornerRadius = 20;
            this.btnClose_.IdleFillColor = System.Drawing.Color.White;
            this.btnClose_.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnClose_.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnClose_.Location = new System.Drawing.Point(603, 852);
            this.btnClose_.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClose_.Name = "btnClose_";
            this.btnClose_.Size = new System.Drawing.Size(271, 49);
            this.btnClose_.TabIndex = 76;
            this.btnClose_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose_.Click += new System.EventHandler(this.btnClose__Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveBorderThickness = 1;
            this.btnPrint.ActiveCornerRadius = 20;
            this.btnPrint.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.ActiveForecolor = System.Drawing.Color.White;
            this.btnPrint.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.ButtonText = "In Hóa Đơn";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.IdleBorderThickness = 1;
            this.btnPrint.IdleCornerRadius = 20;
            this.btnPrint.IdleFillColor = System.Drawing.Color.White;
            this.btnPrint.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnPrint.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.Location = new System.Drawing.Point(15, 852);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(271, 49);
            this.btnPrint.TabIndex = 75;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(268, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 37);
            this.label1.TabIndex = 34;
            this.label1.Text = "MIMOSA HOTEL";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(275, 57);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(645, 32);
            this.label13.TabIndex = 64;
            this.label13.Text = "▶ Address: 297/15 TÔ HIẾN THÀNH , PHƯỜNG 13 , QUẬN 10";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(275, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 23);
            this.label3.TabIndex = 65;
            this.label3.Text = "▶ Phone: 0931.158.500 – 028.38620173";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(275, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 28);
            this.label4.TabIndex = 66;
            this.label4.Text = "▶ Website: https://http://hotelmimosaq10.com/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(264, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(391, 32);
            this.label5.TabIndex = 67;
            this.label5.Text = "HÓA ĐƠN THANH TOÁN DỊCH VỤ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(47, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 68;
            this.label6.Text = "Mã hóa đơn:";
            // 
            // lblIDBill
            // 
            this.lblIDBill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIDBill.Location = new System.Drawing.Point(159, 183);
            this.lblIDBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDBill.Name = "lblIDBill";
            this.lblIDBill.Size = new System.Drawing.Size(111, 21);
            this.lblIDBill.TabIndex = 69;
            this.lblIDBill.Text = "Mã hóa đơn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(316, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 70;
            this.label7.Text = "Nhân viên lập:";
            // 
            // lblStaffSetUp
            // 
            this.lblStaffSetUp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffSetUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStaffSetUp.Location = new System.Drawing.Point(445, 183);
            this.lblStaffSetUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffSetUp.Name = "lblStaffSetUp";
            this.lblStaffSetUp.Size = new System.Drawing.Size(213, 21);
            this.lblStaffSetUp.TabIndex = 71;
            this.lblStaffSetUp.Text = "Mã hóa đơn";
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustom.Location = new System.Drawing.Point(635, 183);
            this.lblCustom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(82, 23);
            this.lblCustom.TabIndex = 72;
            this.lblCustom.Text = "Ngày lập:";
            // 
            // lblDateCreate
            // 
            this.lblDateCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDateCreate.Location = new System.Drawing.Point(728, 183);
            this.lblDateCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateCreate.Name = "lblDateCreate";
            this.lblDateCreate.Size = new System.Drawing.Size(173, 21);
            this.lblDateCreate.TabIndex = 73;
            this.lblDateCreate.Text = "Mã hóa đơn";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSeparator1.LineThickness = 252;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-41, 305);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1316, 32);
            this.bunifuSeparator1.TabIndex = 74;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(47, 236);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 23);
            this.label9.TabIndex = 75;
            this.label9.Text = "Tên khách hàng:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerName.Location = new System.Drawing.Point(189, 236);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(300, 21);
            this.lblCustomerName.TabIndex = 76;
            this.lblCustomerName.Text = "Mã hóa đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(47, 274);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 23);
            this.label10.TabIndex = 77;
            this.label10.Text = "Mã khách hàng:";
            // 
            // lblIDCustomer
            // 
            this.lblIDCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIDCustomer.Location = new System.Drawing.Point(189, 274);
            this.lblIDCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDCustomer.Name = "lblIDCustomer";
            this.lblIDCustomer.Size = new System.Drawing.Size(244, 21);
            this.lblIDCustomer.TabIndex = 78;
            this.lblIDCustomer.Text = "Mã hóa đơn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(519, 274);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 23);
            this.label11.TabIndex = 79;
            this.label11.Text = "Số điện thoại:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(657, 274);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(244, 21);
            this.lblPhoneNumber.TabIndex = 80;
            this.lblPhoneNumber.Text = "Mã hóa đơn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(519, 236);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 23);
            this.label12.TabIndex = 81;
            this.label12.Text = "Địa chỉ:";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAddress.Location = new System.Drawing.Point(657, 236);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(288, 21);
            this.lblAddress.TabIndex = 82;
            this.lblAddress.Text = "Mã hóa đơn";
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSeparator3.LineThickness = 252;
            this.bunifuSeparator3.Location = new System.Drawing.Point(36, 1141);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(19, 26, 19, 26);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(1316, 30);
            this.bunifuSeparator3.TabIndex = 101;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label24.Location = new System.Drawing.Point(607, 727);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(96, 23);
            this.label24.TabIndex = 112;
            this.label24.Text = "Thành tiền:";
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFinalPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFinalPrice.Location = new System.Drawing.Point(708, 727);
            this.lblFinalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(175, 21);
            this.lblFinalPrice.TabIndex = 113;
            this.lblFinalPrice.Text = "Mã hóa đơn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Controls.Add(this.lblFinalPrice);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.bunifuSeparator3);
            this.groupBox6.Controls.Add(this.lblAddress);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.lblPhoneNumber);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.lblIDCustomer);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.lblCustomerName);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.bunifuSeparator1);
            this.groupBox6.Controls.Add(this.lblDateCreate);
            this.groupBox6.Controls.Add(this.lblCustom);
            this.groupBox6.Controls.Add(this.lblStaffSetUp);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.lblIDBill);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox6.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox6.Location = new System.Drawing.Point(20, 46);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(928, 796);
            this.groupBox6.TabIndex = 74;
            this.groupBox6.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataPhongDaNhan);
            this.groupBox1.Location = new System.Drawing.Point(8, 336);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(912, 375);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            // 
            // dataPhongDaNhan
            // 
            this.dataPhongDaNhan.AllowUserToAddRows = false;
            this.dataPhongDaNhan.AllowUserToDeleteRows = false;
            this.dataPhongDaNhan.AllowUserToResizeRows = false;
            this.dataPhongDaNhan.BackgroundColor = System.Drawing.Color.White;
            this.dataPhongDaNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPhongDaNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPhongDaNhan.ColumnHeadersHeight = 29;
            this.dataPhongDaNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataPhongDaNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colLimitPerson,
            this.colPrice,
            this.clhNgayNhan,
            this.clhNgayDi,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPhongDaNhan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataPhongDaNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPhongDaNhan.GridColor = System.Drawing.Color.White;
            this.dataPhongDaNhan.Location = new System.Drawing.Point(4, 31);
            this.dataPhongDaNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataPhongDaNhan.Name = "dataPhongDaNhan";
            this.dataPhongDaNhan.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPhongDaNhan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataPhongDaNhan.RowHeadersVisible = false;
            this.dataPhongDaNhan.RowHeadersWidth = 51;
            this.dataPhongDaNhan.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataPhongDaNhan.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPhongDaNhan.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataPhongDaNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPhongDaNhan.Size = new System.Drawing.Size(904, 340);
            this.dataPhongDaNhan.TabIndex = 52;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "TenPH";
            this.colName.HeaderText = "Tên phòng";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colLimitPerson
            // 
            this.colLimitPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLimitPerson.DataPropertyName = "NgayNhanPhong";
            this.colLimitPerson.HeaderText = "Ngày nhận";
            this.colLimitPerson.MinimumWidth = 6;
            this.colLimitPerson.Name = "colLimitPerson";
            this.colLimitPerson.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrice.DataPropertyName = "NgayTraPhong";
            this.colPrice.HeaderText = "Ngày trả";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // clhNgayNhan
            // 
            this.clhNgayNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clhNgayNhan.DataPropertyName = "DonGia";
            this.clhNgayNhan.HeaderText = "Tiền phòng";
            this.clhNgayNhan.MinimumWidth = 6;
            this.clhNgayNhan.Name = "clhNgayNhan";
            this.clhNgayNhan.ReadOnly = true;
            // 
            // clhNgayDi
            // 
            this.clhNgayDi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clhNgayDi.DataPropertyName = "PhuThu";
            this.clhNgayDi.HeaderText = "Phụ thu";
            this.clhNgayDi.MinimumWidth = 6;
            this.clhNgayDi.Name = "clhNgayDi";
            this.clhNgayDi.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "ThanhTien";
            this.Column1.HeaderText = "Thành tiên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // frmCT_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(989, 918);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose_);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCT_HoaDon";
            this.Text = "frmCT_HoaDon";
            this.Load += new System.EventHandler(this.frmCT_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPhongDaNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose_;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Label label24;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIDCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblDateCreate;
        private System.Windows.Forms.Label lblCustom;
        private System.Windows.Forms.Label lblStaffSetUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIDBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataPhongDaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimitPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhNgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhNgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}