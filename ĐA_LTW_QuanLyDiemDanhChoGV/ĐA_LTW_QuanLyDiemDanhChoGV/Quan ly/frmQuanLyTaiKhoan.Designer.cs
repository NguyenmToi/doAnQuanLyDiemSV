namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
{
    partial class frmQuanLyTaiKhoan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýTàiKhoảnGiảngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cấpQuyềnTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnGiảngViênToolStripMenuItem,
            this.quảnLýTàiKhoảnSinhViênToolStripMenuItem,
            this.cấpQuyềnTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýTàiKhoảnGiảngViênToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnGiảngViênToolStripMenuItem.Name = "quảnLýTàiKhoảnGiảngViênToolStripMenuItem";
            this.quảnLýTàiKhoảnGiảngViênToolStripMenuItem.Size = new System.Drawing.Size(170, 20);
            this.quảnLýTàiKhoảnGiảngViênToolStripMenuItem.Text = "Quản lý tài khoản giảng viên";
            // 
            // quảnLýTàiKhoảnSinhViênToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnSinhViênToolStripMenuItem.Name = "quảnLýTàiKhoảnSinhViênToolStripMenuItem";
            this.quảnLýTàiKhoảnSinhViênToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.quảnLýTàiKhoảnSinhViênToolStripMenuItem.Text = "Quản lý tài khoản sinh viên";
            // 
            // cấpQuyềnTàiKhoảnToolStripMenuItem
            // 
            this.cấpQuyềnTàiKhoảnToolStripMenuItem.Name = "cấpQuyềnTàiKhoảnToolStripMenuItem";
            this.cấpQuyềnTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.cấpQuyềnTàiKhoảnToolStripMenuItem.Text = "Cấp quyền tài khoản";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 365);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "Tài khoản";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnGiảngViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cấpQuyềnTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}