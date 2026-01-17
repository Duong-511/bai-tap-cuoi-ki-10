using QuanLyNhaHang1.DAO;
using QuanLyNhaHang1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.BLL
{
    public class MonAnBLL
    {
        #region singleton MonAnBLL
        private static MonAnBLL instance;
        public static MonAnBLL Instance
        {
            get
            {
                if (instance == null) instance = new MonAnBLL();
                return instance;
            }
            private set { instance = value; }
        }

        private MonAnBLL() { }
        #endregion

        public List<MonAnDTO> LayMonAnTheoDanhMuc(int maDanhMuc)
        {
            return MonAnDAO.Instance.GetMonAnByMaDanhMuc(maDanhMuc);
        }
    }
}
