namespace QuanLyNhaHang1
{
    partial class frmThongTinTaiKhoan
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
            lblTenDangNhap = new Label();
            lblTenHienThi = new Label();
            lblMatKhau = new Label();
            lblMatKhauMoi = new Label();
            txtTenDangNhap = new TextBox();
            txtTenHienThi = new TextBox();
            txtMatKhau = new TextBox();
            txtMatKhauMoi = new TextBox();
            lblNhapLai = new Label();
            txtNhapLai = new TextBox();
            btnCapNhat = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenDangNhap.Location = new Point(53, 53);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(127, 25);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên Đăng Nhập:";
            // 
            // lblTenHienThi
            // 
            lblTenHienThi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenHienThi.Location = new Point(53, 99);
            lblTenHienThi.Name = "lblTenHienThi";
            lblTenHienThi.Size = new Size(127, 25);
            lblTenHienThi.TabIndex = 2;
            lblTenHienThi.Text = "Tên Hiển Thị:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMatKhau.Location = new Point(53, 147);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(127, 25);
            lblMatKhau.TabIndex = 4;
            lblMatKhau.Text = "Mật Khẩu:";
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMatKhauMoi.Location = new Point(53, 196);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new Size(127, 25);
            lblMatKhauMoi.TabIndex = 6;
            lblMatKhauMoi.Text = "Mật Khẩu Mới:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(229, 51);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(323, 27);
            txtTenDangNhap.TabIndex = 1;
            // 
            // txtTenHienThi
            // 
            txtTenHienThi.Location = new Point(229, 96);
            txtTenHienThi.Name = "txtTenHienThi";
            txtTenHienThi.Size = new Size(323, 27);
            txtTenHienThi.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(229, 144);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(323, 27);
            txtMatKhau.TabIndex = 5;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(229, 193);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(323, 27);
            txtMatKhauMoi.TabIndex = 7;
            // 
            // lblNhapLai
            // 
            lblNhapLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNhapLai.Location = new Point(53, 249);
            lblNhapLai.Name = "lblNhapLai";
            lblNhapLai.Size = new Size(127, 25);
            lblNhapLai.TabIndex = 8;
            lblNhapLai.Text = "Nhập Lại:";
            // 
            // txtNhapLai
            // 
            txtNhapLai.Location = new Point(229, 246);
            txtNhapLai.Name = "txtNhapLai";
            txtNhapLai.Size = new Size(323, 27);
            txtNhapLai.TabIndex = 9;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(302, 317);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 47);
            btnCapNhat.TabIndex = 10;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(445, 317);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 47);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmThongTinTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 404);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(txtNhapLai);
            Controls.Add(lblNhapLai);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenHienThi);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblMatKhauMoi);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTenHienThi);
            Controls.Add(lblTenDangNhap);
            Name = "frmThongTinTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông Tin Cá Nhân";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenDangNhap;
        private Label lblTenHienThi;
        private Label lblMatKhau;
        private Label lblMatKhauMoi;
        private TextBox txtTenDangNhap;
        private TextBox txtTenHienThi;
        private TextBox txtMatKhau;
        private TextBox txtMatKhauMoi;
        private Label lblNhapLai;
        private TextBox txtNhapLai;
        private Button btnCapNhat;
        private Button btnThoat;
    }
}