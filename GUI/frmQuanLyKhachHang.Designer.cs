namespace GUI
{
    partial class frmQuanLyKhachHang
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
            this.lbHeader = new System.Windows.Forms.Label();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.toolStripKhachHang = new System.Windows.Forms.ToolStrip();
            this.btXem = new System.Windows.Forms.ToolStripButton();
            this.btThem = new System.Windows.Forms.ToolStripButton();
            this.btSua = new System.Windows.Forms.ToolStripButton();
            this.btXoa = new System.Windows.Forms.ToolStripButton();
            this.btLapHopDong = new System.Windows.Forms.ToolStripButton();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTroGiup = new System.Windows.Forms.Button();
            this.btHopDong = new System.Windows.Forms.Button();
            this.btTaiKhoan = new System.Windows.Forms.Button();
            this.btPhieuBao = new System.Windows.Forms.Button();
            this.btKhachHang = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.btMinimized = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMenu.SuspendLayout();
            this.toolStripKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.lbHeader.Text = "Quản lý khách hàng";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHeader.Click += new System.EventHandler(this.lbHeader_Click);
            this.lbHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbHeader_MouseDown);
            this.lbHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbHeader_MouseMove);
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.DarkOrange;
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
            // toolStripKhachHang
            // 
            this.toolStripKhachHang.AutoSize = false;
            this.toolStripKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.toolStripKhachHang.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripKhachHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btXem,
            this.btThem,
            this.btSua,
            this.btXoa,
            this.btLapHopDong});
            this.toolStripKhachHang.Location = new System.Drawing.Point(0, 100);
            this.toolStripKhachHang.Name = "toolStripKhachHang";
            this.toolStripKhachHang.Size = new System.Drawing.Size(960, 30);
            this.toolStripKhachHang.TabIndex = 11;
            this.toolStripKhachHang.Text = "toolStrip1";
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
            this.btXoa.Text = "Xóa";
            // 
            // btLapHopDong
            // 
            this.btLapHopDong.AutoSize = false;
            this.btLapHopDong.BackColor = System.Drawing.Color.Transparent;
            this.btLapHopDong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLapHopDong.ForeColor = System.Drawing.Color.Black;
            this.btLapHopDong.Image = global::GUI.Properties.Resources.handshake_icon_19;
            this.btLapHopDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLapHopDong.Name = "btLapHopDong";
            this.btLapHopDong.Size = new System.Drawing.Size(120, 30);
            this.btLapHopDong.Text = "Lập hợp đồng";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.DarkOrange;
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
            this.btTroGiup.BackColor = System.Drawing.Color.DarkOrange;
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
            this.btHopDong.BackColor = System.Drawing.Color.DarkOrange;
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
            this.btTaiKhoan.BackColor = System.Drawing.Color.DarkOrange;
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
            this.btPhieuBao.BackColor = System.Drawing.Color.DarkOrange;
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
            this.btKhachHang.BackColor = System.Drawing.Color.Gray;
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
            this.btHome.BackColor = System.Drawing.Color.DarkOrange;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
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
            this.maKHDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.cMNDDataGridViewTextBoxColumn,
            this.loaiKHDataGridViewTextBoxColumn,
            this.soDTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.khachHangBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 300);
            this.dataGridView1.TabIndex = 12;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataSource = typeof(DAO.KhachHang);
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // cMNDDataGridViewTextBoxColumn
            // 
            this.cMNDDataGridViewTextBoxColumn.DataPropertyName = "CMND";
            this.cMNDDataGridViewTextBoxColumn.HeaderText = "CMND";
            this.cMNDDataGridViewTextBoxColumn.Name = "cMNDDataGridViewTextBoxColumn";
            // 
            // loaiKHDataGridViewTextBoxColumn
            // 
            this.loaiKHDataGridViewTextBoxColumn.DataPropertyName = "LoaiKH";
            this.loaiKHDataGridViewTextBoxColumn.HeaderText = "LoaiKH";
            this.loaiKHDataGridViewTextBoxColumn.Name = "loaiKHDataGridViewTextBoxColumn";
            // 
            // soDTDataGridViewTextBoxColumn
            // 
            this.soDTDataGridViewTextBoxColumn.DataPropertyName = "SoDT";
            this.soDTDataGridViewTextBoxColumn.HeaderText = "SoDT";
            this.soDTDataGridViewTextBoxColumn.Name = "soDTDataGridViewTextBoxColumn";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(0, 270);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(960, 30);
            this.txtTimKiem.TabIndex = 13;
            this.txtTimKiem.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStripKhachHang);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.btMinimized);
            this.Controls.Add(this.btExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyKhachHang";
            this.Text = "frmQuanLyKhachHang";
            this.Load += new System.EventHandler(this.frmQuanLyKhachHang_Load);
            this.pnMenu.ResumeLayout(false);
            this.toolStripKhachHang.ResumeLayout(false);
            this.toolStripKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbHeader;
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
        private System.Windows.Forms.ToolStrip toolStripKhachHang;
        private System.Windows.Forms.ToolStripButton btThem;
        private System.Windows.Forms.ToolStripButton btSua;
        private System.Windows.Forms.ToolStripButton btXoa;
        private System.Windows.Forms.ToolStripButton btXem;
        private System.Windows.Forms.ToolStripButton btLapHopDong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.RichTextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
    }
}