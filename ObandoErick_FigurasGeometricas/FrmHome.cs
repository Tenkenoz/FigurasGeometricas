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

        private void lINESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGraficoLineas frm = FrmGraficoLineas.Instance;
            frm.MdiParent = this;
            frm.Show();

        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEllipse frm = FrmEllipse.Instance;
            frm.MdiParent = this;
            frm.Show();
        }

        private void semicircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSemicircle frm = FrmSemicircle.Instance;
            frm.MdiParent = this;
            frm.Show();
        }

        private void trapezeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapeze frm = FrmTrapeze.Instance;
            frm.MdiParent = this;
            frm.Show();
        }

        private void trapezoidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapezoid frm = FrmTrapezoid.Instance;
            frm.MdiParent = this;
            frm.Show();
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRhombus frm = FrmRhombus.Instance;
            frm.MdiParent = this;
            frm.Show();
        }

        private void rhomboidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRhomboid frm = FrmRhomboid.Instance;
            frm.MdiParent = this;
            frm.Show();
        }

        private void starToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStar frm = FrmStar.Instance;
            frm.MdiParent = this;
            frm.Show();
        }

        private void deltoidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeltoid frm = FrmDeltoid.Instance;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
