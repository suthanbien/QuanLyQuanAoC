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
    public partial class frmNhapHang : Form
    {
        #region Khai báo biến
        public static string m_MaNhanVien = "";
        private int mode = 0; //0: bthuong, 1 :sua
        private int modeXem = 0;
        private int modeTim = 1;
        private int position;
        private int positionCT;
        private String tongTienCu;
        private String tongTienMoi;
        private String giaCapNhat;
        private String giaCu;
       
        #endregion

        #region Các phương thức
        private void GetAllPhieuNhapChuaXN()
        {
            BUSNhapHang.Instance.GetAllPhieuNhapChuaXN(dgvPhieuNhapChuaXN);
        }
        private void GetAllPhieuNhapDaXN()
        {
            BUSNhapHang.Instance.GetAllPhieuNhapDaXN(dgvPhieuNhapDaXN);
        }
        private void GetChiTietPN(int maPN)
        {
            BUSNhapHang.Instance.GetChiTietPN(dgvChiTiet, maPN);
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
        private void GetNhanVien()
        {
            BUSPhieuNhap.Instance.GetNhanVien(m_MaNhanVien, txtMaNV, txtTenNV);
            // MessageBox.Show(m_MaNhanVien);   
        }
        private void TinhLaiTien(string _GiaCu,string _GiaCapNhat,int soLuong)
        {
            int giaCu1 = Convert.ToInt32(_GiaCu);
            int giaMoi = Convert.ToInt32(_GiaCapNhat);

            if (giaCu1!=giaMoi)
            {
                int tong = giaMoi*soLuong;
                int giaTriTang = giaMoi - giaCu1;
                dgvChiTiet.Rows[positionCT].Cells[6].Value = "" + tong;


                if (giaTriTang < 0)
                {
                    dgvChiTiet.Rows[positionCT].Cells[7].Value = "Giảm: "+giaTriTang;
                }
                else
                {
                    dgvChiTiet.Rows[positionCT].Cells[7].Value = "Tăng: "+giaTriTang;
                }
            }
        }
        private void CapNhatTongTienPN(int maPN)
        {
            int ttCu = Convert.ToInt32(tongTienCu);
            int ttMoi = Convert.ToInt32(tongTienMoi);
            string ghiChu = "";
            if (ttCu != ttMoi)
            {
                int giaTriTang = ttMoi - ttCu;
                //dgvChiTiet.Rows[positionCT].Cells[5].Value = "" + ttMoi;
                if (giaTriTang < 0)
                {     
                    ghiChu= "Giảm: " + giaTriTang;
                    BUSNhapHang.Instance.CapNhatTongTienPN(maPN, ttMoi, ghiChu);
                }
                else
                {
                    ghiChu = "Tăng: " + giaTriTang;
                    BUSNhapHang.Instance.CapNhatTongTienPN(maPN, ttMoi, ghiChu);

                }
            }
        }
        private void ResetChiTiet()
        {
            BUSNhapHang.Instance.ResetChiTiet(dgvChiTiet);
        }
        private void CapNhatPhieu()
        {
            txtTongTien.Text = BUSNhapHang.Instance.TongTien() + "";
            tongTienMoi = txtTongTien.Text;
        }
        #endregion
        #region Các Xử Lý 
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmMain)(this.MdiParent)).moMnuNhapHang();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            GetAllPhieuNhapChuaXN();
            GetAllPhieuNhapDaXN();
            GetNhanVien();
            dgvPhieuNhapDaXN.CurrentCell = null;
            dgvPhieuNhapChuaXN.CurrentCell = null;
            AddDataTimKiem(BUSNhapHang.Instance.ListTimTheoMa());
        }
        #endregion

        private void dgvPhieuNhapChuaXN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPhieuNhapDaXN.CurrentCell = null;
            modeXem = 1;
            int maPN;
            position = dgvPhieuNhapChuaXN.CurrentRow.Index;
            maPN = Convert.ToInt32(dgvPhieuNhapChuaXN.Rows[position].Cells[0].Value.ToString());
            tongTienCu = dgvPhieuNhapChuaXN.Rows[position].Cells[5].Value.ToString();
           // MessageBox.Show(tongTienCu);
            GetChiTietPN(maPN);
            btnHuyPhieu.Enabled = true;
            btnXacNhan.Enabled = true;
        }

        private void dgvPhieuNhapDaXN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPhieuNhapChuaXN.CurrentCell = null;
            modeXem = 2;
            int maPN;
            position = dgvPhieuNhapDaXN.CurrentRow.Index;
            maPN = Convert.ToInt32(dgvPhieuNhapDaXN.Rows[position].Cells[0].Value.ToString());
            //MessageBox.Show(maHD.ToString());
            GetChiTietPN(maPN);
            btnHuyPhieu.Enabled = false;
            btnXacNhan.Enabled = false;
            btnSuaGia.Enabled = false;
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modeXem==2)
            {
                btnHuyPhieu.Enabled = false;
                btnXacNhan.Enabled = false;
                btnSuaGia.Enabled = false;
            }
            else
            {
                btnSuaGia.Enabled = true;
            }
            if (mode==1)
            {
                if (dgvChiTiet.CurrentRow.Index != positionCT)
                    dgvChiTiet.CurrentCell = dgvChiTiet.Rows[positionCT].Cells[5];
            }
            else
            {
                int maHH;
                positionCT = dgvChiTiet.CurrentRow.Index;
                maHH = Convert.ToInt32(dgvChiTiet.Rows[positionCT].Cells[1].Value.ToString());
                //MessageBox.Show(maHD.ToString());
                txtMaHH.Text = maHH + "";

            }
        }

        private void btnSuaGia_Click(object sender, EventArgs e)
        {
            mode = 1;
            btnSuaGia.Visible = false;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
            positionCT= dgvChiTiet.CurrentRow.Index;
            giaCu = dgvChiTiet.Rows[positionCT].Cells[5].Value.ToString();
            dgvChiTiet.ReadOnly = false;
            dgvChiTiet.CurrentCell = dgvChiTiet.Rows[positionCT].Cells[5];
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            mode = 0;
            btnSuaGia.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
            dgvChiTiet.ReadOnly = true;
            positionCT = dgvChiTiet.CurrentRow.Index;
            dgvChiTiet.Rows[positionCT].Cells[5].Value = giaCu;
        }

        private void dgvChiTiet_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

            if ( dgvChiTiet.CurrentCell.ColumnIndex == 5 )   
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
            if ((e.KeyChar >= 48 && e.KeyChar <= 57  || e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int maPN, maHH, giaMoi;
            string chuThich;

            int soLuong = Convert.ToInt32(dgvChiTiet.Rows[positionCT].Cells[4].Value.ToString());
            mode = 0;
            btnSuaGia.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
            dgvChiTiet.ReadOnly = true;
            positionCT = dgvChiTiet.CurrentRow.Index;
            giaCapNhat = dgvChiTiet.Rows[positionCT].Cells[5].Value.ToString();

            TinhLaiTien(giaCu,giaCapNhat,soLuong);
            CapNhatPhieu();


            maPN = Convert.ToInt32(dgvChiTiet.Rows[positionCT].Cells[0].Value.ToString());
            maHH = Convert.ToInt32(dgvChiTiet.Rows[positionCT].Cells[1].Value.ToString());
            giaMoi = Convert.ToInt32(dgvChiTiet.Rows[positionCT].Cells[5].Value.ToString());
            chuThich = dgvChiTiet.Rows[positionCT].Cells[7].Value.ToString();
            if (BUSNhapHang.Instance.SuaPhieu(maPN, maHH, giaMoi, chuThich)==true)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
            GetChiTietPN(maPN);
            CapNhatTongTienPN(maPN);
            GetAllPhieuNhapChuaXN();
            GetAllPhieuNhapDaXN();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int maPN= Convert.ToInt32(dgvChiTiet.Rows[positionCT].Cells[0].Value.ToString());

            int maNV = Convert.ToInt32(txtMaNV.Text);
            DateTime ngayXacNhan = datePic.Value;

            if (MessageBox.Show("Có chắc chắn đã kiểm tra kỹ hàng hóa chưa?",
            "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (BUSNhapHang.Instance.XacNhanPhieu(maPN, maNV, ngayXacNhan) == true)
                {
                    GetAllPhieuNhapChuaXN();
                    GetAllPhieuNhapDaXN();
                    dgvPhieuNhapDaXN.CurrentCell = null;
                    dgvPhieuNhapChuaXN.CurrentCell = null;
                    ResetChiTiet();
                    MessageBox.Show("Xác nhận phiếu thành Công");
                }
                else
                {
                    MessageBox.Show("không thể xác nhận phiếu nhập này!!");
                }

            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
            int maPN = Convert.ToInt32(dgvPhieuNhapChuaXN.Rows[position].Cells[0].Value.ToString());
            if (MessageBox.Show("Bạn có chắc muốn hủy phiếu nhập "+maPN+" không?",
            "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (BUSNhapHang.Instance.HuyPhieu(maPN) == true)
                {
                    GetAllPhieuNhapChuaXN();
                    GetAllPhieuNhapDaXN();
                    dgvPhieuNhapDaXN.CurrentCell = null;
                    dgvPhieuNhapChuaXN.CurrentCell = null;
                    ResetChiTiet();
                    MessageBox.Show("Hủy thành Công");
                }
                else
                {
                    MessageBox.Show("không thể hủy phiếu nhập này!!");
                }

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            GetAllPhieuNhapChuaXN();
            GetAllPhieuNhapDaXN();
            dgvPhieuNhapDaXN.CurrentCell = null;
            dgvPhieuNhapChuaXN.CurrentCell = null;
            ResetChiTiet();
            txtTimKiem.Text = "";
        }

        private void radTim_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimTheoMa.Checked)
            {
                modeTim = 1;
                AddDataTimKiem(BUSNhapHang.Instance.ListTimTheoMa());
            }
            else if (radTimTheoNV.Checked)
            {
                modeTim = 2;
                AddDataTimKiem(BUSNhapHang.Instance.ListTimTheoNV());
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (modeTim == 1)
            {
                string maPN2 =""+ txtTimKiem.Text.Trim();
                BUSNhapHang.Instance.TimTheoMa(dgvPhieuNhapChuaXN,dgvPhieuNhapDaXN, maPN2);

                if (dgvPhieuNhapChuaXN.RowCount >= 1 || dgvPhieuNhapDaXN.RowCount >= 1 && !maPN2.Trim().Equals(""))
                {
                    try
                    {
                        int maPN = Convert.ToInt32(maPN2.ToString());
                        GetChiTietPN(maPN);
                    }
                    catch
                    {

                    }
                }
                else 
                {
                    ResetChiTiet();
                }
            }
            else if (modeTim == 2)
            {
                string keyTimKiem = txtTimKiem.Text;
                BUSNhapHang.Instance.TimTheoNV(dgvPhieuNhapChuaXN, dgvPhieuNhapDaXN, keyTimKiem);

/*                if (dgvPhieuNhapChuaXN.RowCount >= 1 || dgvPhieuNhapDaXN.RowCount >= 1)
                {
                    int maHD = Convert.ToInt32(dgvHoaDon.Rows[0].Cells[0].Value.ToString());
                    GetChiTietHD(maHD);
                }*/
            }
        }
    }
}
