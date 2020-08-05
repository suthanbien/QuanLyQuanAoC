using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class DAOLapHoaDon
    {
        #region các khai báo
        private static DAOLapHoaDon instance;
        #endregion

        #region các phương thức
        public static DAOLapHoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOLapHoaDon();
                }
                return instance;
            }
        }

        private DAOLapHoaDon()
        {

        }
        #endregion

        #region các xử lý
        public List<ClassKhachHang> GetKhachHang()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassKhachHang> lstKH = new List<ClassKhachHang>();

                db.DeferredLoadingEnabled = false;
                var ttKH = from k in db.KhachHangs
                           join l in db.LoaiKhachHangs on k.LoaiKhachHang equals l.MaLoaiKhachHang

                           select new
                           {
                               KhachHang = k,
                               LoaiKhachHang = l
                           };

                foreach (var i in ttKH)
                {
                    //  MessageBox.Show(""+i);
                    ClassKhachHang KHNew = new ClassKhachHang();
                    KHNew.MaKhachHang = i.KhachHang.MaKhachHang;
                    KHNew.TenKhachHang = i.KhachHang.TenKhachHang;
                    KHNew.Email = i.KhachHang.Email;
                    KHNew.DiaChi = i.KhachHang.DiaChi;
                    KHNew.SDT = i.KhachHang.SDT;
                    KHNew.LoaiKhachHang = i.LoaiKhachHang.TenLoaiKhachHang;
                    KHNew.GhiChu = i.LoaiKhachHang.HeSoGiam.ToString();
                    lstKH.Add(KHNew);
                }
                return lstKH;
            }
        }
        public List<NhanVien> GetNhanVien(string maNV)
        {
            using (CSDLQuanLyQuanAoDataContext db =new CSDLQuanLyQuanAoDataContext())
            {
                List<NhanVien> lstNv = new List<NhanVien>();
                lstNv = db.NhanViens.Where(p => p.MaNhanVien.Equals(maNV)).ToList();
                return lstNv;
            }
        }
        public List<ClassHangHoa> GetHangHoa()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassHangHoa> lstHH = new List<ClassHangHoa>();

                db.DeferredLoadingEnabled = false;
                var ttHH = from n in db.HangHoas
                           join u in db.HangSanXuats on n.MaHangSanXuat equals u.MaHangSanXuat
                           join l in db.LoaiSanPhams on n.MaLoaiHangHoa equals l.MaLoaiSanPham
                           where n.TrangThai == true
                           select new
                           {
                               n.MaHangHoa,
                               n.TenHangHoa,
                               n.GiaNhap,
                               n.GiaBan,
                               n.SoLuongCon,
                               n.TrangThai,
                               n.ChuThich,
                               n.Image,
                               u.TenHangSanXuat,
                               l.TenLoaiSanPham
                           };

                foreach (var i in ttHH)
                {
                    ClassHangHoa HHNew = new ClassHangHoa();
                    HHNew.MaHangHoa = i.MaHangHoa;
                    HHNew.TenHangHoa = i.TenHangHoa;
                    HHNew.LoaiHangHoa = i.TenLoaiSanPham;
                    HHNew.HangSanXuat = i.TenHangSanXuat;
                    HHNew.GiaNhap = i.GiaNhap;
                    HHNew.GiaBan = i.GiaBan;
                    HHNew.SoLuongCon = i.SoLuongCon;
                    HHNew.TrangThai = i.TrangThai;
                    HHNew.ChuThich = i.ChuThich;

                    lstHH.Add(HHNew);
                }
                return lstHH;
            }
        }
        public int SuDungMaGiamGia(string maGiamGia)
        {
            using (CSDLQuanLyQuanAoDataContext db= new CSDLQuanLyQuanAoDataContext())
            {
                MaGiamGia getMaGiamGia = db.MaGiamGias.Where(p => p.MaGiamGia1.Equals(maGiamGia)).SingleOrDefault();
                if (getMaGiamGia!=null)
                {
                    return getMaGiamGia.HeSoGiam;
                }
                else{
                    return -1;
                }
               
            }
        }
        public int LapHoaDon(int maKH, int maNV, int TongTien, DateTime ngayLapHD, string ghiChuHD)
        {
            using (CSDLQuanLyQuanAoDataContext db=new CSDLQuanLyQuanAoDataContext())
            {
                HoaDon hoaDonNew = new HoaDon();
                hoaDonNew.MaKhachHang = maKH;
                hoaDonNew.MaNhanVien = maNV;
                hoaDonNew.TongTien = TongTien;
                hoaDonNew.NgayLapHoaDon = ngayLapHD;
                hoaDonNew.GhiChu = ghiChuHD;

                db.HoaDons.InsertOnSubmit(hoaDonNew);
                db.SubmitChanges();
                return hoaDonNew.MaHoaDon;
            }
        }
        public void LapChiTietHoaDon(int maHD,int maHangHoa, int soLuongMua, int tTien, string ghiChu)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                ChiTietHoaDon chiTietNew = new ChiTietHoaDon();
                chiTietNew.MaHoaDon = maHD;
                chiTietNew.MaHangHoa = maHangHoa;
                chiTietNew.SoLuong = soLuongMua;
                chiTietNew.TongTien = tTien;
                chiTietNew.GhiChu = ghiChu;

                db.ChiTietHoaDons.InsertOnSubmit(chiTietNew);
                db.SubmitChanges();

            }
        }

        #endregion
    }
}
