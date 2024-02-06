namespace ĐA_LTW_QuanLyDiemDanhChoGV
{
    partial class frmDiem
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
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMonHoc = new System.Windows.Forms.Button();
            this.btnTKHocKy = new System.Windows.Forms.Button();
            this.btnTKMSSV = new System.Windows.Forms.Button();
            this.btnTKLop = new System.Windows.Forms.Button();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.radMonHoc = new System.Windows.Forms.RadioButton();
            this.radHocKy = new System.Windows.Forms.RadioButton();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.radMSSV = new System.Windows.Forms.RadioButton();
            this.radLop = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiem
            // 
            this.dgvDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column12,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvDiem.Location = new System.Drawing.Point(11, 216);
            this.dgvDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.RowTemplate.Height = 24;
            this.dgvDiem.Size = new System.Drawing.Size(984, 195);
            this.dgvDiem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý điểm sinh viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnMonHoc);
            this.groupBox1.Controls.Add(this.btnTKHocKy);
            this.groupBox1.Controls.Add(this.btnTKMSSV);
            this.groupBox1.Controls.Add(this.btnTKLop);
            this.groupBox1.Controls.Add(this.cboMonHoc);
            this.groupBox1.Controls.Add(this.cboHocKy);
            this.groupBox1.Controls.Add(this.radMonHoc);
            this.groupBox1.Controls.Add(this.radHocKy);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.radMSSV);
            this.groupBox1.Controls.Add(this.radLop);
            this.groupBox1.Location = new System.Drawing.Point(9, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(985, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thông tin";
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Location = new System.Drawing.Point(495, 56);
            this.btnMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Size = new System.Drawing.Size(33, 22);
            this.btnMonHoc.TabIndex = 16;
            this.btnMonHoc.UseVisualStyleBackColor = true;
            // 
            // btnTKHocKy
            // 
            this.btnTKHocKy.Location = new System.Drawing.Point(495, 19);
            this.btnTKHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTKHocKy.Name = "btnTKHocKy";
            this.btnTKHocKy.Size = new System.Drawing.Size(33, 22);
            this.btnTKHocKy.TabIndex = 15;
            this.btnTKHocKy.UseVisualStyleBackColor = true;
            // 
            // btnTKMSSV
            // 
            this.btnTKMSSV.Location = new System.Drawing.Point(255, 13);
            this.btnTKMSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTKMSSV.Name = "btnTKMSSV";
            this.btnTKMSSV.Size = new System.Drawing.Size(36, 22);
            this.btnTKMSSV.TabIndex = 14;
            this.btnTKMSSV.UseVisualStyleBackColor = true;
            // 
            // btnTKLop
            // 
            this.btnTKLop.Location = new System.Drawing.Point(255, 50);
            this.btnTKLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTKLop.Name = "btnTKLop";
            this.btnTKLop.Size = new System.Drawing.Size(36, 23);
            this.btnTKLop.TabIndex = 13;
            this.btnTKLop.UseVisualStyleBackColor = true;
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(386, 57);
            this.cboMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(104, 21);
            this.cboMonHoc.TabIndex = 12;
            // 
            // cboHocKy
            // 
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(385, 21);
            this.cboHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(104, 21);
            this.cboHocKy.TabIndex = 11;
            // 
            // radMonHoc
            // 
            this.radMonHoc.AutoSize = true;
            this.radMonHoc.Location = new System.Drawing.Point(311, 57);
            this.radMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radMonHoc.Name = "radMonHoc";
            this.radMonHoc.Size = new System.Drawing.Size(69, 17);
            this.radMonHoc.TabIndex = 10;
            this.radMonHoc.TabStop = true;
            this.radMonHoc.Text = "Môn học:";
            this.radMonHoc.UseVisualStyleBackColor = true;
            // 
            // radHocKy
            // 
            this.radHocKy.AutoSize = true;
            this.radHocKy.Location = new System.Drawing.Point(310, 20);
            this.radHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radHocKy.Name = "radHocKy";
            this.radHocKy.Size = new System.Drawing.Size(61, 17);
            this.radHocKy.TabIndex = 9;
            this.radHocKy.TabStop = true;
            this.radHocKy.Text = "Học kỳ:";
            this.radHocKy.UseVisualStyleBackColor = true;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(117, 53);
            this.cboLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(132, 21);
            this.cboLop.TabIndex = 7;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(117, 16);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(132, 21);
            this.txtMSSV.TabIndex = 6;
            // 
            // radMSSV
            // 
            this.radMSSV.AutoSize = true;
            this.radMSSV.Location = new System.Drawing.Point(9, 19);
            this.radMSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radMSSV.Name = "radMSSV";
            this.radMSSV.Size = new System.Drawing.Size(88, 17);
            this.radMSSV.TabIndex = 4;
            this.radMSSV.TabStop = true;
            this.radMSSV.Text = "Mã sinh viên:";
            this.radMSSV.UseVisualStyleBackColor = true;
            // 
            // radLop
            // 
            this.radLop.AutoSize = true;
            this.radLop.Location = new System.Drawing.Point(10, 56);
            this.radLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radLop.Name = "radLop";
            this.radLop.Size = new System.Drawing.Size(46, 17);
            this.radLop.TabIndex = 5;
            this.radLop.TabStop = true;
            this.radLop.Text = "Lớp:";
            this.radLop.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 49);
            this.panel1.TabIndex = 14;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChucNang.Controls.Add(this.btnLamMoi);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Controls.Add(this.btnSua);
            this.grpChucNang.Location = new System.Drawing.Point(644, 150);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(350, 60);
            this.grpChucNang.TabIndex = 15;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            this.grpChucNang.Enter += new System.EventHandler(this.grpChucNang_Enter);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(265, 19);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 32);
            this.btnLamMoi.TabIndex = 16;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(184, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 32);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(22, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(103, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sinh viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Họ tên";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Môn học";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "học kỳ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Điểm chuyên cần";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Điểm TBKT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Điểm thi lân 1";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Điểm thi lần 2";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Điểm thi nhận";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Điểm tổng kết";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Ghi chú";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 420);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDiem";
            this.Text = "Quản lý điểm sinh viên";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radHocKy;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.RadioButton radMSSV;
        private System.Windows.Forms.RadioButton radLop;
        private System.Windows.Forms.RadioButton radMonHoc;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.Button btnMonHoc;
        private System.Windows.Forms.Button btnTKHocKy;
        private System.Windows.Forms.Button btnTKMSSV;
        private System.Windows.Forms.Button btnTKLop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}