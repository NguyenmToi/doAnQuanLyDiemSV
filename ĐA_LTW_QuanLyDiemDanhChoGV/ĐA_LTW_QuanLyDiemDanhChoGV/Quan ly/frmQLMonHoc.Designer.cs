namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
{
    partial class frmQLMonHoc
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
            this.radSoTinChi = new System.Windows.Forms.RadioButton();
            this.radTenMonHoc = new System.Windows.Forms.RadioButton();
            this.radMaMonHoc = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radGhiChu = new System.Windows.Forms.RadioButton();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cboTenMonHoc = new System.Windows.Forms.ComboBox();
            this.cboMaMonHoc = new System.Windows.Forms.ComboBox();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.colMONHOC_MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMONHOC_TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMONHOC_SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMONHOC_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // radSoTinChi
            // 
            this.radSoTinChi.AutoSize = true;
            this.radSoTinChi.Location = new System.Drawing.Point(401, 23);
            this.radSoTinChi.Name = "radSoTinChi";
            this.radSoTinChi.Size = new System.Drawing.Size(72, 17);
            this.radSoTinChi.TabIndex = 2;
            this.radSoTinChi.TabStop = true;
            this.radSoTinChi.Text = "Số tín chỉ:";
            this.radSoTinChi.UseVisualStyleBackColor = true;
            this.radSoTinChi.CheckedChanged += new System.EventHandler(this.radSoTinChi_CheckedChanged);
            // 
            // radTenMonHoc
            // 
            this.radTenMonHoc.AutoSize = true;
            this.radTenMonHoc.Location = new System.Drawing.Point(25, 65);
            this.radTenMonHoc.Name = "radTenMonHoc";
            this.radTenMonHoc.Size = new System.Drawing.Size(90, 17);
            this.radTenMonHoc.TabIndex = 4;
            this.radTenMonHoc.TabStop = true;
            this.radTenMonHoc.Text = "Tên môn học:";
            this.radTenMonHoc.UseVisualStyleBackColor = true;
            this.radTenMonHoc.CheckedChanged += new System.EventHandler(this.radTenMonHoc_CheckedChanged);
            // 
            // radMaMonHoc
            // 
            this.radMaMonHoc.AutoSize = true;
            this.radMaMonHoc.Location = new System.Drawing.Point(25, 24);
            this.radMaMonHoc.Name = "radMaMonHoc";
            this.radMaMonHoc.Size = new System.Drawing.Size(86, 17);
            this.radMaMonHoc.TabIndex = 0;
            this.radMaMonHoc.TabStop = true;
            this.radMaMonHoc.Text = "Mã môn học:";
            this.radMaMonHoc.UseVisualStyleBackColor = true;
            this.radMaMonHoc.CheckedChanged += new System.EventHandler(this.radMaMonHoc_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radGhiChu);
            this.groupBox1.Controls.Add(this.txtSoTinChi);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.cboTenMonHoc);
            this.groupBox1.Controls.Add(this.cboMaMonHoc);
            this.groupBox1.Controls.Add(this.radSoTinChi);
            this.groupBox1.Controls.Add(this.radTenMonHoc);
            this.groupBox1.Controls.Add(this.radMaMonHoc);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin môn học";
            // 
            // radGhiChu
            // 
            this.radGhiChu.AutoSize = true;
            this.radGhiChu.Location = new System.Drawing.Point(401, 65);
            this.radGhiChu.Name = "radGhiChu";
            this.radGhiChu.Size = new System.Drawing.Size(64, 17);
            this.radGhiChu.TabIndex = 6;
            this.radGhiChu.TabStop = true;
            this.radGhiChu.Text = "Ghi chú:";
            this.radGhiChu.UseVisualStyleBackColor = true;
            this.radGhiChu.CheckedChanged += new System.EventHandler(this.radGhiChu_CheckedChanged);
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Location = new System.Drawing.Point(483, 20);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(150, 21);
            this.txtSoTinChi.TabIndex = 3;
            this.txtSoTinChi.TextChanged += new System.EventHandler(this.txtSoTinChi_TextChanged);
            this.txtSoTinChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTinChi_KeyPress);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(483, 65);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(150, 21);
            this.txtGhiChu.TabIndex = 7;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // cboTenMonHoc
            // 
            this.cboTenMonHoc.FormattingEnabled = true;
            this.cboTenMonHoc.Location = new System.Drawing.Point(122, 65);
            this.cboTenMonHoc.Name = "cboTenMonHoc";
            this.cboTenMonHoc.Size = new System.Drawing.Size(215, 21);
            this.cboTenMonHoc.TabIndex = 5;
            this.cboTenMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboTenMonHoc_SelectedIndexChanged);
            this.cboTenMonHoc.TextUpdate += new System.EventHandler(this.cboTenMonHoc_SelectedIndexChanged);
            // 
            // cboMaMonHoc
            // 
            this.cboMaMonHoc.FormattingEnabled = true;
            this.cboMaMonHoc.Location = new System.Drawing.Point(122, 20);
            this.cboMaMonHoc.Name = "cboMaMonHoc";
            this.cboMaMonHoc.Size = new System.Drawing.Size(126, 21);
            this.cboMaMonHoc.TabIndex = 1;
            this.cboMaMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboMaMonHoc_SelectedIndexChanged);
            this.cboMaMonHoc.TextUpdate += new System.EventHandler(this.cboMaMonHoc_SelectedIndexChanged);
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMONHOC_MaMonHoc,
            this.colMONHOC_TenMonHoc,
            this.colMONHOC_SoTinChi,
            this.colMONHOC_GhiChu,
            this.TRANGTHAI});
            this.dgvMonHoc.Location = new System.Drawing.Point(12, 183);
            this.dgvMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.RowHeadersWidth = 51;
            this.dgvMonHoc.RowTemplate.Height = 24;
            this.dgvMonHoc.Size = new System.Drawing.Size(751, 167);
            this.dgvMonHoc.TabIndex = 2;
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellContentClick);
            this.dgvMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellContentClick);
            // 
            // colMONHOC_MaMonHoc
            // 
            this.colMONHOC_MaMonHoc.DataPropertyName = "MAMH";
            this.colMONHOC_MaMonHoc.HeaderText = "Mã môn học";
            this.colMONHOC_MaMonHoc.MinimumWidth = 6;
            this.colMONHOC_MaMonHoc.Name = "colMONHOC_MaMonHoc";
            // 
            // colMONHOC_TenMonHoc
            // 
            this.colMONHOC_TenMonHoc.DataPropertyName = "TENMH";
            this.colMONHOC_TenMonHoc.HeaderText = "Tên môn học";
            this.colMONHOC_TenMonHoc.MinimumWidth = 6;
            this.colMONHOC_TenMonHoc.Name = "colMONHOC_TenMonHoc";
            // 
            // colMONHOC_SoTinChi
            // 
            this.colMONHOC_SoTinChi.DataPropertyName = "SOTINCHI";
            this.colMONHOC_SoTinChi.HeaderText = "Số tín chỉ";
            this.colMONHOC_SoTinChi.MinimumWidth = 6;
            this.colMONHOC_SoTinChi.Name = "colMONHOC_SoTinChi";
            // 
            // colMONHOC_GhiChu
            // 
            this.colMONHOC_GhiChu.DataPropertyName = "GHICHU";
            this.colMONHOC_GhiChu.HeaderText = "Ghi chú";
            this.colMONHOC_GhiChu.MinimumWidth = 6;
            this.colMONHOC_GhiChu.Name = "colMONHOC_GhiChu";
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "TRANGTHAI";
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = false;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChucNang.Controls.Add(this.btnLamMoi);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Controls.Add(this.btnSua);
            this.grpChucNang.Location = new System.Drawing.Point(412, 118);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(350, 60);
            this.grpChucNang.TabIndex = 1;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            this.grpChucNang.Enter += new System.EventHandler(this.grpChucNang_Enter);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImage = global::ĐA_LTW_QuanLyDiemDanhChoGV.Properties.Resources._49384_reload_icon;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Location = new System.Drawing.Point(265, 19);
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
            this.btnXoa.Location = new System.Drawing.Point(184, 19);
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
            this.btnThem.Location = new System.Drawing.Point(22, 19);
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
            this.btnSua.Location = new System.Drawing.Point(103, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnSua, "Cập nhật");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmQLMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 361);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMonHoc);
            this.Name = "frmQLMonHoc";
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.frmQLMonHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radSoTinChi;
        private System.Windows.Forms.RadioButton radTenMonHoc;
        private System.Windows.Forms.RadioButton radMaMonHoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ComboBox cboTenMonHoc;
        private System.Windows.Forms.ComboBox cboMaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMONHOC_MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMONHOC_TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMONHOC_SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMONHOC_GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.RadioButton radGhiChu;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}