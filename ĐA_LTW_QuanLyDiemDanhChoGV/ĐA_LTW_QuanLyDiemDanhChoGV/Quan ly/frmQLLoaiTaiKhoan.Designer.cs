namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
{
    partial class frmQLLoaiTaiKhoan
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
            this.dgvLoaiTaiKhoan = new System.Windows.Forms.DataGridView();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLTK_MaLoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLTK_TenLoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLTK_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.radGhiChu = new System.Windows.Forms.RadioButton();
            this.cboTenLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.cboMaLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.radTenLoaiTaiKhoan = new System.Windows.Forms.RadioButton();
            this.radMaLoaiTaiKhoan = new System.Windows.Forms.RadioButton();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTaiKhoan)).BeginInit();
            this.grpChucNang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoaiTaiKhoan
            // 
            this.dgvLoaiTaiKhoan.AllowUserToResizeColumns = false;
            this.dgvLoaiTaiKhoan.AllowUserToResizeRows = false;
            this.dgvLoaiTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoaiTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TRANGTHAI,
            this.colLTK_MaLoaiTaiKhoan,
            this.colLTK_TenLoaiTaiKhoan,
            this.colLTK_GhiChu});
            this.dgvLoaiTaiKhoan.Location = new System.Drawing.Point(12, 181);
            this.dgvLoaiTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLoaiTaiKhoan.Name = "dgvLoaiTaiKhoan";
            this.dgvLoaiTaiKhoan.RowHeadersWidth = 51;
            this.dgvLoaiTaiKhoan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLoaiTaiKhoan.RowTemplate.Height = 24;
            this.dgvLoaiTaiKhoan.Size = new System.Drawing.Size(825, 179);
            this.dgvLoaiTaiKhoan.TabIndex = 2;
            this.dgvLoaiTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiTaiKhoan_CellContentClick);
            this.dgvLoaiTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiTaiKhoan_CellContentClick);
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "TRANGTHAI";
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = false;
            // 
            // colLTK_MaLoaiTaiKhoan
            // 
            this.colLTK_MaLoaiTaiKhoan.DataPropertyName = "MALOAITAIKHOAN";
            this.colLTK_MaLoaiTaiKhoan.HeaderText = "Mã loại tài khoản";
            this.colLTK_MaLoaiTaiKhoan.Name = "colLTK_MaLoaiTaiKhoan";
            // 
            // colLTK_TenLoaiTaiKhoan
            // 
            this.colLTK_TenLoaiTaiKhoan.DataPropertyName = "TENLOAITAIKHOAN";
            this.colLTK_TenLoaiTaiKhoan.HeaderText = "Tên loại tài khoản";
            this.colLTK_TenLoaiTaiKhoan.MinimumWidth = 6;
            this.colLTK_TenLoaiTaiKhoan.Name = "colLTK_TenLoaiTaiKhoan";
            // 
            // colLTK_GhiChu
            // 
            this.colLTK_GhiChu.DataPropertyName = "GHICHU";
            this.colLTK_GhiChu.HeaderText = "Ghi chú";
            this.colLTK_GhiChu.MinimumWidth = 6;
            this.colLTK_GhiChu.Name = "colLTK_GhiChu";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(469, 19);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(167, 21);
            this.txtGhiChu.TabIndex = 3;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Location = new System.Drawing.Point(394, 67);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(55, 17);
            this.radTatCa.TabIndex = 6;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.radTatCa_CheckedChanged);
            // 
            // radGhiChu
            // 
            this.radGhiChu.AutoSize = true;
            this.radGhiChu.Location = new System.Drawing.Point(394, 20);
            this.radGhiChu.Name = "radGhiChu";
            this.radGhiChu.Size = new System.Drawing.Size(64, 17);
            this.radGhiChu.TabIndex = 2;
            this.radGhiChu.TabStop = true;
            this.radGhiChu.Text = "Ghi chú:";
            this.radGhiChu.UseVisualStyleBackColor = true;
            this.radGhiChu.CheckedChanged += new System.EventHandler(this.radGhiChu_CheckedChanged);
            // 
            // cboTenLoaiTaiKhoan
            // 
            this.cboTenLoaiTaiKhoan.FormattingEnabled = true;
            this.cboTenLoaiTaiKhoan.Location = new System.Drawing.Point(121, 63);
            this.cboTenLoaiTaiKhoan.Name = "cboTenLoaiTaiKhoan";
            this.cboTenLoaiTaiKhoan.Size = new System.Drawing.Size(167, 21);
            this.cboTenLoaiTaiKhoan.TabIndex = 5;
            this.cboTenLoaiTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.cboTenLoaiTaiKhoan_SelectedIndexChanged);
            this.cboTenLoaiTaiKhoan.TextUpdate += new System.EventHandler(this.cboTenLoaiTaiKhoan_SelectedIndexChanged);
            this.cboTenLoaiTaiKhoan.TextChanged += new System.EventHandler(this.cboTenLoaiTaiKhoan_SelectedIndexChanged);
            // 
            // cboMaLoaiTaiKhoan
            // 
            this.cboMaLoaiTaiKhoan.FormattingEnabled = true;
            this.cboMaLoaiTaiKhoan.Location = new System.Drawing.Point(121, 23);
            this.cboMaLoaiTaiKhoan.Name = "cboMaLoaiTaiKhoan";
            this.cboMaLoaiTaiKhoan.Size = new System.Drawing.Size(167, 21);
            this.cboMaLoaiTaiKhoan.TabIndex = 1;
            this.cboMaLoaiTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.cboMaLoaiTaiKhoan_SelectedIndexChanged);
            this.cboMaLoaiTaiKhoan.TextUpdate += new System.EventHandler(this.cboMaLoaiTaiKhoan_TextChanged);
            this.cboMaLoaiTaiKhoan.TextChanged += new System.EventHandler(this.cboMaLoaiTaiKhoan_TextChanged);
            this.cboMaLoaiTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboMaLoaiTaiKhoan_KeyPress);
            // 
            // radTenLoaiTaiKhoan
            // 
            this.radTenLoaiTaiKhoan.AutoSize = true;
            this.radTenLoaiTaiKhoan.Location = new System.Drawing.Point(6, 65);
            this.radTenLoaiTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTenLoaiTaiKhoan.Name = "radTenLoaiTaiKhoan";
            this.radTenLoaiTaiKhoan.Size = new System.Drawing.Size(113, 17);
            this.radTenLoaiTaiKhoan.TabIndex = 4;
            this.radTenLoaiTaiKhoan.TabStop = true;
            this.radTenLoaiTaiKhoan.Text = "Tên loại tài khoản:";
            this.radTenLoaiTaiKhoan.UseVisualStyleBackColor = true;
            this.radTenLoaiTaiKhoan.CheckedChanged += new System.EventHandler(this.radTenLoaiTaiKhoan_CheckedChanged);
            // 
            // radMaLoaiTaiKhoan
            // 
            this.radMaLoaiTaiKhoan.AutoSize = true;
            this.radMaLoaiTaiKhoan.Location = new System.Drawing.Point(6, 24);
            this.radMaLoaiTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radMaLoaiTaiKhoan.Name = "radMaLoaiTaiKhoan";
            this.radMaLoaiTaiKhoan.Size = new System.Drawing.Size(109, 17);
            this.radMaLoaiTaiKhoan.TabIndex = 0;
            this.radMaLoaiTaiKhoan.TabStop = true;
            this.radMaLoaiTaiKhoan.Text = "Mã loại tài khoản:";
            this.radMaLoaiTaiKhoan.UseVisualStyleBackColor = true;
            this.radMaLoaiTaiKhoan.CheckedChanged += new System.EventHandler(this.radMaLoaiTaiKhoan_CheckedChanged);
            // 
            // grpChucNang
            // 
            this.grpChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChucNang.Controls.Add(this.btnLamMoi);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Controls.Add(this.btnSua);
            this.grpChucNang.Location = new System.Drawing.Point(479, 116);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(358, 60);
            this.grpChucNang.TabIndex = 1;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.radTatCa);
            this.groupBox1.Controls.Add(this.radGhiChu);
            this.groupBox1.Controls.Add(this.cboTenLoaiTaiKhoan);
            this.groupBox1.Controls.Add(this.cboMaLoaiTaiKhoan);
            this.groupBox1.Controls.Add(this.radTenLoaiTaiKhoan);
            this.groupBox1.Controls.Add(this.radMaLoaiTaiKhoan);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(825, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại tài khoản";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImage = global::ĐA_LTW_QuanLyDiemDanhChoGV.Properties.Resources._49384_reload_icon;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Location = new System.Drawing.Point(260, 19);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 32);
            this.btnLamMoi.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnLamMoi, "Làm mới");
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::ĐA_LTW_QuanLyDiemDanhChoGV.Properties.Resources._326606_delete_icon;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Location = new System.Drawing.Point(179, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 32);
            this.btnXoa.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::ĐA_LTW_QuanLyDiemDanhChoGV.Properties.Resources._299068_add_sign_icon;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Location = new System.Drawing.Point(17, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::ĐA_LTW_QuanLyDiemDanhChoGV.Properties.Resources.upload;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Location = new System.Drawing.Point(98, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnSua, "Cập nhật");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmQLLoaiTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 371);
            this.Controls.Add(this.dgvLoaiTaiKhoan);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLLoaiTaiKhoan";
            this.Text = "Loại tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTaiKhoan)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLoaiTaiKhoan;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.RadioButton radGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboTenLoaiTaiKhoan;
        private System.Windows.Forms.ComboBox cboMaLoaiTaiKhoan;
        private System.Windows.Forms.RadioButton radTenLoaiTaiKhoan;
        private System.Windows.Forms.RadioButton radMaLoaiTaiKhoan;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLTK_MaLoaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLTK_TenLoaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLTK_GhiChu;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}