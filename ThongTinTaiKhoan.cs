using QuanLyNhaHang1.DAO;
using QuanLyNhaHang1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang1
{
    public partial class frmThongTinTaiKhoan : Form
    {


        private TaiKhoanDTO dangNhapTaiKhoan;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TaiKhoanDTO DangNhapTaiKhoan
        {
            get { return dangNhapTaiKhoan; }
            set { dangNhapTaiKhoan = value; DoiTaiKhoan(dangNhapTaiKhoan); }
        }


        public frmThongTinTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            InitializeComponent();

            DangNhapTaiKhoan = taiKhoan;
        }



        void DoiTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            txtTenDangNhap.Text = DangNhapTaiKhoan.TenDangNhap;
            txtTenHienThi.Text = DangNhapTaiKhoan.TenHienThi;

        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }


        void UpdateTaiKhoan()
        {
            string tenHienThi = txtTenHienThi.Text;
            string matKhauCu = txtMatKhau.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string nhapLaiMatKhauMoi = txtNhapLai.Text;
            string tenDangNhap = txtTenDangNhap.Text;
            if (!matKhauMoi.Equals(nhapLaiMatKhauMoi))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới đúng với mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (TaiKhoanDAO.Instance.UpdateTaiKhoan(tenDangNhap, tenHienThi, matKhauCu, matKhauMoi))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            UpdateTaiKhoan();   
        }
    }
}
