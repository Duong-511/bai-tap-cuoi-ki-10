using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.DAO
{
    public class MonAnDAO
    {
        private static MonAnDAO instance;
        public static MonAnDAO Instance
        {
            get { if (instance == null) instance = new MonAnDAO(); return MonAnDAO.instance; }
            private set { MonAnDAO.instance = value; }
        }
        private MonAnDAO() { }

        public List<DTO.MonAnDTO> GetMonAnByMaDanhMuc(int maDanhMuc)
        {
            List<DTO.MonAnDTO> danhSachMonAn = new List<DTO.MonAnDTO>();

            string query = "USP_GetMonAnByDanhMuc @MaDanhMuc";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { maDanhMuc });

            foreach (DataRow item in data.Rows)
            {
                DTO.MonAnDTO monAn = new DTO.MonAnDTO(item);
                danhSachMonAn.Add(monAn);
            }

            return danhSachMonAn;

        }


        public List<DTO.MonAnDTO> GetDanhSachMonAn()
        {
            List<DTO.MonAnDTO> danhSachMonAn = new List<DTO.MonAnDTO>();
            string query = "select * from MonAn";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO.MonAnDTO monAn = new DTO.MonAnDTO(item);
                danhSachMonAn.Add(monAn);
            }
            return danhSachMonAn;
        }

        public bool ThemMonAn(string tenMon, float donGia, int maDanhMuc)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("exec USP_ThemMon @TenMon  , @DonGia  , @MaDanhMuc", new object[] { tenMon, donGia, maDanhMuc });
            return result > 0;
        }
        public bool  UpdateMonAn(string tenMon, float donGia, int maDanhMuc, int maMon)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("exec USP_UpdateMon @TenMon  , @DonGia  , @MaDanhMuc , @MaMon", new object[] { tenMon, donGia, maDanhMuc , maMon });
            return result > 0;
        }
        public bool XoaMonAn(int maMon)
        {
            ChiTietHoaDonDAO.Instance.XoaChiTietHoaDonByMaMon(maMon);
            int result = DataProvider.Instance.ExcuteNonQuery("exec USP_XoaMon  @MaMon", new object[] { maMon });
            return result > 0;
        }
    }
}
