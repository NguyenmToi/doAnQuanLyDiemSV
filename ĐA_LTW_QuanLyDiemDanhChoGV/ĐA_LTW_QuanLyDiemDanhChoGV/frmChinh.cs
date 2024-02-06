using BUS;
using ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly;
using DAO;
using DevExpress.XtraBars;
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
    public partial class frmChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
       QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        GiangVienBUS _giangVienBUS = new GiangVienBUS();
        QLTKGVBUS _taiKhoanGVBUS = new QLTKGVBUS();
        public frmChinh()
        {
            InitializeComponent();
            //1017, 1581019, 588

            this.MinimumSize = new Size(1150, 650);
            this.MaximumSize = new Size(1300, 800);

            VaiTro();
            TenDangNhap();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();
        }

         public string ss(string a) { 
        
            var gv = _giangVienBUS.LayTenGV(a);
            return gv;
        }
        public void TenDangNhap()
        {
            string a = frmDangNhap.dlTKDangNhap.TKDangNhap;
            txtTaiKhoanDangNhap.Caption = ss(a);
        }

        public void VaiTro()
        {
            string a = frmDangNhap.dlTKDangNhap.TKDangNhap;
            int ltk = int.Parse(_taiKhoanGVBUS.LayMaLoaiTaiKhoan(a));
            string TenLTK;
            if (ltk == 1) { TenLTK = "Giảng viên"; }
            else if (ltk == 0) { TenLTK = "Admin"; }
            else { TenLTK = "Không xác định"; }
            txtVaiTroDangNhap.Caption = TenLTK?.ToString() ?? "";
            GioiHanQuyen(ltk);
        }

        public void GioiHanQuyen(int MaLTK)
        {
            if(MaLTK==1)
            {
                barbtnQLCapQuyenTaiKhoan.Enabled = false;
                barbtnQLLoaiTaiKhoans.Enabled = false;
                barbtnQLTaiKhoanSinhVien.Enabled = false;
                barbtnQLTaiKhoanGV.Enabled = false;
                barbtnQLGiangViens.Enabled = false;
                barbtnQLHocKys.Enabled = false;
                barbtnQLNienKhoas.Enabled = false;
                barbtnQLMonHocs.Enabled = false;
                barbtnQLNganhs.Enabled = false;
                barbtnQLKhoas.Enabled=false;
                barbtnQLLops.Enabled = false;
                barbtnQLSinhViens.Enabled = false;
            }
            else if(MaLTK==0&&frmDangNhap.dlTKDangNhap.TKDangNhap!="ADMIN")
            {
                barbtnQLCapQuyenTaiKhoan.Enabled = false;
                barbtnQLLoaiTaiKhoans.Enabled = false;
                barbtnQLTaiKhoanSinhVien.Enabled = false;
                barbtnQLTaiKhoanGV.Enabled = false;
                barbtnQLGiangViens.Enabled = false;
                barbtnQLHocKys.Enabled = false;
                barbtnQLNienKhoas.Enabled = false;
                barbtnQLMonHocs.Enabled = false;
                barbtnQLNganhs.Enabled = false;
                barbtnQLKhoas.Enabled = false;
                barbtnQLLops.Enabled = false;
                barbtnQLSinhViens.Enabled = true;
            }    
        }


        void OpenForm(Type typeForm)
        {
            foreach(Form frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }    
            }
            Form fm = (Form) Activator.CreateInstance(typeForm);
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmQLNienKhoa));
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmQLGiangVien));
        }

        private void btnSInhViens_ItemClick(object sender, ItemClickEventArgs e)
        {
            //OpenForm(typeof(frmSinhVien));
        }

        private void btnDiems_ItemClick(object sender, ItemClickEventArgs e)
        {
            //OpenForm(typeof(frmDiem));

        }

        private void btnLops_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmLop));

        }

        private void btnMonHocs_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmMonHoc));

        }

        private void btnNganhs_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmNganh));

        }

        private void btnKhoas_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmKhoa));

        }

        private void btnHocKys_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmHocKy));

        }

        private void btnNienKhoas_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmNienKhoa));
        }

        private void btnGiangViens_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmGiangVien));
        }

        private void btnQLSinhViens_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmQLSinhVien));
        }

        private void btnQLMonHocs_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmQLMonHoc));
        }

        private void btnQLLops_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmQLLop));
        }

        private void btnQLNganhs_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmQLNganh));
        }

        private void btnQLKhoas_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmQLKhoa));
        }

        private void btnQLHocKys_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmQLHocKy));
        }

        private void btnQLLoaiTaiKhoans_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmQLLoaiTaiKhoan));
        }

        private void btnQLTaiKhoans_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmQLTKSV));
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {

        }

        private void btnDangXuats_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmDangNhap frm = new frmDangNhap();
                frm.Show();
                this.Hide();
            }
            else
            {
                return;
                
            }    

        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txtThoiGian.Caption = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmQLTKGV));
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmQLPhanQuyen));
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frmThongTinTaiKhoan frm = new frmThongTinTaiKhoan();
            frm.Show();
            this.Hide();
            return;
        }
    }
}