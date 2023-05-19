
namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    partial class frmDoiPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiPhong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnClose_ = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnChangeRoom = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataRoomEmpty = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbRoomType = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRoomEmpty)).BeginInit();
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
            // btnClose_
            // 
            this.btnClose_.ActiveBorderThickness = 1;
            this.btnClose_.ActiveCornerRadius = 20;
            this.btnClose_.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnClose_.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose_.ActiveLineColor = System.Drawing.Color.SteelBlue;
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
            this.btnClose_.Location = new System.Drawing.Point(230, 412);
            this.btnClose_.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose_.Name = "btnClose_";
            this.btnClose_.Size = new System.Drawing.Size(203, 40);
            this.btnClose_.TabIndex = 51;
            this.btnClose_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose_.Click += new System.EventHandler(this.btnClose__Click);
            // 
            // btnChangeRoom
            // 
            this.btnChangeRoom.ActiveBorderThickness = 1;
            this.btnChangeRoom.ActiveCornerRadius = 20;
            this.btnChangeRoom.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnChangeRoom.ActiveForecolor = System.Drawing.Color.White;
            this.btnChangeRoom.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnChangeRoom.BackColor = System.Drawing.Color.White;
            this.btnChangeRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeRoom.BackgroundImage")));
            this.btnChangeRoom.ButtonText = "Lưu Thay Đổi";
            this.btnChangeRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeRoom.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnChangeRoom.IdleBorderThickness = 1;
            this.btnChangeRoom.IdleCornerRadius = 20;
            this.btnChangeRoom.IdleFillColor = System.Drawing.Color.White;
            this.btnChangeRoom.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnChangeRoom.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnChangeRoom.Location = new System.Drawing.Point(19, 412);
            this.btnChangeRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangeRoom.Name = "btnChangeRoom";
            this.btnChangeRoom.Size = new System.Drawing.Size(203, 40);
            this.btnChangeRoom.TabIndex = 48;
            this.btnChangeRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChangeRoom.Click += new System.EventHandler(this.btnChangeRoom_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(15, 56);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1079, 19);
            this.bunifuSeparator1.TabIndex = 63;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataRoomEmpty);
            this.groupBox3.Controls.Add(this.cbRoomType);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(19, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 330);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phòng trống";
            // 
            // dataRoomEmpty
            // 
            this.dataRoomEmpty.AllowUserToAddRows = false;
            this.dataRoomEmpty.AllowUserToDeleteRows = false;
            this.dataRoomEmpty.AllowUserToResizeRows = false;
            this.dataRoomEmpty.BackgroundColor = System.Drawing.Color.White;
            this.dataRoomEmpty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRoomEmpty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataRoomEmpty.ColumnHeadersHeight = 29;
            this.dataRoomEmpty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataRoomEmpty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colPrice});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRoomEmpty.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataRoomEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataRoomEmpty.GridColor = System.Drawing.Color.White;
            this.dataRoomEmpty.Location = new System.Drawing.Point(3, 25);
            this.dataRoomEmpty.Name = "dataRoomEmpty";
            this.dataRoomEmpty.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRoomEmpty.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataRoomEmpty.RowHeadersVisible = false;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dataRoomEmpty.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataRoomEmpty.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataRoomEmpty.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataRoomEmpty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRoomEmpty.Size = new System.Drawing.Size(408, 302);
            this.dataRoomEmpty.TabIndex = 53;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colID.DataPropertyName = "TenPH";
            this.colID.HeaderText = "Tên phòng";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 107;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colName.DataPropertyName = "LoaiPH";
            this.colName.FillWeight = 90F;
            this.colName.HeaderText = "Tên Loại Phòng";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 140;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrice.DataPropertyName = "DonGia";
            this.colPrice.HeaderText = "Đơn giá";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // cbRoomType
            // 
            this.cbRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.ItemHeight = 23;
            this.cbRoomType.Location = new System.Drawing.Point(27, 47);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(203, 29);
            this.cbRoomType.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbRoomType.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(23, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Loại phòng:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(423, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 65;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 37);
            this.label2.TabIndex = 62;
            this.label2.Text = "Đổi Phòng";
            // 
            // frmDoiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 458);
            this.Controls.Add(this.btnClose_);
            this.Controls.Add(this.btnChangeRoom);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoiPhong";
            this.Text = "frmDoiPhong";
            this.Load += new System.EventHandler(this.frmDoiPhong_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRoomEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose_;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChangeRoom;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox cbRoomType;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataRoomEmpty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    }
}