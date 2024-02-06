namespace ĐA_LTW_QuanLyDiemDanhChoGV
{
    partial class frmHocKy
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
            this.dgvHocKy = new System.Windows.Forms.DataGridView();
            this.colHOCKY_MaHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHOCKY_TenHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHOCKY_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHOCKY_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTimKiemThongTin = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.cboTenHocKy = new System.Windows.Forms.ComboBox();
            this.cboMaHocKy = new System.Windows.Forms.ComboBox();
            this.radTenHocKy = new System.Windows.Forms.RadioButton();
            this.radGhiChu = new System.Windows.Forms.RadioButton();
            this.radMaHocKy = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).BeginInit();
            this.grpTimKiemThongTin.SuspendLayout();
            this.SuspendLayout();
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
            this.colHOCKY_MaHocKy,
            this.colHOCKY_TenHocKy,
            this.colHOCKY_GhiChu,
            this.colHOCKY_TrangThai});
            this.dgvHocKy.Location = new System.Drawing.Point(12, 107);
            this.dgvHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHocKy.Name = "dgvHocKy";
            this.dgvHocKy.RowHeadersWidth = 51;
            this.dgvHocKy.RowTemplate.Height = 24;
            this.dgvHocKy.Size = new System.Drawing.Size(690, 151);
            this.dgvHocKy.TabIndex = 0;
            this.dgvHocKy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocKy_CellContentClick);
            this.dgvHocKy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocKy_CellContentClick);
            // 
            // colHOCKY_MaHocKy
            // 
            this.colHOCKY_MaHocKy.DataPropertyName = "MAHOCKY";
            this.colHOCKY_MaHocKy.HeaderText = "Mã học kỳ";
            this.colHOCKY_MaHocKy.MinimumWidth = 6;
            this.colHOCKY_MaHocKy.Name = "colHOCKY_MaHocKy";
            // 
            // colHOCKY_TenHocKy
            // 
            this.colHOCKY_TenHocKy.DataPropertyName = "TENHOCKY";
            this.colHOCKY_TenHocKy.HeaderText = "Tên học kỳ";
            this.colHOCKY_TenHocKy.MinimumWidth = 6;
            this.colHOCKY_TenHocKy.Name = "colHOCKY_TenHocKy";
            // 
            // colHOCKY_GhiChu
            // 
            this.colHOCKY_GhiChu.DataPropertyName = "GHICHU";
            this.colHOCKY_GhiChu.HeaderText = "Ghi chú";
            this.colHOCKY_GhiChu.MinimumWidth = 6;
            this.colHOCKY_GhiChu.Name = "colHOCKY_GhiChu";
            // 
            // colHOCKY_TrangThai
            // 
            this.colHOCKY_TrangThai.DataPropertyName = "TRANGTHAI";
            this.colHOCKY_TrangThai.HeaderText = "Trạng thái";
            this.colHOCKY_TrangThai.MinimumWidth = 6;
            this.colHOCKY_TrangThai.Name = "colHOCKY_TrangThai";
            this.colHOCKY_TrangThai.Visible = false;
            // 
            // grpTimKiemThongTin
            // 
            this.grpTimKiemThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiemThongTin.Controls.Add(this.txtGhiChu);
            this.grpTimKiemThongTin.Controls.Add(this.radTatCa);
            this.grpTimKiemThongTin.Controls.Add(this.cboTenHocKy);
            this.grpTimKiemThongTin.Controls.Add(this.cboMaHocKy);
            this.grpTimKiemThongTin.Controls.Add(this.radTenHocKy);
            this.grpTimKiemThongTin.Controls.Add(this.radGhiChu);
            this.grpTimKiemThongTin.Controls.Add(this.radMaHocKy);
            this.grpTimKiemThongTin.Location = new System.Drawing.Point(11, 12);
            this.grpTimKiemThongTin.Name = "grpTimKiemThongTin";
            this.grpTimKiemThongTin.Size = new System.Drawing.Size(690, 90);
            this.grpTimKiemThongTin.TabIndex = 0;
            this.grpTimKiemThongTin.TabStop = false;
            this.grpTimKiemThongTin.Text = "Thông tin học kỳ";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(403, 23);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(160, 21);
            this.txtGhiChu.TabIndex = 3;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Location = new System.Drawing.Point(333, 59);
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
            this.cboTenHocKy.Location = new System.Drawing.Point(90, 58);
            this.cboTenHocKy.Name = "cboTenHocKy";
            this.cboTenHocKy.Size = new System.Drawing.Size(160, 21);
            this.cboTenHocKy.TabIndex = 5;
            this.cboTenHocKy.SelectedIndexChanged += new System.EventHandler(this.cboTenHocKy_SelectedIndexChanged);
            this.cboTenHocKy.TextUpdate += new System.EventHandler(this.cboTenHocKy_SelectedIndexChanged);
            // 
            // cboMaHocKy
            // 
            this.cboMaHocKy.FormattingEnabled = true;
            this.cboMaHocKy.Location = new System.Drawing.Point(90, 24);
            this.cboMaHocKy.Name = "cboMaHocKy";
            this.cboMaHocKy.Size = new System.Drawing.Size(160, 21);
            this.cboMaHocKy.TabIndex = 1;
            this.cboMaHocKy.SelectedIndexChanged += new System.EventHandler(this.cboMaHocKy_SelectedIndexChanged);
            this.cboMaHocKy.TextUpdate += new System.EventHandler(this.cboMaHocKy_SelectedIndexChanged);
            // 
            // radTenHocKy
            // 
            this.radTenHocKy.AutoSize = true;
            this.radTenHocKy.Location = new System.Drawing.Point(6, 58);
            this.radTenHocKy.Name = "radTenHocKy";
            this.radTenHocKy.Size = new System.Drawing.Size(81, 17);
            this.radTenHocKy.TabIndex = 4;
            this.radTenHocKy.TabStop = true;
            this.radTenHocKy.Text = "Tên học kỳ:";
            this.radTenHocKy.UseVisualStyleBackColor = true;
            this.radTenHocKy.CheckedChanged += new System.EventHandler(this.radTenHocKy_CheckedChanged);
            // 
            // radGhiChu
            // 
            this.radGhiChu.AutoSize = true;
            this.radGhiChu.Location = new System.Drawing.Point(333, 25);
            this.radGhiChu.Name = "radGhiChu";
            this.radGhiChu.Size = new System.Drawing.Size(64, 17);
            this.radGhiChu.TabIndex = 2;
            this.radGhiChu.TabStop = true;
            this.radGhiChu.Text = "Ghi chú:";
            this.radGhiChu.UseVisualStyleBackColor = true;
            this.radGhiChu.CheckedChanged += new System.EventHandler(this.radGhiChu_CheckedChanged);
            // 
            // radMaHocKy
            // 
            this.radMaHocKy.AutoSize = true;
            this.radMaHocKy.Location = new System.Drawing.Point(6, 24);
            this.radMaHocKy.Name = "radMaHocKy";
            this.radMaHocKy.Size = new System.Drawing.Size(77, 17);
            this.radMaHocKy.TabIndex = 0;
            this.radMaHocKy.TabStop = true;
            this.radMaHocKy.Text = "Mã học kỳ:";
            this.radMaHocKy.UseVisualStyleBackColor = true;
            this.radMaHocKy.CheckedChanged += new System.EventHandler(this.radMaHocKy_CheckedChanged);
            // 
            // frmHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 269);
            this.Controls.Add(this.grpTimKiemThongTin);
            this.Controls.Add(this.dgvHocKy);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHocKy";
            this.Text = "Học kỳ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).EndInit();
            this.grpTimKiemThongTin.ResumeLayout(false);
            this.grpTimKiemThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHocKy;
        private System.Windows.Forms.GroupBox grpTimKiemThongTin;
        private System.Windows.Forms.RadioButton radGhiChu;
        private System.Windows.Forms.RadioButton radMaHocKy;
        private System.Windows.Forms.RadioButton radTenHocKy;
        private System.Windows.Forms.ComboBox cboTenHocKy;
        private System.Windows.Forms.ComboBox cboMaHocKy;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHOCKY_MaHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHOCKY_TenHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHOCKY_GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHOCKY_TrangThai;
    }
}