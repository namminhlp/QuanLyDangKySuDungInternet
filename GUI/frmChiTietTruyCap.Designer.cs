namespace GUI
{
    partial class frmChiTietTruyCap
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbHeader = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btXem = new System.Windows.Forms.ToolStripButton();
            this.btXemTheoThang = new System.Windows.Forms.ToolStripButton();
            this.maCTTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSoPhutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietTruyCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btThoat = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietTruyCapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCTTCDataGridViewTextBoxColumn,
            this.maPhieuDataGridViewTextBoxColumn,
            this.maLoaiDataGridViewTextBoxColumn,
            this.ngayDataGridViewTextBoxColumn,
            this.tongSoPhutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chiTietTruyCapBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 340);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbHeader
            // 
            this.lbHeader.BackColor = System.Drawing.Color.DarkGray;
            this.lbHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.Transparent;
            this.lbHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(600, 30);
            this.lbHeader.TabIndex = 77;
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHeader.Click += new System.EventHandler(this.lbHeader_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btXemTheoThang,
            this.btXem,
            this.btThoat});
            this.toolStrip1.Location = new System.Drawing.Point(278, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(322, 30);
            this.toolStrip1.TabIndex = 78;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 29);
            this.dateTimePicker1.TabIndex = 79;
            // 
            // btXem
            // 
            this.btXem.AutoSize = false;
            this.btXem.BackColor = System.Drawing.Color.Transparent;
            this.btXem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXem.ForeColor = System.Drawing.Color.Black;
            this.btXem.Image = global::GUI.Properties.Resources._678134_sign_check_512;
            this.btXem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(80, 30);
            this.btXem.Text = "Xem hết";
            // 
            // btXemTheoThang
            // 
            this.btXemTheoThang.AutoSize = false;
            this.btXemTheoThang.BackColor = System.Drawing.Color.Transparent;
            this.btXemTheoThang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemTheoThang.ForeColor = System.Drawing.Color.Black;
            this.btXemTheoThang.Image = global::GUI.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_arrow_left_double;
            this.btXemTheoThang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btXemTheoThang.Name = "btXemTheoThang";
            this.btXemTheoThang.Size = new System.Drawing.Size(135, 30);
            this.btXemTheoThang.Text = "Xem theo tháng";
            // 
            // maCTTCDataGridViewTextBoxColumn
            // 
            this.maCTTCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maCTTCDataGridViewTextBoxColumn.DataPropertyName = "MaCTTC";
            this.maCTTCDataGridViewTextBoxColumn.HeaderText = "Mã chi tiết truy cập";
            this.maCTTCDataGridViewTextBoxColumn.Name = "maCTTCDataGridViewTextBoxColumn";
            // 
            // maPhieuDataGridViewTextBoxColumn
            // 
            this.maPhieuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maPhieuDataGridViewTextBoxColumn.DataPropertyName = "MaPhieu";
            this.maPhieuDataGridViewTextBoxColumn.HeaderText = "Mã phiếu";
            this.maPhieuDataGridViewTextBoxColumn.Name = "maPhieuDataGridViewTextBoxColumn";
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "Mã loại";
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            // 
            // ngayDataGridViewTextBoxColumn
            // 
            this.ngayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayDataGridViewTextBoxColumn.DataPropertyName = "Ngay";
            this.ngayDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.ngayDataGridViewTextBoxColumn.Name = "ngayDataGridViewTextBoxColumn";
            // 
            // tongSoPhutDataGridViewTextBoxColumn
            // 
            this.tongSoPhutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongSoPhutDataGridViewTextBoxColumn.DataPropertyName = "TongSoPhut";
            this.tongSoPhutDataGridViewTextBoxColumn.HeaderText = "Tổng số phút";
            this.tongSoPhutDataGridViewTextBoxColumn.Name = "tongSoPhutDataGridViewTextBoxColumn";
            // 
            // chiTietTruyCapBindingSource
            // 
            this.chiTietTruyCapBindingSource.DataSource = typeof(DAO.ChiTiet_TruyCap);
            // 
            // btThoat
            // 
            this.btThoat.AutoSize = false;
            this.btThoat.BackColor = System.Drawing.Color.Transparent;
            this.btThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.Black;
            this.btThoat.Image = global::GUI.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh;
            this.btThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(80, 30);
            this.btThoat.Text = "Quay lại";
            // 
            // frmChiTietTruyCap
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmChiTietTruyCap";
            this.Text = "Chi tiết truy cập";
            this.Load += new System.EventHandler(this.frmChiTietTruyCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietTruyCapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCTTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongSoPhutDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource chiTietTruyCapBindingSource;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btXem;
        private System.Windows.Forms.ToolStripButton btXemTheoThang;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripButton btThoat;
    }
}