using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.BUS
{
    class BUSLapHoaDon
    {
        #region các khai báo
        private static BUSLapHoaDon instance;
        List<ClassKhachHang> lstKH = new List<ClassKhachHang>();
        List<ClassChiTietHoaDon> lstCTHD = new List<ClassChiTietHoaDon>();
        List<ClassHangHoa> lstHangHoa = new List<ClassHangHoa>();
        ClassHangHoa hangHoaChon;
        #endregion

        #region các phương thức
        public static BUSLapHoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSLapHoaDon();
                }
                return instance;
            }
        }

        private BUSLapHoaDon()
        {

        }
        public List<ClassHangHoa> GetListHangHoa()
        {
            lstHangHoa = DAOLapHoaDon.Instance.GetHangHoa();
            return lstHangHoa;
        }
        #endregion

        #region các xử lý
        public void GetKhachHang(ComboBox cbo,TextBox txtTenKH, TextBox txtDiaChi, TextBox txtSDT, TextBox txtLoaiKH,TextBox txtLoaiGiamGia)
        {
            lstKH = DAOLapHoaDon.Instance.GetKhachHang();
           
            cbo.DataSource = lstKH;
            cbo.DisplayMember = "MaKhachHang";
            cbo.ValueMember = "MaKhachHang";
            cbo.Text = "32";
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("text", lstKH, "TenKhachHang");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("text", lstKH, "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("text", lstKH, "SDT");
            txtLoaiKH.DataBindings.Clear();
            txtLoaiKH.DataBindings.Add("text", lstKH, "LoaiKhachHang");
            txtLoaiGiamGia.DataBindings.Clear();
            txtLoaiGiamGia.DataBindings.Add("text", lstKH, "GhiChu");

        }
        public void GetNhanVien(string maNV,TextBox txtMaNV,TextBox txtTenNV)
        {
            txtMaNV.Text = DAOLapHoaDon.Instance.GetNhanVien(maNV)[0].MaNhanVien.ToString();
            txtTenNV.Text = DAOLapHoaDon.Instance.GetNhanVien(maNV)[0].TenNhanVien.ToString();
        }

        public void ThemChiTiet(DataGridView dgv)
        {
            dgv.DataSource = null;
            ClassChiTietHoaDon chiTietNew = new ClassChiTietHoaDon();
            lstCTHD.Add(chiTietNew);
            dgv.DataSource = lstCTHD;
        }
        public void SuDungMaGiamGia(string maGiamGia,Label lblHeSoGiam,Label lblThongBaoGG)
        {
            int m_MaGiamGia=DAOLapHoaDon.Instance.SuDungMaGiamGia(maGiamGia) ;
           if (m_MaGiamGia!=-1)
            {
                lblHeSoGiam.Text = m_MaGiamGia.ToString();
                lblThongBaoGG.Text = "%";
            }
            else
            {
                lblHeSoGiam.Text = "";
                lblThongBaoGG.Text = "Mã giảm giá không hợp lệ";
            }
        }
        public void RemoveAt(int position, DataGridView dgv)
        {
            dgv.DataSource = null;
            lstCTHD.RemoveAt(position);
            dgv.DataSource = lstCTHD;
        }
        public void HuyHoaDon(DataGridView dgv)
        {
            dgv.DataSource = null;
            lstCTHD.Clear();
            dgv.DataSource = lstCTHD;
        }
        public int LapHoaDon(int maKH, int maNV,int  TongTien, DateTime ngayLapHD,string ghiChuHD)
        {
           return  DAOLapHoaDon.Instance.LapHoaDon(maKH, maNV, TongTien, ngayLapHD, ghiChuHD);
        }
        public void LapChiTietHoaDon(int maHD,int maHangHoa, int soLuongMua, int tTien, string ghiChu)
        {
            DAOLapHoaDon.Instance.LapChiTietHoaDon(maHD, maHangHoa, soLuongMua, tTien, ghiChu);
        }
        #endregion
    }
}
