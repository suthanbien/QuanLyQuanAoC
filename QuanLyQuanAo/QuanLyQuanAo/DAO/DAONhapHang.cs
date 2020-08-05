using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.DAO
{
    class DAONhapHang
    {
        #region các khai báo
        private static DAONhapHang instance;
        #endregion

        #region các phương thức
        public static DAONhapHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAONhapHang();
                }
                return instance;
            }
        }

        private DAONhapHang()
        {

        }
        #endregion

        #region các xử lý
        public List<ClassPhieuNhap> GetAllPhieuNhapChuaXN()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassPhieuNhap> lstPN = new List<ClassPhieuNhap>();
                db.DeferredLoadingEnabled = false;

                var ttPN = from h in db.PhieuNhaps
                           join n in db.NhanViens on h.NVTao equals n.MaNhanVien
                           where h.TinhTrang==true
                           select new
                           {
                               PhieuNhap = h,
                               NhanVien = n,

                           };


                foreach (var i in ttPN)
                {

                    ClassPhieuNhap phieuNhapNew = new ClassPhieuNhap();

                    phieuNhapNew.ID = i.PhieuNhap.ID;
                    phieuNhapNew.NVTao = i.NhanVien.TenNhanVien;
                    phieuNhapNew.NgayTao = i.PhieuNhap.NgayTao;
                    phieuNhapNew.NgayXacNhan = i.PhieuNhap.NgayXacNhan;
                    phieuNhapNew.TongTien = i.PhieuNhap.TongTien;
                    phieuNhapNew.GhiChu = i.PhieuNhap.GhiChu;

                    lstPN.Add(phieuNhapNew);
                }

                return lstPN;
            }
        }
        public List<ClassPhieuNhap> GetAllPhieuNhapDaXN()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassPhieuNhap> lstPN = new List<ClassPhieuNhap>();
                db.DeferredLoadingEnabled = false;

                var ttPN = from h in db.PhieuNhaps
                           join n in db.NhanViens on h.NVTao equals n.MaNhanVien 
                           join n2 in db.NhanViens on h.NVXacNhan equals n2.MaNhanVien into temp
                           from subpet in temp.DefaultIfEmpty()
                           where h.TinhTrang == false
                           select new
                           {
                               PhieuNhap = h,
                               NhanVien = n,
                               NVName = subpet.TenNhanVien==null? "": subpet.TenNhanVien

                           };


                foreach (var i in ttPN)
                {

                    ClassPhieuNhap phieuNhapNew = new ClassPhieuNhap();

                    phieuNhapNew.ID = i.PhieuNhap.ID;
                    phieuNhapNew.NVTao = i.NhanVien.TenNhanVien;
                    phieuNhapNew.NgayTao = i.PhieuNhap.NgayTao;
                    phieuNhapNew.NgayXacNhan = i.PhieuNhap.NgayXacNhan;
                    phieuNhapNew.NVXacNhan = i.NVName;
                    phieuNhapNew.TongTien = i.PhieuNhap.TongTien;
                    phieuNhapNew.GhiChu = i.PhieuNhap.GhiChu;

                    lstPN.Add(phieuNhapNew);
                }

                return lstPN;
            }
        }
        public List<NhanVien> GetNhanVien(string maNV)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<NhanVien> lstNv = new List<NhanVien>();
                lstNv = db.NhanViens.Where(p => p.MaNhanVien.Equals(maNV)).ToList();
                return lstNv;
            }
        }
        public List<ClassChiTietPhieuNhap> GetChiTietPN(int maPN)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                //  MessageBox.Show(maHDon+"");
                List<ClassChiTietPhieuNhap> lstCTPN = new List<ClassChiTietPhieuNhap>();
                db.DeferredLoadingEnabled = false;
                var ttCTPN = from c in db.ChiTietPhieuNhaps
                             join h in db.HangHoas on c.MaHH equals h.MaHangHoa
                             where c.MaPhieuNhap == maPN


                             select new
                             {
                                 ChiTietPhieuNhap = c,
                                 HangHoa = h

                             };


                foreach (var i in ttCTPN)
                {

                    ClassChiTietPhieuNhap chiTietNew = new ClassChiTietPhieuNhap();
                    chiTietNew.ID = i.ChiTietPhieuNhap.ID;
                    chiTietNew.MaPhieuNhap = i.ChiTietPhieuNhap.MaPhieuNhap;
                    chiTietNew.MaHH = i.HangHoa.MaHangHoa;
                    chiTietNew.TenHH1 = i.HangHoa.TenHangHoa;
                    chiTietNew.SoLuongCon = i.ChiTietPhieuNhap.SoLuongCon;
                    chiTietNew.SoLuongNhap = i.ChiTietPhieuNhap.SoLuongNhap;
                    chiTietNew.GiaCapNhat = i.ChiTietPhieuNhap.GiaCapNhat;
                    chiTietNew.TongTien = i.ChiTietPhieuNhap.TongTien;
                    chiTietNew.GhiChu = i.ChiTietPhieuNhap.GhiChu;
                    lstCTPN.Add(chiTietNew);
                }

                return lstCTPN;
            }
        }
        public bool SuaPhieu(int maPN, int maHH, int giaMoi, string chuThich)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                // MessageBox.Show(maNV + "");
                ChiTietPhieuNhap ctPhieuNhap = db.ChiTietPhieuNhaps.Where(p => p.MaPhieuNhap == maPN && p.MaHH==maHH).SingleOrDefault();

                if (ctPhieuNhap != null)
                    {

                        ctPhieuNhap.GiaCapNhat = giaMoi;
                        ctPhieuNhap.GhiChu = chuThich;
                         db.SubmitChanges();

                        return true;

                    }
                else
                    {
                        return false;
                    }
            }
        }
        public void CapNhatTongTienPN(int maPN, int ttMoi, string ghiChu)
        {

            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                // MessageBox.Show(maNV + "");
                PhieuNhap phieuNhap = db.PhieuNhaps.Where(p => p.ID == maPN).SingleOrDefault();

                if (phieuNhap != null)
                {

                   // MessageBox.Show(ghiChu + "");
                     phieuNhap.TongTien = ttMoi;
                     phieuNhap.GhiChu = ghiChu;
                     db.SubmitChanges();

                }
            }
        }
        public bool HuyPhieu(int maPN)
        {

            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                // MessageBox.Show(maNV + "");
                PhieuNhap phieuNhap = db.PhieuNhaps.Where(p => p.ID == maPN).SingleOrDefault();

                if (phieuNhap != null)
                {

                    // MessageBox.Show(ghiChu + "");
                    
                    phieuNhap.TinhTrang = null;
                    phieuNhap.GhiChu = "Phiếu đã hủy";
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        } 
        public bool XacNhanPhieu(int maPN, int maNV, DateTime ngayXacNhan)
        {

            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                // MessageBox.Show(maNV + "");
                PhieuNhap phieuNhap = db.PhieuNhaps.Where(p => p.ID == maPN).SingleOrDefault();

                if (phieuNhap != null)
                {

                    // MessageBox.Show(ghiChu + "");
                    phieuNhap.NVXacNhan = maNV;
                    phieuNhap.NgayXacNhan = ngayXacNhan;
                    phieuNhap.TinhTrang = false;
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public int GetSoLuong(int MaHH)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                HangHoa hangHoa = db.HangHoas.Where(p => p.MaHangHoa == MaHH).SingleOrDefault();
                return hangHoa.SoLuongCon;
            }
        }
        public void CapNhatSoLuong(int maHH, int tong,int giaMoi)
        {

            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                // MessageBox.Show(maNV + "");
                HangHoa hangHoa = db.HangHoas.Where(p => p.MaHangHoa == maHH).SingleOrDefault();

                if (hangHoa != null)
                {

                    // MessageBox.Show(ghiChu + "");
                    hangHoa.SoLuongCon = tong;
                    hangHoa.GiaNhap = giaMoi;
                    hangHoa.GiaBan = giaMoi + 50000;
                    db.SubmitChanges();

                }
            }
        }
        public List<string> ListTimTheoMa()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<string> lstManHD = new List<string>();
                var tenHH = from n in db.PhieuNhaps where n.TinhTrang!=null
                            select n.ID;
                        
                try
                {
                    foreach (int i in tenHH)
                    {
                        lstManHD.Add(i.ToString());
                       // MessageBox.Show(i.ToString());
                    }
                    return lstManHD;
                }
                catch
                {
                    return null;
                }
            }
        }
        public List<string> ListTimTheoNV()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<string> lstManHD = new List<string>();
                var tenHH = from n in db.PhieuNhaps
                            join v in db.NhanViens on n.NVTao equals v.MaNhanVien
                            where n.TinhTrang != null
                            select new
                            {
                                v.TenNhanVien

                            };

                try
                {
                    foreach (var i in tenHH)
                    {
                        lstManHD.Add(i.TenNhanVien.ToString());
                       // MessageBox.Show(i.ToString());

                    }
                    return lstManHD;
                }
                catch
                {
                    return null;
                }
            }
        }
        public List<ClassPhieuNhap> TimTheoMa(int maPN)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassPhieuNhap> lstPN = new List<ClassPhieuNhap>();
                db.DeferredLoadingEnabled = false;

                var ttPN = from h in db.PhieuNhaps
                           join n in db.NhanViens on h.NVTao equals n.MaNhanVien
                           where h.ID == maPN
                           select new
                           {
                               PhieuNhap = h,
                               NhanVien = n,

                           };


                foreach (var i in ttPN)
                {

                    ClassPhieuNhap phieuNhapNew = new ClassPhieuNhap();

                    phieuNhapNew.ID = i.PhieuNhap.ID;
                    phieuNhapNew.NVTao = i.NhanVien.TenNhanVien;
                    phieuNhapNew.NgayTao = i.PhieuNhap.NgayTao;
                    phieuNhapNew.NgayXacNhan = i.PhieuNhap.NgayXacNhan;
                    phieuNhapNew.TongTien = i.PhieuNhap.TongTien;
                    phieuNhapNew.GhiChu = i.PhieuNhap.GhiChu;
                    phieuNhapNew.TinhTrang = i.PhieuNhap.TinhTrang;
                    lstPN.Add(phieuNhapNew);
                }

                return lstPN;
            }
        }
        public List<ClassPhieuNhap> TimTheoNV(string key)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassPhieuNhap> lstPN = new List<ClassPhieuNhap>();
                db.DeferredLoadingEnabled = false;

                var ttPN = from h in db.PhieuNhaps
                           join n in db.NhanViens on h.NVTao equals n.MaNhanVien
                           where n.TenNhanVien == key
                           select new
                           {
                               PhieuNhap = h,
                               NhanVien = n,

                           };


                foreach (var i in ttPN)
                {

                    ClassPhieuNhap phieuNhapNew = new ClassPhieuNhap();

                    phieuNhapNew.ID = i.PhieuNhap.ID;
                    phieuNhapNew.NVTao = i.NhanVien.TenNhanVien;
                    phieuNhapNew.NgayTao = i.PhieuNhap.NgayTao;
                    phieuNhapNew.NgayXacNhan = i.PhieuNhap.NgayXacNhan;
                    phieuNhapNew.TongTien = i.PhieuNhap.TongTien;
                    phieuNhapNew.GhiChu = i.PhieuNhap.GhiChu;
                    phieuNhapNew.TinhTrang = i.PhieuNhap.TinhTrang;
                    lstPN.Add(phieuNhapNew);
                }

                return lstPN;
            }
        }
        #endregion

    }
}
