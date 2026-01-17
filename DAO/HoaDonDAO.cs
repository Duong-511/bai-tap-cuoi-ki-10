using QuanLyNhaHang1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO? instance;
        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return HoaDonDAO.instance; }
            private set { HoaDonDAO.instance = value; }
        }
        private HoaDonDAO() { }


        // thành công ra mã hóa đơn
        // thất bại trả về -1   
        public int GetUncheckMaHoaDonByMaBan(int maBan)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("exec USP_GetHoaDonByMaBan @MaBan ", new object[] {maBan});

            if (data.Rows.Count > 0)
            {
                HoaDonDTO hoaDonDTO = new HoaDonDTO(data.Rows[0]);
                return hoaDonDTO.MaHoaDon;
            }
            return -1;
        }

        public DataTable GetHoaDonListByNgay(DateTime ngayLap, DateTime ngayTra)
        {
            return DataProvider.Instance.ExcuteQuery("exec USP_GetHoaDonByNgay @NgayLap , @NgayTra ", new object[] { ngayLap, ngayTra });
        }


        public void ThanhToan(int maHoaDon , int maBan , float tongTien)
        {
            string query = "exec USP_CheckOut  @MaHoaDon , @MaBan , @TongTien ";
            DataProvider.Instance.ExcuteNonQuery(query, new object[] { maHoaDon, maBan, tongTien});
        }




        public void InsertHoaDon(int maBan)
        {
            DataProvider.Instance.ExcuteNonQuery("Exec USP_InsertHoaDon @MaBan", new object[] { maBan });
        }

        public int GetMaxHoaDon()
        {
            try
            {
                return (int)DataProvider.Instance.ExcuteScalar("select max (MaHoaDon) from HoaDon   ");
            }
            catch
            {
                return 1;
            }

        }
    }
}
