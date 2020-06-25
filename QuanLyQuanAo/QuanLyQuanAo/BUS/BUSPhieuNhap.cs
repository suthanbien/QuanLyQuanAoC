using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.BUS
{
    class BUSPhieuNhap
    {
        #region các khai báo
        private static BUSPhieuNhap instance;
        List<ClassHangHoa> lstHangHoa = new List<ClassHangHoa>();
        List<string> lstLoaiHangHoa = new List<string>();
        List<ClassHangHoa> lstHangHoaTheoLoai;
        List<ChiTietPhieuNhap> lstChiTiet = new List<ChiTietPhieuNhap>();
        #endregion

        #region các phương thức
        public static BUSPhieuNhap Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSPhieuNhap();
                }
                return instance;
            }
        }

        private BUSPhieuNhap()
        {

        }
        public List<string> GetListLoaiHH()
        {
            lstLoaiHangHoa = DAOHangHoa.Instance.GetListLoaiHangHoa();
            return lstLoaiHangHoa;
        }
        private void TinhTien()
        {
           
            for (int i=0;i<lstChiTiet.Count;i++)
            {
                int sl = lstChiTiet[i].SoLuongNhap;
                int gia = lstChiTiet[i].GiaCapNhat;
                int tong = sl * gia;
                lstChiTiet[i].TongTien = tong;
            }
        }
        public int TongTien()
        {
            if (lstChiTiet.Count>0)
            {
                int tong=0;
                for (int i = 0; i < lstChiTiet.Count; i++)
                {
                    int gia = lstChiTiet[i].TongTien;
                    tong=tong+gia;
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
        public void GetHangHoa(DataGridView dgvHangHoa)
        {
            lstHangHoa = DAOPhieuNhap.Instance.GetHangHoa();
            dgvHangHoa.DataSource = lstHangHoa;
            GetListLoaiHH();
        }
        public void GetHangHoaTheoLoai(string loaiHH, DataGridView dgvHangHoa)
        {
            lstHangHoaTheoLoai = new List<ClassHangHoa>();
            if (loaiHH.Equals("Tất Cả"))
            {
                lstHangHoaTheoLoai = lstHangHoa;
            }
            else
            {
                for (int i = 0; i < lstHangHoa.Count; i++)
                {
                    if (lstHangHoa[i].LoaiHangHoa.Equals(loaiHH))
                    {
                        lstHangHoaTheoLoai.Add(lstHangHoa[i]);
                    }
                }
            }

            dgvHangHoa.DataSource = lstHangHoaTheoLoai;
        }
        public void GetNhanVien(string maNV, TextBox txtMaNV, TextBox txtTenNV)
        {
            txtMaNV.Text = DAOPhieuNhap.Instance.GetNhanVien(maNV)[0].MaNhanVien.ToString();
            txtTenNV.Text = DAOPhieuNhap.Instance.GetNhanVien(maNV)[0].TenNhanVien.ToString();
        }
        

        public List<string> ListTimTheoMa()
        {
            return DAOPhieuNhap.Instance.ListTimTheoMa();
        }

        public void TimTheoMa(string maHH, DataGridView dgvHangHoa)
        {
            try
            {
                dgvHangHoa.DataSource = DAOPhieuNhap.Instance.TimTheoMa(Convert.ToInt32(maHH));
            }
            catch
            {
                lstHangHoa = DAOHangHoa.Instance.GetHangHoa();
                dgvHangHoa.DataSource = lstHangHoa;
            }
        }
        public void TimTheoSL(string SL, DataGridView dgvHangHoa)
        {
            try
            {
                dgvHangHoa.DataSource = DAOPhieuNhap.Instance.TimTheoSL(Convert.ToInt32(SL));
            }
            catch
            {
                lstHangHoa = DAOHangHoa.Instance.GetHangHoa();
                dgvHangHoa.DataSource = lstHangHoa;
            }
        }
        public void XoaPhieu( DataGridView dgvChiTiet)
        {
            dgvChiTiet.DataSource = null;
            lstChiTiet.Clear();
            dgvChiTiet.DataSource = lstChiTiet;
        }
        public void XoaHHTrongPhieu(DataGridView dgvChiTiet,int maHH)
        {
            dgvChiTiet.DataSource = null;
            if (lstChiTiet.Count>0)
            {
                for (int i=0;i<lstChiTiet.Count;i++)
                {
                    if (lstChiTiet[i].MaHH==maHH)
                    {
                        lstChiTiet.RemoveAt(i);
                    }
                }
            }
            dgvChiTiet.DataSource = lstChiTiet;
        }
        public void ThemListChiTiet(DataGridView dgv, DataGridView dgvChiTiet)
        {
            dgvChiTiet.DataSource = null;
            bool check=false,checkChiTiet=true;
            for (int i=0;i<dgv.RowCount; i++)
            {
                int maHH, SLCon, SLnhap, giaCapNhat;
                string ghiChu;

                SLCon = Convert.ToInt32(dgv.Rows[i].Cells[7].Value.ToString().Trim());
                SLnhap = 0;
                giaCapNhat = Convert.ToInt32(dgv.Rows[i].Cells[5].Value.ToString().Trim());
                ghiChu = "";
                check =Convert.ToBoolean(dgv.Rows[i].Cells[0].Value);
                maHH = Convert.ToInt32(dgv.Rows[i].Cells[1].Value.ToString().Trim());
                //MessageBox.Show(check.ToString());
                for (int j = 0; j < lstChiTiet.Count; j++)
                {
                    if (lstChiTiet[j].MaHH == maHH)
                    {
                        checkChiTiet = false;
                        break;
                    }
                    else { checkChiTiet = true; }
                }
                if (check==true&&checkChiTiet==true)
                {
                    ChiTietPhieuNhap ctNew = new ChiTietPhieuNhap();
                    

                    ctNew.MaHH = maHH;
                    ctNew.SoLuongCon = SLCon;
                    ctNew.SoLuongNhap = SLnhap;
                    ctNew.GiaCapNhat = giaCapNhat;
                    ctNew.GhiChu = ghiChu;

                    lstChiTiet.Add(ctNew);
                }
               
            }
            dgvChiTiet.DataSource = lstChiTiet;
        }
        public void ThemChiTiet(DataGridView dgv, DataGridView dgvChiTiet,int index)
        {
            dgvChiTiet.DataSource = null;
            bool check = true, checkChiTiet = true;
           
                int maHH, SLCon, SLnhap, giaCapNhat;
                string ghiChu;

                SLCon = Convert.ToInt32(dgv.Rows[index].Cells[7].Value.ToString().Trim());
                SLnhap = 0;
                giaCapNhat = Convert.ToInt32(dgv.Rows[index].Cells[5].Value.ToString().Trim());
                ghiChu = "";
                //check = Convert.ToBoolean(dgv.Rows[index].Cells[0].Value);
                maHH = Convert.ToInt32(dgv.Rows[index].Cells[1].Value.ToString().Trim());
                //MessageBox.Show(check.ToString());
                for (int j = 0; j < lstChiTiet.Count; j++)
                {
                    if (lstChiTiet[j].MaHH == maHH)
                    {
                        checkChiTiet = false;
                        break;
                    }
                    else { checkChiTiet = true; }
                }
                if (check == true && checkChiTiet == true)
                {
                    ChiTietPhieuNhap ctNew = new ChiTietPhieuNhap();


                    ctNew.MaHH = maHH;
                    ctNew.SoLuongCon = SLCon;
                    ctNew.SoLuongNhap = SLnhap;
                    ctNew.GiaCapNhat = giaCapNhat;
                    ctNew.GhiChu = ghiChu;

                    lstChiTiet.Add(ctNew);
                }

            
            dgvChiTiet.DataSource = lstChiTiet;
        }
        public void GetChiTiet(DataGridView dgv)
        {
            
        }

        public void NhapListSL(int sl,DataGridView dgv)
        {
            dgv.DataSource = null;
            for (int i=0;i<lstChiTiet.Count;i++)
            {
                lstChiTiet[i].SoLuongNhap = sl;
            }
            TinhTien();
            dgv.DataSource = lstChiTiet;
        }
        public void NhapSL1Mon(int maHH,int sl,DataGridView dgv)
        {
            dgv.DataSource = null;
            for (int i=0;i<lstChiTiet.Count;i++)
            {
                if (lstChiTiet[i].MaHH==maHH)
                {
                    lstChiTiet[i].SoLuongNhap = sl;

                }
                
            }
            TinhTien();
            dgv.DataSource = lstChiTiet;
        }
        public int LapPhieu(int maNV, int TongTien,DateTime ngayLapPhieu)
        {
            return DAOPhieuNhap.Instance.LapPhieu(maNV, TongTien, ngayLapPhieu);
        }
        public void LapChiTietPhieuNhap(int MaPN, int maHangHoa,int  soLuongCon,int soLuongNhap
            , int giaCapNhat,int tTien,string ghiChu,bool tinhTrang)
        {
            DAOPhieuNhap.Instance.LapChiTietPhieuNhap(MaPN, maHangHoa, soLuongCon, soLuongNhap, giaCapNhat, tTien, ghiChu, tinhTrang);
        }
       
        #endregion
    }
}
