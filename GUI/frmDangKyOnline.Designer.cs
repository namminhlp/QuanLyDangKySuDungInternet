namespace GUI
{
    partial class frmDangKyOnline
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
            this.btMinimized = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lbCMND = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txtTongTK = new System.Windows.Forms.TextBox();
            this.lbTongTK = new System.Windows.Forms.Label();
            this.btHuy = new System.Windows.Forms.Button();
            this.btDongY = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbLoaiKH = new System.Windows.Forms.Label();
            this.txtLoaiKH = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btMinimized.Location = new System.Drawing.Point(440, 0);
            this.btMinimized.Name = "btMinimized";
            this.btMinimized.Size = new System.Drawing.Size(30, 30);
            this.btMinimized.TabIndex = 7;
            this.btMinimized.UseVisualStyleBackColor = false;
            this.btMinimized.Click += new System.EventHandler(this.btMinimized_Click);
            // 
            // btExit
            // 
            this.btExit.AutoSize = true;
            this.btExit.BackColor = System.Drawing.Color.DimGray;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.Black;
            this.btExit.Image = global::GUI.Properties.Resources.icon_exit;
            this.btExit.Location = new System.Drawing.Point(470, 0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(30, 30);
            this.btExit.TabIndex = 6;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.BackColor = System.Drawing.Color.DimGray;
            this.lbHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(440, 30);
            this.lbHeader.TabIndex = 5;
            this.lbHeader.Text = "Đăng kí thuê bao sử dụng hệ thống Internet - ABC Tech Co. Inc";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(180, 210);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(170, 22);
            this.txtSDT.TabIndex = 68;
            // 
            // lbSDT
            // 
            this.lbSDT.BackColor = System.Drawing.Color.Transparent;
            this.lbSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.ForeColor = System.Drawing.Color.Black;
            this.lbSDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbSDT.Location = new System.Drawing.Point(44, 209);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(120, 22);
            this.lbSDT.TabIndex = 72;
            this.lbSDT.Text = "Số điện thoại";
            this.lbSDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCMND
            // 
            this.txtCMND.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCMND.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(180, 130);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(170, 22);
            this.txtCMND.TabIndex = 66;
            // 
            // lbCMND
            // 
            this.lbCMND.BackColor = System.Drawing.Color.Transparent;
            this.lbCMND.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMND.ForeColor = System.Drawing.Color.Black;
            this.lbCMND.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCMND.Location = new System.Drawing.Point(44, 129);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(119, 22);
            this.lbCMND.TabIndex = 71;
            this.lbCMND.Text = "CMND";
            this.lbCMND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(180, 92);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(170, 22);
            this.txtDiaChi.TabIndex = 65;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lbDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lbDiaChi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDiaChi.Location = new System.Drawing.Point(44, 91);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(120, 22);
            this.lbDiaChi.TabIndex = 70;
            this.lbDiaChi.Text = "Địa chỉ";
            this.lbDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(180, 54);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(170, 22);
            this.txtHoTen.TabIndex = 64;
            // 
            // lbHoTen
            // 
            this.lbHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lbHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.ForeColor = System.Drawing.Color.Black;
            this.lbHoTen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHoTen.Location = new System.Drawing.Point(44, 53);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(121, 22);
            this.lbHoTen.TabIndex = 69;
            this.lbHoTen.Text = "Họ tên";
            this.lbHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTongTK
            // 
            this.txtTongTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTK.Location = new System.Drawing.Point(180, 249);
            this.txtTongTK.Name = "txtTongTK";
            this.txtTongTK.Size = new System.Drawing.Size(170, 22);
            this.txtTongTK.TabIndex = 69;
            // 
            // lbTongTK
            // 
            this.lbTongTK.BackColor = System.Drawing.Color.Transparent;
            this.lbTongTK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTK.ForeColor = System.Drawing.Color.Black;
            this.lbTongTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTongTK.Location = new System.Drawing.Point(44, 248);
            this.lbTongTK.Name = "lbTongTK";
            this.lbTongTK.Size = new System.Drawing.Size(121, 22);
            this.lbTongTK.TabIndex = 75;
            this.lbTongTK.Text = "Số lượng TK";
            this.lbTongTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.White;
            this.btHuy.Location = new System.Drawing.Point(335, 421);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(115, 45);
            this.btHuy.TabIndex = 71;
            this.btHuy.Text = "HỦY";
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btDongY
            // 
            this.btDongY.BackColor = System.Drawing.Color.DodgerBlue;
            this.btDongY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDongY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDongY.ForeColor = System.Drawing.Color.White;
            this.btDongY.Location = new System.Drawing.Point(50, 421);
            this.btDongY.Name = "btDongY";
            this.btDongY.Size = new System.Drawing.Size(115, 45);
            this.btDongY.TabIndex = 70;
            this.btDongY.Text = "ĐỒNG Ý";
            this.btDongY.UseVisualStyleBackColor = false;
            this.btDongY.Click += new System.EventHandler(this.btDongY_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLoaiKH);
            this.groupBox1.Controls.Add(this.lbLoaiKH);
            this.groupBox1.Controls.Add(this.txtTongTK);
            this.groupBox1.Controls.Add(this.lbTongTK);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.lbSDT);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.lbCMND);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.lbDiaChi);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.lbHoTen);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 309);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng cho hợp đồng";
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(400, 40);
            this.label6.TabIndex = 80;
            this.label6.Text = "Vui lòng nhập thông tin đăng kí hợp đồng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbLoaiKH
            // 
            this.lbLoaiKH.BackColor = System.Drawing.Color.Transparent;
            this.lbLoaiKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiKH.ForeColor = System.Drawing.Color.Black;
            this.lbLoaiKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbLoaiKH.Location = new System.Drawing.Point(44, 169);
            this.lbLoaiKH.Name = "lbLoaiKH";
            this.lbLoaiKH.Size = new System.Drawing.Size(130, 22);
            this.lbLoaiKH.TabIndex = 77;
            this.lbLoaiKH.Text = "Loại khách hàng";
            this.lbLoaiKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLoaiKH
            // 
            this.txtLoaiKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiKH.FormattingEnabled = true;
            this.txtLoaiKH.Items.AddRange(new object[] {
            "Cá nhân",
            "Đơn vị"});
            this.txtLoaiKH.Location = new System.Drawing.Point(180, 167);
            this.txtLoaiKH.Name = "txtLoaiKH";
            this.txtLoaiKH.Size = new System.Drawing.Size(170, 23);
            this.txtLoaiKH.TabIndex = 68;
            // 
            // frmDangKyOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btDongY);
            this.Controls.Add(this.btMinimized);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.lbHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangKyOnline";
            this.Text = "frmDangKyOnline";
            this.Load += new System.EventHandler(this.frmDangKyOnline_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMinimized;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txtTongTK;
        private System.Windows.Forms.Label lbTongTK;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btDongY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbLoaiKH;
        private System.Windows.Forms.ComboBox txtLoaiKH;
    }
}