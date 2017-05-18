namespace GUI
{
    partial class frmQuanLyHopDong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lbNgayKyHD = new System.Windows.Forms.Label();
            this.txtLoaiKH = new System.Windows.Forms.TextBox();
            this.lbChiPhi = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lbTongTK = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbNgayDK = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbMaKhachHang = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.lbMaHopDong = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.RichTextBox();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStripHopDong = new System.Windows.Forms.ToolStrip();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btMinimized = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTroGiup = new System.Windows.Forms.Button();
            this.btHopDong = new System.Windows.Forms.Button();
            this.btTaiKhoan = new System.Windows.Forms.Button();
            this.btPhieuBao = new System.Windows.Forms.Button();
            this.btKhachHang = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiPhiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKyHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hopDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btXem = new System.Windows.Forms.ToolStripButton();
            this.btSua = new System.Windows.Forms.ToolStripButton();
            this.btXoa = new System.Windows.Forms.ToolStripButton();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStripHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopDongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSDT
            // 
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(451, 255);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(170, 22);
            this.txtSDT.TabIndex = 46;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // lbNgayKyHD
            // 
            this.lbNgayKyHD.BackColor = System.Drawing.Color.Transparent;
            this.lbNgayKyHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayKyHD.ForeColor = System.Drawing.Color.Black;
            this.lbNgayKyHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNgayKyHD.Location = new System.Drawing.Point(334, 255);
            this.lbNgayKyHD.Name = "lbNgayKyHD";
            this.lbNgayKyHD.Size = new System.Drawing.Size(121, 22);
            this.lbNgayKyHD.TabIndex = 45;
            this.lbNgayKyHD.Text = "Ngày ký HD";
            this.lbNgayKyHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNgayKyHD.Click += new System.EventHandler(this.lbNgayKyHD_Click);
            // 
            // txtLoaiKH
            // 
            this.txtLoaiKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoaiKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiKH.Location = new System.Drawing.Point(451, 219);
            this.txtLoaiKH.Name = "txtLoaiKH";
            this.txtLoaiKH.Size = new System.Drawing.Size(170, 22);
            this.txtLoaiKH.TabIndex = 44;
            this.txtLoaiKH.TextChanged += new System.EventHandler(this.txtLoaiKH_TextChanged);
            // 
            // lbChiPhi
            // 
            this.lbChiPhi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChiPhi.BackColor = System.Drawing.Color.Transparent;
            this.lbChiPhi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiPhi.ForeColor = System.Drawing.Color.Black;
            this.lbChiPhi.Location = new System.Drawing.Point(334, 219);
            this.lbChiPhi.Name = "lbChiPhi";
            this.lbChiPhi.Size = new System.Drawing.Size(121, 22);
            this.lbChiPhi.TabIndex = 43;
            this.lbChiPhi.Text = "Chi Phí";
            this.lbChiPhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbChiPhi.Click += new System.EventHandler(this.lbChiPhi_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCMND.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(451, 181);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(170, 22);
            this.txtCMND.TabIndex = 42;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            // 
            // lbTongTK
            // 
            this.lbTongTK.BackColor = System.Drawing.Color.Transparent;
            this.lbTongTK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTK.ForeColor = System.Drawing.Color.Black;
            this.lbTongTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTongTK.Location = new System.Drawing.Point(334, 180);
            this.lbTongTK.Name = "lbTongTK";
            this.lbTongTK.Size = new System.Drawing.Size(121, 22);
            this.lbTongTK.TabIndex = 41;
            this.lbTongTK.Text = "Tổng tài khoản";
            this.lbTongTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTongTK.Click += new System.EventHandler(this.lbTongTK_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(149, 255);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(170, 22);
            this.txtDiaChi.TabIndex = 40;
            // 
            // lbNgayDK
            // 
            this.lbNgayDK.BackColor = System.Drawing.Color.Transparent;
            this.lbNgayDK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayDK.ForeColor = System.Drawing.Color.Black;
            this.lbNgayDK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNgayDK.Location = new System.Drawing.Point(30, 255);
            this.lbNgayDK.Name = "lbNgayDK";
            this.lbNgayDK.Size = new System.Drawing.Size(123, 22);
            this.lbNgayDK.TabIndex = 39;
            this.lbNgayDK.Text = "Ngày đăng kí";
            this.lbNgayDK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(149, 180);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(170, 22);
            this.txtHoTen.TabIndex = 38;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // lbMaKhachHang
            // 
            this.lbMaKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lbMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKhachHang.ForeColor = System.Drawing.Color.Black;
            this.lbMaKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMaKhachHang.Location = new System.Drawing.Point(30, 180);
            this.lbMaKhachHang.Name = "lbMaKhachHang";
            this.lbMaKhachHang.Size = new System.Drawing.Size(123, 22);
            this.lbMaKhachHang.TabIndex = 37;
            this.lbMaKhachHang.Text = "Mã khách hàng";
            this.lbMaKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMaKhachHang.Click += new System.EventHandler(this.lbMaKhachHang_Click);
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.Location = new System.Drawing.Point(149, 219);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(170, 22);
            this.txtMaKhachHang.TabIndex = 36;
            // 
            // lbMaHopDong
            // 
            this.lbMaHopDong.BackColor = System.Drawing.Color.Transparent;
            this.lbMaHopDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHopDong.ForeColor = System.Drawing.Color.Black;
            this.lbMaHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMaHopDong.Location = new System.Drawing.Point(30, 219);
            this.lbMaHopDong.Name = "lbMaHopDong";
            this.lbMaHopDong.Size = new System.Drawing.Size(120, 22);
            this.lbMaHopDong.TabIndex = 35;
            this.lbMaHopDong.Text = "Mã hợp đồng";
            this.lbMaHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(30, 130);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(325, 25);
            this.txtTimKiem.TabIndex = 34;
            this.txtTimKiem.Text = "";
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.MediumBlue;
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
            this.pnMenu.TabIndex = 31;
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
            this.lbHeader.TabIndex = 28;
            this.lbHeader.Text = "Quản lý hợp đồng";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn,
            this.ngayDKDataGridViewTextBoxColumn,
            this.tongTKDataGridViewTextBoxColumn,
            this.chiPhiDataGridViewTextBoxColumn,
            this.ngayKyHDDataGridViewTextBoxColumn,
            this.khachHangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hopDongBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 300);
            this.dataGridView1.TabIndex = 33;
            // 
            // toolStripHopDong
            // 
            this.toolStripHopDong.AutoSize = false;
            this.toolStripHopDong.BackColor = System.Drawing.Color.Transparent;
            this.toolStripHopDong.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripHopDong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btXem,
            this.btSua,
            this.btXoa});
            this.toolStripHopDong.Location = new System.Drawing.Point(0, 100);
            this.toolStripHopDong.Name = "toolStripHopDong";
            this.toolStripHopDong.Size = new System.Drawing.Size(960, 30);
            this.toolStripHopDong.TabIndex = 32;
            this.toolStripHopDong.Text = "toolStrip1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.mobile_search_icon_x2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(329, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
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
            this.btMinimized.TabIndex = 30;
            this.btMinimized.UseVisualStyleBackColor = false;
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
            this.btExit.TabIndex = 29;
            this.btExit.UseVisualStyleBackColor = false;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.MediumBlue;
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
            // 
            // btTroGiup
            // 
            this.btTroGiup.BackColor = System.Drawing.Color.MediumBlue;
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
            // 
            // btHopDong
            // 
            this.btHopDong.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.btTaiKhoan.BackColor = System.Drawing.Color.MediumBlue;
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
            // 
            // btPhieuBao
            // 
            this.btPhieuBao.BackColor = System.Drawing.Color.MediumBlue;
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
            // 
            // btKhachHang
            // 
            this.btKhachHang.BackColor = System.Drawing.Color.MediumBlue;
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
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.MediumBlue;
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
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "MaHD";
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.Width = 66;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            this.maKHDataGridViewTextBoxColumn.Width = 65;
            // 
            // ngayDKDataGridViewTextBoxColumn
            // 
            this.ngayDKDataGridViewTextBoxColumn.DataPropertyName = "NgayDK";
            this.ngayDKDataGridViewTextBoxColumn.HeaderText = "NgayDK";
            this.ngayDKDataGridViewTextBoxColumn.Name = "ngayDKDataGridViewTextBoxColumn";
            this.ngayDKDataGridViewTextBoxColumn.Width = 75;
            // 
            // tongTKDataGridViewTextBoxColumn
            // 
            this.tongTKDataGridViewTextBoxColumn.DataPropertyName = "TongTK";
            this.tongTKDataGridViewTextBoxColumn.HeaderText = "TongTK";
            this.tongTKDataGridViewTextBoxColumn.Name = "tongTKDataGridViewTextBoxColumn";
            this.tongTKDataGridViewTextBoxColumn.Width = 73;
            // 
            // chiPhiDataGridViewTextBoxColumn
            // 
            this.chiPhiDataGridViewTextBoxColumn.DataPropertyName = "ChiPhi";
            this.chiPhiDataGridViewTextBoxColumn.HeaderText = "ChiPhi";
            this.chiPhiDataGridViewTextBoxColumn.Name = "chiPhiDataGridViewTextBoxColumn";
            this.chiPhiDataGridViewTextBoxColumn.Width = 67;
            // 
            // ngayKyHDDataGridViewTextBoxColumn
            // 
            this.ngayKyHDDataGridViewTextBoxColumn.DataPropertyName = "NgayKyHD";
            this.ngayKyHDDataGridViewTextBoxColumn.HeaderText = "NgayKyHD";
            this.ngayKyHDDataGridViewTextBoxColumn.Name = "ngayKyHDDataGridViewTextBoxColumn";
            this.ngayKyHDDataGridViewTextBoxColumn.Width = 89;
            // 
            // khachHangDataGridViewTextBoxColumn
            // 
            this.khachHangDataGridViewTextBoxColumn.DataPropertyName = "KhachHang";
            this.khachHangDataGridViewTextBoxColumn.HeaderText = "KhachHang";
            this.khachHangDataGridViewTextBoxColumn.Name = "khachHangDataGridViewTextBoxColumn";
            this.khachHangDataGridViewTextBoxColumn.Width = 94;
            // 
            // hopDongBindingSource
            // 
            this.hopDongBindingSource.DataSource = typeof(DAO.HopDong);
            // 
            // btXem
            // 
            this.btXem.AutoSize = false;
            this.btXem.BackColor = System.Drawing.Color.Transparent;
            this.btXem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXem.ForeColor = System.Drawing.Color.Black;
            this.btXem.Image = global::GUI.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh;
            this.btXem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(60, 30);
            this.btXem.Text = "Tải lại";
            // 
            // btSua
            // 
            this.btSua.AutoSize = false;
            this.btSua.BackColor = System.Drawing.Color.Transparent;
            this.btSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.Black;
            this.btSua.Image = global::GUI.Properties.Resources._15_512;
            this.btSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(60, 30);
            this.btSua.Text = "Sửa";
            // 
            // btXoa
            // 
            this.btXoa.AutoSize = false;
            this.btXoa.BackColor = System.Drawing.Color.Transparent;
            this.btXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Black;
            this.btXoa.Image = global::GUI.Properties.Resources.delete_xxl;
            this.btXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(60, 30);
            this.btXoa.Text = "Hủy";
            // 
            // frmQuanLyHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lbNgayKyHD);
            this.Controls.Add(this.txtLoaiKH);
            this.Controls.Add(this.lbChiPhi);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.lbTongTK);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lbNgayDK);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lbMaKhachHang);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.lbMaHopDong);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btMinimized);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStripHopDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyHopDong";
            this.Text = "frmQuanLyHopDong";
            this.Load += new System.EventHandler(this.frmQuanLyHopDong_Load);
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStripHopDong.ResumeLayout(false);
            this.toolStripHopDong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopDongBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lbNgayKyHD;
        private System.Windows.Forms.TextBox txtLoaiKH;
        private System.Windows.Forms.Label lbChiPhi;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lbTongTK;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lbNgayDK;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbMaKhachHang;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label lbMaHopDong;
        private System.Windows.Forms.RichTextBox txtTimKiem;
        private System.Windows.Forms.Button btMinimized;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTroGiup;
        private System.Windows.Forms.Button btHopDong;
        private System.Windows.Forms.Button btTaiKhoan;
        private System.Windows.Forms.Button btPhieuBao;
        private System.Windows.Forms.Button btKhachHang;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton btXem;
        private System.Windows.Forms.ToolStripButton btSua;
        private System.Windows.Forms.ToolStripButton btXoa;
        private System.Windows.Forms.ToolStrip toolStripHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiPhiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKyHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hopDongBindingSource;
    }
}