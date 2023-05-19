
namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    partial class frmLoaiDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiDichVu));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txbSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupServiceType = new System.Windows.Forms.GroupBox();
            this.comboboxID = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewServiceType = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelName = new System.Windows.Forms.Label();
            this.btnCLose1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnInsert = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdateServiceType = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveServiceType = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3.SuspendLayout();
            this.groupServiceType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txbSearch);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(23, 71);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(297, 172);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveBorderThickness = 1;
            this.btnSearch.ActiveCornerRadius = 20;
            this.btnSearch.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearch.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.ButtonText = "Tìm Kiếm";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSearch.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleCornerRadius = 20;
            this.btnSearch.IdleFillColor = System.Drawing.Color.White;
            this.btnSearch.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnSearch.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Location = new System.Drawing.Point(35, 105);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(233, 49);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txbSearch.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txbSearch.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txbSearch.BorderThickness = 1;
            this.txbSearch.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearch.isPassword = false;
            this.txbSearch.Location = new System.Drawing.Point(35, 57);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txbSearch.MaxLength = 32767;
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(233, 36);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(35, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tên loại dịch vụ:";
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.Red;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.Red;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Huỷ Tìm";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.Red;
            this.btnCancel.IdleLineColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(35, 105);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(233, 49);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.TabStop = false;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Visible = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(23, 58);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1037, 17);
            this.bunifuSeparator1.TabIndex = 70;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // groupServiceType
            // 
            this.groupServiceType.Controls.Add(this.comboboxID);
            this.groupServiceType.Controls.Add(this.label1);
            this.groupServiceType.Controls.Add(this.txbName);
            this.groupServiceType.Controls.Add(this.label16);
            this.groupServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupServiceType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupServiceType.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupServiceType.Location = new System.Drawing.Point(23, 245);
            this.groupServiceType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupServiceType.Name = "groupServiceType";
            this.groupServiceType.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupServiceType.Size = new System.Drawing.Size(297, 197);
            this.groupServiceType.TabIndex = 67;
            this.groupServiceType.TabStop = false;
            this.groupServiceType.Text = "Thông tin loại dịch vụ";
            // 
            // comboboxID
            // 
            this.comboboxID.FormattingEnabled = true;
            this.comboboxID.ItemHeight = 24;
            this.comboboxID.Location = new System.Drawing.Point(35, 59);
            this.comboboxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboboxID.Name = "comboboxID";
            this.comboboxID.Size = new System.Drawing.Size(232, 30);
            this.comboboxID.Style = MetroFramework.MetroColorStyle.Blue;
            this.comboboxID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(35, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên loại dịch vụ:";
            // 
            // txbName
            // 
            this.txbName.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txbName.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txbName.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txbName.BorderThickness = 1;
            this.txbName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbName.isPassword = false;
            this.txbName.Location = new System.Drawing.Point(35, 130);
            this.txbName.Margin = new System.Windows.Forms.Padding(0);
            this.txbName.MaxLength = 32767;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(233, 36);
            this.txbName.TabIndex = 1;
            this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label16.ForeColor = System.Drawing.Color.SteelBlue;
            this.label16.Location = new System.Drawing.Point(35, 31);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 25);
            this.label16.TabIndex = 22;
            this.label16.Text = "Mã loại dịch vụ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewServiceType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(328, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(732, 594);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Loại Dịch Vụ";
            // 
            // dataGridViewServiceType
            // 
            this.dataGridViewServiceType.AllowUserToAddRows = false;
            this.dataGridViewServiceType.AllowUserToDeleteRows = false;
            this.dataGridViewServiceType.AllowUserToResizeRows = false;
            this.dataGridViewServiceType.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewServiceType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServiceType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewServiceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServiceType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewServiceType.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewServiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewServiceType.GridColor = System.Drawing.Color.White;
            this.dataGridViewServiceType.Location = new System.Drawing.Point(4, 31);
            this.dataGridViewServiceType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewServiceType.Name = "dataGridViewServiceType";
            this.dataGridViewServiceType.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServiceType.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewServiceType.RowHeadersVisible = false;
            this.dataGridViewServiceType.RowHeadersWidth = 51;
            this.dataGridViewServiceType.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewServiceType.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewServiceType.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewServiceType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServiceType.Size = new System.Drawing.Size(724, 559);
            this.dataGridViewServiceType.TabIndex = 28;
            this.dataGridViewServiceType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServiceType_CellClick);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colID.DataPropertyName = "id";
            this.colID.HeaderText = "Mã loại dịch vụ";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 174;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "name";
            this.colName.FillWeight = 90F;
            this.colName.HeaderText = "Tên loại dịch vụ";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1083, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 65;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelName.Location = new System.Drawing.Point(28, 12);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(329, 46);
            this.labelName.TabIndex = 69;
            this.labelName.Text = "Quản Lí Loại Dịch Vụ";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCLose1
            // 
            this.btnCLose1.ActiveBorderThickness = 1;
            this.btnCLose1.ActiveCornerRadius = 20;
            this.btnCLose1.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnCLose1.ActiveForecolor = System.Drawing.Color.White;
            this.btnCLose1.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnCLose1.BackColor = System.Drawing.Color.White;
            this.btnCLose1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCLose1.BackgroundImage")));
            this.btnCLose1.ButtonText = "Đóng";
            this.btnCLose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCLose1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnCLose1.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCLose1.IdleBorderThickness = 1;
            this.btnCLose1.IdleCornerRadius = 20;
            this.btnCLose1.IdleFillColor = System.Drawing.Color.White;
            this.btnCLose1.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnCLose1.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnCLose1.Location = new System.Drawing.Point(35, 149);
            this.btnCLose1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCLose1.Name = "btnCLose1";
            this.btnCLose1.Size = new System.Drawing.Size(233, 49);
            this.btnCLose1.TabIndex = 25;
            this.btnCLose1.TabStop = false;
            this.btnCLose1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCLose1.Click += new System.EventHandler(this.btnCLose1_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.ActiveBorderThickness = 1;
            this.btnInsert.ActiveCornerRadius = 20;
            this.btnInsert.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnInsert.ActiveForecolor = System.Drawing.Color.White;
            this.btnInsert.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.BackgroundImage")));
            this.btnInsert.ButtonText = "Thêm";
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnInsert.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnInsert.IdleBorderThickness = 1;
            this.btnInsert.IdleCornerRadius = 20;
            this.btnInsert.IdleFillColor = System.Drawing.Color.White;
            this.btnInsert.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnInsert.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnInsert.Location = new System.Drawing.Point(35, 26);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(233, 49);
            this.btnInsert.TabIndex = 26;
            this.btnInsert.TabStop = false;
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdateServiceType
            // 
            this.btnUpdateServiceType.ActiveBorderThickness = 1;
            this.btnUpdateServiceType.ActiveCornerRadius = 20;
            this.btnUpdateServiceType.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateServiceType.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdateServiceType.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateServiceType.BackColor = System.Drawing.Color.White;
            this.btnUpdateServiceType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateServiceType.BackgroundImage")));
            this.btnUpdateServiceType.ButtonText = "Cập Nhật";
            this.btnUpdateServiceType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateServiceType.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnUpdateServiceType.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateServiceType.IdleBorderThickness = 1;
            this.btnUpdateServiceType.IdleCornerRadius = 20;
            this.btnUpdateServiceType.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdateServiceType.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnUpdateServiceType.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateServiceType.Location = new System.Drawing.Point(35, 87);
            this.btnUpdateServiceType.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnUpdateServiceType.Name = "btnUpdateServiceType";
            this.btnUpdateServiceType.Size = new System.Drawing.Size(233, 49);
            this.btnUpdateServiceType.TabIndex = 8;
            this.btnUpdateServiceType.TabStop = false;
            this.btnUpdateServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateServiceType.Click += new System.EventHandler(this.btnUpdateServiceType_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCLose1);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.btnUpdateServiceType);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(23, 443);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(297, 223);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // saveServiceType
            // 
            this.saveServiceType.FileName = "Danh sách loại dịch vụ";
            this.saveServiceType.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
            // 
            // frmLoaiDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 710);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.groupServiceType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLoaiDichVu";
            this.Text = "frmLoaiDichVu";
            this.Load += new System.EventHandler(this.frmLoaiDichVu_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupServiceType.ResumeLayout(false);
            this.groupServiceType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbSearch;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupServiceType;
        private MetroFramework.Controls.MetroComboBox comboboxID;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCLose1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnInsert;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdateServiceType;
        private System.Windows.Forms.SaveFileDialog saveServiceType;
    }
}