namespace ĐA_LTW_QuanLyDiemDanhChoGV
{
    partial class frmDiemTongKetSV
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
            this.dgvBangDiemTongKetSV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.lblNganh = new System.Windows.Forms.Label();
            this.lblNienKhoa = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblTenSinhVien = new System.Windows.Forms.Label();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiemTongKetSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBangDiemTongKetSV
            // 
            this.dgvBangDiemTongKetSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangDiemTongKetSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangDiemTongKetSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDiemTongKetSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvBangDiemTongKetSV.Location = new System.Drawing.Point(12, 263);
            this.dgvBangDiemTongKetSV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvBangDiemTongKetSV.Name = "dgvBangDiemTongKetSV";
            this.dgvBangDiemTongKetSV.RowHeadersWidth = 51;
            this.dgvBangDiemTongKetSV.RowTemplate.Height = 24;
            this.dgvBangDiemTongKetSV.Size = new System.Drawing.Size(1009, 216);
            this.dgvBangDiemTongKetSV.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Môn";
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
            this.Column4.HeaderText = "Tổng kết";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Học kỳ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kết quả học tập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblQueQuan);
            this.groupBox1.Controls.Add(this.lblNganh);
            this.groupBox1.Controls.Add(this.lblNienKhoa);
            this.groupBox1.Controls.Add(this.lblLop);
            this.groupBox1.Controls.Add(this.lblTenSinhVien);
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(1009, 185);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(768, 123);
            this.lblQueQuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(73, 16);
            this.lblQueQuan.TabIndex = 12;
            this.lblQueQuan.Text = "lblQueQuan";
            // 
            // lblNganh
            // 
            this.lblNganh.AutoSize = true;
            this.lblNganh.Location = new System.Drawing.Point(768, 37);
            this.lblNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNganh.Name = "lblNganh";
            this.lblNganh.Size = new System.Drawing.Size(56, 16);
            this.lblNganh.TabIndex = 11;
            this.lblNganh.Text = "lblNganh";
            // 
            // lblNienKhoa
            // 
            this.lblNienKhoa.AutoSize = true;
            this.lblNienKhoa.Location = new System.Drawing.Point(449, 126);
            this.lblNienKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNienKhoa.Name = "lblNienKhoa";
            this.lblNienKhoa.Size = new System.Drawing.Size(73, 16);
            this.lblNienKhoa.TabIndex = 10;
            this.lblNienKhoa.Text = "lblNienKhoa";
            this.lblNienKhoa.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(449, 37);
            this.lblLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(40, 16);
            this.lblLop.TabIndex = 9;
            this.lblLop.Text = "lblLop";
            // 
            // lblTenSinhVien
            // 
            this.lblTenSinhVien.AutoSize = true;
            this.lblTenSinhVien.Location = new System.Drawing.Point(121, 37);
            this.lblTenSinhVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSinhVien.Name = "lblTenSinhVien";
            this.lblTenSinhVien.Size = new System.Drawing.Size(93, 16);
            this.lblTenSinhVien.TabIndex = 8;
            this.lblTenSinhVien.Text = "lblTenSInhVien";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(192, 123);
            this.radNu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(44, 20);
            this.radNu.TabIndex = 7;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(121, 123);
            this.radNam.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(54, 20);
            this.radNam.TabIndex = 6;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Quê quán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Niên khóa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngành:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 54);
            this.panel1.TabIndex = 5;
            // 
            // frmDiemTongKetSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBangDiemTongKetSV);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmDiemTongKetSV";
            this.Text = "Thông tin kết quả học tập sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiemTongKetSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBangDiemTongKetSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label lblNganh;
        private System.Windows.Forms.Label lblNienKhoa;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblTenSinhVien;
        private System.Windows.Forms.Panel panel1;
    }
}