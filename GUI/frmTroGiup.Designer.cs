namespace GUI
{
    partial class frmTroGiup
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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTroGiup = new System.Windows.Forms.Button();
            this.btHopDong = new System.Windows.Forms.Button();
            this.btTaiKhoan = new System.Windows.Forms.Button();
            this.btPhieuBao = new System.Windows.Forms.Button();
            this.btKhachHang = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.btMinimized = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.DarkBlue;
            this.pnMenu.Controls.Add(this.btThoat);
            this.pnMenu.Controls.Add(this.btTroGiup);
            this.pnMenu.Controls.Add(this.btHopDong);
            this.pnMenu.Controls.Add(this.btTaiKhoan);
            this.pnMenu.Controls.Add(this.btPhieuBao);
            this.pnMenu.Controls.Add(this.btKhachHang);
            this.pnMenu.Controls.Add(this.btHome);
            this.pnMenu.Location = new System.Drawing.Point(0, 30);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(960, 70);
            this.pnMenu.TabIndex = 9;
            // 
            // lbHeader
            // 
            this.lbHeader.BackColor = System.Drawing.Color.DimGray;
            this.lbHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(900, 30);
            this.lbHeader.TabIndex = 6;
            this.lbHeader.Text = "Hệ thống quản lý đăng kí sử dụng Internet - ABC Tech Co. Inc";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHeader.Click += new System.EventHandler(this.lbHeader_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImage = global::GUI.Properties.Resources.HelpInfo;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 500);
            this.panel1.TabIndex = 10;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.DarkBlue;
            this.btThoat.FlatAppearance.BorderSize = 0;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.ForeColor = System.Drawing.Color.White;
            this.btThoat.Image = global::GUI.Properties.Resources.btn_carousel_arrow_right;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btThoat.Location = new System.Drawing.Point(425, 0);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(70, 70);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTroGiup
            // 
            this.btTroGiup.BackColor = System.Drawing.Color.DarkBlue;
            this.btTroGiup.FlatAppearance.BorderSize = 0;
            this.btTroGiup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTroGiup.ForeColor = System.Drawing.Color.White;
            this.btTroGiup.Image = global::GUI.Properties.Resources.icon_call;
            this.btTroGiup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btTroGiup.Location = new System.Drawing.Point(355, 0);
            this.btTroGiup.Name = "btTroGiup";
            this.btTroGiup.Size = new System.Drawing.Size(70, 70);
            this.btTroGiup.TabIndex = 5;
            this.btTroGiup.Text = "Trợ giúp";
            this.btTroGiup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btTroGiup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btTroGiup.UseVisualStyleBackColor = false;
            this.btTroGiup.Click += new System.EventHandler(this.btTroGiup_Click);
            // 
            // btHopDong
            // 
            this.btHopDong.BackColor = System.Drawing.Color.DarkBlue;
            this.btHopDong.FlatAppearance.BorderSize = 0;
            this.btHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHopDong.ForeColor = System.Drawing.Color.White;
            this.btHopDong.Image = global::GUI.Properties.Resources.icon_contract;
            this.btHopDong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btHopDong.Location = new System.Drawing.Point(145, 0);
            this.btHopDong.Name = "btHopDong";
            this.btHopDong.Size = new System.Drawing.Size(70, 70);
            this.btHopDong.TabIndex = 4;
            this.btHopDong.Text = "Hợp đồng";
            this.btHopDong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btHopDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btHopDong.UseVisualStyleBackColor = false;
            // 
            // btTaiKhoan
            // 
            this.btTaiKhoan.BackColor = System.Drawing.Color.DarkBlue;
            this.btTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btTaiKhoan.Image = global::GUI.Properties.Resources.incon_key;
            this.btTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btTaiKhoan.Location = new System.Drawing.Point(215, 0);
            this.btTaiKhoan.Name = "btTaiKhoan";
            this.btTaiKhoan.Size = new System.Drawing.Size(70, 70);
            this.btTaiKhoan.TabIndex = 3;
            this.btTaiKhoan.Text = "Tài khoản";
            this.btTaiKhoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btTaiKhoan.UseVisualStyleBackColor = false;
            this.btTaiKhoan.Click += new System.EventHandler(this.btTaiKhoan_Click);
            // 
            // btPhieuBao
            // 
            this.btPhieuBao.BackColor = System.Drawing.Color.DarkBlue;
            this.btPhieuBao.FlatAppearance.BorderSize = 0;
            this.btPhieuBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPhieuBao.ForeColor = System.Drawing.Color.White;
            this.btPhieuBao.Image = global::GUI.Properties.Resources.email_icon;
            this.btPhieuBao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPhieuBao.Location = new System.Drawing.Point(285, 0);
            this.btPhieuBao.Name = "btPhieuBao";
            this.btPhieuBao.Size = new System.Drawing.Size(70, 70);
            this.btPhieuBao.TabIndex = 2;
            this.btPhieuBao.Text = "Phiếu báo";
            this.btPhieuBao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPhieuBao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btPhieuBao.UseVisualStyleBackColor = false;
            this.btPhieuBao.Click += new System.EventHandler(this.btPhieuBao_Click);
            // 
            // btKhachHang
            // 
            this.btKhachHang.BackColor = System.Drawing.Color.DarkBlue;
            this.btKhachHang.FlatAppearance.BorderSize = 0;
            this.btKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKhachHang.ForeColor = System.Drawing.Color.White;
            this.btKhachHang.Image = global::GUI.Properties.Resources.icon_people;
            this.btKhachHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btKhachHang.Location = new System.Drawing.Point(70, 0);
            this.btKhachHang.Name = "btKhachHang";
            this.btKhachHang.Size = new System.Drawing.Size(75, 70);
            this.btKhachHang.TabIndex = 1;
            this.btKhachHang.Text = "Khách hàng";
            this.btKhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btKhachHang.UseVisualStyleBackColor = false;
            this.btKhachHang.Click += new System.EventHandler(this.btKhachHang_Click);
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.DodgerBlue;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Image = global::GUI.Properties.Resources.home_icon;
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btHome.Location = new System.Drawing.Point(0, 0);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(70, 70);
            this.btHome.TabIndex = 0;
            this.btHome.Text = "Trang chủ";
            this.btHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btMinimized
            // 
            this.btMinimized.BackColor = System.Drawing.Color.DimGray;
            this.btMinimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMinimized.FlatAppearance.BorderSize = 0;
            this.btMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinimized.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btMinimized.Image = global::GUI.Properties.Resources.icon_mini;
            this.btMinimized.Location = new System.Drawing.Point(900, 0);
            this.btMinimized.Name = "btMinimized";
            this.btMinimized.Size = new System.Drawing.Size(30, 30);
            this.btMinimized.TabIndex = 8;
            this.btMinimized.UseVisualStyleBackColor = false;
            this.btMinimized.Click += new System.EventHandler(this.btMinimized_Click);
            // 
            // btExit
            // 
            this.btExit.AutoSize = true;
            this.btExit.BackColor = System.Drawing.Color.DimGray;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.Black;
            this.btExit.Image = global::GUI.Properties.Resources.icon_exit;
            this.btExit.Location = new System.Drawing.Point(930, 0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(30, 30);
            this.btExit.TabIndex = 7;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmTroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.btMinimized);
            this.Controls.Add(this.btExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTroGiup";
            this.Text = "frmTroGiup";
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTroGiup;
        private System.Windows.Forms.Button btHopDong;
        private System.Windows.Forms.Button btTaiKhoan;
        private System.Windows.Forms.Button btPhieuBao;
        private System.Windows.Forms.Button btKhachHang;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btMinimized;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panel1;
    }
}