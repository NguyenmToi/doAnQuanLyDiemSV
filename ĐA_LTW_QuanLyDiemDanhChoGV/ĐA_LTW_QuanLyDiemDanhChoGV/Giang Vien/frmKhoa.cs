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
    public partial class frmKhoa : DevExpress.XtraEditors.XtraForm
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        KhoaBUS _KhoaBUS = new KhoaBUS();
        public frmKhoa()
        {
            InitializeComponent();
            LoadDSKhoa();
            Res();
            radTatCa.Checked = true;
        }

        public void LoadDSKhoa()
        {
            dgvKhoa.DataSource = _KhoaBUS.DSKhoa();
        }
        private void LoadCBO_Khoa()
        {
            cboMaKhoa.DataSource = DB.KHOAs.Where(u => u.TRANGTHAI == false).ToList();
            cboMaKhoa.ValueMember = "MAKHOA";
            cboMaKhoa.DisplayMember = "MAKHOA";

            cboTenKhoa.DataSource = DB.KHOAs.Where(u => u.TRANGTHAI == false).ToList();
            cboTenKhoa.ValueMember = "TENKHOA";
            cboTenKhoa.DisplayMember = "TENKHOA";
        }

        public void Res()
        {
            txtGhiChu.Text = string.Empty;
            LoadCBO_Khoa();
            radMaKhoa.Checked = false;
            radTenKhoa.Checked = false;
            radGhiChu.Checked = false;
            radTatCa.Checked = false;
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTatCa.Checked)
            {
                LoadDSKhoa();
                Res();

            }
        }

        private void radTenKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenKhoa.Checked)
            {
                dgvKhoa.DataSource = _KhoaBUS.DSKHOA_TenKhoa(cboTenKhoa.Text.Trim());
            }
        }

        private void cboTenKhoa_TextChanged(object sender, EventArgs e)
        {
            if (radTenKhoa.Checked)
            {
                dgvKhoa.DataSource = _KhoaBUS.DSKHOA_TenKhoa(cboTenKhoa.Text.Trim());
            }
        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else if (dgvKhoa.SelectedRows.Count == 0)
            {
                dgvKhoa.ClearSelection();
                Res();
            }
            else
            {
                cboMaKhoa.Text = dgvKhoa.Rows[e.RowIndex].Cells[Constant.KHOA_MaKhoa].Value.ToString();
                cboTenKhoa.Text = dgvKhoa.Rows[e.RowIndex].Cells[Constant.KHOA_TenKhoa].Value.ToString();
                txtGhiChu.Text = dgvKhoa.Rows[e.RowIndex].Cells[Constant.KHOA_GhiChu].Value.ToString();
            }
        }

        private void cboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radMaKhoa.Checked)
            {
                dgvKhoa.DataSource = _KhoaBUS.DSKHOA_MaKhoa(cboMaKhoa.Text.Trim());
            }
        }

        private void radMaKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if(radMaKhoa.Checked)
            {
                dgvKhoa.DataSource = _KhoaBUS.DSKHOA_MaKhoa(cboMaKhoa.Text.Trim());
            }
        }

        private void radGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvKhoa.DataSource = _KhoaBUS.DSKHOA_GhiChu(txtGhiChu.Text.Trim());
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

                if (radGhiChu.Checked)
                {
                    dgvKhoa.DataSource = _KhoaBUS.DSKHOA_GhiChu(txtGhiChu.Text.Trim());
                }
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {

        }
    }
}