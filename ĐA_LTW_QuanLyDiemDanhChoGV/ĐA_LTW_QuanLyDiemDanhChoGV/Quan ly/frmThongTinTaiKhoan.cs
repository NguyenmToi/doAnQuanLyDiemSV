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

namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
{
    public partial class frmThongTinTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        QLTKGVBUS _taiKhoanGVBUS = new QLTKGVBUS();
        GiangVienBUS _giangVienBUS = new GiangVienBUS();
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
            string tk = frmDangNhap.dlTKDangNhap.TKDangNhap;
            lblTenTaiKhoan.Text = tk;
            lblTenNguoiDangNhap.Text = TenNguoiDangNhap(tk);
        }


        public string TenNguoiDangNhap(string a)
        {
            var gv = _giangVienBUS.LayTenGV(a);
            return gv;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmChinh frmChinh = new frmChinh();
            frmChinh.Show();
            this.Hide();
            return;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtNhapMatKhauMoi.Text =string.Empty;
            txtNhapLaiMatKhauMoi.Text = string.Empty;
            txtNhapMatKhauCu.Text = string.Empty;
        }

        public void RS()
        {
            txtNhapMatKhauMoi.Text = string.Empty;
            txtNhapLaiMatKhauMoi.Text = string.Empty;
            txtNhapMatKhauCu.Text = string.Empty;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNhapMatKhauCu.Text.Trim())&& !string.IsNullOrEmpty(txtNhapMatKhauCu.Text.Trim())&& !string.IsNullOrEmpty(txtNhapMatKhauCu.Text.Trim()))
            {
                if (txtNhapLaiMatKhauMoi.Text.Length>5 && txtNhapMatKhauMoi.Text.Length > 5)
                {
                    if (txtNhapMatKhauMoi.Text.Trim()==txtNhapLaiMatKhauMoi.Text.Trim())
                    {
                        if (_taiKhoanGVBUS.KTMKCu(lblTenTaiKhoan.Text.Trim(),txtNhapMatKhauCu.Text.Trim())==true)
                        {
                            TaiKhoanGVDTO gv = new TaiKhoanGVDTO()
                            {
                                TAIKHOAN = lblTenTaiKhoan.Text,
                                MATKHAU = txtNhapMatKhauMoi.Text.Trim(),
                            };
                            if (_taiKhoanGVBUS.DoiMatKhau(gv) == true)
                            {

                                MessageBox.Show(Constant.doiMatKhau_TC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RS();
                                return;
                            }
                            else
                            {
                                MessageBox.Show(Constant.doiMatKhau_TB, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show(Constant.kiemTraMKCuSai, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show(Constant.matKhauNhapLaiKhac, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    {
                        MessageBox.Show(Constant.toiThieuMatKhau, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }    
            }
            else
            {
                MessageBox.Show(Constant.nhapChuaDuThongTin, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmThongTinTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng form này?", "Thông báo", MessageBoxButtons.YesNo);
            if(result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                e.Cancel = true;
                frmChinh frmChinh = new frmChinh();
                frmChinh.Show();
                this.Hide();
                return;
            }
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}