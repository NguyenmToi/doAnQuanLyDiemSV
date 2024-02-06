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
    public partial class frmGiangVien : DevExpress.XtraEditors.XtraForm
    {   
        QL_DIEMSVEntities DB= new QL_DIEMSVEntities();
        GiangVienBUS _giangVienBUS = new GiangVienBUS();
        
        public frmGiangVien()
        {
            InitializeComponent();
            LoadCBOGiangVien();
            Res();
            LoadDSGV();
            
        }

        public void LoadDSGV()
        {
            dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien();
        }

        public void LoadCBOGiangVien()
        {
            cboKhoa.DataSource = DB.KHOAs.Where(u => u.TRANGTHAI == false).ToList();
            cboKhoa.DisplayMember = "TENKHOA";
            cboKhoa.ValueMember = "MAKHOA";
        }

        public void Res()
        {
            cboKhoa.SelectedIndex = 0;
            txtGhiChu.Text = string.Empty;
            txtHoTenGiangVien.Text = string.Empty;
            txtMaGiangVien.Text = string.Empty;
            radNam.Checked = false;

            radKhoa.Checked = false;
            radGhiChu.Checked = false;
            radTatCa.Checked = false;
            radHoTenGiangVien.Checked = false;
            radMaGiangVien.Checked = false;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) /*return;*/
            //else if (dgvGiangVien.SelectedRows.Count == 0)
            {
                dgvGiangVien.ClearSelection();
                LoadCBOGiangVien();
                LoadDSGV();
            }
            else
            {
                txtMaGiangVien.Text = dgvGiangVien.Rows[e.RowIndex].Cells[Constant.GV_MaGV].Value.ToString();
                txtHoTenGiangVien.Text = dgvGiangVien.Rows[e.RowIndex].Cells[Constant.GV_HoTenGV].Value.ToString();
                txtGhiChu.Text = dgvGiangVien.Rows[e.RowIndex].Cells[Constant.GV_GhiChu].Value.ToString();
                cboKhoa.Text = dgvGiangVien.Rows[e.RowIndex].Cells[Constant.GV_Khoa].Value.ToString();
                bool gt = bool.Parse(dgvGiangVien.Rows[e.RowIndex].Cells[Constant.GV_GioiTinh].Value.ToString());
                if (gt == true ? radNam.Checked = true : radNu.Checked = true) ;

            }
        }

        private void radGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien_GhiChu(txtGhiChu.Text);
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien_GhiChu(txtGhiChu.Text);
            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            LoadDSGV();
            LoadCBOGiangVien();
        }


        private void radMaGiangVien_CheckedChanged(object sender, EventArgs e)
        {
            if (radMaGiangVien.Checked)
            {
                dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien_MaGV(txtMaGiangVien.Text.Trim());
            }
        }

        private void txtMaGiangVien_TextChanged(object sender, EventArgs e)
        {
            if (radMaGiangVien.Checked)
            {
                dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien_MaGV(txtMaGiangVien.Text.Trim());
            }
        }

        private void radHoTenGiangVien_CheckedChanged(object sender, EventArgs e)
        {
            if (radHoTenGiangVien.Checked)
            {
                dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien_HoTenGV(txtHoTenGiangVien.Text.Trim());
            }
        }

        private void txtHoTenGiangVien_TextChanged(object sender, EventArgs e)
        {
            if (radHoTenGiangVien.Checked)
            {
                dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien_HoTenGV(txtHoTenGiangVien.Text.Trim());
            }
        }

        private void radKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (radKhoa.Checked)
            {
                if (!string.IsNullOrEmpty(cboKhoa.Text.Trim()) && radKhoa.Checked)
                {

                    if (cboKhoa.SelectedValue == null) { return; }
                    else
                    {
                        string a = cboKhoa.SelectedValue.ToString();
                        if (_giangVienBUS.DSGiangVien_Khoa(a) != null)
                        {
                            dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien_Khoa(a);
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }

                }
                else
                {
                    LoadDSGV();
                    return;
                }

            }
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radKhoa.Checked)
            {
                if (!string.IsNullOrEmpty(cboKhoa.Text.Trim()) && radKhoa.Checked)
                {

                    if (cboKhoa.SelectedValue == null) { return; }
                    else
                    {
                        string a = cboKhoa.SelectedValue.ToString();
                        if (_giangVienBUS.DSGiangVien_Khoa(a) != null)
                        {
                            dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien_Khoa(a);
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }

                }
                else
                {
                    LoadDSGV();
                    return;
                }

            }
        }

    }
}