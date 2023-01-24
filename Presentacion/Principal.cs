using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Principal : Form
    {
        private int childFormNumber = 0;

        public Principal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        

       

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Visible = true;
            Visible = false;
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripSeparator5_Click(object sender, EventArgs e)
        {

        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpMenu_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void apoderadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmApoderado frm = new FrmApoderado();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FrmAlumno frm = new FrmAlumno();
            frm.MdiParent = this;
            frm.Show();*/
        }

        private void matriculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatriculas frm = new FrmMatriculas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPagos frm = new FrmPagos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frm = new FrmAcercaDe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGrado frm = new FrmGrado();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAula frm = new FrmAula();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNivel frm = new FrmNivel();
            frm.MdiParent = this;
            frm.Show();
        }

        private void seccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSeccion frm = new FrmSeccion();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
