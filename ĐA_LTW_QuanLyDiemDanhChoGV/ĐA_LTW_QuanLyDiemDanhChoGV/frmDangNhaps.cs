using BUS;
using ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly;
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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        GiangVienBUS _giangVienBUS = new GiangVienBUS();
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        QLTKSVsBUS _taiKhoanSVBUS = new QLTKSVsBUS();
        QLTKGVBUS _taiKhoanGVBUS = new QLTKGVBUS();

        public frmDangNhap()
        {
            InitializeComponent();
            Rs();
            txtTaiKhoan.Focus();
        }

        int ltk;
        public static class dlTKDangNhap
        {
            public static int LoaiTaiKhoan { get; set; }
            public static string TKDangNhap { get; set; }
        }
        public void Rs()
        {
            txtTaiKhoan.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text.Trim()))
            {
                TaiKhoanGVDTO tkgv = new TaiKhoanGVDTO();
                {
                    tkgv.TAIKHOAN = txtTaiKhoan.Text.Trim();
                }
                TaiKhoanSVDTO tksv = new TaiKhoanSVDTO();
                {
                    tksv.TAIKHOAN = txtTaiKhoan.Text.Trim();
                }
                string a = txtTaiKhoan.Text.Trim();
                if(_taiKhoanSVBUS.KT(a)==true)
                {
                    TaiKhoanSVDTO sv = new TaiKhoanSVDTO()
                    {
                        TAIKHOAN = txtTaiKhoan.Text.Trim(),
                        GHICHU = "Quên mật khẩu"
                    };
                    if(_taiKhoanSVBUS.QuenMatKhau(sv)==true)
                    {
                        MessageBox.Show("Đã thông báo cho người quản lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;   
                    }
                    else
                    {
                        MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }    
                }
                else if(_taiKhoanGVBUS.KT(a)==true)
                {
                    TaiKhoanGVDTO gv = new TaiKhoanGVDTO()
                    {
                        TAIKHOAN = txtTaiKhoan.Text.Trim(),
                        GHICHU = "Quên mật khẩu"
                    };
                    if (_taiKhoanGVBUS.QuenMatKhau(gv) == true)
                    {
                        MessageBox.Show("Đã thông báo cho người quản lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }    
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tài khoản", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return;
            }
        }



        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(580, 280);
            this.MaximumSize = new Size(650, 300);
        }



        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtTaiKhoan.Text.Trim())&&!string.IsNullOrEmpty(txtMatKhau.Text.Trim()))
            {
                TaiKhoanSVDTO sv = new TaiKhoanSVDTO()
                {
                    TAIKHOAN = txtTaiKhoan.Text.Trim(),
                    MATKHAU = txtMatKhau.Text.Trim(),
                };
                TaiKhoanGVDTO gv = new TaiKhoanGVDTO()
                {
                    TAIKHOAN = txtTaiKhoan.Text.Trim(),
                    MATKHAU = txtMatKhau.Text.Trim(), 
                };
                string tk = txtTaiKhoan.Text.Trim();
                string mk = txtMatKhau.Text.Trim();
                if (_taiKhoanGVBUS.KTTK1(tk,mk)==true)
                {
                    dlTKDangNhap.TKDangNhap = tk;
                    dlTKDangNhap.LoaiTaiKhoan = ltk;
                    frmChinh frmChinh = new frmChinh();
                            frmChinh.Show();
                            this.Hide();
                            Rs();
                            return;        
                }    

                else if(_taiKhoanSVBUS.KTTKMK(tk,mk)==true)
                {
                    MessageBox.Show("Chức năng này đang được hoàn thành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return;
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaiKhoan.Focus();
                    return;
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
