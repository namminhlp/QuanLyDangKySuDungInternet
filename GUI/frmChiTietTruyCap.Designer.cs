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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.brThoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chiTietTruyCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTruyCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSoPhutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietTruyCapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // brThoat
            // 
            this.brThoat.Location = new System.Drawing.Point(505, 15);
            this.brThoat.Name = "brThoat";
            this.brThoat.Size = new System.Drawing.Size(75, 23);
            this.brThoat.TabIndex = 1;
            this.brThoat.Text = "Thoát";
            this.brThoat.UseVisualStyleBackColor = true;
            this.brThoat.Click += new System.EventHandler(this.brThoat_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(25, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 284);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chiTietTruyCapBindingSource
            // 
            this.chiTietTruyCapBindingSource.DataSource = typeof(DAO.ChiTiet_TruyCap);
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "Mã loại";
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
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
            this.ngayDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.ngayDataGridViewTextBoxColumn.Name = "ngayDataGridViewTextBoxColumn";
            // 
            // tongSoPhutDataGridViewTextBoxColumn
            // 
            this.tongSoPhutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongSoPhutDataGridViewTextBoxColumn.DataPropertyName = "TongSoPhut";
            this.tongSoPhutDataGridViewTextBoxColumn.HeaderText = "Tông số phút";
            this.tongSoPhutDataGridViewTextBoxColumn.Name = "tongSoPhutDataGridViewTextBoxColumn";
            // 
            // frmChiTietTruyCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.brThoat);
            this.Controls.Add(this.textBox1);
            this.Name = "frmChiTietTruyCap";
            this.Text = "Chi tiết truy cập";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietTruyCapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button brThoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTruyCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongSoPhutDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource chiTietTruyCapBindingSource;
    }
}