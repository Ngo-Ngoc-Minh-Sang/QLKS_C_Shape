
namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    partial class frmDatPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatPhong));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dpkDateCheckOut = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label23 = new System.Windows.Forms.Label();
            this.dpkDateCheckIn = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label21 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimitPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhNgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhNgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nhanPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDetails = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridViewBookRoom = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnXemPhongDat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDatPhong = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCapNhat = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookRoom)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(1207, 21);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 59;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 46);
            this.label2.TabIndex = 58;
            this.label2.Text = "Đặt Phòng";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dpkDateCheckOut);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.dpkDateCheckIn);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox6.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox6.Location = new System.Drawing.Point(16, 79);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(1216, 105);
            this.groupBox6.TabIndex = 62;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin đăng kí";
            // 
            // dpkDateCheckOut
            // 
            this.dpkDateCheckOut.BackColor = System.Drawing.Color.SteelBlue;
            this.dpkDateCheckOut.BorderRadius = 0;
            this.dpkDateCheckOut.ForeColor = System.Drawing.Color.White;
            this.dpkDateCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkDateCheckOut.FormatCustom = null;
            this.dpkDateCheckOut.Location = new System.Drawing.Point(712, 57);
            this.dpkDateCheckOut.Margin = new System.Windows.Forms.Padding(12, 16, 12, 16);
            this.dpkDateCheckOut.Name = "dpkDateCheckOut";
            this.dpkDateCheckOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dpkDateCheckOut.Size = new System.Drawing.Size(269, 36);
            this.dpkDateCheckOut.TabIndex = 41;
            this.dpkDateCheckOut.Value = new System.DateTime(2018, 2, 23, 23, 29, 57, 962);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.SteelBlue;
            this.label23.Location = new System.Drawing.Point(707, 30);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 25);
            this.label23.TabIndex = 40;
            this.label23.Text = "Ngày trả:";
            // 
            // dpkDateCheckIn
            // 
            this.dpkDateCheckIn.BackColor = System.Drawing.Color.SteelBlue;
            this.dpkDateCheckIn.BorderRadius = 0;
            this.dpkDateCheckIn.ForeColor = System.Drawing.Color.White;
            this.dpkDateCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkDateCheckIn.FormatCustom = null;
            this.dpkDateCheckIn.Location = new System.Drawing.Point(272, 55);
            this.dpkDateCheckIn.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.dpkDateCheckIn.Name = "dpkDateCheckIn";
            this.dpkDateCheckIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dpkDateCheckIn.Size = new System.Drawing.Size(269, 36);
            this.dpkDateCheckIn.TabIndex = 37;
            this.dpkDateCheckIn.Value = new System.DateTime(2018, 2, 23, 23, 29, 57, 962);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.SteelBlue;
            this.label21.Location = new System.Drawing.Point(267, 30);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 25);
            this.label21.TabIndex = 34;
            this.label21.Text = "Ngày nhận:";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(16, 66);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1216, 12);
            this.bunifuSeparator1.TabIndex = 60;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewRoom);
            this.panel2.Controls.Add(this.btnDetails);
            this.panel2.Controls.Add(this.dataGridViewBookRoom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(4, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 377);
            this.panel2.TabIndex = 39;
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AllowUserToAddRows = false;
            this.dataGridViewRoom.AllowUserToDeleteRows = false;
            this.dataGridViewRoom.AllowUserToResizeRows = false;
            this.dataGridViewRoom.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRoom.ColumnHeadersHeight = 29;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colNameRoomType,
            this.colLimitPerson,
            this.colPrice,
            this.clhNgayNhan,
            this.clhNgayDi});
            this.dataGridViewRoom.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRoom.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRoom.GridColor = System.Drawing.Color.White;
            this.dataGridViewRoom.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRoom.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRoom.RowHeadersVisible = false;
            this.dataGridViewRoom.RowHeadersWidth = 51;
            this.dataGridViewRoom.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewRoom.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRoom.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoom.Size = new System.Drawing.Size(1208, 377);
            this.dataGridViewRoom.TabIndex = 50;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "TenPh";
            this.colName.HeaderText = "Tên phòng";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colNameRoomType
            // 
            this.colNameRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNameRoomType.DataPropertyName = "TenKH";
            this.colNameRoomType.HeaderText = "Tên khách";
            this.colNameRoomType.MinimumWidth = 6;
            this.colNameRoomType.Name = "colNameRoomType";
            this.colNameRoomType.ReadOnly = true;
            // 
            // colLimitPerson
            // 
            this.colLimitPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLimitPerson.DataPropertyName = "TenLoai";
            this.colLimitPerson.HeaderText = "Loại phòng";
            this.colLimitPerson.MinimumWidth = 6;
            this.colLimitPerson.Name = "colLimitPerson";
            this.colLimitPerson.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrice.DataPropertyName = "DonGia";
            this.colPrice.HeaderText = "Giá phòng";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // clhNgayNhan
            // 
            this.clhNgayNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clhNgayNhan.DataPropertyName = "NgayDat";
            this.clhNgayNhan.HeaderText = "Ngày nhận";
            this.clhNgayNhan.MinimumWidth = 6;
            this.clhNgayNhan.Name = "clhNgayNhan";
            this.clhNgayNhan.ReadOnly = true;
            // 
            // clhNgayDi
            // 
            this.clhNgayDi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clhNgayDi.DataPropertyName = "NgayTra";
            this.clhNgayDi.HeaderText = "Ngày trả";
            this.clhNgayDi.MinimumWidth = 6;
            this.clhNgayDi.Name = "clhNgayDi";
            this.clhNgayDi.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanPhongToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 28);
            // 
            // nhanPhongToolStripMenuItem
            // 
            this.nhanPhongToolStripMenuItem.Name = "nhanPhongToolStripMenuItem";
            this.nhanPhongToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.nhanPhongToolStripMenuItem.Text = "Nhận phòng";
            this.nhanPhongToolStripMenuItem.Click += new System.EventHandler(this.nhanPhongToolStripMenuItem_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.ActiveBorderThickness = 1;
            this.btnDetails.ActiveCornerRadius = 20;
            this.btnDetails.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnDetails.ActiveForecolor = System.Drawing.Color.White;
            this.btnDetails.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnDetails.BackColor = System.Drawing.Color.White;
            this.btnDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetails.BackgroundImage")));
            this.btnDetails.ButtonText = "Xem Chi Tiết";
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDetails.IdleBorderThickness = 1;
            this.btnDetails.IdleCornerRadius = 20;
            this.btnDetails.IdleFillColor = System.Drawing.Color.White;
            this.btnDetails.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnDetails.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnDetails.Location = new System.Drawing.Point(307, 530);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(271, 49);
            this.btnDetails.TabIndex = 49;
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewBookRoom
            // 
            this.dataGridViewBookRoom.AllowDrop = true;
            this.dataGridViewBookRoom.AllowUserToAddRows = false;
            this.dataGridViewBookRoom.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewBookRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBookRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookRoom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewBookRoom.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBookRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBookRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookRoom.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewBookRoom.GridColor = System.Drawing.Color.White;
            this.dataGridViewBookRoom.Location = new System.Drawing.Point(11, 5);
            this.dataGridViewBookRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewBookRoom.Name = "dataGridViewBookRoom";
            this.dataGridViewBookRoom.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewBookRoom.RowHeadersVisible = false;
            this.dataGridViewBookRoom.RowHeadersWidth = 51;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookRoom.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewBookRoom.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewBookRoom.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewBookRoom.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewBookRoom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewBookRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookRoom.Size = new System.Drawing.Size(1540, 519);
            this.dataGridViewBookRoom.StandardTab = true;
            this.dataGridViewBookRoom.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox4.Location = new System.Drawing.Point(16, 191);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1216, 412);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách đặt phòng trong ngày";
            // 
            // btnXemPhongDat
            // 
            this.btnXemPhongDat.ActiveBorderThickness = 1;
            this.btnXemPhongDat.ActiveCornerRadius = 20;
            this.btnXemPhongDat.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnXemPhongDat.ActiveForecolor = System.Drawing.Color.White;
            this.btnXemPhongDat.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnXemPhongDat.BackColor = System.Drawing.Color.White;
            this.btnXemPhongDat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXemPhongDat.BackgroundImage")));
            this.btnXemPhongDat.ButtonText = "Xem";
            this.btnXemPhongDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemPhongDat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemPhongDat.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnXemPhongDat.IdleBorderThickness = 1;
            this.btnXemPhongDat.IdleCornerRadius = 20;
            this.btnXemPhongDat.IdleFillColor = System.Drawing.Color.White;
            this.btnXemPhongDat.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnXemPhongDat.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnXemPhongDat.Location = new System.Drawing.Point(93, 613);
            this.btnXemPhongDat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnXemPhongDat.Name = "btnXemPhongDat";
            this.btnXemPhongDat.Size = new System.Drawing.Size(119, 49);
            this.btnXemPhongDat.TabIndex = 64;
            this.btnXemPhongDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXemPhongDat.Click += new System.EventHandler(this.btnXemPhongDat_Click);
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
            this.btnDatPhong.Location = new System.Drawing.Point(245, 613);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(148, 49);
            this.btnDatPhong.TabIndex = 65;
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ActiveBorderThickness = 1;
            this.btnXoa.ActiveCornerRadius = 20;
            this.btnXoa.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.ActiveForecolor = System.Drawing.Color.White;
            this.btnXoa.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.IdleBorderThickness = 1;
            this.btnXoa.IdleCornerRadius = 20;
            this.btnXoa.IdleFillColor = System.Drawing.Color.White;
            this.btnXoa.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnXoa.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.Location = new System.Drawing.Point(409, 613);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(148, 49);
            this.btnXoa.TabIndex = 66;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnCapNhat.Location = new System.Drawing.Point(568, 613);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(148, 49);
            this.btnCapNhat.TabIndex = 66;
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1247, 674);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.btnXemPhongDat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.bunifuSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatPhong";
            this.Text = "frmDatPhong";
            this.Load += new System.EventHandler(this.frmDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookRoom)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private Bunifu.Framework.UI.BunifuDatepicker dpkDateCheckOut;
        private System.Windows.Forms.Label label23;
        private Bunifu.Framework.UI.BunifuDatepicker dpkDateCheckIn;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDetails;
        private System.Windows.Forms.DataGridView dataGridViewBookRoom;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXemPhongDat;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDatPhong;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimitPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhNgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhNgayDi;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCapNhat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhanPhongToolStripMenuItem;
    }
}