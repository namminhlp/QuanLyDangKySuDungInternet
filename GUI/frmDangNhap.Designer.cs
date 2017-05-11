namespace GUI
{
    partial class frmDangNhap
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
            this.grpDangNhap = new System.Windows.Forms.GroupBox();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.radCustomer = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.grpDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDangNhap
            // 
            this.grpDangNhap.Controls.Add(this.radAdmin);
            this.grpDangNhap.Controls.Add(this.radCustomer);
            this.grpDangNhap.Controls.Add(this.button1);
            this.grpDangNhap.Controls.Add(this.btDangNhap);
            this.grpDangNhap.Controls.Add(this.txtMatKhau);
            this.grpDangNhap.Controls.Add(this.txtTaiKhoan);
            this.grpDangNhap.Controls.Add(this.lblMatKhau);
            this.grpDangNhap.Controls.Add(this.lblTaiKhoan);
            this.grpDangNhap.Location = new System.Drawing.Point(36, 24);
            this.grpDangNhap.Name = "grpDangNhap";
            this.grpDangNhap.Size = new System.Drawing.Size(314, 203);
            this.grpDangNhap.TabIndex = 0;
            this.grpDangNhap.TabStop = false;
            this.grpDangNhap.Text = "Đăng nhập vào hệ thống";
            this.grpDangNhap.Enter += new System.EventHandler(this.grpDangNhap_Enter);
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.Location = new System.Drawing.Point(173, 110);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(85, 17);
            this.radAdmin.TabIndex = 7;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "Quản trị viên";
            this.radAdmin.UseVisualStyleBackColor = true;
            this.radAdmin.CheckedChanged += new System.EventHandler(this.radAdmin_CheckedChanged);
            // 
            // radCustomer
            // 
            this.radCustomer.AutoSize = true;
            this.radCustomer.Checked = true;
            this.radCustomer.Location = new System.Drawing.Point(55, 110);
            this.radCustomer.Name = "radCustomer";
            this.radCustomer.Size = new System.Drawing.Size(83, 17);
            this.radCustomer.TabIndex = 6;
            this.radCustomer.TabStop = true;
            this.radCustomer.Text = "Khách hàng";
            this.radCustomer.UseVisualStyleBackColor = true;
            this.radCustomer.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(50, 148);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(90, 34);
            this.btDangNhap.TabIndex = 4;
            this.btDangNhap.Text = "ĐĂNG NHẬP";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(115, 72);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(161, 20);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(115, 38);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(161, 20);
            this.txtTaiKhoan.TabIndex = 2;
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(47, 75);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(53, 13);
            this.lblMatKhau.TabIndex = 1;
            this.lblMatKhau.Text = "Mật Khẩu";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(47, 41);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(55, 13);
            this.lblTaiKhoan.TabIndex = 0;
            this.lblTaiKhoan.Text = "Tài khoản";
            this.lblTaiKhoan.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.grpDangNhap);
            this.Name = "frmDangNhap";
            this.Text = "Hệ thống quản lý đăng kí sử dụng Internet ABC";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.grpDangNhap.ResumeLayout(false);
            this.grpDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDangNhap;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.RadioButton radCustomer;
    }
}