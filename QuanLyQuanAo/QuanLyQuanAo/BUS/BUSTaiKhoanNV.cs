using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.BUS
{
    class BUSTaiKhoanNV
    {
        #region các khai báo
        private static BUSTaiKhoanNV instance;
        #endregion

        #region các phương thức
        public static BUSTaiKhoanNV Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSTaiKhoanNV();
                }
                return instance;
            }
        }

        private BUSTaiKhoanNV()
        {

        }
        #endregion

        #region các xử lý

        public void GetNhanVien(DataGridView dgv)
        {
            dgv.DataSource = DAOTaiKhoanNV.Instance.GetNhanVien();
        }
        public void GetTaiKhoan(DataGridView dgv)
        {
            dgv.DataSource = DAOTaiKhoanNV.Instance.GetTaiKhoan();
        }
        public void GetComboBox(ComboBox cbo)
        {
            cbo.DataSource = DAOTaiKhoanNV.Instance.GetListChucVu();
        }
        public List<string> GetComboBoxQuyen()
        {
            return DAOTaiKhoanNV.Instance.GetListQuyen();
        }

        public List<string> ListTimTheoTen()
        {
            return DAOQLNhanVien.Instance.ListTimTheoTen();
        }
        public List<string> ListTimTheoMa()
        {
            return DAOQLNhanVien.Instance.ListTimTheoMa();
        }

        public void TimNhanVienTheoTen(string tenNV, DataGridView dgv)
        {
            dgv.DataSource = DAOTaiKhoanNV.Instance.TimNhanVienTheoTen(tenNV);
        }
        public void TimTaiKhoanTheoTen(string tenNV, DataGridView dgv)
        {
            dgv.DataSource = DAOTaiKhoanNV.Instance.TimTaiKhoanTheoTen(tenNV);
        }

        public void TimNhanVienTheoMa(int maNV, DataGridView dgv)
        {
            dgv.DataSource = DAOTaiKhoanNV.Instance.TimNhanVienTheoMa(maNV);
        }
        public void TimTaiKhoanTheoMa(int maNV, DataGridView dgv)
        {
            dgv.DataSource = DAOTaiKhoanNV.Instance.TimTaiKhoanTheoMa(maNV);
        }

        public void TimNhanVienTheoChucVu(string chucVu, DataGridView dgv)
        {
            dgv.DataSource = DAOTaiKhoanNV.Instance.TimNhanVienTheoChucVu(chucVu);
        }
        public void TimTaiKhoanTheoChucVu(string chucVu, DataGridView dgv)
        {
            dgv.DataSource = DAOTaiKhoanNV.Instance.TimTaiKhoanTheoChucVu(chucVu);
        }

        public void TaoTaiKhoan(int maNV, string taiKhoan,string matKhau,string quyen)
        {
            DAOTaiKhoanNV.Instance.TaoTaiKhoan(maNV, taiKhoan, matKhau, quyen);
        }

        public bool XoaTaiKhoan(int m_ID)
        {
            return DAOTaiKhoanNV.Instance.XoaTaiKhoan(m_ID);
        }
        public bool KiemTraTenDangNhap(string tenDN)
        {
            return DAOTaiKhoanNV.Instance.KiemTraTenDangNhap(tenDN);
        }
        public void SuaTK(int m_ID, int maNV,string tenDN, string m_MK, string quyen, string chuThich,bool tinhTrang)
        {
            DAOTaiKhoanNV.Instance.SuaTK(m_ID, maNV, tenDN, m_MK, quyen, chuThich, tinhTrang);
        }
        #endregion

    }
}
