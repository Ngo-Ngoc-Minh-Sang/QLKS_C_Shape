
namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    partial class frmCT_DatPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCT_DatPhong));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.DatepickerDateOfReceive = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnAddNewKH = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataEmptyRoom = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhLoaiPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpkDateCheckOut = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dpkDateCheckIn = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPhoneNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimPhongTrong = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cboTenKH = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataChoosenRoom = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtSoNgayDat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtHoTenKH = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnDatPhong = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtTamTinh = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtSoDienThoai = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmptyRoom)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChoosenRoom)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(1146, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 66;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DatepickerDateOfReceive
            // 
            this.DatepickerDateOfReceive.BackColor = System.Drawing.Color.SteelBlue;
            this.DatepickerDateOfReceive.BorderRadius = 0;
            this.DatepickerDateOfReceive.ForeColor = System.Drawing.Color.White;
            this.DatepickerDateOfReceive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatepickerDateOfReceive.FormatCustom = "";
            this.DatepickerDateOfReceive.Location = new System.Drawing.Point(63, 1237);
            this.DatepickerDateOfReceive.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.DatepickerDateOfReceive.Name = "DatepickerDateOfReceive";
            this.DatepickerDateOfReceive.Size = new System.Drawing.Size(456, 76);
            this.DatepickerDateOfReceive.TabIndex = 30;
            this.DatepickerDateOfReceive.Value = new System.DateTime(2018, 2, 23, 23, 29, 57, 962);
            // 
            // btnAddNewKH
            // 
            this.btnAddNewKH.ActiveBorderThickness = 1;
            this.btnAddNewKH.ActiveCornerRadius = 20;
            this.btnAddNewKH.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewKH.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddNewKH.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewKH.BackColor = System.Drawing.Color.White;
            this.btnAddNewKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewKH.BackgroundImage")));
            this.btnAddNewKH.ButtonText = "Thêm mới khách";
            this.btnAddNewKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewKH.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewKH.IdleBorderThickness = 1;
            this.btnAddNewKH.IdleCornerRadius = 20;
            this.btnAddNewKH.IdleFillColor = System.Drawing.Color.White;
            this.btnAddNewKH.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnAddNewKH.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewKH.Location = new System.Drawing.Point(12, 198);
            this.btnAddNewKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNewKH.Name = "btnAddNewKH";
            this.btnAddNewKH.Size = new System.Drawing.Size(148, 40);
            this.btnAddNewKH.TabIndex = 65;
            this.btnAddNewKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNewKH.Click += new System.EventHandler(this.btnAddNewKH_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(1, 57);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1161, 17);
            this.bunifuSeparator1.TabIndex = 63;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataEmptyRoom);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox6.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox6.Location = new System.Drawing.Point(4, 80);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(380, 481);
            this.groupBox6.TabIndex = 64;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin phòng còn trống";
            // 
            // dataEmptyRoom
            // 
            this.dataEmptyRoom.AllowUserToAddRows = false;
            this.dataEmptyRoom.AllowUserToDeleteRows = false;
            this.dataEmptyRoom.AllowUserToResizeRows = false;
            this.dataEmptyRoom.BackgroundColor = System.Drawing.Color.White;
            this.dataEmptyRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataEmptyRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataEmptyRoom.ColumnHeadersHeight = 29;
            this.dataEmptyRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataEmptyRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.clhLoaiPH,
            this.col});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataEmptyRoom.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataEmptyRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataEmptyRoom.GridColor = System.Drawing.Color.White;
            this.dataEmptyRoom.Location = new System.Drawing.Point(3, 25);
            this.dataEmptyRoom.Name = "dataEmptyRoom";
            this.dataEmptyRoom.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataEmptyRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataEmptyRoom.RowHeadersVisible = false;
            this.dataEmptyRoom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataEmptyRoom.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataEmptyRoom.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEmptyRoom.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataEmptyRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEmptyRoom.Size = new System.Drawing.Size(374, 453);
            this.dataEmptyRoom.TabIndex = 29;
            this.dataEmptyRoom.VirtualMode = true;
            this.dataEmptyRoom.DoubleClick += new System.EventHandler(this.dataEmptyRoom_DoubleClick);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.DataPropertyName = "TenPH";
            this.colId.HeaderText = "Tên phòng";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // clhLoaiPH
            // 
            this.clhLoaiPH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clhLoaiPH.DataPropertyName = "LoaiPH";
            this.clhLoaiPH.HeaderText = "Loại phòng";
            this.clhLoaiPH.Name = "clhLoaiPH";
            this.clhLoaiPH.ReadOnly = true;
            // 
            // col
            // 
            this.col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col.DataPropertyName = "DonGia";
            this.col.HeaderText = "Đơn giá";
            this.col.Name = "col";
            this.col.ReadOnly = true;
            this.col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dpkDateCheckOut
            // 
            this.dpkDateCheckOut.BackColor = System.Drawing.Color.SteelBlue;
            this.dpkDateCheckOut.BorderRadius = 0;
            this.dpkDateCheckOut.ForeColor = System.Drawing.Color.White;
            this.dpkDateCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkDateCheckOut.FormatCustom = null;
            this.dpkDateCheckOut.Location = new System.Drawing.Point(232, 162);
            this.dpkDateCheckOut.Margin = new System.Windows.Forms.Padding(14, 21, 14, 21);
            this.dpkDateCheckOut.Name = "dpkDateCheckOut";
            this.dpkDateCheckOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dpkDateCheckOut.Size = new System.Drawing.Size(202, 29);
            this.dpkDateCheckOut.TabIndex = 54;
            this.dpkDateCheckOut.Value = new System.DateTime(2018, 2, 23, 23, 29, 57, 962);
            this.dpkDateCheckOut.onValueChanged += new System.EventHandler(this.dpkDateCheckOut_onValueChanged);
            // 
            // dpkDateCheckIn
            // 
            this.dpkDateCheckIn.BackColor = System.Drawing.Color.SteelBlue;
            this.dpkDateCheckIn.BorderRadius = 0;
            this.dpkDateCheckIn.ForeColor = System.Drawing.Color.White;
            this.dpkDateCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkDateCheckIn.FormatCustom = null;
            this.dpkDateCheckIn.Location = new System.Drawing.Point(12, 159);
            this.dpkDateCheckIn.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.dpkDateCheckIn.Name = "dpkDateCheckIn";
            this.dpkDateCheckIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dpkDateCheckIn.Size = new System.Drawing.Size(202, 29);
            this.dpkDateCheckIn.TabIndex = 53;
            this.dpkDateCheckIn.Value = new System.DateTime(2018, 2, 23, 23, 29, 57, 962);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.SteelBlue;
            this.label19.Location = new System.Drawing.Point(228, 143);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 20);
            this.label19.TabIndex = 34;
            this.label19.Text = "Ngày trả:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.SteelBlue;
            this.label21.Location = new System.Drawing.Point(8, 140);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 20);
            this.label21.TabIndex = 32;
            this.label21.Text = "Ngày nhận:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(2, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 37);
            this.label2.TabIndex = 62;
            this.label2.Text = "Chi Tiết Đặt Phòng";
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txbPhoneNumber.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txbPhoneNumber.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txbPhoneNumber.BorderThickness = 1;
            this.txbPhoneNumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPhoneNumber.Enabled = false;
            this.txbPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPhoneNumber.isPassword = false;
            this.txbPhoneNumber.Location = new System.Drawing.Point(12, 106);
            this.txbPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txbPhoneNumber.MaxLength = 32767;
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(431, 29);
            this.txbPhoneNumber.TabIndex = 24;
            this.txbPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.SteelBlue;
            this.label14.Location = new System.Drawing.Point(8, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Số điện thoại:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimPhongTrong);
            this.groupBox2.Controls.Add(this.cboTenKH);
            this.groupBox2.Controls.Add(this.DatepickerDateOfReceive);
            this.groupBox2.Controls.Add(this.btnAddNewKH);
            this.groupBox2.Controls.Add(this.txbPhoneNumber);
            this.groupBox2.Controls.Add(this.dpkDateCheckOut);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dpkDateCheckIn);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(390, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 246);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // btnTimPhongTrong
            // 
            this.btnTimPhongTrong.ActiveBorderThickness = 1;
            this.btnTimPhongTrong.ActiveCornerRadius = 20;
            this.btnTimPhongTrong.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnTimPhongTrong.ActiveForecolor = System.Drawing.Color.White;
            this.btnTimPhongTrong.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnTimPhongTrong.BackColor = System.Drawing.Color.White;
            this.btnTimPhongTrong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimPhongTrong.BackgroundImage")));
            this.btnTimPhongTrong.ButtonText = "Tìm phòng";
            this.btnTimPhongTrong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimPhongTrong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimPhongTrong.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnTimPhongTrong.IdleBorderThickness = 1;
            this.btnTimPhongTrong.IdleCornerRadius = 20;
            this.btnTimPhongTrong.IdleFillColor = System.Drawing.Color.White;
            this.btnTimPhongTrong.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnTimPhongTrong.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnTimPhongTrong.Location = new System.Drawing.Point(168, 198);
            this.btnTimPhongTrong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimPhongTrong.Name = "btnTimPhongTrong";
            this.btnTimPhongTrong.Size = new System.Drawing.Size(148, 40);
            this.btnTimPhongTrong.TabIndex = 67;
            this.btnTimPhongTrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimPhongTrong.Click += new System.EventHandler(this.btnTimPhongTrong_Click);
            // 
            // cboTenKH
            // 
            this.cboTenKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTenKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTenKH.FormattingEnabled = true;
            this.cboTenKH.ItemHeight = 23;
            this.cboTenKH.Location = new System.Drawing.Point(12, 50);
            this.cboTenKH.Name = "cboTenKH";
            this.cboTenKH.Size = new System.Drawing.Size(431, 29);
            this.cboTenKH.Style = MetroFramework.MetroColorStyle.Blue;
            this.cboTenKH.TabIndex = 66;
            this.cboTenKH.SelectedIndexChanged += new System.EventHandler(this.cboTenKH_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Họ và tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataChoosenRoom);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(392, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 229);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng đặt";
            // 
            // dataChoosenRoom
            // 
            this.dataChoosenRoom.AllowUserToAddRows = false;
            this.dataChoosenRoom.AllowUserToDeleteRows = false;
            this.dataChoosenRoom.AllowUserToResizeRows = false;
            this.dataChoosenRoom.BackgroundColor = System.Drawing.Color.White;
            this.dataChoosenRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataChoosenRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataChoosenRoom.ColumnHeadersHeight = 29;
            this.dataChoosenRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataChoosenRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataChoosenRoom.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataChoosenRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataChoosenRoom.GridColor = System.Drawing.Color.White;
            this.dataChoosenRoom.Location = new System.Drawing.Point(3, 25);
            this.dataChoosenRoom.Name = "dataChoosenRoom";
            this.dataChoosenRoom.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataChoosenRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataChoosenRoom.RowHeadersVisible = false;
            this.dataChoosenRoom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataChoosenRoom.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataChoosenRoom.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataChoosenRoom.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataChoosenRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataChoosenRoom.Size = new System.Drawing.Size(447, 201);
            this.dataChoosenRoom.TabIndex = 30;
            this.dataChoosenRoom.VirtualMode = true;
            this.dataChoosenRoom.DoubleClick += new System.EventHandler(this.dataChoosenRoom_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenPH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên phòng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LoaiPH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Loại phòng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn3.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCapNhat);
            this.groupBox3.Controls.Add(this.txtSoNgayDat);
            this.groupBox3.Controls.Add(this.txtHoTenKH);
            this.groupBox3.Controls.Add(this.btnDatPhong);
            this.groupBox3.Controls.Add(this.bunifuDatepicker1);
            this.groupBox3.Controls.Add(this.txtTamTinh);
            this.groupBox3.Controls.Add(this.txtSoDienThoai);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(861, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 481);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đặt hàng";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ActiveBorderThickness = 1;
            this.btnCapNhat.ActiveCornerRadius = 20;
            this.btnCapNhat.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnCapNhat.ActiveForecolor = System.Drawing.Color.White;
            this.btnCapNhat.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnCapNhat.BackColor = System.Drawing.Color.White;
            this.btnCapNhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.BackgroundImage")));
            this.btnCapNhat.ButtonText = "Cập nhật";
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCapNhat.IdleBorderThickness = 1;
            this.btnCapNhat.IdleCornerRadius = 20;
            this.btnCapNhat.IdleFillColor = System.Drawing.Color.White;
            this.btnCapNhat.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnCapNhat.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnCapNhat.Location = new System.Drawing.Point(12, 330);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(148, 40);
            this.btnCapNhat.TabIndex = 70;
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCapNhat.Visible = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtSoNgayDat
            // 
            this.txtSoNgayDat.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txtSoNgayDat.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txtSoNgayDat.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txtSoNgayDat.BorderThickness = 1;
            this.txtSoNgayDat.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoNgayDat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoNgayDat.Enabled = false;
            this.txtSoNgayDat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSoNgayDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoNgayDat.isPassword = false;
            this.txtSoNgayDat.Location = new System.Drawing.Point(12, 168);
            this.txtSoNgayDat.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoNgayDat.MaxLength = 32767;
            this.txtSoNgayDat.Name = "txtSoNgayDat";
            this.txtSoNgayDat.Size = new System.Drawing.Size(285, 29);
            this.txtSoNgayDat.TabIndex = 69;
            this.txtSoNgayDat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txtHoTenKH.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txtHoTenKH.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txtHoTenKH.BorderThickness = 1;
            this.txtHoTenKH.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHoTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTenKH.Enabled = false;
            this.txtHoTenKH.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHoTenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoTenKH.isPassword = false;
            this.txtHoTenKH.Location = new System.Drawing.Point(12, 49);
            this.txtHoTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTenKH.MaxLength = 32767;
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(285, 29);
            this.txtHoTenKH.TabIndex = 68;
            this.txtHoTenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.ActiveBorderThickness = 1;
            this.btnDatPhong.ActiveCornerRadius = 20;
            this.btnDatPhong.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnDatPhong.ActiveForecolor = System.Drawing.Color.White;
            this.btnDatPhong.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnDatPhong.BackColor = System.Drawing.Color.White;
            this.btnDatPhong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDatPhong.BackgroundImage")));
            this.btnDatPhong.ButtonText = "Đặt phòng";
            this.btnDatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatPhong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDatPhong.IdleBorderThickness = 1;
            this.btnDatPhong.IdleCornerRadius = 20;
            this.btnDatPhong.IdleFillColor = System.Drawing.Color.White;
            this.btnDatPhong.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnDatPhong.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnDatPhong.Location = new System.Drawing.Point(12, 280);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(148, 40);
            this.btnDatPhong.TabIndex = 67;
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SteelBlue;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker1.FormatCustom = "";
            this.bunifuDatepicker1.Location = new System.Drawing.Point(63, 1237);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(456, 76);
            this.bunifuDatepicker1.TabIndex = 30;
            this.bunifuDatepicker1.Value = new System.DateTime(2018, 2, 23, 23, 29, 57, 962);
            // 
            // txtTamTinh
            // 
            this.txtTamTinh.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txtTamTinh.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txtTamTinh.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txtTamTinh.BorderThickness = 1;
            this.txtTamTinh.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTamTinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTamTinh.Enabled = false;
            this.txtTamTinh.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTamTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTamTinh.isPassword = false;
            this.txtTamTinh.Location = new System.Drawing.Point(12, 242);
            this.txtTamTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTamTinh.MaxLength = 32767;
            this.txtTamTinh.Name = "txtTamTinh";
            this.txtTamTinh.Size = new System.Drawing.Size(285, 29);
            this.txtTamTinh.TabIndex = 24;
            this.txtTamTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txtSoDienThoai.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txtSoDienThoai.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txtSoDienThoai.BorderThickness = 1;
            this.txtSoDienThoai.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoai.Enabled = false;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoDienThoai.isPassword = false;
            this.txtSoDienThoai.Location = new System.Drawing.Point(12, 106);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDienThoai.MaxLength = 32767;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(285, 29);
            this.txtSoDienThoai.TabIndex = 24;
            this.txtSoDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(8, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Tạm tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(8, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(8, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Số ngày đặt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(8, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Họ và tên:";
            // 
            // frmCT_DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 568);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCT_DatPhong";
            this.Text = "frmCT_DatPhong";
            this.Load += new System.EventHandler(this.frmCT_DatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmptyRoom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataChoosenRoom)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddNewKH;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupBox6;
        private Bunifu.Framework.UI.BunifuDatepicker dpkDateCheckOut;
        private Bunifu.Framework.UI.BunifuDatepicker dpkDateCheckIn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerDateOfReceive;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbPhoneNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cboTenKH;
        private System.Windows.Forms.DataGridView dataEmptyRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTimPhongTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhLoaiPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col;
        private System.Windows.Forms.DataGridView dataChoosenRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHoTenKH;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDatPhong;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTamTinh;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSoDienThoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSoNgayDat;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCapNhat;
    }
}