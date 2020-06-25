using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        List<string> lstLoaiKH = new List<string>();
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
            GetListLoaiKH();
        }
        public List<string> GetListLoaiKH()
        {
            lstLoaiKH = DAOKhachHang.Instance.GetListLoaiKH();
            return lstLoaiKH;
        }
        #endregion

        #region các xử lý
       
        public void AddRows(DataGridView dgvHangHoa, DataGridViewComboBoxCell comboBoxCell)
        {
            dgvHangHoa.DataSource = null;
            ClassKhachHang NVNew2 = new ClassKhachHang();
            lstKhachHang.Add(NVNew2);
            dgvHangHoa.DataSource = lstKhachHang;

            comboBoxCell.DataSource = lstLoaiKH;

        }


        public void LoadComboBoxLoaiKH(DataGridViewComboBoxCell comboBoxCellHSX)
        {
            comboBoxCellHSX.DataSource = lstLoaiKH;
        }

        public void DelRow(DataGridView dgvNhanVien)
        {
            lstKhachHang.RemoveAt(lstKhachHang.Count - 1);
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = lstKhachHang;
        }



        public bool Them(int maKH,  string tenKH,DateTime ngaySinhKH,string gioiTinh,
                     string   email,string diaChi,string soDT,string loaiKH,string chuThich)
        {
            return DAOKhachHang.Instance.Them(maKH, tenKH, ngaySinhKH, gioiTinh,
                        email, diaChi, soDT, loaiKH, chuThich);
        }

        public bool Sua(int maKH, string tenKH, DateTime ngaySinhKH, string gioiTinh,
                     string email, string diaChi, string soDT, string loaiKH, string chuThich)
        {
            return DAOKhachHang.Instance.Sua(maKH, tenKH, ngaySinhKH, gioiTinh,
                        email, diaChi, soDT, loaiKH, chuThich);
        }



        public bool Xoa(int maKH)
        {

            return DAOKhachHang.Instance.Xoa(maKH);
        }

        public int TimTheoTen(string tenNV, DataGridView dgvNhanVien)
        {
            if (tenNV.Equals(""))
            {
                lstKhachHang = DAOKhachHang.Instance.GetKhachHang();
                dgvNhanVien.DataSource = lstKhachHang;
                return 0;
            }
            else
            {
                dgvNhanVien.DataSource = DAOKhachHang.Instance.TimTheoTen(tenNV);
                return 1;
            }

        }
        public int TimTheoMa(string maHH, DataGridView dgvHangHoa)
        {
            try
            {

                dgvHangHoa.DataSource = DAOKhachHang.Instance.TimTheoMa(Convert.ToInt32(maHH));
                return 1;
            }
            catch
            {
                lstKhachHang = DAOKhachHang.Instance.GetKhachHang();
                dgvHangHoa.DataSource = lstKhachHang;
                return 0;
            }
        }

        public List<string> ListTimTheoTen()
        {
            return DAOKhachHang.Instance.ListTimTheoTen();
        }
        public List<string> ListTimTheoMa()
        {
            return DAOKhachHang.Instance.ListTimTheoMa();
        }

        public void DoiAnh(int maNV, Image image)
        {
            DAOKhachHang.Instance.DoiAnh(maNV, image);
        }

        #endregion
    }
}
