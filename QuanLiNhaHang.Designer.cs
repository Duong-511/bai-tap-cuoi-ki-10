namespace QuanLyNhaHang1
{
    partial class frmQuanLiNhaHang
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            cboDanhMuc = new ComboBox();
            cboMonAn = new ComboBox();
            nmrSoLuong = new NumericUpDown();
            lsvHoaDon = new ListView();
            chTenMon = new ColumnHeader();
            chSoLuong = new ColumnHeader();
            chDonGia = new ColumnHeader();
            chThanhTien = new ColumnHeader();
            btnThemMon = new Button();
            btnThanhToan = new Button();
            flpBanAn = new FlowLayoutPanel();
            btnChuyenBan = new Button();
            cboChuyenBan = new ComboBox();
            txtTongTien = new TextBox();
            btnDatBan = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrSoLuong).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(907, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(151, 24);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(210, 26);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(210, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(443, 31);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(202, 28);
            cboDanhMuc.TabIndex = 1;
            cboDanhMuc.SelectedIndexChanged += cboDanhMuc_SelectedIndexChanged;
            // 
            // cboMonAn
            // 
            cboMonAn.FormattingEnabled = true;
            cboMonAn.Location = new Point(444, 65);
            cboMonAn.Name = "cboMonAn";
            cboMonAn.Size = new Size(202, 28);
            cboMonAn.TabIndex = 2;
            // 
            // nmrSoLuong
            // 
            nmrSoLuong.Location = new Point(748, 50);
            nmrSoLuong.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmrSoLuong.Name = "nmrSoLuong";
            nmrSoLuong.Size = new Size(48, 27);
            nmrSoLuong.TabIndex = 3;
            nmrSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lsvHoaDon
            // 
            lsvHoaDon.Columns.AddRange(new ColumnHeader[] { chTenMon, chSoLuong, chDonGia, chThanhTien });
            lsvHoaDon.GridLines = true;
            lsvHoaDon.Location = new Point(444, 99);
            lsvHoaDon.Name = "lsvHoaDon";
            lsvHoaDon.Size = new Size(451, 422);
            lsvHoaDon.TabIndex = 4;
            lsvHoaDon.UseCompatibleStateImageBehavior = false;
            lsvHoaDon.View = View.Details;
            lsvHoaDon.SelectedIndexChanged += lsvHoaDon_SelectedIndexChanged;
            // 
            // chTenMon
            // 
            chTenMon.Text = "Tên Món";
            chTenMon.Width = 130;
            // 
            // chSoLuong
            // 
            chSoLuong.Text = "Số Lượng";
            chSoLuong.Width = 85;
            // 
            // chDonGia
            // 
            chDonGia.Text = "Đơn Giá";
            chDonGia.Width = 85;
            // 
            // chThanhTien
            // 
            chThanhTien.Text = "Thành Tiền";
            chThanhTien.Width = 105;
            // 
            // btnThemMon
            // 
            btnThemMon.Location = new Point(651, 37);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(91, 51);
            btnThemMon.TabIndex = 5;
            btnThemMon.Text = "Thêm Món";
            btnThemMon.UseVisualStyleBackColor = true;
            btnThemMon.Click += btnThemMon_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(801, 548);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(94, 55);
            btnThanhToan.TabIndex = 6;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // flpBanAn
            // 
            flpBanAn.AutoScroll = true;
            flpBanAn.Dock = DockStyle.Left;
            flpBanAn.Location = new Point(0, 28);
            flpBanAn.Name = "flpBanAn";
            flpBanAn.Size = new Size(424, 589);
            flpBanAn.TabIndex = 8;
            // 
            // btnChuyenBan
            // 
            btnChuyenBan.Location = new Point(444, 527);
            btnChuyenBan.Name = "btnChuyenBan";
            btnChuyenBan.Size = new Size(125, 42);
            btnChuyenBan.TabIndex = 9;
            btnChuyenBan.Text = "Chuyển Bàn";
            btnChuyenBan.UseVisualStyleBackColor = true;
            btnChuyenBan.Click += btnChuyenBan_Click;
            // 
            // cboChuyenBan
            // 
            cboChuyenBan.FormattingEnabled = true;
            cboChuyenBan.Location = new Point(444, 575);
            cboChuyenBan.Name = "cboChuyenBan";
            cboChuyenBan.Size = new Size(125, 28);
            cboChuyenBan.TabIndex = 10;
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTongTien.ForeColor = Color.Red;
            txtTongTien.Location = new Point(681, 558);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(114, 31);
            txtTongTien.TabIndex = 12;
            txtTongTien.Text = "0";
            txtTongTien.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDatBan
            // 
            btnDatBan.Location = new Point(575, 548);
            btnDatBan.Name = "btnDatBan";
            btnDatBan.Size = new Size(94, 55);
            btnDatBan.TabIndex = 13;
            btnDatBan.Text = "Đặt Bàn";
            btnDatBan.UseVisualStyleBackColor = true;
            btnDatBan.Click += btnDatBan_Click;
            // 
            // frmQuanLiNhaHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 617);
            Controls.Add(btnDatBan);
            Controls.Add(txtTongTien);
            Controls.Add(cboChuyenBan);
            Controls.Add(btnChuyenBan);
            Controls.Add(flpBanAn);
            Controls.Add(btnThanhToan);
            Controls.Add(btnThemMon);
            Controls.Add(lsvHoaDon);
            Controls.Add(nmrSoLuong);
            Controls.Add(cboMonAn);
            Controls.Add(cboDanhMuc);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmQuanLiNhaHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lí Nhà Hàng";
            Load += frmQuanLiNhaHang_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ComboBox cboDanhMuc;
        private ComboBox cboMonAn;
        private NumericUpDown nmrSoLuong;
        private ListView lsvHoaDon;
        private Button btnThemMon;
        private Button btnThanhToan;
        private FlowLayoutPanel flpBanAn;
        private Button btnChuyenBan;
        private ComboBox cboChuyenBan;
        private ColumnHeader chTenMon;
        private ColumnHeader chSoLuong;
        private ColumnHeader chDonGia;
        private ColumnHeader chThanhTien;
        private TextBox txtTongTien;
        private Button btnDatBan;
    }
}