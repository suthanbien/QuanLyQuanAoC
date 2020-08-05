using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.BUS
{
    class BUSQuenMatKhau
    {

        #region các khai báo
        private static BUSQuenMatKhau instance;
        #endregion

        #region các phương thức
        public static BUSQuenMatKhau Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSQuenMatKhau();
                }
                return instance;
            }
        }

        private BUSQuenMatKhau()
        {

        }
        #endregion

        #region các xử lý
        public string KiemTraEmail(string strGmail)
        {
            string taiKhoan="";
            taiKhoan = DAOQuenMatKhau.Instance.KiemTraEmail(strGmail);
            return taiKhoan;
        }

        public string LayLaiMatKhau(string strGmail)
        {
            string matKhau = "";
            matKhau = DAOQuenMatKhau.Instance.LayLaiMatKhau(strGmail);
            return matKhau;
        }

        #endregion
    }
}
