namespace QuanLyNhaHang1
{
    partial class frmDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTenDangNhap = new Label();
            lblMatKhau = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTenDangNhap.Location = new Point(76, 59);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(150, 27);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên Đăng Nhập:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblMatKhau.Location = new Point(76, 114);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(135, 27);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật Khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(250, 56);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(321, 27);
            txtTenDangNhap.TabIndex = 1;
            txtTenDangNhap.TextChanged += txtTenDangNhap_TextChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(250, 114);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(321, 27);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(310, 195);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(94, 42);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(464, 195);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 42);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 294);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTenDangNhap);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenDangNhap;
        private Label lblMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
    }
}
