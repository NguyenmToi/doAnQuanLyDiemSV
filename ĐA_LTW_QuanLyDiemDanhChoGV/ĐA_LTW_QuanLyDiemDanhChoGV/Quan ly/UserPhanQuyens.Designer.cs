//namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
//{
//    partial class UserPhanQuyens
//    {
//        /// <summary> 
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary> 
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Component Designer generated code

//        /// <summary> 
//        /// Required method for Designer support - do not modify 
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.groupBox2 = new System.Windows.Forms.GroupBox();
//            this.radGiangVien = new System.Windows.Forms.RadioButton();
//            this.radAdmin = new System.Windows.Forms.RadioButton();
//            this.label7 = new System.Windows.Forms.Label();
//            this.btnLamMoi = new System.Windows.Forms.Button();
//            this.btnTimKiemTK = new System.Windows.Forms.Button();
//            this.cboTimKiem = new System.Windows.Forms.ComboBox();
//            this.label3 = new System.Windows.Forms.Label();
//            this.btnCapQuyen = new System.Windows.Forms.Button();
//            this.txtGhiChu = new System.Windows.Forms.TextBox();
//            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
//            this.label6 = new System.Windows.Forms.Label();
//            this.label8 = new System.Windows.Forms.Label();
//            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colTKSV_TK = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colTKSV_MK = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colTKSV_LoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.MATKGAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colPG_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.PG_TangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colPG_TenLoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colPG_LoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colPG_TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.dgvPhanQuyen = new System.Windows.Forms.DataGridView();
//            this.lblLTK = new System.Windows.Forms.Label();
//            this.groupBox2.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // groupBox2
//            // 
//            this.groupBox2.Controls.Add(this.lblLTK);
//            this.groupBox2.Controls.Add(this.radGiangVien);
//            this.groupBox2.Controls.Add(this.radAdmin);
//            this.groupBox2.Controls.Add(this.label7);
//            this.groupBox2.Controls.Add(this.btnLamMoi);
//            this.groupBox2.Controls.Add(this.btnTimKiemTK);
//            this.groupBox2.Controls.Add(this.cboTimKiem);
//            this.groupBox2.Controls.Add(this.label3);
//            this.groupBox2.Controls.Add(this.btnCapQuyen);
//            this.groupBox2.Controls.Add(this.txtGhiChu);
//            this.groupBox2.Controls.Add(this.txtTaiKhoan);
//            this.groupBox2.Controls.Add(this.label6);
//            this.groupBox2.Controls.Add(this.label8);
//            this.groupBox2.Location = new System.Drawing.Point(3, 3);
//            this.groupBox2.Name = "groupBox2";
//            this.groupBox2.Size = new System.Drawing.Size(220, 359);
//            this.groupBox2.TabIndex = 12;
//            this.groupBox2.TabStop = false;
//            this.groupBox2.Text = "Thông tin tài khoản";
//            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
//            // 
//            // radGiangVien
//            // 
//            this.radGiangVien.AutoSize = true;
//            this.radGiangVien.Location = new System.Drawing.Point(111, 150);
//            this.radGiangVien.Name = "radGiangVien";
//            this.radGiangVien.Size = new System.Drawing.Size(76, 17);
//            this.radGiangVien.TabIndex = 21;
//            this.radGiangVien.TabStop = true;
//            this.radGiangVien.Text = "Giảng viên";
//            this.radGiangVien.UseVisualStyleBackColor = true;
//            // 
//            // radAdmin
//            // 
//            this.radAdmin.AutoSize = true;
//            this.radAdmin.Location = new System.Drawing.Point(111, 116);
//            this.radAdmin.Name = "radAdmin";
//            this.radAdmin.Size = new System.Drawing.Size(54, 17);
//            this.radAdmin.TabIndex = 20;
//            this.radAdmin.TabStop = true;
//            this.radAdmin.Text = "Admin";
//            this.radAdmin.UseVisualStyleBackColor = true;
//            // 
//            // label7
//            // 
//            this.label7.AutoSize = true;
//            this.label7.Location = new System.Drawing.Point(6, 118);
//            this.label7.Name = "label7";
//            this.label7.Size = new System.Drawing.Size(81, 13);
//            this.label7.TabIndex = 19;
//            this.label7.Text = "Loại Tài khoản:";
//            // 
//            // btnLamMoi
//            // 
//            this.btnLamMoi.Location = new System.Drawing.Point(111, 207);
//            this.btnLamMoi.Name = "btnLamMoi";
//            this.btnLamMoi.Size = new System.Drawing.Size(75, 30);
//            this.btnLamMoi.TabIndex = 18;
//            this.btnLamMoi.Text = "làm mới";
//            this.btnLamMoi.UseVisualStyleBackColor = true;
//            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
//            // 
//            // btnTimKiemTK
//            // 
//            this.btnTimKiemTK.Location = new System.Drawing.Point(89, 305);
//            this.btnTimKiemTK.Name = "btnTimKiemTK";
//            this.btnTimKiemTK.Size = new System.Drawing.Size(75, 30);
//            this.btnTimKiemTK.TabIndex = 17;
//            this.btnTimKiemTK.Text = "Tìm kiếm";
//            this.btnTimKiemTK.UseVisualStyleBackColor = true;
//            this.btnTimKiemTK.Click += new System.EventHandler(this.btnTimKiemTK_Click);
//            // 
//            // cboTimKiem
//            // 
//            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.cboTimKiem.FormattingEnabled = true;
//            this.cboTimKiem.Items.AddRange(new object[] {
//            "Tài khoản",
//            "Ghi chú"});
//            this.cboTimKiem.Location = new System.Drawing.Point(89, 272);
//            this.cboTimKiem.Name = "cboTimKiem";
//            this.cboTimKiem.Size = new System.Drawing.Size(121, 21);
//            this.cboTimKiem.TabIndex = 14;
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Location = new System.Drawing.Point(7, 275);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(76, 13);
//            this.label3.TabIndex = 13;
//            this.label3.Text = "Tìm kiếm theo:";
//            // 
//            // btnCapQuyen
//            // 
//            this.btnCapQuyen.Location = new System.Drawing.Point(12, 207);
//            this.btnCapQuyen.Name = "btnCapQuyen";
//            this.btnCapQuyen.Size = new System.Drawing.Size(75, 30);
//            this.btnCapQuyen.TabIndex = 11;
//            this.btnCapQuyen.Text = "Cấp quyền";
//            this.btnCapQuyen.UseVisualStyleBackColor = true;
//            this.btnCapQuyen.Click += new System.EventHandler(this.btnCapQuyen_Click);
//            // 
//            // txtGhiChu
//            // 
//            this.txtGhiChu.Location = new System.Drawing.Point(70, 71);
//            this.txtGhiChu.Name = "txtGhiChu";
//            this.txtGhiChu.Size = new System.Drawing.Size(126, 20);
//            this.txtGhiChu.TabIndex = 7;
//            // 
//            // txtTaiKhoan
//            // 
//            this.txtTaiKhoan.Location = new System.Drawing.Point(70, 32);
//            this.txtTaiKhoan.Name = "txtTaiKhoan";
//            this.txtTaiKhoan.Size = new System.Drawing.Size(126, 20);
//            this.txtTaiKhoan.TabIndex = 4;
//            // 
//            // label6
//            // 
//            this.label6.AutoSize = true;
//            this.label6.Location = new System.Drawing.Point(6, 74);
//            this.label6.Name = "label6";
//            this.label6.Size = new System.Drawing.Size(47, 13);
//            this.label6.TabIndex = 3;
//            this.label6.Text = "Ghi chú:";
//            // 
//            // label8
//            // 
//            this.label8.AutoSize = true;
//            this.label8.Location = new System.Drawing.Point(6, 35);
//            this.label8.Name = "label8";
//            this.label8.Size = new System.Drawing.Size(58, 13);
//            this.label8.TabIndex = 0;
//            this.label8.Text = "Tài khoản:";
//            // 
//            // colTrangThai
//            // 
//            this.colTrangThai.DataPropertyName = "TRANGTHAI";
//            this.colTrangThai.HeaderText = "TRANGTHAI";
//            this.colTrangThai.Name = "colTrangThai";
//            this.colTrangThai.Visible = false;
//            // 
//            // colTKSV_TK
//            // 
//            this.colTKSV_TK.DataPropertyName = "TAIKHOAN";
//            this.colTKSV_TK.HeaderText = "Tài khoản";
//            this.colTKSV_TK.Name = "colTKSV_TK";
//            // 
//            // colTKSV_MK
//            // 
//            this.colTKSV_MK.DataPropertyName = "MATKHAU";
//            this.colTKSV_MK.HeaderText = "Mật khẩu";
//            this.colTKSV_MK.Name = "colTKSV_MK";
//            // 
//            // TT
//            // 
//            this.TT.DataPropertyName = "TT";
//            this.TT.HeaderText = "TT";
//            this.TT.Name = "TT";
//            this.TT.Visible = false;
//            // 
//            // colTKSV_LoaiTaiKhoan
//            // 
//            this.colTKSV_LoaiTaiKhoan.DataPropertyName = "LOAITAIKHOAN";
//            this.colTKSV_LoaiTaiKhoan.HeaderText = "Loại tài khoản";
//            this.colTKSV_LoaiTaiKhoan.Name = "colTKSV_LoaiTaiKhoan";
//            this.colTKSV_LoaiTaiKhoan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
//            this.colTKSV_LoaiTaiKhoan.Visible = false;
//            // 
//            // TRANGTHAI
//            // 
//            this.TRANGTHAI.HeaderText = "TRANGTHAI";
//            this.TRANGTHAI.Name = "TRANGTHAI";
//            this.TRANGTHAI.Visible = false;
//            // 
//            // Column3
//            // 
//            this.Column3.HeaderText = "Ghi Chú";
//            this.Column3.Name = "Column3";
//            // 
//            // Column2
//            // 
//            this.Column2.HeaderText = "Mật khẩu";
//            this.Column2.Name = "Column2";
//            // 
//            // Column1
//            // 
//            this.Column1.HeaderText = "Tài khoản";
//            this.Column1.Name = "Column1";
//            // 
//            // MATKGAU
//            // 
//            this.MATKGAU.DataPropertyName = "MATKHAU";
//            this.MATKGAU.HeaderText = "MATKHAU";
//            this.MATKGAU.Name = "MATKGAU";
//            this.MATKGAU.Visible = false;
//            // 
//            // colPG_GhiChu
//            // 
//            this.colPG_GhiChu.DataPropertyName = "GHICHU";
//            this.colPG_GhiChu.HeaderText = "Ghi chú";
//            this.colPG_GhiChu.Name = "colPG_GhiChu";
//            // 
//            // PG_TangThai
//            // 
//            this.PG_TangThai.DataPropertyName = "TRANGTHAI";
//            this.PG_TangThai.HeaderText = "Trạng thái";
//            this.PG_TangThai.Name = "PG_TangThai";
//            this.PG_TangThai.Visible = false;
//            // 
//            // colPG_TenLoaiTaiKhoan
//            // 
//            this.colPG_TenLoaiTaiKhoan.DataPropertyName = "TENLOAITAIKHOAN";
//            this.colPG_TenLoaiTaiKhoan.HeaderText = "Loại tài khoản";
//            this.colPG_TenLoaiTaiKhoan.Name = "colPG_TenLoaiTaiKhoan";
//            // 
//            // colPG_LoaiTaiKhoan
//            // 
//            this.colPG_LoaiTaiKhoan.DataPropertyName = "LOAITAIKHOAN";
//            this.colPG_LoaiTaiKhoan.HeaderText = "Loại tài khoản";
//            this.colPG_LoaiTaiKhoan.Name = "colPG_LoaiTaiKhoan";
//            this.colPG_LoaiTaiKhoan.Visible = false;
//            // 
//            // colPG_TaiKhoan
//            // 
//            this.colPG_TaiKhoan.DataPropertyName = "TAIKHOAN";
//            this.colPG_TaiKhoan.HeaderText = "Tài khoản";
//            this.colPG_TaiKhoan.Name = "colPG_TaiKhoan";
//            // 
//            // Column4
//            // 
//            this.Column4.DataPropertyName = "TT";
//            this.Column4.HeaderText = "Số thứ tự";
//            this.Column4.Name = "Column4";
//            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
//            this.Column4.Visible = false;
//            // 
//            // GhiChu
//            // 
//            this.GhiChu.DataPropertyName = "GHICHU";
//            this.GhiChu.HeaderText = "Ghi Chú";
//            this.GhiChu.Name = "GhiChu";
//            // 
//            // dgvPhanQuyen
//            // 
//            this.dgvPhanQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.dgvPhanQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.dgvPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dgvPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.Column4,
//            this.colPG_TaiKhoan,
//            this.colPG_LoaiTaiKhoan,
//            this.colPG_TenLoaiTaiKhoan,
//            this.PG_TangThai,
//            this.colPG_GhiChu,
//            this.MATKGAU});
//            this.dgvPhanQuyen.Location = new System.Drawing.Point(229, 3);
//            this.dgvPhanQuyen.Name = "dgvPhanQuyen";
//            this.dgvPhanQuyen.Size = new System.Drawing.Size(610, 359);
//            this.dgvPhanQuyen.TabIndex = 11;
//            this.dgvPhanQuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhanQuyen_CellContentClick);
//            // 
//            // lblLTK
//            // 
//            this.lblLTK.AutoSize = true;
//            this.lblLTK.Location = new System.Drawing.Point(9, 154);
//            this.lblLTK.Name = "lblLTK";
//            this.lblLTK.Size = new System.Drawing.Size(37, 13);
//            this.lblLTK.TabIndex = 22;
//            this.lblLTK.Text = "lblLTK";
//            // 
//            // UserPhanQuyens
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.Controls.Add(this.groupBox2);
//            this.Controls.Add(this.dgvPhanQuyen);
//            this.Name = "UserPhanQuyens";
//            this.Size = new System.Drawing.Size(842, 365);
//            this.groupBox2.ResumeLayout(false);
//            this.groupBox2.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.GroupBox groupBox2;
//        private System.Windows.Forms.RadioButton radGiangVien;
//        private System.Windows.Forms.RadioButton radAdmin;
//        private System.Windows.Forms.Label label7;
//        private System.Windows.Forms.Button btnLamMoi;
//        private System.Windows.Forms.Button btnTimKiemTK;
//        private System.Windows.Forms.ComboBox cboTimKiem;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.Button btnCapQuyen;
//        private System.Windows.Forms.TextBox txtGhiChu;
//        private System.Windows.Forms.TextBox txtTaiKhoan;
//        private System.Windows.Forms.Label label6;
//        private System.Windows.Forms.Label label8;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colTKSV_TK;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colTKSV_MK;
//        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colTKSV_LoaiTaiKhoan;
//        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
//        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
//        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
//        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
//        private System.Windows.Forms.DataGridViewTextBoxColumn MATKGAU;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colPG_GhiChu;
//        private System.Windows.Forms.DataGridViewTextBoxColumn PG_TangThai;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colPG_TenLoaiTaiKhoan;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colPG_LoaiTaiKhoan;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colPG_TaiKhoan;
//        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
//        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
//        private System.Windows.Forms.DataGridView dgvPhanQuyen;
//        private System.Windows.Forms.Label lblLTK;
//    }
//}
