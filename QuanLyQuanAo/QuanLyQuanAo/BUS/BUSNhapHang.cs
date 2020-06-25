using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.BUS
{
    class BUSNhapHang
    {
        #region các khai báo
        private static BUSNhapHang instance;
        List<ClassPhieuNhap> lstPhieuNhap = new List<ClassPhieuNhap>();
        List<ClassPhieuNhap> lstPhieuNhap2 = new List<ClassPhieuNhap>();
        List<ClassPhieuNhap> lstPhieuNhapTong = new List<ClassPhieuNhap>();
        List<ClassChiTietPhieuNhap> lstChiTiet = new List<ClassChiTietPhieuNhap>();
        #endregion

        #region các phương thức
        public static BUSNhapHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSNhapHang();
                }
                return instance;
            }
        }

        private BUSNhapHang()
        {

        }

        public int TongTien()
        {
            if (lstChiTiet.Count > 0)
            {
                int tong = 0;
                for (int i = 0; i < lstChiTiet.Count; i++)
                {
                    int gia = lstChiTiet[i].TongTien;
                    tong = tong + gia;
                }

                return tong;
            }
            else
            {
                return 0;
            }

        }
        #endregion

        #region các xử lý

        public void GetAllPhieuNhapChuaXN(DataGridView dgv)
        {
           
            dgv.DataSource = null;
            lstPhieuNhap = DAONhapHang.Instance.GetAllPhieuNhapChuaXN();
            dgv.DataSource = lstPhieuNhap;
        }
        public void GetAllPhieuNhapDaXN(DataGridView dgv)
        {

            dgv.DataSource = null;
            lstPhieuNhap2 = DAONhapHang.Instance.GetAllPhieuNhapDaXN();
            dgv.DataSource = lstPhieuNhap2;
        }
        public void GetNhanVien(string maNV, TextBox txtMaNV, TextBox txtTenNV)
        {
            txtMaNV.Text = DAONhapHang.Instance.GetNhanVien(maNV)[0].MaNhanVien.ToString();
            txtTenNV.Text = DAONhapHang.Instance.GetNhanVien(maNV)[0].TenNhanVien.ToString();
        }
        public void GetChiTietPN(DataGridView dgv, int maHD)
        {
            dgv.DataSource = null;
            lstChiTiet= DAONhapHang.Instance.GetChiTietPN(maHD);
            dgv.DataSource = lstChiTiet;
        }
        public void ResetChiTiet(DataGridView dgv)
        {
            dgv.DataSource = null;
            lstChiTiet.Clear();
            dgv.DataSource = lstChiTiet;
        }
        public bool SuaPhieu(int maPN, int maHH, int giaMoi, string chuThich)
        {

            return DAONhapHang.Instance.SuaPhieu(maPN, maHH, giaMoi, chuThich);
        }
        public void CapNhatTongTienPN(int maPN, int ttMoi, string ghiChu)
        {

            DAONhapHang.Instance.CapNhatTongTienPN(maPN, ttMoi, ghiChu);
        }
        public bool XacNhanPhieu(int maPN,int maNV,DateTime ngayXacNhan)
        {
            for (int i=0;i<lstChiTiet.Count;i++)
            {
                int maHH = lstChiTiet[i].MaHH;
                int soLuongNhap = lstChiTiet[i].SoLuongNhap;
                int soLuongMoi = DAONhapHang.Instance.GetSoLuong(maHH);
                int giaBan = lstChiTiet[i].GiaCapNhat;
                int tong = soLuongMoi + soLuongNhap;
                DAONhapHang.Instance.CapNhatSoLuong(maHH, tong,giaBan);
            }
            return DAONhapHang.Instance.XacNhanPhieu(maPN, maNV, ngayXacNhan);
        }
        public bool HuyPhieu(int maPN)
        {

            return DAONhapHang.Instance.HuyPhieu(maPN);
        }
        public List<string> ListTimTheoMa()
        {
            return DAONhapHang.Instance.ListTimTheoMa();
        }
        public List<string> ListTimTheoNV()
        {
            return DAONhapHang.Instance.ListTimTheoNV();
        }
        public void TimTheoMa(DataGridView dgv, DataGridView dgv2, int maHD)
        {
            dgv.DataSource = null;
            dgv2.DataSource = null;

            lstPhieuNhap.Clear();
            lstPhieuNhap2.Clear();
            lstPhieuNhapTong = DAONhapHang.Instance.TimTheoMa(maHD);
            for (int i=0;i< lstPhieuNhapTong.Count;i++)
            {
                if (lstPhieuNhapTong[i].TinhTrang==true)
                {
                    lstPhieuNhap.Add(lstPhieuNhapTong[i]);
                }else if (lstPhieuNhapTong[i].TinhTrang == false)
                {
                    lstPhieuNhap2.Add(lstPhieuNhapTong[i]);
                }
            }
            
            dgv.DataSource = lstPhieuNhap;
            dgv2.DataSource = lstPhieuNhap2;
        }
        public void TimTheoNV(DataGridView dgv, DataGridView dgv2, string keyTim)
        {
            dgv.DataSource = null;
            dgv2.DataSource = null;

            lstPhieuNhap.Clear();
            lstPhieuNhap2.Clear();

            lstPhieuNhapTong = DAONhapHang.Instance.TimTheoNV(keyTim);
            for (int i=0;i< lstPhieuNhapTong.Count;i++)
            {
                if (lstPhieuNhapTong[i].TinhTrang==true)
                {
                    lstPhieuNhap.Add(lstPhieuNhapTong[i]);
                }else if (lstPhieuNhapTong[i].TinhTrang == false)
                {
                    lstPhieuNhap2.Add(lstPhieuNhapTong[i]);
                }
            }
            
            dgv.DataSource = lstPhieuNhap;
            dgv2.DataSource = lstPhieuNhap2;
        }
        #endregion

    }
}
