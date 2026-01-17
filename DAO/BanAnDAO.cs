using QuanLyNhaHang1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QuanLyNhaHang1.DAO
{
    public class BanAnDAO
    {
        private static BanAnDAO? instance;
        public static BanAnDAO Instance
        {
            get { if (instance == null) instance = new BanAnDAO(); return BanAnDAO.instance; }
            private set { BanAnDAO.instance = value; }
        }
        private BanAnDAO() { }



        public void ChuyenBan (int maBan1, int maBan2)
        {
            DataProvider.Instance.ExcuteQuery("Exec USP_ChuyenBan @MaBan1 , @MaBan2", new object[] { maBan1, maBan2 });
        }
        public List<BanAnDTO> LoadDanhSachBan()
        {
            List<BanAnDTO> danhSachBan = new List<BanAnDTO>();

            

            DataTable data = DataProvider.Instance.ExcuteQuery("Exec USP_GetDanhSachBan");

            foreach (DataRow item in data.Rows)
            {
                BanAnDTO banAn = new BanAnDTO(item);
                danhSachBan.Add(banAn);
            }
            return danhSachBan;
        }


        public bool DatBan(int maBan)
        {
            int result = DataProvider.Instance.ExcuteNonQuery(
                "EXEC USP_DatBan  @MaBan",
                new object[] { maBan }
            );
            return result > 0;
        }




        public static int BanWidth = 90;
        public static int BanHeight = 90;
    }
}
