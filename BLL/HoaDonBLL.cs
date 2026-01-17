using QuanLyNhaHang1.DAO;
using QuanLyNhaHang1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace QuanLyNhaHang1.BLL
{
    public class HoaDonBLL
    {
        #region singleton HoaDonBLL
        private static HoaDonBLL instance;
        public static HoaDonBLL Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonBLL();
                return instance;
            }
            private set { instance = value; }
        }

        private HoaDonBLL() { }
        #endregion

        public (List<MenuDTO> danhSachMenu, float tongTien) LayChiTietHoaDon(int maBan)
        {
            List<MenuDTO> danhSachMenu = MenuDAO.Instance.GetListMenuByTable(maBan);
            float tongTien = 0;

            foreach (var item in danhSachMenu)
            {
                tongTien += item.ThanhTien;
            }

            return (danhSachMenu, tongTien);
        }

        public void HienThiHoaDon(int maBan, ListView lsvHoaDon, TextBox txtTongTien)
        {
            lsvHoaDon.Items.Clear();
            var (danhSach, tongTien) = LayChiTietHoaDon(maBan);

            foreach (var item in danhSach)
            {
                ListViewItem lsvItem = new ListViewItem(item.TenMon);
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.DonGia.ToString());
                lsvItem.SubItems.Add(item.ThanhTien.ToString());
                lsvHoaDon.Items.Add(lsvItem);
            }

            txtTongTien.Text = tongTien.ToString();
        }

        public void ThemMon(BanAnDTO ban, MonAnDTO mon, int soLuong)
        {
            if (ban == null || mon == null || soLuong <= 0) return;

            int maHoaDon = HoaDonDAO.Instance.GetUncheckMaHoaDonByMaBan(ban.MaBan);

            if (maHoaDon == -1)
            {
                HoaDonDAO.Instance.InsertHoaDon(ban.MaBan);
                maHoaDon = HoaDonDAO.Instance.GetMaxHoaDon();
            }

            ChiTietHoaDonDAO.Instance.InsertChitietHoaDon(maHoaDon, mon.MaMon, soLuong);
        }

        public void ThanhToan(BanAnDTO ban, float tongTien)
        {
            if (ban == null) return;

            int maHoaDon = HoaDonDAO.Instance.GetUncheckMaHoaDonByMaBan(ban.MaBan);
            if (maHoaDon != -1)
            {
                HoaDonDAO.Instance.ThanhToan(maHoaDon, ban.MaBan, tongTien);
            }
        }
        public  void ExportHoaDonToExcelAsync(List<MenuDTO> danhSachMenu, string filePath)
        {

            using (var fileExcel = new XLWorkbook())
            {
                var worksheet = fileExcel.Worksheets.Add("HoaDon");
                // Header
                worksheet.Cell(1, 1).Value = "Tên Món";
                worksheet.Cell(1, 2).Value = "Số Lượng";
                worksheet.Cell(1, 3).Value = "Đơn Giá";
                worksheet.Cell(1, 4).Value = "Thành Tiền";
                // Data
                for (int i = 0; i < danhSachMenu.Count; i++)
                {
                    var item = danhSachMenu[i];
                    worksheet.Cell(i + 2, 1).Value = item.TenMon;
                    worksheet.Cell(i + 2, 2).Value = item.SoLuong;
                    worksheet.Cell(i + 2, 3).Value = item.DonGia;
                    worksheet.Cell(i + 2, 4).Value = item.ThanhTien;
                }
                fileExcel.SaveAs(filePath);
                
            }
        }


    }
}
