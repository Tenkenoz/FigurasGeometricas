using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    public partial class FrmHome : Form
    {

        public FrmHome()
        {
            InitializeComponent();
        }
        
        private static FrmSquare square;
        private static FrmRectangle rectangle;
        private static FrmTriangle triangle;

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSquare frm = FrmSquare.Instance;
            frm.MdiParent = this;
            frm.Show();
        }

        private void cuadriangulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectangle frm = FrmRectangle.Instance;
            frm.MdiParent = this;
            frm.Show();
        }

        private void cuadradoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCircle frm = FrmCircle.Instance;
            frm.MdiParent = this;
            frm.Show();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangle frm =FrmTriangle.Instance;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
