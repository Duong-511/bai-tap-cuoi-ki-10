 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.DAO
{
    public class DanhMucDAO
    {
        private static DanhMucDAO instance;
        public static DanhMucDAO Instance
        {
            get { if (instance == null) instance = new DanhMucDAO(); return instance; }
            private set { instance = value; }
        }
        private DanhMucDAO() { }

        public List<DTO.DanhMucDTO> GetDanhSachDanhMuc()
        {
            List<DTO.DanhMucDTO> danhSachDanhMuc = new List<DTO.DanhMucDTO>();

            string query = "SELECT * FROM DanhMuc";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);


            foreach (DataRow item in data.Rows)
            {
                DTO.DanhMucDTO danhMuc = new DTO.DanhMucDTO(item);
                danhSachDanhMuc.Add(danhMuc);
            }
            return danhSachDanhMuc;
        }

        public DTO.DanhMucDTO GetDanhMucByMaDanhMuc(int maDanhMuc)
        {
            string query = "USP_GetDanhMucByMaDanhMuc @MaDanhMuc ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { maDanhMuc });
            foreach (DataRow item in data.Rows)
            {
                return new DTO.DanhMucDTO(item);
            }
            return null;
        }
    }
}
