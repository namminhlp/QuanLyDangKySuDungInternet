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
            this.components = new System.ComponentModel.Container();
            this.btXuatPhieuBao = new System.Windows.Forms.Button();
            this.btDongPhiTre = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnTiepNhan = new System.Windows.Forms.Button();
            this.txtThangLap = new System.Windows.Forms.TextBox();
            this.lbThangLap = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.txtTenTruyCap = new System.Windows.Forms.TextBox();
            this.txtMaPhieuBao = new System.Windows.Forms.TextBox();
            this.lbTenTruyCap = new System.Windows.Forms.Label();
            this.lbMaPhieuBao = new System.Windows.Forms.Label();
            this.textTongTien = new System.Windows.Forms.TextBox();
            this.lbTongTienTT = new System.Windows.Forms.Label();
            this.textHinhThucTT = new System.Windows.Forms.TextBox();
            this.lbHinhThucTT = new System.Windows.Forms.Label();
            this.btXacNhanThanhToan = new System.Windows.Forms.Button();
            this.phieuBaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.maPhieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTruyCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhThucTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuBaoBindingSource)).BeginInit();
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuDataGridViewTextBoxColumn,
            this.tenTruyCapDataGridViewTextBoxColumn,
            this.thangLapDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.ngayTTDataGridViewTextBoxColumn,
            this.hinhThucTTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phieuBaoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(809, 366);
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
            // txtThangLap
            // 
            this.txtThangLap.Location = new System.Drawing.Point(317, 47);
            this.txtThangLap.Name = "txtThangLap";
            this.txtThangLap.Size = new System.Drawing.Size(135, 20);
            this.txtThangLap.TabIndex = 34;
            this.txtThangLap.TextChanged += new System.EventHandler(this.txtDCTT_TextChanged);
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
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(590, 17);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(135, 20);
            this.txtTinhTrang.TabIndex = 32;
            this.txtTinhTrang.TextChanged += new System.EventHandler(this.txtDCCD_TextChanged);
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(317, 16);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(135, 20);
            this.txtNgayLap.TabIndex = 30;
            this.txtNgayLap.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
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
            // txtTenTruyCap
            // 
            this.txtTenTruyCap.Location = new System.Drawing.Point(96, 47);
            this.txtTenTruyCap.Name = "txtTenTruyCap";
            this.txtTenTruyCap.Size = new System.Drawing.Size(128, 20);
            this.txtTenTruyCap.TabIndex = 28;
            this.txtTenTruyCap.UseSystemPasswordChar = true;
            // 
            // txtMaPhieuBao
            // 
            this.txtMaPhieuBao.Location = new System.Drawing.Point(96, 14);
            this.txtMaPhieuBao.Name = "txtMaPhieuBao";
            this.txtMaPhieuBao.Size = new System.Drawing.Size(128, 20);
            this.txtMaPhieuBao.TabIndex = 25;
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
            // textTongTien
            // 
            this.textTongTien.Location = new System.Drawing.Point(590, 47);
            this.textTongTien.Name = "textTongTien";
            this.textTongTien.Size = new System.Drawing.Size(135, 20);
            this.textTongTien.TabIndex = 50;
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
            // textHinhThucTT
            // 
            this.textHinhThucTT.Location = new System.Drawing.Point(590, 81);
            this.textHinhThucTT.Name = "textHinhThucTT";
            this.textHinhThucTT.Size = new System.Drawing.Size(135, 20);
            this.textHinhThucTT.TabIndex = 48;
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
            // phieuBaoBindingSource
            // 
            this.phieuBaoBindingSource.DataSource = typeof(DAO.PhieuBao);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 41);
            this.button1.TabIndex = 53;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maPhieuDataGridViewTextBoxColumn
            // 
            this.maPhieuDataGridViewTextBoxColumn.DataPropertyName = "MaPhieu";
            this.maPhieuDataGridViewTextBoxColumn.HeaderText = "Mã phiếu";
            this.maPhieuDataGridViewTextBoxColumn.Name = "maPhieuDataGridViewTextBoxColumn";
            // 
            // tenTruyCapDataGridViewTextBoxColumn
            // 
            this.tenTruyCapDataGridViewTextBoxColumn.DataPropertyName = "TenTruyCap";
            this.tenTruyCapDataGridViewTextBoxColumn.HeaderText = "Tên truy cập";
            this.tenTruyCapDataGridViewTextBoxColumn.Name = "tenTruyCapDataGridViewTextBoxColumn";
            // 
            // thangLapDataGridViewTextBoxColumn
            // 
            this.thangLapDataGridViewTextBoxColumn.DataPropertyName = "ThangLap";
            this.thangLapDataGridViewTextBoxColumn.FillWeight = 75F;
            this.thangLapDataGridViewTextBoxColumn.HeaderText = "Tháng lập";
            this.thangLapDataGridViewTextBoxColumn.Name = "thangLapDataGridViewTextBoxColumn";
            this.thangLapDataGridViewTextBoxColumn.Width = 80;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.FillWeight = 75F;
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "Tình trạng";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            this.tinhTrangDataGridViewTextBoxColumn.Width = 80;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            // 
            // ngayTTDataGridViewTextBoxColumn
            // 
            this.ngayTTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayTTDataGridViewTextBoxColumn.DataPropertyName = "NgayTT";
            this.ngayTTDataGridViewTextBoxColumn.HeaderText = "Ngày TT";
            this.ngayTTDataGridViewTextBoxColumn.Name = "ngayTTDataGridViewTextBoxColumn";
            // 
            // hinhThucTTDataGridViewTextBoxColumn
            // 
            this.hinhThucTTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hinhThucTTDataGridViewTextBoxColumn.DataPropertyName = "HinhThucTT";
            this.hinhThucTTDataGridViewTextBoxColumn.HeaderText = "Hình thức TT";
            this.hinhThucTTDataGridViewTextBoxColumn.Name = "hinhThucTTDataGridViewTextBoxColumn";
            // 
            // frmQuanLyPhieuBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btXacNhanThanhToan);
            this.Controls.Add(this.textTongTien);
            this.Controls.Add(this.lbTongTienTT);
            this.Controls.Add(this.textHinhThucTT);
            this.Controls.Add(this.lbHinhThucTT);
            this.Controls.Add(this.btXuatPhieuBao);
            this.Controls.Add(this.btDongPhiTre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnTiepNhan);
            this.Controls.Add(this.txtThangLap);
            this.Controls.Add(this.lbThangLap);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.lbTinhTrang);
            this.Controls.Add(this.lbNgayLap);
            this.Controls.Add(this.txtTenTruyCap);
            this.Controls.Add(this.txtMaPhieuBao);
            this.Controls.Add(this.lbTenTruyCap);
            this.Controls.Add(this.lbMaPhieuBao);
            this.Name = "frmQuanLyPhieuBao";
            this.Text = "Quản lý phiếu báo";
            this.Load += new System.EventHandler(this.frmQuanLyPhieuBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuBaoBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtThangLap;
        private System.Windows.Forms.Label lbThangLap;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.Label lbNgayLap;
        private System.Windows.Forms.TextBox txtTenTruyCap;
        private System.Windows.Forms.TextBox txtMaPhieuBao;
        private System.Windows.Forms.Label lbTenTruyCap;
        private System.Windows.Forms.Label lbMaPhieuBao;
        private System.Windows.Forms.TextBox textTongTien;
        private System.Windows.Forms.Label lbTongTienTT;
        private System.Windows.Forms.TextBox textHinhThucTT;
        private System.Windows.Forms.Label lbHinhThucTT;
        private System.Windows.Forms.Button btXacNhanThanhToan;
        private System.Windows.Forms.BindingSource phieuBaoBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTruyCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhThucTTDataGridViewTextBoxColumn;
    }
}