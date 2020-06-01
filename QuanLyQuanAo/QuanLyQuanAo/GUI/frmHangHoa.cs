using QuanLyQuanAo.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.GUI
{
    public partial class frmHangHoa : Form
    {
        #region Khai báo biến
        private String m_MaHH;
        private String m_TenHH;
        private String[] OldHangHoa;
        private bool isEdit=false;
        private bool isOpen=true;
        #endregion

        #region Các phương thức
        private void LoadData()
        {
            List<string> lstLoaiHH = new List<string>();
            BUSHangHoa.Instance.GetHangHoa(dgvSanPham);
            lstLoaiHH.Add("Tất Cả");

            btgNhomLenh.Reccount = dgvSanPham.RowCount;
            // MessageBox.Show(""+ dgvLoaiSanPham.RowCount);

            // btgNhomLenh.ds = dsLoaiSanPham;

            LoadDuLieu();

            lstLoaiHH.AddRange( BUSHangHoa.Instance.GetListLoaiHH());
            cboLoaiHH.DataSource = lstLoaiHH;
            LoadAnh();
           

        }
        private void LoadDuLieu()
        {
            txtMaHH.DataBindings.Clear();
            txtMaHH.DataBindings.Add("text", dgvSanPham.DataSource, "MaHangHoa");
            txtTenHH.DataBindings.Clear();
            txtTenHH.DataBindings.Add("text", dgvSanPham.DataSource, "TenHangHoa");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("text", dgvSanPham.DataSource, "SoLuongCon");
            txtLoaiHH.DataBindings.Clear();
            txtLoaiHH.DataBindings.Add("text", dgvSanPham.DataSource, "LoaiHangHoa");
            txtHangSX.DataBindings.Clear();
            txtHangSX.DataBindings.Add("text", dgvSanPham.DataSource, "HangSanXuat");
            txtGiaNhap.DataBindings.Clear();
            txtGiaNhap.DataBindings.Add("text", dgvSanPham.DataSource, "GiaNhap");
            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("text", dgvSanPham.DataSource, "GiaBan");
            txtAnh.DataBindings.Clear();
            txtAnh.DataBindings.Add("text", dgvSanPham.DataSource, "Image");
            ricChuThich.DataBindings.Clear();
            ricChuThich.DataBindings.Add("text", dgvSanPham.DataSource, "ChuThich");
        }

        private void DinhViLai(String m_TenHH)
        {

            for (int i = 0; i < btgNhomLenh.Reccount; i++)
                if (dgvSanPham.Rows[i].Cells[1].Value.ToString().Trim() == m_TenHH.Trim())
                {

                    btgNhomLenh.Position = i;
                    dgvSanPham.CurrentCell = dgvSanPham.Rows[i].Cells[0];
                }
        }
        private void LoadAnh()
        {
                picAnh.Image = (Image)dgvSanPham.Rows[btgNhomLenh.Position].Cells[9].Value;
            
           
        }
        #endregion
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmMain)(this.MdiParent)).moMnuSanPham();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
             LoadData();
             btgNhomLenh.EnableButton(true);
             btgNhomLenh.AddDataTimKiem(BUSHangHoa.Instance.ListTimTheoTen());
               m_TenHH = dgvSanPham.Rows[btgNhomLenh.Position].Cells[1].ToString();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            m_TenHH = dgvSanPham.Rows[btgNhomLenh.Position].Cells[1].ToString();
            if (btgNhomLenh.Mode != 0)  //0: bình thường, 1 : thêm,2: sửa
            {
                if (dgvSanPham.CurrentRow.Index != btgNhomLenh.Position)
                    dgvSanPham.CurrentCell = dgvSanPham.Rows[btgNhomLenh.Position].Cells[1];
            }


            if (dgvSanPham.CurrentCell != null)
            {
                btgNhomLenh.Position = dgvSanPham.CurrentCell.RowIndex;
            }
            m_MaHH = dgvSanPham.Rows[btgNhomLenh.Position].Cells[0].Value.ToString();
            if (btgNhomLenh.Mode == 0)
                btgNhomLenh.EnableButton(true);

            if (dgvSanPham.CurrentCell.ColumnIndex == 2)
            {
                if (isEdit == true)
                {
                    DataGridViewComboBoxCell comboBoxCellLHH = new DataGridViewComboBoxCell();
                    BUSHangHoa.Instance.LoadComboBoxLoaiHH(comboBoxCellLHH);
                    dgvSanPham[2, btgNhomLenh.Position] = comboBoxCellLHH;
                }
            }

            if (dgvSanPham.CurrentCell.ColumnIndex == 3)
            {
                if (isEdit == true)
                {
                    DataGridViewComboBoxCell comboBoxCellHSX = new DataGridViewComboBoxCell();
                    BUSHangHoa.Instance.LoadComboBoxTenHSX(comboBoxCellHSX);
                    dgvSanPham[3, btgNhomLenh.Position] = comboBoxCellHSX;
                }
            }
            LoadAnh();
            LoadDuLieu();

        }

        private void dgvSanPham_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

            if (dgvSanPham.CurrentCell.ColumnIndex == 4 ||
                dgvSanPham.CurrentCell.ColumnIndex == 5 ||
                dgvSanPham.CurrentCell.ColumnIndex == 6) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
            TextBox tb1 = e.Control as TextBox;
            if (tb1 != null)
            {
                tb1.Text = "";
            }
        }
        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //NhomLenh
        private void btgNhomLenh_Load(object sender, EventArgs e)
        {
            btgNhomLenh.dgv = dgvSanPham;
        }

        private void btgNhomLenh_Display(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Reccount > 0)
            {
                dgvSanPham.CurrentCell = dgvSanPham.Rows[btgNhomLenh.Position].Cells[0];
                m_TenHH = dgvSanPham.Rows[btgNhomLenh.Position].Cells[1].ToString();
                LoadAnh();
                LoadDuLieu();
            }
               
        }

        private void btgNhomLenh_AddClick(object sender, ButtonGroupEventArgs e)
        {
            DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
            DataGridViewComboBoxCell comboBoxCell2 = new DataGridViewComboBoxCell();
            BUSHangHoa.Instance.AddRows(dgvSanPham, comboBoxCell, comboBoxCell2);
            btgNhomLenh.Position = btgNhomLenh.Reccount++;
            //MessageBox.Show("m " + btgNhomLenh.Position);
            dgvSanPham.CurrentCell = dgvSanPham.Rows[btgNhomLenh.Position].Cells[1];
            btgNhomLenh.Extra2Enabled = false;

            dgvSanPham[ 3, btgNhomLenh.Position] = comboBoxCell;
            dgvSanPham[2, btgNhomLenh.Position] = comboBoxCell2;
            //BUSHangHoa.Instance.GetValueHangSanXuat(dgvSanPham[3, btgNhomLenh.Position]);
        }

        private void btgNhomLenh_EditClick(object sender, ButtonGroupEventArgs e)
        {
            isEdit = true;
            OldHangHoa = new String[2];
            for (int i = 0; i < 2; i++)
                OldHangHoa[i] = dgvSanPham.Rows[btgNhomLenh.Position].Cells[i].Value.ToString();
            btgNhomLenh.Extra2Enabled = false;

        }

        private void btgNhomLenh_SaveClick(object sender, ButtonGroupEventArgs e)
        {

            if (btgNhomLenh.Mode == 1) //lưu lúc thêm
            {
                bool tinhTrang;
                string tenHH = "", loaiHH = "", hangSanXuat = "", chuThich = "";
                int maHH, giaNhap = 0, giaBan = 0, soLuongCon;
                tenHH = dgvSanPham.Rows[btgNhomLenh.Position].Cells[1].Value.ToString();
                maHH = Convert.ToInt32(dgvSanPham.Rows[btgNhomLenh.Position].Cells[0].Value.ToString());
                giaNhap = Convert.ToInt32(dgvSanPham.Rows[btgNhomLenh.Position].Cells[4].Value.ToString());
                giaBan = Convert.ToInt32(dgvSanPham.Rows[btgNhomLenh.Position].Cells[5].Value.ToString());
                soLuongCon = Convert.ToInt32(dgvSanPham.Rows[btgNhomLenh.Position].Cells[6].Value.ToString());
                loaiHH = dgvSanPham.Rows[btgNhomLenh.Position].Cells[2].Value.ToString();
                hangSanXuat = dgvSanPham.Rows[btgNhomLenh.Position].Cells[3].Value.ToString();
                tinhTrang = Convert.ToBoolean(dgvSanPham.Rows[btgNhomLenh.Position].Cells[7].Value);
                chuThich = dgvSanPham.Rows[btgNhomLenh.Position].Cells[8].Value.ToString();
                if (tenHH.Length>0&& hangSanXuat.Length>0&& loaiHH.Length>0)
                {
                    if (giaNhap > 10000 && giaBan > 10000)
                    {
                        if (soLuongCon > 10)
                        {

                            BUSHangHoa.Instance.Them( maHH,  tenHH,  loaiHH,  hangSanXuat,  giaNhap,  giaBan,  soLuongCon,  tinhTrang,  chuThich);
                            LoadData();
                            DinhViLai(tenHH);
                            btgNhomLenh.CanSave = true;
                            btgNhomLenh.Extra2Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Số Lượng Phải lớn Hơn 100", "Lỗi");
                            btgNhomLenh.CanSave = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giá Nhập Phải lớn Hơn 10000", "Lỗi");
                        btgNhomLenh.CanSave = false;
                    }
                    

                }
                else
                {
                    MessageBox.Show("Tên hàng hóa, loại hàng hóa, hãng sản xuất không được để trống", "Lỗi");
                    btgNhomLenh.CanSave = false;
                }
            }
            else
            {
                bool tinhTrang;
                string tenHH = "", loaiHH = "", hangSanXuat = "", chuThich = "";
                int maHH, giaNhap = 0, giaBan = 0, soLuongCon;
                tenHH = dgvSanPham.Rows[btgNhomLenh.Position].Cells[1].Value.ToString();
                maHH = Convert.ToInt32(dgvSanPham.Rows[btgNhomLenh.Position].Cells[0].Value.ToString());
                giaNhap = Convert.ToInt32(dgvSanPham.Rows[btgNhomLenh.Position].Cells[4].Value.ToString());
                giaBan = Convert.ToInt32(dgvSanPham.Rows[btgNhomLenh.Position].Cells[5].Value.ToString());
                soLuongCon = Convert.ToInt32(dgvSanPham.Rows[btgNhomLenh.Position].Cells[6].Value.ToString());
                loaiHH = dgvSanPham.Rows[btgNhomLenh.Position].Cells[2].Value.ToString();
                hangSanXuat = dgvSanPham.Rows[btgNhomLenh.Position].Cells[3].Value.ToString();
                tinhTrang = Convert.ToBoolean(dgvSanPham.Rows[btgNhomLenh.Position].Cells[7].Value);
                chuThich = dgvSanPham.Rows[btgNhomLenh.Position].Cells[8].Value.ToString();
                if (tenHH.Length > 0 && hangSanXuat.Length > 0 && loaiHH.Length > 0)
                {
                    if (giaNhap > 10000 && giaBan > 10000)
                    {
                        if (soLuongCon > 10)
                        {

                            BUSHangHoa.Instance.Sua(maHH, tenHH, loaiHH, hangSanXuat, giaNhap, giaBan, soLuongCon, tinhTrang, chuThich);
                            LoadData();
                            DinhViLai(tenHH);
                            btgNhomLenh.CanSave = true;
                            isEdit = false;
                            btgNhomLenh.Extra2Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Số Lượng Phải lớn Hơn 100", "Lỗi");
                            btgNhomLenh.CanSave = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giá Nhập Phải lớn Hơn 10000", "Lỗi");
                        btgNhomLenh.CanSave = false;
                    }


                }
                else
                {
                    MessageBox.Show("Tên hàng hóa, loại hàng hóa, hãng sản xuất không được để trống", "Lỗi");
                    btgNhomLenh.CanSave = false;
                }
            }
        }

        private void btgNhomLenh_CancelClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Mode == 1) //trang thai 1: huy luc thêm
            {
                BUSHangHoa.Instance.DelRow(dgvSanPham);
                dgvSanPham.CurrentCell = dgvSanPham.Rows[btgNhomLenh.Position].Cells[0];
                btgNhomLenh.Extra2Enabled = true;
            }
            else   //trạng thái khác 1: hủy lúc sửa
            {
                isEdit = false;
                for (int i = 0; i < 2; i++)
                    dgvSanPham.Rows[btgNhomLenh.Position].Cells[i].Value = OldHangHoa[i];
            }
        }

        private void btgNhomLenh_DeleteClick(object sender, ButtonGroupEventArgs e)
        {
            m_MaHH = dgvSanPham.Rows[btgNhomLenh.Position].Cells[0].Value.ToString().Trim();
            m_TenHH = dgvSanPham.Rows[btgNhomLenh.Position].Cells[1].ToString();
            if (MessageBox.Show(
            "Có chắc chắn hủy bỏ món hàng với mã số  " + m_MaHH + " không?",
            "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (BUSHangHoa.Instance.Xoa(Convert.ToInt32(m_MaHH)) == true)
                {
                    LoadData();
                }
                else
                {
                    MessageBox.Show("không thể xóa ràng buộc dữ liệu ");
                }

            }
        }


        private void btgNhomLenh_TimKiemClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.ModeTimKiem == 1)
            {
                //MessageBox.Show("tim kiem theo tên" + btgNhomLenh.TenTimKiem);
                string tenHH = btgNhomLenh.TenTimKiem;
                btgNhomLenh.ModeADD = BUSHangHoa.Instance.TimTheoTen(tenHH, dgvSanPham);


                btgNhomLenh.Reccount = dgvSanPham.RowCount;
               // MessageBox.Show(btgNhomLenh.Reccount + "");
                btgNhomLenh.Position = 0;

            }
            else
            {
                string maHH = btgNhomLenh.MaTimKiem;
                btgNhomLenh.ModeADD = BUSHangHoa.Instance.TimTheoMa(maHH, dgvSanPham);


                btgNhomLenh.Reccount = dgvSanPham.RowCount;
                //MessageBox.Show(btgNhomLenh.Reccount + "");
                btgNhomLenh.Position = 0;
            }

        }

        private void btgNhomLenh_RadTimClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.ModeTimKiem == 1)
            {
                btgNhomLenh.ListTimKiem = BUSHangHoa.Instance.ListTimTheoTen();

            }
            else
            {
                btgNhomLenh.ListTimKiem = BUSHangHoa.Instance.ListTimTheoMa();

            }


        }

        private void btgNhomLenh_ExtraClick(object sender, ButtonGroupEventArgs e)
        {
            LoadData();
        }

        

        private void btgNhomLenh_Extra2Click(object sender, ButtonGroupEventArgs e)
        {
            frmAnhHH frm = new frmAnhHH();

            frm.MaHangHoa = dgvSanPham.Rows[btgNhomLenh.Position].Cells[0].Value.ToString();
            frm.TenHangHoa = dgvSanPham.Rows[btgNhomLenh.Position].Cells[1].Value.ToString().Trim();
            frm.LoaiHangHoa = dgvSanPham.Rows[btgNhomLenh.Position].Cells[2].Value.ToString().Trim();
            frm.HangSanXuat = dgvSanPham.Rows[btgNhomLenh.Position].Cells[3].Value.ToString().Trim();
            frm.GiaNhap = dgvSanPham.Rows[btgNhomLenh.Position].Cells[4].Value.ToString();
            frm.GiaBan = dgvSanPham.Rows[btgNhomLenh.Position].Cells[5].Value.ToString();
            frm.SoLuongCon = dgvSanPham.Rows[btgNhomLenh.Position].Cells[6].Value.ToString();
            frm.TenHangHoa = dgvSanPham.Rows[btgNhomLenh.Position].Cells[7].Value.ToString().Trim();
            frm.ChuThich = dgvSanPham.Rows[btgNhomLenh.Position].Cells[8].Value.ToString().Trim();
           
            if (!dgvSanPham.Rows[btgNhomLenh.Position].Cells[9].Equals(System.DBNull.Value))
            {
                frm.Image = (Image)dgvSanPham.Rows[btgNhomLenh.Position].Cells[9].Value;
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                DinhViLai(m_TenHH);
            }
        }

        private void cboLoaiHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isOpen==false)
            {
                string loaiHH = cboLoaiHH.SelectedValue.ToString();
                BUSHangHoa.Instance.GetHangHoaTheoLoai(loaiHH, dgvSanPham);
                btgNhomLenh.Reccount = dgvSanPham.RowCount;
                // MessageBox.Show(btgNhomLenh.Reccount + "");
                btgNhomLenh.Position = 0;
                //LoadAnh();
            }
            

        }

        private void cboLoaiHH_Click(object sender, EventArgs e)
        {
            isOpen = false;
            
        }
    }
}
