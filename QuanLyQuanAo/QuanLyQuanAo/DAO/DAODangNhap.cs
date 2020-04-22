using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyquanao.DAO
{
    class DAODangNhap
    {
        private static DAODangNhap instance;

        public static DAODangNhap Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAODangNhap();
                }
                return instance;
            }
        }
        private DAODangNhap() { }

        public  List<DangNhap> KiemTra()
        {
            List<DangNhap> accout = new List<DangNhap>();
            CSLDQuanLyQuanAoDataContext db = new CSLDQuanLyQuanAoDataContext();
            accout = db.DangNhaps.Select(p => p).ToList();
            return accout;
        }
    }
}
