using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.DTO
{
    public class ChiTietHoaDonDTO
    {
        public ChiTietHoaDonDTO(int maChiTietHoaDon,int maHoaDon, int maMon, int soLuong)
        {
            this.MaChiTietHoaDon = maChiTietHoaDon;
            this.MaHoaDon = maHoaDon;
            this.MaMon = maMon;
            this.SoLuong = soLuong;
        }

        public ChiTietHoaDonDTO(DataRow row)


        {
            this.MaChiTietHoaDon = (int) row["maChiTietHoaDon"];
            this.MaHoaDon = (int) row ["maHoaDon"];
            this.MaMon = (int) row ["maMon"];
            this.SoLuong = (int) row ["soLuong"];
        }


        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }



        private int maMon;
        public int MaMon
        {
            get { return maMon; }
            set { maMon = value; }
        }



        private int maHoaDon;
        public int MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }



        private int maChiTietHoaDon;

        public int MaChiTietHoaDon
        {
            get { return maChiTietHoaDon; }
            set { maChiTietHoaDon = value; }
        }
    }
}
