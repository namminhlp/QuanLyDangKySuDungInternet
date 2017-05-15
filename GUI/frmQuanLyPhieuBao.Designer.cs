namespace GUI
{
    partial class frmQuanLyPhieuBao
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
            this.btXuatPhieuBao = new System.Windows.Forms.Button();
            this.btDongPhiTre = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnTiepNhan = new System.Windows.Forms.Button();
            this.txtDCTT = new System.Windows.Forms.TextBox();
            this.lbThangLap = new System.Windows.Forms.Label();
            this.txtDCCD = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.txtMatKhauTTC = new System.Windows.Forms.TextBox();
            this.txtTenTruyCap = new System.Windows.Forms.TextBox();
            this.lbTenTruyCap = new System.Windows.Forms.Label();
            this.lbMaPhieuBao = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTongTienTT = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbHinhThucTT = new System.Windows.Forms.Label();
            this.btXacNhanThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btXuatPhieuBao
            // 
            this.btXuatPhieuBao.Location = new System.Drawing.Point(232, 113);
            this.btXuatPhieuBao.Name = "btXuatPhieuBao";
            this.btXuatPhieuBao.Size = new System.Drawing.Size(105, 41);
            this.btXuatPhieuBao.TabIndex = 45;
            this.btXuatPhieuBao.Text = "Xuất phiếu báo";
            this.btXuatPhieuBao.UseVisualStyleBackColor = true;
            // 
            // btDongPhiTre
            // 
            this.btDongPhiTre.Location = new System.Drawing.Point(96, 113);
            this.btDongPhiTre.Name = "btDongPhiTre";
            this.btDongPhiTre.Size = new System.Drawing.Size(106, 41);
            this.btDongPhiTre.TabIndex = 44;
            this.btDongPhiTre.Text = "Danh sách đóng phí trễ";
            this.btDongPhiTre.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(713, 366);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(852, 79);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 41;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(758, 47);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 39;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(852, 47);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(852, 14);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 37;
            this.btnXem.Text = "Tải lại";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.Location = new System.Drawing.Point(758, 13);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(75, 23);
            this.btnTiepNhan.TabIndex = 40;
            this.btnTiepNhan.Text = "Tiếp nhận";
            this.btnTiepNhan.UseVisualStyleBackColor = true;
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);
            // 
            // txtDCTT
            // 
            this.txtDCTT.Location = new System.Drawing.Point(317, 47);
            this.txtDCTT.Name = "txtDCTT";
            this.txtDCTT.Size = new System.Drawing.Size(135, 20);
            this.txtDCTT.TabIndex = 34;
            this.txtDCTT.TextChanged += new System.EventHandler(this.txtDCTT_TextChanged);
            // 
            // lbThangLap
            // 
            this.lbThangLap.AutoSize = true;
            this.lbThangLap.Location = new System.Drawing.Point(244, 50);
            this.lbThangLap.Name = "lbThangLap";
            this.lbThangLap.Size = new System.Drawing.Size(55, 13);
            this.lbThangLap.TabIndex = 35;
            this.lbThangLap.Text = "Tháng lập";
            this.lbThangLap.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtDCCD
            // 
            this.txtDCCD.Location = new System.Drawing.Point(590, 17);
            this.txtDCCD.Name = "txtDCCD";
            this.txtDCCD.Size = new System.Drawing.Size(135, 20);
            this.txtDCCD.TabIndex = 32;
            this.txtDCCD.TextChanged += new System.EventHandler(this.txtDCCD_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(317, 16);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(135, 20);
            this.txtEmail.TabIndex = 30;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.Location = new System.Drawing.Point(476, 20);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(109, 13);
            this.lbTinhTrang.TabIndex = 33;
            this.lbTinhTrang.Text = "Tình trạng thanh toán";
            this.lbTinhTrang.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.AutoSize = true;
            this.lbNgayLap.Location = new System.Drawing.Point(244, 17);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(49, 13);
            this.lbNgayLap.TabIndex = 31;
            this.lbNgayLap.Text = "Ngày lập";
            this.lbNgayLap.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMatKhauTTC
            // 
            this.txtMatKhauTTC.Location = new System.Drawing.Point(96, 47);
            this.txtMatKhauTTC.Name = "txtMatKhauTTC";
            this.txtMatKhauTTC.Size = new System.Drawing.Size(128, 20);
            this.txtMatKhauTTC.TabIndex = 28;
            this.txtMatKhauTTC.UseSystemPasswordChar = true;
            // 
            // txtTenTruyCap
            // 
            this.txtTenTruyCap.Location = new System.Drawing.Point(96, 14);
            this.txtTenTruyCap.Name = "txtTenTruyCap";
            this.txtTenTruyCap.Size = new System.Drawing.Size(128, 20);
            this.txtTenTruyCap.TabIndex = 25;
            // 
            // lbTenTruyCap
            // 
            this.lbTenTruyCap.AutoSize = true;
            this.lbTenTruyCap.Location = new System.Drawing.Point(20, 50);
            this.lbTenTruyCap.Name = "lbTenTruyCap";
            this.lbTenTruyCap.Size = new System.Drawing.Size(67, 13);
            this.lbTenTruyCap.TabIndex = 26;
            this.lbTenTruyCap.Text = "Tên truy cập";
            // 
            // lbMaPhieuBao
            // 
            this.lbMaPhieuBao.AutoSize = true;
            this.lbMaPhieuBao.Location = new System.Drawing.Point(20, 17);
            this.lbMaPhieuBao.Name = "lbMaPhieuBao";
            this.lbMaPhieuBao.Size = new System.Drawing.Size(72, 13);
            this.lbMaPhieuBao.TabIndex = 24;
            this.lbMaPhieuBao.Text = "Mã phiếu báo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(590, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 50;
            // 
            // lbTongTienTT
            // 
            this.lbTongTienTT.AutoSize = true;
            this.lbTongTienTT.Location = new System.Drawing.Point(476, 52);
            this.lbTongTienTT.Name = "lbTongTienTT";
            this.lbTongTienTT.Size = new System.Drawing.Size(106, 13);
            this.lbTongTienTT.TabIndex = 51;
            this.lbTongTienTT.Text = "Tổng tiền thanh toán";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(590, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 48;
            // 
            // lbHinhThucTT
            // 
            this.lbHinhThucTT.AutoSize = true;
            this.lbHinhThucTT.Location = new System.Drawing.Point(476, 84);
            this.lbHinhThucTT.Name = "lbHinhThucTT";
            this.lbHinhThucTT.Size = new System.Drawing.Size(107, 13);
            this.lbHinhThucTT.TabIndex = 49;
            this.lbHinhThucTT.Text = "Hình thức thanh toán";
            // 
            // btXacNhanThanhToan
            // 
            this.btXacNhanThanhToan.Location = new System.Drawing.Point(367, 113);
            this.btXacNhanThanhToan.Name = "btXacNhanThanhToan";
            this.btXacNhanThanhToan.Size = new System.Drawing.Size(105, 41);
            this.btXacNhanThanhToan.TabIndex = 52;
            this.btXacNhanThanhToan.Text = "Xác nhận thanh toán";
            this.btXacNhanThanhToan.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyPhieuBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.btXacNhanThanhToan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbTongTienTT);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbHinhThucTT);
            this.Controls.Add(this.btXuatPhieuBao);
            this.Controls.Add(this.btDongPhiTre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnTiepNhan);
            this.Controls.Add(this.txtDCTT);
            this.Controls.Add(this.lbThangLap);
            this.Controls.Add(this.txtDCCD);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbTinhTrang);
            this.Controls.Add(this.lbNgayLap);
            this.Controls.Add(this.txtMatKhauTTC);
            this.Controls.Add(this.txtTenTruyCap);
            this.Controls.Add(this.lbTenTruyCap);
            this.Controls.Add(this.lbMaPhieuBao);
            this.Name = "frmQuanLyPhieuBao";
            this.Text = "Quản lý phiếu báo";
            this.Load += new System.EventHandler(this.frmQuanLyPhieuBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btXuatPhieuBao;
        private System.Windows.Forms.Button btDongPhiTre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnTiepNhan;
        private System.Windows.Forms.TextBox txtDCTT;
        private System.Windows.Forms.Label lbThangLap;
        private System.Windows.Forms.TextBox txtDCCD;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.Label lbNgayLap;
        private System.Windows.Forms.TextBox txtMatKhauTTC;
        private System.Windows.Forms.TextBox txtTenTruyCap;
        private System.Windows.Forms.Label lbTenTruyCap;
        private System.Windows.Forms.Label lbMaPhieuBao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbTongTienTT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbHinhThucTT;
        private System.Windows.Forms.Button btXacNhanThanhToan;
    }
}