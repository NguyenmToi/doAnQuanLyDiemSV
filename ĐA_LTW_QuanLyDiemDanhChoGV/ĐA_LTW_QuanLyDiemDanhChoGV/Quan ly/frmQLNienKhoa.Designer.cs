namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
{
    partial class frmQLNienKhoa
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
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.radGhiChu = new System.Windows.Forms.RadioButton();
            this.cboTenNienKhoa = new System.Windows.Forms.ComboBox();
            this.cboMaNienKhoa = new System.Windows.Forms.ComboBox();
            this.radTenNienKhoa = new System.Windows.Forms.RadioButton();
            this.radMaNienKhoa = new System.Windows.Forms.RadioButton();
            this.dgvNienKhoa = new System.Windows.Forms.DataGridView();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNIENKHOA_MaNienKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNIENKHOA_TenNienKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNIENKHOA_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpChucNang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNienKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChucNang
            // 
            this.grpChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChucNang.Controls.Add(this.btnLamMoi);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Controls.Add(this.btnSua);
            this.grpChucNang.Location = new System.Drawing.Point(409, 127);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(358, 60);
            this.grpChucNang.TabIndex = 1;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            this.grpChucNang.Enter += new System.EventHandler(this.grpChucNang_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.radTatCa);
            this.groupBox1.Controls.Add(this.radGhiChu);
            this.groupBox1.Controls.Add(this.cboTenNienKhoa);
            this.groupBox1.Controls.Add(this.cboMaNienKhoa);
            this.groupBox1.Controls.Add(this.radTenNienKhoa);
            this.groupBox1.Controls.Add(this.radMaNienKhoa);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(755, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin niên khóa";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(467, 19);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(211, 32);
            this.txtGhiChu.TabIndex = 3;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Location = new System.Drawing.Point(397, 73);
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
            this.radGhiChu.Location = new System.Drawing.Point(397, 26);
            this.radGhiChu.Name = "radGhiChu";
            this.radGhiChu.Size = new System.Drawing.Size(64, 17);
            this.radGhiChu.TabIndex = 2;
            this.radGhiChu.TabStop = true;
            this.radGhiChu.Text = "Ghi chú:";
            this.radGhiChu.UseVisualStyleBackColor = true;
            this.radGhiChu.CheckedChanged += new System.EventHandler(this.radGhiChu_CheckedChanged);
            // 
            // cboTenNienKhoa
            // 
            this.cboTenNienKhoa.FormattingEnabled = true;
            this.cboTenNienKhoa.Location = new System.Drawing.Point(104, 69);
            this.cboTenNienKhoa.Name = "cboTenNienKhoa";
            this.cboTenNienKhoa.Size = new System.Drawing.Size(148, 21);
            this.cboTenNienKhoa.TabIndex = 5;
            this.cboTenNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cboTenNienKhoa_SelectedIndexChanged);
            this.cboTenNienKhoa.TextUpdate += new System.EventHandler(this.cboTenNienKhoa_SelectedIndexChanged);
            // 
            // cboMaNienKhoa
            // 
            this.cboMaNienKhoa.FormattingEnabled = true;
            this.cboMaNienKhoa.Location = new System.Drawing.Point(104, 26);
            this.cboMaNienKhoa.Name = "cboMaNienKhoa";
            this.cboMaNienKhoa.Size = new System.Drawing.Size(148, 21);
            this.cboMaNienKhoa.TabIndex = 1;
            this.cboMaNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cboMaNienKhoa_SelectedIndexChanged);
            this.cboMaNienKhoa.TextUpdate += new System.EventHandler(this.cboMaNienKhoa_SelectedIndexChanged);
            // 
            // radTenNienKhoa
            // 
            this.radTenNienKhoa.AutoSize = true;
            this.radTenNienKhoa.Location = new System.Drawing.Point(9, 71);
            this.radTenNienKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTenNienKhoa.Name = "radTenNienKhoa";
            this.radTenNienKhoa.Size = new System.Drawing.Size(96, 17);
            this.radTenNienKhoa.TabIndex = 4;
            this.radTenNienKhoa.TabStop = true;
            this.radTenNienKhoa.Text = "Tên niên khóa:";
            this.radTenNienKhoa.UseVisualStyleBackColor = true;
            this.radTenNienKhoa.CheckedChanged += new System.EventHandler(this.radTenNienKhoa_CheckedChanged);
            // 
            // radMaNienKhoa
            // 
            this.radMaNienKhoa.AutoSize = true;
            this.radMaNienKhoa.Location = new System.Drawing.Point(9, 30);
            this.radMaNienKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radMaNienKhoa.Name = "radMaNienKhoa";
            this.radMaNienKhoa.Size = new System.Drawing.Size(92, 17);
            this.radMaNienKhoa.TabIndex = 0;
            this.radMaNienKhoa.TabStop = true;
            this.radMaNienKhoa.Text = "Mã niên khóa:";
            this.radMaNienKhoa.UseVisualStyleBackColor = true;
            this.radMaNienKhoa.CheckedChanged += new System.EventHandler(this.radMaNienKhoa_CheckedChanged);
            // 
            // dgvNienKhoa
            // 
            this.dgvNienKhoa.AllowUserToResizeColumns = false;
            this.dgvNienKhoa.AllowUserToResizeRows = false;
            this.dgvNienKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNienKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNienKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNienKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TRANGTHAI,
            this.colNIENKHOA_MaNienKhoa,
            this.colNIENKHOA_TenNienKhoa,
            this.colNIENKHOA_GhiChu});
            this.dgvNienKhoa.Location = new System.Drawing.Point(12, 192);
            this.dgvNienKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNienKhoa.Name = "dgvNienKhoa";
            this.dgvNienKhoa.RowHeadersWidth = 51;
            this.dgvNienKhoa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNienKhoa.RowTemplate.Height = 24;
            this.dgvNienKhoa.Size = new System.Drawing.Size(755, 184);
            this.dgvNienKhoa.TabIndex = 2;
            this.dgvNienKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNienKhoa_CellContentClick);
            this.dgvNienKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNienKhoa_CellContentClick);
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "TRANGTHAI";
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = false;
            // 
            // colNIENKHOA_MaNienKhoa
            // 
            this.colNIENKHOA_MaNienKhoa.DataPropertyName = "MANIENKHOA";
            this.colNIENKHOA_MaNienKhoa.FillWeight = 80F;
            this.colNIENKHOA_MaNienKhoa.HeaderText = "Mã niên khóa";
            this.colNIENKHOA_MaNienKhoa.Name = "colNIENKHOA_MaNienKhoa";
            // 
            // colNIENKHOA_TenNienKhoa
            // 
            this.colNIENKHOA_TenNienKhoa.DataPropertyName = "TENNIENKHOA";
            this.colNIENKHOA_TenNienKhoa.FillWeight = 80F;
            this.colNIENKHOA_TenNienKhoa.HeaderText = "Tên niên khóa";
            this.colNIENKHOA_TenNienKhoa.MinimumWidth = 6;
            this.colNIENKHOA_TenNienKhoa.Name = "colNIENKHOA_TenNienKhoa";
            // 
            // colNIENKHOA_GhiChu
            // 
            this.colNIENKHOA_GhiChu.DataPropertyName = "GHICHU";
            this.colNIENKHOA_GhiChu.FillWeight = 140F;
            this.colNIENKHOA_GhiChu.HeaderText = "Ghi chú";
            this.colNIENKHOA_GhiChu.MinimumWidth = 6;
            this.colNIENKHOA_GhiChu.Name = "colNIENKHOA_GhiChu";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImage = global::ĐA_LTW_QuanLyDiemDanhChoGV.Properties.Resources._49384_reload_icon;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Location = new System.Drawing.Point(260, 19);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 32);
            this.btnLamMoi.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnLamMoi, "làm mới");
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
            // frmQLNienKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 387);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNienKhoa);
            this.Name = "frmQLNienKhoa";
            this.Text = "Niên khóa";
            this.grpChucNang.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNienKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.RadioButton radGhiChu;
        private System.Windows.Forms.ComboBox cboTenNienKhoa;
        private System.Windows.Forms.ComboBox cboMaNienKhoa;
        private System.Windows.Forms.RadioButton radTenNienKhoa;
        private System.Windows.Forms.RadioButton radMaNienKhoa;
        private System.Windows.Forms.DataGridView dgvNienKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNIENKHOA_MaNienKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNIENKHOA_TenNienKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNIENKHOA_GhiChu;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}