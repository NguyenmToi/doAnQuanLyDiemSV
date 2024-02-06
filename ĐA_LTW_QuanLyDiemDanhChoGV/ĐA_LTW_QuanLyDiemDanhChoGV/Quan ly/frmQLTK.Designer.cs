namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
{
    partial class frmQLTK
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
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTKGV = new System.Windows.Forms.Panel();
            this.panelTKSV = new System.Windows.Forms.Panel();
            this.panelPhanQuyen = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.aToolStripMenuItem1,
            this.aToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.aToolStripMenuItem.Text = "Quản lý tài khoản Giảng viên";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(162, 20);
            this.aToolStripMenuItem1.Text = "Quản lý tài khoản sinh viên";
            this.aToolStripMenuItem1.Click += new System.EventHandler(this.aToolStripMenuItem1_Click);
            // 
            // aToolStripMenuItem2
            // 
            this.aToolStripMenuItem2.Name = "aToolStripMenuItem2";
            this.aToolStripMenuItem2.Size = new System.Drawing.Size(122, 20);
            this.aToolStripMenuItem2.Text = "Cấp quyền truy cập";
            this.aToolStripMenuItem2.Click += new System.EventHandler(this.aToolStripMenuItem2_Click);
            // 
            // panelTKGV
            // 
            this.panelTKGV.Location = new System.Drawing.Point(379, 65);
            this.panelTKGV.Name = "panelTKGV";
            this.panelTKGV.Size = new System.Drawing.Size(467, 286);
            this.panelTKGV.TabIndex = 1;
            this.panelTKGV.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTKGV_Paint);
            // 
            // panelTKSV
            // 
            this.panelTKSV.Location = new System.Drawing.Point(80, 214);
            this.panelTKSV.Name = "panelTKSV";
            this.panelTKSV.Size = new System.Drawing.Size(200, 100);
            this.panelTKSV.TabIndex = 0;
            // 
            // panelPhanQuyen
            // 
            this.panelPhanQuyen.Location = new System.Drawing.Point(53, 99);
            this.panelPhanQuyen.Name = "panelPhanQuyen";
            this.panelPhanQuyen.Size = new System.Drawing.Size(227, 82);
            this.panelPhanQuyen.TabIndex = 0;
            // 
            // frmQLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 416);
            this.Controls.Add(this.panelTKSV);
            this.Controls.Add(this.panelPhanQuyen);
            this.Controls.Add(this.panelTKGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQLTK";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.frmQLTK_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem2;
        private System.Windows.Forms.Panel panelTKGV;
        private System.Windows.Forms.Panel panelTKSV;
        private System.Windows.Forms.Panel panelPhanQuyen;
    }
}