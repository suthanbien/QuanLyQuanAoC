﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class DAOPhieuNhap
    {
        #region các khai báo
        private static DAOPhieuNhap instance;
        #endregion

        #region các phương thức
        public static DAOPhieuNhap Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOPhieuNhap();
                }
                return instance;
            }
        }

        private DAOPhieuNhap()
        {

        }
        private byte[] ImageToByteArray(Image anhHH)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                anhHH.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
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
                     //   HHNew.Image = ByteArrayToImage(i.Image.ToArray());
                    }
                    lstHH.Add(HHNew);
                }
                return lstHH;
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
                     //   HHNew.Image = ByteArrayToImage(i.Image.ToArray());
                    }
                    lstHH.Add(HHNew);
                }
                return lstHH;
            }
        }

        public List<ClassHangHoa> TimTheoSL(int SL)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassHangHoa> lstHH = new List<ClassHangHoa>();

                db.DeferredLoadingEnabled = false;
                var ttHH = from n in db.HangHoas
                           join u in db.HangSanXuats on n.MaHangSanXuat equals u.MaHangSanXuat
                           join l in db.LoaiSanPhams on n.MaLoaiHangHoa equals l.MaLoaiSanPham
                          
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
                    if (i.SoLuongCon<=SL )
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
                            //   HHNew.Image = ByteArrayToImage(i.Image.ToArray());
                        }
                        lstHH.Add(HHNew);
                    }
                    
                }
                return lstHH;
            }
        }

        public int LapPhieu(int maNV, int TongTien, DateTime ngayLapPhieu)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                PhieuNhap phieuNhapNew = new PhieuNhap();
                phieuNhapNew.NVTao = maNV;
                phieuNhapNew.NgayTao = ngayLapPhieu;
                phieuNhapNew.TinhTrang = true;
                phieuNhapNew.TongTien = TongTien;
               

                db.PhieuNhaps.InsertOnSubmit(phieuNhapNew);
                db.SubmitChanges();
                return phieuNhapNew.ID;
            }
        }
        public void LapChiTietPhieuNhap(int MaPN, int maHangHoa, int soLuongCon, int soLuongNhap, int giaCapNhat, int tTien, string ghiChu, bool tinhTrang)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                ChiTietPhieuNhap chiTietNew = new ChiTietPhieuNhap();
                chiTietNew.MaPhieuNhap = MaPN;
                chiTietNew.MaHH = maHangHoa;
                chiTietNew.SoLuongCon = soLuongCon;
                chiTietNew.SoLuongNhap = soLuongNhap;
                chiTietNew.GiaCapNhat = giaCapNhat;
                chiTietNew.TongTien = tTien;
                chiTietNew.GhiChu = ghiChu;
                chiTietNew.TinhTrang = tinhTrang;
                db.ChiTietPhieuNhaps.InsertOnSubmit(chiTietNew);
                db.SubmitChanges();

            }
        }
        #endregion
    }
}
