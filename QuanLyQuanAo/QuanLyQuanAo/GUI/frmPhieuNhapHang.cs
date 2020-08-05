using QuanLyQuanAo.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.GUI
{
    public partial class frmPhieuNhapHang : Form
    {
        #region Khai báo biến
        public static string m_MaNhanVien = "";
        private int mode=1;
        private int position;
        private int positionChiTiet;
        private String m_MaHH;
        #endregion

        #region Các phương thức
        private void LoadData()
        {
            List<string> lstLoaiHH = new List<string>();
            BUSPhieuNhap.Instance.GetHangHoa(dgvHangHoa);
            lstLoaiHH.Add("Tất Cả");
           // MessageBox.Show(""+ dgvHangHoa.RowCount);
            // btgNhomLenh.ds = dsLoaiSanPham;
            lstLoaiHH.AddRange(BUSPhieuNhap.Instance.GetListLoaiHH());
            cboLoaiHH.DataSource = lstLoaiHH;
            btnThemVaoPhieu.Enabled = false;
            btnThemHangLoat.Enabled = false;
            KiemTraButton();


        }
        private void KiemTraButton()
        {
            if (dgvChiTiet.RowCount <= 0)
            {
                btnLuuPhieu.Enabled = false;
                btnThemSL1Mon.Enabled = false;
                btnThemSLList.Enabled = false;
                btnXoaHH.Enabled = false;
                btnXoaPhieu.Enabled = false;
            }
            else
            {
               // btnLuuPhieu.Enabled = true;
               // btnThemSL1Mon.Enabled = true;
                //btnThemSLList.Enabled = true;
               // btnXoaHH.Enabled = true;
                btnXoaPhieu.Enabled = true;
            }
        }
        private void KiemTraLuu()
        {
            for (int i=0;i<dgvChiTiet.RowCount;i++)
            {
                int sl = Convert.ToInt32(dgvChiTiet.Rows[i].Cells[2].Value.ToString().Trim());

                if (dgvChiTiet.RowCount <= 0 || sl==0)
                {
                    btnLuuPhieu.Enabled = false;
                    break;
                }
                else
                {
                    btnLuuPhieu.Enabled = true;
                }
            }
           
        }
        private void GetNhanVien()
        {
            BUSPhieuNhap.Instance.GetNhanVien(m_MaNhanVien, txtMaNV, txtTenNV);
            // MessageBox.Show(m_MaNhanVien);   
        }

        public void AddDataTimKiem(List<string> lstTimKiem)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            for (int i = 0; i < lstTimKiem.Count(); i++)
            {
                collection.Add(lstTimKiem[i]);
                // MessageBox.Show("phan tu thu "+i+"la: "+ collection[i]);
            }
            txtTimKiem.AutoCompleteCustomSource = collection;
        }

        private void LuuPhieuNhap()
        {
            int maHH, maNV, TongTien,MaPN;
            DateTime ngayLapPhieu;
            string ghiChuPhieu;
            maNV = Convert.ToInt32(txtMaNV.Text);
            TongTien = Convert.ToInt32(txtTongTien.Text);
            ngayLapPhieu = datePic.Value;

            MaPN = BUSPhieuNhap.Instance.LapPhieu( maNV, TongTien, ngayLapPhieu);
            //MessageBox.Show(maHD + "");

            for (int i = 0; i < dgvChiTiet.RowCount; i++)
            {
                int maHangHoa, soLuongCon, soLuongNhap,giaCapNhat, tTien;
                string ghiChu;
                bool tinhTrang;
                maHangHoa = Convert.ToInt32(dgvChiTiet.Rows[i].Cells[0].Value.ToString().Trim());
                soLuongCon = Convert.ToInt32(dgvChiTiet.Rows[i].Cells[1].Value.ToString().Trim());
                soLuongNhap = Convert.ToInt32(dgvChiTiet.Rows[i].Cells[2].Value.ToString().Trim());
                giaCapNhat = Convert.ToInt32(dgvChiTiet.Rows[i].Cells[3].Value.ToString().Trim());
                tTien = Convert.ToInt32(dgvChiTiet.Rows[i].Cells[4].Value.ToString().Trim());
                ghiChu = dgvChiTiet.Rows[i].Cells[5].Value.ToString().Trim();
                tinhTrang = false;
                BUSPhieuNhap.Instance.LapChiTietPhieuNhap(MaPN, maHangHoa, soLuongCon, soLuongNhap, giaCapNhat, tTien, ghiChu, tinhTrang);
            }

            BUSPhieuNhap.Instance.XoaPhieu(dgvChiTiet);
            txtTongTien.Text = "0";
            txtMaHHCT.Text = "";
            txtSLNhap.Text = "";
        }

        #endregion
        #region các xử lý
        public frmPhieuNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmMain)(this.MdiParent)).moMnuPhieuNhapHang();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            LoadData();
            GetNhanVien();
            mode = 1;
            AddDataTimKiem(BUSPhieuNhap.Instance.ListTimTheoMa());
            txtTongTien.Text = BUSPhieuNhap.Instance.TongTien() + "";
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                if (dgvHangHoa.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    position = dgvHangHoa.CurrentRow.Index;
                    txtMaHH.Text = dgvHangHoa.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSLCon.Text = dgvHangHoa.Rows[e.RowIndex].Cells[5].Value.ToString();
                    btnThemVaoPhieu.Enabled = true;
                }

                for (int i=0;i<dgvHangHoa.RowCount;i++)
                {
                    bool check = Convert.ToBoolean(dgvHangHoa.Rows[i].Cells[0].Value);
                    if (check == true)
                    {
                        btnThemHangLoat.Enabled = true;
                        break;
                    }
                    else
                    {
                        btnThemHangLoat.Enabled = false;
                    }
                }
            }
            catch
            {

            }
        }

        private void cboLoaiHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaiHH = cboLoaiHH.SelectedValue.ToString();
            BUSPhieuNhap.Instance.GetHangHoaTheoLoai(loaiHH, dgvHangHoa);

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (mode==1)
            {
                string maHH = txtTimKiem.Text;
                BUSPhieuNhap.Instance.TimTheoMa(maHH, dgvHangHoa);

            }
            else if (mode ==2)
            {
                string SL = txtTimKiem.Text.Trim();
                BUSPhieuNhap.Instance.TimTheoSL(SL, dgvHangHoa);
            }
        }

        private void radTim_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimTheoMa.Checked)
            {
                mode = 1;
                AddDataTimKiem(BUSPhieuNhap.Instance.ListTimTheoMa());
            }
            else if (radTimTheoSL.Checked)
            {
                mode = 2;

            }
        }

        private void btnThemHangLoat_Click(object sender, EventArgs e)
        {
            BUSPhieuNhap.Instance.ThemListChiTiet(dgvHangHoa,dgvChiTiet);
            // BUSPhieuNhap.Instance.GetChiTiet(dgvHangHoa);
            KiemTraButton();
            txtMaHHCT.Text = dgvChiTiet.Rows[0].Cells[0].Value.ToString();
        }

        private void btnThemVaoPhieu_Click(object sender, EventArgs e)
        {
            BUSPhieuNhap.Instance.ThemChiTiet(dgvHangHoa, dgvChiTiet,position);
            KiemTraButton();
            txtMaHHCT.Text = dgvChiTiet.Rows[0].Cells[0].Value.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            BUSPhieuNhap.Instance.XoaPhieu(dgvChiTiet);
            KiemTraButton();
            txtSLNhap.Text = "";
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                if (dgvChiTiet.Rows[e.RowIndex].Cells[0].Value != null)
                {
                   positionChiTiet = dgvChiTiet.CurrentRow.Index;
                    txtMaHHCT.Text = dgvChiTiet.Rows[positionChiTiet].Cells[0].Value.ToString();
                   // btnThemSL1Mon.Enabled = true;
                    btnXoaHH.Enabled = true;
                    
                }
            }
            catch
            {

            }
        }

        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChiTiet.RowCount > 0)
                {
                    int maHH = Convert.ToInt32(txtMaHHCT.Text);
                    BUSPhieuNhap.Instance.XoaHHTrongPhieu(dgvChiTiet, maHH);
                    if (dgvChiTiet.RowCount > 0)
                    {
                        positionChiTiet = dgvChiTiet.CurrentRow.Index;
                        txtMaHHCT.Text = dgvChiTiet.Rows[positionChiTiet].Cells[0].Value.ToString();
                    }
                }
            }
            catch
            {

            }
            
          
        }

        private void btnThemSLList_Click(object sender, EventArgs e)
        {
            int soLuong;
            if (txtSLNhap.Text.Trim().Length==0)
            {
                soLuong = 0;
            }
            else
            {
                soLuong = Convert.ToInt32(txtSLNhap.Text.Trim());
            }
             
            BUSPhieuNhap.Instance.NhapListSL(soLuong,dgvChiTiet);
            txtTongTien.Text = BUSPhieuNhap.Instance.TongTien()+"";
            KiemTraLuu();


        }

        private void txtSLNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mode == 1 )
            {
                if (e.KeyChar > 'a' && e.KeyChar > 'z' || e.KeyChar > 'A' && e.KeyChar > 'Z')
                {
                    e.Handled = true;
                    btnThemSLList.Enabled = false;
                    btnThemSL1Mon.Enabled = false;
                }
                else 
                {
                      if (  dgvChiTiet.RowCount<=0)
                      {
                          btnThemSLList.Enabled = false;
                        btnThemSL1Mon.Enabled = false;
                    }
                      else
                      {
                          btnThemSLList.Enabled = true;
                        btnThemSL1Mon.Enabled = true;
                    }
                }
            }
        }

        private void btnThemSL1Mon_Click(object sender, EventArgs e)
        {
            if (txtMaHHCT.Text.Length>0)
            {
                int soLuong;
                int maHH = Convert.ToInt32(txtMaHHCT.Text);
                if (txtSLNhap.Text.Trim().Length == 0)
                {
                    soLuong = 0;
                }
                else
                {
                    soLuong = Convert.ToInt32(txtSLNhap.Text.Trim());
                }

                BUSPhieuNhap.Instance.NhapSL1Mon(maHH, soLuong, dgvChiTiet);
                txtTongTien.Text = BUSPhieuNhap.Instance.TongTien() + "";
                KiemTraLuu();
            }
           
        }

        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn lưu phiếu nhập hàng không?",
                "Lưu Phiếu Nhập", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dgvChiTiet.RowCount <= 0 || txtTongTien.Text.Equals("0"))
                {
                    MessageBox.Show("Vui lòng nhập chi tiết phiếu");
                }
                else
                {
                    LuuPhieuNhap();
                    MessageBox.Show("Đã lưu Phiếu Nhập");
                }
                
            }
        }
        #endregion
    }
}
