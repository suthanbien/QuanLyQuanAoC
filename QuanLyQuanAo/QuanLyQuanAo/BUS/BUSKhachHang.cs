using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.BUS
{
    class BUSKhachHang
    {
        #region các khai báo
        private static BUSKhachHang instance;
        List<ClassKhachHang> lstKhachHang = new List<ClassKhachHang>();
        List<string> lstChucVu = new List<string>();
        #endregion

        #region các phương thức
        public static BUSKhachHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSKhachHang();
                }
                return instance;
            }
        }

        private BUSKhachHang()
        {

        }

        public void GetKhachHang(DataGridView dgv)
        {
            lstKhachHang = DAOKhachHang.Instance.GetKhachHang();
            dgv.DataSource = lstKhachHang;
           // GetListChucVu();
        }
        #endregion

        #region các xử lý
        #endregion
    }
}
