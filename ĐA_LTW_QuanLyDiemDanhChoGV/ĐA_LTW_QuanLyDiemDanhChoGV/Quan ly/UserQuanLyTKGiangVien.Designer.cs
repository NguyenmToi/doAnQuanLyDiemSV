//namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
//{
//    partial class UserQuanLyTKGiangVien
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
//            this.colTKGV_LoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.btnKhoiPhucTaiKhoan = new System.Windows.Forms.Button();
//            this.btnLamMoi = new System.Windows.Forms.Button();
//            this.btnTimKiem = new System.Windows.Forms.Button();
//            this.cboTimKiem = new System.Windows.Forms.ComboBox();
//            this.label5 = new System.Windows.Forms.Label();
//            this.btnXoa = new System.Windows.Forms.Button();
//            this.btnSua = new System.Windows.Forms.Button();
//            this.btnThem = new System.Windows.Forms.Button();
//            this.colTKGV_MK = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colTKGV_TK = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.txtGhiChu = new System.Windows.Forms.TextBox();
//            this.txtMatKhau = new System.Windows.Forms.TextBox();
//            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
//            this.label2 = new System.Windows.Forms.Label();
//            this.label1 = new System.Windows.Forms.Label();
//            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.groupBox1 = new System.Windows.Forms.GroupBox();
//            this.label4 = new System.Windows.Forms.Label();
//            this.dgvTaiKhoanSV = new System.Windows.Forms.DataGridView();
//            this.groupBox1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanSV)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // colTKGV_LoaiTaiKhoan
//            // 
//            this.colTKGV_LoaiTaiKhoan.DataPropertyName = "LOAITAIKHOAN";
//            this.colTKGV_LoaiTaiKhoan.HeaderText = "Loại tài khoản";
//            this.colTKGV_LoaiTaiKhoan.Name = "colTKGV_LoaiTaiKhoan";
//            this.colTKGV_LoaiTaiKhoan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
//            this.colTKGV_LoaiTaiKhoan.Visible = false;
//            // 
//            // GhiChu
//            // 
//            this.GhiChu.DataPropertyName = "GHICHU";
//            this.GhiChu.HeaderText = "Ghi Chú";
//            this.GhiChu.Name = "GhiChu";
//            // 
//            // btnKhoiPhucTaiKhoan
//            // 
//            this.btnKhoiPhucTaiKhoan.Location = new System.Drawing.Point(23, 218);
//            this.btnKhoiPhucTaiKhoan.Name = "btnKhoiPhucTaiKhoan";
//            this.btnKhoiPhucTaiKhoan.Size = new System.Drawing.Size(169, 30);
//            this.btnKhoiPhucTaiKhoan.TabIndex = 19;
//            this.btnKhoiPhucTaiKhoan.Text = "Khôi phục tài khoản";
//            this.btnKhoiPhucTaiKhoan.UseVisualStyleBackColor = true;
//            // 
//            // btnLamMoi
//            // 
//            this.btnLamMoi.Location = new System.Drawing.Point(117, 182);
//            this.btnLamMoi.Name = "btnLamMoi";
//            this.btnLamMoi.Size = new System.Drawing.Size(75, 30);
//            this.btnLamMoi.TabIndex = 18;
//            this.btnLamMoi.Text = "làm mới";
//            this.btnLamMoi.UseVisualStyleBackColor = true;
//            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
//            // 
//            // btnTimKiem
//            // 
//            this.btnTimKiem.Location = new System.Drawing.Point(89, 299);
//            this.btnTimKiem.Name = "btnTimKiem";
//            this.btnTimKiem.Size = new System.Drawing.Size(75, 30);
//            this.btnTimKiem.TabIndex = 17;
//            this.btnTimKiem.Text = "Tìm kiếm";
//            this.btnTimKiem.UseVisualStyleBackColor = true;
//            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
//            // label5
//            // 
//            this.label5.AutoSize = true;
//            this.label5.Location = new System.Drawing.Point(7, 275);
//            this.label5.Name = "label5";
//            this.label5.Size = new System.Drawing.Size(76, 13);
//            this.label5.TabIndex = 13;
//            this.label5.Text = "Tìm kiếm theo:";
//            // 
//            // btnXoa
//            // 
//            this.btnXoa.Location = new System.Drawing.Point(23, 182);
//            this.btnXoa.Name = "btnXoa";
//            this.btnXoa.Size = new System.Drawing.Size(75, 30);
//            this.btnXoa.TabIndex = 12;
//            this.btnXoa.Text = "Xóa";
//            this.btnXoa.UseVisualStyleBackColor = true;
//            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
//            // 
//            // btnSua
//            // 
//            this.btnSua.Location = new System.Drawing.Point(117, 146);
//            this.btnSua.Name = "btnSua";
//            this.btnSua.Size = new System.Drawing.Size(75, 30);
//            this.btnSua.TabIndex = 11;
//            this.btnSua.Text = "Sửa";
//            this.btnSua.UseVisualStyleBackColor = true;
//            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
//            // 
//            // btnThem
//            // 
//            this.btnThem.Location = new System.Drawing.Point(23, 146);
//            this.btnThem.Name = "btnThem";
//            this.btnThem.Size = new System.Drawing.Size(75, 30);
//            this.btnThem.TabIndex = 10;
//            this.btnThem.Text = "Thêm";
//            this.btnThem.UseVisualStyleBackColor = true;
//            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
//            // 
//            // colTKGV_MK
//            // 
//            this.colTKGV_MK.DataPropertyName = "MATKHAU";
//            this.colTKGV_MK.HeaderText = "Mật khẩu";
//            this.colTKGV_MK.Name = "colTKGV_MK";
//            // 
//            // TT
//            // 
//            this.TT.DataPropertyName = "TT";
//            this.TT.HeaderText = "TT";
//            this.TT.Name = "TT";
//            this.TT.Visible = false;
//            // 
//            // colTKGV_TK
//            // 
//            this.colTKGV_TK.DataPropertyName = "TAIKHOAN";
//            this.colTKGV_TK.HeaderText = "Tài khoản";
//            this.colTKGV_TK.Name = "colTKGV_TK";
//            // 
//            // txtGhiChu
//            // 
//            this.txtGhiChu.Location = new System.Drawing.Point(70, 109);
//            this.txtGhiChu.Name = "txtGhiChu";
//            this.txtGhiChu.Size = new System.Drawing.Size(126, 20);
//            this.txtGhiChu.TabIndex = 7;
//            // 
//            // txtMatKhau
//            // 
//            this.txtMatKhau.Location = new System.Drawing.Point(70, 69);
//            this.txtMatKhau.Name = "txtMatKhau";
//            this.txtMatKhau.Size = new System.Drawing.Size(126, 20);
//            this.txtMatKhau.TabIndex = 5;
//            // 
//            // txtTaiKhoan
//            // 
//            this.txtTaiKhoan.Location = new System.Drawing.Point(70, 32);
//            this.txtTaiKhoan.Name = "txtTaiKhoan";
//            this.txtTaiKhoan.Size = new System.Drawing.Size(126, 20);
//            this.txtTaiKhoan.TabIndex = 4;
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Location = new System.Drawing.Point(6, 72);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(55, 13);
//            this.label2.TabIndex = 1;
//            this.label2.Text = "Mật khẩu:";
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Location = new System.Drawing.Point(6, 35);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(58, 13);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "Tài khoản:";
//            // 
//            // TRANGTHAI
//            // 
//            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
//            this.TRANGTHAI.HeaderText = "TRANGTHAI";
//            this.TRANGTHAI.Name = "TRANGTHAI";
//            this.TRANGTHAI.Visible = false;
//            // 
//            // groupBox1
//            // 
//            this.groupBox1.Controls.Add(this.btnKhoiPhucTaiKhoan);
//            this.groupBox1.Controls.Add(this.btnLamMoi);
//            this.groupBox1.Controls.Add(this.btnTimKiem);
//            this.groupBox1.Controls.Add(this.cboTimKiem);
//            this.groupBox1.Controls.Add(this.label5);
//            this.groupBox1.Controls.Add(this.btnXoa);
//            this.groupBox1.Controls.Add(this.btnSua);
//            this.groupBox1.Controls.Add(this.btnThem);
//            this.groupBox1.Controls.Add(this.txtGhiChu);
//            this.groupBox1.Controls.Add(this.txtMatKhau);
//            this.groupBox1.Controls.Add(this.txtTaiKhoan);
//            this.groupBox1.Controls.Add(this.label4);
//            this.groupBox1.Controls.Add(this.label2);
//            this.groupBox1.Controls.Add(this.label1);
//            this.groupBox1.Location = new System.Drawing.Point(2, 3);
//            this.groupBox1.Name = "groupBox1";
//            this.groupBox1.Size = new System.Drawing.Size(234, 359);
//            this.groupBox1.TabIndex = 6;
//            this.groupBox1.TabStop = false;
//            this.groupBox1.Text = "Thông tin tài khoản";
//            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
//            // 
//            // label4
//            // 
//            this.label4.AutoSize = true;
//            this.label4.Location = new System.Drawing.Point(6, 112);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(47, 13);
//            this.label4.TabIndex = 3;
//            this.label4.Text = "Ghi chú:";
//            // 
//            // dgvTaiKhoanSV
//            // 
//            this.dgvTaiKhoanSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.dgvTaiKhoanSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.dgvTaiKhoanSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dgvTaiKhoanSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.colTKGV_TK,
//            this.TT,
//            this.colTKGV_MK,
//            this.GhiChu,
//            this.TRANGTHAI,
//            this.colTKGV_LoaiTaiKhoan});
//            this.dgvTaiKhoanSV.Location = new System.Drawing.Point(242, 3);
//            this.dgvTaiKhoanSV.Name = "dgvTaiKhoanSV";
//            this.dgvTaiKhoanSV.Size = new System.Drawing.Size(599, 359);
//            this.dgvTaiKhoanSV.TabIndex = 7;
//            this.dgvTaiKhoanSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoanSV_CellContentClick);
//            // 
//            // UserQuanLyTKGiangVien
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.Controls.Add(this.groupBox1);
//            this.Controls.Add(this.dgvTaiKhoanSV);
//            this.Name = "UserQuanLyTKGiangVien";
//            this.Size = new System.Drawing.Size(842, 365);
//            this.Load += new System.EventHandler(this.UserQuanLyTKGiangVien_Load);
//            this.groupBox1.ResumeLayout(false);
//            this.groupBox1.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanSV)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.DataGridViewTextBoxColumn colTKGV_LoaiTaiKhoan;
//        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
//        private System.Windows.Forms.Button btnKhoiPhucTaiKhoan;
//        private System.Windows.Forms.Button btnLamMoi;
//        private System.Windows.Forms.Button btnTimKiem;
//        private System.Windows.Forms.ComboBox cboTimKiem;
//        private System.Windows.Forms.Label label5;
//        private System.Windows.Forms.Button btnXoa;
//        private System.Windows.Forms.Button btnSua;
//        private System.Windows.Forms.Button btnThem;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colTKGV_MK;
//        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colTKGV_TK;
//        private System.Windows.Forms.TextBox txtGhiChu;
//        private System.Windows.Forms.TextBox txtMatKhau;
//        private System.Windows.Forms.TextBox txtTaiKhoan;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
//        private System.Windows.Forms.GroupBox groupBox1;
//        private System.Windows.Forms.Label label4;
//        private System.Windows.Forms.DataGridView dgvTaiKhoanSV;
//    }
//}
