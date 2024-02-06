namespace ĐA_LTW_QuanLyDiemDanhChoGV
{
    partial class frmMonHoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.radGhiChu = new System.Windows.Forms.RadioButton();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cboTenMonHoc = new System.Windows.Forms.ComboBox();
            this.cboMaMonHoc = new System.Windows.Forms.ComboBox();
            this.radSoTinChi = new System.Windows.Forms.RadioButton();
            this.radTenMonHoc = new System.Windows.Forms.RadioButton();
            this.radMaMonHoc = new System.Windows.Forms.RadioButton();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMONHOC_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMONHOC_SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMONHOC_TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMONHOC_MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radTatCa);
            this.groupBox1.Controls.Add(this.radGhiChu);
            this.groupBox1.Controls.Add(this.txtSoTinChi);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.cboTenMonHoc);
            this.groupBox1.Controls.Add(this.cboMaMonHoc);
            this.groupBox1.Controls.Add(this.radSoTinChi);
            this.groupBox1.Controls.Add(this.radTenMonHoc);
            this.groupBox1.Controls.Add(this.radMaMonHoc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin môn học";
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Location = new System.Drawing.Point(695, 24);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(55, 17);
            this.radTatCa.TabIndex = 5;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.radTatCa_CheckedChanged);
            // 
            // radGhiChu
            // 
            this.radGhiChu.AutoSize = true;
            this.radGhiChu.Location = new System.Drawing.Point(401, 65);
            this.radGhiChu.Name = "radGhiChu";
            this.radGhiChu.Size = new System.Drawing.Size(64, 17);
            this.radGhiChu.TabIndex = 8;
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
            this.txtGhiChu.TabIndex = 0;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // cboTenMonHoc
            // 
            this.cboTenMonHoc.FormattingEnabled = true;
            this.cboTenMonHoc.Location = new System.Drawing.Point(122, 65);
            this.cboTenMonHoc.Name = "cboTenMonHoc";
            this.cboTenMonHoc.Size = new System.Drawing.Size(215, 21);
            this.cboTenMonHoc.TabIndex = 7;
            this.cboTenMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboTenMonHoc_SelectedIndexChanged);
            this.cboTenMonHoc.TextUpdate += new System.EventHandler(this.cboTenMonHoc_SelectedIndexChanged);
            this.cboTenMonHoc.TextChanged += new System.EventHandler(this.cboTenMonHoc_SelectedIndexChanged);
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
            this.radTenMonHoc.TabIndex = 6;
            this.radTenMonHoc.TabStop = true;
            this.radTenMonHoc.Text = "Tên môn học:";
            this.radTenMonHoc.UseVisualStyleBackColor = true;
            this.radTenMonHoc.CheckedChanged += new System.EventHandler(this.radTenMonHoc_CheckedChanged);
            // 
            // radMaMonHoc
            // 
            this.radMaMonHoc.AutoSize = true;
            this.radMaMonHoc.Location = new System.Drawing.Point(25, 21);
            this.radMaMonHoc.Name = "radMaMonHoc";
            this.radMaMonHoc.Size = new System.Drawing.Size(86, 17);
            this.radMaMonHoc.TabIndex = 0;
            this.radMaMonHoc.TabStop = true;
            this.radMaMonHoc.Text = "Mã môn học:";
            this.radMaMonHoc.UseVisualStyleBackColor = true;
            this.radMaMonHoc.CheckedChanged += new System.EventHandler(this.cboMaMonHoc_SelectedIndexChanged);
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "TRANGTHAI";
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = false;
            // 
            // colMONHOC_GhiChu
            // 
            this.colMONHOC_GhiChu.DataPropertyName = "GHICHU";
            this.colMONHOC_GhiChu.HeaderText = "Ghi chú";
            this.colMONHOC_GhiChu.MinimumWidth = 6;
            this.colMONHOC_GhiChu.Name = "colMONHOC_GhiChu";
            // 
            // colMONHOC_SoTinChi
            // 
            this.colMONHOC_SoTinChi.DataPropertyName = "SOTINCHI";
            this.colMONHOC_SoTinChi.HeaderText = "Số tín chỉ";
            this.colMONHOC_SoTinChi.MinimumWidth = 6;
            this.colMONHOC_SoTinChi.Name = "colMONHOC_SoTinChi";
            // 
            // colMONHOC_TenMonHoc
            // 
            this.colMONHOC_TenMonHoc.DataPropertyName = "TENMH";
            this.colMONHOC_TenMonHoc.HeaderText = "Tên môn học";
            this.colMONHOC_TenMonHoc.MinimumWidth = 6;
            this.colMONHOC_TenMonHoc.Name = "colMONHOC_TenMonHoc";
            // 
            // colMONHOC_MaMonHoc
            // 
            this.colMONHOC_MaMonHoc.DataPropertyName = "MAMH";
            this.colMONHOC_MaMonHoc.HeaderText = "Mã môn học";
            this.colMONHOC_MaMonHoc.MinimumWidth = 6;
            this.colMONHOC_MaMonHoc.Name = "colMONHOC_MaMonHoc";
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.AllowUserToResizeColumns = false;
            this.dgvMonHoc.AllowUserToResizeRows = false;
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
            this.dgvMonHoc.Location = new System.Drawing.Point(12, 117);
            this.dgvMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.RowHeadersWidth = 51;
            this.dgvMonHoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMonHoc.RowTemplate.Height = 24;
            this.dgvMonHoc.Size = new System.Drawing.Size(783, 165);
            this.dgvMonHoc.TabIndex = 1;
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellContentClick);
            this.dgvMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellContentClick);
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 293);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMonHoc);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMonHoc";
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMonHoc_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radGhiChu;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ComboBox cboTenMonHoc;
        private System.Windows.Forms.ComboBox cboMaMonHoc;
        private System.Windows.Forms.RadioButton radSoTinChi;
        private System.Windows.Forms.RadioButton radTenMonHoc;
        private System.Windows.Forms.RadioButton radMaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMONHOC_GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMONHOC_SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMONHOC_TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMONHOC_MaMonHoc;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.RadioButton radTatCa;
    }
}