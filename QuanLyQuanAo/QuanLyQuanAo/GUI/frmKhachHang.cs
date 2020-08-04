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
    public partial class frmKhachHang : Form
    {
        #region Khai báo biến
        public static bool isDialog = false;
        private String m_MaKH;
        private String m_TenKH;
        private String[] OldNhanVien;
        private bool isEdit = false;
        #endregion

        #region Các phương thức

        private void LoadData()
        {
            BUSKhachHang.Instance.GetKhachHang(dgvNhanVien);
            btgNhomLenh.Reccount = dgvNhanVien.RowCount;
            // MessageBox.Show(""+ dgvLoaiSanPham.RowCount);

            // btgNhomLenh.ds = dsLoaiSanPham;


            LoadAnh();
            LoadDuLieu();

        }
        private void LoadDuLieu()
        {
            if (btgNhomLenh.Reccount > 0)
            {
                txtMaKH.DataBindings.Clear();
                txtMaKH.DataBindings.Add("text", dgvNhanVien.DataSource, "MaKhachHang");
                txtTenKH.DataBindings.Clear();
                txtTenKH.DataBindings.Add("text", dgvNhanVien.DataSource, "TenKhachHang");
                txtNgaySinh.DataBindings.Clear();
                txtNgaySinh.DataBindings.Add("text", dgvNhanVien.DataSource, "Ngaysinh");
                txtGioiTinh.DataBindings.Clear();
                txtGioiTinh.DataBindings.Add("text", dgvNhanVien.DataSource, "GioiTinh");
                txtEmail.DataBindings.Clear();
                txtEmail.DataBindings.Add("text", dgvNhanVien.DataSource, "Email");
                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("text", dgvNhanVien.DataSource, "DiaChi");
                txtSDT.DataBindings.Clear();
                txtSDT.DataBindings.Add("text", dgvNhanVien.DataSource, "SDT");
                txtLoaiKH.DataBindings.Clear();
                txtLoaiKH.DataBindings.Add("text", dgvNhanVien.DataSource, "LoaiKhachHang");
                txtAnh.DataBindings.Clear();
                ricChuThich.DataBindings.Clear();
                ricChuThich.DataBindings.Add("text", dgvNhanVien.DataSource, "GhiChu");
                txtAnh.DataBindings.Add("text", dgvNhanVien.DataSource, "Image");

            }
            else
            {
                txtMaKH.Text = "";
                //txtMaNV.DataBindings.Add("text", dgvNhanVien.DataSource, "MaNhanVien");
                txtTenKH.Text = "";
                //txtTenNV.DataBindings.Add("text", dgvNhanVien.DataSource, "TenNhanVien");
                txtNgaySinh.Text = "";
                //txtNgaySinh.DataBindings.Add("text", dgvNhanVien.DataSource, "NgaySinh");
                txtGioiTinh.Text = "";
                // txtGioiTinh.DataBindings.Add("text", dgvNhanVien.DataSource, "GioiTinh");
                txtEmail.Text = "";
                //txtEmail.DataBindings.Add("text", dgvNhanVien.DataSource, "Email");
                txtDiaChi.Text = "";
                //txtDiaChi.DataBindings.Add("text", dgvNhanVien.DataSource, "DiaChi");
                txtSDT.Text = "";
                // txtSDT.DataBindings.Add("text", dgvNhanVien.DataSource, "SDT");
                txtLoaiKH.Text = "";
                //txtChucVu.DataBindings.Add("text", dgvNhanVien.DataSource, "LoaiKhachHang");
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
                    dgvNhanVien.CurrentCell = dgvNhanVien.Rows[i].Cells[1];
                }
        }

        private void LoadAnh()
        {
          picAnh.Image = (Image)dgvNhanVien.Rows[btgNhomLenh.Position].Cells[9].Value;
        }

        #endregion


        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isDialog==false)
            {
              //  ((frmMain)(this.MdiParent)).moMnuQLKhachHang(true);
            }

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            btgNhomLenh.EnableButton(true);
            btgNhomLenh.AddDataTimKiem(BUSKhachHang.Instance.ListTimTheoTen());
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            m_TenKH = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1].ToString();
            if (btgNhomLenh.Mode != 0)  //0: bình thường, 1 : thêm,2: sửa
            {
                if (dgvNhanVien.CurrentRow.Index != btgNhomLenh.Position)
                    dgvNhanVien.CurrentCell = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1];
            }


            if (dgvNhanVien.CurrentCell != null)
            {
                btgNhomLenh.Position = dgvNhanVien.CurrentCell.RowIndex;
            }
            m_TenKH = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1].Value.ToString();
            if (btgNhomLenh.Mode == 0)
                btgNhomLenh.EnableButton(true);

            if (dgvNhanVien.CurrentCell.ColumnIndex == 7)
            {
                if (isEdit == true)
                {
                    DataGridViewComboBoxCell comboBoxCellLHH = new DataGridViewComboBoxCell();
                     BUSKhachHang.Instance.LoadComboBoxLoaiKH(comboBoxCellLHH);
                    dgvNhanVien[7, btgNhomLenh.Position] = comboBoxCellLHH;
                }
            }

            LoadAnh();

        }

        private void btgNhomLenh_AddClick(object sender, ButtonGroupEventArgs e)
        {
            DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
            BUSKhachHang.Instance.AddRows(dgvNhanVien, comboBoxCell);
            btgNhomLenh.Position = btgNhomLenh.Reccount++;
            //MessageBox.Show("m " + btgNhomLenh.Position);
            dgvNhanVien.CurrentCell = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1];
            btgNhomLenh.Extra2Enabled = false;
            dgvNhanVien[7, btgNhomLenh.Position] = comboBoxCell;
        }

        private void btgNhomLenh_CancelClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Mode == 1) //trang thai 1: huy luc thêm
            {
                BUSKhachHang.Instance.DelRow(dgvNhanVien);
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
            m_MaKH = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[0].Value.ToString();
            m_TenKH = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1].ToString();
            if (MessageBox.Show(
            "Có chắc chắn hủy nhân viên với mã số  " + m_MaKH + " không?",
            "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (BUSKhachHang.Instance.Xoa(Convert.ToInt32(m_MaKH)) == true)
                {
                    LoadData();
                }
                else
                {
                    MessageBox.Show("không thể xóa ràng buộc dữ liệu ");
                }

            }
        }

        private void btgNhomLenh_Display(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Reccount > 0)
            {
                dgvNhanVien.CurrentCell = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[0];
                m_TenKH = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1].ToString();
                LoadAnh();
            }
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

        private void btgNhomLenh_Extra2Click(object sender, ButtonGroupEventArgs e)
        {
           
            
        }

        private void btgNhomLenh_ExtraClick(object sender, ButtonGroupEventArgs e)
        {
            LoadData();
        }

        private void btgNhomLenh_RadTimClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.ModeTimKiem == 1)
            {
                btgNhomLenh.ListTimKiem = BUSKhachHang.Instance.ListTimTheoTen();

            }
            else
            {
                btgNhomLenh.ListTimKiem = BUSKhachHang.Instance.ListTimTheoMa();

            }
        }

        private void btgNhomLenh_SaveClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Mode == 1) //lưu lúc thêm
            {

                string tenKH = "", loaiKH = "",
               gioiTinh = "", email = "", diaChi = "", chuThich = "";
                string soDT;
                int maKH;
                DateTime? ngaySinh;




                maKH = Convert.ToInt32(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[0].Value.ToString());
                tenKH = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1].Value.ToString();
                loaiKH = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[7].Value.ToString();
                //ngaySinh=new DateTime( int.Parse(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[3].Value.ToString()));
                ngaySinh = Convert.ToDateTime(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[2].Value.ToString());
                gioiTinh = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[3].Value.ToString();

                email = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[4].Value.ToString();



                diaChi = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[5].Value.ToString();
                soDT = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[6].Value.ToString();

                chuThich = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[8].Value.ToString();


                if (tenKH.Length > 0 && ngaySinh.ToString().Length > 0)
                {
                    DateTime ngaySinhKH;

                    ngaySinhKH = Convert.ToDateTime(ngaySinh.ToString());

                    // MessageBox.Show(maKH + tenKH + ngaySinh + gioiTinh + email + diaChi + soDT + loaiKH + chuThich);

                    if (BUSKhachHang.Instance.Them(maKH, tenKH, ngaySinhKH, gioiTinh,
                        email, diaChi, soDT, loaiKH, chuThich) == true)
                    {
                        LoadData();
                        DinhViLai(tenKH);
                        btgNhomLenh.CanSave = true;
                        btgNhomLenh.Extra2Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Email, SDT trùng, nhân viên đã có trong hệ thống.", "Lỗi");
                        btgNhomLenh.CanSave = false;
                    }
                }



                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết\n Tên, ngày sinh, cmnd, ngày vào làm", "Lỗi");
                    btgNhomLenh.CanSave = false;
                }
            }
            else//che do 2: lưu lúc sửa
            {
                string tenKH = "", loaiKH = "",
               gioiTinh = "", email = "", diaChi = "", chuThich = "";
                string soDT;
                int maKH;
                DateTime? ngaySinh;


                if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1].Value == null)
                {
                    tenKH = "";
                }
                else
                {
                    tenKH = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[1].Value.ToString();
                }
                if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[2].Value == null)
                {
                    ngaySinh = Convert.ToDateTime("1/1/1991");
                }
                else
                {
                    ngaySinh = Convert.ToDateTime(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[2].Value.ToString());
                }
                maKH = Convert.ToInt32(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[0].Value.ToString());

                loaiKH = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[7].Value.ToString();
                //ngaySinh=new DateTime( int.Parse(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[3].Value.ToString()));
                if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[3].Value == null)
                {
                    gioiTinh = "nam";
                }
                else
                {
                    gioiTinh = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[3].Value.ToString();
                }
                maKH = Convert.ToInt32(dgvNhanVien.Rows[btgNhomLenh.Position].Cells[0].Value.ToString());


                if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[4].Value == null)
                {
                    email = "";
                }
                else
                {
                    email = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[4].Value.ToString();
                }

                if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[4].Value == null)
                {
                    email = "";
                }
                else
                {
                    email = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[4].Value.ToString();
                }

                if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[5].Value == null)
                {
                    diaChi = "";
                }
                else
                {
                    diaChi = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[5].Value.ToString();
                }
                if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[6].Value == null)
                {
                    soDT = "";
                }
                else
                {
                    soDT = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[6].Value.ToString();
                }
                if (dgvNhanVien.Rows[btgNhomLenh.Position].Cells[8].Value == null)
                {
                    chuThich = "";
                }
                else
                {
                    chuThich = dgvNhanVien.Rows[btgNhomLenh.Position].Cells[8].Value.ToString();
                }

                // MessageBox.Show(maKH + tenKH + ngaySinh + gioiTinh + email + diaChi + soDT + loaiKH + chuThich);


                if (tenKH.Length > 0 && ngaySinh.ToString().Length > 0)

                {
                    DateTime ngaySinhKH;

                    ngaySinhKH = Convert.ToDateTime(ngaySinh.ToString());


                    if (BUSKhachHang.Instance.Sua(maKH, tenKH, ngaySinhKH, gioiTinh,
                        email, diaChi, soDT, loaiKH, chuThich) == true)
                    {
                        LoadData();
                        DinhViLai(tenKH);
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
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết\n Tên, ngày sinh, cmnd, ngày vào làm", "Lỗi");
                btgNhomLenh.CanSave = false;
            }
        }
        }
        

        private void btgNhomLenh_TimKiemClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.ModeTimKiem == 1)
            {
                //MessageBox.Show("tim kiem theo tên" + btgNhomLenh.TenTimKiem);
                string tenNV = btgNhomLenh.TenTimKiem;
                btgNhomLenh.ModeADD = BUSKhachHang.Instance.TimTheoTen(tenNV, dgvNhanVien);


                btgNhomLenh.Reccount = dgvNhanVien.RowCount;
                btgNhomLenh.Position = 0;
                LoadDuLieu();

            }
            else
            {
                string maNV = btgNhomLenh.MaTimKiem;
                btgNhomLenh.ModeADD = BUSKhachHang.Instance.TimTheoMa(maNV, dgvNhanVien);


                btgNhomLenh.Reccount = dgvNhanVien.RowCount;
                btgNhomLenh.Position = 0;
                LoadDuLieu();
            }

        }

        private void btgNhomLenh_Load(object sender, EventArgs e)
        {
            btgNhomLenh.dgv = dgvNhanVien;
        }

        private void lblMLSP_Click(object sender, EventArgs e)
        {

        }
    }
}
