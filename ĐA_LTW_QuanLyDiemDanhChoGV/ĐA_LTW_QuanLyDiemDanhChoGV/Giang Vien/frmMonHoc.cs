using BUS;
using DAO;
using DevExpress.XtraEditors;
using DTO;
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
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        MonHocBUS _monHocBUS = new MonHocBUS();
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        public frmMonHoc()
        {
            InitializeComponent();
            LOADCBOMonHoc();
            LOADDSMonHoc();
            radTatCa.Checked = true;
        }

        private void frmMonHoc_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers==Keys.F5)
            {
                txtGhiChu.Text = "a";

            }    
        }

        public void LOADDSMonHoc()
        {
            dgvMonHoc.DataSource = _monHocBUS.DSMonHoc();
        }

        public void LOADCN()
        {
            LOADCBOMonHoc();
            LOADDSMonHoc();
            Rs();
            radTatCa.Checked = true;
        }

        public void Rs()
        {
            cboMaMonHoc.SelectedIndex = 0;
            cboTenMonHoc.SelectedIndex = 0;
            txtSoTinChi.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
        }

        public void LOADCBOMonHoc()
        {
            cboMaMonHoc.DataSource = DB.MONHOCs.Where(u => u.TRANGTHAI == false).ToList();
            cboMaMonHoc.DisplayMember = "MAMH";
            cboMaMonHoc.ValueMember = "MAMH";

            cboTenMonHoc.DataSource = DB.MONHOCs.Where(u => u.TRANGTHAI == false).ToList();
            cboTenMonHoc.DisplayMember = "TENMH";
            cboTenMonHoc.ValueMember = "TENMH";

        }


        private void txtSoTinChi_TextChanged(object sender, EventArgs e)
        {
            if (radSoTinChi.Checked && !string.IsNullOrEmpty(txtSoTinChi.Text))
            {
                dgvMonHoc.DataSource = _monHocBUS.DSMonHoc_SoTinChi(Int32.Parse(txtSoTinChi.Text.Trim()));
            }
            else
            {
                LOADDSMonHoc();
                return;
            }
        }

        private void txtSoTinChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void dgvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

            {
                cboMaMonHoc.Text = dgvMonHoc.Rows[e.RowIndex].Cells[Constant.MONHOC_MaMonHoc].Value.ToString();
                cboTenMonHoc.Text = dgvMonHoc.Rows[e.RowIndex].Cells[Constant.MONHOC_TenMonHoc].Value.ToString();
                txtSoTinChi.Text = dgvMonHoc.Rows[e.RowIndex].Cells[Constant.MONHOC_SoTinChi].Value.ToString();
                txtGhiChu.Text = dgvMonHoc.Rows[e.RowIndex].Cells[Constant.MONHOC_GhiChu].Value.ToString();
            }

        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LOADCN();
            radMaMonHoc.Checked = false;
            radTenMonHoc.Checked = false;
            radSoTinChi.Checked = false;
            radGhiChu.Checked = false;
        }

        private void radGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvMonHoc.DataSource = _monHocBUS.DSMonHoc_GhiChu(txtGhiChu.Text.Trim());
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvMonHoc.DataSource = _monHocBUS.DSMonHoc_GhiChu(txtGhiChu.Text.Trim());
            }
        }

        private void radMaMonHoc_CheckedChanged(object sender, EventArgs e)
        {
            if (radMaMonHoc.Checked)
            {
                dgvMonHoc.DataSource = _monHocBUS.DSMonHoc_MaMonHoc(cboMaMonHoc.Text.Trim());
            }
        }

        private void cboMaMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radMaMonHoc.Checked)
            {
                dgvMonHoc.DataSource = _monHocBUS.DSMonHoc_MaMonHoc(cboMaMonHoc.Text.Trim());
            }
        }

        private void radTenMonHoc_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenMonHoc.Checked)
            {
                dgvMonHoc.DataSource = _monHocBUS.DSMonHoc_TenMonHoc(cboTenMonHoc.Text.Trim());
                return;
            }
            else { return; }
        }

        private void cboTenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTenMonHoc.Checked)
            {
                dgvMonHoc.DataSource = _monHocBUS.DSMonHoc_TenMonHoc(cboTenMonHoc.Text.Trim());
                return;
            }
            else { return; }
        }

        private void radSoTinChi_CheckedChanged(object sender, EventArgs e)
        {
            if (radSoTinChi.Checked && !string.IsNullOrEmpty(txtSoTinChi.Text))
            {
                dgvMonHoc.DataSource = _monHocBUS.DSMonHoc_SoTinChi(Int32.Parse(txtSoTinChi.Text.Trim()));
            }
            else
            {
                LOADDSMonHoc();
                return;
            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if(radTatCa.Checked)
            {
                LOADCN();
            }    
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {

        }
    }
}