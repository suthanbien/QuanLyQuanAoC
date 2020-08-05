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
    class BUSTimHoaDon
    {
        #region các khai báo
        private static BUSTimHoaDon instance;
        private List<ClassHoaDon> lstHoaDon = new List<ClassHoaDon>();
        private List<ClassChiTietHoaDon> lstCTHD = new List<ClassChiTietHoaDon>();
        #endregion

        #region các phương thức
        public static BUSTimHoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSTimHoaDon();
                }
                return instance;
            }
        }

        private BUSTimHoaDon()
        {

        }
        #endregion

        #region các xử lý
        public void GetAllHoaDon(DataGridView dgv)
        {
            dgv.DataSource = null;
            lstHoaDon = DAOTimHoaDon.Instance.GetAllHoaDon();
            dgv.DataSource = lstHoaDon;
        }
        public void TimTheoMa(DataGridView dgv,int maHD)
        {
            dgv.DataSource = null;
            lstHoaDon = DAOTimHoaDon.Instance.TimTheoMa(maHD);
            dgv.DataSource = lstHoaDon;
        }
        public void TimTheoKH(DataGridView dgv, string keyTimKiem)
        {
            dgv.DataSource = null;
            lstHoaDon = DAOTimHoaDon.Instance.TimTheoKH(keyTimKiem);
            dgv.DataSource = lstHoaDon;
        }
        public void GetChiTietHD(DataGridView dgv,int maHD)
        {
            dgv.DataSource = null;
            lstCTHD = DAOTimHoaDon.Instance.GetChiTietHD(maHD);
            dgv.DataSource = lstCTHD; 
        }
        public List<string> ListTimTheoMa()
        {
            return DAOTimHoaDon.Instance.ListTimTheoMa();
        }
        public void InHoaDon(int maHD, frmPrintThongKe frm)
        {
            ClassHoaDon hoaDonNew = new ClassHoaDon();
            hoaDonNew = DAOTimHoaDon.Instance.GetHoaDonTheoMa(maHD);

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
