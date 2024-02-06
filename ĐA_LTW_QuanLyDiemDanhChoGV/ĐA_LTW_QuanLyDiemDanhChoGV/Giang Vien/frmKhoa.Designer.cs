namespace ĐA_LTW_QuanLyDiemDanhChoGV
{
    partial class frmKhoa
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
            this.cboTenKhoa = new System.Windows.Forms.ComboBox();
            this.cboMaKhoa = new System.Windows.Forms.ComboBox();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.colKHOA_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.radGhiChu = new System.Windows.Forms.RadioButton();
            this.radTenKhoa = new System.Windows.Forms.RadioButton();
            this.radMaKhoa = new System.Windows.Forms.RadioButton();
            this.colKHOA_TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKHOA_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKHOA_MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTenKhoa
            // 
            this.cboTenKhoa.FormattingEnabled = true;
            this.cboTenKhoa.Location = new System.Drawing.Point(87, 59);
            this.cboTenKhoa.Name = "cboTenKhoa";
            this.cboTenKhoa.Size = new System.Drawing.Size(160, 21);
            this.cboTenKhoa.TabIndex = 5;
            this.cboTenKhoa.SelectedIndexChanged += new System.EventHandler(this.cboTenKhoa_TextChanged);
            this.cboTenKhoa.TextUpdate += new System.EventHandler(this.cboTenKhoa_TextChanged);
            // 
            // cboMaKhoa
            // 
            this.cboMaKhoa.FormattingEnabled = true;
            this.cboMaKhoa.Location = new System.Drawing.Point(87, 26);
            this.cboMaKhoa.Name = "cboMaKhoa";
            this.cboMaKhoa.Size = new System.Drawing.Size(160, 21);
            this.cboMaKhoa.TabIndex = 1;
            this.cboMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cboMaKhoa_SelectedIndexChanged);
            this.cboMaKhoa.TextUpdate += new System.EventHandler(this.cboMaKhoa_SelectedIndexChanged);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Location = new System.Drawing.Point(338, 63);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(55, 17);
            this.radTatCa.TabIndex = 6;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.radTatCa_CheckedChanged);
            // 
            // colKHOA_GhiChu
            // 
            this.colKHOA_GhiChu.DataPropertyName = "GHICHU";
            this.colKHOA_GhiChu.HeaderText = "Ghi chú";
            this.colKHOA_GhiChu.MinimumWidth = 6;
            this.colKHOA_GhiChu.Name = "colKHOA_GhiChu";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(408, 26);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(160, 21);
            this.txtGhiChu.TabIndex = 3;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // radGhiChu
            // 
            this.radGhiChu.AutoSize = true;
            this.radGhiChu.Location = new System.Drawing.Point(338, 27);
            this.radGhiChu.Name = "radGhiChu";
            this.radGhiChu.Size = new System.Drawing.Size(64, 17);
            this.radGhiChu.TabIndex = 2;
            this.radGhiChu.TabStop = true;
            this.radGhiChu.Text = "Ghi chú:";
            this.radGhiChu.UseVisualStyleBackColor = true;
            this.radGhiChu.CheckedChanged += new System.EventHandler(this.radGhiChu_CheckedChanged);
            // 
            // radTenKhoa
            // 
            this.radTenKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTenKhoa.AutoSize = true;
            this.radTenKhoa.Location = new System.Drawing.Point(4, 60);
            this.radTenKhoa.Name = "radTenKhoa";
            this.radTenKhoa.Size = new System.Drawing.Size(76, 17);
            this.radTenKhoa.TabIndex = 4;
            this.radTenKhoa.TabStop = true;
            this.radTenKhoa.Text = "Tên  khoa:";
            this.radTenKhoa.UseVisualStyleBackColor = true;
            this.radTenKhoa.CheckedChanged += new System.EventHandler(this.radTenKhoa_CheckedChanged);
            // 
            // radMaKhoa
            // 
            this.radMaKhoa.AutoSize = true;
            this.radMaKhoa.Location = new System.Drawing.Point(6, 26);
            this.radMaKhoa.Name = "radMaKhoa";
            this.radMaKhoa.Size = new System.Drawing.Size(69, 17);
            this.radMaKhoa.TabIndex = 0;
            this.radMaKhoa.TabStop = true;
            this.radMaKhoa.Text = "Mã khoa:";
            this.radMaKhoa.UseVisualStyleBackColor = true;
            this.radMaKhoa.CheckedChanged += new System.EventHandler(this.radMaKhoa_CheckedChanged);
            // 
            // colKHOA_TenKhoa
            // 
            this.colKHOA_TenKhoa.DataPropertyName = "TENKHOA";
            this.colKHOA_TenKhoa.HeaderText = "Tên khoa";
            this.colKHOA_TenKhoa.MinimumWidth = 6;
            this.colKHOA_TenKhoa.Name = "colKHOA_TenKhoa";
            // 
            // colKHOA_TrangThai
            // 
            this.colKHOA_TrangThai.DataPropertyName = "TRANGTHAI";
            this.colKHOA_TrangThai.HeaderText = "Trạng thái";
            this.colKHOA_TrangThai.MinimumWidth = 6;
            this.colKHOA_TrangThai.Name = "colKHOA_TrangThai";
            this.colKHOA_TrangThai.Visible = false;
            // 
            // colKHOA_MaKhoa
            // 
            this.colKHOA_MaKhoa.DataPropertyName = "MAKHOA";
            this.colKHOA_MaKhoa.HeaderText = "Mã khoa";
            this.colKHOA_MaKhoa.MinimumWidth = 6;
            this.colKHOA_MaKhoa.Name = "colKHOA_MaKhoa";
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.AllowUserToResizeColumns = false;
            this.dgvKhoa.AllowUserToResizeRows = false;
            this.dgvKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKHOA_MaKhoa,
            this.colKHOA_TrangThai,
            this.colKHOA_TenKhoa,
            this.colKHOA_GhiChu});
            this.dgvKhoa.Location = new System.Drawing.Point(12, 109);
            this.dgvKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.RowHeadersWidth = 51;
            this.dgvKhoa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvKhoa.RowTemplate.Height = 24;
            this.dgvKhoa.Size = new System.Drawing.Size(716, 163);
            this.dgvKhoa.TabIndex = 1;
            this.dgvKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellContentClick);
            this.dgvKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cboTenKhoa);
            this.groupBox1.Controls.Add(this.cboMaKhoa);
            this.groupBox1.Controls.Add(this.radTatCa);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.radGhiChu);
            this.groupBox1.Controls.Add(this.radTenKhoa);
            this.groupBox1.Controls.Add(this.radMaKhoa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khoa";
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 283);
            this.Controls.Add(this.dgvKhoa);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKhoa";
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.frmKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboTenKhoa;
        private System.Windows.Forms.ComboBox cboMaKhoa;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKHOA_GhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.RadioButton radGhiChu;
        private System.Windows.Forms.RadioButton radTenKhoa;
        private System.Windows.Forms.RadioButton radMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKHOA_TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKHOA_TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKHOA_MaKhoa;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}