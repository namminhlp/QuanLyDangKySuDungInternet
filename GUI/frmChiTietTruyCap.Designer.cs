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
            this.txtThongBao = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.chiTietTruyCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTruyCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSoPhutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietTruyCapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiDataGridViewTextBoxColumn,
            this.tenTruyCapDataGridViewTextBoxColumn,
            this.ngayDataGridViewTextBoxColumn,
            this.tongSoPhutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chiTietTruyCapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 287);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtThongBao
            // 
            this.txtThongBao.BackColor = System.Drawing.SystemColors.Info;
            this.txtThongBao.Location = new System.Drawing.Point(12, 21);
            this.txtThongBao.Name = "txtThongBao";
            this.txtThongBao.Size = new System.Drawing.Size(432, 20);
            this.txtThongBao.TabIndex = 2;
            this.txtThongBao.TextChanged += new System.EventHandler(this.txtThongBao_TextChanged);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(478, 21);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(84, 20);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // chiTietTruyCapBindingSource
            // 
            this.chiTietTruyCapBindingSource.DataSource = typeof(DAO.ChiTiet_TruyCap);
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "Mã loại";
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            this.maLoaiDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenTruyCapDataGridViewTextBoxColumn
            // 
            this.tenTruyCapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenTruyCapDataGridViewTextBoxColumn.DataPropertyName = "TenTruyCap";
            this.tenTruyCapDataGridViewTextBoxColumn.HeaderText = "Tên truy cập";
            this.tenTruyCapDataGridViewTextBoxColumn.Name = "tenTruyCapDataGridViewTextBoxColumn";
            // 
            // ngayDataGridViewTextBoxColumn
            // 
            this.ngayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayDataGridViewTextBoxColumn.DataPropertyName = "Ngay";
            this.ngayDataGridViewTextBoxColumn.HeaderText = "Ngày (mm/dd/yyyy)";
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
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.txtThongBao);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmChiTietTruyCap";
            this.Text = "Chi tiết truy cập";
            this.Load += new System.EventHandler(this.frmChiTietTruyCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietTruyCapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtThongBao;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.BindingSource chiTietTruyCapBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTruyCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongSoPhutDataGridViewTextBoxColumn;
    }
}