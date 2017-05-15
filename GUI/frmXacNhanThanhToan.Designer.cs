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
            this.txtHinhThucTT = new System.Windows.Forms.ComboBox();
            this.lbHinhThucTT = new System.Windows.Forms.Label();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHinhThucTT
            // 
            this.txtHinhThucTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtHinhThucTT.FormattingEnabled = true;
            this.txtHinhThucTT.Items.AddRange(new object[] {
            "Online",
            "Trực tiếp"});
            this.txtHinhThucTT.Location = new System.Drawing.Point(121, 54);
            this.txtHinhThucTT.Name = "txtHinhThucTT";
            this.txtHinhThucTT.Size = new System.Drawing.Size(130, 21);
            this.txtHinhThucTT.TabIndex = 0;
            // 
            // lbHinhThucTT
            // 
            this.lbHinhThucTT.AutoSize = true;
            this.lbHinhThucTT.Location = new System.Drawing.Point(118, 29);
            this.lbHinhThucTT.Name = "lbHinhThucTT";
            this.lbHinhThucTT.Size = new System.Drawing.Size(133, 13);
            this.lbHinhThucTT.TabIndex = 1;
            this.lbHinhThucTT.Text = "Chọn hình thức thanh toán";
            // 
            // btXacNhan
            // 
            this.btXacNhan.Location = new System.Drawing.Point(87, 108);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btXacNhan.TabIndex = 2;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(197, 108);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 23);
            this.btHuy.TabIndex = 3;
            this.btHuy.Text = "Hủy bỏ";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // frmXacNhanThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btXacNhan);
            this.Controls.Add(this.lbHinhThucTT);
            this.Controls.Add(this.txtHinhThucTT);
            this.Name = "frmXacNhanThanhToan";
            this.Text = "frmXacNhanThanhToan";
            this.Load += new System.EventHandler(this.frmXacNhanThanhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtHinhThucTT;
        private System.Windows.Forms.Label lbHinhThucTT;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.Button btHuy;
    }
}