using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class DAOQuenMatKhau
    {


        #region các khai báo
        private static DAOQuenMatKhau instance;
        #endregion

        #region các phương thức
        public static DAOQuenMatKhau Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOQuenMatKhau();
                }
                return instance;
            }
        }

        private DAOQuenMatKhau()
        {

        }
        #endregion

        #region các xử lý
        public string KiemTraEmail(string strEmail)
        {
            using (CSDLQuanLyQuanAoDataContext db=new CSDLQuanLyQuanAoDataContext())
            {
                var tenTK = from n in db.NhanViens
                                 from u in db.Users
                                 where n.MaNhanVien == u.MaNhanVien && n.Email.Equals(strEmail)
                                 select u.TenDangNhap;
                try
                {
                    foreach (string i in tenTK)
                    {
                        return i;
                    }
                }
                catch
                {
                    return "";
                }
            }
            return "";

        }
        public string LayLaiMatKhau(string strEmail)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                var tenTK = from n in db.NhanViens
                            from u in db.Users
                            where n.MaNhanVien == u.MaNhanVien && n.Email.Equals(strEmail)
                            select u.Password;
                try
                {
                    foreach (string i in tenTK)
                    {
                        return i;
                    }
                }
                catch
                {
                    return "";
                }
            }
            return "";

        }

        #endregion
    }
}
