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
    public partial class frmNganh : DevExpress.XtraEditors.XtraForm
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        NganhBUS _nganhBUS = new NganhBUS();
        public frmNganh()
        {
            InitializeComponent();
            LoadDSNganh();
            LoadCBONganh();
            radTatCa.Checked = true;
        }
        public void LoadDSNganh()
        {
            dgvNganh.DataSource = _nganhBUS.DSNganh();
        }
        public void LoadCBONganh()
        {
            cboMaNganh.DataSource = DB.NGANHs.Where(u => u.TRANGTHAI == false).ToList();
            cboMaNganh.DisplayMember = "MANGANH";
            cboMaNganh.ValueMember = "MANGANH";

            cboTenNganh.DataSource = DB.NGANHs.Where(u => u.TRANGTHAI == false).ToList();
            cboTenNganh.DisplayMember = "TENNGANH";
            cboTenNganh.ValueMember = "TENNGANH";

            cboTenKhoa.DataSource = DB.KHOAs.Where(u => u.TRANGTHAI == false).ToList();
            cboTenKhoa.DisplayMember = "TENKHOA";
            cboTenKhoa.ValueMember = "MAKHOA";
        }
        public void Res()
        {
            cboMaNganh.SelectedIndex = 0;
            cboTenNganh.SelectedIndex = 0;
            cboTenKhoa.SelectedIndex = 0;
            txtGhiChu.Text = string.Empty;

            radMaNganh.Checked = false;
            radTenNganh.Checked = false;
            radGhiChu.Checked = false;
            radTatCa.Checked = false;
            radTenKhoa.Checked = false;
        }

        private void dgvNganh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else if (dgvNganh.SelectedRows.Count == 0)
            {
                dgvNganh.ClearSelection();
                LoadCBONganh();
                LoadDSNganh();
            }
            else
            {
                cboMaNganh.Text = dgvNganh.Rows[e.RowIndex].Cells[Constant.NGANH_MaNganh].Value.ToString();
                cboTenKhoa.Text = dgvNganh.Rows[e.RowIndex].Cells[Constant.NGANH_TenKhoa].Value.ToString();
                cboTenNganh.Text = dgvNganh.Rows[e.RowIndex].Cells[Constant.NGANH_TenNganh].Value.ToString();
                txtGhiChu.Text = dgvNganh.Rows[e.RowIndex].Cells[Constant.NGANH_GhiChu].Value.ToString();
            }
        }
        private void radGhiChu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvNganh.DataSource = _nganhBUS.DSNganh_GhiChu(txtGhiChu.Text);
            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            LoadDSNganh();
        }
        private void radMaNganh_CheckedChanged(object sender, EventArgs e)
        {
            if (radMaNganh.Checked)
            {
                dgvNganh.DataSource = _nganhBUS.DSNganh_MaNganh(cboMaNganh.Text.Trim());
            }
        }

        private void cboMaNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radMaNganh.Checked)
            {
                dgvNganh.DataSource = _nganhBUS.DSNganh_MaNganh(cboMaNganh.Text.Trim());
            }
        }

        private void cboTenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTenNganh.Checked)
            {
                dgvNganh.DataSource = _nganhBUS.DSNganh_TenNganh(cboTenNganh.Text.Trim());
            }
        }

        private void radTenNganh_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenNganh.Checked)
            {
                dgvNganh.DataSource = _nganhBUS.DSNganh_TenNganh(cboTenNganh.Text.Trim());
            }
        }

        private void radTenKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenKhoa.Checked)
            {
                dgvNganh.DataSource = _nganhBUS.DSNganh_TenKhoa(cboTenKhoa.Text.Trim());
            }
        }

        private void cboTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTenKhoa.Checked)
            {
                dgvNganh.DataSource = _nganhBUS.DSNganh_TenKhoa(cboTenKhoa.Text.Trim());
            }
        }

        private void frmNganh_Load(object sender, EventArgs e)
        {

        }
    }
}