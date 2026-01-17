using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.DTO
{
    public class DanhMucDTO
    {
        public DanhMucDTO(int maDanhMuc, string tenDanhMuc)
        {
            this.MaDanhMuc = maDanhMuc;
            this.TenDanhMuc = tenDanhMuc;
        }

        public DanhMucDTO(DataRow row)
        {
            this.MaDanhMuc = (int)row["maDanhMuc"];
            this.TenDanhMuc = row["tenDanhMuc"].ToString();
        }



        private string tenDanhMuc;
        public string TenDanhMuc
        {
            get { return tenDanhMuc; }
            set { tenDanhMuc = value; }
        }


        private int maDanhMuc;
        public int MaDanhMuc
        {
            get { return maDanhMuc; }
            set { maDanhMuc = value; }
        }
    }
}
