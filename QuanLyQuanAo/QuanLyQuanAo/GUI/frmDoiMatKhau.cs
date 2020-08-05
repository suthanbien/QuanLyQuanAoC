using QuanLyQuanAo.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyquanao.GUI
{
    public partial class frmDoiMatKhau : Form
    {

        #region các khai báo
        public static string tenTK = "";
        #endregion


        #region các phương thức
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        //kiểm tra nhập thông tin
        private bool KiemTra(string tenTK, string nMKCu, string nMKMoi, string nNhapLaiMK)
        {
            if (tenTK.Length == 0 || nMKCu.Length == 0 || nMKMoi.Length == 0 || nNhapLaiMK.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!", "Thông Báo");
                return false;
            }
            else if (!nMKMoi.Equals(nNhapLaiMK))
            {
                MessageBox.Show("Mật khẩu mới và nhập lại phải giống nhau !!", "Thông Báo");
                return false;
            }
            else if(nMKCu.Equals( nMKMoi))
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu củ !!", "Thông Báo");
                return false;
            }
            else
            {
                return true;
            }
            
        }

        #endregion



        #region các xử lý
        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = tenTK;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string tenTK = "", nMKCu = "", nMKMoi = "", nNhapLaiMK = "";
            tenTK = txtTaiKhoan.Text;
            nMKCu = txtMatKhauHienTai.Text;
            nMKMoi = txtNhapLaiMatKhauMoi.Text;
            nNhapLaiMK = txtNhapLaiMatKhauMoi.Text;

            if (KiemTra(tenTK, nMKCu, nMKMoi, nNhapLaiMK))
            {
                if (BUSDoiMatKhau.Instance.DoiMatKhau(tenTK, nMKCu, nMKMoi))
                {
                    MessageBox.Show("Thành Công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Thất bại. Vui lòng kiểm tra lại thông tin!!", "Thông Báo");
                }
            }

        }
        #endregion




    }
}
