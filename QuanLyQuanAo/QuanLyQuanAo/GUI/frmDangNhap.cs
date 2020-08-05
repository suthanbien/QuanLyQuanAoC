using quanlyquanao.GUI;
using QuanLyQuanAo.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyquanao
{
    public partial class frmDangNhap : Form
    {
        #region các khai báo
        #endregion

        #region các phương thức
        public frmDangNhap()
        {
            InitializeComponent();
        }

        //kiểm tra quyền
        public int KiemTraQuyenDangNhap()
        {
            int quyen=0;
            if (rbNhanVien.Checked == false && rbQuanLy.Checked == false)// admin
            {
                quyen = 1;
            }
            else if (rbNhanVien.Checked == false)   //quản lý
            {
                quyen = 2;
            }
            else    //nhân viên
            {
                quyen = 3;
            }
            return quyen;
        }
        private string MaHoaBuocNhay(string chuoiKyTu, int buocNhay)
        {
            char[] mangKT = chuoiKyTu.ToArray();
            for (int i = 0; i < mangKT.Length; i++)
            {
                char kyTu = mangKT[i];
                kyTu = (char)(kyTu + buocNhay);

                if (kyTu > 'Z')
                {
                    kyTu = (char)(kyTu - 26);
                }
                else if (kyTu < 'a')
                {
                    kyTu = (char)(kyTu + 26);
                }

                mangKT[i] = kyTu;
            }

            return new string(mangKT);

        }


        #endregion

        #region các xử lý
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void lblDangNhap_Click(object sender, EventArgs e)
        {
            rbNhanVien.Checked = false;
            rbQuanLy.Checked = false;
        }

        private void llblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           frmQuenMatKhau frm = new frmQuenMatKhau();
            frm.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            string taiKhoan = txtTenTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            int quyen;
            frmMain frm = new frmMain();

            quyen = KiemTraQuyenDangNhap();

            //truyền thông tin đăng nhập vào BUS để xử lý
            BUSDangNhap.Instance.KiemTraDangNhap(taiKhoan, matKhau, quyen,frm,this);

            
        }

        private void llblKiemTraKetNoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (BUSDangNhap.Instance.KiemTraKetNoi() == true)
            {
                MessageBox.Show("Kết nối CSDL thành Công.");
            }
            else
            {
                MessageBox.Show("Kết nối CSDL thất bại.");
            }
        }

        private void llblDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDoiMatKhau.tenTK = txtTenTaiKhoan.Text;
           frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
          

        }
        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion


    }
}
