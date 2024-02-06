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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTkTenMonHoc = new System.Windows.Forms.Button();
            this.btnTKMaMonHoc = new System.Windows.Forms.Button();
            this.btnTKSoTinChi = new System.Windows.Forms.Button();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.radSoTinChi = new System.Windows.Forms.RadioButton();
            this.radTenMonHoc = new System.Windows.Forms.RadioButton();
            this.radMaMonHoc = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin môn học";
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvMonHoc.Location = new System.Drawing.Point(8, 164);
            this.dgvMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.RowHeadersWidth = 51;
            this.dgvMonHoc.RowTemplate.Height = 24;
            this.dgvMonHoc.Size = new System.Drawing.Size(847, 185);
            this.dgvMonHoc.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã môn học";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên môn học";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số tín chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ghi chú";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 50);
            this.panel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTkTenMonHoc);
            this.groupBox1.Controls.Add(this.btnTKMaMonHoc);
            this.groupBox1.Controls.Add(this.btnTKSoTinChi);
            this.groupBox1.Controls.Add(this.txtSoTinChi);
            this.groupBox1.Controls.Add(this.txtTenMonHoc);
            this.groupBox1.Controls.Add(this.txtMaMonHoc);
            this.groupBox1.Controls.Add(this.radSoTinChi);
            this.groupBox1.Controls.Add(this.radTenMonHoc);
            this.groupBox1.Controls.Add(this.radMaMonHoc);
            this.groupBox1.Location = new System.Drawing.Point(8, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thông tin";
            // 
            // btnTkTenMonHoc
            // 
            this.btnTkTenMonHoc.Location = new System.Drawing.Point(294, 61);
            this.btnTkTenMonHoc.Name = "btnTkTenMonHoc";
            this.btnTkTenMonHoc.Size = new System.Drawing.Size(31, 22);
            this.btnTkTenMonHoc.TabIndex = 10;
            this.btnTkTenMonHoc.UseVisualStyleBackColor = true;
            // 
            // btnTKMaMonHoc
            // 
            this.btnTKMaMonHoc.Location = new System.Drawing.Point(294, 20);
            this.btnTKMaMonHoc.Name = "btnTKMaMonHoc";
            this.btnTKMaMonHoc.Size = new System.Drawing.Size(31, 22);
            this.btnTKMaMonHoc.TabIndex = 9;
            this.btnTKMaMonHoc.UseVisualStyleBackColor = true;
            // 
            // btnTKSoTinChi
            // 
            this.btnTKSoTinChi.Location = new System.Drawing.Point(604, 21);
            this.btnTKSoTinChi.Name = "btnTKSoTinChi";
            this.btnTKSoTinChi.Size = new System.Drawing.Size(31, 22);
            this.btnTKSoTinChi.TabIndex = 8;
            this.btnTKSoTinChi.UseVisualStyleBackColor = true;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Location = new System.Drawing.Point(434, 22);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(164, 21);
            this.txtSoTinChi.TabIndex = 5;
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Location = new System.Drawing.Point(117, 61);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(171, 21);
            this.txtTenMonHoc.TabIndex = 4;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Location = new System.Drawing.Point(117, 20);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(171, 21);
            this.txtMaMonHoc.TabIndex = 3;
            // 
            // radSoTinChi
            // 
            this.radSoTinChi.AutoSize = true;
            this.radSoTinChi.Location = new System.Drawing.Point(356, 22);
            this.radSoTinChi.Name = "radSoTinChi";
            this.radSoTinChi.Size = new System.Drawing.Size(72, 17);
            this.radSoTinChi.TabIndex = 2;
            this.radSoTinChi.TabStop = true;
            this.radSoTinChi.Text = "Số tín chỉ:";
            this.radSoTinChi.UseVisualStyleBackColor = true;
            // 
            // radTenMonHoc
            // 
            this.radTenMonHoc.AutoSize = true;
            this.radTenMonHoc.Location = new System.Drawing.Point(25, 65);
            this.radTenMonHoc.Name = "radTenMonHoc";
            this.radTenMonHoc.Size = new System.Drawing.Size(90, 17);
            this.radTenMonHoc.TabIndex = 1;
            this.radTenMonHoc.TabStop = true;
            this.radTenMonHoc.Text = "Tên môn học:";
            this.radTenMonHoc.UseVisualStyleBackColor = true;
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
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMonHoc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMonHoc";
            this.Text = "Môn học";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTkTenMonHoc;
        private System.Windows.Forms.Button btnTKMaMonHoc;
        private System.Windows.Forms.Button btnTKSoTinChi;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.RadioButton radSoTinChi;
        private System.Windows.Forms.RadioButton radTenMonHoc;
        private System.Windows.Forms.RadioButton radMaMonHoc;
    }
}