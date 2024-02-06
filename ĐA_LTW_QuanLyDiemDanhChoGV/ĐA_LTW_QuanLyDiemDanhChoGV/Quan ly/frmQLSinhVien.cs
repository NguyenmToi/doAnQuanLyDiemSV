using BUS;
using DAO;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
{
    public partial class frmQLSinhVien : DevExpress.XtraEditors.XtraForm
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        SinhVienBUS _sinhVienBUS = new SinhVienBUS();
        public frmQLSinhVien()
        {
            InitializeComponent();
            DSSinhVien();
            LoadCBOSinhVien();
            lbltk2.Text = dgvSinhVien.Rows.Count.ToString();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMSSV.Text.Trim()) && !string.IsNullOrEmpty(txtHoTen.Text.Trim()) && !string.IsNullOrEmpty(txtSoCCCD.Text.Trim()) && !string.IsNullOrEmpty(txtEmail.Text.Trim()) && !string.IsNullOrEmpty(cboLop.Text.Trim()) && !string.IsNullOrEmpty(cboNganh.Text.Trim()) && !string.IsNullOrEmpty(cboNienKhoa.Text.Trim()) && !string.IsNullOrEmpty(txtDanToc.Text.Trim()) && !string.IsNullOrEmpty(txtDiaChi.Text.Trim()))
            {
                if (cboLop.SelectedValue != null && cboNganh.SelectedValue != null && cboNienKhoa.SelectedValue != null)
                {
                    SinhVienDTO sv = new SinhVienDTO();
                    {
                        sv.MSSV = txtMSSV.Text.Trim();
                        sv.HOTEN = txtHoTen.Text.Trim();
                        sv.NGAYSINH = dtpNgaySinh.Value;
                        sv.CCCD = txtSoCCCD.Text.ToString();
                        sv.EMAIL = txtEmail.Text.ToString();
                        sv.MALOP = cboLop.SelectedValue.ToString();
                        sv.NGANH = cboNganh.SelectedValue.ToString();
                        sv.NIENKHOA = cboNienKhoa.SelectedValue.ToString();
                        sv.DIACHI = txtDiaChi.Text.ToString();
                        sv.GHICHU = txtGhiChu.Text.Trim();
                        sv.DANTOC = txtDanToc.Text.ToString();
                        sv.GIOITINH = radNam.Checked ? true : false;
                    }

                    if (_sinhVienBUS.KTSV(sv) == false)
                    {
                        if (_sinhVienBUS.KTLop(cboLop.SelectedValue.ToString()) == true)
                        {
                            if (_sinhVienBUS.KTNganh(cboNganh.SelectedValue.ToString()) == true)
                            {
                                if (_sinhVienBUS.KTNienKhoa(cboNienKhoa.SelectedValue.ToString()) == true)
                                {

                                    if (_sinhVienBUS.KTEmail(txtEmail.Text.Trim()) == true)
                                    {
                                        if (txtSoCCCD.Text.Length == 12)
                                        {
                                            if (_sinhVienBUS.KTNgaySinh(dtpNgaySinh.Value.ToString()))
                                            {

                                                if (_sinhVienBUS.KTSVDaXoa(txtMSSV.Text.Trim()) == false)
                                                {
                                                    if (_sinhVienBUS.ThemSinhVien(sv) == true)
                                                    {
                                                        MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        DSSinhVien();
                                                        Rs();
                                                        lbltk2.Text = Convert.ToString(dgvSinhVien.RowCount);
                                                        return;
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show(Constant.ThemTB, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        return;
                                                    }
                                                }
                                                else
                                                {
                                                    if (_sinhVienBUS.ThemSVDaXoa(sv) == true)
                                                    {
                                                        MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        DSSinhVien();
                                                        Rs();
                                                        lbltk2.Text = Convert.ToString(dgvSinhVien.RowCount);
                                                        return;
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show(Constant.ThemTB, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        return;
                                                    }
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show(Constant.NgaySinhSai, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show(Constant.CCCDSai, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show(Constant.EmailSaiDinhDang, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }


                                }
                                else
                                {
                                    MessageBox.Show("Niên khóa không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                            }
                            else
                            {
                                MessageBox.Show("Ngành không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lớp không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên đã tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(Constant.nhapChuaDuThongTin, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show(Constant.nhapChuaDuThongTin, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtDanToc_TextChanged(object sender, EventArgs e)
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Rs();
            radMSSV.Checked = false;
            radHoTen.Checked = false;
            radLop.Checked = false;
            radNganh.Checked = false;
            radNienKhoa.Checked = false;
            radSoCCCD.Checked = false;
            radGhiChu.Checked = false;
            radDiaChi.Checked = false;
            radDanToc.Checked = false;
            radEmail.Checked = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMSSV.Text.Trim()) && !string.IsNullOrEmpty(txtHoTen.Text.Trim()) && !string.IsNullOrEmpty(txtSoCCCD.Text.Trim()) && !string.IsNullOrEmpty(txtEmail.Text.Trim()) && !string.IsNullOrEmpty(cboLop.Text.Trim()) && !string.IsNullOrEmpty(cboNganh.Text.Trim()) && !string.IsNullOrEmpty(cboNienKhoa.Text.Trim()) && !string.IsNullOrEmpty(txtDanToc.Text.Trim()) && !string.IsNullOrEmpty(txtDiaChi.Text.Trim()))
            {
                if (cboLop.SelectedValue != null && cboNganh.SelectedValue != null && cboNienKhoa.SelectedValue != null)
                {
                    SinhVienDTO sv = new SinhVienDTO()
                    {
                        MSSV = txtMSSV.Text.Trim(),
                        HOTEN = txtHoTen.Text.Trim(),
                        NGAYSINH = dtpNgaySinh.Value,
                        CCCD = txtSoCCCD.Text.ToString(),
                        EMAIL = txtEmail.Text.ToString(),
                        MALOP = cboLop.SelectedValue.ToString(),
                        NGANH = cboNganh.SelectedValue.ToString(),
                        NIENKHOA = cboNienKhoa.SelectedValue.ToString(),
                        DIACHI = txtDiaChi.Text.ToString(),
                        GHICHU = txtGhiChu.Text.Trim(),
                        DANTOC = txtDanToc.Text.ToString(),
                        GIOITINH = radNam.Checked ? true : false
                    };

                    if (_sinhVienBUS.KTSV(sv) == true)
                    {
                        if (_sinhVienBUS.KTLop(cboLop.SelectedValue.ToString()) == true)
                        {
                            if (_sinhVienBUS.KTNganh(cboNganh.SelectedValue.ToString()) == true)
                            {
                                if (_sinhVienBUS.KTNienKhoa(cboNienKhoa.SelectedValue.ToString()) == true)
                                {

                                    if (_sinhVienBUS.KTEmail(txtEmail.Text.Trim()) == true)
                                    {
                                        if (txtSoCCCD.Text.Length == 12)
                                        {
                                            if (_sinhVienBUS.KTNgaySinh(dtpNgaySinh.Value.ToString()))
                                            {

                                                if (_sinhVienBUS.SuaSinhVien(sv) == true)
                                                {
                                                    MessageBox.Show(Constant.SuaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    DSSinhVien();
                                                    Rs();
                                                    return;
                                                }
                                                else
                                                {
                                                    MessageBox.Show(Constant.SuaTB, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    return;
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show(Constant.NgaySinhSai, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show(Constant.CCCDSai, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show(Constant.EmailSaiDinhDang, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }


                                }
                                else
                                {
                                    MessageBox.Show("Niên khóa không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                            }
                            else
                            {
                                MessageBox.Show("Ngành không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lớp không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(Constant.nhapChuaDuThongTin, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show(Constant.nhapChuaDuThongTin, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(Constant.HoiXoa, Constant.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(txtMSSV.Text.Trim()))
                {
                    SinhVienDTO sv = new SinhVienDTO()
                    {
                        MSSV = txtMSSV.Text.Trim()
                    };
                    if (_sinhVienBUS.KTSV(sv) == true)
                    {
                        if (_sinhVienBUS.XoaSV(txtMSSV.Text.Trim()))
                        {
                            MessageBox.Show(Constant.XoaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCBOSinhVien();
                            DSSinhVien();
                            Rs();
                            return;
                        }
                        else
                        {
                            MessageBox.Show(Constant.XoaTB, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên viên không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã sinh viên", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show(Constant.HuyXoa, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmQLSinhVien_Load(object sender, EventArgs e)
        {

        }
    }
}