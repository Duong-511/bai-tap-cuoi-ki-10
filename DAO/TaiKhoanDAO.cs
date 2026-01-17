using QuanLyNhaHang1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return TaiKhoanDAO.instance; }
            private set { TaiKhoanDAO.instance = value; }
        }
        private TaiKhoanDAO() { }

        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            string query = "USP_DangNhap @TenDangNhap , @MatKhau";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] {tenDangNhap , matKhau});
            return result.Rows.Count > 0;
        }



        public bool UpdateTaiKhoan(string tenDangNhap, string tenHienThi, string matKhau, string matKhauMoi)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("exec USP_UpdateTaiKhoan @TenDangNhap , @TenHienThi , @MatKhau , @MatKhauMoi ",
                new object[] {tenDangNhap, tenHienThi, matKhau, matKhauMoi });
            return result  > 0;
        }



        public TaiKhoanDTO getTaiKhoanByTenDangNhap(string tenDangNhap)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("Exec USP_GetTaiKhoanByTenDangNhap @TenDangNhap", new object[] {tenDangNhap});
            foreach (DataRow item in data.Rows)
            {
                return new TaiKhoanDTO(item);
            }
            return null;
        }

    }
}
