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
            string tuCach;
            if (rbNhanVien.Checked == false && rbQuanLy.Checked == false)
            {
                tuCach = "3";
            }
            else if (rbQuanLy.Checked == false)
            {
                tuCach = "2";
            }
            else
            {
                tuCach = "1";
            }
           // BUSDangNhap.Instance.KiemTraDangNhap(taiKhoan, matKhau, tuCach);
        }



        #endregion

        private void llblKiemTraKetNoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (BUSDangNhap.Instance.KiemTraKetNoi()==true)
            {
                MessageBox.Show("Kết nối CSDL thành Công.");
            }
            else
            {
                MessageBox.Show("Kết nối CSDL thất bại.");
            }
        }
    }
}
