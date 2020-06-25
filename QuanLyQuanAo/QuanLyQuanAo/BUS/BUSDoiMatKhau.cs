using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.BUS
{
    class BUSDoiMatKhau
    {
        #region các khai báo
        private static BUSDoiMatKhau instance;
        #endregion

        #region các phương thức
        public static BUSDoiMatKhau Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSDoiMatKhau();
                }
                return instance;
            }
        }

        private BUSDoiMatKhau()
        {

        }
        #endregion

        #region các xử lý
        public bool DoiMatKhau(string tenTK, string nMKCu, string nMKMoi)
        {
            return DAODoiMatKhau.Instance.DoiMatKhau(tenTK, nMKCu, nMKMoi);
        }
        #endregion
    }
}
