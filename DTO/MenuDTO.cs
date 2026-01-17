using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.DTO
{
    public class MenuDTO
    {
        public MenuDTO() { }
        public MenuDTO(string tenMon, int soLuong, float donGia, float thanhTien = 0)
        {
            this.TenMon = tenMon;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
        }
        public MenuDTO(DataRow row)
        {
            this.TenMon = row["tenMon"].ToString();
            this.SoLuong = (int)row["soLuong"];
            this.DonGia = (float)Convert.ToDouble(row["donGia"].ToString());
            this.ThanhTien = (float)Convert.ToDouble(row["thanhTien"].ToString());
        }


        private float thanhTien;
        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }



        private float donGia;
        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }



        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }




        private string tenMon;
        public string TenMon
        {
            get { return tenMon; }
            set { tenMon = value; }
        }
    }
}
