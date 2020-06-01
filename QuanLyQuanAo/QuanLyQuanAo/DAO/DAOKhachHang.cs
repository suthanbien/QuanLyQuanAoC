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
    class DAOKhachHang
    {
        #region các khai báo
        private static DAOKhachHang instance;

        private List<ClassKhachHang> classKH = new List<ClassKhachHang>();
        #endregion

        #region các phương thức
        public static DAOKhachHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOKhachHang();
                }
                return instance;
            }
        }

        private DAOKhachHang()
        {

        }
        private int GetChucVu(string tenchucVu)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                ChucVu cv = db.ChucVus.Where(p => p.TenChucVu.Equals(tenchucVu)).SingleOrDefault();

                // MessageBox.Show(lsp.MaLoaiSanPham + "");
                return cv.MaChucVu;

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
                               LoaiKhachHang=l
                                
                           };

                foreach (var i in ttKH)
                {
                  //  MessageBox.Show(""+i);
                    ClassKhachHang KHNew = new ClassKhachHang();
                    KHNew.MaKhachHang = i.KhachHang.MaKhachHang;
                    KHNew.TenKhachHang = i.KhachHang.TenKhachHang;
                    KHNew.Ngaysinh = i.KhachHang.Ngaysinh;
                    KHNew.GioiTinh = i.KhachHang.GioiTinh;
                    KHNew.Email = i.KhachHang.Email;
                    KHNew.DiaChi = i.KhachHang.DiaChi;
                    KHNew.SDT = i.KhachHang.SDT;
                    KHNew.LoaiKhachHang = i.LoaiKhachHang.TenLoaiKhachHang;
                    KHNew.GhiChu = i.KhachHang.GhiChu;
                    if (i.KhachHang.Image != null)
                    {
                        KHNew.Image = ByteArrayToImage(i.KhachHang.Image.ToArray());
                    }
                    lstKH.Add(KHNew);
                }
                classKH = lstKH;
                return lstKH;
            }
        }
        #endregion
    }
}
