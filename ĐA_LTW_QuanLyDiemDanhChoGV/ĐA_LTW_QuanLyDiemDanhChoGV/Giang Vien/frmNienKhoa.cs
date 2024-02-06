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
    public partial class frmNienKhoa : DevExpress.XtraEditors.XtraForm
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        NienKhoaBUS _nienKhoaBUS = new NienKhoaBUS();
        public frmNienKhoa()
        {
            InitializeComponent();
            LoadDSNienKhoa();
            LoadCBONienKhoa();
            radTatCa.Checked = true;
        }

        public void LoadDSNienKhoa()
        {
            dgvNienKhoa.DataSource = _nienKhoaBUS.DSNienKhoa();
        }
        public void LoadCN()
        {
            LoadCBONienKhoa();
            LoadDSNienKhoa();
            Res();
        }
        public void LoadCBONienKhoa()
        {
            cboMaNienKhoa.DataSource = DB.NIENKHOAs.Where(u => u.TRANGTHAI == false).ToList();
            cboMaNienKhoa.DisplayMember = "MANIENKHOA";
            cboMaNienKhoa.ValueMember = "MANIENKHOA";

            cboTenNienKhoa.DataSource = DB.NIENKHOAs.Where(u => u.TRANGTHAI == false).ToList();
            cboTenNienKhoa.DisplayMember = "TENNIENKHOA";
            cboTenNienKhoa.ValueMember = "TENNIENKHOA";
        }

        public void Res()
        {
            cboMaNienKhoa.SelectedIndex = 0;
            cboTenNienKhoa.SelectedIndex = 0;
            txtGhiChu.Text = string.Empty;


            radMaNienKhoa.Checked = false;
            radTenNienKhoa.Checked = false;
            radGhiChu.Checked = false;
            radTatCa.Checked = false;
        }

        private void dgvNienKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1) return;
            else if (dgvNienKhoa.SelectedRows.Count == 0)
            {
                dgvNienKhoa.ClearSelection();
                LoadCBONienKhoa();
                LoadDSNienKhoa();
            }
            else
            {
                cboMaNienKhoa.Text = dgvNienKhoa.Rows[e.RowIndex].Cells[Constant.NIENKHOA_MaNienKhoa].Value.ToString();
                cboTenNienKhoa.Text = dgvNienKhoa.Rows[e.RowIndex].Cells[Constant.NIENKHOA_TenNienKhoa].Value.ToString();
                txtGhiChu.Text = dgvNienKhoa.Rows[e.RowIndex].Cells[Constant.NIENKHOA_GhiChu].Value.ToString();
            }
        }
        private void radMaNienKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (radMaNienKhoa.Checked)
            {
                dgvNienKhoa.DataSource = _nienKhoaBUS.DSNienKhoa_MaNienKhoa(cboMaNienKhoa.Text);
            }
        }

        private void cboMaNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radMaNienKhoa.Checked)
            {
                dgvNienKhoa.DataSource = _nienKhoaBUS.DSNienKhoa_MaNienKhoa(cboMaNienKhoa.Text);
            }
        }

        private void radTenNienKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenNienKhoa.Checked)
            {
                dgvNienKhoa.DataSource = _nienKhoaBUS.DSNienKhoa_TenNienKhoa(cboTenNienKhoa.Text);
            }
        }

        private void cboTenNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTenNienKhoa.Checked)
            {
                dgvNienKhoa.DataSource = _nienKhoaBUS.DSNienKhoa_TenNienKhoa(cboTenNienKhoa.Text);
            }
        }

        private void radGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvNienKhoa.DataSource = _nienKhoaBUS.DSNienKhoa_GhiChu(txtGhiChu.Text);
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvNienKhoa.DataSource = _nienKhoaBUS.DSNienKhoa_GhiChu(txtGhiChu.Text);
            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            LoadDSNienKhoa();
        }
    }
}