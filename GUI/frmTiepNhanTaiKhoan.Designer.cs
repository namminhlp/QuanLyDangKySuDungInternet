namespace GUI
{
    partial class frmTiepNhanTaiKhoan
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
            this.lbDiaChiTT = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtDiaChiTT = new System.Windows.Forms.TextBox();
            this.txtDiaChiCD = new System.Windows.Forms.TextBox();
            this.lbDiaChiCD = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.txtTenTruyCap = new System.Windows.Forms.TextBox();
            this.lbTenTruyCap = new System.Windows.Forms.Label();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.lbMaHopDong = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.White;
            this.btHuy.Location = new System.Drawing.Point(223, 404);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(115, 45);
            this.btHuy.TabIndex = 47;
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
            this.btDongY.Location = new System.Drawing.Point(51, 404);
            this.btDongY.Name = "btDongY";
            this.btDongY.Size = new System.Drawing.Size(115, 45);
            this.btDongY.TabIndex = 46;
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
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 45);
            this.label1.TabIndex = 54;
            this.label1.Text = "Vui lòng nhập thông tin tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDiaChiTT
            // 
            this.lbDiaChiTT.BackColor = System.Drawing.Color.Transparent;
            this.lbDiaChiTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChiTT.ForeColor = System.Drawing.Color.Black;
            this.lbDiaChiTT.Location = new System.Drawing.Point(47, 266);
            this.lbDiaChiTT.Name = "lbDiaChiTT";
            this.lbDiaChiTT.Size = new System.Drawing.Size(119, 22);
            this.lbDiaChiTT.TabIndex = 53;
            this.lbDiaChiTT.Text = "D/C thanh toán";
            this.lbDiaChiTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(168, 306);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 22);
            this.txtEmail.TabIndex = 45;
            // 
            // lbEmail
            // 
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Black;
            this.lbEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbEmail.Location = new System.Drawing.Point(47, 305);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(120, 22);
            this.lbEmail.TabIndex = 52;
            this.lbEmail.Text = "Email";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiaChiTT
            // 
            this.txtDiaChiTT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChiTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiTT.Location = new System.Drawing.Point(167, 267);
            this.txtDiaChiTT.Name = "txtDiaChiTT";
            this.txtDiaChiTT.Size = new System.Drawing.Size(170, 22);
            this.txtDiaChiTT.TabIndex = 44;
            // 
            // txtDiaChiCD
            // 
            this.txtDiaChiCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChiCD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiCD.Location = new System.Drawing.Point(168, 226);
            this.txtDiaChiCD.Name = "txtDiaChiCD";
            this.txtDiaChiCD.Size = new System.Drawing.Size(170, 22);
            this.txtDiaChiCD.TabIndex = 43;
            // 
            // lbDiaChiCD
            // 
            this.lbDiaChiCD.BackColor = System.Drawing.Color.Transparent;
            this.lbDiaChiCD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChiCD.ForeColor = System.Drawing.Color.Black;
            this.lbDiaChiCD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDiaChiCD.Location = new System.Drawing.Point(47, 225);
            this.lbDiaChiCD.Name = "lbDiaChiCD";
            this.lbDiaChiCD.Size = new System.Drawing.Size(119, 22);
            this.lbDiaChiCD.TabIndex = 51;
            this.lbDiaChiCD.Text = "D/C cài đặt";
            this.lbDiaChiCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(168, 188);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(170, 22);
            this.txtMatKhau.TabIndex = 42;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lbMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.ForeColor = System.Drawing.Color.Black;
            this.lbMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMatKhau.Location = new System.Drawing.Point(47, 187);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(120, 22);
            this.lbMatKhau.TabIndex = 50;
            this.lbMatKhau.Text = "Mật khẩu";
            this.lbMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenTruyCap
            // 
            this.txtTenTruyCap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenTruyCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTruyCap.Location = new System.Drawing.Point(168, 150);
            this.txtTenTruyCap.Name = "txtTenTruyCap";
            this.txtTenTruyCap.Size = new System.Drawing.Size(170, 22);
            this.txtTenTruyCap.TabIndex = 41;
            // 
            // lbTenTruyCap
            // 
            this.lbTenTruyCap.BackColor = System.Drawing.Color.Transparent;
            this.lbTenTruyCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTruyCap.ForeColor = System.Drawing.Color.Black;
            this.lbTenTruyCap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTenTruyCap.Location = new System.Drawing.Point(47, 149);
            this.lbTenTruyCap.Name = "lbTenTruyCap";
            this.lbTenTruyCap.Size = new System.Drawing.Size(121, 22);
            this.lbTenTruyCap.TabIndex = 49;
            this.lbTenTruyCap.Text = "Tên truy cập";
            this.lbTenTruyCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHopDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHopDong.Location = new System.Drawing.Point(168, 111);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.Size = new System.Drawing.Size(170, 22);
            this.txtMaHopDong.TabIndex = 40;
            // 
            // lbMaHopDong
            // 
            this.lbMaHopDong.BackColor = System.Drawing.Color.Transparent;
            this.lbMaHopDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHopDong.ForeColor = System.Drawing.Color.Black;
            this.lbMaHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMaHopDong.Location = new System.Drawing.Point(47, 111);
            this.lbMaHopDong.Name = "lbMaHopDong";
            this.lbMaHopDong.Size = new System.Drawing.Size(121, 22);
            this.lbMaHopDong.TabIndex = 48;
            this.lbMaHopDong.Text = "Mã hợp đồng";
            this.lbMaHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lbTrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.ForeColor = System.Drawing.Color.Black;
            this.lbTrangThai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTrangThai.Location = new System.Drawing.Point(48, 345);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(120, 22);
            this.lbTrangThai.TabIndex = 56;
            this.lbTrangThai.Text = "Trạng thái";
            this.lbTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.FormattingEnabled = true;
            this.txtTrangThai.Items.AddRange(new object[] {
            "True",
            "False"});
            this.txtTrangThai.Location = new System.Drawing.Point(170, 344);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(169, 23);
            this.txtTrangThai.TabIndex = 57;
            // 
            // frmTiepNhanTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btDongY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDiaChiTT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtDiaChiTT);
            this.Controls.Add(this.txtDiaChiCD);
            this.Controls.Add(this.lbDiaChiCD);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.txtTenTruyCap);
            this.Controls.Add(this.lbTenTruyCap);
            this.Controls.Add(this.txtMaHopDong);
            this.Controls.Add(this.lbMaHopDong);
            this.Name = "frmTiepNhanTaiKhoan";
            this.Text = "Tiếp nhận tài khoản";
            this.Load += new System.EventHandler(this.frmTiepNhanTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btDongY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDiaChiTT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtDiaChiTT;
        private System.Windows.Forms.TextBox txtDiaChiCD;
        private System.Windows.Forms.Label lbDiaChiCD;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox txtTenTruyCap;
        private System.Windows.Forms.Label lbTenTruyCap;
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.Label lbMaHopDong;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.ComboBox txtTrangThai;
    }
}