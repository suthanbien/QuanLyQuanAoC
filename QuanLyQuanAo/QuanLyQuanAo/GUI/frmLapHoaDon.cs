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
    public partial class frmLapHoaDon : Form
    {
        #region Khai báo biến
        public static string m_MaNhanVien = "";
        private int position;
        private int mode = 0;
        #endregion

        #region Các phương thức

        public void GetKhachHang()
        {
            BUSLapHoaDon.Instance.GetKhachHang(cboMKH,txtTenKH,txtDiaChi,txtSDT,txtLoaiKH,txtLoaiGiamGia);
           // MessageBox.Show(m_MaNhanVien);   
        }
        private void GetNhanVien()
        {
            BUSLapHoaDon.Instance.GetNhanVien(m_MaNhanVien,txtMaNV,txtTenNV);
            // MessageBox.Show(m_MaNhanVien);   
        }
      
        private void LoadSP()
         {
            MaHH.DataSource = BUSLapHoaDon.Instance.GetListHangHoa();
            MaHH.DisplayMember = "MaHangHoa";
            MaHH.ValueMember = "MaHangHoa";
        }
        
        private float TongTien()
         {
             float t = 0;
             for (int i = 0; i < dgvHoaDon.RowCount; i++)
             {
                 t += float.Parse(dgvHoaDon[5, i].Value.ToString());
             }
             return t;
         }
        private float GiamGia(string tongTien,string loaiKHGiam,string maGGGiam)
         {
            float m_TongTien, m_loaiKHGiam, m_maGGGiam, m_TienDaGiam=0,m_TongPTGiam;

            if (tongTien.Trim().Length==0|| loaiKHGiam.Trim().Length == 0)
            {
                return m_TienDaGiam = 0;
            }
            else if (maGGGiam.Trim().Length != 0)
                {
                m_TongTien = Convert.ToInt32(tongTien);
                m_loaiKHGiam = Convert.ToInt32(loaiKHGiam);
                m_maGGGiam = Convert.ToInt32(maGGGiam);
                m_TongPTGiam = m_loaiKHGiam + m_maGGGiam;
               
                m_TienDaGiam = (m_TongPTGiam / 100) * m_TongTien;
                //MessageBox.Show("" + m_TienDaGiam);
                return m_TienDaGiam;
            }
            else {
                m_TongTien = Convert.ToInt32(tongTien);
                m_loaiKHGiam = Convert.ToInt32(loaiKHGiam);
                m_maGGGiam = 0;
                m_TongPTGiam = m_loaiKHGiam + m_maGGGiam;

                m_TienDaGiam = (m_TongPTGiam / 100) * m_TongTien;
                //MessageBox.Show("" + m_TienDaGiam);
                return m_TienDaGiam;
            }
        }
        private double TTien(int m)
         {


             double s = 0;
             double t, slm, g;
             double.TryParse(dgvHoaDon[2, m].Value.ToString(), out t);
             double.TryParse(dgvHoaDon[3, m].Value.ToString(), out g);

             if (!double.TryParse(dgvHoaDon[4, m].Value.ToString(), out slm))
             {
                 slm = 0;
             }
             if (t > 0 && g > 0 && slm <= t)
             {
                 return s = g * slm;
             }
             else
             {
                 return s = 0;
             }
         }
         
        private void LuuHD()
        {
            int maHD, maKH, maNV, TongTien;
            DateTime ngayLapHD;
            string ghiChuHD;
            maKH = Convert.ToInt32(cboMKH.Text);
            maNV = Convert.ToInt32(txtMaNV.Text);
            TongTien = Convert.ToInt32(txtConLai.Text);
            ngayLapHD = datePic.Value;
            ghiChuHD = "Tổng tiền: " + txtTongTien.Text.ToString() + ". Giảm Giá: " + txtGiamGia.Text.ToString();
            maHD= BUSLapHoaDon.Instance.LapHoaDon(maKH, maNV, TongTien, ngayLapHD, ghiChuHD);
            //MessageBox.Show(maHD + "");

            for (int i = 0; i < dgvHoaDon.RowCount; i++)
             {
                int maHangHoa, soLuongMua, tTien;
                string ghiChu;
                maHangHoa = Convert.ToInt32(dgvHoaDon.Rows[i].Cells[0].Value.ToString().Trim());
                soLuongMua = Convert.ToInt32(dgvHoaDon.Rows[i].Cells[4].Value.ToString().Trim());
                tTien = Convert.ToInt32(dgvHoaDon.Rows[i].Cells[5].Value.ToString().Trim());
                ghiChu = dgvHoaDon.Rows[i].Cells[6].Value.ToString().Trim();
                BUSLapHoaDon.Instance.LapChiTietHoaDon(maHD, maHangHoa, soLuongMua, tTien, ghiChu);
            }

            BUSLapHoaDon.Instance.HuyHoaDon(dgvHoaDon);
            txtTongTien.Text = "0";
            txtGiamGia.Text = "0";
            txtConLai.Text = "0";
            btnLuuHH.Visible = false;
            btnThemHH.Enabled = true;
            btnLuu.Enabled = false;
            btnXoaHH.Enabled = false;
            btnSuDungMGG.Enabled = true;
            btnSuaHH.Enabled = false;
            txtMaGiamGia.Text = "";
            lblHeSoGiam.Text = "";
            lblThongBaoGG.Text = "";
        }

        public void TinhTien()
        {
            string maGiamGia = txtMaGiamGia.Text.Trim();
            BUSLapHoaDon.Instance.SuDungMaGiamGia(maGiamGia, lblHeSoGiam, lblThongBaoGG);

            if (dgvHoaDon.RowCount > 0)
            {
                
                txtTongTien.Text = TongTien().ToString("#########");
                string text = GiamGia(txtTongTien.Text, txtLoaiGiamGia.Text, lblHeSoGiam.Text).ToString("#########");
                if (text.Length == 0)
                {
                    text = "0";
                }
                txtGiamGia.Text = text;
                int conLai = Convert.ToInt32(txtTongTien.Text.Trim()) - Convert.ToInt32(txtGiamGia.Text.Trim());
                txtConLai.Text = conLai.ToString("#########");
            }
        }
        #endregion
        public frmLapHoaDon()
        {
            InitializeComponent();
        }

        private void frmLapHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            BUSLapHoaDon.Instance.HuyHoaDon(dgvHoaDon);
            txtTongTien.Text = "0";
            txtGiamGia.Text = "0";
            txtConLai.Text = "0";
            btnLuuHH.Visible = false;
            btnThemHH.Enabled = true;
            btnLuu.Enabled = false;
            btnXoaHH.Enabled = false;
            btnSuDungMGG.Enabled = true;
            btnSuaHH.Enabled = false;
            ((frmMain)(this.MdiParent)).moMnuLapHoaDon();
        }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            btnLuuHH.Enabled = false;
            GetKhachHang();
            GetNhanVien();

            grbThongTinMatHang.Enabled = true;
            LoadSP();

            btnThemHH.Enabled = true;
 

            btnLuuHH.Hide();
            DateTime date = DateTime.Today;
            datePic.Value = date;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
            frmKhachHang.isDialog = true;
            
        }

        private void btnLoadKH_Click(object sender, EventArgs e)
        {
            GetKhachHang();
        }

        private void btnThemHH_Click(object sender, EventArgs e)
        {
            mode = 1;
            BUSLapHoaDon.Instance.ThemChiTiet(dgvHoaDon);
            position = dgvHoaDon.RowCount - 1;
            dgvHoaDon.CurrentCell = dgvHoaDon.Rows[position].Cells[0];
           
            //MessageBox.Show(position.ToString());
            btnLuuHH.Show();
            btnLuuHH.Enabled=true;
            dgvHoaDon.ReadOnly = false;
           
            btnLuu.Enabled = false;
            btnSuDungMGG.Enabled = false;
            //txtTongTien.Text = TongTien().ToString("#########");

            if (dgvHoaDon.RowCount > 0)
            {
                btnXoaHH.Enabled = true;
            }
            else
            {
                btnXoaHH.Enabled = false;
            }
            btnThemHH.Enabled = false;
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvHoaDon.RowCount; i++)
            {
                int t = int.Parse(dgvHoaDon[5, i].Value.ToString());
                int s = int.Parse(dgvHoaDon[4, i].Value.ToString());
                if (t > 0 && s > 0)
                {
                    dgvHoaDon.ReadOnly = true;
                    btnLuuHH.Hide();
                    txtTongTien.Text = TongTien().ToString("#########");
                    TinhTien();
                    if (dgvHoaDon.RowCount > 0)
                    {
                        btnXoaHH.Enabled = true;
                        btnLuu.Enabled = true;
                        btnSuaHH.Enabled = true;
                        btnThemHH.Enabled = true;
                        mode = 0;
                        btnSuDungMGG.Enabled = true;
                    }
                    else
                    {
                        btnXoaHH.Enabled = false;
                        btnLuu.Enabled = false;
                        btnSuaHH.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập số lượng");
                    btnLuuHH.Show();
                }

            }
        }

        private void dgvHoaDon_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
            if (dgvHoaDon.CurrentCell.ColumnIndex == 0)

            {
                if (e.Control is ComboBox)
                {
                    ComboBox cboMaSP = (ComboBox)e.Control;
                    if (cboMaSP != null)
                    {
                        cboMaSP.SelectedIndexChanged -= cboMaSP_SelectedIndexChanged;
                        cboMaSP.SelectedIndexChanged += cboMaSP_SelectedIndexChanged;
                    }
                }
            }
            if (dgvHoaDon.CurrentCell.ColumnIndex == 4 )
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 47 || e.KeyChar == 8))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
         
        }

        private void cboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int rowIndex = dgvHoaDon.CurrentCell.RowIndex;
            ComboBox cboTacGia = sender as DataGridViewComboBoxEditingControl;
            dgvHoaDon.Rows[position].Cells[1].Value =
                BUSLapHoaDon.Instance.GetListHangHoa()[cboTacGia.SelectedIndex].TenHangHoa;

            dgvHoaDon.Rows[position].Cells[2].Value =
                BUSLapHoaDon.Instance.GetListHangHoa()[cboTacGia.SelectedIndex].SoLuongCon;

            dgvHoaDon.Rows[position].Cells[3].Value =
                BUSLapHoaDon.Instance.GetListHangHoa()[cboTacGia.SelectedIndex].GiaBan;

            dgvHoaDon.Rows[position].Cells[6].Value =
                BUSLapHoaDon.Instance.GetListHangHoa()[cboTacGia.SelectedIndex].ChuThich;



        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (mode==1)
                {
                    if (dgvHoaDon.CurrentRow.Index != position)
                    {
                        dgvHoaDon.CurrentCell = dgvHoaDon.Rows[position].Cells[4];
                    }
                }
                if (dgvHoaDon.RowCount > 0)
                {
                    dgvHoaDon.Rows[position].Cells[5].Value = TTien(position).ToString();
                }

                    TinhTien();
            }
            catch
            {

            }
        }

        private void btnSuDungMGG_Click(object sender, EventArgs e)
        {
           

            TinhTien();
        }

        private void cboMKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cboMKH.SelectedIndex.ToString());
            //MessageBox.Show(txtLoaiGiamGia.Text.ToString());
            //TinhTien();
        }

        private void txtLoaiGiamGia_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            int RowIndex = dgvHoaDon.CurrentRow.Index;
            LoadSP();
            // MessageBox.Show(RowIndex.ToString());
            //dgvHoaDon.Rows.RemoveAt(position);
            BUSLapHoaDon.Instance.RemoveAt(RowIndex, dgvHoaDon);
            // MessageBox.Show(position.ToString());
            
            if (dgvHoaDon.RowCount > 0)
            {
                btnXoaHH.Enabled = true;
                btnLuuHH.Enabled = true;
                btnSuaHH.Enabled = true;
                TinhTien();
            }
            else
            {
                btnXoaHH.Enabled = false;
                btnLuuHH.Visible = false;
                btnSuaHH.Enabled = false;
                btnLuu.Enabled = false;
                btnThemHH.Enabled = true;
                txtTongTien.Text = "0";
                txtGiamGia.Text = "0";
                txtConLai.Text = "0";
            }

           // txtTongTien.Text = TongTien().ToString("#########");
          //  TinhTien();
        }

        private void btnSuaHH_Click(object sender, EventArgs e)
        {

            dgvHoaDon.ReadOnly = false;
            btnLuu.Enabled = false;
            btnLuuHH.Show();
            btnSuaHH.Enabled = false;
            //txtTongTien.Text = TongTien().ToString("#########");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BUSLapHoaDon.Instance.HuyHoaDon(dgvHoaDon);
            txtTongTien.Text = "0";
            txtGiamGia.Text = "0";
            txtConLai.Text = "0";
            btnLuuHH.Visible = false;
            btnThemHH.Enabled = true;
            btnLuu.Enabled = false;
            btnXoaHH.Enabled = false;
            btnSuDungMGG.Enabled = true;
            btnSuaHH.Enabled = false;
            txtMaGiamGia.Text = "";
            lblHeSoGiam.Text = "";
            lblThongBaoGG .Text= "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            BUSLapHoaDon.Instance.HuyHoaDon(dgvHoaDon);
            txtTongTien.Text = "0";
            txtGiamGia.Text = "0";
            txtConLai.Text = "0";
            btnLuuHH.Visible = false;
            btnThemHH.Enabled = true;
            btnLuu.Enabled = false;
            btnXoaHH.Enabled = false;
            btnSuDungMGG.Enabled = true;
            btnSuaHH.Enabled = false;
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn lưu Hóa Đơn không?",
                "Lưu Hóa Đơn", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LuuHD();
                MessageBox.Show("Đã lưu Hóa đơn");
            }
        }
    }
}
