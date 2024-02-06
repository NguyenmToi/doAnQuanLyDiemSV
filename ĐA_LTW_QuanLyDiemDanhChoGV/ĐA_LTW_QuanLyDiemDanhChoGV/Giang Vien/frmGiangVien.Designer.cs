namespace ĐA_LTW_QuanLyDiemDanhChoGV
{
    partial class frmGiangVien
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
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtMaGiangVien = new System.Windows.Forms.TextBox();
            this.radMaGiangVien = new System.Windows.Forms.RadioButton();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.txtHoTenGiangVien = new System.Windows.Forms.TextBox();
            this.radHoTenGiangVien = new System.Windows.Forms.RadioButton();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.radGhiChu = new System.Windows.Forms.RadioButton();
            this.radKhoa = new System.Windows.Forms.RadioButton();
            this.colGV_MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGV_HoTenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGV_GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGV_TenGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGV_Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGV_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGiangVien
            // 
            this.dgvGiangVien.AllowUserToResizeColumns = false;
            this.dgvGiangVien.AllowUserToResizeRows = false;
            this.dgvGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGiangVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGV_MaGV,
            this.colGV_HoTenGV,
            this.colGV_GT,
            this.colGV_TenGT,
            this.colGV_Khoa,
            this.GV_MaKhoa,
            this.TRANGTHAI,
            this.colGV_GhiChu});
            this.dgvGiangVien.Location = new System.Drawing.Point(12, 119);
            this.dgvGiangVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.RowHeadersWidth = 51;
            this.dgvGiangVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGiangVien.RowTemplate.Height = 24;
            this.dgvGiangVien.Size = new System.Drawing.Size(893, 186);
            this.dgvGiangVien.TabIndex = 0;
            this.dgvGiangVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiangVien_CellContentClick);
            this.dgvGiangVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiangVien_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtMaGiangVien);
            this.groupBox2.Controls.Add(this.radMaGiangVien);
            this.groupBox2.Controls.Add(this.cboKhoa);
            this.groupBox2.Controls.Add(this.txtHoTenGiangVien);
            this.groupBox2.Controls.Add(this.radHoTenGiangVien);
            this.groupBox2.Controls.Add(this.radTatCa);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.radGhiChu);
            this.groupBox2.Controls.Add(this.radKhoa);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(889, 102);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Giảng viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Location = new System.Drawing.Point(363, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 36);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giới tính:";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(145, 15);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 0;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(79, 14);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(46, 17);
            this.radNam.TabIndex = 2;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // txtMaGiangVien
            // 
            this.txtMaGiangVien.Location = new System.Drawing.Point(127, 22);
            this.txtMaGiangVien.Name = "txtMaGiangVien";
            this.txtMaGiangVien.Size = new System.Drawing.Size(171, 21);
            this.txtMaGiangVien.TabIndex = 2;
            this.txtMaGiangVien.TextChanged += new System.EventHandler(this.txtMaGiangVien_TextChanged);
            // 
            // radMaGiangVien
            // 
            this.radMaGiangVien.AutoSize = true;
            this.radMaGiangVien.Location = new System.Drawing.Point(7, 22);
            this.radMaGiangVien.Name = "radMaGiangVien";
            this.radMaGiangVien.Size = new System.Drawing.Size(93, 17);
            this.radMaGiangVien.TabIndex = 1;
            this.radMaGiangVien.TabStop = true;
            this.radMaGiangVien.Text = "Mã giảng vên:";
            this.radMaGiangVien.UseVisualStyleBackColor = true;
            this.radMaGiangVien.CheckedChanged += new System.EventHandler(this.radMaGiangVien_CheckedChanged);
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(422, 23);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(160, 21);
            this.cboKhoa.TabIndex = 5;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // txtHoTenGiangVien
            // 
            this.txtHoTenGiangVien.Location = new System.Drawing.Point(127, 65);
            this.txtHoTenGiangVien.Name = "txtHoTenGiangVien";
            this.txtHoTenGiangVien.Size = new System.Drawing.Size(171, 21);
            this.txtHoTenGiangVien.TabIndex = 9;
            this.txtHoTenGiangVien.TextChanged += new System.EventHandler(this.txtHoTenGiangVien_TextChanged);
            // 
            // radHoTenGiangVien
            // 
            this.radHoTenGiangVien.AutoSize = true;
            this.radHoTenGiangVien.Location = new System.Drawing.Point(7, 65);
            this.radHoTenGiangVien.Name = "radHoTenGiangVien";
            this.radHoTenGiangVien.Size = new System.Drawing.Size(113, 17);
            this.radHoTenGiangVien.TabIndex = 8;
            this.radHoTenGiangVien.TabStop = true;
            this.radHoTenGiangVien.Text = "Họ tên giảng viên:";
            this.radHoTenGiangVien.UseVisualStyleBackColor = true;
            this.radHoTenGiangVien.CheckedChanged += new System.EventHandler(this.radHoTenGiangVien_CheckedChanged);
            this.radHoTenGiangVien.TextChanged += new System.EventHandler(this.radHoTenGiangVien_CheckedChanged);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Location = new System.Drawing.Point(633, 71);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(55, 17);
            this.radTatCa.TabIndex = 0;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.radTatCa_CheckedChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(705, 24);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(160, 21);
            this.txtGhiChu.TabIndex = 7;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // radGhiChu
            // 
            this.radGhiChu.AutoSize = true;
            this.radGhiChu.Location = new System.Drawing.Point(633, 24);
            this.radGhiChu.Name = "radGhiChu";
            this.radGhiChu.Size = new System.Drawing.Size(64, 17);
            this.radGhiChu.TabIndex = 6;
            this.radGhiChu.TabStop = true;
            this.radGhiChu.Text = "Ghi chú:";
            this.radGhiChu.UseVisualStyleBackColor = true;
            this.radGhiChu.CheckedChanged += new System.EventHandler(this.radGhiChu_CheckedChanged);
            // 
            // radKhoa
            // 
            this.radKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radKhoa.AutoSize = true;
            this.radKhoa.Location = new System.Drawing.Point(363, 23);
            this.radKhoa.Name = "radKhoa";
            this.radKhoa.Size = new System.Drawing.Size(53, 17);
            this.radKhoa.TabIndex = 4;
            this.radKhoa.TabStop = true;
            this.radKhoa.Text = "Khoa:";
            this.radKhoa.UseVisualStyleBackColor = true;
            this.radKhoa.CheckedChanged += new System.EventHandler(this.radKhoa_CheckedChanged);
            // 
            // colGV_MaGV
            // 
            this.colGV_MaGV.DataPropertyName = "MAGV";
            this.colGV_MaGV.HeaderText = "Mã giảng viên";
            this.colGV_MaGV.MinimumWidth = 6;
            this.colGV_MaGV.Name = "colGV_MaGV";
            // 
            // colGV_HoTenGV
            // 
            this.colGV_HoTenGV.DataPropertyName = "HOTENGV";
            this.colGV_HoTenGV.HeaderText = "Họ tên giảng viên";
            this.colGV_HoTenGV.MinimumWidth = 6;
            this.colGV_HoTenGV.Name = "colGV_HoTenGV";
            // 
            // colGV_GT
            // 
            this.colGV_GT.DataPropertyName = "GIOITINH";
            this.colGV_GT.HeaderText = "Giới tính TF";
            this.colGV_GT.Name = "colGV_GT";
            this.colGV_GT.Visible = false;
            // 
            // colGV_TenGT
            // 
            this.colGV_TenGT.DataPropertyName = "TENGIOITINH";
            this.colGV_TenGT.HeaderText = "Giới tính";
            this.colGV_TenGT.Name = "colGV_TenGT";
            // 
            // colGV_Khoa
            // 
            this.colGV_Khoa.DataPropertyName = "TENKHOA";
            this.colGV_Khoa.HeaderText = "Khoa";
            this.colGV_Khoa.MinimumWidth = 6;
            this.colGV_Khoa.Name = "colGV_Khoa";
            // 
            // GV_MaKhoa
            // 
            this.GV_MaKhoa.DataPropertyName = "KHOA";
            this.GV_MaKhoa.HeaderText = "Mã Khoa";
            this.GV_MaKhoa.Name = "GV_MaKhoa";
            this.GV_MaKhoa.Visible = false;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "TRANGTHAI";
            this.TRANGTHAI.MinimumWidth = 6;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = false;
            // 
            // colGV_GhiChu
            // 
            this.colGV_GhiChu.DataPropertyName = "GHICHU";
            this.colGV_GhiChu.HeaderText = "Ghi chú";
            this.colGV_GhiChu.MinimumWidth = 6;
            this.colGV_GhiChu.Name = "colGV_GhiChu";
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 316);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvGiangVien);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGiangVien";
            this.Text = "  Giảng viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtMaGiangVien;
        private System.Windows.Forms.RadioButton radMaGiangVien;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.TextBox txtHoTenGiangVien;
        private System.Windows.Forms.RadioButton radHoTenGiangVien;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.RadioButton radGhiChu;
        private System.Windows.Forms.RadioButton radKhoa;
        private System.Windows.Forms.DataGridView dgvGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGV_MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGV_HoTenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGV_GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGV_TenGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGV_Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGV_GhiChu;
    }
}