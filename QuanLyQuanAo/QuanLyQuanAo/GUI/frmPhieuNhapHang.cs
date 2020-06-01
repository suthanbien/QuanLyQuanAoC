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

        #endregion
        public frmPhieuNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmMain)(this.MdiParent)).moMnuNhapHang();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            LoadData();
            GetNhanVien();
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                if (dgvHangHoa.Rows[e.RowIndex].Cells[1].Value != null)
                {
                   // position = dgvHangHoa.CurrentRow.Index;
                    txtMaHH.Text = dgvHangHoa.Rows[e.RowIndex].Cells[1].Value.ToString();
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

        }

        private void radTim_CheckedChanged(object sender, EventArgs e)
        {
           /* if (radTimTheoMa.Checked)
            {
                mode = 1;
                AddDataTimKiem(BUSPhieuNhap.Instance.ListTimTheoMa());
            }
            else if (radTimTheoSL.Checked)
            {
                mode = 2;

            }*/
        }

    }
}
