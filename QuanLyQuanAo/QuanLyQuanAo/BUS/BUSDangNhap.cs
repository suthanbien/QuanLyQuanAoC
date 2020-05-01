using quanlyquanao.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyquanao
{
    class BUSDangNhap
    {

        #region các khai báo

        private static BUSDangNhap instance;

        #endregion


        #region các phương thức



        public static BUSDangNhap Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSDangNhap();
                }
                return instance;
            }
        }

        private BUSDangNhap()
        {

        }

        public bool KiemTraKetNoi()
        {
            bool KetNoi = false;

            if (DAODangNhap.Instance.KiemTraKetNoi().Count>0)
            {
                KetNoi = true;
            }

            return KetNoi;
        }

        public void KiemTraD(string taiKhoan, string matKhau, string tuCach, DataGridView dataGridView1)
        {

             dataGridView1.DataSource = DAODangNhap.Instance.KiemTraKetNoi();
            // MessageBox.Show(DAODangNhap.Instance.KiemTraKetNoi()[1].MaNhanVien+"");
        }

        #endregion



        #region các xử lý
        #endregion

    }
}
