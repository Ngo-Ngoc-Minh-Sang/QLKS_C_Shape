
namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    partial class frmDichVuAndThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDichVuAndThanhToan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBillRoom = new System.Windows.Forms.GroupBox();
            this.dataPhongDaNhan = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimitPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhNgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhNgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataPhongCoNguoi = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhLoaiPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataPhongDangDon = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.donPhongXongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBillRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhongDaNhan)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhongCoNguoi)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhongDangDon)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // groupBillRoom
            // 
            this.groupBillRoom.Controls.Add(this.dataPhongDaNhan);
            this.groupBillRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBillRoom.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBillRoom.Location = new System.Drawing.Point(364, 54);
            this.groupBillRoom.Name = "groupBillRoom";
            this.groupBillRoom.Size = new System.Drawing.Size(874, 559);
            this.groupBillRoom.TabIndex = 80;
            this.groupBillRoom.TabStop = false;
            this.groupBillRoom.Text = "Hóa đơn tiền phòng";
            // 
            // dataPhongDaNhan
            // 
            this.dataPhongDaNhan.AllowUserToAddRows = false;
            this.dataPhongDaNhan.AllowUserToDeleteRows = false;
            this.dataPhongDaNhan.AllowUserToResizeRows = false;
            this.dataPhongDaNhan.BackgroundColor = System.Drawing.Color.White;
            this.dataPhongDaNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPhongDaNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataPhongDaNhan.ColumnHeadersHeight = 29;
            this.dataPhongDaNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataPhongDaNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colNameRoomType,
            this.colLimitPerson,
            this.colPrice,
            this.clhNgayNhan,
            this.clhNgayDi,
            this.Column1});
            this.dataPhongDaNhan.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPhongDaNhan.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataPhongDaNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPhongDaNhan.GridColor = System.Drawing.Color.White;
            this.dataPhongDaNhan.Location = new System.Drawing.Point(3, 25);
            this.dataPhongDaNhan.Name = "dataPhongDaNhan";
            this.dataPhongDaNhan.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPhongDaNhan.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataPhongDaNhan.RowHeadersVisible = false;
            this.dataPhongDaNhan.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataPhongDaNhan.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPhongDaNhan.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataPhongDaNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPhongDaNhan.Size = new System.Drawing.Size(868, 531);
            this.dataPhongDaNhan.TabIndex = 51;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "TenPH";
            this.colName.HeaderText = "Tên phòng";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colNameRoomType
            // 
            this.colNameRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNameRoomType.DataPropertyName = "DonGia";
            this.colNameRoomType.HeaderText = "Đơn giá";
            this.colNameRoomType.Name = "colNameRoomType";
            this.colNameRoomType.ReadOnly = true;
            // 
            // colLimitPerson
            // 
            this.colLimitPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLimitPerson.DataPropertyName = "NgayNhanPhong";
            this.colLimitPerson.HeaderText = "Ngày nhận";
            this.colLimitPerson.Name = "colLimitPerson";
            this.colLimitPerson.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrice.DataPropertyName = "NgayTraPhong";
            this.colPrice.HeaderText = "Ngày trả";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // clhNgayNhan
            // 
            this.clhNgayNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clhNgayNhan.DataPropertyName = "TamTinh";
            this.clhNgayNhan.HeaderText = "Tiền phòng";
            this.clhNgayNhan.Name = "clhNgayNhan";
            this.clhNgayNhan.ReadOnly = true;
            // 
            // clhNgayDi
            // 
            this.clhNgayDi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clhNgayDi.DataPropertyName = "PhuThu";
            this.clhNgayDi.HeaderText = "Phụ thu";
            this.clhNgayDi.Name = "clhNgayDi";
            this.clhNgayDi.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "ThanhTien";
            this.Column1.HeaderText = "Thành tiên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trảPhòngToolStripMenuItem,
            this.doiPhongToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 48);
            // 
            // trảPhòngToolStripMenuItem
            // 
            this.trảPhòngToolStripMenuItem.Name = "trảPhòngToolStripMenuItem";
            this.trảPhòngToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.trảPhòngToolStripMenuItem.Text = "Trả phòng";
            this.trảPhòngToolStripMenuItem.Click += new System.EventHandler(this.trảPhòngToolStripMenuItem_Click);
            // 
            // doiPhongToolStripMenuItem
            // 
            this.doiPhongToolStripMenuItem.Name = "doiPhongToolStripMenuItem";
            this.doiPhongToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.doiPhongToolStripMenuItem.Text = "Đổi phòng";
            this.doiPhongToolStripMenuItem.Click += new System.EventHandler(this.doiPhongToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1237, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 73;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataPhongCoNguoi);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(-2, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 291);
            this.groupBox3.TabIndex = 74;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phòng đang sử dụng";
            // 
            // dataPhongCoNguoi
            // 
            this.dataPhongCoNguoi.AllowUserToAddRows = false;
            this.dataPhongCoNguoi.AllowUserToDeleteRows = false;
            this.dataPhongCoNguoi.AllowUserToResizeRows = false;
            this.dataPhongCoNguoi.BackgroundColor = System.Drawing.Color.White;
            this.dataPhongCoNguoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPhongCoNguoi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataPhongCoNguoi.ColumnHeadersHeight = 29;
            this.dataPhongCoNguoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataPhongCoNguoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.clhLoaiPH});
            this.dataPhongCoNguoi.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPhongCoNguoi.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataPhongCoNguoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPhongCoNguoi.GridColor = System.Drawing.Color.White;
            this.dataPhongCoNguoi.Location = new System.Drawing.Point(3, 25);
            this.dataPhongCoNguoi.Name = "dataPhongCoNguoi";
            this.dataPhongCoNguoi.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPhongCoNguoi.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataPhongCoNguoi.RowHeadersVisible = false;
            this.dataPhongCoNguoi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataPhongCoNguoi.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataPhongCoNguoi.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPhongCoNguoi.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataPhongCoNguoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPhongCoNguoi.Size = new System.Drawing.Size(354, 263);
            this.dataPhongCoNguoi.TabIndex = 30;
            this.dataPhongCoNguoi.VirtualMode = true;
            this.dataPhongCoNguoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPhongCoNguoi_CellClick_1);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.DataPropertyName = "TenPhong";
            this.colId.HeaderText = "Tên phòng";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // clhLoaiPH
            // 
            this.clhLoaiPH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clhLoaiPH.DataPropertyName = "TenKhach";
            this.clhLoaiPH.HeaderText = "Tên khách";
            this.clhLoaiPH.Name = "clhLoaiPH";
            this.clhLoaiPH.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(1, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 37);
            this.label2.TabIndex = 75;
            this.label2.Text = "Sử Dụng Và Thanh Toán";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-2, 45);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1243, 10);
            this.bunifuSeparator1.TabIndex = 76;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataPhongDangDon);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox4.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox4.Location = new System.Drawing.Point(-4, 348);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 265);
            this.groupBox4.TabIndex = 82;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách phòng đang dọn";
            // 
            // dataPhongDangDon
            // 
            this.dataPhongDangDon.AllowUserToAddRows = false;
            this.dataPhongDangDon.AllowUserToDeleteRows = false;
            this.dataPhongDangDon.AllowUserToResizeRows = false;
            this.dataPhongDangDon.BackgroundColor = System.Drawing.Color.White;
            this.dataPhongDangDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPhongDangDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPhongDangDon.ColumnHeadersHeight = 29;
            this.dataPhongDangDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataPhongDangDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataPhongDangDon.ContextMenuStrip = this.contextMenuStrip2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPhongDangDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataPhongDangDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPhongDangDon.GridColor = System.Drawing.Color.White;
            this.dataPhongDangDon.Location = new System.Drawing.Point(3, 25);
            this.dataPhongDangDon.Name = "dataPhongDangDon";
            this.dataPhongDangDon.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPhongDangDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataPhongDangDon.RowHeadersVisible = false;
            this.dataPhongDangDon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataPhongDangDon.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataPhongDangDon.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPhongDangDon.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataPhongDangDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPhongDangDon.Size = new System.Drawing.Size(354, 237);
            this.dataPhongDangDon.TabIndex = 30;
            this.dataPhongDangDon.VirtualMode = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenPH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên phòng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donPhongXongToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(165, 26);
            // 
            // donPhongXongToolStripMenuItem
            // 
            this.donPhongXongToolStripMenuItem.Name = "donPhongXongToolStripMenuItem";
            this.donPhongXongToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.donPhongXongToolStripMenuItem.Text = "Dọn phòng xong";
            this.donPhongXongToolStripMenuItem.Click += new System.EventHandler(this.donPhongXongToolStripMenuItem_Click);
            // 
            // frmDichVuAndThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 624);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBillRoom);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDichVuAndThanhToan";
            this.Text = "frmDichVuAndThanhToan";
            this.Load += new System.EventHandler(this.frmDichVuAndThanhToan_Load);
            this.groupBillRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPhongDaNhan)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPhongCoNguoi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPhongDangDon)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox groupBillRoom;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trảPhòngToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataPhongCoNguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhLoaiPH;
        private System.Windows.Forms.DataGridView dataPhongDaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimitPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhNgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhNgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ToolStripMenuItem doiPhongToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataPhongDangDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem donPhongXongToolStripMenuItem;
    }
}