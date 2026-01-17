using Microsoft.Data.SqlClient;
using QuanLyNhaHang1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.DAO
{
    public class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO? instance;
        public static ChiTietHoaDonDAO Instance
        {
            get { if (instance == null) instance = new ChiTietHoaDonDAO(); return instance; }
            private set { instance = value; }
        }
        private ChiTietHoaDonDAO() { }

        public List<DTO.ChiTietHoaDonDTO> GetListChiTietHoaDonByMaHoaDon(int maHoaDon)
        {
            List<DTO.ChiTietHoaDonDTO> list = new List<DTO.ChiTietHoaDonDTO>();
            string query = "SELECT * FROM ChiTietHoaDon WHERE maHoaDon = " + maHoaDon;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO.ChiTietHoaDonDTO chiTietHoaDon = new DTO.ChiTietHoaDonDTO(item);
                list.Add(chiTietHoaDon);
            }
            return list;
        }

        public void XoaChiTietHoaDonByMaMon(int maMon)
        {
            DataProvider.Instance.ExcuteNonQuery("Exec USP_XoaMonTrongChiTietHoaDon @MaMon ", new object[] { maMon });
        }
        public void InsertChitietHoaDon(int maHoaDon, int maMon, int soLuong)
        {
            DataProvider.Instance.ExcuteNonQuery("Exec USP_InsertChiTietHoaDon @MaHoaDon , @MaMon , @SoLuong ", new object[] { maHoaDon, maMon, soLuong });
        }
       
    }
}
