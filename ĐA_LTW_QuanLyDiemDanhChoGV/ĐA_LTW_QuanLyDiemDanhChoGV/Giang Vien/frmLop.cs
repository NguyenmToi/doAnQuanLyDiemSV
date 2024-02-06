using BUS;
using DAO;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐA_LTW_QuanLyDiemDanhChoGV
{
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
       QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        LopBUS _LopBUS = new LopBUS();
        public frmLop()
        {
            InitializeComponent();
            LoadDSLop();
            LoadCBOLop();
            radTatCa.Checked = true;
        }


        public void LoadDSLop()
        {
            dgvLop.DataSource = _LopBUS.DSLOP();
        }
        public void LoadCBOLop()
        {
            cboMaLop.DataSource = DB.LOPs.Where(u => u.TRANGTHAI == false).ToList();
            cboMaLop.ValueMember = "MALOP";
            cboMaLop.DisplayMember = "MALOP";

            cboTenLop.DataSource = DB.LOPs.Where(u => u.TRANGTHAI == false).ToList();
            cboTenLop.ValueMember = "TENLOP";
            cboTenLop.DisplayMember = "TENLOP";

            cboTenNganh.DataSource = DB.NGANHs.Where(u => u.TRANGTHAI == false).ToList();
            cboTenNganh.ValueMember = "MANGANH";
            cboTenNganh.DisplayMember = "TENNGANH";

            cboNienKhoa.DataSource = DB.NIENKHOAs.Where(u => u.TRANGTHAI == false).ToList();
            cboNienKhoa.ValueMember = "MANIENKHOA";
            cboNienKhoa.DisplayMember = "TENNIENKHOA";

        }

        public void Res()
        {
            cboMaLop.SelectedIndex = 0;
            cboTenLop.SelectedIndex = 0;
            cboTenNganh.SelectedIndex = 0;
            cboNienKhoa.SelectedIndex = 0;
            txtGhiChu.Text = string.Empty;

            radMaLop.Checked = false;
            radNienKhoa.Checked = false;
            radGhiChu.Checked = false;
            radTenLop.Checked = false;
            radTenNganh.Checked = false;
            radTatCa.Checked = false;
        }
        private void frmLop_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaNienKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNganh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void btnTKHocKy_Click(object sender, EventArgs e)
        {

        }

        private void btnTKMSSV_Click(object sender, EventArgs e)
        {

        }

        private void btnTKLop_Click(object sender, EventArgs e)
        {

        }

        private void radMonHoc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radHocKy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void radMSSV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radLop_CheckedChanged(object sender, EventArgs e)
        {
            if (radMaLop.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_MaLop(cboMaLop.Text.Trim());
            }
        }



        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else if (dgvLop.SelectedRows.Count == 0)
            {
                dgvLop.ClearSelection();
                Res();
            }
            else
            {
                cboMaLop.Text = dgvLop.Rows[e.RowIndex].Cells[Constant.LOP_MaLop].Value.ToString();
                cboTenLop.Text = dgvLop.Rows[e.RowIndex].Cells[Constant.LOP_TenLop].Value.ToString();
                cboTenNganh.Text = dgvLop.Rows[e.RowIndex].Cells[Constant.LOP_TenNganh].Value.ToString();
                cboNienKhoa.Text = dgvLop.Rows[e.RowIndex].Cells[Constant.LOP_TenNienKhoa].Value.ToString();
                txtGhiChu.Text = dgvLop.Rows[e.RowIndex].Cells[Constant.LOP_GhiChu].Value.ToString();
            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTatCa.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP();
                
            }
        }

        private void radTenLop_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenLop.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_TenLop(cboTenLop.Text.Trim());
            }
        }

        private void cboTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTenLop.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_TenLop(cboTenLop.Text.Trim());
            }
        }

        private void radMaLop_CheckedChanged(object sender, EventArgs e)
        {
            if (radMaLop.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_MaLop(cboMaLop.Text.Trim());
            }
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radMaLop.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_MaLop(cboMaLop.Text.Trim());
            }
        }

        private void cboTenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTenNganh.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_TenNganh(cboTenNganh.Text.Trim());
            }
        }

        private void radTenNganh_CheckedChanged(object sender, EventArgs e)
        {
          if (radTenNganh.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_TenNganh(cboTenNganh.Text.Trim());
            }  
        }

        private void radNienKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (radNienKhoa.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_TenNienKhoa(cboNienKhoa.Text.Trim());
            }
        }

        private void cboNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radNienKhoa.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_TenNienKhoa(cboNienKhoa.Text.Trim());
            }
        }

        private void radGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_GhiChu(txtGhiChu.Text.Trim());
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_GhiChu(txtGhiChu.Text.Trim());
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_GhiChu(txtGhiChu.Text.Trim());
            }
            if (radNienKhoa.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_TenNienKhoa(cboNienKhoa.Text.Trim());
            }
            if (radTenNganh.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_TenNganh(cboTenNganh.Text.Trim());
            }
            if (radMaLop.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_MaLop(cboMaLop.Text.Trim());
            }
            if (radTenLop.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_TenLop(cboTenLop.Text.Trim());
            }
        }


    }
}