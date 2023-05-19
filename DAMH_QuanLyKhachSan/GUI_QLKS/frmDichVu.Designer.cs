
namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    partial class frmDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDichVu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupService = new System.Windows.Forms.GroupBox();
            this.comboboxID = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxServiceType = new MetroFramework.Controls.MetroComboBox();
            this.txbName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveService = new System.Windows.Forms.SaveFileDialog();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnServiceType = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnInsert = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCLose1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupService.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // groupService
            // 
            this.groupService.Controls.Add(this.comboboxID);
            this.groupService.Controls.Add(this.comboBoxServiceType);
            this.groupService.Controls.Add(this.txbName);
            this.groupService.Controls.Add(this.txbPrice);
            this.groupService.Controls.Add(this.label16);
            this.groupService.Controls.Add(this.label15);
            this.groupService.Controls.Add(this.label13);
            this.groupService.Controls.Add(this.label20);
            this.groupService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupService.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupService.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupService.Location = new System.Drawing.Point(15, 193);
            this.groupService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupService.Name = "groupService";
            this.groupService.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupService.Size = new System.Drawing.Size(277, 315);
            this.groupService.TabIndex = 65;
            this.groupService.TabStop = false;
            this.groupService.Text = "Thông tin dịch vụ";
            // 
            // comboboxID
            // 
            this.comboboxID.FormattingEnabled = true;
            this.comboboxID.ItemHeight = 24;
            this.comboboxID.Location = new System.Drawing.Point(20, 53);
            this.comboboxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboboxID.Name = "comboboxID";
            this.comboboxID.Size = new System.Drawing.Size(232, 30);
            this.comboboxID.Style = MetroFramework.MetroColorStyle.Blue;
            this.comboboxID.TabIndex = 60;
            // 
            // comboBoxServiceType
            // 
            this.comboBoxServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxServiceType.ForeColor = System.Drawing.Color.SteelBlue;
            this.comboBoxServiceType.FormattingEnabled = true;
            this.comboBoxServiceType.ItemHeight = 24;
            this.comboBoxServiceType.Location = new System.Drawing.Point(20, 193);
            this.comboBoxServiceType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxServiceType.Name = "comboBoxServiceType";
            this.comboBoxServiceType.Size = new System.Drawing.Size(232, 30);
            this.comboBoxServiceType.Style = MetroFramework.MetroColorStyle.Blue;
            this.comboBoxServiceType.TabIndex = 56;
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
            this.txbName.Location = new System.Drawing.Point(20, 122);
            this.txbName.Margin = new System.Windows.Forms.Padding(0);
            this.txbName.MaxLength = 32767;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(233, 36);
            this.txbName.TabIndex = 1;
            this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbPrice
            // 
            this.txbPrice.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txbPrice.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txbPrice.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txbPrice.BorderThickness = 1;
            this.txbPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPrice.isPassword = false;
            this.txbPrice.Location = new System.Drawing.Point(20, 257);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(0);
            this.txbPrice.MaxLength = 32767;
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(233, 36);
            this.txbPrice.TabIndex = 59;
            this.txbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.SteelBlue;
            this.label16.Location = new System.Drawing.Point(20, 25);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 25);
            this.label16.TabIndex = 22;
            this.label16.Text = "Mã dịch vụ:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SteelBlue;
            this.label15.Location = new System.Drawing.Point(20, 97);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 25);
            this.label15.TabIndex = 24;
            this.label15.Text = "Tên dịch vụ:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SteelBlue;
            this.label13.Location = new System.Drawing.Point(20, 233);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 25);
            this.label13.TabIndex = 57;
            this.label13.Text = "Giá:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.SteelBlue;
            this.label20.Location = new System.Drawing.Point(20, 165);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 25);
            this.label20.TabIndex = 58;
            this.label20.Text = "Loại dịch vụ:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbSearch);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(15, 81);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(575, 111);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
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
            this.txbSearch.Location = new System.Drawing.Point(25, 54);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txbSearch.MaxLength = 32767;
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(233, 36);
            this.txbSearch.TabIndex = 27;
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(20, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tên dịch vụ:";
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
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleCornerRadius = 20;
            this.btnSearch.IdleFillColor = System.Drawing.Color.White;
            this.btnSearch.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnSearch.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Location = new System.Drawing.Point(313, 41);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(233, 49);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(313, 46);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(233, 49);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewService);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(596, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(707, 427);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Dịch Vụ";
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AllowUserToAddRows = false;
            this.dataGridViewService.AllowUserToDeleteRows = false;
            this.dataGridViewService.AllowUserToResizeRows = false;
            this.dataGridViewService.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewService.ColumnHeadersHeight = 29;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colPrice,
            this.colNameServiceType});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewService.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewService.GridColor = System.Drawing.Color.White;
            this.dataGridViewService.Location = new System.Drawing.Point(4, 31);
            this.dataGridViewService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewService.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewService.RowHeadersVisible = false;
            this.dataGridViewService.RowHeadersWidth = 51;
            this.dataGridViewService.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewService.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridViewService.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewService.Size = new System.Drawing.Size(699, 392);
            this.dataGridViewService.TabIndex = 28;
            this.dataGridViewService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewService_CellClick);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colID.DataPropertyName = "id";
            this.colID.FillWeight = 30F;
            this.colID.HeaderText = "Mã";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 69;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "name";
            this.colName.FillWeight = 30F;
            this.colName.HeaderText = "Tên";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 250;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrice.DataPropertyName = "price_new";
            this.colPrice.FillWeight = 30F;
            this.colPrice.HeaderText = "Giá";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 70;
            // 
            // colNameServiceType
            // 
            this.colNameServiceType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNameServiceType.DataPropertyName = "nameServiceType";
            this.colNameServiceType.FillWeight = 30F;
            this.colNameServiceType.HeaderText = "Loại dịch vụ";
            this.colNameServiceType.MinimumWidth = 6;
            this.colNameServiceType.Name = "colNameServiceType";
            this.colNameServiceType.ReadOnly = true;
            // 
            // saveService
            // 
            this.saveService.FileName = "Danh sách dịch vụ";
            this.saveService.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(16, 69);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1287, 15);
            this.bunifuSeparator1.TabIndex = 69;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnServiceType);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.btnCLose1);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(300, 193);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(289, 315);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnServiceType
            // 
            this.btnServiceType.ActiveBorderThickness = 1;
            this.btnServiceType.ActiveCornerRadius = 20;
            this.btnServiceType.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnServiceType.ActiveForecolor = System.Drawing.Color.White;
            this.btnServiceType.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnServiceType.BackColor = System.Drawing.Color.White;
            this.btnServiceType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnServiceType.BackgroundImage")));
            this.btnServiceType.ButtonText = "Sửa Loại Dịch Vụ";
            this.btnServiceType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServiceType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceType.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnServiceType.IdleBorderThickness = 1;
            this.btnServiceType.IdleCornerRadius = 20;
            this.btnServiceType.IdleFillColor = System.Drawing.Color.White;
            this.btnServiceType.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnServiceType.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnServiceType.Location = new System.Drawing.Point(28, 182);
            this.btnServiceType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnServiceType.Name = "btnServiceType";
            this.btnServiceType.Size = new System.Drawing.Size(233, 49);
            this.btnServiceType.TabIndex = 50;
            this.btnServiceType.TabStop = false;
            this.btnServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnServiceType.Click += new System.EventHandler(this.btnServiceType_Click);
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
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnInsert.IdleBorderThickness = 1;
            this.btnInsert.IdleCornerRadius = 20;
            this.btnInsert.IdleFillColor = System.Drawing.Color.White;
            this.btnInsert.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnInsert.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnInsert.Location = new System.Drawing.Point(28, 43);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(233, 49);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.TabStop = false;
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            this.btnCLose1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLose1.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCLose1.IdleBorderThickness = 1;
            this.btnCLose1.IdleCornerRadius = 20;
            this.btnCLose1.IdleFillColor = System.Drawing.Color.White;
            this.btnCLose1.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnCLose1.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnCLose1.Location = new System.Drawing.Point(28, 249);
            this.btnCLose1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCLose1.Name = "btnCLose1";
            this.btnCLose1.Size = new System.Drawing.Size(233, 49);
            this.btnCLose1.TabIndex = 52;
            this.btnCLose1.TabStop = false;
            this.btnCLose1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCLose1.Click += new System.EventHandler(this.btnCLose1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 20;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "Cập Nhật";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 20;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Location = new System.Drawing.Point(28, 113);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(233, 49);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1280, 23);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 63;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(21, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 46);
            this.label6.TabIndex = 68;
            this.label6.Text = "Quản Lí Dịch Vụ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 550);
            this.Controls.Add(this.groupService);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDichVu";
            this.Text = "frmDichVu";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            this.groupService.ResumeLayout(false);
            this.groupService.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox groupService;
        private MetroFramework.Controls.MetroComboBox comboboxID;
        private MetroFramework.Controls.MetroComboBox comboBoxServiceType;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbSearch;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewService;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnServiceType;
        private Bunifu.Framework.UI.BunifuThinButton2 btnInsert;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCLose1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameServiceType;
    }
}