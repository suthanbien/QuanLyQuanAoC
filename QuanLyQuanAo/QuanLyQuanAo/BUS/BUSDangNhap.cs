using quanlyquanao.DAO;
using QuanLyQuanAo.GUI;
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

        //xử lý sự kiện đăng nhập
        public void KiemTraDangNhap(string taiKhoan, string matKhau, int quyen,frmMain frm_Main, frmDangNhap frm_DangNhap)
        {

            if (DAODangNhap.Instance.KiemTraDangNhap(taiKhoan,matKhau,quyen).Count()>0)
            {

               /* MessageBox.Show("Đăng Nhập thành công tài khoản: "
                    + DAODangNhap.Instance.KiemTraDangNhap(taiKhoan, matKhau, quyen).Count()+"\n"
                   + DAODangNhap.Instance.KiemTraDangNhap(taiKhoan, matKhau, quyen)[0].TenDangNhap.ToString() + "\n" +
                   "Quyền: " + DAODangNhap.Instance.KiemTraDangNhap(taiKhoan, matKhau, quyen)[0].Quyen.ToString());*/


                 frmMain.quyen = DAODangNhap.Instance.KiemTraDangNhap(taiKhoan,matKhau,quyen)[0].Quyen.ToString();
                 frmMain.taiKhoan = DAODangNhap.Instance.KiemTraDangNhap(taiKhoan,matKhau,quyen)[0].TenDangNhap.ToString();
                frmMain.mSNhanVien=DAODangNhap.Instance.KiemTraDangNhap(taiKhoan, matKhau, quyen)[0].MaNhanVien.ToString();
                frm_Main.Show();
                 frm_DangNhap.Visible=false;
                
               // return DAODangNhap.Instance.KiemTraDangNhap(taiKhoan, matKhau, quyen)[0].MaNhanVien.ToString();

            }
            else
                MessageBox.Show("Sai tên đăng nhập/mật khẩu\nHoặc TK đã khóa", "Mật khẩu");
           // return "";
            // MessageBox.Show(DAODangNhap.Instance.KiemTraKetNoi()[1].MaNhanVien+"");
        }

        #endregion



        #region các xử lý


        #endregion

    }
}
