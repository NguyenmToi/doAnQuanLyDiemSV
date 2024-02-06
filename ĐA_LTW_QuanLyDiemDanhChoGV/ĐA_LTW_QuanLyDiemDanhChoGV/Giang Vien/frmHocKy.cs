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
    public partial class frmHocKy : DevExpress.XtraEditors.XtraForm
    {
        HocKyBUS _HocKyBUS = new HocKyBUS();
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        public frmHocKy()
        {
            InitializeComponent();
            LoadDSHK();
            Res();
            radTatCa.Checked = true;
        }


        public void LoadDSHK()
        {
            dgvHocKy.DataSource = _HocKyBUS.DSHocKy();
        }
        private void LoadCBO_HocKy()
        {
            cboMaHocKy.DataSource = DB.HOCKies.Where(u => u.TRANGTHAI == false).ToList();
            cboMaHocKy.ValueMember = "MAHOCKY";
            cboMaHocKy.DisplayMember = "MAHOCKY";

            cboTenHocKy.DataSource = DB.HOCKies.Where(u => u.TRANGTHAI == false).ToList();
            cboTenHocKy.ValueMember = "TENHOCKY";
            cboTenHocKy.DisplayMember = "TENHOCKY";
        }
        public void Res()
        {
            txtGhiChu.Text = string.Empty;
            LoadCBO_HocKy();
            cboMaHocKy.SelectedIndex = 0;
            cboTenHocKy.SelectedIndex = 0;
        }

        private void dgvHocKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else if (dgvHocKy.SelectedRows.Count == 0)
            {
                dgvHocKy.ClearSelection();
                Res();
            }
            else
            {
                radMaHocKy.Checked = false;
                radTenHocKy.Checked = false;
                radGhiChu.Checked = false;
                radTatCa.Checked = false;
                cboMaHocKy.Text = dgvHocKy.Rows[e.RowIndex].Cells[Constant.HOCKY_MaHocKy].Value.ToString();
                cboTenHocKy.Text = dgvHocKy.Rows[e.RowIndex].Cells[Constant.HOCKY_TenHocKy].Value.ToString();
                txtGhiChu.Text = dgvHocKy.Rows[e.RowIndex].Cells[Constant.HOCKY_GhiChu].Value.ToString();
            }
        }
        private void radMaHocKy_CheckedChanged(object sender, EventArgs e)
        {
            if (radMaHocKy.Checked)
            {
                dgvHocKy.DataSource = _HocKyBUS.DSHOCKY_MaHocKy(cboMaHocKy.Text.Trim());
            }
        }

        private void cboMaHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radMaHocKy.Checked)
            {
                dgvHocKy.DataSource = _HocKyBUS.DSHOCKY_MaHocKy(cboMaHocKy.Text.Trim());
            }
        }

        private void radTenHocKy_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenHocKy.Checked)
            {
                dgvHocKy.DataSource = _HocKyBUS.DSHOCKY_TenHocKy(cboTenHocKy.Text.Trim());
            }
        }

        private void cboTenHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTenHocKy.Checked)
            {
                dgvHocKy.DataSource = _HocKyBUS.DSHOCKY_TenHocKy(cboTenHocKy.Text.Trim());
            }
        }

        private void radGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvHocKy.DataSource = _HocKyBUS.DSHOCKY_GhiChu(txtGhiChu.Text.Trim());
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvHocKy.DataSource = _HocKyBUS.DSHOCKY_GhiChu(txtGhiChu.Text.Trim());
            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTatCa.Checked)
            {
                dgvHocKy.DataSource = _HocKyBUS.DSHocKy();
                Res();
                radMaHocKy.Checked = false;
                radTenHocKy.Checked = false;
                radGhiChu.Checked = false;
                
            }
        }
    }
}