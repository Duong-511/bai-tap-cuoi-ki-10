using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.DTO
{
    public class TaiKhoanDTO
    {

        public TaiKhoanDTO(string tenDangNhap, string tenHienThi, int type, string matKhau = null)
        {
            this.TenDangNhap = tenDangNhap;
            this.TenHienThi = tenHienThi;
            this.Type = type;
            this.MatKhau = matKhau;
        }



        public TaiKhoanDTO(DataRow row)
        {
            this.TenDangNhap = row["TenDangNhap"].ToString();
            this.TenHienThi = row["TenHienThi"].ToString();
            this.Type = (int)row["TYPE"];
            this.MatKhau = row["matKhau"].ToString();
        }



        private string tenDangNhap;
        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }


        private string tenHienThi;
        public string TenHienThi
        {
            get { return tenHienThi; }
            set { tenHienThi = value; }
        }

        private string matKhau;
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }



        private int type;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
