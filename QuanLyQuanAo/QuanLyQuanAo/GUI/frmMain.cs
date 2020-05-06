using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.GUI
{

    public partial class frmMain : Form
    {
        #region Khai báo biến

        public static string quyen ="";
        public static string taiKhoan = "";
        public static char TuCach = ' ';
        public static string mSThamChieu = "";

        #endregion

        #region các phương thức
        public frmMain()
        {
            InitializeComponent();
        }

        public static bool QuyenNguoiSuDung(char TuCach, string MsMau, char TacVu)
        { // Hình thái thứ nhất của quyền người sử dụng
          //  string s = QuyenNguoiSuDung(TuCach, MsMau); // Áp dụng hình thái thứ hai
            string s = "2222";
            if (s != null)
                switch (TacVu)
                {
                    case 'A': return s[0] == '1' || s[0] == '2'; // Tác vụ A=Add (Thêm)
                    case 'E': return s[1] == '1' || s[0] == '2'; // Tác vụ E=Edit (Sửa)
                    case 'D': return s[2] == '1' || s[0] == '2'; // Tác vụ D=Delete (Xóa)
                    case 'P': return s[0] == '2'; // Tác vụ P=Print (In)
                }
            return false;
        }
        public static string QuyenNguoiSuDung(char TuCach, string MsMau)
        { // Hình thái thứ hai của quyền người sử dụng
            try
            { // Thử
              /*  string SQL = "select Quyen from CapQuyen where TuCach='" + TuCach
                + "' and MsMau='" + MsMau.Trim() + "'";
                conn = new SqlConnection(ConnStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                string s = (string)cmd.ExecuteScalar();
                conn.Close();*/
                return "";
            }
            catch
            { // Đón bắt lỗi sai
                return "";
            }
        }
        public void moMnuLoaiSanPham()
        {
            mnuLoaiSanPham.Enabled = true;
        }

        public Form FormExist(String FormName)
        {
            foreach (Form frm in MdiChildren)
                if (frm.Name == FormName) return frm;
            return null;
        }
        #endregion

        #region các xử lý
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        #endregion

        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {

            frmLoaiSanPham frm = (frmLoaiSanPham)FormExist("");
            if (frm == null)
            {
                frm = new frmLoaiSanPham();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Focus();

            mnuLoaiSanPham.Enabled = false;
        }
    }
}
