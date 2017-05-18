namespace GUI
{
    partial class frmDangNhap
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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.lbFooter = new System.Windows.Forms.Label();
            this.lbInfor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTruyCap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.btDangKy = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btMinimized = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.pnHeader.SuspendLayout();
            this.pnFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.SystemColors.Window;
            this.pnHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnHeader.Controls.Add(this.btMinimized);
            this.pnHeader.Controls.Add(this.lbHeader);
            this.pnHeader.Controls.Add(this.btExit);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(400, 35);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseMove);
            // 
            // lbHeader
            // 
            this.lbHeader.BackColor = System.Drawing.Color.DimGray;
            this.lbHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(330, 35);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Tập đoàn dịch vụ viễn thông ABC";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHeader.Click += new System.EventHandler(this.label1_Click_1);
            this.lbHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.lbHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // pnFooter
            // 
            this.pnFooter.BackColor = System.Drawing.Color.DimGray;
            this.pnFooter.Controls.Add(this.lbFooter);
            this.pnFooter.Controls.Add(this.lbInfor);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 460);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(400, 40);
            this.pnFooter.TabIndex = 1;
            this.pnFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbFooter
            // 
            this.lbFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFooter.ForeColor = System.Drawing.Color.Transparent;
            this.lbFooter.Location = new System.Drawing.Point(12, 5);
            this.lbFooter.Name = "lbFooter";
            this.lbFooter.Size = new System.Drawing.Size(376, 35);
            this.lbFooter.TabIndex = 5;
            this.lbFooter.Text = "Mọi thông tin chi tiết xin liên lạc về đường dây nóng: 190012340  Địa chỉ website" +
    ": abctech.vivu";
            // 
            // lbInfor
            // 
            this.lbInfor.AutoSize = true;
            this.lbInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbInfor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfor.ForeColor = System.Drawing.Color.White;
            this.lbInfor.Location = new System.Drawing.Point(12, 13);
            this.lbInfor.Name = "lbInfor";
            this.lbInfor.Size = new System.Drawing.Size(0, 17);
            this.lbInfor.TabIndex = 4;
            this.lbInfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbInfor.Click += new System.EventHandler(this.lbDangKy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(92, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đăng nhập vào hệ thống";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTenTruyCap
            // 
            this.txtTenTruyCap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenTruyCap.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTruyCap.Location = new System.Drawing.Point(90, 218);
            this.txtTenTruyCap.Name = "txtTenTruyCap";
            this.txtTenTruyCap.Size = new System.Drawing.Size(234, 28);
            this.txtTenTruyCap.TabIndex = 10;
            this.txtTenTruyCap.TextChanged += new System.EventHandler(this.txtTenTruyCap_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(90, 268);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(234, 28);
            this.txtMatKhau.TabIndex = 12;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(25, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 14;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btDangNhap
            // 
            this.btDangNhap.BackColor = System.Drawing.Color.DarkOrange;
            this.btDangNhap.FlatAppearance.BorderSize = 0;
            this.btDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.ForeColor = System.Drawing.Color.White;
            this.btDangNhap.Location = new System.Drawing.Point(61, 332);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(263, 35);
            this.btDangNhap.TabIndex = 15;
            this.btDangNhap.Text = "ĐĂNG NHẬP";
            this.btDangNhap.UseVisualStyleBackColor = false;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btDangKy
            // 
            this.btDangKy.BackColor = System.Drawing.Color.DarkOrange;
            this.btDangKy.FlatAppearance.BorderSize = 0;
            this.btDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangKy.ForeColor = System.Drawing.Color.White;
            this.btDangKy.Location = new System.Drawing.Point(61, 387);
            this.btDangKy.Name = "btDangKy";
            this.btDangKy.Size = new System.Drawing.Size(263, 35);
            this.btDangKy.TabIndex = 16;
            this.btDangKy.Text = "ĐĂNG KÍ ONLINE ?";
            this.btDangKy.UseVisualStyleBackColor = false;
            this.btDangKy.Click += new System.EventHandler(this.button1_Click_1);
            this.btDangKy.MouseLeave += new System.EventHandler(this.btDangKy_MouseLeave);
            this.btDangKy.MouseHover += new System.EventHandler(this.btDangKy_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox4.BackgroundImage = global::GUI.Properties.Resources.thumbnail_nred_padlockicon;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(62, 268);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 28);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.attorney;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(62, 218);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.ABC_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(124, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btMinimized
            // 
            this.btMinimized.BackColor = System.Drawing.Color.DimGray;
            this.btMinimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMinimized.FlatAppearance.BorderSize = 0;
            this.btMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinimized.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btMinimized.Image = global::GUI.Properties.Resources.icon_mini;
            this.btMinimized.Location = new System.Drawing.Point(330, 0);
            this.btMinimized.Name = "btMinimized";
            this.btMinimized.Size = new System.Drawing.Size(35, 35);
            this.btMinimized.TabIndex = 2;
            this.btMinimized.UseVisualStyleBackColor = false;
            this.btMinimized.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btExit
            // 
            this.btExit.AutoSize = true;
            this.btExit.BackColor = System.Drawing.Color.DimGray;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btExit.Image = global::GUI.Properties.Resources.icon_exit;
            this.btExit.Location = new System.Drawing.Point(365, 0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(35, 35);
            this.btExit.TabIndex = 0;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.button1_Click);
            this.btExit.MouseLeave += new System.EventHandler(this.btExit_MouseLeave);
            this.btExit.MouseHover += new System.EventHandler(this.btExit_MouseHover);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.btDangKy);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTruyCap);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmDangNhap";
            this.Text = "Tập đoàn viễn thông ABC Tech";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnFooter.ResumeLayout(false);
            this.pnFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtTenTruyCap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btDangKy;
        private System.Windows.Forms.Label lbInfor;
        private System.Windows.Forms.Label lbFooter;
        private System.Windows.Forms.Button btMinimized;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btExit;
    }
}