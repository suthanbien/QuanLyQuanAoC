using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.DAO
{
    class DAOHangHoa
    {
        #region các khai báo
        private static DAOHangHoa instance;
        private List<ClassHangHoa> classHH = new List<ClassHangHoa>();
        #endregion

        #region các phương thức
        public static DAOHangHoa Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOHangHoa();
                }
                return instance;
            }
        }

        private DAOHangHoa()
        {

        }
        private int GetMaLoaiHH(string tenLHP)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                LoaiSanPham lsp = db.LoaiSanPhams.Where(p => p.TenLoaiSanPham.Equals(tenLHP)).SingleOrDefault();

                // MessageBox.Show(lsp.MaLoaiSanPham + "");
                return lsp.MaLoaiSanPham;

            }
        }
        private int GetMaHangSanXuat(string tenHSX)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                HangSanXuat lsp = db.HangSanXuats.Where(p => p.TenHangSanXuat.Equals(tenHSX)).SingleOrDefault();

                // MessageBox.Show(lsp.MaLoaiSanPham + "");
                return lsp.MaHangSanXuat;

            }
        }
        private byte[] ImageToByteArray(Image anhHH)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                anhHH.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        #endregion

        #region các xử lý
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
                    if (i.Image != null)
                    {
                        HHNew.Image = ByteArrayToImage(i.Image.ToArray());
                    }
                    lstHH.Add(HHNew);
                }
                classHH = lstHH;
                return lstHH;
            }
        }

        public Image ByteArrayToImage(byte[] arr)
        {
            using (MemoryStream ms = new MemoryStream(arr))
            {
                Image resurtImage = Image.FromStream(ms);
                return resurtImage;
            }
        }


        public List<string> GetListHangSanXuat()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<string> lstHH = new List<string>();
                lstHH = db.HangSanXuats.Select(p => p.TenHangSanXuat).ToList();

                return lstHH;
            }
        }
        public List<string> GetListLoaiHangHoa()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<string> lstLHH = new List<string>();
                lstLHH = db.LoaiSanPhams.Select(p => p.TenLoaiSanPham).ToList();

                return lstLHH;
            }
        }



        public void Them(int maHangHoa, string tenHangHoa, string loaiHangHoa, string hangSanXuat, int giaNhap, int giaBan, int soLuongCon, bool trangThai, string chuThich)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                int maLoaiHH = GetMaLoaiHH(loaiHangHoa);
                int maHangSX = GetMaHangSanXuat(hangSanXuat);
                HangHoa hangHoaNew = new HangHoa();
                hangHoaNew.MaHangHoa = maHangHoa;
                hangHoaNew.TenHangHoa = tenHangHoa;
                hangHoaNew.MaLoaiHangHoa = maLoaiHH;
                hangHoaNew.MaHangSanXuat = maHangSX;
                hangHoaNew.GiaNhap = giaNhap;
                hangHoaNew.GiaBan = giaBan;
                hangHoaNew.SoLuongCon = soLuongCon;
                hangHoaNew.TrangThai = trangThai;
                hangHoaNew.ChuThich = chuThich;
                hangHoaNew.Image = null;
                db.HangHoas.InsertOnSubmit(hangHoaNew);
                db.SubmitChanges();
            }
        }

        public void Sua(int maHangHoa, string tenHangHoa, string loaiHangHoa, string hangSanXuat, int giaNhap, int giaBan, int soLuongCon, bool trangThai, string chuThich)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                HangHoa hangHoa = db.HangHoas.Where(p => p.MaHangHoa == maHangHoa).SingleOrDefault();
                int maLoaiHH = GetMaLoaiHH(loaiHangHoa);
                int maHangSX = GetMaHangSanXuat(hangSanXuat);
                if (hangHoa != null)
                {
                    // hangHoa.MaHangHoa = maHangHoa;
                    hangHoa.TenHangHoa = tenHangHoa;
                    hangHoa.MaLoaiHangHoa = maLoaiHH;
                    hangHoa.MaHangSanXuat = maHangSX;
                    hangHoa.GiaNhap = giaNhap;
                    hangHoa.GiaBan = giaBan;
                    hangHoa.SoLuongCon = soLuongCon;
                    hangHoa.TrangThai = trangThai;
                    hangHoa.ChuThich = chuThich;
                    // hangHoa.Image = null;

                    db.SubmitChanges();

                }

            }
        }

        public bool Xoa(int maHH)
        {
            try
            {
                using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
                {
                    HangHoa delHH = db.HangHoas.Where(p => p.MaHangHoa == maHH).SingleOrDefault();
                    db.HangHoas.DeleteOnSubmit(delHH);
                    db.SubmitChanges();

                    return true;
                }
            }
            catch
            {

                return false;
            }

        }

        public List<ClassHangHoa> TimTheoTen(string tenHH)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassHangHoa> lstHH = new List<ClassHangHoa>();

                db.DeferredLoadingEnabled = false;
                var ttHH = from n in db.HangHoas
                           join u in db.HangSanXuats on n.MaHangSanXuat equals u.MaHangSanXuat
                           join l in db.LoaiSanPhams on n.MaLoaiHangHoa equals l.MaLoaiSanPham
                           where n.TenHangHoa == tenHH
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
                    if (i.Image != null)
                    {
                        HHNew.Image = ByteArrayToImage(i.Image.ToArray());
                    }
                    lstHH.Add(HHNew);
                }
                classHH = lstHH;
                return lstHH;
            }
        }

        public List<ClassHangHoa> TimTheoMa(int maHH)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassHangHoa> lstHH = new List<ClassHangHoa>();

                db.DeferredLoadingEnabled = false;
                var ttHH = from n in db.HangHoas
                           join u in db.HangSanXuats on n.MaHangSanXuat equals u.MaHangSanXuat
                           join l in db.LoaiSanPhams on n.MaLoaiHangHoa equals l.MaLoaiSanPham
                           where n.MaHangHoa == maHH
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
                    if (i.Image != null)
                    {
                        HHNew.Image = ByteArrayToImage(i.Image.ToArray());
                    }
                    lstHH.Add(HHNew);
                }
                classHH = lstHH;
                return lstHH;
            }
        }
        public List<ClassHangHoa> TimTheoLoaiHH(string tenLHH)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassHangHoa> lstHH = new List<ClassHangHoa>();

                db.DeferredLoadingEnabled = false;
                var ttHH = from n in db.HangHoas
                           join u in db.HangSanXuats on n.MaHangSanXuat equals u.MaHangSanXuat
                           join l in db.LoaiSanPhams on n.MaLoaiHangHoa equals l.MaLoaiSanPham
                           where l.TenLoaiSanPham == tenLHH
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
                    if (i.Image != null)
                    {
                        HHNew.Image = ByteArrayToImage(i.Image.ToArray());
                    }
                    lstHH.Add(HHNew);
                }
                classHH = lstHH;
                return lstHH;
            }
        }

        public List<string> ListTimTheoTen()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<string> lstTenHH = new List<string>();
                var tenHH = from n in db.HangHoas
                            select n.TenHangHoa;
                try
                {
                    foreach (string i in tenHH)
                    {
                        lstTenHH.Add(i);
                    }
                    return lstTenHH;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<string> ListTimTheoMa()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<string> lstManHH = new List<string>();
                var tenHH = from n in db.HangHoas
                            select n.MaHangHoa;
                try
                {
                    foreach (int i in tenHH)
                    {
                        lstManHH.Add(i.ToString());
                    }
                    return lstManHH;
                }
                catch
                {
                    return null;
                }
            }
        }

        public void DoiAnh(int MaHH, Image image)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                HangHoa hangHoa = db.HangHoas.Where(p => p.MaHangHoa == MaHH).SingleOrDefault();
                byte[] fileAnh = ImageToByteArray(image);

                if (hangHoa != null)
                {

                    hangHoa.Image = fileAnh;

                    db.SubmitChanges();

                }
            }

            #endregion
        }
    }
}
