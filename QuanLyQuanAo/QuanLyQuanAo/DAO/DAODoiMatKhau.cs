using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class DAODoiMatKhau
    {
        #region các khai báo

        private static DAODoiMatKhau instance;

        #endregion

        #region các phương thức

        public static DAODoiMatKhau Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAODoiMatKhau();
                }
                return instance;
            }
        }

        private DAODoiMatKhau()
        {

        }

        #endregion

        #region các xử lý
        public bool DoiMatKhau(string tenTK, string nMKCu, string nMKMoi)
        {
             using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
                {
                    User editUser = db.Users.Where(p => p.TenDangNhap.Equals(tenTK) 
                                                    && p.Password.Equals(nMKCu)
                                                    &&p.Quyen!=1).SingleOrDefault();

                try
                {   if(editUser != null)
                    {
                        editUser.Password = nMKMoi;
                        db.SubmitChanges();
                        return true;
                    }
                    return false;
                }
                catch 
                {
                    return false;
                }
            }
            
        }
        #endregion
    }
}
