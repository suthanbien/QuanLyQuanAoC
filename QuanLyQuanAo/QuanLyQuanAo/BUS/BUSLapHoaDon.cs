using QuanLyQuanAo.DAO;
using QuanLyQuanAo.GUI;
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
        List<ClassChiTietHoaDon> lstCTHDPrint = new List<ClassChiTietHoaDon>();
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
            lstCTHDPrint = lstCTHD;
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
            lstCTHDPrint = lstCTHD;
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

        public void InHoaDon(int maHD,  frmPrintThongKe frm)
        {
            ClassHoaDon hoaDonNew = new ClassHoaDon();
            List<ClassChiTietHoaDon> lstCTHD = new List<ClassChiTietHoaDon>();
            hoaDonNew = DAOLapHoaDon.Instance.GetHoaDonTheoMa(maHD);
            lstCTHD= DAOLapHoaDon.Instance.GetChiTietHD(maHD);

            frmPrintThongKe.mauIn = 1;
            frmPrintThongKe.maHD = hoaDonNew.MaHoaDon.ToString();
            frmPrintThongKe.maNV = hoaDonNew.MaNhanVien.ToString();
            frmPrintThongKe.tenNV = hoaDonNew.TenNhanVien.ToString();
            frmPrintThongKe.ngayBan = hoaDonNew.NgayLapHoaDon.ToString();
            frmPrintThongKe.maKH = hoaDonNew.MaKhachHang.ToString();
            frmPrintThongKe.tenKH = hoaDonNew.TenKhachHang.ToString();
            frmPrintThongKe.diaChiKH = hoaDonNew.DiaChi.ToString();
            frmPrintThongKe.dienThoai = hoaDonNew.DienThoai.ToString();
            frmPrintThongKe.loaiKH = hoaDonNew.LoaiKH.ToString();
            //frmPrintThongKe.tongTien = hoaDonNew.TongTien.ToString(); 
            frmPrintThongKe.ghiChu = hoaDonNew.GhiChu.ToString();
            frmPrintThongKe.conLai = hoaDonNew.TongTien.ToString();
            frmPrintThongKe.lstChiTietHoaDon = lstCTHD;

            frm.ShowDialog();
        }


        #endregion
    }
}
