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
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaNienKhoa = new System.Windows.Forms.TextBox();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.btnMonHoc = new System.Windows.Forms.Button();
            this.btnTKHocKy = new System.Windows.Forms.Button();
            this.btnTKMSSV = new System.Windows.Forms.Button();
            this.btnTKLop = new System.Windows.Forms.Button();
            this.radMonHoc = new System.Windows.Forms.RadioButton();
            this.radHocKy = new System.Windows.Forms.RadioButton();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.radMSSV = new System.Windows.Forms.RadioButton();
            this.radLop = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLop
            // 
            this.dgvLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvLop.Location = new System.Drawing.Point(9, 228);
            this.dgvLop.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 51;
            this.dgvLop.RowTemplate.Height = 24;
            this.dgvLop.Size = new System.Drawing.Size(969, 267);
            this.dgvLop.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã lớp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên lớp";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã ngành";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã niên khóa";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin Lớp";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 62);
            this.panel1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaNienKhoa);
            this.groupBox1.Controls.Add(this.txtMaNganh);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.btnMonHoc);
            this.groupBox1.Controls.Add(this.btnTKHocKy);
            this.groupBox1.Controls.Add(this.btnTKMSSV);
            this.groupBox1.Controls.Add(this.btnTKLop);
            this.groupBox1.Controls.Add(this.radMonHoc);
            this.groupBox1.Controls.Add(this.radHocKy);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.radMSSV);
            this.groupBox1.Controls.Add(this.radLop);
            this.groupBox1.Location = new System.Drawing.Point(9, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(748, 148);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thông tin";
            // 
            // txtMaNienKhoa
            // 
            this.txtMaNienKhoa.Location = new System.Drawing.Point(482, 102);
            this.txtMaNienKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNienKhoa.Name = "txtMaNienKhoa";
            this.txtMaNienKhoa.Size = new System.Drawing.Size(168, 23);
            this.txtMaNienKhoa.TabIndex = 19;
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Location = new System.Drawing.Point(482, 39);
            this.txtMaNganh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(168, 23);
            this.txtMaNganh.TabIndex = 18;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(104, 102);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(174, 23);
            this.txtTenLop.TabIndex = 17;
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Location = new System.Drawing.Point(658, 100);
            this.btnMonHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Size = new System.Drawing.Size(38, 27);
            this.btnMonHoc.TabIndex = 16;
            this.btnMonHoc.UseVisualStyleBackColor = true;
            // 
            // btnTKHocKy
            // 
            this.btnTKHocKy.Location = new System.Drawing.Point(658, 39);
            this.btnTKHocKy.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnTKHocKy.Name = "btnTKHocKy";
            this.btnTKHocKy.Size = new System.Drawing.Size(38, 27);
            this.btnTKHocKy.TabIndex = 15;
            this.btnTKHocKy.UseVisualStyleBackColor = true;
            // 
            // btnTKMSSV
            // 
            this.btnTKMSSV.Location = new System.Drawing.Point(286, 37);
            this.btnTKMSSV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnTKMSSV.Name = "btnTKMSSV";
            this.btnTKMSSV.Size = new System.Drawing.Size(42, 27);
            this.btnTKMSSV.TabIndex = 14;
            this.btnTKMSSV.UseVisualStyleBackColor = true;
            // 
            // btnTKLop
            // 
            this.btnTKLop.Location = new System.Drawing.Point(286, 101);
            this.btnTKLop.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnTKLop.Name = "btnTKLop";
            this.btnTKLop.Size = new System.Drawing.Size(42, 28);
            this.btnTKLop.TabIndex = 13;
            this.btnTKLop.UseVisualStyleBackColor = true;
            // 
            // radMonHoc
            // 
            this.radMonHoc.AutoSize = true;
            this.radMonHoc.Location = new System.Drawing.Point(360, 108);
            this.radMonHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radMonHoc.Name = "radMonHoc";
            this.radMonHoc.Size = new System.Drawing.Size(109, 20);
            this.radMonHoc.TabIndex = 10;
            this.radMonHoc.TabStop = true;
            this.radMonHoc.Text = "Mã niên khóa:";
            this.radMonHoc.UseVisualStyleBackColor = true;
            // 
            // radHocKy
            // 
            this.radHocKy.AutoSize = true;
            this.radHocKy.Location = new System.Drawing.Point(360, 43);
            this.radHocKy.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radHocKy.Name = "radHocKy";
            this.radHocKy.Size = new System.Drawing.Size(89, 20);
            this.radHocKy.TabIndex = 9;
            this.radHocKy.TabStop = true;
            this.radHocKy.Text = "Mã ngành:";
            this.radHocKy.UseVisualStyleBackColor = true;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(104, 37);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(174, 23);
            this.txtMaLop.TabIndex = 6;
            // 
            // radMSSV
            // 
            this.radMSSV.AutoSize = true;
            this.radMSSV.Location = new System.Drawing.Point(27, 37);
            this.radMSSV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radMSSV.Name = "radMSSV";
            this.radMSSV.Size = new System.Drawing.Size(71, 20);
            this.radMSSV.TabIndex = 4;
            this.radMSSV.TabStop = true;
            this.radMSSV.Text = "Mã lớp:";
            this.radMSSV.UseVisualStyleBackColor = true;
            // 
            // radLop
            // 
            this.radLop.AutoSize = true;
            this.radLop.Location = new System.Drawing.Point(27, 106);
            this.radLop.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radLop.Name = "radLop";
            this.radLop.Size = new System.Drawing.Size(76, 20);
            this.radLop.TabIndex = 5;
            this.radLop.TabStop = true;
            this.radLop.Text = "Tên lớp:";
            this.radLop.UseVisualStyleBackColor = true;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLop);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmLop";
            this.Text = "Lớp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaNienKhoa;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Button btnMonHoc;
        private System.Windows.Forms.Button btnTKHocKy;
        private System.Windows.Forms.Button btnTKMSSV;
        private System.Windows.Forms.Button btnTKLop;
        private System.Windows.Forms.RadioButton radMonHoc;
        private System.Windows.Forms.RadioButton radHocKy;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.RadioButton radMSSV;
        private System.Windows.Forms.RadioButton radLop;
    }
}