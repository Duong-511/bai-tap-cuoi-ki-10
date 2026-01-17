using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.DTO
{
    public class HoaDonDTO
    {

        public HoaDonDTO(int maHoaDon, DateTime? ngayLap, DateTime? ngayTra, int trangThai) 
        {
            this.MaHoaDon = maHoaDon;
            this.NgayLap = ngayLap;
            this.NgayTra = ngayTra;
            this.TrangThai = trangThai;
        }

        public HoaDonDTO (DataRow row) 
        
        {
            this.MaHoaDon = (int) row["maHoaDon"];
            this.NgayLap = (DateTime?)row["ngayLap"];
            var ngayTraTam = row["ngayTra"];
            if (ngayTraTam.ToString() != "") 
            this.NgayTra = (DateTime?)row["ngayTra"];
            this.TrangThai = (int)row["trangThai"];
        }

        private int trangThai;
        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }



        private DateTime? ngayTra;

        public DateTime? NgayTra
        {
            get { return ngayTra; }
            set { ngayTra = value; }
        }



        private DateTime? ngayLap;

        public DateTime? NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }


        private int maHoaDon;

        public int MaHoaDon 
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
    }
}
