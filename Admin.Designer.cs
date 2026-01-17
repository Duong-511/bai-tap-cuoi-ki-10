namespace QuanLyNhaHang1
{
    partial class frmAdmin
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
            tcAdmin = new TabControl();
            tbDoanhThu = new TabPage();
            btnThongKe = new Button();
            dtpDenNgay = new DateTimePicker();
            dtPTuNgay = new DateTimePicker();
            dgvDoanhThu = new DataGridView();
            tpMonAn = new TabPage();
            nmrGia = new NumericUpDown();
            cboDanhMuc = new ComboBox();
            lblGia = new Label();
            lblDanhMuc = new Label();
            lblTenMon = new Label();
            lblIDMonAn = new Label();
            txtTenMon = new TextBox();
            txtID = new TextBox();
            txtTimMonAn = new TextBox();
            btnTim = new Button();
            dgvMonAn = new DataGridView();
            btnXemMonAn = new Button();
            XoaMonAn = new Button();
            SuaMonAn = new Button();
            btnThemMonAn = new Button();
            tpDanhMuc = new TabPage();
            lblTenDanhMuc = new Label();
            lblIDDanhMuc = new Label();
            textBox1 = new TextBox();
            txtIDDanhMuc = new TextBox();
            dgvDanhMuc = new DataGridView();
            btnXemDanhMuc = new Button();
            btnXoaDanhMuc = new Button();
            btnSuaDanhMuc = new Button();
            btnThemDanhMuc = new Button();
            tpBanAn = new TabPage();
            cboTrangThai = new ComboBox();
            lblTrangThai = new Label();
            lblTenBan = new Label();
            lblIDBanAn = new Label();
            txtTenBan = new TextBox();
            txtIDBanAn = new TextBox();
            dgvBanAn = new DataGridView();
            btnXemBanAn = new Button();
            btnXoaBanAn = new Button();
            btnSuaBanAn = new Button();
            btnThemBanAn = new Button();
            tpTaiKhoan = new TabPage();
            btnDatLaiMatKhau = new Button();
            cboLoaiTaiKhoan = new ComboBox();
            lblLoaiTaiKhoan = new Label();
            lblTenHienThi = new Label();
            lblTenTaiKhoan = new Label();
            txtTenHienThi = new TextBox();
            txtTenTaiKhoan = new TextBox();
            dgvTaiKhoan = new DataGridView();
            btnXemTaiKhoan = new Button();
            btnXoaTaiKhoan = new Button();
            btnSuaTaiKhoan = new Button();
            btnThemTaiKhoan = new Button();
            tcAdmin.SuspendLayout();
            tbDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
            tpMonAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).BeginInit();
            tpDanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
            tpBanAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBanAn).BeginInit();
            tpTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tbDoanhThu);
            tcAdmin.Controls.Add(tpMonAn);
            tcAdmin.Controls.Add(tpDanhMuc);
            tcAdmin.Controls.Add(tpBanAn);
            tcAdmin.Controls.Add(tpTaiKhoan);
            tcAdmin.Location = new Point(12, 12);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(773, 618);
            tcAdmin.TabIndex = 0;
            // 
            // tbDoanhThu
            // 
            tbDoanhThu.Controls.Add(btnThongKe);
            tbDoanhThu.Controls.Add(dtpDenNgay);
            tbDoanhThu.Controls.Add(dtPTuNgay);
            tbDoanhThu.Controls.Add(dgvDoanhThu);
            tbDoanhThu.Location = new Point(4, 29);
            tbDoanhThu.Name = "tbDoanhThu";
            tbDoanhThu.Padding = new Padding(3);
            tbDoanhThu.Size = new Size(765, 585);
            tbDoanhThu.TabIndex = 0;
            tbDoanhThu.Text = "Doanh Thu";
            tbDoanhThu.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(337, 14);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(103, 37);
            btnThongKe.TabIndex = 7;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(499, 21);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(250, 27);
            dtpDenNgay.TabIndex = 6;
            // 
            // dtPTuNgay
            // 
            dtPTuNgay.Location = new Point(19, 20);
            dtPTuNgay.Name = "dtPTuNgay";
            dtPTuNgay.Size = new Size(250, 27);
            dtPTuNgay.TabIndex = 5;
            // 
            // dgvDoanhThu
            // 
            dgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhThu.Location = new Point(6, 57);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.RowHeadersWidth = 51;
            dgvDoanhThu.Size = new Size(753, 379);
            dgvDoanhThu.TabIndex = 4;
            // 
            // tpMonAn
            // 
            tpMonAn.Controls.Add(nmrGia);
            tpMonAn.Controls.Add(cboDanhMuc);
            tpMonAn.Controls.Add(lblGia);
            tpMonAn.Controls.Add(lblDanhMuc);
            tpMonAn.Controls.Add(lblTenMon);
            tpMonAn.Controls.Add(lblIDMonAn);
            tpMonAn.Controls.Add(txtTenMon);
            tpMonAn.Controls.Add(txtID);
            tpMonAn.Controls.Add(txtTimMonAn);
            tpMonAn.Controls.Add(btnTim);
            tpMonAn.Controls.Add(dgvMonAn);
            tpMonAn.Controls.Add(btnXemMonAn);
            tpMonAn.Controls.Add(XoaMonAn);
            tpMonAn.Controls.Add(SuaMonAn);
            tpMonAn.Controls.Add(btnThemMonAn);
            tpMonAn.Location = new Point(4, 29);
            tpMonAn.Name = "tpMonAn";
            tpMonAn.Padding = new Padding(3);
            tpMonAn.Size = new Size(765, 585);
            tpMonAn.TabIndex = 1;
            tpMonAn.Text = "Món Ăn";
            tpMonAn.UseVisualStyleBackColor = true;
            // 
            // nmrGia
            // 
            nmrGia.Location = new Point(555, 271);
            nmrGia.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            nmrGia.Name = "nmrGia";
            nmrGia.Size = new Size(204, 27);
            nmrGia.TabIndex = 18;
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(555, 217);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(204, 28);
            cboDanhMuc.TabIndex = 17;
            // 
            // lblGia
            // 
            lblGia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGia.Location = new Point(459, 271);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(90, 25);
            lblGia.TabIndex = 16;
            lblGia.Text = "Giá:";
            lblGia.Click += lblGia_Click;
            // 
            // lblDanhMuc
            // 
            lblDanhMuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDanhMuc.Location = new Point(459, 220);
            lblDanhMuc.Name = "lblDanhMuc";
            lblDanhMuc.Size = new Size(90, 25);
            lblDanhMuc.TabIndex = 15;
            lblDanhMuc.Text = "Danh Mục:";
            lblDanhMuc.Click += lblDanhMuc_Click;
            // 
            // lblTenMon
            // 
            lblTenMon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenMon.Location = new Point(459, 172);
            lblTenMon.Name = "lblTenMon";
            lblTenMon.Size = new Size(90, 25);
            lblTenMon.TabIndex = 14;
            lblTenMon.Text = "Tên Món:";
            lblTenMon.Click += lblTenMon_Click;
            // 
            // lblIDMonAn
            // 
            lblIDMonAn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIDMonAn.Location = new Point(459, 123);
            lblIDMonAn.Name = "lblIDMonAn";
            lblIDMonAn.Size = new Size(90, 25);
            lblIDMonAn.TabIndex = 13;
            lblIDMonAn.Text = "ID:";
            lblIDMonAn.Click += lblIDMonAn_Click;
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(555, 169);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(204, 27);
            txtTenMon.TabIndex = 12;
            // 
            // txtID
            // 
            txtID.Location = new Point(555, 120);
            txtID.Name = "txtID";
            txtID.Size = new Size(204, 27);
            txtID.TabIndex = 11;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtTimMonAn
            // 
            txtTimMonAn.Location = new Point(449, 15);
            txtTimMonAn.Name = "txtTimMonAn";
            txtTimMonAn.Size = new Size(209, 27);
            txtTimMonAn.TabIndex = 10;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(664, 6);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(95, 45);
            btnTim.TabIndex = 9;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // dgvMonAn
            // 
            dgvMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonAn.Location = new Point(6, 57);
            dgvMonAn.Name = "dgvMonAn";
            dgvMonAn.RowHeadersWidth = 51;
            dgvMonAn.Size = new Size(435, 490);
            dgvMonAn.TabIndex = 8;
            // 
            // btnXemMonAn
            // 
            btnXemMonAn.Location = new Point(309, 6);
            btnXemMonAn.Name = "btnXemMonAn";
            btnXemMonAn.Size = new Size(95, 45);
            btnXemMonAn.TabIndex = 7;
            btnXemMonAn.Text = "Xem";
            btnXemMonAn.UseVisualStyleBackColor = true;
            btnXemMonAn.Click += btnXemMonAn_Click;
            // 
            // XoaMonAn
            // 
            XoaMonAn.Location = new Point(208, 6);
            XoaMonAn.Name = "XoaMonAn";
            XoaMonAn.Size = new Size(95, 45);
            XoaMonAn.TabIndex = 6;
            XoaMonAn.Text = "Xóa";
            XoaMonAn.UseVisualStyleBackColor = true;
            XoaMonAn.Click += XoaMonAn_Click;
            // 
            // SuaMonAn
            // 
            SuaMonAn.Location = new Point(107, 6);
            SuaMonAn.Name = "SuaMonAn";
            SuaMonAn.Size = new Size(95, 45);
            SuaMonAn.TabIndex = 5;
            SuaMonAn.Text = "Sửa";
            SuaMonAn.UseVisualStyleBackColor = true;
            SuaMonAn.Click += SuaMonAn_Click;
            // 
            // btnThemMonAn
            // 
            btnThemMonAn.Location = new Point(6, 6);
            btnThemMonAn.Name = "btnThemMonAn";
            btnThemMonAn.Size = new Size(95, 45);
            btnThemMonAn.TabIndex = 4;
            btnThemMonAn.Text = "Thêm";
            btnThemMonAn.UseVisualStyleBackColor = true;
            btnThemMonAn.Click += btnThemMonAn_Click;
            // 
            // tpDanhMuc
            // 
            tpDanhMuc.Controls.Add(lblTenDanhMuc);
            tpDanhMuc.Controls.Add(lblIDDanhMuc);
            tpDanhMuc.Controls.Add(textBox1);
            tpDanhMuc.Controls.Add(txtIDDanhMuc);
            tpDanhMuc.Controls.Add(dgvDanhMuc);
            tpDanhMuc.Controls.Add(btnXemDanhMuc);
            tpDanhMuc.Controls.Add(btnXoaDanhMuc);
            tpDanhMuc.Controls.Add(btnSuaDanhMuc);
            tpDanhMuc.Controls.Add(btnThemDanhMuc);
            tpDanhMuc.Location = new Point(4, 29);
            tpDanhMuc.Name = "tpDanhMuc";
            tpDanhMuc.Padding = new Padding(3);
            tpDanhMuc.Size = new Size(765, 585);
            tpDanhMuc.TabIndex = 2;
            tpDanhMuc.Text = "Danh Mục";
            tpDanhMuc.UseVisualStyleBackColor = true;
            // 
            // lblTenDanhMuc
            // 
            lblTenDanhMuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenDanhMuc.Location = new Point(459, 167);
            lblTenDanhMuc.Name = "lblTenDanhMuc";
            lblTenDanhMuc.Size = new Size(129, 25);
            lblTenDanhMuc.TabIndex = 18;
            lblTenDanhMuc.Text = "Tên Danh Mục:";
            // 
            // lblIDDanhMuc
            // 
            lblIDDanhMuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIDDanhMuc.Location = new Point(459, 118);
            lblIDDanhMuc.Name = "lblIDDanhMuc";
            lblIDDanhMuc.Size = new Size(90, 25);
            lblIDDanhMuc.TabIndex = 17;
            lblIDDanhMuc.Text = "ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(586, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 27);
            textBox1.TabIndex = 16;
            // 
            // txtIDDanhMuc
            // 
            txtIDDanhMuc.Location = new Point(586, 115);
            txtIDDanhMuc.Name = "txtIDDanhMuc";
            txtIDDanhMuc.Size = new Size(173, 27);
            txtIDDanhMuc.TabIndex = 15;
            // 
            // dgvDanhMuc
            // 
            dgvDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhMuc.Location = new Point(6, 57);
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.RowHeadersWidth = 51;
            dgvDanhMuc.Size = new Size(435, 490);
            dgvDanhMuc.TabIndex = 12;
            // 
            // btnXemDanhMuc
            // 
            btnXemDanhMuc.Location = new Point(309, 6);
            btnXemDanhMuc.Name = "btnXemDanhMuc";
            btnXemDanhMuc.Size = new Size(95, 45);
            btnXemDanhMuc.TabIndex = 11;
            btnXemDanhMuc.Text = "Xem";
            btnXemDanhMuc.UseVisualStyleBackColor = true;
            // 
            // btnXoaDanhMuc
            // 
            btnXoaDanhMuc.Location = new Point(208, 6);
            btnXoaDanhMuc.Name = "btnXoaDanhMuc";
            btnXoaDanhMuc.Size = new Size(95, 45);
            btnXoaDanhMuc.TabIndex = 10;
            btnXoaDanhMuc.Text = "Xóa";
            btnXoaDanhMuc.UseVisualStyleBackColor = true;
            // 
            // btnSuaDanhMuc
            // 
            btnSuaDanhMuc.Location = new Point(107, 6);
            btnSuaDanhMuc.Name = "btnSuaDanhMuc";
            btnSuaDanhMuc.Size = new Size(95, 45);
            btnSuaDanhMuc.TabIndex = 9;
            btnSuaDanhMuc.Text = "Sửa";
            btnSuaDanhMuc.UseVisualStyleBackColor = true;
            // 
            // btnThemDanhMuc
            // 
            btnThemDanhMuc.Location = new Point(6, 6);
            btnThemDanhMuc.Name = "btnThemDanhMuc";
            btnThemDanhMuc.Size = new Size(95, 45);
            btnThemDanhMuc.TabIndex = 8;
            btnThemDanhMuc.Text = "Thêm";
            btnThemDanhMuc.UseVisualStyleBackColor = true;
            // 
            // tpBanAn
            // 
            tpBanAn.Controls.Add(cboTrangThai);
            tpBanAn.Controls.Add(lblTrangThai);
            tpBanAn.Controls.Add(lblTenBan);
            tpBanAn.Controls.Add(lblIDBanAn);
            tpBanAn.Controls.Add(txtTenBan);
            tpBanAn.Controls.Add(txtIDBanAn);
            tpBanAn.Controls.Add(dgvBanAn);
            tpBanAn.Controls.Add(btnXemBanAn);
            tpBanAn.Controls.Add(btnXoaBanAn);
            tpBanAn.Controls.Add(btnSuaBanAn);
            tpBanAn.Controls.Add(btnThemBanAn);
            tpBanAn.Location = new Point(4, 29);
            tpBanAn.Name = "tpBanAn";
            tpBanAn.Padding = new Padding(3);
            tpBanAn.Size = new Size(765, 585);
            tpBanAn.TabIndex = 3;
            tpBanAn.Text = "Bàn Ăn";
            tpBanAn.UseVisualStyleBackColor = true;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(555, 211);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(204, 28);
            cboTrangThai.TabIndex = 23;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTrangThai.Location = new Point(459, 214);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(90, 25);
            lblTrangThai.TabIndex = 22;
            lblTrangThai.Text = "Trạng Thái:";
            // 
            // lblTenBan
            // 
            lblTenBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenBan.Location = new Point(459, 166);
            lblTenBan.Name = "lblTenBan";
            lblTenBan.Size = new Size(90, 25);
            lblTenBan.TabIndex = 21;
            lblTenBan.Text = "Tên Bàn:";
            // 
            // lblIDBanAn
            // 
            lblIDBanAn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIDBanAn.Location = new Point(459, 117);
            lblIDBanAn.Name = "lblIDBanAn";
            lblIDBanAn.Size = new Size(90, 25);
            lblIDBanAn.TabIndex = 20;
            lblIDBanAn.Text = "ID:";
            // 
            // txtTenBan
            // 
            txtTenBan.Location = new Point(555, 163);
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(204, 27);
            txtTenBan.TabIndex = 19;
            // 
            // txtIDBanAn
            // 
            txtIDBanAn.Location = new Point(555, 114);
            txtIDBanAn.Name = "txtIDBanAn";
            txtIDBanAn.Size = new Size(204, 27);
            txtIDBanAn.TabIndex = 18;
            // 
            // dgvBanAn
            // 
            dgvBanAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBanAn.Location = new Point(3, 57);
            dgvBanAn.Name = "dgvBanAn";
            dgvBanAn.RowHeadersWidth = 51;
            dgvBanAn.Size = new Size(435, 490);
            dgvBanAn.TabIndex = 12;
            dgvBanAn.CellContentClick += dgvBanAn_CellContentClick;
            // 
            // btnXemBanAn
            // 
            btnXemBanAn.Location = new Point(306, 6);
            btnXemBanAn.Name = "btnXemBanAn";
            btnXemBanAn.Size = new Size(95, 45);
            btnXemBanAn.TabIndex = 11;
            btnXemBanAn.Text = "Xem";
            btnXemBanAn.UseVisualStyleBackColor = true;
            // 
            // btnXoaBanAn
            // 
            btnXoaBanAn.Location = new Point(205, 6);
            btnXoaBanAn.Name = "btnXoaBanAn";
            btnXoaBanAn.Size = new Size(95, 45);
            btnXoaBanAn.TabIndex = 10;
            btnXoaBanAn.Text = "Xóa";
            btnXoaBanAn.UseVisualStyleBackColor = true;
            // 
            // btnSuaBanAn
            // 
            btnSuaBanAn.Location = new Point(104, 6);
            btnSuaBanAn.Name = "btnSuaBanAn";
            btnSuaBanAn.Size = new Size(95, 45);
            btnSuaBanAn.TabIndex = 9;
            btnSuaBanAn.Text = "Sửa";
            btnSuaBanAn.UseVisualStyleBackColor = true;
            // 
            // btnThemBanAn
            // 
            btnThemBanAn.Location = new Point(3, 6);
            btnThemBanAn.Name = "btnThemBanAn";
            btnThemBanAn.Size = new Size(95, 45);
            btnThemBanAn.TabIndex = 8;
            btnThemBanAn.Text = "Thêm";
            btnThemBanAn.UseVisualStyleBackColor = true;
            // 
            // tpTaiKhoan
            // 
            tpTaiKhoan.Controls.Add(btnDatLaiMatKhau);
            tpTaiKhoan.Controls.Add(cboLoaiTaiKhoan);
            tpTaiKhoan.Controls.Add(lblLoaiTaiKhoan);
            tpTaiKhoan.Controls.Add(lblTenHienThi);
            tpTaiKhoan.Controls.Add(lblTenTaiKhoan);
            tpTaiKhoan.Controls.Add(txtTenHienThi);
            tpTaiKhoan.Controls.Add(txtTenTaiKhoan);
            tpTaiKhoan.Controls.Add(dgvTaiKhoan);
            tpTaiKhoan.Controls.Add(btnXemTaiKhoan);
            tpTaiKhoan.Controls.Add(btnXoaTaiKhoan);
            tpTaiKhoan.Controls.Add(btnSuaTaiKhoan);
            tpTaiKhoan.Controls.Add(btnThemTaiKhoan);
            tpTaiKhoan.Location = new Point(4, 29);
            tpTaiKhoan.Name = "tpTaiKhoan";
            tpTaiKhoan.Padding = new Padding(3);
            tpTaiKhoan.Size = new Size(765, 585);
            tpTaiKhoan.TabIndex = 4;
            tpTaiKhoan.Text = "Tài Khoản";
            tpTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnDatLaiMatKhau
            // 
            btnDatLaiMatKhau.Location = new Point(652, 262);
            btnDatLaiMatKhau.Name = "btnDatLaiMatKhau";
            btnDatLaiMatKhau.Size = new Size(105, 54);
            btnDatLaiMatKhau.TabIndex = 30;
            btnDatLaiMatKhau.Text = "Đặt Lại Mật Khẩu";
            btnDatLaiMatKhau.UseVisualStyleBackColor = true;
            // 
            // cboLoaiTaiKhoan
            // 
            cboLoaiTaiKhoan.FormattingEnabled = true;
            cboLoaiTaiKhoan.Location = new Point(579, 210);
            cboLoaiTaiKhoan.Name = "cboLoaiTaiKhoan";
            cboLoaiTaiKhoan.Size = new Size(178, 28);
            cboLoaiTaiKhoan.TabIndex = 29;
            // 
            // lblLoaiTaiKhoan
            // 
            lblLoaiTaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLoaiTaiKhoan.Location = new Point(457, 213);
            lblLoaiTaiKhoan.Name = "lblLoaiTaiKhoan";
            lblLoaiTaiKhoan.Size = new Size(116, 25);
            lblLoaiTaiKhoan.TabIndex = 28;
            lblLoaiTaiKhoan.Text = "Loại Tài Khoản:";
            // 
            // lblTenHienThi
            // 
            lblTenHienThi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenHienThi.Location = new Point(457, 165);
            lblTenHienThi.Name = "lblTenHienThi";
            lblTenHienThi.Size = new Size(116, 25);
            lblTenHienThi.TabIndex = 27;
            lblTenHienThi.Text = "Tên Hiển Thị:";
            // 
            // lblTenTaiKhoan
            // 
            lblTenTaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenTaiKhoan.Location = new Point(457, 116);
            lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            lblTenTaiKhoan.Size = new Size(116, 25);
            lblTenTaiKhoan.TabIndex = 26;
            lblTenTaiKhoan.Text = "Tên Tài Khoản:";
            // 
            // txtTenHienThi
            // 
            txtTenHienThi.Location = new Point(579, 162);
            txtTenHienThi.Name = "txtTenHienThi";
            txtTenHienThi.Size = new Size(178, 27);
            txtTenHienThi.TabIndex = 25;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(579, 113);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(178, 27);
            txtTenTaiKhoan.TabIndex = 24;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Location = new Point(6, 57);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.Size = new Size(435, 490);
            dgvTaiKhoan.TabIndex = 12;
            // 
            // btnXemTaiKhoan
            // 
            btnXemTaiKhoan.Location = new Point(309, 6);
            btnXemTaiKhoan.Name = "btnXemTaiKhoan";
            btnXemTaiKhoan.Size = new Size(95, 45);
            btnXemTaiKhoan.TabIndex = 11;
            btnXemTaiKhoan.Text = "Xem";
            btnXemTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnXoaTaiKhoan
            // 
            btnXoaTaiKhoan.Location = new Point(208, 6);
            btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            btnXoaTaiKhoan.Size = new Size(95, 45);
            btnXoaTaiKhoan.TabIndex = 10;
            btnXoaTaiKhoan.Text = "Xóa";
            btnXoaTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnSuaTaiKhoan
            // 
            btnSuaTaiKhoan.Location = new Point(107, 6);
            btnSuaTaiKhoan.Name = "btnSuaTaiKhoan";
            btnSuaTaiKhoan.Size = new Size(95, 45);
            btnSuaTaiKhoan.TabIndex = 9;
            btnSuaTaiKhoan.Text = "Sửa";
            btnSuaTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnThemTaiKhoan
            // 
            btnThemTaiKhoan.Location = new Point(6, 6);
            btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            btnThemTaiKhoan.Size = new Size(95, 45);
            btnThemTaiKhoan.TabIndex = 8;
            btnThemTaiKhoan.Text = "Thêm";
            btnThemTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 657);
            Controls.Add(tcAdmin);
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tcAdmin.ResumeLayout(false);
            tbDoanhThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
            tpMonAn.ResumeLayout(false);
            tpMonAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).EndInit();
            tpDanhMuc.ResumeLayout(false);
            tpDanhMuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
            tpBanAn.ResumeLayout(false);
            tpBanAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBanAn).EndInit();
            tpTaiKhoan.ResumeLayout(false);
            tpTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tbDoanhThu;
        private TabPage tpMonAn;
        private TabPage tpDanhMuc;
        private TabPage tpBanAn;
        private TabPage tpTaiKhoan;
        private DataGridView dgvDoanhThu;
        private DataGridView dgvMonAn;
        private Button btnXemMonAn;
        private Button XoaMonAn;
        private Button SuaMonAn;
        private Button btnThemMonAn;
        private DataGridView dgvDanhMuc;
        private Button btnXemDanhMuc;
        private Button btnXoaDanhMuc;
        private Button btnSuaDanhMuc;
        private Button btnThemDanhMuc;
        private DataGridView dgvBanAn;
        private Button btnXemBanAn;
        private Button btnXoaBanAn;
        private Button btnSuaBanAn;
        private Button btnThemBanAn;
        private DataGridView dgvTaiKhoan;
        private Button btnXemTaiKhoan;
        private Button btnXoaTaiKhoan;
        private Button btnSuaTaiKhoan;
        private Button btnThemTaiKhoan;
        private Button btnThongKe;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtPTuNgay;
        private NumericUpDown nmrGia;
        private ComboBox cboDanhMuc;
        private Label lblGia;
        private Label lblDanhMuc;
        private Label lblTenMon;
        private Label lblIDMonAn;
        private TextBox txtTenMon;
        private TextBox txtID;
        private TextBox txtTimMonAn;
        private Button btnTim;
        private Label lblTenDanhMuc;
        private Label lblIDDanhMuc;
        private TextBox textBox1;
        private TextBox txtIDDanhMuc;
        private ComboBox cboTrangThai;
        private Label lblTrangThai;
        private Label lblTenBan;
        private Label lblIDBanAn;
        private TextBox txtTenBan;
        private TextBox txtIDBanAn;
        private ComboBox cboLoaiTaiKhoan;
        private Label lblLoaiTaiKhoan;
        private Label lblTenHienThi;
        private Label lblTenTaiKhoan;
        private TextBox txtTenHienThi;
        private TextBox txtTenTaiKhoan;
        private Button btnDatLaiMatKhau;
    }
   

    }