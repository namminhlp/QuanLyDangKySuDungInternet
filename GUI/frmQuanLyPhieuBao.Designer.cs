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
            this.txtLoaiKH = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbThangLap = new System.Windows.Forms.Label();
            this.lbNgayLapPB = new System.Windows.Forms.Label();
            this.lbTenTruyCap = new System.Windows.Forms.Label();
            this.lbMaPhieuBao = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbNgayTT = new System.Windows.Forms.Label();
            this.lbHinhThucTT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.phieuBaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maPhieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTruyCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhThucTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuBaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoaiKH
            // 
            this.txtLoaiKH.Location = new System.Drawing.Point(328, 58);
            this.txtLoaiKH.Name = "txtLoaiKH";
            this.txtLoaiKH.Size = new System.Drawing.Size(133, 20);
            this.txtLoaiKH.TabIndex = 30;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(328, 22);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(133, 20);
            this.txtCMND.TabIndex = 29;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(102, 94);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(129, 20);
            this.txtDiaChi.TabIndex = 28;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(102, 58);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(129, 20);
            this.txtHoTen.TabIndex = 27;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(102, 22);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(129, 20);
            this.txtMaKH.TabIndex = 26;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(263, 61);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(52, 13);
            this.lbTongTien.TabIndex = 25;
            this.lbTongTien.Text = "Tổng tiền";
            // 
            // lbThangLap
            // 
            this.lbThangLap.AutoSize = true;
            this.lbThangLap.Location = new System.Drawing.Point(263, 25);
            this.lbThangLap.Name = "lbThangLap";
            this.lbThangLap.Size = new System.Drawing.Size(55, 13);
            this.lbThangLap.TabIndex = 23;
            this.lbThangLap.Text = "Tháng lập";
            // 
            // lbNgayLapPB
            // 
            this.lbNgayLapPB.AutoSize = true;
            this.lbNgayLapPB.Location = new System.Drawing.Point(23, 101);
            this.lbNgayLapPB.Name = "lbNgayLapPB";
            this.lbNgayLapPB.Size = new System.Drawing.Size(66, 13);
            this.lbNgayLapPB.TabIndex = 22;
            this.lbNgayLapPB.Text = "Ngày lập PB";
            // 
            // lbTenTruyCap
            // 
            this.lbTenTruyCap.AutoSize = true;
            this.lbTenTruyCap.Location = new System.Drawing.Point(23, 61);
            this.lbTenTruyCap.Name = "lbTenTruyCap";
            this.lbTenTruyCap.Size = new System.Drawing.Size(67, 13);
            this.lbTenTruyCap.TabIndex = 21;
            this.lbTenTruyCap.Text = "Tên truy cập";
            // 
            // lbMaPhieuBao
            // 
            this.lbMaPhieuBao.AutoSize = true;
            this.lbMaPhieuBao.Location = new System.Drawing.Point(23, 25);
            this.lbMaPhieuBao.Name = "lbMaPhieuBao";
            this.lbMaPhieuBao.Size = new System.Drawing.Size(72, 13);
            this.lbMaPhieuBao.TabIndex = 20;
            this.lbMaPhieuBao.Text = "Mã phiếu báo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(617, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 36;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(617, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 20);
            this.textBox3.TabIndex = 35;
            // 
            // lbNgayTT
            // 
            this.lbNgayTT.AutoSize = true;
            this.lbNgayTT.Location = new System.Drawing.Point(503, 61);
            this.lbNgayTT.Name = "lbNgayTT";
            this.lbNgayTT.Size = new System.Drawing.Size(86, 13);
            this.lbNgayTT.TabIndex = 34;
            this.lbNgayTT.Text = "Ngày thanh toán";
            // 
            // lbHinhThucTT
            // 
            this.lbHinhThucTT.AutoSize = true;
            this.lbHinhThucTT.Location = new System.Drawing.Point(503, 25);
            this.lbHinhThucTT.Name = "lbHinhThucTT";
            this.lbHinhThucTT.Size = new System.Drawing.Size(107, 13);
            this.lbHinhThucTT.TabIndex = 32;
            this.lbHinhThucTT.Text = "Hình thức thanh toán";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(328, 94);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(133, 20);
            this.txtSDT.TabIndex = 38;
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.Location = new System.Drawing.Point(263, 97);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(55, 13);
            this.lbTinhTrang.TabIndex = 37;
            this.lbTinhTrang.Text = "Tình trạng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuDataGridViewTextBoxColumn,
            this.tenTruyCapDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.thangLapDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn,
            this.ngayTTDataGridViewTextBoxColumn,
            this.hinhThucTTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phieuBaoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(920, 361);
            this.dataGridView1.TabIndex = 39;
            // 
            // phieuBaoBindingSource
            // 
            this.phieuBaoBindingSource.DataSource = typeof(DAO.PhieuBao);
            // 
            // maPhieuDataGridViewTextBoxColumn
            // 
            this.maPhieuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            // 
            // thangLapDataGridViewTextBoxColumn
            // 
            this.thangLapDataGridViewTextBoxColumn.DataPropertyName = "ThangLap";
            this.thangLapDataGridViewTextBoxColumn.HeaderText = "Tháng lập";
            this.thangLapDataGridViewTextBoxColumn.Name = "thangLapDataGridViewTextBoxColumn";
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "Tình trạng";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            this.tinhTrangDataGridViewTextBoxColumn.Width = 80;
            // 
            // ngayTTDataGridViewTextBoxColumn
            // 
            this.ngayTTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayTTDataGridViewTextBoxColumn.DataPropertyName = "NgayTT";
            this.ngayTTDataGridViewTextBoxColumn.HeaderText = "Ngày thanh toán";
            this.ngayTTDataGridViewTextBoxColumn.Name = "ngayTTDataGridViewTextBoxColumn";
            // 
            // hinhThucTTDataGridViewTextBoxColumn
            // 
            this.hinhThucTTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hinhThucTTDataGridViewTextBoxColumn.DataPropertyName = "HinhThucTT";
            this.hinhThucTTDataGridViewTextBoxColumn.HeaderText = "Hình thức thanh toán";
            this.hinhThucTTDataGridViewTextBoxColumn.Name = "hinhThucTTDataGridViewTextBoxColumn";
            // 
            // frmQuanLyPhieuBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lbTinhTrang);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbNgayTT);
            this.Controls.Add(this.lbHinhThucTT);
            this.Controls.Add(this.txtLoaiKH);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.lbThangLap);
            this.Controls.Add(this.lbNgayLapPB);
            this.Controls.Add(this.lbTenTruyCap);
            this.Controls.Add(this.lbMaPhieuBao);
            this.Name = "frmQuanLyPhieuBao";
            this.Text = "Quản lý phiếu báo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuBaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLoaiKH;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbThangLap;
        private System.Windows.Forms.Label lbNgayLapPB;
        private System.Windows.Forms.Label lbTenTruyCap;
        private System.Windows.Forms.Label lbMaPhieuBao;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbNgayTT;
        private System.Windows.Forms.Label lbHinhThucTT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource phieuBaoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTruyCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhThucTTDataGridViewTextBoxColumn;
    }
}