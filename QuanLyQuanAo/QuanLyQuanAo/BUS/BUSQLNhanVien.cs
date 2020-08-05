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
    class BUSQLNhanVien
    {
        #region các khai báo
        private static BUSQLNhanVien instance;
        List<ClassNhanVien> lstNhanVien = new List<ClassNhanVien>();
        List<string> lstChucVu = new List<string>();
        #endregion

        #region các phương thức
        public static BUSQLNhanVien Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSQLNhanVien();
                }
                return instance;
            }
        }

        private BUSQLNhanVien()
        {

        }

        public List<string> GetListChucVu()
        {
            lstChucVu = DAOQLNhanVien.Instance.GetListChucVu();
            return lstChucVu;
        }
        #endregion

        #region các xử lý
        public void GetNhanVien(DataGridView dgvHangHoa)
        {
            lstNhanVien = DAOQLNhanVien.Instance.GetNhanVien();
            dgvHangHoa.DataSource = lstNhanVien;
            GetListChucVu();
        }

        public void AddRows(DataGridView dgvHangHoa, DataGridViewComboBoxCell comboBoxCell)
        {
            dgvHangHoa.DataSource = null;
            ClassNhanVien NVNew2 = new ClassNhanVien();
            lstNhanVien.Add(NVNew2);
            dgvHangHoa.DataSource = lstNhanVien;

            comboBoxCell.DataSource = lstChucVu;

        }


        public void LoadComboBoxChucVu(DataGridViewComboBoxCell comboBoxCellHSX)
        {
            comboBoxCellHSX.DataSource = lstChucVu;
        }

        public void DelRow(DataGridView dgvNhanVien)
        {
            lstNhanVien.RemoveAt(lstNhanVien.Count - 1);
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = lstNhanVien;
        }



        public bool Them(int maNV,string tenNV,string chucVu,DateTime ngaySinh,string gioiTinh,int cmnd,
                           string email, DateTime ngayVaoLam, DateTime? ngayNghiLam,string diaChi,string soDT,Boolean tinhTrang,string chuThich)
        {
           return DAOQLNhanVien.Instance.Them(maNV, tenNV, chucVu, ngaySinh, gioiTinh, cmnd,
                            email, ngayVaoLam, ngayNghiLam, diaChi, soDT, tinhTrang, chuThich);
        } 
        
        public bool Sua(int maNV,string tenNV,string chucVu,DateTime ngaySinh,string gioiTinh,int cmnd,
                           string email, DateTime ngayVaoLam, DateTime? ngayNghiLam,string diaChi,string soDT,Boolean tinhTrang,string chuThich)
        {
          return  DAOQLNhanVien.Instance.Sua(maNV, tenNV, chucVu, ngaySinh, gioiTinh, cmnd,
                            email, ngayVaoLam, ngayNghiLam, diaChi, soDT, tinhTrang, chuThich);
        }



        public bool Xoa(int maNV)
        {

            return DAOQLNhanVien.Instance.Xoa(maNV);
        }

        public int TimTheoTen(string tenNV, DataGridView dgvNhanVien)
        {
            if (tenNV.Equals(""))
            {
                lstNhanVien = DAOQLNhanVien.Instance.GetNhanVien();
                dgvNhanVien.DataSource = lstNhanVien;
                return 0;
            }
            else
            {
                dgvNhanVien.DataSource = DAOQLNhanVien.Instance.TimTheoTen(tenNV);
                return 1;
            }

        }
        public int TimTheoMa(string maHH, DataGridView dgvHangHoa)
        {
            try
            {

                dgvHangHoa.DataSource = DAOQLNhanVien.Instance.TimTheoMa(Convert.ToInt32(maHH));
                return 1;
            }
            catch
            {
                lstNhanVien = DAOQLNhanVien.Instance.GetNhanVien();
                dgvHangHoa.DataSource = lstNhanVien;
                return 0;
            }
        }

        public List<string> ListTimTheoTen()
        {
            return DAOQLNhanVien.Instance.ListTimTheoTen();
        }
        public List<string> ListTimTheoMa()
        {
            return DAOQLNhanVien.Instance.ListTimTheoMa();
        }

        public void DoiAnh(int maNV, Image image)
        {
            DAOQLNhanVien.Instance.DoiAnh(maNV, image);
        }

        #endregion
    }
}
