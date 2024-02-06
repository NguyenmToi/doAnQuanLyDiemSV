namespace ĐA_LTW_QuanLyDiemDanhChoGV
{
    partial class frmLop
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
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.radGhiChu = new System.Windows.Forms.RadioButton();
            this.cboNienKhoa = new System.Windows.Forms.ComboBox();
            this.cboTenNganh = new System.Windows.Forms.ComboBox();
            this.cboTenLop = new System.Windows.Forms.ComboBox();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.radNienKhoa = new System.Windows.Forms.RadioButton();
            this.radTenNganh = new System.Windows.Forms.RadioButton();
            this.radMaLop = new System.Windows.Forms.RadioButton();
            this.radTenLop = new System.Windows.Forms.RadioButton();
            this.colLOP_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOP_MaNienKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOP_TenNienKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOP_MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOP_TenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOP_TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOP_MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.radTatCa);
            this.groupBox1.Controls.Add(this.radGhiChu);
            this.groupBox1.Controls.Add(this.cboNienKhoa);
            this.groupBox1.Controls.Add(this.cboTenNganh);
            this.groupBox1.Controls.Add(this.cboTenLop);
            this.groupBox1.Controls.Add(this.cboMaLop);
            this.groupBox1.Controls.Add(this.radNienKhoa);
            this.groupBox1.Controls.Add(this.radTenNganh);
            this.groupBox1.Controls.Add(this.radMaLop);
            this.groupBox1.Controls.Add(this.radTenLop);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(831, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(632, 29);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(133, 21);
            this.txtGhiChu.TabIndex = 5;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Location = new System.Drawing.Point(561, 74);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(55, 17);
            this.radTatCa.TabIndex = 0;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.radTatCa_CheckedChanged);
            // 
            // radGhiChu
            // 
            this.radGhiChu.AutoSize = true;
            this.radGhiChu.Location = new System.Drawing.Point(561, 30);
            this.radGhiChu.Name = "radGhiChu";
            this.radGhiChu.Size = new System.Drawing.Size(64, 17);
            this.radGhiChu.TabIndex = 4;
            this.radGhiChu.TabStop = true;
            this.radGhiChu.Text = "Ghi chú:";
            this.radGhiChu.UseVisualStyleBackColor = true;
            this.radGhiChu.CheckedChanged += new System.EventHandler(this.radGhiChu_CheckedChanged);
            // 
            // cboNienKhoa
            // 
            this.cboNienKhoa.FormattingEnabled = true;
            this.cboNienKhoa.Location = new System.Drawing.Point(344, 73);
            this.cboNienKhoa.Name = "cboNienKhoa";
            this.cboNienKhoa.Size = new System.Drawing.Size(174, 21);
            this.cboNienKhoa.TabIndex = 9;
            this.cboNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cboNienKhoa_SelectedIndexChanged);
            // 
            // cboTenNganh
            // 
            this.cboTenNganh.FormattingEnabled = true;
            this.cboTenNganh.Location = new System.Drawing.Point(343, 28);
            this.cboTenNganh.Name = "cboTenNganh";
            this.cboTenNganh.Size = new System.Drawing.Size(175, 21);
            this.cboTenNganh.TabIndex = 3;
            this.cboTenNganh.SelectedIndexChanged += new System.EventHandler(this.cboTenNganh_SelectedIndexChanged);
            // 
            // cboTenLop
            // 
            this.cboTenLop.FormattingEnabled = true;
            this.cboTenLop.Location = new System.Drawing.Point(72, 69);
            this.cboTenLop.Name = "cboTenLop";
            this.cboTenLop.Size = new System.Drawing.Size(135, 21);
            this.cboTenLop.TabIndex = 7;
            this.cboTenLop.SelectedIndexChanged += new System.EventHandler(this.cboTenLop_SelectedIndexChanged);
            // 
            // cboMaLop
            // 
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(72, 28);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(135, 21);
            this.cboMaLop.TabIndex = 1;
            this.cboMaLop.SelectedIndexChanged += new System.EventHandler(this.cboMaLop_SelectedIndexChanged);
            this.cboMaLop.TextChanged += new System.EventHandler(this.txtMaLop_TextChanged);
            // 
            // radNienKhoa
            // 
            this.radNienKhoa.AutoSize = true;
            this.radNienKhoa.Location = new System.Drawing.Point(257, 73);
            this.radNienKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNienKhoa.Name = "radNienKhoa";
            this.radNienKhoa.Size = new System.Drawing.Size(76, 17);
            this.radNienKhoa.TabIndex = 8;
            this.radNienKhoa.TabStop = true;
            this.radNienKhoa.Text = "Niên khóa:";
            this.radNienKhoa.UseVisualStyleBackColor = true;
            this.radNienKhoa.CheckedChanged += new System.EventHandler(this.radNienKhoa_CheckedChanged);
            // 
            // radTenNganh
            // 
            this.radTenNganh.AutoSize = true;
            this.radTenNganh.Location = new System.Drawing.Point(257, 31);
            this.radTenNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTenNganh.Name = "radTenNganh";
            this.radTenNganh.Size = new System.Drawing.Size(80, 17);
            this.radTenNganh.TabIndex = 2;
            this.radTenNganh.TabStop = true;
            this.radTenNganh.Text = "Tên ngành:";
            this.radTenNganh.UseVisualStyleBackColor = true;
            this.radTenNganh.CheckedChanged += new System.EventHandler(this.radTenNganh_CheckedChanged);
            // 
            // radMaLop
            // 
            this.radMaLop.AutoSize = true;
            this.radMaLop.Location = new System.Drawing.Point(6, 28);
            this.radMaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radMaLop.Name = "radMaLop";
            this.radMaLop.Size = new System.Drawing.Size(60, 17);
            this.radMaLop.TabIndex = 0;
            this.radMaLop.TabStop = true;
            this.radMaLop.Text = "Mã lớp:";
            this.radMaLop.UseVisualStyleBackColor = true;
            this.radMaLop.CheckedChanged += new System.EventHandler(this.radMaLop_CheckedChanged);
            // 
            // radTenLop
            // 
            this.radTenLop.AutoSize = true;
            this.radTenLop.Location = new System.Drawing.Point(6, 72);
            this.radTenLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTenLop.Name = "radTenLop";
            this.radTenLop.Size = new System.Drawing.Size(64, 17);
            this.radTenLop.TabIndex = 6;
            this.radTenLop.TabStop = true;
            this.radTenLop.Text = "Tên lớp:";
            this.radTenLop.UseVisualStyleBackColor = true;
            this.radTenLop.CheckedChanged += new System.EventHandler(this.radTenLop_CheckedChanged);
            // 
            // colLOP_GhiChu
            // 
            this.colLOP_GhiChu.DataPropertyName = "GHICHU";
            this.colLOP_GhiChu.HeaderText = "Ghi chú";
            this.colLOP_GhiChu.MinimumWidth = 6;
            this.colLOP_GhiChu.Name = "colLOP_GhiChu";
            // 
            // colLOP_MaNienKhoa
            // 
            this.colLOP_MaNienKhoa.DataPropertyName = "MANIENKHOA";
            this.colLOP_MaNienKhoa.HeaderText = "Mã niên khóa";
            this.colLOP_MaNienKhoa.Name = "colLOP_MaNienKhoa";
            this.colLOP_MaNienKhoa.Visible = false;
            // 
            // colLOP_TenNienKhoa
            // 
            this.colLOP_TenNienKhoa.DataPropertyName = "TENNIENKHOA";
            this.colLOP_TenNienKhoa.HeaderText = "Tên niên khóa";
            this.colLOP_TenNienKhoa.MinimumWidth = 6;
            this.colLOP_TenNienKhoa.Name = "colLOP_TenNienKhoa";
            // 
            // colLOP_MaNganh
            // 
            this.colLOP_MaNganh.DataPropertyName = "MANGANH";
            this.colLOP_MaNganh.HeaderText = "Mã ngành";
            this.colLOP_MaNganh.Name = "colLOP_MaNganh";
            this.colLOP_MaNganh.Visible = false;
            // 
            // colLOP_TenNganh
            // 
            this.colLOP_TenNganh.DataPropertyName = "TENNGANH";
            this.colLOP_TenNganh.HeaderText = "Tên ngành";
            this.colLOP_TenNganh.MinimumWidth = 6;
            this.colLOP_TenNganh.Name = "colLOP_TenNganh";
            // 
            // colLOP_TenLop
            // 
            this.colLOP_TenLop.DataPropertyName = "TENLOP";
            this.colLOP_TenLop.HeaderText = "Tên lớp";
            this.colLOP_TenLop.MinimumWidth = 6;
            this.colLOP_TenLop.Name = "colLOP_TenLop";
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "TRANGTHAI";
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = false;
            // 
            // colLOP_MaLop
            // 
            this.colLOP_MaLop.DataPropertyName = "MALOP";
            this.colLOP_MaLop.HeaderText = "Mã lớp";
            this.colLOP_MaLop.MinimumWidth = 6;
            this.colLOP_MaLop.Name = "colLOP_MaLop";
            // 
            // dgvLop
            // 
            this.dgvLop.AllowUserToResizeColumns = false;
            this.dgvLop.AllowUserToResizeRows = false;
            this.dgvLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLOP_MaLop,
            this.TRANGTHAI,
            this.colLOP_TenLop,
            this.colLOP_TenNganh,
            this.colLOP_MaNganh,
            this.colLOP_TenNienKhoa,
            this.colLOP_MaNienKhoa,
            this.colLOP_GhiChu});
            this.dgvLop.Location = new System.Drawing.Point(12, 126);
            this.dgvLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 51;
            this.dgvLop.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLop.RowTemplate.Height = 24;
            this.dgvLop.Size = new System.Drawing.Size(831, 180);
            this.dgvLop.TabIndex = 1;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellContentClick);
            this.dgvLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellContentClick);
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLop";
            this.Text = "Lớp";
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.RadioButton radGhiChu;
        private System.Windows.Forms.ComboBox cboNienKhoa;
        private System.Windows.Forms.ComboBox cboTenNganh;
        private System.Windows.Forms.ComboBox cboTenLop;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.RadioButton radNienKhoa;
        private System.Windows.Forms.RadioButton radTenNganh;
        private System.Windows.Forms.RadioButton radMaLop;
        private System.Windows.Forms.RadioButton radTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLOP_GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLOP_MaNienKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLOP_TenNienKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLOP_MaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLOP_TenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLOP_TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLOP_MaLop;
        private System.Windows.Forms.DataGridView dgvLop;
    }
}