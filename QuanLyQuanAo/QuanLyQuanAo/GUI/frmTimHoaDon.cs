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
    public partial class frmTimHoaDon : Form
    {
        #region Khai báo biến
        int mode = 1;
        int position;
        #endregion

        #region Các phương thức
        private void GetAllHoaDon()
        {
            BUSTimHoaDon.Instance.GetAllHoaDon(dgvHoaDon);
        }
        private void GetChiTietHD(int maHD)
        {
            BUSTimHoaDon.Instance.GetChiTietHD(dgvChiTiet,maHD);
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

        #region Các Xử Lý 
       
        public frmTimHoaDon()
        {
            InitializeComponent();
        }

        private void frmTimHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmMain)(this.MdiParent)).moMnuTimHoaDon();
        }

        private void frmTimHoaDon_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void frmTimHoaDon_Resize(object sender, EventArgs e)
        {
            pnlC_Left.Width = (pnlCenter.Width / 2)-25;
            pnlC_R.Width = (pnlCenter.Width / 2) - 25;
        }

        private void frmTimHoaDon_Load(object sender, EventArgs e)
        {
            GetAllHoaDon();
            AddDataTimKiem(BUSTimHoaDon.Instance.ListTimTheoMa());
            pnlC_Left.Width = (pnlCenter.Width / 2) - 25;
            pnlC_R.Width = (pnlCenter.Width / 2) - 25;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                int maHD;
                position = dgvHoaDon.CurrentRow.Index;
                maHD = Convert.ToInt32(dgvHoaDon.Rows[position].Cells[0].Value.ToString());
                //MessageBox.Show(maHD.ToString());
                GetChiTietHD(maHD);
            }
            catch
            {
                GetAllHoaDon();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            GetAllHoaDon();
            dgvChiTiet.DataSource = null;
            txtTimKiem.Text = "";
        }

        private void radTim_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimTheoMa.Checked)
            {
                mode = 1;
                AddDataTimKiem(BUSTimHoaDon.Instance.ListTimTheoMa());
            }
            else if (radTimTheoKH.Checked)
            {
                mode = 2;

            }
        }

        

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (mode==1)
            {
                try
                {
                    int maHD = Convert.ToInt32(txtTimKiem.Text.Trim());
                    BUSTimHoaDon.Instance.TimTheoMa(dgvHoaDon, maHD);
                    if (dgvHoaDon.RowCount >= 1)
                    {

                        GetChiTietHD(maHD);
                    }
                }
                catch
                {
                    dgvChiTiet.DataSource = null;
                }
            }
            else if (mode == 2)
            {
                string keyTimKiem = txtTimKiem.Text;
                BUSTimHoaDon.Instance.TimTheoKH(dgvHoaDon, keyTimKiem);
                if (dgvHoaDon.RowCount >= 1)
                {
                    int maHD = Convert.ToInt32(dgvHoaDon.Rows[0].Cells[0].Value.ToString());
                    GetChiTietHD(maHD);
                }
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mode == 1)
            {
                if (e.KeyChar > 'a' && e.KeyChar > 'z' || e.KeyChar > 'A' && e.KeyChar > 'Z')
                {
                    e.Handled = true;
                }
            }
        }
        #endregion
    }
}
