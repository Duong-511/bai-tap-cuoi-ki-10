using QuanLyNhaHang1.DAO;
using QuanLyNhaHang1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.BLL
{
    public class DanhMucBLL
    {
        #region singleton DanhMucBLL
        private static DanhMucBLL instance;
        public static DanhMucBLL Instance
        {
            get
            {
                if (instance == null) instance = new DanhMucBLL();
                return instance;
            }
            private set { instance = value; }
        }

        private DanhMucBLL() { }
        #endregion
        public List<DanhMucDTO> LayDanhSachDanhMuc()
        {
            return DanhMucDAO.Instance.GetDanhSachDanhMuc();
        }

    }
}
