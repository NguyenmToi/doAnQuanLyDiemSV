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

namespace ĐA_LTW_QuanLyDiemDanhChoGV.Giang_Vien
{
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        SinhVienBUS _sinhVienBUS = new SinhVienBUS();
        public frmSinhVien()
        {
            InitializeComponent();
            DSSinhVien();
            LoadCBOSinhVien();
            lbltk2.Text = dgvSinhVien.Rows.Count.ToString();
            lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            Rs();
        }

        public void DSSinhVien()
        {
            dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien();

        }

        public void LoadCBOSinhVien()
        {
            cboLop.DataSource = DB.LOPs.Where(u => u.TRANGTHAI == false).ToList();
            cboLop.ValueMember = "MALOP";
            cboLop.DisplayMember = "TENLOP";
            cboLop.SelectedIndex = 0;

            cboNganh.DataSource = DB.NGANHs.Where(u => u.TRANGTHAI == false).ToList();
            cboNganh.ValueMember = "MANGANH";
            cboNganh.DisplayMember = "TENNGANH";
            cboNganh.SelectedIndex = 0;

            cboNienKhoa.DataSource = DB.NIENKHOAs.Where(u => u.TRANGTHAI == false).ToList();
            cboNienKhoa.ValueMember = "MANIENKHOA";
            cboNienKhoa.DisplayMember = "TENNIENKHOA";
            cboNienKhoa.SelectedIndex = 0;
        }

        public void Rs()
        {
            txtMSSV.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDanToc.Text = string.Empty;
            txtSoCCCD.Text = string.Empty;
            cboLop.SelectedIndex = 0;
            cboNganh.SelectedIndex = 0;
            cboNienKhoa.SelectedIndex = 0;
            radNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;


        }

        private void dgvDSSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else
            {
                txtMSSV.Text = dgvSinhVien.Rows[e.RowIndex].Cells[Constant.SV_MSSV].Value.ToString();
                txtHoTen.Text = dgvSinhVien.Rows[e.RowIndex].Cells[Constant.SV_HoTen].Value.ToString();
                txtSoCCCD.Text = dgvSinhVien.Rows[e.RowIndex].Cells[Constant.SV_CCCD].Value.ToString();
                txtEmail.Text = dgvSinhVien.Rows[e.RowIndex].Cells[Constant.SV_Email].Value.ToString();
                dtpNgaySinh.Text = dgvSinhVien.Rows[e.RowIndex].Cells[Constant.SV_NgaySinh].Value.ToString();
                txtDanToc.Text = dgvSinhVien.Rows[e.RowIndex].Cells[Constant.SV_DanToc].Value.ToString();
                txtDiaChi.Text = dgvSinhVien.Rows[e.RowIndex].Cells[Constant.SV_DiaChi].Value.ToString();
                txtGhiChu.Text = dgvSinhVien.Rows[e.RowIndex].Cells[Constant.SV_GhiChu].Value.ToString();
                cboLop.Text = dgvSinhVien.Rows[e.RowIndex].Cells[Constant.SV_Lop].Value.ToString();
                cboNganh.Text = dgvSinhVien.Rows[e.RowIndex].Cells[Constant.SV_Nganh].Value.ToString();
                cboNienKhoa.Text = dgvSinhVien.Rows[e.RowIndex].Cells[Constant.SV_NienKhoa].Value.ToString();
                bool gt = bool.Parse(dgvSinhVien.Rows[e.RowIndex].Cells[Constant.SV_GIOITINH].Value.ToString());
                if (gt == true ? radNam.Checked = true : radNu.Checked = true) ;

            }
        }

        private void radLop_CheckedChanged(object sender, EventArgs e)
        {
            if (radLop.Checked)
            {
                string a = cboLop.SelectedValue.ToString();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_Lop(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {
                return;
            }
        }
        private void txtSoCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMSSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            string a = txtMSSV.Text;

            if (!string.IsNullOrEmpty(a))
            {
                string loc = new string(a.Where(c => char.IsLetterOrDigit(c)).ToArray());

                if (loc != a)
                {
                    txtMSSV.Text = loc;
                    txtMSSV.Select(loc.Length, 0);
                }
            }
        }



        private void radMSSV_CheckedChanged(object sender, EventArgs e)
        {
            if (radMSSV.Checked)
            {
                string a = txtMSSV.Text.Trim();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_MSSV(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {
                return;
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radLop.Checked)
            {
                string a = cboLop.SelectedValue.ToString();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_Lop(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {
                return;
            }
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            if (radMSSV.Checked)
            {
                string a = txtMSSV.Text.Trim();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_MSSV(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {
                return;
            }
        }

        private void radHoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (radHoTen.Checked == true)
            {
                string a = txtHoTen.Text.Trim();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_HoTen(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {
                return;
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            if (radHoTen.Checked == true)
            {
                string a = txtHoTen.Text.Trim();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_HoTen(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {
                return;
            }
        }

        private void radSoCCCD_CheckedChanged(object sender, EventArgs e)
        {
            if (radSoCCCD.Checked)
            {
                string a = txtSoCCCD.Text.Trim();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_CCCD(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {
                return;
            }
        }

        private void txtSoCCCD_TextChanged(object sender, EventArgs e)
        {
            if (radSoCCCD.Checked)
            {
                string a = txtSoCCCD.Text.Trim();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_CCCD(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {
                return;
            }
        }

        private void radEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (radEmail.Checked)
            {
                string a = txtEmail.Text.Trim();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_Email(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {
                return;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (radEmail.Checked)
            {
                string a = txtEmail.Text.Trim();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_Email(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {
                return;
            }
        }

        private void radNganh_CheckedChanged(object sender, EventArgs e)
        {
            if (radNganh.Checked)
            {
                string a = cboNganh.SelectedValue.ToString();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_Nganh(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
                return;
            }
            else
            {
                return;
            }
        }

        private void cboNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radNganh.Checked)
            {
                string a = cboNganh.SelectedValue.ToString();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_Nganh(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
                return;
            }
            else
            {

                return;
            }
        }

        private void radNienKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (radNienKhoa.Checked)
            {
                string a = cboNienKhoa.SelectedValue.ToString();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_NienKhoa(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {

                return;
            }
        }

        private void cboNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radNienKhoa.Checked)
            {
                string a = cboNienKhoa.SelectedValue.ToString();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_NienKhoa(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {

                return;
            }
        }

        private void radDanToc_CheckedChanged(object sender, EventArgs e)
        {
            if (radDanToc.Checked)
            {
                string a = txtDanToc.Text.Trim();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_DanToc(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {
                return;
            }
        }

        private void radDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            if (radDiaChi.Checked)
            {
                string a = txtDiaChi.Text.Trim();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_DiaChi(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {
                return;
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (radDiaChi.Checked)
            {
                string a = txtDiaChi.Text.Trim();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_DiaChi(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {
                return;
            }
        }

        private void radGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                string a = txtGhiChu.Text.Trim();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_GhiChu(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {
                return;
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                string a = txtGhiChu.Text.Trim();
                dgvSinhVien.DataSource = _sinhVienBUS.DSSinhVien_GhiChu(a);
                lblSoLuongSVTK.Text = dgvSinhVien.Rows.Count.ToString();
            }
            else
            {
                return;
            }
        }

        private void cboLop_TextChanged(object sender, EventArgs e)
        {

        }

    }
}