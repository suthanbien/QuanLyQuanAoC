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
      
        #region các khai báo
        private static DAODangNhap instance;
        #endregion

        #region các phương thức

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

        //kiểm tra kết nối csdl
        public List<User> KiemTraKetNoi()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<User> accout = new List<User>();
                accout = db.Users.Select(p => p).ToList();
                return accout;
            }
                
        }

        //trả về list user
        public List<User> KiemTraDangNhap(string tenDangNhap, string matKhau, int quyen)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<User> accout = new List<User>();

                //kiểm tra điều kiện và truyền vào list
                accout = db.Users.Where(p => p.TenDangNhap==tenDangNhap 
                                            &&p.Password== matKhau
                                            &&p.TinhTrang==true
                                            && p.Quyen==quyen).ToList();
                                           

                //accout = db.Users.Select(p => p).ToList();
                return accout;
            }

        }

        #endregion

        #region các xử lý
        #endregion
    }
}
