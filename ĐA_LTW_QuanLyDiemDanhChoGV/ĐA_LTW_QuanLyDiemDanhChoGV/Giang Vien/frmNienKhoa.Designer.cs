namespace ĐA_LTW_QuanLyDiemDanhChoGV
{
    partial class frmNienKhoa
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
            this.colNIENKHOA_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNIENKHOA_MaNienKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNienKhoa = new System.Windows.Forms.DataGridView();
            this.colNIENKHOA_TenNienKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.radGhiChu = new System.Windows.Forms.RadioButton();
            this.cboTenNienKhoa = new System.Windows.Forms.ComboBox();
            this.cboMaNienKhoa = new System.Windows.Forms.ComboBox();
            this.radTenNienKhoa = new System.Windows.Forms.RadioButton();
            this.radMaNienKhoa = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNienKhoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colNIENKHOA_GhiChu
            // 
            this.colNIENKHOA_GhiChu.DataPropertyName = "GHICHU";
            this.colNIENKHOA_GhiChu.FillWeight = 140F;
            this.colNIENKHOA_GhiChu.HeaderText = "Ghi chú";
            this.colNIENKHOA_GhiChu.MinimumWidth = 6;
            this.colNIENKHOA_GhiChu.Name = "colNIENKHOA_GhiChu";
            // 
            // colNIENKHOA_MaNienKhoa
            // 
            this.colNIENKHOA_MaNienKhoa.DataPropertyName = "MANIENKHOA";
            this.colNIENKHOA_MaNienKhoa.FillWeight = 80F;
            this.colNIENKHOA_MaNienKhoa.HeaderText = "Mã niên khóa";
            this.colNIENKHOA_MaNienKhoa.Name = "colNIENKHOA_MaNienKhoa";
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "TRANGTHAI";
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = false;
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
            this.dgvNienKhoa.Location = new System.Drawing.Point(12, 106);
            this.dgvNienKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNienKhoa.Name = "dgvNienKhoa";
            this.dgvNienKhoa.RowHeadersWidth = 51;
            this.dgvNienKhoa.RowTemplate.Height = 24;
            this.dgvNienKhoa.Size = new System.Drawing.Size(805, 159);
            this.dgvNienKhoa.TabIndex = 1;
            this.dgvNienKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNienKhoa_CellContentClick);
            this.dgvNienKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNienKhoa_CellContentClick);
            // 
            // colNIENKHOA_TenNienKhoa
            // 
            this.colNIENKHOA_TenNienKhoa.DataPropertyName = "TENNIENKHOA";
            this.colNIENKHOA_TenNienKhoa.FillWeight = 80F;
            this.colNIENKHOA_TenNienKhoa.HeaderText = "Tên niên khóa";
            this.colNIENKHOA_TenNienKhoa.MinimumWidth = 6;
            this.colNIENKHOA_TenNienKhoa.Name = "colNIENKHOA_TenNienKhoa";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(399, 22);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(334, 20);
            this.txtGhiChu.TabIndex = 3;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Location = new System.Drawing.Point(329, 64);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(55, 17);
            this.radTatCa.TabIndex = 6;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.TextChanged += new System.EventHandler(this.radTatCa_CheckedChanged);
            // 
            // radGhiChu
            // 
            this.radGhiChu.AutoSize = true;
            this.radGhiChu.Location = new System.Drawing.Point(329, 22);
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
            this.cboTenNienKhoa.Location = new System.Drawing.Point(108, 60);
            this.cboTenNienKhoa.Name = "cboTenNienKhoa";
            this.cboTenNienKhoa.Size = new System.Drawing.Size(148, 21);
            this.cboTenNienKhoa.TabIndex = 5;
            this.cboTenNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cboTenNienKhoa_SelectedIndexChanged);
            // 
            // cboMaNienKhoa
            // 
            this.cboMaNienKhoa.FormattingEnabled = true;
            this.cboMaNienKhoa.Location = new System.Drawing.Point(108, 18);
            this.cboMaNienKhoa.Name = "cboMaNienKhoa";
            this.cboMaNienKhoa.Size = new System.Drawing.Size(148, 21);
            this.cboMaNienKhoa.TabIndex = 1;
            this.cboMaNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cboMaNienKhoa_SelectedIndexChanged);
            // 
            // radTenNienKhoa
            // 
            this.radTenNienKhoa.AutoSize = true;
            this.radTenNienKhoa.Location = new System.Drawing.Point(6, 61);
            this.radTenNienKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTenNienKhoa.Name = "radTenNienKhoa";
            this.radTenNienKhoa.Size = new System.Drawing.Size(96, 17);
            this.radTenNienKhoa.TabIndex = 4;
            this.radTenNienKhoa.TabStop = true;
            this.radTenNienKhoa.Text = "Tên niên khóa:";
            this.radTenNienKhoa.UseVisualStyleBackColor = true;
            this.radTenNienKhoa.CheckedChanged += new System.EventHandler(this.cboTenNienKhoa_SelectedIndexChanged);
            // 
            // radMaNienKhoa
            // 
            this.radMaNienKhoa.AutoSize = true;
            this.radMaNienKhoa.Location = new System.Drawing.Point(6, 21);
            this.radMaNienKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radMaNienKhoa.Name = "radMaNienKhoa";
            this.radMaNienKhoa.Size = new System.Drawing.Size(92, 17);
            this.radMaNienKhoa.TabIndex = 0;
            this.radMaNienKhoa.TabStop = true;
            this.radMaNienKhoa.Text = "Mã niên khóa:";
            this.radMaNienKhoa.UseVisualStyleBackColor = true;
            this.radMaNienKhoa.CheckedChanged += new System.EventHandler(this.radMaNienKhoa_CheckedChanged);
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
            this.groupBox1.Size = new System.Drawing.Size(805, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin niên khóa";
            // 
            // frmNienKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 274);
            this.Controls.Add(this.dgvNienKhoa);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNienKhoa";
            this.Text = "Niên khóa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNienKhoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colNIENKHOA_GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNIENKHOA_MaNienKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.DataGridView dgvNienKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNIENKHOA_TenNienKhoa;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.RadioButton radGhiChu;
        private System.Windows.Forms.ComboBox cboTenNienKhoa;
        private System.Windows.Forms.ComboBox cboMaNienKhoa;
        private System.Windows.Forms.RadioButton radTenNienKhoa;
        private System.Windows.Forms.RadioButton radMaNienKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}