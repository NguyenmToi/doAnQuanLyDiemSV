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
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTKTenKhoa = new System.Windows.Forms.Button();
            this.btnTKMaKhoa = new System.Windows.Forms.Button();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.radTenKhoa = new System.Windows.Forms.RadioButton();
            this.radMaKhoa = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvKhoa.Location = new System.Drawing.Point(10, 176);
            this.dgvKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.RowHeadersWidth = 51;
            this.dgvKhoa.RowTemplate.Height = 24;
            this.dgvKhoa.Size = new System.Drawing.Size(803, 175);
            this.dgvKhoa.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã khoa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên khoa";
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
            this.panel1.Size = new System.Drawing.Size(823, 49);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin khoa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTKTenKhoa);
            this.groupBox1.Controls.Add(this.btnTKMaKhoa);
            this.groupBox1.Controls.Add(this.txtTenKhoa);
            this.groupBox1.Controls.Add(this.txtMaKhoa);
            this.groupBox1.Controls.Add(this.radTenKhoa);
            this.groupBox1.Controls.Add(this.radMaKhoa);
            this.groupBox1.Location = new System.Drawing.Point(10, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thông tin";
            // 
            // btnTKTenKhoa
            // 
            this.btnTKTenKhoa.Location = new System.Drawing.Point(285, 59);
            this.btnTKTenKhoa.Name = "btnTKTenKhoa";
            this.btnTKTenKhoa.Size = new System.Drawing.Size(31, 22);
            this.btnTKTenKhoa.TabIndex = 16;
            this.btnTKTenKhoa.UseVisualStyleBackColor = true;
            // 
            // btnTKMaKhoa
            // 
            this.btnTKMaKhoa.Location = new System.Drawing.Point(285, 19);
            this.btnTKMaKhoa.Name = "btnTKMaKhoa";
            this.btnTKMaKhoa.Size = new System.Drawing.Size(31, 22);
            this.btnTKMaKhoa.TabIndex = 15;
            this.btnTKMaKhoa.UseVisualStyleBackColor = true;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(108, 60);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(171, 21);
            this.txtTenKhoa.TabIndex = 14;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(108, 18);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(171, 21);
            this.txtMaKhoa.TabIndex = 13;
            // 
            // radTenKhoa
            // 
            this.radTenKhoa.AutoSize = true;
            this.radTenKhoa.Location = new System.Drawing.Point(26, 65);
            this.radTenKhoa.Name = "radTenKhoa";
            this.radTenKhoa.Size = new System.Drawing.Size(76, 17);
            this.radTenKhoa.TabIndex = 12;
            this.radTenKhoa.TabStop = true;
            this.radTenKhoa.Text = "Tên  khoa:";
            this.radTenKhoa.UseVisualStyleBackColor = true;
            // 
            // radMaKhoa
            // 
            this.radMaKhoa.AutoSize = true;
            this.radMaKhoa.Location = new System.Drawing.Point(26, 23);
            this.radMaKhoa.Name = "radMaKhoa";
            this.radMaKhoa.Size = new System.Drawing.Size(69, 17);
            this.radMaKhoa.TabIndex = 11;
            this.radMaKhoa.TabStop = true;
            this.radMaKhoa.Text = "Mã khoa:";
            this.radMaKhoa.UseVisualStyleBackColor = true;
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 362);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvKhoa);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKhoa";
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.frmKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTKTenKhoa;
        private System.Windows.Forms.Button btnTKMaKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.RadioButton radTenKhoa;
        private System.Windows.Forms.RadioButton radMaKhoa;
    }
}