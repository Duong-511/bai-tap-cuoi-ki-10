using QuanLyNhaHang1.BLL;
using QuanLyNhaHang1.DAO;
using QuanLyNhaHang1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace QuanLyNhaHang1
{
    public partial class frmQuanLiNhaHang : Form
    {


        private TaiKhoanDTO dangNhapTaiKhoan;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TaiKhoanDTO DangNhapTaiKhoan
        {
            get { return dangNhapTaiKhoan; }
            set { dangNhapTaiKhoan = value; DoiTaiKhoan(dangNhapTaiKhoan.Type); }
        }

        public frmQuanLiNhaHang(TaiKhoanDTO taiKhoan)
        {
            InitializeComponent();

            this.DangNhapTaiKhoan = taiKhoan;

            this.AutoScaleMode = AutoScaleMode.None;

            LoadBanAn();

            LoadDanhMuc();

            LoadComboboxBanAn(cboChuyenBan);


        }


        void DoiTaiKhoan(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinCáNhânToolStripMenuItem.Text += " (" + DangNhapTaiKhoan.TenHienThi + ")";
        }
        void LoadBanAn()
        {
            flpBanAn.Controls.Clear();

            List<BanAnDTO> danhSachBan = BanAnBLL.Instance.LayDanhSachBan();

            foreach (BanAnDTO item in danhSachBan)
            {
                Button btn = new Button() { Width = BanAnDAO.BanWidth, Height = BanAnDAO.BanHeight };
                btn.Text = item.TenBan + Environment.NewLine + item.TrangThai;
                btn.Click += btn_Click;
                btn.Tag = item;


                btn.BackColor = item.TrangThai == "Trống" ? Color.Aqua : Color.LightPink;

                flpBanAn.Controls.Add(btn);
            }
        }
        void btn_Click(object? sender, EventArgs e)
        {
            #region oldcode
            //int maBanAn = ((sender as Button).Tag as BanAnDTO).MaBan;
            //lsvHoaDon.Tag = (sender as Button).Tag;
            //HienThiHoaDon(maBanAn);
            #endregion
            Button btn = sender as Button;
            BanAnDTO ban = btn.Tag as BanAnDTO;

            lsvHoaDon.Tag = ban;
            HoaDonBLL.Instance.HienThiHoaDon(ban.MaBan, lsvHoaDon, txtTongTien);
            //HienThiHoaDon(ban.MaBan);
        }
        //void HienThiHoaDon(int id)
        //{
        //    lsvHoaDon.Items.Clear();
        //    var (danhSach, tongTien) = HoaDonBLL.Instance.LayChiTietHoaDon(id);


        //    foreach (var item in danhSach)
        //    {
        //        ListViewItem lsvItem = new ListViewItem(item.TenMon.ToString());
        //        lsvItem.SubItems.Add(item.SoLuong.ToString());
        //        lsvItem.SubItems.Add(item.DonGia.ToString());
        //        lsvItem.SubItems.Add(item.ThanhTien.ToString());

        //        lsvHoaDon.Items.Add(lsvItem);
        //    }

        //    txtTongTien.Text = tongTien.ToString();

        //}
        void LoadDanhMuc()
        {
            List<DanhMucDTO> danhSachDanhMuc = DanhMucBLL.Instance.LayDanhSachDanhMuc();
            cboDanhMuc.DataSource = danhSachDanhMuc;
            cboDanhMuc.DisplayMember = "TenDanhMuc";

        }
        void LoadMonAnByMaDanhMuc(int id)
        {
            List<MonAnDTO> danhSachMonAn = MonAnBLL.Instance.LayMonAnTheoDanhMuc(id);
            cboMonAn.DataSource = danhSachMonAn;
            cboMonAn.DisplayMember = "TenMon";
        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region oldcode
            //int id = 0;
            //ComboBox cbo = sender as ComboBox;
            //if (cbo.SelectedItem == null)
            //    return;

            //DanhMucDTO selected = cbo.SelectedItem as DanhMucDTO;

            //id = selected.MaDanhMuc;

            //LoadMonAnByMaDanhMuc(id);
            #endregion
            if (cboDanhMuc.SelectedItem == null) return;
            int maDanhMuc = (cboDanhMuc.SelectedItem as DanhMucDTO).MaDanhMuc;
            cboMonAn.DataSource = MonAnBLL.Instance.LayMonAnTheoDanhMuc(maDanhMuc);
            cboMonAn.DisplayMember = "TenMon";
            LoadMonAnByMaDanhMuc(maDanhMuc);

        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            #region oldcode
            //BanAnDTO banAn = lsvHoaDon.Tag as BanAnDTO;
            //if (banAn == null)
            //{
            //    MessageBox.Show("Vui lòng chọn bàn ăn");
            //    return;
            //}

            //int maHoaDon = HoaDonDAO.Instance.GetUncheckMaHoaDonByMaBan(banAn.MaBan);
            //int maMon = (cboMonAn.SelectedItem as MonAnDTO).MaMon;

            //int soLuong = (int)nmrSoLuong.Value;
            //if (maHoaDon == -1)
            //{
            //    HoaDonDAO.Instance.InsertHoaDon(banAn.MaBan);
            //    ChiTietHoaDonDAO.Instance.InsertChitietHoaDon(HoaDonDAO.Instance.GetMaxHoaDon(), maMon, soLuong);
            //}
            //else
            //{

            //    ChiTietHoaDonDAO.Instance.InsertChitietHoaDon(maHoaDon, maMon, soLuong);

            //}

            //HienThiHoaDon(banAn.MaBan);

            #endregion
            BanAnDTO ban = lsvHoaDon.Tag as BanAnDTO;
            MonAnDTO mon = cboMonAn.SelectedItem as MonAnDTO;
            int soLuong = (int)nmrSoLuong.Value;

            HoaDonBLL.Instance.ThemMon(ban, mon, soLuong);

            HoaDonBLL.Instance.HienThiHoaDon(ban.MaBan, lsvHoaDon, txtTongTien);
            BanAnBLL.Instance.LayDanhSachBan();
            LoadBanAn();
            //HienThiHoaDon(ban.MaBan);

        }

        void LoadComboboxBanAn(ComboBox cbo)
        {
            cbo.DataSource = BanAnDAO.Instance.LoadDanhSachBan();
            cbo.DisplayMember = "TenBan";
        }
        


        private void btnDatBan_Click(object sender, EventArgs e)
        {
            BanAnDTO ban = lsvHoaDon.Tag as BanAnDTO;

            if (ban == null)
            {
                MessageBox.Show("Không xác định được bàn!");
                return;
            }

            if (MessageBox.Show($"Đặt bàn {ban.TenBan} ?",
                "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool kq = BanAnBLL.Instance.DatBan(ban);

                if (kq)
                {
                    MessageBox.Show("Đặt bàn thành công!");
                    LoadBanAn();
                }
                else
                {
                    MessageBox.Show("Bàn không còn trống!");
                }
            }
        }


        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            #region oldcode
            //DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn chuyển bàn "+ (lsvHoaDon.Tag as BanAnDTO).TenBan +" qua bàn " + (cboChuyenBan.SelectedItem as BanAnDTO).TenBan + " không ?", "Xác nhận chuyển bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{ 

            //int maBan1 = (lsvHoaDon.Tag as BanAnDTO).MaBan;
            //int maBan2 = (cboChuyenBan.SelectedItem as BanAnDTO).MaBan;
            //BanAnDAO.Instance.ChuyenBan(maBan1, maBan2);

            //LoadBanAn();
            //}
            #endregion
            BanAnDTO banHienTai = lsvHoaDon.Tag as BanAnDTO;
            BanAnDTO banChuyen = cboChuyenBan.SelectedItem as BanAnDTO;
            if (banHienTai == null || banChuyen == null)
            {
                MessageBox.Show("Vui lòng chọn bàn cần chuyển và bàn muốn chuyển đến.");
                return;
            }
            if (banHienTai.MaBan == banChuyen.MaBan)
            {
                MessageBox.Show("Không thể chuyển sang cùng bàn!");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn chuyển bàn {banHienTai.TenBan} sang {banChuyen.TenBan}?",
                "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BanAnBLL.Instance.ChuyenBan(banHienTai, banChuyen);
                LoadBanAn();
            }
        }
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinTaiKhoan thongTinTaiKhoan = new frmThongTinTaiKhoan(DangNhapTaiKhoan);
            thongTinTaiKhoan.ShowDialog();
        }



        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            BanAnDTO ban = lsvHoaDon.Tag as BanAnDTO;
            float tongTien = float.Parse(txtTongTien.Text.Replace(",", "."));

            if (MessageBox.Show($"Bạn có chắc chắn thanh toán hóa đơn {ban.TenBan}?\nTổng tiền: {tongTien}",
                "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MessageBox.Show($"Bạn có muốn in hóa đơn {ban.TenBan}?không",
                "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<MenuDTO> danhSachMenu = new List<MenuDTO>();

                    foreach (ListViewItem item in lsvHoaDon.Items)
                    {
                        danhSachMenu.Add(new MenuDTO
                        {
                            TenMon = item.SubItems[0].Text,
                            SoLuong = int.Parse(item.SubItems[1].Text),
                            DonGia = float.Parse(item.SubItems[2].Text),
                            ThanhTien = float.Parse(item.SubItems[3].Text)
                        });
                    }



                    string filePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "HoaDon.xlsx"
            );
                    HoaDonBLL.Instance.ExportHoaDonToExcelAsync(danhSachMenu, filePath);
                    MessageBox.Show("Đã lưu hóa đơn Excel tại:\n" + filePath, "Xuất hóa đơn Excel thành công!");
                    HoaDonBLL.Instance.ThanhToan(ban, tongTien);
                    HoaDonBLL.Instance.HienThiHoaDon(ban.MaBan, lsvHoaDon, txtTongTien);
                    LoadBanAn();
                }
                else
                {
                    HoaDonBLL.Instance.ThanhToan(ban, tongTien);
                    HoaDonBLL.Instance.HienThiHoaDon(ban.MaBan, lsvHoaDon, txtTongTien);
                    LoadBanAn();
                }


            }
        }







        private void lsvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmQuanLiNhaHang_Load(object sender, EventArgs e)
        {

        }

       
    }
}
