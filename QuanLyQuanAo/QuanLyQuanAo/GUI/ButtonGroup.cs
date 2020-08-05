using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.GUI
{
    public partial class ButtonGroup : UserControl
    {
        #region Khai báo biến
        private int m_Reccount = 0;
        private int m_Position = 0;
        private int m_ModeAdd = 0;
        private int m_ModeTimKiem = 1; //1: tim theo ten,2 :timTheo Ma
        private int m_Mode = 0;
        private string m_MaTimKiem="";
        private string m_TenTimKiem="";
        private DataGridView m_dgv;
        private string m_MsMau;
        private bool m_AutoNumber = false;
        private List<string> lstTimKiem;
        private bool m_CanSave=true;
        private bool m_CanDelete = true;

        #endregion
        public ButtonGroup()
        {
            InitializeComponent();
        }

        private void ButonGroup_Load(object sender, EventArgs e)
        {

        }
        // Khai báo các biến cố (event)
        public event ButtonGroupEventHandler Display; // Trình bày
        public event ButtonGroupEventHandler AddClick;
        public event ButtonGroupEventHandler EditClick;
        public event ButtonGroupEventHandler SaveClick;
        public event ButtonGroupEventHandler CancelClick;
        public event ButtonGroupEventHandler DeleteClick;
        public event ButtonGroupEventHandler TimKiemClick;
        public event ButtonGroupEventHandler ExtraClick;
        public event ButtonGroupEventHandler Extra2Click;
        public event ButtonGroupEventHandler RadTimClick;
        // Khai báo thể hiện ủy quyền


        public int Reccount
        {
            set { m_Reccount = value; }
            get { return m_Reccount; }
        }
        public int Position
        {
            set { m_Position = value; }
            get { return m_Position; }
        }
    
        public int Mode
        {
            set { m_Mode = value; }
            get { return m_Mode; }
        }
        public int ModeTimKiem
        {
            set { m_ModeTimKiem = value; }
            get { return m_ModeTimKiem; }
        }
        public int ModeADD
        {
            set { m_ModeAdd = value; }
            get { return m_ModeAdd; }
        }
        public DataGridView dgv
        {
            set { m_dgv = value; }
            get { return m_dgv; }
        }
        public List<string> ListTimKiem
        {
            set { lstTimKiem = value; }
            get { return lstTimKiem; }
        }
        public bool ExtraVisible
        {
            set { btnExtra.Visible = value; }
            get { return btnExtra.Visible; }
        }
        public bool ExtraEnabled
        {
            set { btnExtra.Enabled = value; }
            get { return btnExtra.Enabled; }
        }
        public string ExtraText
        {
            set { btnExtra.Text = value; }
            get { return btnExtra.Text; }
        }
        public bool Extra2Visible
        {
            set { btnExtra2.Visible = value; }
            get { return btnExtra2.Visible; }
        }
        public bool Extra2Enabled
        {
            set { btnExtra2.Enabled = value; }
            get { return btnExtra2.Enabled; }
        }
        public string Extra2Text
        {
            set { btnExtra2.Text = value; }
            get { return btnExtra2.Text; }
        }
        public string MsMau
        {
            set { m_MsMau = value; }
            get { return m_MsMau; }
        }
        public string MaTimKiem
        {
            set { m_MaTimKiem = value; }
            get { return m_MaTimKiem; }
        }
        public string TenTimKiem
        {
            set { m_TenTimKiem = value; }
            get { return m_TenTimKiem; }
        }
        public bool AutoNumber
        {
            set { m_AutoNumber = value; }
            get { return m_AutoNumber; }
        }
        public bool AddEnabled
        {
            set { btnAdd.Enabled = value; }
            get { return btnAdd.Enabled; }
        }
        public bool EditEnabled
        {
            set { btnEdit.Enabled = value; }
            get { return btnEdit.Enabled; }
        }

        public bool CanSave { get => m_CanSave; set => m_CanSave = value; }
        public bool CanDelete { get => m_CanDelete; set => m_CanDelete = value; }


        #region Các phương thức
        public void EnableButton(bool b)
        {
            //enable cho 4 nút diều kiển 
            btnFirst.Enabled = b && m_Reccount > 0 && m_Position > 0;
            btnPrev.Enabled = b && m_Reccount > 0 && m_Position > 0;
            btnNext.Enabled = b && m_Reccount > 0 && m_Position < m_Reccount - 1;
            btnLast.Enabled = b && m_Reccount > 0 && m_Position < m_Reccount - 1;

            btnAdd.Enabled = b && frmMain.quyen.Equals("1")|| b && frmMain.quyen.Equals("2"); // Add
            btnAdd.Visible = b;


            btnEdit.Enabled = b && m_Reccount > 0
            && frmMain.quyen.Equals("1") || b && frmMain.quyen.Equals("2"); // Edit
            btnEdit.Visible = b;
            btnSave.Enabled = !b;
            btnSave.Visible = !b;
            btnCancel.Enabled = !b;
            btnCancel.Visible = !b;
            btnTim.Enabled = b;
            txtTimKiem.Enabled = b;
            btnDelete.Enabled = b && m_Reccount > 0
            && frmMain.quyen.Equals("1") || b && frmMain.quyen.Equals("2"); // Delete
            //btnADMin.Enabled = b && m_Reccount > 0
           // && frmMain.QuyenNguoiSuDung(frmMain.TuCach, m_MsMau, 'P');
          btnExtra2.Enabled = b && (frmMain.quyen.Equals("1") || b && frmMain.quyen.Equals("2"));
        }
        public void EnableAddButton(bool b)
        {
           // btnAdd.Enabled = b;
        }
        private void OnDisplay(ButtonGroupEventArgs e) // On + Tên_biến_cố
        {
            ButtonGroupEventHandler handler = Display; // Có khả năng Display là null
            if (handler != null)
                handler(this, e); // Thực thi chương trình xử lý biến cố
            EnableButton(true);
        }
        private void OnAddClick(ButtonGroupEventArgs e)
        {
            ButtonGroupEventHandler handler = AddClick;
            if (handler != null)
                handler(this, e);

        }
        private void OnEditClick(ButtonGroupEventArgs e)

        {
            ButtonGroupEventHandler handler = EditClick;
            if (handler != null)
                handler(this, e);

        }
        private bool OnCanSave()
        {
            return CanSave;

        }
        private void OnSaveClick(ButtonGroupEventArgs e)

        {
            ButtonGroupEventHandler handler = SaveClick;
            if (handler != null)
                handler(this, e);

        }
        private void OnCancelClick(ButtonGroupEventArgs e)

        {
            ButtonGroupEventHandler handler = CancelClick;
            if (handler != null)
                handler(this, e);

        }
        private void OnActivateRow(int row)

        {
            dgv.ReadOnly = false;
            dgv.Columns[0].ReadOnly = true;
          //  dgv.Columns[1].ReadOnly = (m_Mode != 1) || m_AutoNumber;

        }
        private void OnDeactivateRow(int row)

        {
            dgv.ReadOnly = true;

        }
        private bool OnCanDelete()

        {
            return CanDelete;
        }
        private void OnDeleteClick(ButtonGroupEventArgs e)

        {
            ButtonGroupEventHandler handler = DeleteClick;
            if (handler != null)
                handler(this, e);

        }
        private void OnTimKiemClick(ButtonGroupEventArgs e)
        {
            ButtonGroupEventHandler handler = TimKiemClick;
            if (handler != null)
                handler(this, e);
        }
        private void OnRadTimClick(ButtonGroupEventArgs e)
        {
            ButtonGroupEventHandler handler = RadTimClick;
            if (handler != null)
                handler(this, e);
        }
        private void OnExtraClick(ButtonGroupEventArgs e)
        {
            ButtonGroupEventHandler handler = ExtraClick;
            if (handler != null)
                handler(this, e);
        }
        private void OnExtra2Click(ButtonGroupEventArgs e)
        {
            ButtonGroupEventHandler handler = Extra2Click;
            if (handler != null)
                handler(this, e);
        }

        public void AddDataTimKiem(List<string> lstTimKiem)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            for (int i = 0; i < lstTimKiem.Count(); i++)
            {
                collection.Add(lstTimKiem[i]);
                // MessageBox.Show("phan tu thu "+i+"la: "+ ListTimKiem[i]);
            }
            txtTimKiem.AutoCompleteCustomSource = collection;
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            m_Position = 0; // Về mẩu tin đầu tiên
            ButtonGroupEventArgs e1 = new ButtonGroupEventArgs();
            OnDisplay(e1); // Bẫy chương trình xử lý biến cố (nếu có)
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            m_Position--; // Trở về mẩu tin trước
            ButtonGroupEventArgs e1 = new ButtonGroupEventArgs();
            OnDisplay(e1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            m_Position++; // Sang mẩu tin kế tiếp
            ButtonGroupEventArgs e1 = new ButtonGroupEventArgs();
            OnDisplay(e1);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            m_Position = m_Reccount - 1; // Đi đến mẩu tin cuối cùng
            ButtonGroupEventArgs e1 = new ButtonGroupEventArgs();
            OnDisplay(e1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if (ModeADD == 0)
            {
                m_Mode = 1; // Đang thêm
                ButtonGroupEventArgs e1 = new ButtonGroupEventArgs();
                OnAddClick(e1);
                OnActivateRow(m_Position); // Có thể dưới dạng tham số khác
                EnableButton(false);
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            m_Mode = 2; // Đang sửa
            ButtonGroupEventArgs e1 = new ButtonGroupEventArgs();
            OnActivateRow(m_Position); // Có thể dưới dạng tham số khác
            OnEditClick(e1);
            EnableButton(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ButtonGroupEventArgs e1 = new ButtonGroupEventArgs();
            if (m_Mode == 1)
            { // Lưu lúc thêm
                OnSaveClick(e1);
                if (OnCanSave()==true)
                { // Lưu được lúc thêm
                   
                    m_Mode = 0; // Bình thường
                    OnDeactivateRow(m_Position);
                    EnableButton(true);
                }

            }
            else
            { // Lưu lúc sửa

                // MessageBox.Show(" lưu lúc sua", ParentForm.Text);
                OnSaveClick(e1);
                if (OnCanSave()==true)
                { // Lưu được lúc sửa
                    
                    m_Mode = 0; // Bình thường
                    OnDeactivateRow(m_Position);
                    EnableButton(true);
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonGroupEventArgs e1 = new ButtonGroupEventArgs();
            if (m_Mode == 1)
            { // Không lưu lúc thêm
                m_Reccount--;
                m_Position = m_Reccount - 1;
                dgv.CurrentCell = dgv.Rows[m_Position].Cells[1];
                OnCancelClick(e1);
                m_Mode = 0;
                OnDeactivateRow(m_Position); // Mới thêm
                EnableButton(true);
            }
            else
            { // Không lưu lúc sửa
                OnCancelClick(e1);
                m_Mode = 0;
                OnDeactivateRow(m_Position); // Mới thêm
                EnableButton(true);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ButtonGroupEventArgs e1 = new ButtonGroupEventArgs();
            if (OnCanDelete())
            {
                OnDeleteClick(e1);
                if (m_Position >= m_Reccount) m_Position = m_Reccount - 1;
                OnDisplay(e1);
            }
            else MessageBox.Show("Không thể hủy bỏ do ràng buộc cơ sở dữ liệu", ParentForm.Text);
        }

        private void btnExtra_Click(object sender, EventArgs e)
        {
            ButtonGroupEventArgs e1 = new ButtonGroupEventArgs();
            OnExtraClick(e1);
            OnDisplay(e1);
        }

        private void btnExtra2_Click(object sender, EventArgs e)
        {
            ButtonGroupEventArgs e1 = new ButtonGroupEventArgs();
            OnExtra2Click(e1);
            OnDisplay(e1);
        }

        private void ButtonGroup_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radTimTheoTen.Checked)
            {
                ModeTimKiem = 1;
                TenTimKiem = txtTimKiem.Text;
            }
            else
            {
                ModeTimKiem = 2;
                MaTimKiem=txtTimKiem.Text;
            }
            ButtonGroupEventArgs e1 = new ButtonGroupEventArgs();
            OnTimKiemClick(e1);
            OnDisplay(e1);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTim_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimTheoTen.Checked)
            {
                ModeTimKiem = 1;
            }
            else
            {
                ModeTimKiem = 2;
            }

            ButtonGroupEventArgs e1 = new ButtonGroupEventArgs();
            OnRadTimClick(e1);
            OnDisplay(e1);
            AddDataTimKiem(ListTimKiem);
        }
    }
}
