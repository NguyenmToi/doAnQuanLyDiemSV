namespace ĐA_LTW_QuanLyDiemDanhChoGV
{
    partial class frmNganh
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
            this.colNGANH_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNGANH_TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNGANH_TenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNGANH_MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTimKiemThongTin = new System.Windows.Forms.GroupBox();
            this.cboTenKhoa = new System.Windows.Forms.ComboBox();
            this.radTenKhoa = new System.Windows.Forms.RadioButton();
            this.radMaNganh = new System.Windows.Forms.RadioButton();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.radGhiChu = new System.Windows.Forms.RadioButton();
            this.cboTenNganh = new System.Windows.Forms.ComboBox();
            this.cboMaNganh = new System.Windows.Forms.ComboBox();
            this.radTenNganh = new System.Windows.Forms.RadioButton();
            this.colNganh_MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNganh = new System.Windows.Forms.DataGridView();
            this.grpTimKiemThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganh)).BeginInit();
            this.SuspendLayout();
            // 
            // colNGANH_GhiChu
            // 
            this.colNGANH_GhiChu.DataPropertyName = "GHICHU";
            this.colNGANH_GhiChu.HeaderText = "Ghi chú";
            this.colNGANH_GhiChu.MinimumWidth = 6;
            this.colNGANH_GhiChu.Name = "colNGANH_GhiChu";
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "TRANGTHAI";
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = false;
            // 
            // colNGANH_TenKhoa
            // 
            this.colNGANH_TenKhoa.DataPropertyName = "TENKHOA";
            this.colNGANH_TenKhoa.HeaderText = "Tên khoa";
            this.colNGANH_TenKhoa.Name = "colNGANH_TenKhoa";
            // 
            // colNGANH_TenNganh
            // 
            this.colNGANH_TenNganh.DataPropertyName = "TENNGANH";
            this.colNGANH_TenNganh.HeaderText = "Tên ngành";
            this.colNGANH_TenNganh.MinimumWidth = 6;
            this.colNGANH_TenNganh.Name = "colNGANH_TenNganh";
            // 
            // colNGANH_MaNganh
            // 
            this.colNGANH_MaNganh.DataPropertyName = "MANGANH";
            this.colNGANH_MaNganh.HeaderText = "Mã ngành";
            this.colNGANH_MaNganh.MinimumWidth = 6;
            this.colNGANH_MaNganh.Name = "colNGANH_MaNganh";
            // 
            // grpTimKiemThongTin
            // 
            this.grpTimKiemThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiemThongTin.Controls.Add(this.cboTenKhoa);
            this.grpTimKiemThongTin.Controls.Add(this.radTenKhoa);
            this.grpTimKiemThongTin.Controls.Add(this.radMaNganh);
            this.grpTimKiemThongTin.Controls.Add(this.txtGhiChu);
            this.grpTimKiemThongTin.Controls.Add(this.radTatCa);
            this.grpTimKiemThongTin.Controls.Add(this.radGhiChu);
            this.grpTimKiemThongTin.Controls.Add(this.cboTenNganh);
            this.grpTimKiemThongTin.Controls.Add(this.cboMaNganh);
            this.grpTimKiemThongTin.Controls.Add(this.radTenNganh);
            this.grpTimKiemThongTin.Location = new System.Drawing.Point(12, 12);
            this.grpTimKiemThongTin.Name = "grpTimKiemThongTin";
            this.grpTimKiemThongTin.Size = new System.Drawing.Size(776, 112);
            this.grpTimKiemThongTin.TabIndex = 0;
            this.grpTimKiemThongTin.TabStop = false;
            this.grpTimKiemThongTin.Text = "Thông tin ngành";
            // 
            // cboTenKhoa
            // 
            this.cboTenKhoa.FormattingEnabled = true;
            this.cboTenKhoa.Location = new System.Drawing.Point(438, 27);
            this.cboTenKhoa.Name = "cboTenKhoa";
            this.cboTenKhoa.Size = new System.Drawing.Size(148, 21);
            this.cboTenKhoa.TabIndex = 3;
            this.cboTenKhoa.SelectedIndexChanged += new System.EventHandler(this.radTenKhoa_CheckedChanged);
            // 
            // radTenKhoa
            // 
            this.radTenKhoa.AutoSize = true;
            this.radTenKhoa.Location = new System.Drawing.Point(336, 27);
            this.radTenKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTenKhoa.Name = "radTenKhoa";
            this.radTenKhoa.Size = new System.Drawing.Size(73, 17);
            this.radTenKhoa.TabIndex = 2;
            this.radTenKhoa.TabStop = true;
            this.radTenKhoa.Text = "Tên khoa:";
            this.radTenKhoa.UseVisualStyleBackColor = true;
            this.radTenKhoa.CheckedChanged += new System.EventHandler(this.radTenKhoa_CheckedChanged);
            // 
            // radMaNganh
            // 
            this.radMaNganh.AutoSize = true;
            this.radMaNganh.Location = new System.Drawing.Point(6, 26);
            this.radMaNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radMaNganh.Name = "radMaNganh";
            this.radMaNganh.Size = new System.Drawing.Size(76, 17);
            this.radMaNganh.TabIndex = 0;
            this.radMaNganh.TabStop = true;
            this.radMaNganh.Text = "Mã ngành:";
            this.radMaNganh.UseVisualStyleBackColor = true;
            this.radMaNganh.CheckedChanged += new System.EventHandler(this.radMaNganh_CheckedChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(438, 69);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(148, 21);
            this.txtGhiChu.TabIndex = 7;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Location = new System.Drawing.Point(673, 31);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(55, 17);
            this.radTatCa.TabIndex = 8;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.radTatCa_CheckedChanged);
            // 
            // radGhiChu
            // 
            this.radGhiChu.AutoSize = true;
            this.radGhiChu.Location = new System.Drawing.Point(336, 70);
            this.radGhiChu.Name = "radGhiChu";
            this.radGhiChu.Size = new System.Drawing.Size(64, 17);
            this.radGhiChu.TabIndex = 6;
            this.radGhiChu.TabStop = true;
            this.radGhiChu.Text = "Ghi chú:";
            this.radGhiChu.UseVisualStyleBackColor = true;
            this.radGhiChu.CheckedChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // cboTenNganh
            // 
            this.cboTenNganh.FormattingEnabled = true;
            this.cboTenNganh.Location = new System.Drawing.Point(104, 68);
            this.cboTenNganh.Name = "cboTenNganh";
            this.cboTenNganh.Size = new System.Drawing.Size(177, 21);
            this.cboTenNganh.TabIndex = 5;
            this.cboTenNganh.SelectedIndexChanged += new System.EventHandler(this.cboTenNganh_SelectedIndexChanged);
            // 
            // cboMaNganh
            // 
            this.cboMaNganh.FormattingEnabled = true;
            this.cboMaNganh.Location = new System.Drawing.Point(104, 26);
            this.cboMaNganh.Name = "cboMaNganh";
            this.cboMaNganh.Size = new System.Drawing.Size(177, 21);
            this.cboMaNganh.TabIndex = 1;
            this.cboMaNganh.SelectedIndexChanged += new System.EventHandler(this.cboMaNganh_SelectedIndexChanged);
            // 
            // radTenNganh
            // 
            this.radTenNganh.AutoSize = true;
            this.radTenNganh.Location = new System.Drawing.Point(6, 69);
            this.radTenNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTenNganh.Name = "radTenNganh";
            this.radTenNganh.Size = new System.Drawing.Size(80, 17);
            this.radTenNganh.TabIndex = 4;
            this.radTenNganh.TabStop = true;
            this.radTenNganh.Text = "Tên ngành:";
            this.radTenNganh.UseVisualStyleBackColor = true;
            this.radTenNganh.CheckedChanged += new System.EventHandler(this.radTenNganh_CheckedChanged);
            // 
            // colNganh_MaKhoa
            // 
            this.colNganh_MaKhoa.DataPropertyName = "MAKHOA";
            this.colNganh_MaKhoa.HeaderText = "Mã khoa";
            this.colNganh_MaKhoa.MinimumWidth = 6;
            this.colNganh_MaKhoa.Name = "colNganh_MaKhoa";
            this.colNganh_MaKhoa.Visible = false;
            // 
            // dgvNganh
            // 
            this.dgvNganh.AllowUserToResizeColumns = false;
            this.dgvNganh.AllowUserToResizeRows = false;
            this.dgvNganh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNganh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNGANH_MaNganh,
            this.colNGANH_TenNganh,
            this.colNGANH_TenKhoa,
            this.TRANGTHAI,
            this.colNganh_MaKhoa,
            this.colNGANH_GhiChu});
            this.dgvNganh.Location = new System.Drawing.Point(12, 129);
            this.dgvNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNganh.Name = "dgvNganh";
            this.dgvNganh.RowHeadersWidth = 51;
            this.dgvNganh.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNganh.RowTemplate.Height = 24;
            this.dgvNganh.Size = new System.Drawing.Size(776, 167);
            this.dgvNganh.TabIndex = 1;
            this.dgvNganh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNganh_CellContentClick);
            this.dgvNganh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNganh_CellContentClick);
            // 
            // frmNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 307);
            this.Controls.Add(this.grpTimKiemThongTin);
            this.Controls.Add(this.dgvNganh);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNganh";
            this.Text = "Ngành";
            this.Load += new System.EventHandler(this.frmNganh_Load);
            this.grpTimKiemThongTin.ResumeLayout(false);
            this.grpTimKiemThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colNGANH_GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNGANH_TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNGANH_TenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNGANH_MaNganh;
        private System.Windows.Forms.GroupBox grpTimKiemThongTin;
        private System.Windows.Forms.ComboBox cboTenKhoa;
        private System.Windows.Forms.RadioButton radTenKhoa;
        private System.Windows.Forms.RadioButton radMaNganh;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.RadioButton radGhiChu;
        private System.Windows.Forms.ComboBox cboTenNganh;
        private System.Windows.Forms.ComboBox cboMaNganh;
        private System.Windows.Forms.RadioButton radTenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNganh_MaKhoa;
        private System.Windows.Forms.DataGridView dgvNganh;
    }
}