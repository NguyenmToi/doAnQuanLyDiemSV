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
            this.dgvNienKhoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.grpTimKiemThongTin = new System.Windows.Forms.GroupBox();
            this.btnTKTenNienKhoa = new System.Windows.Forms.Button();
            this.btnTKMaNienKhoa = new System.Windows.Forms.Button();
            this.txtTenNienKhoa = new System.Windows.Forms.TextBox();
            this.txtMaNienKhoa = new System.Windows.Forms.TextBox();
            this.radTenHocKy = new System.Windows.Forms.RadioButton();
            this.radMaHocKy = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNienKhoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpTimKiemThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNienKhoa
            // 
            this.dgvNienKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNienKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNienKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNienKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvNienKhoa.Location = new System.Drawing.Point(0, 176);
            this.dgvNienKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNienKhoa.Name = "dgvNienKhoa";
            this.dgvNienKhoa.RowHeadersWidth = 51;
            this.dgvNienKhoa.RowTemplate.Height = 24;
            this.dgvNienKhoa.Size = new System.Drawing.Size(759, 171);
            this.dgvNienKhoa.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã biên khóa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên niên khóa";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ghi chú";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 53);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin ngành";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpTimKiemThongTin
            // 
            this.grpTimKiemThongTin.Controls.Add(this.btnTKTenNienKhoa);
            this.grpTimKiemThongTin.Controls.Add(this.btnTKMaNienKhoa);
            this.grpTimKiemThongTin.Controls.Add(this.txtTenNienKhoa);
            this.grpTimKiemThongTin.Controls.Add(this.txtMaNienKhoa);
            this.grpTimKiemThongTin.Controls.Add(this.radTenHocKy);
            this.grpTimKiemThongTin.Controls.Add(this.radMaHocKy);
            this.grpTimKiemThongTin.Location = new System.Drawing.Point(10, 71);
            this.grpTimKiemThongTin.Name = "grpTimKiemThongTin";
            this.grpTimKiemThongTin.Size = new System.Drawing.Size(358, 100);
            this.grpTimKiemThongTin.TabIndex = 17;
            this.grpTimKiemThongTin.TabStop = false;
            this.grpTimKiemThongTin.Text = "Tìm kiếm thông tin";
            // 
            // btnTKTenNienKhoa
            // 
            this.btnTKTenNienKhoa.Location = new System.Drawing.Point(299, 59);
            this.btnTKTenNienKhoa.Name = "btnTKTenNienKhoa";
            this.btnTKTenNienKhoa.Size = new System.Drawing.Size(31, 22);
            this.btnTKTenNienKhoa.TabIndex = 16;
            this.btnTKTenNienKhoa.UseVisualStyleBackColor = true;
            // 
            // btnTKMaNienKhoa
            // 
            this.btnTKMaNienKhoa.Location = new System.Drawing.Point(299, 19);
            this.btnTKMaNienKhoa.Name = "btnTKMaNienKhoa";
            this.btnTKMaNienKhoa.Size = new System.Drawing.Size(31, 22);
            this.btnTKMaNienKhoa.TabIndex = 15;
            this.btnTKMaNienKhoa.UseVisualStyleBackColor = true;
            // 
            // txtTenNienKhoa
            // 
            this.txtTenNienKhoa.Location = new System.Drawing.Point(122, 61);
            this.txtTenNienKhoa.Name = "txtTenNienKhoa";
            this.txtTenNienKhoa.Size = new System.Drawing.Size(171, 21);
            this.txtTenNienKhoa.TabIndex = 14;
            // 
            // txtMaNienKhoa
            // 
            this.txtMaNienKhoa.Location = new System.Drawing.Point(122, 19);
            this.txtMaNienKhoa.Name = "txtMaNienKhoa";
            this.txtMaNienKhoa.Size = new System.Drawing.Size(171, 21);
            this.txtMaNienKhoa.TabIndex = 13;
            // 
            // radTenHocKy
            // 
            this.radTenHocKy.AutoSize = true;
            this.radTenHocKy.Location = new System.Drawing.Point(26, 65);
            this.radTenHocKy.Name = "radTenHocKy";
            this.radTenHocKy.Size = new System.Drawing.Size(96, 17);
            this.radTenHocKy.TabIndex = 12;
            this.radTenHocKy.TabStop = true;
            this.radTenHocKy.Text = "Tên niên khóa:";
            this.radTenHocKy.UseVisualStyleBackColor = true;
            // 
            // radMaHocKy
            // 
            this.radMaHocKy.AutoSize = true;
            this.radMaHocKy.Location = new System.Drawing.Point(26, 23);
            this.radMaHocKy.Name = "radMaHocKy";
            this.radMaHocKy.Size = new System.Drawing.Size(92, 17);
            this.radMaHocKy.TabIndex = 11;
            this.radMaHocKy.TabStop = true;
            this.radMaHocKy.Text = "Mã niên khóa:";
            this.radMaHocKy.UseVisualStyleBackColor = true;
            // 
            // frmNienKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 358);
            this.Controls.Add(this.grpTimKiemThongTin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvNienKhoa);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNienKhoa";
            this.Text = "Niên khóa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNienKhoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpTimKiemThongTin.ResumeLayout(false);
            this.grpTimKiemThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNienKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpTimKiemThongTin;
        private System.Windows.Forms.Button btnTKTenNienKhoa;
        private System.Windows.Forms.Button btnTKMaNienKhoa;
        private System.Windows.Forms.TextBox txtTenNienKhoa;
        private System.Windows.Forms.TextBox txtMaNienKhoa;
        private System.Windows.Forms.RadioButton radTenHocKy;
        private System.Windows.Forms.RadioButton radMaHocKy;
    }
}