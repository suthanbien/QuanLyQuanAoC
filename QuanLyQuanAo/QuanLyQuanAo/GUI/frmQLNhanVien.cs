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
    public partial class frmQLNhanVien : Form
    {
        #region Khai báo biến
        private String m_MaNV;
        private String m_TenNV;
        private String[] OldNhanVien;
        private bool isEdit = false;
        #endregion

        #region Các phương thức

        private void LoadData()
        {
            BUSQLNhanVien   .Instance.GetNhanVien(dgvNhanVien);
            btgNhomLenh.Reccount = dgvNhanVien.RowCount;
            // MessageBox.Show(""+ dgvLoaiSanPham.RowCount);

            // btgNhomLenh.ds = dsLoaiSanPham;

            
            LoadAnh();
            LoadDuLieu();

        }
        private void LoadDuLieu()
        {
            if (btgNhomLenh.Reccount>0)
            {
                txtMaNV.DataBindings.Clear();
                txtMaNV.DataBindings.Add("text", dgvNhanVien.DataSource, "MaNhanVien");
                txtTenNV.DataBindings.Clear();
                txtTenNV.DataBindings.Add("text", dgvNhanVien.DataSource, "TenNhanVien");
                txtCMND.DataBindings.Clear();
                txtCMND.DataBindings.Add("text", dgvNhanVien.DataSource, "CMND");
                txtNgaySinh.DataBindings.Clear();
                txtNgaySinh.DataBindings.Add("text", dgvNhanVien.DataSource, "NgaySinh");
                txtGioiTinh.DataBindings.Clear();
                txtGioiTinh.DataBindings.Add("text", dgvNhanVien.DataSource, "GioiTinh");
                txtEmail.DataBindings.Clear();
                txtEmail.DataBindings.Add("text", dgvNhanVien.DataSource, "Email");
                txtChucVu.DataBindings.Clear();
                txtChucVu.DataBindings.Add("text", dgvNhanVien.DataSource, "ChucVu");
                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("text", dgvNhanVien.DataSource, "DiaChi");
                txtSDT.DataBindings.Clear();
                txtSDT.DataBindings.Add("text", dgvNhanVien.DataSource, "SoDT");
                txtAnh.DataBindings.Clear();
                txtAnh.DataBindings.Add("text", dgvNhanVien.DataSource, "Image");
                ricChuThich.DataBindings.Clear();
                ricChuThich.DataBindings.Add("text", dgvNhanVien.DataSource, "GhiChu");
            }
            else
            {
                txtMaNV.Text="";
                //txtMaNV.DataBindings.Add("text", dgvNhanVien.DataSource, "MaNhanVien");
                txtTenNV.Text = "";
                //txtTenNV.DataBindings.Add("text", dgvNhanVien.DataSource, "TenNhanVien");
                txtCMND.Text = "";
                //txtCMND.DataBindings.Add("text", dgvNhanVien.DataSource, "CMND");
                txtNgaySinh.Text = "";
                //txtNgaySinh.DataBindings.Add("text", dgvNhanVien.DataSource, "NgaySinh");
                txtGioiTinh.Text = "";
                // txtGioiTinh.DataBindings.Add("text", dgvNhanVien.DataSource, "GioiTinh");
                txtEmail.Text = "";
                //txtEmail.DataBindings.Add("text", dgvNhanVien.DataSource, "Email");
                txtChucVu.Text = "";
                //txtChucVu.DataBindings.Add("text", dgvNhanVien.DataSource, "ChucVu");
                txtDiaChi.Text = "";
                //txtDiaChi.DataBindings.Add("text", dgvNhanVien.DataSource, "DiaChi");
                txtSDT.Text = "";
                // txtSDT.DataBindings.Add("text", dgvNhanVien.DataSource, "SoDT");
                txtAnh.Text = "";
                // txtAnh.DataBindings.Add("text", dgvNhanVien.DataSource, "Image");
                ricChuThich.Text = "";
                // ricChuThich.DataBindings.Add("text", dgvNhanVien.DataSource, "GhiChu");
                picAnh.Image = null;
            }
        }

        private void DinhViLai(String m_TenNV)
        {

            for (int i = 0; i < btgNhomLenh.Reccount; i++)
                if (dgvNhanVien.Rows[i].Cells[1].Value.ToString().Trim() == m_TenNV.Trim())
                {

                    btgNhomLenh.Position = i;
                    dgvNhanVien.CurrentCell = dgvNhanVien.Rows[i].Cells[0];
                }
        }

        private void LoadAnh()
        {
            picAnh.Image = (Image)dgvNhanVien.Rows[btgNhomLenh.Position].Cells[13].Value;
        }

        #endregion


        public frmQLNhanVien()
        {
            InitializeComponent();
        }


        private void btgNhomLenh_Load(object sender, EventArgs e)
        {
            btgNhomLenh.dgv = dgvNhanVien;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            m_TenNV = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1].ToString();
            if (btgNhomLenh.Mode != 0)  //0: bình thường, 1 : thêm,2: sửa
            {
                if (dgvNhanVien.CurrentRow.Index != btgNhomLenh.Position)
                    dgvNhanVien.CurrentCell = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1];
            }


            if (dgvNhanVien.CurrentCell != null)
            {
                btgNhomLenh.Position = dgvNhanVien.CurrentCell.RowIndex;
            }
            m_MaNV = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[0].Value.ToString();
            if (btgNhomLenh.Mode == 0)
                btgNhomLenh.EnableButton(true);

            if (dgvNhanVien.CurrentCell.ColumnIndex == 2)
            {
                if (isEdit == true)
                {
                    DataGridViewComboBoxCell comboBoxCellLHH = new DataGridViewComboBoxCell();
                    BUSQLNhanVien.Instance.LoadComboBoxChucVu(comboBoxCellLHH);
                    dgvNhanVien[2, btgNhomLenh.Position] = comboBoxCellLHH;
                }
            }

            LoadAnh();

            
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            btgNhomLenh.EnableButton(true);
            btgNhomLenh.AddDataTimKiem(BUSQLNhanVien.Instance.ListTimTheoTen());
            m_TenNV = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1].ToString();
        }

        private void frmQLNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmMain)(this.MdiParent)).moMnuQLNhanVien();
        }

        private void dgvSanPham_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

            if (dgvNhanVien.CurrentCell.ColumnIndex == 3 ||
                dgvNhanVien.CurrentCell.ColumnIndex == 5 ||
                dgvNhanVien.CurrentCell.ColumnIndex == 7 ||
                dgvNhanVien.CurrentCell.ColumnIndex == 8 ||
                dgvNhanVien.CurrentCell.ColumnIndex == 10) //Desired Column
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
            if ((e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 47|| e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else 
            {
                e.Handled = true;
            }
        }

        //NhomLenh


        private void btgNhomLenh_Display(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Reccount > 0)
            {
                dgvNhanVien.CurrentCell = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[0];
                m_TenNV = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1].ToString();
                LoadAnh();
            }
                
        }

        private void btgNhomLenh_AddClick(object sender, ButtonGroupEventArgs e)
        {
            DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
            BUSQLNhanVien.Instance.AddRows(dgvNhanVien, comboBoxCell);
            btgNhomLenh.Position = btgNhomLenh.Reccount++;
            //MessageBox.Show("m " + btgNhomLenh.Position);
            dgvNhanVien.CurrentCell = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1];
            btgNhomLenh.Extra2Enabled = false;
            dgvNhanVien[2, btgNhomLenh.Position] = comboBoxCell;

        }

        private void btgNhomLenh_EditClick(object sender, ButtonGroupEventArgs e)
        {
            isEdit = true;
            OldNhanVien = new String[2];
            for (int i = 0; i < 2; i++)
                OldNhanVien[i] = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[i].Value.ToString();
            btgNhomLenh.Extra2Enabled = false;
            LoadDuLieu();
        }

        private void btgNhomLenh_SaveClick(object sender, ButtonGroupEventArgs e)
        {

            if (btgNhomLenh.Mode == 1) //lưu lúc thêm
            {
                bool tinhTrang;
                string tenNV = "", chucVu = "", 
               gioiTinh = "", email = "",diaChi = "", chuThich = "";
                string soDT;
                int maNV,cmnd;

                DateTime? ngaySinh, ngayVaoLam,ngayNghiLam;

                maNV = Convert.ToInt32(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[0].Value.ToString());
                tenNV = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1].Value.ToString();
                chucVu = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[2].Value.ToString();
                //ngaySinh=new DateTime( int.Parse(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[3].Value.ToString()));
                ngaySinh = Convert.ToDateTime(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[3].Value.ToString());
                gioiTinh = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[4].Value.ToString();
                cmnd = Convert.ToInt32(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[5].Value.ToString());
                email = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[6].Value.ToString();


                ngayVaoLam = Convert.ToDateTime(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[7].Value.ToString());

                ngayNghiLam = Convert.ToDateTime(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[8].Value.ToString());

                diaChi = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[9].Value.ToString();
                soDT = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[10].Value.ToString();
                tinhTrang = Convert.ToBoolean(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[11].Value);
                chuThich = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[12].Value.ToString();


                if (tenNV.Length > 0 && ngaySinh.ToString().Length > 0 &&
                    cmnd.ToString().Length>=9 && ngayVaoLam.ToString().Length > 0)
                {
                    DateTime ngaySinhNV, ngayVaoLamNV,ngayNghiLamNV;
                    if (ngayNghiLam.ToString().Length>0)
                    {
                        ngayNghiLamNV =Convert.ToDateTime( ngayNghiLam.ToString()) ;
                    }
                    ngaySinhNV = Convert.ToDateTime(ngaySinh.ToString());
                    ngayVaoLamNV = Convert.ToDateTime(ngayVaoLam.ToString());

                    if (ngaySinhNV.Year<(ngayVaoLamNV.Year-16))
                    {
                        if (BUSQLNhanVien.Instance.Them(maNV, tenNV, chucVu, ngaySinhNV, gioiTinh, cmnd,
                            email, ngayVaoLamNV, ngayNghiLam, diaChi, soDT, tinhTrang, chuThich)==true) 
                        {
                            LoadData();
                            DinhViLai(tenNV);
                            btgNhomLenh.CanSave = true;
                            btgNhomLenh.Extra2Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Email, SDT hoặc CMND trùng, nhân viên đã có trong hệ thống.","Lỗi");
                            btgNhomLenh.CanSave = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ngày vào làm phải lớn hơn ngày sinh, nhân viên phải trên 16 tuổi.");
                        btgNhomLenh.CanSave = false;
                    }

                             

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết\n Tên, ngày sinh, cmnd, ngày vào làm", "Lỗi");
                    btgNhomLenh.CanSave = false;
                }
            }
            else
            {
                bool tinhTrang;
                string tenNV = "", chucVu = "",
               gioiTinh = "", email = "", diaChi = "", chuThich = "";
                string soDT;
                int maNV, cmnd;

                DateTime? ngaySinh, ngayVaoLam, ngayNghiLam;
                if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1].Value == null)
                {
                    tenNV = "";
                }
                else
                {
                    tenNV = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1].Value.ToString();
                }
                if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[3].Value == null)
                {
                    ngaySinh = Convert.ToDateTime("1/1/1991");
                }
                else
                {
                    ngaySinh = Convert.ToDateTime(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[3].Value.ToString());
                }
                maNV = Convert.ToInt32(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[0].Value.ToString());
                
                chucVu = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[2].Value.ToString();
                //ngaySinh=new DateTime( int.Parse(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[3].Value.ToString()));
                if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[4].Value == null)
                {
                    gioiTinh = "nam";
                }
                else
                {
                    gioiTinh = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[4].Value.ToString();
                }
                maNV = Convert.ToInt32(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[0].Value.ToString());
                
               
                   if(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[6].Value == null)
                {
                    email = "";
                }
                else
                {
                    email = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[6].Value.ToString();
                }
                cmnd = Convert.ToInt32(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[5].Value.ToString());
                if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[6].Value==null)
                {
                    email ="" ;
                }
                else
                {
                    email = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[6].Value.ToString();
                }


                ngayVaoLam = Convert.ToDateTime(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[7].Value.ToString());
                if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[8].Value == null)
                {
                    ngayNghiLam = null;
                }
                else
                {
                    ngayNghiLam = Convert.ToDateTime(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[8].Value.ToString());
                }

                if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[9].Value == null)
                {
                    diaChi = "";
                }
                else
                {
                    diaChi = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[9].Value.ToString();
                }
                if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[10].Value == null)
                {
                    soDT = "";
                }
                else
                {
                    soDT = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[10].Value.ToString();
                }
                if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[12].Value == null)
                {
                    chuThich = "";
                }
                else
                {
                    chuThich = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[12].Value.ToString();
                }


                
                tinhTrang = Convert.ToBoolean(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[11].Value);
            


                if (tenNV.Length > 0 && ngaySinh.ToString().Length > 0 &&
                    cmnd.ToString().Length >= 9 && ngayVaoLam.ToString().Length > 0)
                {
                    DateTime ngaySinhNV, ngayVaoLamNV, ngayNghiLamNV;
                    if (ngayNghiLam.ToString().Length > 0)
                    {
                        ngayNghiLamNV = Convert.ToDateTime(ngayNghiLam.ToString());
                    }
                    ngaySinhNV = Convert.ToDateTime(ngaySinh.ToString());
                    ngayVaoLamNV = Convert.ToDateTime(ngayVaoLam.ToString());

                    if (ngaySinhNV.Year < (ngayVaoLamNV.Year - 16))
                    {

                        if (BUSQLNhanVien.Instance.Sua(maNV, tenNV, chucVu, ngaySinhNV, gioiTinh, cmnd,
                            email, ngayVaoLamNV, ngayNghiLam, diaChi, soDT, tinhTrang, chuThich) == true)
                        {
                            LoadData();
                            DinhViLai(tenNV);
                            btgNhomLenh.CanSave = true;
                            btgNhomLenh.Extra2Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Email, SDT hoặc CMND trùng, nhân viên đã có trong hệ thống.", "Lỗi");
                            btgNhomLenh.CanSave = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ngày vào làm phải lớn hơn ngày sinh, nhân viên phải trên 16 tuổi.");
                        btgNhomLenh.CanSave = false;
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết\n Tên, ngày sinh, cmnd, ngày vào làm", "Lỗi");
                    btgNhomLenh.CanSave = false;
                }
            }
        }

        private void btgNhomLenh_CancelClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Mode == 1) //trang thai 1: huy luc thêm
            {
                BUSQLNhanVien.Instance.DelRow(dgvNhanVien);
                dgvNhanVien.CurrentCell = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[0];
                btgNhomLenh.Extra2Enabled = true;
            }
            else   //trạng thái khác 1: hủy lúc sửa
            {
                isEdit = false;
                for (int i = 0; i < 2; i++)
                    dgvNhanVien.Rows[btgNhomLenh.Position].Cells[i].Value = OldNhanVien[i];
            }
        }

        private void btgNhomLenh_DeleteClick(object sender, ButtonGroupEventArgs e)
        {
            m_MaNV = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[0].Value.ToString();
            m_TenNV = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1].ToString();
            if (MessageBox.Show(
            "Có chắc chắn hủy nhân viên với mã số  " + m_MaNV + " không?",
            "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (BUSQLNhanVien.Instance.Xoa(Convert.ToInt32(m_MaNV)) == true)
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
                string tenNV = btgNhomLenh.TenTimKiem;
                btgNhomLenh.ModeADD = BUSQLNhanVien.Instance.TimTheoTen(tenNV, dgvNhanVien);


                btgNhomLenh.Reccount = dgvNhanVien.RowCount;
                btgNhomLenh.Position = 0;
                LoadDuLieu();

            }
            else
            {
                string maNV = btgNhomLenh.MaTimKiem;
                btgNhomLenh.ModeADD = BUSQLNhanVien.Instance.TimTheoMa(maNV, dgvNhanVien);


                btgNhomLenh.Reccount = dgvNhanVien.RowCount;
                btgNhomLenh.Position = 0;
                LoadDuLieu();
            }

        }

        private void btgNhomLenh_RadTimClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.ModeTimKiem == 1)
            {
                btgNhomLenh.ListTimKiem = BUSQLNhanVien.Instance.ListTimTheoTen();

            }
            else
            {
                btgNhomLenh.ListTimKiem = BUSQLNhanVien.Instance.ListTimTheoMa();

            }


        }

        private void btgNhomLenh_ExtraClick(object sender, ButtonGroupEventArgs e)
        {
            LoadData();
        }



        private void btgNhomLenh_Extra2Click(object sender, ButtonGroupEventArgs e)
        {
            frmAnhNV frm = new frmAnhNV();

            frm.MaNhanVien = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[0].Value.ToString();
       
            

            if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[8].Value == null)
            {
                frm.SoDT = "";
            }
            else
            {
                frm.SoDT = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[8].Value.ToString().Trim() + "";
            }
            if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[7].Value == null)
            {
                frm.DiaChi = "";
            }
            else
            {
                frm.DiaChi = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[7].Value.ToString().Trim();
            }
            if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[2].Value == null)
            {
                frm.ChucVu = "";
            }
            else
            {
                frm.ChucVu = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[2].Value.ToString();
            }
            if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[6].Value == null)
            {
                frm.Email = "";
            }
            else
            {
                frm.Email = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[6].Value.ToString();
            }
            if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[4].Value == null)
            {
                frm.GioiTinh = "";
            }
            else
            {
                frm.GioiTinh = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[4].Value.ToString();
            }
            if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[3].Value == null)
            {
                frm.NgaySinh = "";
            }
            else
            {
                frm.NgaySinh = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[3].Value.ToString().Trim();
            }
            if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[5].Value == null)
            {
                frm.CMND = "";
            }
            else
            {
                frm.CMND = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[5].Value.ToString().Trim();
            }
            if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[8].Value == null)
            {
                frm.TenNhanVien = "";
            }
            else
            {
                frm.TenNhanVien = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1].Value.ToString().Trim();
            }

            if (!dgvNhanVien.Rows[btgNhomLenh.Position].Cells[13].Equals(System.DBNull.Value))
            {
                frm.Image = (Image)dgvNhanVien.Rows[btgNhomLenh.Position].Cells[13].Value;
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                DinhViLai(m_TenNV);
            }
        }



    }
}
