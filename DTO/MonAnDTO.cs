using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.DTO
{
    public class MonAnDTO
    {
        public MonAnDTO(int maMon, string tenMon, float donGia, int maDanhMuc)
        {
            this.MaMon = maMon;
            this.TenMon = tenMon;
            this.DonGia = donGia;
            this.MaDanhMuc = maDanhMuc;
        }



        public MonAnDTO(System.Data.DataRow row)
        {
            this.MaMon = (int)row["maMon"];
            this.TenMon = row["tenMon"].ToString();
            this.DonGia = (float) Convert.ToDouble( row["donGia"].ToString());
            this.MaDanhMuc = (int)row["maDanhMuc"];
        }




        private int maMon;
        public int MaMon
        {
            get { return maMon; }
            set { maMon = value; }
        }


        private string tenMon;
        public string TenMon
        {
            get { return tenMon; }
            set { tenMon = value; }
        }



        private float donGia;
        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }



        private int maDanhMuc;
        public int MaDanhMuc
        {
            get { return maDanhMuc; }
            set { maDanhMuc = value; }
        }
    }
}
