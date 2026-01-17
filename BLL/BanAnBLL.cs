using QuanLyNhaHang1.DAO;
using QuanLyNhaHang1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang1.BLL
{
    public class BanAnBLL
    {

        #region singleton BanAnBLL
        private static BanAnBLL instance;
        public static BanAnBLL Instance
        {
            get
            {
                if (instance == null) instance = new BanAnBLL();
                return instance;
            }
            private set { instance = value; }
        }
        private BanAnBLL() { }
        #endregion 


        public List<BanAnDTO> LayDanhSachBan()
        {
            List<BanAnDTO> danhSachBan = BanAnDAO.Instance.LoadDanhSachBan();

            foreach (var ban in danhSachBan)
            {
                // Chuẩn hóa trạng thái
                if (ban.TrangThai != "Trống")
                    ban.TrangThai = "Có người";
            }

            return danhSachBan;
        }

        public int LayMaBan(Button btn)
        {
            if (btn.Tag is BanAnDTO ban)
                return ban.MaBan;
            return -1;
        }
        public bool ChuyenBan(BanAnDTO banHienTai, BanAnDTO banChuyen)
        {
            if (banHienTai == null || banChuyen == null)
                return false;

            BanAnDAO.Instance.ChuyenBan(banHienTai.MaBan, banChuyen.MaBan);
            return true;
        }
        public void LoadComboboxBanAn(ComboBox cbo)
        {
            cbo.DataSource = LayDanhSachBan();
            cbo.DisplayMember = "TenBan";
        }

        public bool DatBan(BanAnDTO ban)
        {
            if (ban == null) return false;
            if (ban.TrangThai != "Trống") return false;

            return BanAnDAO.Instance.DatBan(ban.MaBan);
        }


    }
}
