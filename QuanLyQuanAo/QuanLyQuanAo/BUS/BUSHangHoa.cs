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
    class BUSHangHoa
    {
        #region các khai báo
        private static BUSHangHoa instance;
        List<ClassHangHoa> lstHangHoa = new List<ClassHangHoa>();
        List<string> lstNhaSanXuat = new List<string>();
        List<string> lstLoaiHangHoa = new List<string>();
        #endregion

        #region các phương thức
        public static BUSHangHoa Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSHangHoa();
                }
                return instance;
            }
        }

        private BUSHangHoa()
        {

        }
        public List<string> GetListHangSX()
        {
            lstNhaSanXuat = DAOHangHoa.Instance.GetListHangSanXuat();
            return lstNhaSanXuat;
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
            lstHangHoa = DAOHangHoa.Instance.GetHangHoa();
            dgvHangHoa.DataSource = lstHangHoa;
            GetListHangSX();
            GetListLoaiHH();
        }

        public void AddRows(DataGridView dgvHangHoa, DataGridViewComboBoxCell comboBoxCell, DataGridViewComboBoxCell comboBoxCell2)
        {
            dgvHangHoa.DataSource = null;
            ClassHangHoa HHNew2 = new ClassHangHoa();
            lstHangHoa.Add(HHNew2);
            dgvHangHoa.DataSource = lstHangHoa;
            
            comboBoxCell.DataSource = lstNhaSanXuat;   

            comboBoxCell2.DataSource = lstLoaiHangHoa;
        }

        public void LoadComboBoxLoaiHH( DataGridViewComboBoxCell comboBoxCellLoaiHH)
        {
            comboBoxCellLoaiHH.DataSource = lstLoaiHangHoa;
        }
        public void LoadComboBoxTenHSX( DataGridViewComboBoxCell comboBoxCellHSX)
        {
            comboBoxCellHSX.DataSource = lstNhaSanXuat;
        }

        public void DelRow(DataGridView dgvHangHoa)
        {
            lstHangHoa.RemoveAt(lstHangHoa.Count-1);
            dgvHangHoa.DataSource = null;
            dgvHangHoa.DataSource = lstHangHoa;
        }

        
 
        public void Them(int maHangHoa, string tenHangHoa, string loaiHangHoa, string hangSanXuat, int giaNhap, int giaBan, int soLuongCon, bool trangThai, string chuThich)
        {
            DAOHangHoa.Instance.Them( maHangHoa,  tenHangHoa,  loaiHangHoa,  hangSanXuat,  giaNhap,  giaBan,  soLuongCon,  trangThai,   chuThich);
        }

        public void Sua(int maHangHoa, string tenHangHoa, string loaiHangHoa, string hangSanXuat, int giaNhap, int giaBan, int soLuongCon, bool trangThai, string chuThich)
        {

            DAOHangHoa.Instance.Sua(maHangHoa, tenHangHoa, loaiHangHoa, hangSanXuat, giaNhap, giaBan, soLuongCon, trangThai, chuThich);
        }

        public bool Xoa(int maHH)
        {

            return DAOHangHoa.Instance.Xoa(maHH);
        }

        public int TimTheoTen(string tenHH, DataGridView dgvHangHoa)
        {
            if (tenHH.Equals(""))
            {
                lstHangHoa = DAOHangHoa.Instance.GetHangHoa();
                dgvHangHoa.DataSource = lstHangHoa;
                return 0;
            }
            else
            {
                dgvHangHoa.DataSource = DAOHangHoa.Instance.TimTheoTen(tenHH);
                return 1;
            }

        }
        public void TimTheoLoaiHH(string tenLHH, DataGridView dgvHangHoa)
        {
            try
            {
                dgvHangHoa.DataSource = DAOHangHoa.Instance.TimTheoLoaiHH(tenLHH);
            }
            catch
            {
                lstHangHoa = DAOHangHoa.Instance.GetHangHoa();
                dgvHangHoa.DataSource = lstHangHoa;
            }
        }public int TimTheoMa(string maHH, DataGridView dgvHangHoa)
        {
            try
            {

                dgvHangHoa.DataSource = DAOHangHoa.Instance.TimTheoMa(Convert.ToInt32(maHH));
                return 1;
            }
            catch
            {
                lstHangHoa = DAOHangHoa.Instance.GetHangHoa();
                dgvHangHoa.DataSource = lstHangHoa;
                return 0;
            }
        }

        public List<string> ListTimTheoTen()
        {
            return DAOHangHoa.Instance.ListTimTheoTen();
        }
        public List<string> ListTimTheoMa()
        {
            return DAOHangHoa.Instance.ListTimTheoMa();
        }

        public void DoiAnh(int maHH,Image image)
        {
            DAOHangHoa.Instance.DoiAnh(maHH, image);
        }

        #endregion
    }
}
