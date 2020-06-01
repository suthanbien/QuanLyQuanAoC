using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.BUS
{
    class BUSPhieuNhap
    {
        #region các khai báo
        private static BUSPhieuNhap instance;
        List<ClassHangHoa> lstHangHoa = new List<ClassHangHoa>();
        List<string> lstLoaiHangHoa = new List<string>();
        List<ClassHangHoa> lstHangHoaTheoLoai;
        #endregion

        #region các phương thức
        public static BUSPhieuNhap Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSPhieuNhap();
                }
                return instance;
            }
        }

        private BUSPhieuNhap()
        {

        }
        public List<string> GetListLoaiHH()
        {
            lstLoaiHangHoa = DAOHangHoa.Instance.GetListLoaiHangHoa();
            return lstLoaiHangHoa;
        }
        #endregion

        #region các xử lý
        public void GetHangHoa(DataGridView dgvHangHoa)
        {
            lstHangHoa = DAOPhieuNhap.Instance.GetHangHoa();
            dgvHangHoa.DataSource = lstHangHoa;
            GetListLoaiHH();
        }
        public void GetHangHoaTheoLoai(string loaiHH, DataGridView dgvHangHoa)
        {
            lstHangHoaTheoLoai = new List<ClassHangHoa>();
            if (loaiHH.Equals("Tất Cả"))
            {
                lstHangHoaTheoLoai = lstHangHoa;
            }
            else
            {
                for (int i = 0; i < lstHangHoa.Count; i++)
                {
                    if (lstHangHoa[i].LoaiHangHoa.Equals(loaiHH))
                    {
                        lstHangHoaTheoLoai.Add(lstHangHoa[i]);
                    }
                }
            }

            dgvHangHoa.DataSource = lstHangHoaTheoLoai;
        }
        public void GetNhanVien(string maNV, TextBox txtMaNV, TextBox txtTenNV)
        {
            txtMaNV.Text = DAOPhieuNhap.Instance.GetNhanVien(maNV)[0].MaNhanVien.ToString();
            txtTenNV.Text = DAOPhieuNhap.Instance.GetNhanVien(maNV)[0].TenNhanVien.ToString();
        }
        #endregion
    }
}
