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
            this.chiTietTruyCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maCTTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSoPhutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietTruyCapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCTTCDataGridViewTextBoxColumn,
            this.maPhieuDataGridViewTextBoxColumn,
            this.maLoaiDataGridViewTextBoxColumn,
            this.ngayDataGridViewTextBoxColumn,
            this.tongSoPhutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chiTietTruyCapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chiTietTruyCapBindingSource
            // 
            this.chiTietTruyCapBindingSource.DataSource = typeof(DAO.ChiTiet_TruyCap);
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
            // frmChiTietTruyCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 561);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmChiTietTruyCap";
            this.Text = "frmChiTietTruyCap";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}