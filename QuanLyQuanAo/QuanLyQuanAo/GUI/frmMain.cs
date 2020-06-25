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
        public static string mSNhanVien = "1";

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
        public void moMnuSanPham()
        {
            mnuSanPham.Enabled = true;
        }
        public void moMnuHangSanXuat()
        {
            mnuHangSanXuat.Enabled = true;
        }
        public void moMnuHangHoaAn()
        {
            mnuHangHoaDaAn.Enabled = true;
        }
        public void moMnuQLNhanVien()
        {
            mnuQLNhanVien.Enabled = true;
        }
        public void moMnuQLKhachHang(bool b)
        {
            mnuQLKhachHang.Enabled = b;
        }
        public void moMnuQLTaiKhoanNV()
        {
            mnuTKNhanVien.Enabled = true;
        }
        public void moMnuLapHoaDon()
        {
            mnuLapHoaDon.Enabled = true;
        }
        public void moMnuTimHoaDon()
        {
            mnuTimHoaDon.Enabled = true;
        }
        public void moMnuPhieuNhapHang()
        {
            mnuPhieuNhapHang.Enabled = true;
        }
        public void moMnuNhapHang()
        {
            mnuNhapHang.Enabled = true;
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

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            frmHangHoa frm = (frmHangHoa)FormExist("");
            if (frm == null)
            {
                frm = new frmHangHoa();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Focus();

            mnuSanPham.Enabled = false;
        }

        private void mainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuHangSanXuat_Click(object sender, EventArgs e)
        {
            frmHangSanXuat frm = (frmHangSanXuat)FormExist("");
            if (frm == null)
            {
                frm = new frmHangSanXuat();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Focus();

            mnuHangSanXuat.Enabled = false;
        }

        private void mnuHangHoaDaAn_Click(object sender, EventArgs e)
        {
            frmAnHangHoa frm = (frmAnHangHoa)FormExist("");
            if (frm == null)
            {
                frm = new frmAnHangHoa();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Focus();

            mnuHangHoaDaAn.Enabled = false;
        }

        private void mnuTKNhanVien_Click(object sender, EventArgs e)
        {
            frmQLTaiKhoanNV frm = (frmQLTaiKhoanNV)FormExist("");
            if (frm == null)
            {
                frm = new frmQLTaiKhoanNV();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Focus();

            mnuTKNhanVien.Enabled = false;
        }

        private void mnuQLNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien frm = (frmQLNhanVien)FormExist("");
            if (frm == null)
            {
                frm = new frmQLNhanVien();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Focus();

            mnuQLNhanVien.Enabled = false;
        }

        private void mnuQLKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = (frmKhachHang)FormExist("");
            if (frm == null)
            {
                frm = new frmKhachHang();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Focus();

            mnuQLKhachHang.Enabled = false;
        }

        private void mnuLapHoaDon_Click(object sender, EventArgs e)
        {
            frmLapHoaDon.m_MaNhanVien = mSNhanVien;
            frmLapHoaDon frm = (frmLapHoaDon)FormExist("");
            if (frm == null)
            {
                frm = new frmLapHoaDon();
                frm.MdiParent = this;
                frm.Show();

            }
            frm.Focus();

            mnuLapHoaDon.Enabled = false;
        }

        private void mnuTimHoaDon_Click(object sender, EventArgs e)
        {
            frmTimHoaDon frm = (frmTimHoaDon)FormExist("");
            if (frm == null)
            {
                frm = new frmTimHoaDon();
                frm.MdiParent = this;
                frm.Show();

            }
            frm.Focus();

            mnuTimHoaDon.Enabled = false;
        }
        
         private void mnuNhapHang_Click(object sender, EventArgs e)
        {
            frmPhieuNhapHang.m_MaNhanVien = mSNhanVien;
            frmPhieuNhapHang frm = (frmPhieuNhapHang)FormExist("");
            if (frm == null)
            {
                frm = new frmPhieuNhapHang();
                frm.MdiParent = this;
                frm.Show();

            }
            frm.Focus();

            mnuPhieuNhapHang.Enabled = false;
        }

        private void mnuNhapHang_Click_1(object sender, EventArgs e)
        {
            frmNhapHang.m_MaNhanVien = mSNhanVien;
            frmNhapHang frm = (frmNhapHang)FormExist("");
            if (frm == null)
            {
                frm = new frmNhapHang();
                frm.MdiParent = this;
                frm.Show();

            }
            frm.Focus();

            mnuNhapHang.Enabled = false;
        }
        #endregion


    }
}
