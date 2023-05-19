
namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    partial class frmUpPassdefaut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpPassdefaut));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMatKhauMoi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbMatKhauHT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.title = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txbMatKhauMoi);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txbMatKhauHT);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(12, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 135);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "mật khẩu mới";
            // 
            // txbMatKhauMoi
            // 
            this.txbMatKhauMoi.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txbMatKhauMoi.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txbMatKhauMoi.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txbMatKhauMoi.BorderThickness = 1;
            this.txbMatKhauMoi.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbMatKhauMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMatKhauMoi.isPassword = false;
            this.txbMatKhauMoi.Location = new System.Drawing.Point(194, 75);
            this.txbMatKhauMoi.Margin = new System.Windows.Forms.Padding(0);
            this.txbMatKhauMoi.MaxLength = 32767;
            this.txbMatKhauMoi.Name = "txbMatKhauMoi";
            this.txbMatKhauMoi.Size = new System.Drawing.Size(175, 29);
            this.txbMatKhauMoi.TabIndex = 59;
            this.txbMatKhauMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "mật khẩu mặt định hiện tại";
            // 
            // txbMatKhauHT
            // 
            this.txbMatKhauHT.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txbMatKhauHT.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txbMatKhauHT.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txbMatKhauHT.BorderThickness = 1;
            this.txbMatKhauHT.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbMatKhauHT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMatKhauHT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhauHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMatKhauHT.isPassword = false;
            this.txbMatKhauHT.Location = new System.Drawing.Point(194, 25);
            this.txbMatKhauHT.Margin = new System.Windows.Forms.Padding(0);
            this.txbMatKhauHT.MaxLength = 32767;
            this.txbMatKhauHT.Name = "txbMatKhauHT";
            this.txbMatKhauHT.Size = new System.Drawing.Size(175, 29);
            this.txbMatKhauHT.TabIndex = 57;
            this.txbMatKhauHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn);
            this.groupBox1.Controls.Add(this.bunifuThinButton25);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 69);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btn
            // 
            this.btn.ActiveBorderThickness = 1;
            this.btn.ActiveCornerRadius = 20;
            this.btn.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btn.ActiveForecolor = System.Drawing.Color.White;
            this.btn.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.BackColor = System.Drawing.Color.White;
            this.btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn.BackgroundImage")));
            this.btn.ButtonText = "Cập Nhật";
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn.IdleBorderThickness = 1;
            this.btn.IdleCornerRadius = 20;
            this.btn.IdleFillColor = System.Drawing.Color.White;
            this.btn.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btn.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btn.Location = new System.Drawing.Point(7, 21);
            this.btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(175, 40);
            this.btn.TabIndex = 56;
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton25.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "Đóng";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton25.Location = new System.Drawing.Point(194, 21);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(175, 40);
            this.bunifuThinButton25.TabIndex = 55;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(380, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 83;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.SteelBlue;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(354, 37);
            this.title.TabIndex = 85;
            this.title.Text = "Cập nhật mật khẩu mặt định";
            // 
            // frmUpPassdefaut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 296);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpPassdefaut";
            this.Text = "frmUpPassdefaut";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbMatKhauMoi;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbMatKhauHT;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label title;
    }
}