using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QuanLyNhaHang1.DAO;
using QuanLyNhaHang1.DTO;

namespace QuanLyNhaHang1
{
    public partial class frmAdmin : Form
    {

        BindingSource monAnList = new BindingSource();

        public frmAdmin()
        {
            InitializeComponent();

            dgvMonAn.DataSource = monAnList;

            LoadNgay();

            LoadHoaDonByNgay(dtPTuNgay.Value, dtpDenNgay.Value);

            LoadDanhSachMonAn();

            LoadDanhMucVaoCombobox(cboDanhMuc);

            AddMonAnBindinng();
        }

        void LoadHoaDonByNgay(DateTime ngayLap, DateTime ngayTra)
        {
            dgvDoanhThu.DataSource = HoaDonDAO.Instance.GetHoaDonListByNgay(ngayLap, ngayTra);
        }

        void LoadNgay()
        {
            DateTime today = DateTime.Now;
            dtPTuNgay.Value = new DateTime(today.Year, today.Month, 1);
            dtpDenNgay.Value = dtPTuNgay.Value.AddMonths(1).AddDays(-1);

        }

        private void lblGia_Click(object sender, EventArgs e)
        {

        }
        private void lblDanhMuc_Click(object sender, EventArgs e)
        {

        }
        private void lblIDMonAn_Click(object sender, EventArgs e)
        {

        }
        private void lblTenMon_Click(object sender, EventArgs e)
        {

        }

        private void dgvBanAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadHoaDonByNgay(dtPTuNgay.Value, dtpDenNgay.Value);
        }


        void LoadDanhSachMonAn()
        {
            monAnList.DataSource = MonAnDAO.Instance.GetDanhSachMonAn();
        }
        private void btnXemMonAn_Click(object sender, EventArgs e)
        {
            LoadDanhSachMonAn();
        }

        void AddMonAnBindinng()
        {
            txtTenMon.DataBindings.Add(new Binding("Text", dgvMonAn.DataSource, "TenMon", true, DataSourceUpdateMode.Never));
            txtID.DataBindings.Add(new Binding("Text", dgvMonAn.DataSource, "MaMon", true, DataSourceUpdateMode.Never));
            nmrGia.DataBindings.Add(new Binding("Value", dgvMonAn.DataSource, "DonGia", true, DataSourceUpdateMode.Never));

        }

        void LoadDanhMucVaoCombobox(ComboBox cbo)
        {
            cbo.DataSource = DanhMucDAO.Instance.GetDanhSachDanhMuc();
            cbo.DisplayMember = "TenDanhMuc";
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            int maDanhMuc = (int)dgvMonAn.SelectedCells[0].OwningRow.Cells["MaDanhMuc"].Value;

            DanhMucDTO danhMuc = DanhMucDAO.Instance.GetDanhMucByMaDanhMuc(maDanhMuc);

            cboDanhMuc.SelectedItem = danhMuc;

            int index = -1;
            int i = 0;
            foreach (DanhMucDTO item in cboDanhMuc.Items)
            {
                if (item.MaDanhMuc == danhMuc.MaDanhMuc)
                {
                    index = i;
                    break;
                }
                i++;
            }
            cboDanhMuc.SelectedIndex = index;

        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            string tenMon = txtTenMon.Text;
            float donGia = (float)nmrGia.Value;
            int maDanhMuc = (cboDanhMuc.SelectedItem as DanhMucDTO).MaDanhMuc;

            if (MonAnDAO.Instance.ThemMonAn(tenMon, donGia, maDanhMuc))
            {
                MessageBox.Show("Thêm món ăn thành công");
                LoadDanhSachMonAn();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món ăn");
            }
        }

        private void SuaMonAn_Click(object sender, EventArgs e)
        {
            string tenMon = txtTenMon.Text;
            float donGia = (float)nmrGia.Value;
            int maDanhMuc = (cboDanhMuc.SelectedItem as DanhMucDTO).MaDanhMuc;
            int maMon = Convert.ToInt32(txtID.Text);

            if (MonAnDAO.Instance.UpdateMonAn(tenMon, donGia, maDanhMuc, maMon))
            {
                MessageBox.Show("Sửa món ăn thành công");
                LoadDanhSachMonAn();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa món ăn");
            }
        }

        private void XoaMonAn_Click(object sender, EventArgs e)
        {
            int maMon = Convert.ToInt32(txtID.Text);

            if (MonAnDAO.Instance.XoaMonAn(maMon))
            {
                MessageBox.Show("Xóa món ăn thành công");
                LoadDanhSachMonAn();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa món ăn");
            }
        }
    }
}
