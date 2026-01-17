using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set { instance = value; }
        }
        private MenuDAO() { }

        public List<DTO.MenuDTO> GetListMenuByTable(int maBan)
        {
            List<DTO.MenuDTO> listMenu = new List<DTO.MenuDTO>();

            string query = "select MonAn.TenMon, ChiTietHoaDon.SoLuong, MonAn.DonGia,MonAn.DonGia*ChiTietHoaDon.SoLuong as ThanhTien from MonAn, ChiTietHoaDon, HoaDon where ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon and  ChiTietHoaDon.MaMon = MonAn.MaMon and HoaDon.TrangThai =0 and   HoaDon.MaBan =" + maBan;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO.MenuDTO menuDTO = new DTO.MenuDTO(item);
                listMenu.Add(menuDTO);
            }
            return listMenu;
        }
    }
}
