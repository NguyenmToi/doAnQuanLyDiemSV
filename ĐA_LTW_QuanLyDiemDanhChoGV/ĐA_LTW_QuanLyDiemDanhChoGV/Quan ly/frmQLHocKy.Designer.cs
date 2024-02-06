namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
{
    partial class frmQLHocKy
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
            this.radMaHocKy = new System.Windows.Forms.RadioButton();
            this.grpTimKiemThongTin = new System.Windows.Forms.GroupBox();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.cboTenHocKy = new System.Windows.Forms.ComboBox();
            this.cboMaHocKy = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.radGhiChu = new System.Windows.Forms.RadioButton();
            this.radTenHocKy = new System.Windows.Forms.RadioButton();
            this.dgvHocKy = new System.Windows.Forms.DataGridView();
            this.colHOCKY_MaHocKY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHOCKY_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHOCKY_TenHocKY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHOCKY_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpTimKiemThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).BeginInit();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // radMaHocKy
            // 
            this.radMaHocKy.AutoSize = true;
            this.radMaHocKy.Location = new System.Drawing.Point(6, 25);
            this.radMaHocKy.Name = "radMaHocKy";
            this.radMaHocKy.Size = new System.Drawing.Size(77, 17);
            this.radMaHocKy.TabIndex = 0;
            this.radMaHocKy.TabStop = true;
            this.radMaHocKy.Text = "Mã học kỳ:";
            this.radMaHocKy.UseVisualStyleBackColor = true;
            this.radMaHocKy.CheckedChanged += new System.EventHandler(this.radMaHocKy_CheckedChanged);
            // 
            // grpTimKiemThongTin
            // 
            this.grpTimKiemThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiemThongTin.Controls.Add(this.radTatCa);
            this.grpTimKiemThongTin.Controls.Add(this.cboTenHocKy);
            this.grpTimKiemThongTin.Controls.Add(this.cboMaHocKy);
            this.grpTimKiemThongTin.Controls.Add(this.txtGhiChu);
            this.grpTimKiemThongTin.Controls.Add(this.radGhiChu);
            this.grpTimKiemThongTin.Controls.Add(this.radTenHocKy);
            this.grpTimKiemThongTin.Controls.Add(this.radMaHocKy);
            this.grpTimKiemThongTin.Location = new System.Drawing.Point(12, 12);
            this.grpTimKiemThongTin.Name = "grpTimKiemThongTin";
            this.grpTimKiemThongTin.Size = new System.Drawing.Size(743, 95);
            this.grpTimKiemThongTin.TabIndex = 1;
            this.grpTimKiemThongTin.TabStop = false;
            this.grpTimKiemThongTin.Text = "Thông tin học kỳ";
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Location = new System.Drawing.Point(337, 61);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(55, 17);
            this.radTatCa.TabIndex = 6;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.radTatCa_CheckedChanged);
            // 
            // cboTenHocKy
            // 
            this.cboTenHocKy.FormattingEnabled = true;
            this.cboTenHocKy.Location = new System.Drawing.Point(89, 61);
            this.cboTenHocKy.Name = "cboTenHocKy";
            this.cboTenHocKy.Size = new System.Drawing.Size(160, 21);
            this.cboTenHocKy.TabIndex = 5;
            this.cboTenHocKy.SelectedIndexChanged += new System.EventHandler(this.cboTenHocKy_SelectedIndexChanged);
            this.cboTenHocKy.TextUpdate += new System.EventHandler(this.cboTenHocKy_SelectedIndexChanged);
            // 
            // cboMaHocKy
            // 
            this.cboMaHocKy.FormattingEnabled = true;
            this.cboMaHocKy.Location = new System.Drawing.Point(89, 22);
            this.cboMaHocKy.Name = "cboMaHocKy";
            this.cboMaHocKy.Size = new System.Drawing.Size(160, 21);
            this.cboMaHocKy.TabIndex = 1;
            this.cboMaHocKy.SelectedIndexChanged += new System.EventHandler(this.cboMaHocKy_SelectedIndexChanged);
            this.cboMaHocKy.TextUpdate += new System.EventHandler(this.cboMaHocKy_SelectedIndexChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(407, 20);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(160, 21);
            this.txtGhiChu.TabIndex = 3;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // radGhiChu
            // 
            this.radGhiChu.AutoSize = true;
            this.radGhiChu.Location = new System.Drawing.Point(337, 22);
            this.radGhiChu.Name = "radGhiChu";
            this.radGhiChu.Size = new System.Drawing.Size(64, 17);
            this.radGhiChu.TabIndex = 2;
            this.radGhiChu.TabStop = true;
            this.radGhiChu.Text = "Ghi chú:";
            this.radGhiChu.UseVisualStyleBackColor = true;
            this.radGhiChu.CheckedChanged += new System.EventHandler(this.radGhiChu_CheckedChanged);
            // 
            // radTenHocKy
            // 
            this.radTenHocKy.AutoSize = true;
            this.radTenHocKy.Location = new System.Drawing.Point(6, 62);
            this.radTenHocKy.Name = "radTenHocKy";
            this.radTenHocKy.Size = new System.Drawing.Size(81, 17);
            this.radTenHocKy.TabIndex = 4;
            this.radTenHocKy.TabStop = true;
            this.radTenHocKy.Text = "Tên học kỳ:";
            this.radTenHocKy.UseVisualStyleBackColor = true;
            this.radTenHocKy.CheckedChanged += new System.EventHandler(this.radTenHocKy_CheckedChanged);
            // 
            // dgvHocKy
            // 
            this.dgvHocKy.AllowUserToResizeColumns = false;
            this.dgvHocKy.AllowUserToResizeRows = false;
            this.dgvHocKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHocKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHOCKY_MaHocKY,
            this.colHOCKY_TrangThai,
            this.colHOCKY_TenHocKY,
            this.colHOCKY_GhiChu});
            this.dgvHocKy.Location = new System.Drawing.Point(12, 178);
            this.dgvHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHocKy.Name = "dgvHocKy";
            this.dgvHocKy.RowHeadersWidth = 51;
            this.dgvHocKy.RowTemplate.Height = 24;
            this.dgvHocKy.Size = new System.Drawing.Size(743, 174);
            this.dgvHocKy.TabIndex = 1;
            this.dgvHocKy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocKy_CellContentClick);
            // 
            // colHOCKY_MaHocKY
            // 
            this.colHOCKY_MaHocKY.DataPropertyName = "MAHOCKY";
            this.colHOCKY_MaHocKY.HeaderText = "Mã học kỳ";
            this.colHOCKY_MaHocKY.MinimumWidth = 6;
            this.colHOCKY_MaHocKY.Name = "colHOCKY_MaHocKY";
            // 
            // colHOCKY_TrangThai
            // 
            this.colHOCKY_TrangThai.DataPropertyName = "TRANGTHAI";
            this.colHOCKY_TrangThai.HeaderText = "Trạng thái";
            this.colHOCKY_TrangThai.MinimumWidth = 6;
            this.colHOCKY_TrangThai.Name = "colHOCKY_TrangThai";
            this.colHOCKY_TrangThai.Visible = false;
            // 
            // colHOCKY_TenHocKY
            // 
            this.colHOCKY_TenHocKY.DataPropertyName = "TENHOCKY";
            this.colHOCKY_TenHocKY.HeaderText = "Tên học kỳ";
            this.colHOCKY_TenHocKY.MinimumWidth = 6;
            this.colHOCKY_TenHocKY.Name = "colHOCKY_TenHocKY";
            // 
            // colHOCKY_GhiChu
            // 
            this.colHOCKY_GhiChu.DataPropertyName = "GHICHU";
            this.colHOCKY_GhiChu.HeaderText = "Ghi chú";
            this.colHOCKY_GhiChu.MinimumWidth = 6;
            this.colHOCKY_GhiChu.Name = "colHOCKY_GhiChu";
            // 
            // grpChucNang
            // 
            this.grpChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChucNang.Controls.Add(this.btnLamMoi);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Controls.Add(this.btnSua);
            this.grpChucNang.Location = new System.Drawing.Point(400, 113);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(355, 60);
            this.grpChucNang.TabIndex = 0;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImage = global::ĐA_LTW_QuanLyDiemDanhChoGV.Properties.Resources._49384_reload_icon;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Location = new System.Drawing.Point(260, 19);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 32);
            this.btnLamMoi.TabIndex = 0;
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
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
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
            this.btnThem.TabIndex = 1;
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
            this.btnSua.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSua, "Cập nhật");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmQLHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 363);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpTimKiemThongTin);
            this.Controls.Add(this.dgvHocKy);
            this.Name = "frmQLHocKy";
            this.Text = "Học kỳ";
            this.Load += new System.EventHandler(this.frmQLHocKy_Load);
            this.grpTimKiemThongTin.ResumeLayout(false);
            this.grpTimKiemThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radMaHocKy;
        private System.Windows.Forms.GroupBox grpTimKiemThongTin;
        private System.Windows.Forms.RadioButton radTenHocKy;
        private System.Windows.Forms.DataGridView dgvHocKy;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.RadioButton radGhiChu;
        private System.Windows.Forms.ComboBox cboTenHocKy;
        private System.Windows.Forms.ComboBox cboMaHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHOCKY_MaHocKY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHOCKY_TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHOCKY_TenHocKY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHOCKY_GhiChu;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}