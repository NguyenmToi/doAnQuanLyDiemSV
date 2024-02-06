namespace ĐA_LTW_QuanLyDiemDanhChoGV.Giang_Vien
{
    partial class frmSinhVien
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
            this.components = new System.ComponentModel.Container();
            this.colSV_TenGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSV_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSV_CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSV_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSV_DanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSV_LOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSV_TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSV_Nganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSV_TenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSV_NienKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSV_TenNienKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSV_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSV_GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSV_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbltk3 = new System.Windows.Forms.Label();
            this.lbltk1 = new System.Windows.Forms.Label();
            this.lbltk2 = new System.Windows.Forms.Label();
            this.lblSoLuongSVTK = new System.Windows.Forms.Label();
            this.lblTKSV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSV_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.radGhiChu = new System.Windows.Forms.RadioButton();
            this.radDanToc = new System.Windows.Forms.RadioButton();
            this.radDiaChi = new System.Windows.Forms.RadioButton();
            this.radEmail = new System.Windows.Forms.RadioButton();
            this.cboNienKhoa = new System.Windows.Forms.ComboBox();
            this.cboNganh = new System.Windows.Forms.ComboBox();
            this.radNganh = new System.Windows.Forms.RadioButton();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDanToc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.grpGioiTinh = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtSoCCCD = new System.Windows.Forms.TextBox();
            this.radSoCCCD = new System.Windows.Forms.RadioButton();
            this.radNienKhoa = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.radLop = new System.Windows.Forms.RadioButton();
            this.radMSSV = new System.Windows.Forms.RadioButton();
            this.radHoTen = new System.Windows.Forms.RadioButton();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.colSV_MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.grpGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // colSV_TenGT
            // 
            this.colSV_TenGT.DataPropertyName = "TENGIOITINH";
            this.colSV_TenGT.HeaderText = "Giới tính";
            this.colSV_TenGT.Name = "colSV_TenGT";
            this.colSV_TenGT.Width = 94;
            // 
            // colSV_NgaySinh
            // 
            this.colSV_NgaySinh.DataPropertyName = "NGAYSINH";
            this.colSV_NgaySinh.HeaderText = "Ngày sinh";
            this.colSV_NgaySinh.MinimumWidth = 6;
            this.colSV_NgaySinh.Name = "colSV_NgaySinh";
            this.colSV_NgaySinh.Width = 95;
            // 
            // colSV_CCCD
            // 
            this.colSV_CCCD.DataPropertyName = "CCCD";
            this.colSV_CCCD.HeaderText = "CCCD";
            this.colSV_CCCD.MinimumWidth = 6;
            this.colSV_CCCD.Name = "colSV_CCCD";
            this.colSV_CCCD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSV_CCCD.Width = 94;
            // 
            // colSV_Email
            // 
            this.colSV_Email.DataPropertyName = "EMAIL";
            this.colSV_Email.HeaderText = "Email";
            this.colSV_Email.MinimumWidth = 6;
            this.colSV_Email.Name = "colSV_Email";
            this.colSV_Email.Width = 160;
            // 
            // colSV_DanToc
            // 
            this.colSV_DanToc.DataPropertyName = "DANTOC";
            this.colSV_DanToc.HeaderText = "Dân tộc";
            this.colSV_DanToc.Name = "colSV_DanToc";
            this.colSV_DanToc.Width = 94;
            // 
            // colSV_LOP
            // 
            this.colSV_LOP.DataPropertyName = "MALOP";
            this.colSV_LOP.HeaderText = "Lớp";
            this.colSV_LOP.MinimumWidth = 6;
            this.colSV_LOP.Name = "colSV_LOP";
            this.colSV_LOP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSV_LOP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSV_LOP.Visible = false;
            // 
            // colSV_TenLop
            // 
            this.colSV_TenLop.DataPropertyName = "TENLOP";
            this.colSV_TenLop.HeaderText = "Lớp";
            this.colSV_TenLop.Name = "colSV_TenLop";
            this.colSV_TenLop.Width = 94;
            // 
            // colSV_Nganh
            // 
            this.colSV_Nganh.DataPropertyName = "NGANH";
            this.colSV_Nganh.HeaderText = "Ngành";
            this.colSV_Nganh.Name = "colSV_Nganh";
            this.colSV_Nganh.Visible = false;
            this.colSV_Nganh.Width = 110;
            // 
            // colSV_TenNganh
            // 
            this.colSV_TenNganh.DataPropertyName = "TENNGANH";
            this.colSV_TenNganh.HeaderText = "Ngành";
            this.colSV_TenNganh.Name = "colSV_TenNganh";
            this.colSV_TenNganh.Width = 150;
            // 
            // colSV_NienKhoa
            // 
            this.colSV_NienKhoa.DataPropertyName = "NIENKHOA";
            this.colSV_NienKhoa.HeaderText = "Niên khóa";
            this.colSV_NienKhoa.MinimumWidth = 6;
            this.colSV_NienKhoa.Name = "colSV_NienKhoa";
            this.colSV_NienKhoa.Visible = false;
            this.colSV_NienKhoa.Width = 94;
            // 
            // colSV_TenNienKhoa
            // 
            this.colSV_TenNienKhoa.DataPropertyName = "TENNIENKHOA";
            this.colSV_TenNienKhoa.HeaderText = "Niên khóa";
            this.colSV_TenNienKhoa.Name = "colSV_TenNienKhoa";
            // 
            // colSV_GhiChu
            // 
            this.colSV_GhiChu.DataPropertyName = "GHICHU";
            this.colSV_GhiChu.HeaderText = "Ghi chú";
            this.colSV_GhiChu.Name = "colSV_GhiChu";
            this.colSV_GhiChu.Width = 150;
            // 
            // colSV_GT
            // 
            this.colSV_GT.DataPropertyName = "GIOITINH";
            this.colSV_GT.HeaderText = "Giới tính";
            this.colSV_GT.Name = "colSV_GT";
            this.colSV_GT.Visible = false;
            // 
            // colSV_DiaChi
            // 
            this.colSV_DiaChi.DataPropertyName = "DIACHI";
            this.colSV_DiaChi.HeaderText = "Địa chỉ";
            this.colSV_DiaChi.MinimumWidth = 6;
            this.colSV_DiaChi.Name = "colSV_DiaChi";
            this.colSV_DiaChi.Width = 150;
            // 
            // lbltk3
            // 
            this.lbltk3.AutoSize = true;
            this.lbltk3.Location = new System.Drawing.Point(141, 29);
            this.lbltk3.Name = "lbltk3";
            this.lbltk3.Size = new System.Drawing.Size(49, 13);
            this.lbltk3.TabIndex = 2;
            this.lbltk3.Text = "sinh viên";
            // 
            // lbltk1
            // 
            this.lbltk1.AutoSize = true;
            this.lbltk1.Location = new System.Drawing.Point(42, 29);
            this.lbltk1.Name = "lbltk1";
            this.lbltk1.Size = new System.Drawing.Size(55, 13);
            this.lbltk1.TabIndex = 0;
            this.lbltk1.Text = "Có tất cả:";
            // 
            // lbltk2
            // 
            this.lbltk2.AutoSize = true;
            this.lbltk2.Location = new System.Drawing.Point(103, 29);
            this.lbltk2.Name = "lbltk2";
            this.lbltk2.Size = new System.Drawing.Size(32, 13);
            this.lbltk2.TabIndex = 1;
            this.lbltk2.Text = "lbltk2";
            // 
            // lblSoLuongSVTK
            // 
            this.lblSoLuongSVTK.AutoSize = true;
            this.lblSoLuongSVTK.Location = new System.Drawing.Point(137, 29);
            this.lblSoLuongSVTK.Name = "lblSoLuongSVTK";
            this.lblSoLuongSVTK.Size = new System.Drawing.Size(17, 13);
            this.lblSoLuongSVTK.TabIndex = 1;
            this.lblSoLuongSVTK.Text = "lbl";
            // 
            // lblTKSV
            // 
            this.lblTKSV.AutoSize = true;
            this.lblTKSV.Location = new System.Drawing.Point(160, 29);
            this.lblTKSV.Name = "lblTKSV";
            this.lblTKSV.Size = new System.Drawing.Size(118, 13);
            this.lblTKSV.TabIndex = 2;
            this.lblTKSV.Text = "sinh viên được tìm thấy";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSoLuongSVTK);
            this.groupBox1.Controls.Add(this.lblTKSV);
            this.groupBox1.Location = new System.Drawing.Point(576, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê kết quả tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Có";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lbltk3);
            this.groupBox2.Controls.Add(this.lbltk1);
            this.groupBox2.Controls.Add(this.lbltk2);
            this.groupBox2.Location = new System.Drawing.Point(265, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê số lượng";
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TRANGTHAI";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = false;
            // 
            // colSV_HoTen
            // 
            this.colSV_HoTen.DataPropertyName = "HOTEN";
            this.colSV_HoTen.HeaderText = "Họ tên";
            this.colSV_HoTen.MinimumWidth = 6;
            this.colSV_HoTen.Name = "colSV_HoTen";
            this.colSV_HoTen.Width = 120;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.radGhiChu);
            this.grpThongTin.Controls.Add(this.radDanToc);
            this.grpThongTin.Controls.Add(this.radDiaChi);
            this.grpThongTin.Controls.Add(this.radEmail);
            this.grpThongTin.Controls.Add(this.cboNienKhoa);
            this.grpThongTin.Controls.Add(this.cboNganh);
            this.grpThongTin.Controls.Add(this.radNganh);
            this.grpThongTin.Controls.Add(this.txtGhiChu);
            this.grpThongTin.Controls.Add(this.txtEmail);
            this.grpThongTin.Controls.Add(this.txtDanToc);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.dtpNgaySinh);
            this.grpThongTin.Controls.Add(this.grpGioiTinh);
            this.grpThongTin.Controls.Add(this.txtSoCCCD);
            this.grpThongTin.Controls.Add(this.radSoCCCD);
            this.grpThongTin.Controls.Add(this.radNienKhoa);
            this.grpThongTin.Controls.Add(this.txtDiaChi);
            this.grpThongTin.Controls.Add(this.cboLop);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.txtMSSV);
            this.grpThongTin.Controls.Add(this.radLop);
            this.grpThongTin.Controls.Add(this.radMSSV);
            this.grpThongTin.Controls.Add(this.radHoTen);
            this.grpThongTin.Location = new System.Drawing.Point(11, 5);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(2);
            this.grpThongTin.Size = new System.Drawing.Size(1183, 147);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin sinh viên";
            // 
            // radGhiChu
            // 
            this.radGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGhiChu.AutoSize = true;
            this.radGhiChu.Location = new System.Drawing.Point(841, 113);
            this.radGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.radGhiChu.Name = "radGhiChu";
            this.radGhiChu.Size = new System.Drawing.Size(64, 17);
            this.radGhiChu.TabIndex = 21;
            this.radGhiChu.Text = "Ghi chú:";
            this.radGhiChu.UseVisualStyleBackColor = true;
            // 
            // radDanToc
            // 
            this.radDanToc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radDanToc.AutoSize = true;
            this.radDanToc.Location = new System.Drawing.Point(841, 24);
            this.radDanToc.Margin = new System.Windows.Forms.Padding(2);
            this.radDanToc.Name = "radDanToc";
            this.radDanToc.Size = new System.Drawing.Size(66, 17);
            this.radDanToc.TabIndex = 6;
            this.radDanToc.Text = "Dân tộc:";
            this.radDanToc.UseVisualStyleBackColor = true;
            // 
            // radDiaChi
            // 
            this.radDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radDiaChi.AutoSize = true;
            this.radDiaChi.Location = new System.Drawing.Point(841, 71);
            this.radDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.radDiaChi.Name = "radDiaChi";
            this.radDiaChi.Size = new System.Drawing.Size(61, 17);
            this.radDiaChi.TabIndex = 13;
            this.radDiaChi.Text = "Địa chỉ:";
            this.radDiaChi.UseVisualStyleBackColor = true;
            // 
            // radEmail
            // 
            this.radEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radEmail.AutoSize = true;
            this.radEmail.Location = new System.Drawing.Point(290, 112);
            this.radEmail.Margin = new System.Windows.Forms.Padding(2);
            this.radEmail.Name = "radEmail";
            this.radEmail.Size = new System.Drawing.Size(53, 17);
            this.radEmail.TabIndex = 17;
            this.radEmail.Text = "Email:";
            this.radEmail.UseVisualStyleBackColor = true;
            this.radEmail.CheckedChanged += new System.EventHandler(this.radEmail_CheckedChanged);
            // 
            // cboNienKhoa
            // 
            this.cboNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNienKhoa.FormattingEnabled = true;
            this.cboNienKhoa.Location = new System.Drawing.Point(638, 112);
            this.cboNienKhoa.Name = "cboNienKhoa";
            this.cboNienKhoa.Size = new System.Drawing.Size(146, 21);
            this.cboNienKhoa.TabIndex = 20;
            // 
            // cboNganh
            // 
            this.cboNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNganh.FormattingEnabled = true;
            this.cboNganh.Location = new System.Drawing.Point(621, 67);
            this.cboNganh.Margin = new System.Windows.Forms.Padding(2);
            this.cboNganh.Name = "cboNganh";
            this.cboNganh.Size = new System.Drawing.Size(166, 21);
            this.cboNganh.TabIndex = 12;
            this.cboNganh.SelectedIndexChanged += new System.EventHandler(this.cboNganh_SelectedIndexChanged);
            // 
            // radNganh
            // 
            this.radNganh.AutoSize = true;
            this.radNganh.Location = new System.Drawing.Point(557, 70);
            this.radNganh.Margin = new System.Windows.Forms.Padding(2);
            this.radNganh.Name = "radNganh";
            this.radNganh.Size = new System.Drawing.Size(60, 17);
            this.radNganh.TabIndex = 11;
            this.radNganh.Text = "Ngành:";
            this.radNganh.UseVisualStyleBackColor = true;
            this.radNganh.CheckedChanged += new System.EventHandler(this.radNganh_CheckedChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(910, 112);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(172, 21);
            this.txtGhiChu.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(345, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 21);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtDanToc
            // 
            this.txtDanToc.Location = new System.Drawing.Point(910, 20);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.Size = new System.Drawing.Size(172, 21);
            this.txtDanToc.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd//MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(71, 112);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(152, 21);
            this.dtpNgaySinh.TabIndex = 16;
            // 
            // grpGioiTinh
            // 
            this.grpGioiTinh.Controls.Add(this.label1);
            this.grpGioiTinh.Controls.Add(this.radNu);
            this.grpGioiTinh.Controls.Add(this.radNam);
            this.grpGioiTinh.Location = new System.Drawing.Point(287, 59);
            this.grpGioiTinh.Name = "grpGioiTinh";
            this.grpGioiTinh.Size = new System.Drawing.Size(219, 36);
            this.grpGioiTinh.TabIndex = 10;
            this.grpGioiTinh.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giới tính:";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(145, 15);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 2;
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
            this.radNam.TabIndex = 1;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // txtSoCCCD
            // 
            this.txtSoCCCD.Location = new System.Drawing.Point(366, 24);
            this.txtSoCCCD.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoCCCD.Name = "txtSoCCCD";
            this.txtSoCCCD.Size = new System.Drawing.Size(140, 21);
            this.txtSoCCCD.TabIndex = 3;
            this.txtSoCCCD.TextChanged += new System.EventHandler(this.txtSoCCCD_TextChanged);
            // 
            // radSoCCCD
            // 
            this.radSoCCCD.AutoSize = true;
            this.radSoCCCD.Location = new System.Drawing.Point(287, 25);
            this.radSoCCCD.Margin = new System.Windows.Forms.Padding(2);
            this.radSoCCCD.Name = "radSoCCCD";
            this.radSoCCCD.Size = new System.Drawing.Size(72, 17);
            this.radSoCCCD.TabIndex = 2;
            this.radSoCCCD.Text = "Số CCCD:";
            this.radSoCCCD.UseVisualStyleBackColor = true;
            this.radSoCCCD.CheckedChanged += new System.EventHandler(this.radSoCCCD_CheckedChanged);
            // 
            // radNienKhoa
            // 
            this.radNienKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radNienKhoa.AutoSize = true;
            this.radNienKhoa.Location = new System.Drawing.Point(557, 115);
            this.radNienKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.radNienKhoa.Name = "radNienKhoa";
            this.radNienKhoa.Size = new System.Drawing.Size(76, 17);
            this.radNienKhoa.TabIndex = 19;
            this.radNienKhoa.Text = "Niên khóa:";
            this.radNienKhoa.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(910, 67);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(172, 21);
            this.txtDiaChi.TabIndex = 14;
            // 
            // cboLop
            // 
            this.cboLop.AllowDrop = true;
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(621, 21);
            this.cboLop.Margin = new System.Windows.Forms.Padding(2);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(166, 21);
            this.cboLop.TabIndex = 5;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            this.cboLop.TextUpdate += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(71, 67);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(152, 21);
            this.txtHoTen.TabIndex = 9;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(71, 24);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(152, 21);
            this.txtMSSV.TabIndex = 1;
            this.txtMSSV.TextChanged += new System.EventHandler(this.txtMSSV_TextChanged);
            // 
            // radLop
            // 
            this.radLop.AutoSize = true;
            this.radLop.Location = new System.Drawing.Point(557, 25);
            this.radLop.Margin = new System.Windows.Forms.Padding(2);
            this.radLop.Name = "radLop";
            this.radLop.Size = new System.Drawing.Size(46, 17);
            this.radLop.TabIndex = 4;
            this.radLop.Text = "Lớp:";
            this.radLop.UseVisualStyleBackColor = true;
            this.radLop.CheckedChanged += new System.EventHandler(this.radLop_CheckedChanged);
            // 
            // radMSSV
            // 
            this.radMSSV.AutoSize = true;
            this.radMSSV.Location = new System.Drawing.Point(4, 24);
            this.radMSSV.Margin = new System.Windows.Forms.Padding(2);
            this.radMSSV.Name = "radMSSV";
            this.radMSSV.Size = new System.Drawing.Size(55, 17);
            this.radMSSV.TabIndex = 0;
            this.radMSSV.Text = "MSSV:";
            this.radMSSV.UseVisualStyleBackColor = true;
            this.radMSSV.CheckedChanged += new System.EventHandler(this.radMSSV_CheckedChanged);
            // 
            // radHoTen
            // 
            this.radHoTen.Location = new System.Drawing.Point(4, 69);
            this.radHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.radHoTen.Name = "radHoTen";
            this.radHoTen.Size = new System.Drawing.Size(63, 17);
            this.radHoTen.TabIndex = 8;
            this.radHoTen.Text = "Họ Tên:";
            this.radHoTen.UseVisualStyleBackColor = true;
            this.radHoTen.CheckedChanged += new System.EventHandler(this.radHoTen_CheckedChanged);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToResizeColumns = false;
            this.dgvSinhVien.AllowUserToResizeRows = false;
            this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSV_MSSV,
            this.colSV_HoTen,
            this.colSV_GT,
            this.colSV_TenGT,
            this.colSV_NgaySinh,
            this.colSV_CCCD,
            this.colSV_Email,
            this.colSV_DanToc,
            this.colSV_LOP,
            this.colSV_TenLop,
            this.colSV_Nganh,
            this.colSV_TenNganh,
            this.colSV_NienKhoa,
            this.colSV_TenNienKhoa,
            this.colSV_GhiChu,
            this.colSV_DiaChi,
            this.colTrangThai});
            this.dgvSinhVien.Location = new System.Drawing.Point(11, 232);
            this.dgvSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(1183, 249);
            this.dgvSinhVien.TabIndex = 3;
            // 
            // colSV_MSSV
            // 
            this.colSV_MSSV.DataPropertyName = "MSSV";
            this.colSV_MSSV.HeaderText = "MSSV";
            this.colSV_MSSV.MinimumWidth = 6;
            this.colSV_MSSV.Name = "colSV_MSSV";
            this.colSV_MSSV.Width = 94;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.dgvSinhVien);
            this.Name = "frmSinhVien";
            this.Text = "frmSinhVien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpGioiTinh.ResumeLayout(false);
            this.grpGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV_TenGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV_CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV_DanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV_LOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV_TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV_Nganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV_TenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV_NienKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV_TenNienKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV_GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV_GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV_DiaChi;
        private System.Windows.Forms.Label lbltk3;
        private System.Windows.Forms.Label lbltk1;
        private System.Windows.Forms.Label lbltk2;
        private System.Windows.Forms.Label lblSoLuongSVTK;
        private System.Windows.Forms.Label lblTKSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV_HoTen;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.RadioButton radGhiChu;
        private System.Windows.Forms.RadioButton radDanToc;
        private System.Windows.Forms.RadioButton radDiaChi;
        private System.Windows.Forms.RadioButton radEmail;
        private System.Windows.Forms.ComboBox cboNienKhoa;
        private System.Windows.Forms.ComboBox cboNganh;
        private System.Windows.Forms.RadioButton radNganh;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDanToc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.GroupBox grpGioiTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtSoCCCD;
        private System.Windows.Forms.RadioButton radSoCCCD;
        private System.Windows.Forms.RadioButton radNienKhoa;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.RadioButton radLop;
        private System.Windows.Forms.RadioButton radMSSV;
        private System.Windows.Forms.RadioButton radHoTen;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV_MSSV;
    }
}