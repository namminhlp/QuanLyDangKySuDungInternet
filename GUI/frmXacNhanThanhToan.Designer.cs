namespace GUI
{
    partial class frmXacNhanThanhToan
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
            this.lbNgayTT = new System.Windows.Forms.Label();
            this.lbHinhThucTT = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btHuy = new System.Windows.Forms.Button();
            this.btDongY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNgayTT
            // 
            this.lbNgayTT.BackColor = System.Drawing.Color.Transparent;
            this.lbNgayTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTT.ForeColor = System.Drawing.Color.Black;
            this.lbNgayTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNgayTT.Location = new System.Drawing.Point(78, 27);
            this.lbNgayTT.Name = "lbNgayTT";
            this.lbNgayTT.Size = new System.Drawing.Size(143, 22);
            this.lbNgayTT.TabIndex = 105;
            this.lbNgayTT.Text = "Ngày thanh toán";
            this.lbNgayTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbHinhThucTT
            // 
            this.lbHinhThucTT.BackColor = System.Drawing.Color.Transparent;
            this.lbHinhThucTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHinhThucTT.ForeColor = System.Drawing.Color.Black;
            this.lbHinhThucTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHinhThucTT.Location = new System.Drawing.Point(78, 103);
            this.lbHinhThucTT.Name = "lbHinhThucTT";
            this.lbHinhThucTT.Size = new System.Drawing.Size(160, 22);
            this.lbHinhThucTT.TabIndex = 102;
            this.lbHinhThucTT.Text = "Hình thức thanh toán";
            this.lbHinhThucTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 22);
            this.dateTimePicker1.TabIndex = 106;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Online",
            "Tại nhà",
            "Chuyển khoản"});
            this.comboBox1.Location = new System.Drawing.Point(82, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 23);
            this.comboBox1.TabIndex = 107;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.White;
            this.btHuy.Location = new System.Drawing.Point(211, 190);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(90, 30);
            this.btHuy.TabIndex = 109;
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
            this.btDongY.Location = new System.Drawing.Point(82, 190);
            this.btDongY.Name = "btDongY";
            this.btDongY.Size = new System.Drawing.Size(90, 30);
            this.btDongY.TabIndex = 108;
            this.btDongY.Text = "ĐỒNG Ý";
            this.btDongY.UseVisualStyleBackColor = false;
            this.btDongY.Click += new System.EventHandler(this.btDongY_Click);
            // 
            // frmXacNhanThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btDongY);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbNgayTT);
            this.Controls.Add(this.lbHinhThucTT);
            this.Name = "frmXacNhanThanhToan";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Xác nhận thanh toán";
            this.Load += new System.EventHandler(this.frmXacNhanThanhToan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNgayTT;
        private System.Windows.Forms.Label lbHinhThucTT;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btDongY;
    }
}