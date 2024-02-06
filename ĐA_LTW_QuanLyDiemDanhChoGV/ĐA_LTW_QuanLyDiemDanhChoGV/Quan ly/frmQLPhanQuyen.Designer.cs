namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
{
    partial class frmQLPhanQuyen
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
            this.MATKGAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPG_TangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPQ_TenLoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPQ_LoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPQ_TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLTK = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radGiangVien = new System.Windows.Forms.RadioButton();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiemTKGV = new System.Windows.Forms.Button();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCapQuyen = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.colPQ_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTKSV_MK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTKSV_LoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTKSV_TK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhanQuyen = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // MATKGAU
            // 
            this.MATKGAU.DataPropertyName = "MATKHAU";
            this.MATKGAU.HeaderText = "MATKHAU";
            this.MATKGAU.Name = "MATKGAU";
            this.MATKGAU.Visible = false;
            // 
            // colPG_TangThai
            // 
            this.colPG_TangThai.DataPropertyName = "TRANGTHAI";
            this.colPG_TangThai.HeaderText = "Trạng thái";
            this.colPG_TangThai.Name = "colPG_TangThai";
            this.colPG_TangThai.Visible = false;
            // 
            // colPQ_TenLoaiTaiKhoan
            // 
            this.colPQ_TenLoaiTaiKhoan.DataPropertyName = "TENLOAITAIKHOAN";
            this.colPQ_TenLoaiTaiKhoan.HeaderText = "Loại tài khoản";
            this.colPQ_TenLoaiTaiKhoan.Name = "colPQ_TenLoaiTaiKhoan";
            // 
            // colPQ_LoaiTaiKhoan
            // 
            this.colPQ_LoaiTaiKhoan.DataPropertyName = "LOAITAIKHOAN";
            this.colPQ_LoaiTaiKhoan.HeaderText = "Loại tài khoản";
            this.colPQ_LoaiTaiKhoan.Name = "colPQ_LoaiTaiKhoan";
            this.colPQ_LoaiTaiKhoan.Visible = false;
            // 
            // colPQ_TaiKhoan
            // 
            this.colPQ_TaiKhoan.DataPropertyName = "TAIKHOAN";
            this.colPQ_TaiKhoan.HeaderText = "Tài khoản";
            this.colPQ_TaiKhoan.Name = "colPQ_TaiKhoan";
            // 
            // colTT
            // 
            this.colTT.DataPropertyName = "TT";
            this.colTT.HeaderText = "Số thứ tự";
            this.colTT.Name = "colTT";
            this.colTT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTT.Visible = false;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TRANGTHAI";
            this.colTrangThai.HeaderText = "TRANGTHAI";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = false;
            // 
            // lblLTK
            // 
            this.lblLTK.AutoSize = true;
            this.lblLTK.Location = new System.Drawing.Point(16, 152);
            this.lblLTK.Name = "lblLTK";
            this.lblLTK.Size = new System.Drawing.Size(34, 13);
            this.lblLTK.TabIndex = 6;
            this.lblLTK.Text = "lblLTK";
            this.lblLTK.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.lblLTK);
            this.groupBox2.Controls.Add(this.radGiangVien);
            this.groupBox2.Controls.Add(this.radAdmin);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnTimKiemTKGV);
            this.groupBox2.Controls.Add(this.cboTimKiem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCapQuyen);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.txtTaiKhoan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 358);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản";
            // 
            // radGiangVien
            // 
            this.radGiangVien.AutoSize = true;
            this.radGiangVien.Location = new System.Drawing.Point(111, 148);
            this.radGiangVien.Name = "radGiangVien";
            this.radGiangVien.Size = new System.Drawing.Size(75, 17);
            this.radGiangVien.TabIndex = 7;
            this.radGiangVien.TabStop = true;
            this.radGiangVien.Text = "Giảng viên";
            this.radGiangVien.UseVisualStyleBackColor = true;
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.Location = new System.Drawing.Point(111, 116);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(54, 17);
            this.radAdmin.TabIndex = 5;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "Admin";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Loại Tài khoản:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImage = global::ĐA_LTW_QuanLyDiemDanhChoGV.Properties.Resources._49384_reload_icon;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Location = new System.Drawing.Point(111, 207);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 30);
            this.btnLamMoi.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnLamMoi, "Làm mới");
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiemTKGV
            // 
            this.btnTimKiemTKGV.BackgroundImage = global::ĐA_LTW_QuanLyDiemDanhChoGV.Properties.Resources._172546_search_icon;
            this.btnTimKiemTKGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemTKGV.Location = new System.Drawing.Point(89, 299);
            this.btnTimKiemTKGV.Name = "btnTimKiemTKGV";
            this.btnTimKiemTKGV.Size = new System.Drawing.Size(75, 30);
            this.btnTimKiemTKGV.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnTimKiemTKGV, "Làm mới");
            this.btnTimKiemTKGV.UseVisualStyleBackColor = true;
            this.btnTimKiemTKGV.Click += new System.EventHandler(this.btnTimKiemTK_Click);
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Tài khoản",
            "Ghi chú",
            "Loại tài khoản"});
            this.cboTimKiem.Location = new System.Drawing.Point(89, 272);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(121, 21);
            this.cboTimKiem.TabIndex = 11;
            this.cboTimKiem.SelectedIndexChanged += new System.EventHandler(this.cboTimKiem_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tìm kiếm theo:";
            // 
            // btnCapQuyen
            // 
            this.btnCapQuyen.BackgroundImage = global::ĐA_LTW_QuanLyDiemDanhChoGV.Properties.Resources._85350_accept_icon;
            this.btnCapQuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCapQuyen.Location = new System.Drawing.Point(12, 207);
            this.btnCapQuyen.Name = "btnCapQuyen";
            this.btnCapQuyen.Size = new System.Drawing.Size(75, 30);
            this.btnCapQuyen.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnCapQuyen, "Cấp quyền");
            this.btnCapQuyen.UseVisualStyleBackColor = true;
            this.btnCapQuyen.Click += new System.EventHandler(this.btnCapQuyen_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(70, 71);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(126, 21);
            this.txtGhiChu.TabIndex = 3;
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
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ghi chú:";
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
            // colPQ_GhiChu
            // 
            this.colPQ_GhiChu.DataPropertyName = "GHICHU";
            this.colPQ_GhiChu.HeaderText = "Ghi chú";
            this.colPQ_GhiChu.Name = "colPQ_GhiChu";
            // 
            // colTKSV_MK
            // 
            this.colTKSV_MK.DataPropertyName = "MATKHAU";
            this.colTKSV_MK.HeaderText = "Mật khẩu";
            this.colTKSV_MK.Name = "colTKSV_MK";
            // 
            // TT
            // 
            this.TT.DataPropertyName = "TT";
            this.TT.HeaderText = "TT";
            this.TT.Name = "TT";
            this.TT.Visible = false;
            // 
            // colTKSV_LoaiTaiKhoan
            // 
            this.colTKSV_LoaiTaiKhoan.DataPropertyName = "LOAITAIKHOAN";
            this.colTKSV_LoaiTaiKhoan.HeaderText = "Loại tài khoản";
            this.colTKSV_LoaiTaiKhoan.Name = "colTKSV_LoaiTaiKhoan";
            this.colTKSV_LoaiTaiKhoan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTKSV_LoaiTaiKhoan.Visible = false;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.HeaderText = "TRANGTHAI";
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ghi Chú";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mật khẩu";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tài khoản";
            this.Column1.Name = "Column1";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GHICHU";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // colTKSV_TK
            // 
            this.colTKSV_TK.DataPropertyName = "TAIKHOAN";
            this.colTKSV_TK.HeaderText = "Tài khoản";
            this.colTKSV_TK.Name = "colTKSV_TK";
            // 
            // dgvPhanQuyen
            // 
            this.dgvPhanQuyen.AllowUserToDeleteRows = false;
            this.dgvPhanQuyen.AllowUserToResizeColumns = false;
            this.dgvPhanQuyen.AllowUserToResizeRows = false;
            this.dgvPhanQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhanQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTT,
            this.colPQ_TaiKhoan,
            this.colPQ_LoaiTaiKhoan,
            this.colPQ_TenLoaiTaiKhoan,
            this.colPG_TangThai,
            this.colPQ_GhiChu,
            this.MATKGAU});
            this.dgvPhanQuyen.Location = new System.Drawing.Point(252, 12);
            this.dgvPhanQuyen.Name = "dgvPhanQuyen";
            this.dgvPhanQuyen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPhanQuyen.Size = new System.Drawing.Size(579, 350);
            this.dgvPhanQuyen.TabIndex = 1;
            this.dgvPhanQuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhanQuyen_CellContentClick);
            this.dgvPhanQuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhanQuyen_CellContentClick);
            // 
            // frmQLPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 374);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPhanQuyen);
            this.Name = "frmQLPhanQuyen";
            this.Text = "Cấp quyền tài khoản";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn MATKGAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPG_TangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPQ_TenLoaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPQ_LoaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPQ_TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Label lblLTK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radGiangVien;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiemTKGV;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCapQuyen;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPQ_GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTKSV_MK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTKSV_LoaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTKSV_TK;
        private System.Windows.Forms.DataGridView dgvPhanQuyen;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}