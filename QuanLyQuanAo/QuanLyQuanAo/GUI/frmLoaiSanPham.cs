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
    public partial class frmLoaiSanPham : Form
    {

        #region Khai báo biến
        //private SqlConnection conn = new SqlConnection(MainForm.ConnStr);
       // private int m_CurrColumn = 0;
        private String m_MLSP;
        private String[] OldLoaiSanPham;
        #endregion

        #region Các phương thức
        private void LoadData()
        {
            BUSLoaiSanPham.Instance.GetLoaiSanPham(dgvLoaiSanPham);
            btgNhomLenh.Reccount = dgvLoaiSanPham.RowCount;
           // MessageBox.Show(""+ dgvLoaiSanPham.RowCount);

           // btgNhomLenh.ds = dsLoaiSanPham;
        }
        private void DinhViLai(String m_MLSP)
        {
            
            for (int i = 0; i < btgNhomLenh.Reccount; i++)
                if (dgvLoaiSanPham.Rows[i].Cells[0].Value.ToString().Trim() == m_MLSP.Trim())
                {
                   
                    btgNhomLenh.Position = i;
                    dgvLoaiSanPham.CurrentCell = dgvLoaiSanPham.Rows[i].Cells[0];
                }
        }
        #endregion


        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            this.btgNhomLenh.CanSave += new ButtonGroupCanDoDelegate(this.btgNhomLenh_CanSave);
            this.btgNhomLenh.CanDelete += new ButtonGroupCanDoDelegate(this.btgNhomLenh_CanDelete);
            LoadData();
            btgNhomLenh.EnableButton(true);
            btgNhomLenh.AddDataTimKiem( BUSLoaiSanPham.Instance.ListTimTheoTen());
            btgNhomLenh.ExtraVisible = true;
            btgNhomLenh.ExtraText = "Làm Mới";
        }

        private void btgNhomLenh_Load(object sender, EventArgs e)
        {
            btgNhomLenh.dgv = dgvLoaiSanPham;
        }

        private void btgNhomLenh_Display(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Reccount > 0)
                dgvLoaiSanPham.CurrentCell = dgvLoaiSanPham.Rows[btgNhomLenh.Position].Cells[0];
        }

        private void btgNhomLenh_AddClick(object sender, ButtonGroupEventArgs e)
        {
                // MessageBox.Show("c " + btgNhomLenh.Reccount);
                BUSLoaiSanPham.Instance.AddRows(dgvLoaiSanPham);
                btgNhomLenh.Position = btgNhomLenh.Reccount++;
                //MessageBox.Show("m " + btgNhomLenh.Position);
                dgvLoaiSanPham.CurrentCell = dgvLoaiSanPham.Rows[btgNhomLenh.Position].Cells[1];

        }


        private void btgNhomLenh_EditClick(object sender, ButtonGroupEventArgs e)
        {
            OldLoaiSanPham = new String[2];
            for (int i = 0; i < 2; i++)
                OldLoaiSanPham[i] = dgvLoaiSanPham.Rows[btgNhomLenh.Position].Cells[i].Value.ToString();
        }
        private void btgNhomLenh_SaveClick(object sender, ButtonGroupEventArgs e)
        {
            
            if (btgNhomLenh.Mode == 1) //lưu lúc thêm
            {
                string tenLSP;
                int maLSP;
                maLSP = Convert.ToInt32(dgvLoaiSanPham.Rows[btgNhomLenh.Position].Cells[0].Value.ToString());
                tenLSP = dgvLoaiSanPham.Rows[btgNhomLenh.Position].Cells[1].Value.ToString();
               //MessageBox.Show( tenLSP);
                BUSLoaiSanPham.Instance.Them(maLSP,tenLSP);
                LoadData();
                DinhViLai(m_MLSP);
            }
            else
            {
                string tenLSP;
                int maLSP;
                maLSP = Convert.ToInt32(dgvLoaiSanPham.Rows[btgNhomLenh.Position].Cells[0].Value.ToString());
                tenLSP = dgvLoaiSanPham.Rows[btgNhomLenh.Position].Cells[1].Value.ToString();
                BUSLoaiSanPham.Instance.Sua(maLSP,tenLSP);
                LoadData();
                DinhViLai(m_MLSP);
            }
        }
        private void btgNhomLenh_CancelClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Mode == 1) //trang thai 1: huy luc thêm
            {
                BUSLoaiSanPham.Instance.GetLoaiSanPham(dgvLoaiSanPham);
                dgvLoaiSanPham.CurrentCell = dgvLoaiSanPham.Rows[btgNhomLenh.Position].Cells[0];
            }
            else   //trạng thái khác 1: hủy lúc sửa
            {
                for (int i = 0; i < 2; i++)
                   dgvLoaiSanPham.Rows[btgNhomLenh.Position].Cells[i].Value = OldLoaiSanPham[i];
            }
        }
        private void btgNhomLenh_DeleteClick(object sender, ButtonGroupEventArgs e)
        {
            m_MLSP = dgvLoaiSanPham.Rows[btgNhomLenh.Position].Cells[0].Value.ToString().Trim();
            if (MessageBox.Show(
            "Có chắc chắn hủy bỏ loại sản phẩm với mã số  " + m_MLSP + " không?",
            "Nhà xuất bản", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (BUSLoaiSanPham.Instance.Xoa(Convert.ToInt32(m_MLSP))==true)
                {
                    LoadData();
                }
                else
                {
                    MessageBox.Show("không thể xóa ràng buộc dữ liệu");
                }
               
            }
        }
        private bool btgNhomLenh_CanSave(object sender, ButtonGroupEventArgs e)
        {
            
            return true;
        }
        private bool btgNhomLenh_CanDelete(object sender, ButtonGroupEventArgs e)
        {
            
            return true;
        }

        private void dgvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btgNhomLenh.Mode != 0)  //0: bình thường, 1 : thêm,2: sửa
            {
                if (dgvLoaiSanPham.CurrentRow.Index != btgNhomLenh.Position)
                    dgvLoaiSanPham.CurrentCell = dgvLoaiSanPham.Rows[btgNhomLenh.Position].Cells[1];
            }


            if (dgvLoaiSanPham.CurrentCell != null)
            {
                btgNhomLenh.Position = dgvLoaiSanPham.CurrentCell.RowIndex;
            }
            m_MLSP = dgvLoaiSanPham.Rows[btgNhomLenh.Position].Cells[0].Value.ToString();
            if (btgNhomLenh.Mode == 0)
                btgNhomLenh.EnableButton(true);
        }

        private void btgNhomLenh_TimKiemClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.ModeTimKiem==1)
            {
                //MessageBox.Show("tim kiem theo tên" + btgNhomLenh.TenTimKiem);
                string tenLSP = btgNhomLenh.TenTimKiem;
                btgNhomLenh.ModeADD = BUSLoaiSanPham.Instance.TimTheoTen(tenLSP,dgvLoaiSanPham);


                btgNhomLenh.Reccount = dgvLoaiSanPham.RowCount;
                btgNhomLenh.Position = 0;
                
            }
            else
            {
                string maLSP = btgNhomLenh.MaTimKiem ;
                btgNhomLenh.ModeADD = BUSLoaiSanPham.Instance.TimTheoMa(maLSP, dgvLoaiSanPham);


                btgNhomLenh.Reccount = dgvLoaiSanPham.RowCount;
                btgNhomLenh.Position = 0;
            }
            
        }

        private void frmLoaiSanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmMain)(this.MdiParent)).moMnuLoaiSanPham();
        }

        private void btgNhomLenh_RadTimClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.ModeTimKiem==1)
            {
                btgNhomLenh.ListTimKiem = BUSLoaiSanPham.Instance.ListTimTheoTen();
               
            }
            else
            {
                btgNhomLenh.ListTimKiem = BUSLoaiSanPham.Instance.ListTimTheoMa();

            }
            
            
        }

        private void btgNhomLenh_ExtraClick(object sender, ButtonGroupEventArgs e)
        {
            LoadData();
        }
    }
}
