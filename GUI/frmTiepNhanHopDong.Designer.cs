namespace GUI
{
    partial class frmTiepNhanHopDong
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
            this.btHuy = new System.Windows.Forms.Button();
            this.btDongY = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayDK = new System.Windows.Forms.TextBox();
            this.lbNgayDK = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.lbMaKhachHang = new System.Windows.Forms.Label();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.lbMaHopDong = new System.Windows.Forms.Label();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.lbChiPhi = new System.Windows.Forms.Label();
            this.txtTongTK = new System.Windows.Forms.TextBox();
            this.lbTongTK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.White;
            this.btHuy.Location = new System.Drawing.Point(223, 352);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(115, 45);
            this.btHuy.TabIndex = 7;
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
            this.btDongY.Location = new System.Drawing.Point(51, 352);
            this.btDongY.Name = "btDongY";
            this.btDongY.Size = new System.Drawing.Size(115, 45);
            this.btDongY.TabIndex = 6;
            this.btDongY.Text = "ĐỒNG Ý";
            this.btDongY.UseVisualStyleBackColor = false;
            this.btDongY.Click += new System.EventHandler(this.btDongY_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(47, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 45);
            this.label1.TabIndex = 54;
            this.label1.Text = "Vui lòng nhập thông tin hợp đồng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNgayDK
            // 
            this.txtNgayDK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNgayDK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDK.Location = new System.Drawing.Point(166, 205);
            this.txtNgayDK.Name = "txtNgayDK";
            this.txtNgayDK.Size = new System.Drawing.Size(170, 22);
            this.txtNgayDK.TabIndex = 2;
            this.txtNgayDK.Click += new System.EventHandler(this.txtNgayDK_Click);
            this.txtNgayDK.TextChanged += new System.EventHandler(this.txtNgayDK_TextChanged);
            this.txtNgayDK.Leave += new System.EventHandler(this.txtNgayDK_Leave);
            // 
            // lbNgayDK
            // 
            this.lbNgayDK.BackColor = System.Drawing.Color.Transparent;
            this.lbNgayDK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayDK.ForeColor = System.Drawing.Color.Black;
            this.lbNgayDK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNgayDK.Location = new System.Drawing.Point(47, 205);
            this.lbNgayDK.Name = "lbNgayDK";
            this.lbNgayDK.Size = new System.Drawing.Size(120, 22);
            this.lbNgayDK.TabIndex = 61;
            this.lbNgayDK.Text = "Ngày đăng kí";
            this.lbNgayDK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.Location = new System.Drawing.Point(166, 128);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(170, 22);
            this.txtMaKhachHang.TabIndex = 60;
            this.txtMaKhachHang.TextChanged += new System.EventHandler(this.txtMaKhachHang_TextChanged);
            // 
            // lbMaKhachHang
            // 
            this.lbMaKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lbMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKhachHang.ForeColor = System.Drawing.Color.Black;
            this.lbMaKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMaKhachHang.Location = new System.Drawing.Point(47, 128);
            this.lbMaKhachHang.Name = "lbMaKhachHang";
            this.lbMaKhachHang.Size = new System.Drawing.Size(123, 22);
            this.lbMaKhachHang.TabIndex = 59;
            this.lbMaKhachHang.Text = "Mã khách hàng";
            this.lbMaKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHopDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHopDong.Location = new System.Drawing.Point(166, 168);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.Size = new System.Drawing.Size(170, 22);
            this.txtMaHopDong.TabIndex = 1;
            // 
            // lbMaHopDong
            // 
            this.lbMaHopDong.BackColor = System.Drawing.Color.Transparent;
            this.lbMaHopDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHopDong.ForeColor = System.Drawing.Color.Black;
            this.lbMaHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMaHopDong.Location = new System.Drawing.Point(47, 168);
            this.lbMaHopDong.Name = "lbMaHopDong";
            this.lbMaHopDong.Size = new System.Drawing.Size(120, 22);
            this.lbMaHopDong.TabIndex = 57;
            this.lbMaHopDong.Text = "Mã hợp đồng";
            this.lbMaHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChiPhi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiPhi.Location = new System.Drawing.Point(166, 285);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(170, 22);
            this.txtChiPhi.TabIndex = 4;
            // 
            // lbChiPhi
            // 
            this.lbChiPhi.BackColor = System.Drawing.Color.Transparent;
            this.lbChiPhi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiPhi.ForeColor = System.Drawing.Color.Black;
            this.lbChiPhi.Location = new System.Drawing.Point(49, 284);
            this.lbChiPhi.Name = "lbChiPhi";
            this.lbChiPhi.Size = new System.Drawing.Size(117, 22);
            this.lbChiPhi.TabIndex = 65;
            this.lbChiPhi.Text = "Chi Phí";
            this.lbChiPhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTongTK
            // 
            this.txtTongTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTK.Location = new System.Drawing.Point(166, 245);
            this.txtTongTK.Name = "txtTongTK";
            this.txtTongTK.Size = new System.Drawing.Size(170, 22);
            this.txtTongTK.TabIndex = 3;
            // 
            // lbTongTK
            // 
            this.lbTongTK.BackColor = System.Drawing.Color.Transparent;
            this.lbTongTK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTK.ForeColor = System.Drawing.Color.Black;
            this.lbTongTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTongTK.Location = new System.Drawing.Point(49, 244);
            this.lbTongTK.Name = "lbTongTK";
            this.lbTongTK.Size = new System.Drawing.Size(121, 22);
            this.lbTongTK.TabIndex = 63;
            this.lbTongTK.Text = "Tổng tài khoản";
            this.lbTongTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmTiepNhanHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.txtChiPhi);
            this.Controls.Add(this.lbChiPhi);
            this.Controls.Add(this.txtTongTK);
            this.Controls.Add(this.lbTongTK);
            this.Controls.Add(this.txtNgayDK);
            this.Controls.Add(this.lbNgayDK);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.lbMaKhachHang);
            this.Controls.Add(this.txtMaHopDong);
            this.Controls.Add(this.lbMaHopDong);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btDongY);
            this.Controls.Add(this.label1);
            this.Name = "frmTiepNhanHopDong";
            this.Text = "Tiếp nhận hợp đồng";
            this.Load += new System.EventHandler(this.frmTiepNhanHopDong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btDongY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNgayDK;
        private System.Windows.Forms.Label lbNgayDK;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label lbMaKhachHang;
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.Label lbMaHopDong;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.Label lbChiPhi;
        private System.Windows.Forms.TextBox txtTongTK;
        private System.Windows.Forms.Label lbTongTK;
    }
}