using QuanLyNhaHang1.DAO;
using QuanLyNhaHang1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.BLL
{
    public class TaiKhoanBLL
    {
        private static TaiKhoanBLL instance;
        public static TaiKhoanBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBLL();
                return instance;
            }
        }

        private TaiKhoanBLL() { }


        public TaiKhoanDTO DangNhap(string tenDangNhap, string matKhau)
        {

            
                if(tenDangNhap == string.Empty || matKhau == string.Empty)
            {
                return null;
            }
            bool ketQua = TaiKhoanDAO.Instance.DangNhap(tenDangNhap, matKhau);

            if (!ketQua)
                return null; 
            return TaiKhoanDAO.Instance.getTaiKhoanByTenDangNhap(tenDangNhap);
        }
    }
}
