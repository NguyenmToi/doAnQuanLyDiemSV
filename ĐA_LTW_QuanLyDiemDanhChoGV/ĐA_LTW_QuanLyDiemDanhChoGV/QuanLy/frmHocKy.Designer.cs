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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpTimKiemThongTin = new System.Windows.Forms.GroupBox();
            this.btnTKTenHocKy = new System.Windows.Forms.Button();
            this.btnTKMaHocKy = new System.Windows.Forms.Button();
            this.txtTenHocKy = new System.Windows.Forms.TextBox();
            this.txtMaHocKy = new System.Windows.Forms.TextBox();
            this.radTenHocKy = new System.Windows.Forms.RadioButton();
            this.radMaHocKy = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpTimKiemThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHocKy
            // 
            this.dgvHocKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvHocKy.Location = new System.Drawing.Point(8, 176);
            this.dgvHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHocKy.Name = "dgvHocKy";
            this.dgvHocKy.RowHeadersWidth = 51;
            this.dgvHocKy.RowTemplate.Height = 24;
            this.dgvHocKy.Size = new System.Drawing.Size(817, 195);
            this.dgvHocKy.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã học kỳ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên học kỳ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ghi chú";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin học kỳ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Location = new System.Drawing.Point(741, 116);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 33);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(579, 116);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 33);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(660, 116);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 33);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(498, 116);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 33);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 49);
            this.panel1.TabIndex = 13;
            // 
            // grpTimKiemThongTin
            // 
            this.grpTimKiemThongTin.Controls.Add(this.btnTKTenHocKy);
            this.grpTimKiemThongTin.Controls.Add(this.btnTKMaHocKy);
            this.grpTimKiemThongTin.Controls.Add(this.txtTenHocKy);
            this.grpTimKiemThongTin.Controls.Add(this.txtMaHocKy);
            this.grpTimKiemThongTin.Controls.Add(this.radTenHocKy);
            this.grpTimKiemThongTin.Controls.Add(this.radMaHocKy);
            this.grpTimKiemThongTin.Location = new System.Drawing.Point(10, 71);
            this.grpTimKiemThongTin.Name = "grpTimKiemThongTin";
            this.grpTimKiemThongTin.Size = new System.Drawing.Size(358, 100);
            this.grpTimKiemThongTin.TabIndex = 16;
            this.grpTimKiemThongTin.TabStop = false;
            this.grpTimKiemThongTin.Text = "Tìm kiếm thông tin";
            this.grpTimKiemThongTin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnTKTenHocKy
            // 
            this.btnTKTenHocKy.Location = new System.Drawing.Point(286, 59);
            this.btnTKTenHocKy.Name = "btnTKTenHocKy";
            this.btnTKTenHocKy.Size = new System.Drawing.Size(31, 22);
            this.btnTKTenHocKy.TabIndex = 16;
            this.btnTKTenHocKy.UseVisualStyleBackColor = true;
            // 
            // btnTKMaHocKy
            // 
            this.btnTKMaHocKy.Location = new System.Drawing.Point(286, 19);
            this.btnTKMaHocKy.Name = "btnTKMaHocKy";
            this.btnTKMaHocKy.Size = new System.Drawing.Size(31, 22);
            this.btnTKMaHocKy.TabIndex = 15;
            this.btnTKMaHocKy.UseVisualStyleBackColor = true;
            // 
            // txtTenHocKy
            // 
            this.txtTenHocKy.Location = new System.Drawing.Point(109, 61);
            this.txtTenHocKy.Name = "txtTenHocKy";
            this.txtTenHocKy.Size = new System.Drawing.Size(171, 21);
            this.txtTenHocKy.TabIndex = 14;
            // 
            // txtMaHocKy
            // 
            this.txtMaHocKy.Location = new System.Drawing.Point(109, 19);
            this.txtMaHocKy.Name = "txtMaHocKy";
            this.txtMaHocKy.Size = new System.Drawing.Size(171, 21);
            this.txtMaHocKy.TabIndex = 13;
            // 
            // radTenHocKy
            // 
            this.radTenHocKy.AutoSize = true;
            this.radTenHocKy.Location = new System.Drawing.Point(26, 65);
            this.radTenHocKy.Name = "radTenHocKy";
            this.radTenHocKy.Size = new System.Drawing.Size(77, 17);
            this.radTenHocKy.TabIndex = 12;
            this.radTenHocKy.TabStop = true;
            this.radTenHocKy.Text = "Tên học kỳ";
            this.radTenHocKy.UseVisualStyleBackColor = true;
            // 
            // radMaHocKy
            // 
            this.radMaHocKy.AutoSize = true;
            this.radMaHocKy.Location = new System.Drawing.Point(26, 23);
            this.radMaHocKy.Name = "radMaHocKy";
            this.radMaHocKy.Size = new System.Drawing.Size(77, 17);
            this.radMaHocKy.TabIndex = 11;
            this.radMaHocKy.TabStop = true;
            this.radMaHocKy.Text = "Mã học kỳ:";
            this.radMaHocKy.UseVisualStyleBackColor = true;
            // 
            // frmHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 379);
            this.Controls.Add(this.grpTimKiemThongTin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvHocKy);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHocKy";
            this.Text = "Học kỳ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpTimKiemThongTin.ResumeLayout(false);
            this.grpTimKiemThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpTimKiemThongTin;
        private System.Windows.Forms.Button btnTKTenHocKy;
        private System.Windows.Forms.Button btnTKMaHocKy;
        private System.Windows.Forms.TextBox txtTenHocKy;
        private System.Windows.Forms.TextBox txtMaHocKy;
        private System.Windows.Forms.RadioButton radTenHocKy;
        private System.Windows.Forms.RadioButton radMaHocKy;
    }
}