using DevExpress.Drawing.Internal.Fonts.Interop;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
{
    public partial class frmQLTK : DevExpress.XtraEditors.XtraForm
    {
        public frmQLTK()
        {
            InitializeComponent();


        }
        private Form currentForm = null;
        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CloseCurrentForm();
            currentForm = new frmQLTKGV();
            panelTKGV.Controls.Add(currentForm);
            currentForm.Dock = DockStyle.Fill;
            currentForm.Show();

        }
    

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            CloseCurrentForm();
            currentForm = new frmQLTKSV();
            panelTKSV.Controls.Add(currentForm);
            currentForm.Dock = DockStyle.Fill;
            currentForm.Show();
        }

        private void aToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CloseCurrentForm();
            currentForm = new frmQLPhanQuyen();
            panelPhanQuyen.Controls.Add(currentForm);
            currentForm.Dock = DockStyle.Fill;
            currentForm.Show();
        }

        private void CloseCurrentForm()
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
                currentForm = null;
            }
        }

        private void ShowForm(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.Parent = panel;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }
        private void frmQLTK_Load(object sender, EventArgs e)
        {
 
        }

        private void panelTKSV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTKGV_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}