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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNgayKyHD = new System.Windows.Forms.TextBox();
            this.lbNgayKyHD = new System.Windows.Forms.Label();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.lbChiPhi = new System.Windows.Forms.Label();
            this.txtTongTK = new System.Windows.Forms.TextBox();
            this.lbTongTK = new System.Windows.Forms.Label();
            this.txtNgayDK = new System.Windows.Forms.TextBox();
            this.lbNgayDK = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.lbMaKhachHang = new System.Windows.Forms.Label();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.lbMaHopDong = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.RichTextBox();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTroGiup = new System.Windows.Forms.Button();
            this.btHopDong = new System.Windows.Forms.Button();
            this.btTaiKhoan = new System.Windows.Forms.Button();
            this.btPhieuBao = new System.Windows.Forms.Button();
            this.btKhachHang = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiPhiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKyHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hopDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripHopDong = new System.Windows.Forms.ToolStrip();
            this.btXem = new System.Windows.Forms.ToolStripButton();
            this.btThem = new System.Windows.Forms.ToolStripButton();
            this.btSua = new System.Windows.Forms.ToolStripButton();
            this.btXoa = new System.Windows.Forms.ToolStripButton();
            this.btTaoTaiKhoan = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btMinimized = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopDongBindingSource)).BeginInit();
            this.toolStripHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNgayKyHD
            // 
            this.txtNgayKyHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNgayKyHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayKyHD.Location = new System.Drawing.Point(589, 258);
            this.txtNgayKyHD.Name = "txtNgayKyHD";
            this.txtNgayKyHD.Size = new System.Drawing.Size(170, 22);
            this.txtNgayKyHD.TabIndex = 46;
            this.txtNgayKyHD.Click += new System.EventHandler(this.txtNgayKyHD_Click);
            this.txtNgayKyHD.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            this.txtNgayKyHD.Leave += new System.EventHandler(this.txtNgayKyHD_Leave);
            // 
            // lbNgayKyHD
            // 
            this.lbNgayKyHD.BackColor = System.Drawing.Color.Transparent;
            this.lbNgayKyHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayKyHD.ForeColor = System.Drawing.Color.Black;
            this.lbNgayKyHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNgayKyHD.Location = new System.Drawing.Point(472, 258);
            this.lbNgayKyHD.Name = "lbNgayKyHD";
            this.lbNgayKyHD.Size = new System.Drawing.Size(121, 22);
            this.lbNgayKyHD.TabIndex = 45;
            this.lbNgayKyHD.Text = "Ngày ký HD";
            this.lbNgayKyHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNgayKyHD.Click += new System.EventHandler(this.lbNgayKyHD_Click);
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChiPhi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiPhi.Location = new System.Drawing.Point(589, 222);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(170, 22);
            this.txtChiPhi.TabIndex = 44;
            this.txtChiPhi.TextChanged += new System.EventHandler(this.txtLoaiKH_TextChanged);
            // 
            // lbChiPhi
            // 
            this.lbChiPhi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChiPhi.BackColor = System.Drawing.Color.Transparent;
            this.lbChiPhi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiPhi.ForeColor = System.Drawing.Color.Black;
            this.lbChiPhi.Location = new System.Drawing.Point(472, 222);
            this.lbChiPhi.Name = "lbChiPhi";
            this.lbChiPhi.Size = new System.Drawing.Size(121, 22);
            this.lbChiPhi.TabIndex = 43;
            this.lbChiPhi.Text = "Chi Phí";
            this.lbChiPhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbChiPhi.Click += new System.EventHandler(this.lbChiPhi_Click);
            // 
            // txtTongTK
            // 
            this.txtTongTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTK.Location = new System.Drawing.Point(589, 184);
            this.txtTongTK.Name = "txtTongTK";
            this.txtTongTK.Size = new System.Drawing.Size(170, 22);
            this.txtTongTK.TabIndex = 42;
            this.txtTongTK.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            // 
            // lbTongTK
            // 
            this.lbTongTK.BackColor = System.Drawing.Color.Transparent;
            this.lbTongTK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTK.ForeColor = System.Drawing.Color.Black;
            this.lbTongTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTongTK.Location = new System.Drawing.Point(472, 183);
            this.lbTongTK.Name = "lbTongTK";
            this.lbTongTK.Size = new System.Drawing.Size(121, 22);
            this.lbTongTK.TabIndex = 41;
            this.lbTongTK.Text = "Tổng tài khoản";
            this.lbTongTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTongTK.Click += new System.EventHandler(this.lbTongTK_Click);
            // 
            // txtNgayDK
            // 
            this.txtNgayDK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNgayDK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDK.Location = new System.Drawing.Point(287, 258);
            this.txtNgayDK.Name = "txtNgayDK";
            this.txtNgayDK.Size = new System.Drawing.Size(170, 22);
            this.txtNgayDK.TabIndex = 40;
            // 
            // lbNgayDK
            // 
            this.lbNgayDK.BackColor = System.Drawing.Color.Transparent;
            this.lbNgayDK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayDK.ForeColor = System.Drawing.Color.Black;
            this.lbNgayDK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNgayDK.Location = new System.Drawing.Point(168, 258);
            this.lbNgayDK.Name = "lbNgayDK";
            this.lbNgayDK.Size = new System.Drawing.Size(123, 22);
            this.lbNgayDK.TabIndex = 39;
            this.lbNgayDK.Text = "Ngày đăng kí";
            this.lbNgayDK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.Location = new System.Drawing.Point(287, 183);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(170, 22);
            this.txtMaKhachHang.TabIndex = 38;
            this.txtMaKhachHang.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // lbMaKhachHang
            // 
            this.lbMaKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lbMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKhachHang.ForeColor = System.Drawing.Color.Black;
            this.lbMaKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMaKhachHang.Location = new System.Drawing.Point(168, 183);
            this.lbMaKhachHang.Name = "lbMaKhachHang";
            this.lbMaKhachHang.Size = new System.Drawing.Size(123, 22);
            this.lbMaKhachHang.TabIndex = 37;
            this.lbMaKhachHang.Text = "Mã khách hàng";
            this.lbMaKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMaKhachHang.Click += new System.EventHandler(this.lbMaKhachHang_Click);
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHopDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHopDong.Location = new System.Drawing.Point(287, 222);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.Size = new System.Drawing.Size(170, 22);
            this.txtMaHopDong.TabIndex = 36;
            // 
            // lbMaHopDong
            // 
            this.lbMaHopDong.BackColor = System.Drawing.Color.Transparent;
            this.lbMaHopDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHopDong.ForeColor = System.Drawing.Color.Black;
            this.lbMaHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMaHopDong.Location = new System.Drawing.Point(168, 222);
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
            this.txtTimKiem.Location = new System.Drawing.Point(308, 133);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(325, 25);
            this.txtTimKiem.TabIndex = 34;
            this.txtTimKiem.Text = "";
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
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
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
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
            this.btHopDong.Click += new System.EventHandler(this.btHopDong_Click);
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
            this.btTaiKhoan.Click += new System.EventHandler(this.btTaiKhoan_Click);
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
            this.btPhieuBao.Click += new System.EventHandler(this.btPhieuBao_Click);
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
            this.btKhachHang.Click += new System.EventHandler(this.btKhachHang_Click);
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
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
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
            this.lbHeader.Click += new System.EventHandler(this.lbHeader_Click);
            this.lbHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbHeader_MouseDown);
            this.lbHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbHeader_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn,
            this.ngayDKDataGridViewTextBoxColumn,
            this.tongTKDataGridViewTextBoxColumn,
            this.chiPhiDataGridViewTextBoxColumn,
            this.ngayKyHDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hopDongBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 300);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "Mã hợp đồng";
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // ngayDKDataGridViewTextBoxColumn
            // 
            this.ngayDKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayDKDataGridViewTextBoxColumn.DataPropertyName = "NgayDK";
            this.ngayDKDataGridViewTextBoxColumn.HeaderText = "Ngày đăng kí";
            this.ngayDKDataGridViewTextBoxColumn.Name = "ngayDKDataGridViewTextBoxColumn";
            // 
            // tongTKDataGridViewTextBoxColumn
            // 
            this.tongTKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongTKDataGridViewTextBoxColumn.DataPropertyName = "TongTK";
            this.tongTKDataGridViewTextBoxColumn.HeaderText = "Tổng tài khoản";
            this.tongTKDataGridViewTextBoxColumn.Name = "tongTKDataGridViewTextBoxColumn";
            // 
            // chiPhiDataGridViewTextBoxColumn
            // 
            this.chiPhiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chiPhiDataGridViewTextBoxColumn.DataPropertyName = "ChiPhi";
            this.chiPhiDataGridViewTextBoxColumn.HeaderText = "ChiPhi";
            this.chiPhiDataGridViewTextBoxColumn.Name = "chiPhiDataGridViewTextBoxColumn";
            // 
            // ngayKyHDDataGridViewTextBoxColumn
            // 
            this.ngayKyHDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayKyHDDataGridViewTextBoxColumn.DataPropertyName = "NgayKyHD";
            this.ngayKyHDDataGridViewTextBoxColumn.HeaderText = "Ngày ký hợp đồng";
            this.ngayKyHDDataGridViewTextBoxColumn.Name = "ngayKyHDDataGridViewTextBoxColumn";
            // 
            // hopDongBindingSource
            // 
            this.hopDongBindingSource.DataSource = typeof(DAO.HopDong);
            // 
            // toolStripHopDong
            // 
            this.toolStripHopDong.AutoSize = false;
            this.toolStripHopDong.BackColor = System.Drawing.Color.Transparent;
            this.toolStripHopDong.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripHopDong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btXem,
            this.btThem,
            this.btSua,
            this.btXoa,
            this.btTaoTaiKhoan,
            this.toolStripButton1});
            this.toolStripHopDong.Location = new System.Drawing.Point(0, 100);
            this.toolStripHopDong.Name = "toolStripHopDong";
            this.toolStripHopDong.Size = new System.Drawing.Size(960, 30);
            this.toolStripHopDong.TabIndex = 32;
            this.toolStripHopDong.Text = "toolStrip1";
            this.toolStripHopDong.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripHopDong_ItemClicked);
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
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // btThem
            // 
            this.btThem.AutoSize = false;
            this.btThem.BackColor = System.Drawing.Color.Transparent;
            this.btThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.Black;
            this.btThem.Image = global::GUI.Properties.Resources.Add_Button;
            this.btThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(60, 30);
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
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
            this.btSua.Size = new System.Drawing.Size(80, 30);
            this.btSua.Text = "Cập nhật";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
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
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btTaoTaiKhoan
            // 
            this.btTaoTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoTaiKhoan.Image = global::GUI.Properties.Resources.Male_user_add_icon;
            this.btTaoTaiKhoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btTaoTaiKhoan.Name = "btTaoTaiKhoan";
            this.btTaoTaiKhoan.Size = new System.Drawing.Size(107, 27);
            this.btTaoTaiKhoan.Text = "Tạo tài khoản";
            this.btTaoTaiKhoan.Click += new System.EventHandler(this.btTaoTaiKhoan_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::GUI.Properties.Resources.waiting_icon_8619;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(133, 27);
            this.toolStripButton1.Text = "Danh sách HĐ đợi";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.mobile_search_icon_x2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(608, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
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
            this.btExit.TabIndex = 29;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmQuanLyHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtNgayKyHD);
            this.Controls.Add(this.lbNgayKyHD);
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
            ((System.ComponentModel.ISupportInitialize)(this.hopDongBindingSource)).EndInit();
            this.toolStripHopDong.ResumeLayout(false);
            this.toolStripHopDong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNgayKyHD;
        private System.Windows.Forms.Label lbNgayKyHD;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.Label lbChiPhi;
        private System.Windows.Forms.TextBox txtTongTK;
        private System.Windows.Forms.Label lbTongTK;
        private System.Windows.Forms.TextBox txtNgayDK;
        private System.Windows.Forms.Label lbNgayDK;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label lbMaKhachHang;
        private System.Windows.Forms.TextBox txtMaHopDong;
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
        private System.Windows.Forms.BindingSource hopDongBindingSource;
        private System.Windows.Forms.ToolStripButton btThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiPhiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKyHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btTaoTaiKhoan;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}