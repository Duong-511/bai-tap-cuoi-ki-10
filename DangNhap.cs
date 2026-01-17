using QuanLyNhaHang1.BLL;
using QuanLyNhaHang1.DAO;
using QuanLyNhaHang1.DTO;

namespace QuanLyNhaHang1
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            TaiKhoanDTO taiKhoan = TaiKhoanBLL.Instance.DangNhap(tenDangNhap, matKhau);
            if (tenDangNhap == string.Empty )
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập !", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                return;
            }
            if (matKhau == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }

            if (taiKhoan != null)
            {
                frmQuanLiNhaHang quanLi = new frmQuanLiNhaHang(taiKhoan);
                this.Hide();
                quanLi.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
