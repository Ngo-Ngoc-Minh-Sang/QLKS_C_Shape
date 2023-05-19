
namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    partial class frmPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnRoomType = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCLose1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddRoom = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.labelName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboboxID = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txbLimitPerson = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStatusRoom = new MetroFramework.Controls.MetroComboBox();
            this.txbNameRoom = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.comboBoxRoomType = new MetroFramework.Controls.MetroComboBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.colIDRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimitPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctmPhong = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolsmiDatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsmiThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.groupRoom = new System.Windows.Forms.GroupBox();
            this.saveRoom = new System.Windows.Forms.SaveFileDialog();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSeparateRoom = new MetroFramework.Controls.MetroComboBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.ctmPhong.SuspendLayout();
            this.groupRoom.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnRoomType
            // 
            this.btnRoomType.ActiveBorderThickness = 1;
            this.btnRoomType.ActiveCornerRadius = 20;
            this.btnRoomType.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnRoomType.ActiveForecolor = System.Drawing.Color.White;
            this.btnRoomType.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnRoomType.BackColor = System.Drawing.Color.White;
            this.btnRoomType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoomType.BackgroundImage")));
            this.btnRoomType.ButtonText = "Sửa Loại Phòng";
            this.btnRoomType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomType.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnRoomType.IdleBorderThickness = 1;
            this.btnRoomType.IdleCornerRadius = 15;
            this.btnRoomType.IdleFillColor = System.Drawing.Color.White;
            this.btnRoomType.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnRoomType.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnRoomType.Location = new System.Drawing.Point(247, 35);
            this.btnRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoomType.Name = "btnRoomType";
            this.btnRoomType.Size = new System.Drawing.Size(175, 40);
            this.btnRoomType.TabIndex = 50;
            this.btnRoomType.TabStop = false;
            this.btnRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRoomType.Click += new System.EventHandler(this.btnRoomType_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCLose1);
            this.groupBox4.Controls.Add(this.btnAddRoom);
            this.groupBox4.Controls.Add(this.btnRoomType);
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox4.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox4.Location = new System.Drawing.Point(8, 429);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(444, 138);
            this.groupBox4.TabIndex = 72;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
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
            this.btnCLose1.IdleCornerRadius = 15;
            this.btnCLose1.IdleFillColor = System.Drawing.Color.White;
            this.btnCLose1.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnCLose1.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnCLose1.Location = new System.Drawing.Point(247, 89);
            this.btnCLose1.Margin = new System.Windows.Forms.Padding(4);
            this.btnCLose1.Name = "btnCLose1";
            this.btnCLose1.Size = new System.Drawing.Size(175, 40);
            this.btnCLose1.TabIndex = 51;
            this.btnCLose1.TabStop = false;
            this.btnCLose1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCLose1.Click += new System.EventHandler(this.btnCLose1_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.ActiveBorderThickness = 1;
            this.btnAddRoom.ActiveCornerRadius = 20;
            this.btnAddRoom.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnAddRoom.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddRoom.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnAddRoom.BackColor = System.Drawing.Color.White;
            this.btnAddRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.BackgroundImage")));
            this.btnAddRoom.ButtonText = "Thêm Phòng";
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddRoom.IdleBorderThickness = 1;
            this.btnAddRoom.IdleCornerRadius = 15;
            this.btnAddRoom.IdleFillColor = System.Drawing.Color.White;
            this.btnAddRoom.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnAddRoom.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnAddRoom.Location = new System.Drawing.Point(22, 35);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(175, 40);
            this.btnAddRoom.TabIndex = 8;
            this.btnAddRoom.TabStop = false;
            this.btnAddRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
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
            this.btnUpdate.ButtonText = "Cập Nhật Phòng";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 15;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Location = new System.Drawing.Point(22, 91);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 40);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(247, 38);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(175, 40);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelName.Location = new System.Drawing.Point(12, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(192, 37);
            this.labelName.TabIndex = 70;
            this.labelName.Text = "Quản Lí Phòng";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(22, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mã/ Tên phòng:";
            // 
            // txbSearch
            // 
            this.txbSearch.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txbSearch.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txbSearch.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txbSearch.BorderThickness = 1;
            this.txbSearch.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearch.isPassword = false;
            this.txbSearch.Location = new System.Drawing.Point(22, 44);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearch.MaxLength = 32767;
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(175, 29);
            this.txbSearch.TabIndex = 27;
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnCancel.Location = new System.Drawing.Point(247, 38);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 40);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Visible = false;
            // 
            // comboboxID
            // 
            this.comboboxID.FormattingEnabled = true;
            this.comboboxID.ItemHeight = 23;
            this.comboboxID.Location = new System.Drawing.Point(22, 44);
            this.comboboxID.Name = "comboboxID";
            this.comboboxID.Size = new System.Drawing.Size(175, 29);
            this.comboboxID.Style = MetroFramework.MetroColorStyle.Blue;
            this.comboboxID.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(247, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Số người tối đa:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.SteelBlue;
            this.label16.Location = new System.Drawing.Point(22, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Mã phòng:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.SteelBlue;
            this.label20.Location = new System.Drawing.Point(247, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 20);
            this.label20.TabIndex = 41;
            this.label20.Text = "Loại Phòng:";
            // 
            // txbLimitPerson
            // 
            this.txbLimitPerson.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbLimitPerson.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txbLimitPerson.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txbLimitPerson.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txbLimitPerson.BorderThickness = 1;
            this.txbLimitPerson.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbLimitPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbLimitPerson.Enabled = false;
            this.txbLimitPerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLimitPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbLimitPerson.isPassword = false;
            this.txbLimitPerson.Location = new System.Drawing.Point(247, 156);
            this.txbLimitPerson.Margin = new System.Windows.Forms.Padding(0);
            this.txbLimitPerson.MaxLength = 32767;
            this.txbLimitPerson.Name = "txbLimitPerson";
            this.txbLimitPerson.Size = new System.Drawing.Size(175, 29);
            this.txbLimitPerson.TabIndex = 44;
            this.txbLimitPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SteelBlue;
            this.label13.Location = new System.Drawing.Point(22, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Trạng Thái:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SteelBlue;
            this.label15.Location = new System.Drawing.Point(22, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Tên Phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(247, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Giá phòng:";
            // 
            // comboBoxStatusRoom
            // 
            this.comboBoxStatusRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxStatusRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStatusRoom.ForeColor = System.Drawing.Color.SteelBlue;
            this.comboBoxStatusRoom.FormattingEnabled = true;
            this.comboBoxStatusRoom.ItemHeight = 23;
            this.comboBoxStatusRoom.Location = new System.Drawing.Point(22, 156);
            this.comboBoxStatusRoom.Name = "comboBoxStatusRoom";
            this.comboBoxStatusRoom.Size = new System.Drawing.Size(175, 29);
            this.comboBoxStatusRoom.Style = MetroFramework.MetroColorStyle.Blue;
            this.comboBoxStatusRoom.TabIndex = 4;
            // 
            // txbNameRoom
            // 
            this.txbNameRoom.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txbNameRoom.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txbNameRoom.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txbNameRoom.BorderThickness = 1;
            this.txbNameRoom.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbNameRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameRoom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNameRoom.isPassword = false;
            this.txbNameRoom.Location = new System.Drawing.Point(22, 100);
            this.txbNameRoom.Margin = new System.Windows.Forms.Padding(0);
            this.txbNameRoom.MaxLength = 32767;
            this.txbNameRoom.Name = "txbNameRoom";
            this.txbNameRoom.Size = new System.Drawing.Size(175, 29);
            this.txbNameRoom.TabIndex = 1;
            this.txbNameRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbPrice
            // 
            this.txbPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbPrice.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txbPrice.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txbPrice.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txbPrice.BorderThickness = 1;
            this.txbPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPrice.Enabled = false;
            this.txbPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPrice.isPassword = false;
            this.txbPrice.Location = new System.Drawing.Point(247, 100);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(0);
            this.txbPrice.MaxLength = 32767;
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(175, 29);
            this.txbPrice.TabIndex = 42;
            this.txbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRoomType.ForeColor = System.Drawing.Color.SteelBlue;
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.ItemHeight = 23;
            this.comboBoxRoomType.Location = new System.Drawing.Point(247, 44);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(175, 29);
            this.comboBoxRoomType.Style = MetroFramework.MetroColorStyle.Blue;
            this.comboBoxRoomType.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1117, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 66;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AllowUserToAddRows = false;
            this.dataGridViewRoom.AllowUserToDeleteRows = false;
            this.dataGridViewRoom.AllowUserToResizeRows = false;
            this.dataGridViewRoom.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRoom.ColumnHeadersHeight = 29;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDRoom,
            this.colName,
            this.colNameRoomType,
            this.colPrice,
            this.colLimitPerson,
            this.colStatus});
            this.dataGridViewRoom.ContextMenuStrip = this.ctmPhong;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRoom.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRoom.GridColor = System.Drawing.Color.White;
            this.dataGridViewRoom.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewRoom.RowHeadersVisible = false;
            this.dataGridViewRoom.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewRoom.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRoom.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoom.Size = new System.Drawing.Size(646, 471);
            this.dataGridViewRoom.TabIndex = 28;
            this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick);
            // 
            // colIDRoom
            // 
            this.colIDRoom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colIDRoom.DataPropertyName = "MaPh";
            this.colIDRoom.FillWeight = 90F;
            this.colIDRoom.HeaderText = "Mã";
            this.colIDRoom.Name = "colIDRoom";
            this.colIDRoom.ReadOnly = true;
            this.colIDRoom.Width = 57;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colName.DataPropertyName = "TenPh";
            this.colName.HeaderText = "Tên";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 58;
            // 
            // colNameRoomType
            // 
            this.colNameRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNameRoomType.DataPropertyName = "TenLoaiPH";
            this.colNameRoomType.HeaderText = "Loại Phòng";
            this.colNameRoomType.Name = "colNameRoomType";
            this.colNameRoomType.ReadOnly = true;
            this.colNameRoomType.Width = 113;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrice.DataPropertyName = "GiaPH";
            this.colPrice.HeaderText = "Giá";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 58;
            // 
            // colLimitPerson
            // 
            this.colLimitPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLimitPerson.DataPropertyName = "SoNguoiTD";
            this.colLimitPerson.HeaderText = "Số người tối đa";
            this.colLimitPerson.Name = "colLimitPerson";
            this.colLimitPerson.ReadOnly = true;
            this.colLimitPerson.Width = 141;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.DataPropertyName = "TenTT";
            this.colStatus.HeaderText = "Trạng Thái";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // ctmPhong
            // 
            this.ctmPhong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsmiDatPhong,
            this.toolsmiUpdate,
            this.toolsmiThanhToan});
            this.ctmPhong.Name = "ctmPhong";
            this.ctmPhong.Size = new System.Drawing.Size(135, 70);
            // 
            // toolsmiDatPhong
            // 
            this.toolsmiDatPhong.Name = "toolsmiDatPhong";
            this.toolsmiDatPhong.Size = new System.Drawing.Size(134, 22);
            this.toolsmiDatPhong.Text = "Đặt phòng";
            this.toolsmiDatPhong.Click += new System.EventHandler(this.toolsmiDatPhong_Click);
            // 
            // toolsmiUpdate
            // 
            this.toolsmiUpdate.Name = "toolsmiUpdate";
            this.toolsmiUpdate.Size = new System.Drawing.Size(134, 22);
            this.toolsmiUpdate.Text = "Cập nhật";
            // 
            // toolsmiThanhToan
            // 
            this.toolsmiThanhToan.Name = "toolsmiThanhToan";
            this.toolsmiThanhToan.Size = new System.Drawing.Size(134, 22);
            this.toolsmiThanhToan.Text = "Thanh toán";
            // 
            // groupRoom
            // 
            this.groupRoom.Controls.Add(this.comboboxID);
            this.groupRoom.Controls.Add(this.label2);
            this.groupRoom.Controls.Add(this.label16);
            this.groupRoom.Controls.Add(this.label20);
            this.groupRoom.Controls.Add(this.txbLimitPerson);
            this.groupRoom.Controls.Add(this.label13);
            this.groupRoom.Controls.Add(this.label15);
            this.groupRoom.Controls.Add(this.label1);
            this.groupRoom.Controls.Add(this.comboBoxStatusRoom);
            this.groupRoom.Controls.Add(this.txbNameRoom);
            this.groupRoom.Controls.Add(this.txbPrice);
            this.groupRoom.Controls.Add(this.comboBoxRoomType);
            this.groupRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupRoom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupRoom.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupRoom.Location = new System.Drawing.Point(8, 224);
            this.groupRoom.Name = "groupRoom";
            this.groupRoom.Size = new System.Drawing.Size(444, 199);
            this.groupRoom.TabIndex = 68;
            this.groupRoom.TabStop = false;
            this.groupRoom.Text = "Thông tin phòng";
            // 
            // saveRoom
            // 
            this.saveRoom.FileName = "Danh sách Phòng";
            this.saveRoom.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(8, 58);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1102, 14);
            this.bunifuSeparator1.TabIndex = 71;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSeparateRoom);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txbSearch);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(8, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 150);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewRoom);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(458, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 499);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phòng";
            // 
            // cbSeparateRoom
            // 
            this.cbSeparateRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSeparateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSeparateRoom.FormattingEnabled = true;
            this.cbSeparateRoom.ItemHeight = 23;
            this.cbSeparateRoom.Location = new System.Drawing.Point(22, 98);
            this.cbSeparateRoom.Name = "cbSeparateRoom";
            this.cbSeparateRoom.Size = new System.Drawing.Size(175, 29);
            this.cbSeparateRoom.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbSeparateRoom.TabIndex = 51;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1145, 590);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupRoom);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhong";
            this.Text = "frmPhong";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.ctmPhong.ResumeLayout(false);
            this.groupRoom.ResumeLayout(false);
            this.groupRoom.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCLose1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddRoom;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRoomType;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private System.Windows.Forms.Label labelName;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.GroupBox groupRoom;
        private MetroFramework.Controls.MetroComboBox comboboxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbLimitPerson;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox comboBoxStatusRoom;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbNameRoom;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbPrice;
        private MetroFramework.Controls.MetroComboBox comboBoxRoomType;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.SaveFileDialog saveRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimitPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.ContextMenuStrip ctmPhong;
        private System.Windows.Forms.ToolStripMenuItem toolsmiDatPhong;
        private System.Windows.Forms.ToolStripMenuItem toolsmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem toolsmiThanhToan;
        private MetroFramework.Controls.MetroComboBox cbSeparateRoom;
    }
}