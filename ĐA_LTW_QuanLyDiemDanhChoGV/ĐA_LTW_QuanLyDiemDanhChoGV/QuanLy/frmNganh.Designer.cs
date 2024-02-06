namespace ĐA_LTW_QuanLyDiemDanhChoGV
{
    partial class frmNganh
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
            this.dgvNganh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpTimKiemThongTin = new System.Windows.Forms.GroupBox();
            this.btnTkTenNganh = new System.Windows.Forms.Button();
            this.btnTKMaNganh = new System.Windows.Forms.Button();
            this.btnMaKhoa = new System.Windows.Forms.Button();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenNganh = new System.Windows.Forms.TextBox();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.radMaKhoa = new System.Windows.Forms.RadioButton();
            this.radTenNganh = new System.Windows.Forms.RadioButton();
            this.radMaNganh = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganh)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpTimKiemThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNganh
            // 
            this.dgvNganh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNganh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvNganh.Location = new System.Drawing.Point(10, 166);
            this.dgvNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNganh.Name = "dgvNganh";
            this.dgvNganh.RowHeadersWidth = 51;
            this.dgvNganh.RowTemplate.Height = 24;
            this.dgvNganh.Size = new System.Drawing.Size(828, 200);
            this.dgvNganh.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã ngành";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên ngành";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã khoa";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ghi chú";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin ngành";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 53);
            this.panel1.TabIndex = 15;
            // 
            // grpTimKiemThongTin
            // 
            this.grpTimKiemThongTin.Controls.Add(this.btnTkTenNganh);
            this.grpTimKiemThongTin.Controls.Add(this.btnTKMaNganh);
            this.grpTimKiemThongTin.Controls.Add(this.btnMaKhoa);
            this.grpTimKiemThongTin.Controls.Add(this.txtMaKhoa);
            this.grpTimKiemThongTin.Controls.Add(this.txtTenNganh);
            this.grpTimKiemThongTin.Controls.Add(this.txtMaNganh);
            this.grpTimKiemThongTin.Controls.Add(this.radMaKhoa);
            this.grpTimKiemThongTin.Controls.Add(this.radTenNganh);
            this.grpTimKiemThongTin.Controls.Add(this.radMaNganh);
            this.grpTimKiemThongTin.Location = new System.Drawing.Point(10, 61);
            this.grpTimKiemThongTin.Name = "grpTimKiemThongTin";
            this.grpTimKiemThongTin.Size = new System.Drawing.Size(660, 100);
            this.grpTimKiemThongTin.TabIndex = 17;
            this.grpTimKiemThongTin.TabStop = false;
            this.grpTimKiemThongTin.Text = "Tìm kiếm thông tin";
            // 
            // btnTkTenNganh
            // 
            this.btnTkTenNganh.Location = new System.Drawing.Point(294, 61);
            this.btnTkTenNganh.Name = "btnTkTenNganh";
            this.btnTkTenNganh.Size = new System.Drawing.Size(31, 22);
            this.btnTkTenNganh.TabIndex = 10;
            this.btnTkTenNganh.UseVisualStyleBackColor = true;
            // 
            // btnTKMaNganh
            // 
            this.btnTKMaNganh.Location = new System.Drawing.Point(294, 20);
            this.btnTKMaNganh.Name = "btnTKMaNganh";
            this.btnTKMaNganh.Size = new System.Drawing.Size(31, 22);
            this.btnTKMaNganh.TabIndex = 9;
            this.btnTKMaNganh.UseVisualStyleBackColor = true;
            // 
            // btnMaKhoa
            // 
            this.btnMaKhoa.Location = new System.Drawing.Point(604, 21);
            this.btnMaKhoa.Name = "btnMaKhoa";
            this.btnMaKhoa.Size = new System.Drawing.Size(31, 22);
            this.btnMaKhoa.TabIndex = 8;
            this.btnMaKhoa.UseVisualStyleBackColor = true;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(434, 22);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(164, 21);
            this.txtMaKhoa.TabIndex = 5;
            // 
            // txtTenNganh
            // 
            this.txtTenNganh.Location = new System.Drawing.Point(117, 61);
            this.txtTenNganh.Name = "txtTenNganh";
            this.txtTenNganh.Size = new System.Drawing.Size(171, 21);
            this.txtTenNganh.TabIndex = 4;
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Location = new System.Drawing.Point(117, 20);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(171, 21);
            this.txtMaNganh.TabIndex = 3;
            // 
            // radMaKhoa
            // 
            this.radMaKhoa.AutoSize = true;
            this.radMaKhoa.Location = new System.Drawing.Point(356, 22);
            this.radMaKhoa.Name = "radMaKhoa";
            this.radMaKhoa.Size = new System.Drawing.Size(69, 17);
            this.radMaKhoa.TabIndex = 2;
            this.radMaKhoa.TabStop = true;
            this.radMaKhoa.Text = "Mã khoa:";
            this.radMaKhoa.UseVisualStyleBackColor = true;
            // 
            // radTenNganh
            // 
            this.radTenNganh.AutoSize = true;
            this.radTenNganh.Location = new System.Drawing.Point(25, 65);
            this.radTenNganh.Name = "radTenNganh";
            this.radTenNganh.Size = new System.Drawing.Size(80, 17);
            this.radTenNganh.TabIndex = 1;
            this.radTenNganh.TabStop = true;
            this.radTenNganh.Text = "Tên ngành:";
            this.radTenNganh.UseVisualStyleBackColor = true;
            // 
            // radMaNganh
            // 
            this.radMaNganh.AutoSize = true;
            this.radMaNganh.Location = new System.Drawing.Point(25, 21);
            this.radMaNganh.Name = "radMaNganh";
            this.radMaNganh.Size = new System.Drawing.Size(76, 17);
            this.radMaNganh.TabIndex = 0;
            this.radMaNganh.TabStop = true;
            this.radMaNganh.Text = "Mã ngành:";
            this.radMaNganh.UseVisualStyleBackColor = true;
            // 
            // frmNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 375);
            this.Controls.Add(this.grpTimKiemThongTin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvNganh);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNganh";
            this.Text = "Ngành";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpTimKiemThongTin.ResumeLayout(false);
            this.grpTimKiemThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNganh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpTimKiemThongTin;
        private System.Windows.Forms.Button btnTkTenNganh;
        private System.Windows.Forms.Button btnTKMaNganh;
        private System.Windows.Forms.Button btnMaKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenNganh;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.RadioButton radMaKhoa;
        private System.Windows.Forms.RadioButton radTenNganh;
        private System.Windows.Forms.RadioButton radMaNganh;
    }
}