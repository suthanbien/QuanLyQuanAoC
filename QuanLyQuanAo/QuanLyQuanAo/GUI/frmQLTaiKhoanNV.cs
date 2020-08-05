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
    public partial class frmQLTaiKhoanNV : Form
    {
        #region Khai báo biến
        private string m_MaNV;
        private string m_IDDV;
        private int timKiem=1;
        private int mode = 0;
        private int position;
        #endregion

        #region Các phương thức

        private void LoadData()
        {
            BUSTaiKhoanNV.Instance.GetNhanVien(dgvNhanVien);
            BUSTaiKhoanNV.Instance.GetTaiKhoan(dgvTaiKhoan);
            AddDataTimKiem(BUSTaiKhoanNV.Instance.ListTimTheoTen());
            cboQuyen.DataSource= BUSTaiKhoanNV.Instance.GetComboBoxQuyen();
           
            txtMaNV.Text = "";
            txtMK.Text = "";
            txtTK.Text = "";
            cboQuyen.Text = "Nhân Viên";
        }
        private void ReadDGV(bool b)
        {
            dgvTaiKhoan.ReadOnly = b;

            dgvTaiKhoan.Columns[0].ReadOnly = !b;
            dgvTaiKhoan.Columns[1].ReadOnly = !b;
            dgvTaiKhoan.Columns[2].ReadOnly = !b;
            dgvTaiKhoan.Columns[8].ReadOnly = !b;
            dgvTaiKhoan.Columns[9].ReadOnly = !b;
            dgvTaiKhoan.Columns[10].ReadOnly = !b;
            dgvTaiKhoan.Columns[11].ReadOnly = !b;
            dgvTaiKhoan.Columns[12].ReadOnly = !b;
        }
        private void DinhViLai(String m_ID)
        {
            for (int i = 0; i < dgvTaiKhoan.RowCount; i++)
            {
               
                if (dgvTaiKhoan.Rows[i].Cells[0].Value.ToString().Trim().Equals( m_ID.Trim()))
                {
                    position = i;
                    dgvTaiKhoan.CurrentCell = dgvTaiKhoan.Rows[i].Cells[0];
                }
            }
               
        }
        private void DinhViLaiNV(String m_maNV)
        {
            for (int i = 0; i < dgvTaiKhoan.RowCount; i++)
            {

                if (dgvTaiKhoan.Rows[i].Cells[1].Value.ToString().Trim().Equals(m_maNV.Trim()))
                {
                    position = i;
                    dgvTaiKhoan.CurrentCell = dgvTaiKhoan.Rows[i].Cells[0];
                }
            }

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
        public frmQLTaiKhoanNV()
        {
            InitializeComponent();
        }

        private void frmQLTaiKhoanNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmMain)(this.MdiParent)).moMnuQLTaiKhoanNV();
        }

        private void frmQLTaiKhoanNV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void radTim_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimTheoTen.Checked)
            {
                timKiem = 1;
                cbChucVu.Enabled = false;
                txtTimKiem.Enabled = true;
                AddDataTimKiem(BUSTaiKhoanNV.Instance.ListTimTheoTen());
            }
            else if (radTimTheoMa.Checked)
            {
                timKiem = 2;
                cbChucVu.Enabled = false;
                txtTimKiem.Enabled = true;
                AddDataTimKiem(BUSTaiKhoanNV.Instance.ListTimTheoMa());
            }
            else if (radTimTheoChucVu.Checked)
            {
                timKiem = 3;
                cbChucVu.Enabled = true;
                txtTimKiem.Enabled = false;
                BUSTaiKhoanNV.Instance.GetComboBox(cbChucVu);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (timKiem==1)
            {
                string  tenNV = txtTimKiem.Text;
                BUSTaiKhoanNV.Instance.TimNhanVienTheoTen(tenNV,dgvNhanVien);
                BUSTaiKhoanNV.Instance.TimTaiKhoanTheoTen(tenNV,dgvTaiKhoan);
            }
            else if(timKiem == 2)
            {
                try
                {
                    int maNV = Convert.ToInt32(txtTimKiem.Text);
                    BUSTaiKhoanNV.Instance.TimNhanVienTheoMa(maNV, dgvNhanVien);
                    BUSTaiKhoanNV.Instance.TimTaiKhoanTheoMa(maNV, dgvTaiKhoan);
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên");
                }
            }
            else if (timKiem ==3)
            {
                string chucVu = cbChucVu.SelectedValue.ToString();
                BUSTaiKhoanNV.Instance.TimNhanVienTheoChucVu(chucVu, dgvNhanVien);
                BUSTaiKhoanNV.Instance.TimNhanVienTheoChucVu(chucVu, dgvTaiKhoan);
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (timKiem == 2)
            {
                if (e.KeyChar > 'a' && e.KeyChar > 'z' || e.KeyChar > 'A' && e.KeyChar > 'Z')
                {
                    e.Handled = true;
                }
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMK.Text = "";
                if (txtTK.Text.Length>0&&txtMK.Text.Length>0)
                {
                    btnTaoTK.Enabled = true;
                }
                else
                {
                    btnTaoTK.Enabled = false;
                }


                if (dgvNhanVien.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (dgvNhanVien.Rows[e.RowIndex].Cells[3].Value != null)
                    {
                        txtTK.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                    }
                        
                }

                
            }
            catch
            {

            }
        }

        private void txtTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTK.Text.Length > 0 && txtMK.Text.Length > 0)
            {
                btnTaoTK.Enabled = true;
            }
            else
            {
                btnTaoTK.Enabled = false;
            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            try
            {
                int maNV=Convert.ToInt32(txtMaNV.Text);
                m_MaNV = maNV.ToString(); 
                string taiKhoan=txtTK.Text;
                string matKhau=txtMK.Text;
                string quyen = cboQuyen.SelectedValue.ToString();
                BUSTaiKhoanNV.Instance.TaoTaiKhoan(maNV, taiKhoan, matKhau, quyen);
                LoadData();
                DinhViLaiNV(m_MaNV);
                
            }
            catch
            {

            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = "";    
                
                if (dgvTaiKhoan.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtID.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells[0].Value.ToString();
                }

                if (mode != 0)
                {
                    if (dgvTaiKhoan.CurrentRow.Index != position)
                        dgvTaiKhoan.CurrentCell = dgvTaiKhoan.Rows[position].Cells[3];
                }

                if (dgvTaiKhoan.CurrentCell.ColumnIndex == 6)
                {
                    if (mode == 1)
                    {
                        DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
                        comboBoxCell.DataSource = BUSTaiKhoanNV.Instance.GetComboBoxQuyen();

                        dgvTaiKhoan[6, position] = comboBoxCell;
                    }
                }
            }
            catch
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            mode = 1;
            position = dgvTaiKhoan.CurrentRow.Index;
            m_IDDV = dgvTaiKhoan.Rows[position].Cells[0].Value.ToString();
            btnLuu.Enabled = true;
            btnSua.Visible = false;
            btnHuy.Visible = true;
            btnTimKiem.Enabled = false;
            btnLamMoi.Enabled = false;
             ReadDGV(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            mode = 0;
            
            btnLuu.Enabled = false;
            btnSua.Visible = true;
            btnHuy.Visible = false;
            btnTimKiem.Enabled = true;
            btnLamMoi.Enabled = true;
            ReadDGV(true);
            LoadData();
            DinhViLai(m_IDDV);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            int m_ID, maNV;
            string tenDN, m_MK, quyen, chuThich;
            bool tinhTrang = Convert.ToBoolean(dgvTaiKhoan.Rows[position].Cells[5].Value);
            if (dgvTaiKhoan.Rows[position].Cells[0].Value == null)
            {
                m_ID = -1;
            }
            else
            {
                m_ID = Convert.ToInt32(dgvTaiKhoan.Rows[position].Cells[0].Value);
            }
            if (dgvTaiKhoan.Rows[position].Cells[1].Value == null)
            {
                maNV = -1;
            }
            else
            {
                maNV = Convert.ToInt32(dgvTaiKhoan.Rows[position].Cells[1].Value);
            }
            if (dgvTaiKhoan.Rows[position].Cells[3].Value == null)
            {
                tenDN = "";

            }
            else
            {
                tenDN = dgvTaiKhoan.Rows[position].Cells[3].Value.ToString();
            }
            if (dgvTaiKhoan.Rows[position].Cells[4].Value == null)
            {
                m_MK = "";
            }
            else
            {
                m_MK = dgvTaiKhoan.Rows[position].Cells[4].Value.ToString();
            }
            if (dgvTaiKhoan.Rows[position].Cells[6].Value == null)
            {
                quyen = "";
            }
            else
            {
                quyen = dgvTaiKhoan.Rows[position].Cells[6].Value.ToString();
            }
            if (dgvTaiKhoan.Rows[position].Cells[7].Value == null)
            {
                chuThich = "";
            }
            else
            {
                chuThich = dgvTaiKhoan.Rows[position].Cells[7].Value.ToString();
            }
            //MessageBox.Show( m_ID+""+ maNV+""+tenDN+""+ m_MK+""+ quyen+""+ chuThich+tinhTrang);

            if (tenDN.Equals("") || m_MK.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên tài khoản và mật khẩu");
            }
            else
            {
                if (BUSTaiKhoanNV.Instance.KiemTraTenDangNhap(tenDN) == false)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại.");
                }
                else
                {
                    BUSTaiKhoanNV.Instance.SuaTK( m_ID, maNV, tenDN, m_MK, quyen, chuThich, tinhTrang);
                    mode = 0;

                    btnLuu.Enabled = false;
                    btnSua.Visible = true;
                    btnHuy.Visible = false;
                    btnTimKiem.Enabled = true;
                    btnLamMoi.Enabled = true;
                    ReadDGV(true);
                    LoadData();
                    DinhViLai(m_IDDV);
                }
            }


        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            int m_ID = Convert.ToInt32(txtID.Text);
           
            if (MessageBox.Show(
           "Có chắc chắn hủy bỏ tài khoản với mã số  " + m_ID + " không?",
           "Nhà xuất bản", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (BUSTaiKhoanNV.Instance.XoaTaiKhoan(m_ID) == true)
                {
                    LoadData();
                }
                else
                {
                    MessageBox.Show("không thể xóa ràng buộc dữ liệu");
                }

            }
        }

        #endregion
    }
}
