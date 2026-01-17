using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.DTO
{
    public class BanAnDTO
    {

        private int maBan;
        public int MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }

        private string tenBan;
        public string TenBan
        {
            get { return tenBan; }
            set { tenBan = value; }
        }

        private string trangThai;
        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        public BanAnDTO(int maBan, string tenBan, string trangThai)
        {
            this.MaBan = maBan;
            this.TenBan = tenBan;
            this.TrangThai = trangThai;
        } 
        public BanAnDTO(DataRow row) 
        {
            this.maBan = (int)row["MaBan"];
            this.tenBan = row["TenBan"].ToString();
            this.trangThai = row["TrangThai"].ToString();
        }
    }
}
