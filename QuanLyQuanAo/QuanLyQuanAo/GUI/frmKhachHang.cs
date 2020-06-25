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
        private String m_MaNV;
        private String m_TenNV;
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
            /*if (btgNhomLenh.Reccount > 0)
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
                txtMaNV.Text = "";
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
            }*/
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
            picAnh.Image = (Image)dgvNhanVien.Rows[btgNhomLenh.Position].Cells[9].Value;
        }

        #endregion


        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isDialog=false)
            {
                ((frmMain)(this.MdiParent)).moMnuQLKhachHang(true);
            }

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btgNhomLenh_AddClick(object sender, ButtonGroupEventArgs e)
        {

        }

        private void btgNhomLenh_CancelClick(object sender, ButtonGroupEventArgs e)
        {

        }

        private void btgNhomLenh_DeleteClick(object sender, ButtonGroupEventArgs e)
        {

        }

        private void btgNhomLenh_Display(object sender, ButtonGroupEventArgs e)
        {

        }

        private void btgNhomLenh_EditClick(object sender, ButtonGroupEventArgs e)
        {

        }

        private void btgNhomLenh_Extra2Click(object sender, ButtonGroupEventArgs e)
        {

        }

        private void btgNhomLenh_ExtraClick(object sender, ButtonGroupEventArgs e)
        {

        }

        private void btgNhomLenh_RadTimClick(object sender, ButtonGroupEventArgs e)
        {

        }

        private void btgNhomLenh_SaveClick(object sender, ButtonGroupEventArgs e)
        {

        }

        private void btgNhomLenh_TimKiemClick(object sender, ButtonGroupEventArgs e)
        {

        }

        private void btgNhomLenh_Load(object sender, EventArgs e)
        {

        }
    }
}
