namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
{
    partial class frmQLTKSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKhoiPhucTaiKhoan = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiemTKSV = new System.Windows.Forms.Button();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTaiKhoanSV = new System.Windows.Forms.DataGridView();
            this.colTKSV_TK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTKSV_MK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTKSV_LoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanSV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnKhoiPhucTaiKhoan);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnTimKiemTKSV);
            this.groupBox2.Controls.Add(this.cboTimKiem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.txtMatKhau);
            this.groupBox2.Controls.Add(this.txtTaiKhoan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 358);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản";
            // 
            // btnKhoiPhucTaiKhoan
            // 
            this.btnKhoiPhucTaiKhoan.BackgroundImage = global::ĐA_LTW_QuanLyDiemDanhChoGV.Properties.Resources._9042205_database_restore_icon1;
            this.btnKhoiPhucTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKhoiPhucTaiKhoan.Location = new System.Drawing.Point(23, 218);
            this.btnKhoiPhucTaiKhoan.Name = "btnKhoiPhucTaiKhoan";
            this.btnKhoiPhucTaiKhoan.Size = new System.Drawing.Size(169, 30);
            this.btnKhoiPhucTaiKhoan.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnKhoiPhucTaiKhoan, "Khôi phục tài khoản");
            this.btnKhoiPhucTaiKhoan.UseVisualStyleBackColor = true;
            this.btnKhoiPhucTaiKhoan.Click += new System.EventHandler(this.btnKhoiPhucTaiKhoan_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImage = global::ĐA_LTW_QuanLyDiemDanhChoGV.Properties.Resources._49384_reload_icon;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Location = new System.Drawing.Point(117, 182);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 30);
            this.btnLamMoi.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnLamMoi, "Làm mới");
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiemTKSV
            // 
            this.btnTimKiemTKSV.BackgroundImage = global::ĐA_LTW_QuanLyDiemDanhChoGV.Properties.Resources._172546_search_icon;
            this.btnTimKiemTKSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemTKSV.Location = new System.Drawing.Point(89, 299);
            this.btnTimKiemTKSV.Name = "btnTimKiemTKSV";
            this.btnTimKiemTKSV.Size = new System.Drawing.Size(75, 30);
            this.btnTimKiemTKSV.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnTimKiemTKSV, "Tìm kiếm");
            this.btnTimKiemTKSV.UseVisualStyleBackColor = true;
            this.btnTimKiemTKSV.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Tài khoản",
            "Ghi chú"});
            this.cboTimKiem.Location = new System.Drawing.Point(89, 272);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(121, 21);
            this.cboTimKiem.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tìm kiếm theo:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::ĐA_LTW_QuanLyDiemDanhChoGV.Properties.Resources._326606_delete_icon;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Location = new System.Drawing.Point(23, 182);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::ĐA_LTW_QuanLyDiemDanhChoGV.Properties.Resources.upload;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Location = new System.Drawing.Point(117, 146);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnSua, "Cập nhật");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::ĐA_LTW_QuanLyDiemDanhChoGV.Properties.Resources._299068_add_sign_icon;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Location = new System.Drawing.Point(23, 146);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(70, 109);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(126, 21);
            this.txtGhiChu.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(70, 69);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(126, 21);
            this.txtMatKhau.TabIndex = 3;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(70, 32);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(126, 21);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaiKhoan_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ghi chú:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mật khẩu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tài khoản:";
            // 
            // dgvTaiKhoanSV
            // 
            this.dgvTaiKhoanSV.AllowUserToResizeColumns = false;
            this.dgvTaiKhoanSV.AllowUserToResizeRows = false;
            this.dgvTaiKhoanSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaiKhoanSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoanSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTaiKhoanSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTKSV_TK,
            this.colTKSV_MK,
            this.GhiChu,
            this.TT,
            this.colTrangThai,
            this.colTKSV_LoaiTaiKhoan});
            this.dgvTaiKhoanSV.Location = new System.Drawing.Point(252, 12);
            this.dgvTaiKhoanSV.Name = "dgvTaiKhoanSV";
            this.dgvTaiKhoanSV.Size = new System.Drawing.Size(579, 350);
            this.dgvTaiKhoanSV.TabIndex = 1;
            this.dgvTaiKhoanSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoanGV_CellContentClick);
            this.dgvTaiKhoanSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoanGV_CellContentClick);
            // 
            // colTKSV_TK
            // 
            this.colTKSV_TK.DataPropertyName = "TAIKHOAN";
            this.colTKSV_TK.HeaderText = "Tài khoản";
            this.colTKSV_TK.Name = "colTKSV_TK";
            // 
            // colTKSV_MK
            // 
            this.colTKSV_MK.DataPropertyName = "MATKHAU";
            this.colTKSV_MK.HeaderText = "Mật khẩu";
            this.colTKSV_MK.Name = "colTKSV_MK";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GHICHU";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // TT
            // 
            this.TT.DataPropertyName = "TT";
            this.TT.HeaderText = "TT";
            this.TT.Name = "TT";
            this.TT.Visible = false;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TRANGTHAI";
            this.colTrangThai.HeaderText = "TRANGTHAI";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = false;
            // 
            // colTKSV_LoaiTaiKhoan
            // 
            this.colTKSV_LoaiTaiKhoan.DataPropertyName = "LOAITAIKHOAN";
            this.colTKSV_LoaiTaiKhoan.HeaderText = "Loại tài khoản";
            this.colTKSV_LoaiTaiKhoan.Name = "colTKSV_LoaiTaiKhoan";
            this.colTKSV_LoaiTaiKhoan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTKSV_LoaiTaiKhoan.Visible = false;
            // 
            // frmQLTKSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 374);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvTaiKhoanSV);
            this.Name = "frmQLTKSV";
            this.Text = "Tài khoản sinh viên";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiemTKSV;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvTaiKhoanSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTKSV_TK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTKSV_MK;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTKSV_LoaiTaiKhoan;
        private System.Windows.Forms.Button btnKhoiPhucTaiKhoan;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}