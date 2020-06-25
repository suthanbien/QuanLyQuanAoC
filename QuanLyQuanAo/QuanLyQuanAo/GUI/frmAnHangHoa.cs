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
    public partial class frmAnHangHoa : Form
    {
        #region Khai báo biến
        private String m_MaHH;
        private String m_MaHHAn;
        private int timKiem=2;
        private bool isAn;
        public string MaHangHoa
        {
            set { lblMaHH.Text = m_MaHH = value.ToString(); }
            get { return lblMaHH.Text; }
        }
        public string MaHangHoaAn
        {
            set { lblMaHHAn.Text = m_MaHHAn = value.ToString(); }
            get { return lblMaHHAn.Text; }
        }

        // private String[] OldLoaiSanPham;
        #endregion

        #region Các phương thức
        private void LoadData()
        {
            BUSAnHangHoa.Instance.GetHangHoa(dgvHangHoa);
            BUSAnHangHoa.Instance.GetHangHoaAn(dgvHangHoaAn);
            MaHangHoa = dgvHangHoa.Rows[0].Cells[0].Value.ToString();
            MaHangHoaAn = dgvHangHoaAn.Rows[0].Cells[0].Value.ToString();
        }
        private void TimTheoMa(int maHH)
        {
            BUSAnHangHoa.Instance.TimTheoMa(maHH,dgvHangHoa, dgvHangHoaAn);
            
            lblMaHH.Text = "";
            lblMaHHAn.Text = "";
        }
        private void TimTheoSoLuong(int slHH)
        {
            BUSAnHangHoa.Instance.TimTheoSoLuong(slHH, dgvHangHoa, dgvHangHoaAn);
            lblMaHH.Text = "";
            lblMaHHAn.Text = "";
        }
        private void TimTheoTen(string tenHH)
        {
            BUSAnHangHoa.Instance.TimTheoTen(tenHH, dgvHangHoa, dgvHangHoaAn);
            lblMaHH.Text = "";
            lblMaHHAn.Text = "";
        }
        public void AddDataTimKiem(List<string> lstTimKiem)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            for (int i = 0; i < lstTimKiem.Count(); i++)
            {
                collection.Add(lstTimKiem[i]);
                // MessageBox.Show("phan tu thu "+i+"la: "+ lstTimKiem[i]);
            }
            txtTimKiem.AutoCompleteCustomSource = collection;
        }
        private void DinhViLai(String m_MaHH)
        {

            if (isAn)
            {
                for (int i = 0; i < dgvHangHoaAn.ColumnCount; i++)
                    if (dgvHangHoaAn.Rows[i].Cells[0].Value.ToString().Trim() == m_MaHH.Trim())
                    {
                        dgvHangHoaAn.CurrentCell = dgvHangHoaAn.Rows[i].Cells[0];
                    }
            }
            else
            {
                for (int i = 0; i < dgvHangHoa.ColumnCount; i++)
                    if (dgvHangHoa.Rows[i].Cells[0].Value.ToString().Trim() == m_MaHH.Trim())
                    {
                        dgvHangHoa.CurrentCell = dgvHangHoa.Rows[i].Cells[0];
                    }
            }
            
        }

        #endregion
        public frmAnHangHoa()
        {
            InitializeComponent();
        }

        private void frmAnHangHoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmMain)(this.MdiParent)).moMnuHangHoaAn();
        }

        private void frmAnHangHoa_Load(object sender, EventArgs e)
        {
            LoadData();
            AddDataTimKiem(BUSAnHangHoa.Instance.ListTimTheoMa());
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHangHoa.Rows[e.RowIndex].Cells[0].Value != null)
            {
                MaHangHoa=dgvHangHoa.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }

        private void dgvHangHoaAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHangHoaAn.Rows[e.RowIndex].Cells[0].Value != null)
            {
                MaHangHoaAn = dgvHangHoaAn.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void radTimKiemHHAn_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radTimTheoMa.Checked)
            {
                timKiem = 1;
                AddDataTimKiem(BUSAnHangHoa.Instance.ListTimTheoMa());
                txtTimKiem.Text = "0";
            }
            else if (radTimTheoTen.Checked)
            {
                timKiem = 2;
                AddDataTimKiem(BUSAnHangHoa.Instance.ListTimTheoTen());
                txtTimKiem.Text = "";
            }
            else if (radTimTheoSL.Checked)
                    {
                timKiem = 3;
                txtTimKiem.Text = "0";
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (timKiem == 1)
            {
                int maTimKiem = Convert.ToInt32(txtTimKiem.Text);
                TimTheoMa(maTimKiem);
            }else if (timKiem == 2)
            {
                string tenTimKiem = txtTimKiem.Text;
                TimTheoTen(tenTimKiem);
            }
            else if (timKiem == 3)
            {
                int slTimKiem = Convert.ToInt32(txtTimKiem.Text);
                TimTheoSoLuong(slTimKiem);
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (timKiem == 1 || timKiem == 3)
            {
                if (e.KeyChar > 'a' && e.KeyChar > 'z' || e.KeyChar > 'A' && e.KeyChar > 'Z')
                {
                    e.Handled = true;
                }
            }
            
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnHH_Click(object sender, EventArgs e)
        {
            isAn = true;
            int maHH = Convert.ToInt32(m_MaHH);
            BUSAnHangHoa.Instance.An(maHH);
            //BUSAnHangHoa.Instance.TimTheoMa(Convert.ToInt32(m_MaHH), dgvHangHoa, dgvHangHoaAn);
            LoadData();
           // DinhViLai(maHH.ToString());
        }

        private void btnHienHH_Click(object sender, EventArgs e)
        {
            isAn = false;
            int maHH = Convert.ToInt32(m_MaHHAn);
            BUSAnHangHoa.Instance.Hien(Convert.ToInt32(maHH));
            //BUSAnHangHoa.Instance.TimTheoMa(Convert.ToInt32(m_MaHH), dgvHangHoa, dgvHangHoaAn);
            LoadData();
         //   DinhViLai(maHH.ToString());
        }
    }
}
